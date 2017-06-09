using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using CBIS.WriteAPI.Client;
using CBIS.WriteAPI.Client.Models;
using Microsoft.Win32.SafeHandles;

namespace CBIS.WriteAPI.Example
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.SetWindowSize(150, 50);
            bool isLogged = false;

            CBISClient client = null;
            do
            {
                Console.Clear();
                PrintHeader();
                Console.WriteLine("Let's log in first:");
                Console.WriteLine("Username?");
                var userName = Console.ReadLine();
                Console.WriteLine("Password?");
                var password = Console.ReadLine();
                try
                {
                    client = new CBISClient(new Uri("https://ipa.cbis.test.citybreak.com/api/"), userName, password);
                    isLogged = client.Ping();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Endpoint replied:" + e.ToString());
                    Console.WriteLine("Try again.");
                }

                if (!isLogged)
                {
                    Console.WriteLine("Invalid login, try again");
                    Console.ReadLine();
                }
                else
                {
                    break;
                }
                
            } while (true);

            Console.WriteLine("You are now logged in, let's play!");
            Console.ReadLine();
            bool quit = false;
            do
            {
                PrintMenu();
                var action = Console.ReadLine();
                quit = PlayWithAction(action, client);
            } while (!quit);
        }

        private static void PrintMenu()
        {
            Console.Clear();
            PrintHeader();

            Console.WriteLine("Would you like to be yourself?");
            Console.WriteLine();
            Console.WriteLine("\t1. I would like to act as myself");
            Console.WriteLine("\t2. I would like to act as a supplier of myself");
            Console.WriteLine();
        }

        private static void PrintHeader()
        {
            Console.WriteLine(@"____    __    ____ .______       __  .___________. _______         ___      .______    __       ______  __       __   _______ .__   __. .___________.");
            Console.WriteLine(@"\   \  /  \  /   / |   _  \     |  | |           ||   ____|       /   \     |   _  \  |  |     /      ||  |     |  | |   ____||  \ |  | |           |");
            Console.WriteLine(@" \   \/    \/   /  |  |_)  |    |  | `---|  |----`|  |__         /  ^  \    |  |_)  | |  |    |  ,----'|  |     |  | |  |__   |   \|  | `---|  |----`");
            Console.WriteLine(@"  \            /   |      /     |  |     |  |     |   __|       /  /_\  \   |   ___/  |  |    |  |     |  |     |  | |   __|  |  . `  |     |  |     ");
            Console.WriteLine(@"   \    /\    /    |  |\  \----.|  |     |  |     |  |____     /  _____  \  |  |      |  |    |  `----.|  `----.|  | |  |____ |  |\   |     |  |     ");
            Console.WriteLine(@"    \__/  \__/     | _| `._____||__|     |__|     |_______|   /__/     \__\ | _|      |__|     \______||_______||__| |_______||__| \__|     |__|     ");
            Console.WriteLine(@"_____________________________________________________________________________________________________________________________________________________");
            Console.WriteLine();
        }

        private static bool PlayWithAction(string action, CBISClient client)
        {
            int actionAsInt;
            if (!int.TryParse(action, out actionAsInt))
            {
                Console.WriteLine("Could not understand this action, please try again.");
                Console.ReadLine();
                return false;
            }

            switch (actionAsInt)
            {
                case 0:
                    return false;

                case 1:
                    return PrintMenuOrganization(client);

                default:
                    Console.WriteLine("Could not understand this action, please try again.");
                    Console.ReadLine();
                    return false;
            }
        }

        private static bool PrintMenuOrganization(CBISClient client)
        {
            bool quit = false;
            do
            {
                Console.Clear();
                PrintHeader();

                Console.WriteLine("What would you like to do today?");
                Console.WriteLine();
                Console.WriteLine("\t1. Create a new product");
                Console.WriteLine("\t2. Check a product existence");
                Console.WriteLine("\t3. Archive a product");
                Console.WriteLine();
                Console.WriteLine("\t4. Change product description");
                Console.WriteLine("\t5. Remove product description");
                Console.WriteLine();
                Console.WriteLine("\t6. Add a picture on a product");
                Console.WriteLine("\t7. Remove a picture on a product");
                Console.WriteLine();
                Console.WriteLine("\t8. Add an occasion");
                Console.WriteLine();
                Console.WriteLine("\t9. Return home");
                Console.WriteLine("\t0. Quit");
                var action = Console.ReadLine();
                Console.Clear();
                PrintHeader();
                int actionAsInt;
                if (!int.TryParse(action, out actionAsInt))
                {
                    Console.WriteLine("Could not understand this action, please try again.");
                    Console.ReadLine();
                    return false;
                }

                switch (actionAsInt)
                {
                    case 0:
                        Console.WriteLine("Press a key to quit...");
                        Console.ReadLine();
                        return true;

                    case 1:
                        return InitiateProductCreation(client);

                    case 2:
                        try
                        {
                            var ret = client.ProductExists(AskForReference());
                            if (ret)
                            {
                                Console.WriteLine("Product exists!");
                            }
                            else
                            {
                                Console.WriteLine("Product is unknown to the system.");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("An error occured: " + e.ToString());
                        }

                        Console.ReadLine();
                        break;

                    case 3:
                        try
                        {
                            var ret = client.ArchiveProduct(AskForReference());
                            if (ret.HasChanged)
                            {
                                Console.WriteLine("Product has been archived!");
                            }
                            else
                            {
                                Console.WriteLine("No change with that call.");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Archiving failed: " + e.ToString());
                        }

                        Console.ReadLine();
                        break;

                    case 4:
                        CultureInfo cultureInfo = null;
                        do
                        {
                            Console.Write("Which language? (en-us, sv-se, etc...)");
                            var culture = Console.ReadLine();
                            if (!string.IsNullOrEmpty(culture))
                            {
                                try
                                {
                                    cultureInfo = new CultureInfo(culture);
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Could not undestand this language.");
                                }
                            }
                        } while (cultureInfo == null);

                        var factory = new InformationFactory(cultureInfo);
                        Console.Write("Description?");
                        var description = Console.ReadLine();
                        try
                        {
                            var ret = client.SetInformation(AskForReference(), new List<Information>() 
                            {
                                factory.Description(description)
                            }, new List<InformationKey>());
                            if (ret.HasChanged)
                            {
                                Console.WriteLine("Description updated!");
                            }
                            else
                            {
                                Console.WriteLine("No change with that call.");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Description update failed: " + e.ToString());
                        }

                        Console.ReadLine();
                        break;

                    case 5:
                        CultureInfo cultureInfo2 = null;
                        do
                        {
                            Console.Write("Which language? (en-us, sv-se, etc...)");
                            var culture = Console.ReadLine();
                            if (!string.IsNullOrEmpty(culture))
                            {
                                try
                                {
                                    cultureInfo2 = new CultureInfo(culture);
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Could not undestand this language.");
                                }
                            }
                        } while (cultureInfo2 == null);

                        var keyfactory = new InformationKeyFactory(cultureInfo2);

                        try
                        {
                            var ret = client.SetInformation(AskForReference(), new List<Information>(), 
                                                                   new List<InformationKey>()
                                                                   {
                                                                       keyfactory.Description()
                                                                   });
                            if (ret.HasChanged)
                            {
                                Console.WriteLine("Description removed!");
                            }
                            else
                            {
                                Console.WriteLine("No change with that call.");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Description removal failed: " + e.ToString());
                        }

                        Console.ReadLine();
                        break;

                    case 6:
                        Console.Write("Url of the picture?");
                        var url = Console.ReadLine();
                        Console.Write("Reference of the picture?");
                        var externalReference = Console.ReadLine();
                        try
                        {
                            var uri = new Uri(url);
                            client.SetMedia(AskForReference(), new List<Media>() 
                            {
                                new Media(uri, MediaType.Image, true, externalReference)
                            }, new List<string>());
                            Console.WriteLine("Image has been sent for download, it will automatically appear on the product if valid.");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Couldn't set image: " + e.ToString());
                            throw;
                        }
                        break;

                    case 7:
                        Console.Write("Reference of the picture?");
                        var externalReferenceDel = Console.ReadLine();
                        try
                        {
                            client.SetMedia(AskForReference(), new List<Media>(), new List<string>()
                            {
                                externalReferenceDel
                            });
                            Console.WriteLine("Image has been sent for removal, it will automatically appear on the product if valid.");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Couldn't set image: " + e.ToString());
                            throw;
                        }
                        break;

                    case 8:
                        Console.Write("Occasion data: Start 2017-06-10 @10:00 and last 8h" + Environment.NewLine);
                        try
                        {
                            client.SetOccasion(AskForReference(), new List<Occasion>()
                            {
                                new Occasion(new DateTime(2017, 6, 10), null, new TimeSpan(10, 0, 0), new TimeSpan(8, 0, 0),
                                null, false, false, false, false, false, false, false)
                            }, new List<Occasion>());
                            Console.WriteLine("Occasion has been set.");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Couldn't set occasion: " + e.ToString());
                            throw;
                        }
                        break;

                    case 9:
                        quit = true;
                        break;

                    default:
                        Console.WriteLine("Could not understand this action, please try again.");
                        Console.ReadLine();
                        break;
                }
            } while (!quit);

            return false;
        }

        private static string AskForReference()
        {
            Console.WriteLine("Product reference?");
            var id = Console.ReadLine();
            return id;
        }

        private static bool InitiateProductCreation(CBISClient client)
        {
            Console.WriteLine("Let's create that new product!");
            Console.Write("Name?");
            var name = Console.ReadLine();

            Console.WriteLine("Product reference:");
            var reference = Console.ReadLine();

            try
            {
                var ret = client.CreateProduct(reference, name, null);
                Console.WriteLine("Product created with reference: " + ret.Reference.ToString());
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Creation failed: " + e);
                Console.ReadLine();
            }

            return false;
        }
    }
}
