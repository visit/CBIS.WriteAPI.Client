using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CBIS.WriteAPI.Client.Generated;

namespace CBIS.WriteAPI.Client
{
    public class InformationFactory
    {
        private readonly CultureInfo _culture;
        public InformationFactory(CultureInfo culture)
        {
            _culture = culture;
        }

        public Information Name(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 99,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information Introduction(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 101,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information Description(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 102,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information Direction(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 103,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information OpeningHours(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 104,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information Entrence(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 105,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information PhoneNumberString(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 107,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information MobilePhoneString(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 108,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information Email(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 109,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information Website(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 110,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information Other(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 112,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information Latitude(double value)
        {
            return new InformationDouble()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 113,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information Longitude(double value)
        {
            return new InformationDouble()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 114,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information StreetAddress1(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 117,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information StreetAddress2(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 118,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information StreetAddress3(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 119,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information PostalCode(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 120,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information CityAddress(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 121,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information CountryAddress(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 122,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information EventType(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 124,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information EventUrl(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 125,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information BookUrl(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 126,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information AgeLimit(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 127,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information NumRooms(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 130,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information NumFloors(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 131,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information NumConferenceRooms(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 132,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information NumBars(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 133,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information YearBuilt(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 134,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information LastRenovatedYear(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 135,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information KeyPickup(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 136,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information Capacity(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 137,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information FaxAsString(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 138,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information NumSeats(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 139,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information PhoneNumberReception(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 142,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information AreaCodeReception(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 143,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information CountryCodeReception(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 144,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information PhoneNumberBooking(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 145,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information AreaCodeBooking(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 146,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information CountryCodeBooking(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 147,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information CheckInStart(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 148,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information CheckOutEnd(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 149,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information Link360(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 150,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information Classification(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 151,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information ExternalLinks(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 152,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information ContactPersonName(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 160,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information ContactPersonEmail(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 161,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information ContactPersonNotes(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 162,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information NumberOfDoublerooms(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 166,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information NumberOfSuites(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 167,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information NumberOfRoomsWithJacuzzi(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 168,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information NumberOfCommunityRooms(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 169,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information NumberOfDisabledRooms(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 170,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information NumberOfSingleRooms(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 171,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information MaxInCinema(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 172,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information MaxInSchool(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 173,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information NumberOfGroupRooms(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 174,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information KitchenDescription(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 175,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information History(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 177,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information Activities(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 179,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information County(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 180,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information EditorNotes(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 181,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information OpeningHoursReception(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 193,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information WorthSeeing(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 194,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information RoomsInMultipleBuildings(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 196,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information ConferenceDescription(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 197,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information NumberOfFamilyRooms(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 198,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information NumberOfDogRooms(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 199,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information NumberOfStudyRooms(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 200,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information EmailBooking(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 201,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information FaxBookingString(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 202,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information OtherPhoneString(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 203,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information OtherPhoneDetails(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 204,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information MaxNoofConfPart(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 207,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information Noofpeopleinbiggestconferenceroom(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 208,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information Conferencesalespersonname(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 211,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information Conferencesalespersonphone(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 212,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information Conferencesalescellphone(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 213,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information Conferencesalesemail(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 214,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information Conferencesalespersonname2(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 215,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information Conferencesalesphone2(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 216,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information Conferencesalescellphone2(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 217,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information Conferencesalesemail2(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 218,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information Noofpepsinislands(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 219,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information Noofpepsinuseating(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 220,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information Noofroomsforconfparticipants(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 221,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information Noofbedsforconfparticipants(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 222,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information Maxnoofpepsinrestaurant(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 225,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information OrganizerName(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 261,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information CoOrganizer(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 262,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information ReceivingCultureFunds(bool value)
        {
            return new InformationBoolean()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 263,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information Applicationdeadline(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 266,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information Membershiprequired(bool value)
        {
            return new InformationBoolean()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 268,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information Signuprequired(bool value)
        {
            return new InformationBoolean()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 269,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information Externalsignuptext(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 270,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information Externalsignuplink(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 271,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information PhoneNumberBookingString(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 273,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information CopyText(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 274,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information IncludedInCooperation(bool value)
        {
            return new InformationBoolean()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 275,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information SuitableForDisabled(bool value)
        {
            return new InformationBoolean()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 276,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information SignupListEmail(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 288,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information Maxnumberofaccommodation(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 291,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information Zoomlevel(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 297,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information NumberOfPeopleSocializing(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 301,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information NumberOfSeatsOutside(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 302,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information Vimeolink(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 303,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information UniqueSellingPoint1(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 304,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information UniqueSellingPoint2(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 305,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information UniqueSellingPoint3(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 306,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information DistanceFrom(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 309,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information Km(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 310,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information MenuLink(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 314,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information GeneralRules(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 316,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information FacilitiesText(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 322,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information CommercialMessage(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 324,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information Information1(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 325,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information Information2(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 326,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information Information3(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 327,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information DisabledFacilitiesText(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 328,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information ApproximatePrice(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 329,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information ComplementPrice(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 330,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information FreeEntrance(bool value)
        {
            return new InformationBoolean()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 331,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information FreeEntranceText(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 332,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information NantesPass(bool value)
        {
            return new InformationBoolean()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 333,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information NantesPassText(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 334,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information GroupBenefitTitle(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 335,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information GroupBenefitDescription(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 336,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information GroupBenefitContact(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 337,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information GroupBenefitLink(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 338,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information GroupBenefitLinkText(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 339,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information BusinessBenefitTitle(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 340,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information BusinessBenefitDescription(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 341,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information BusinessBenefit(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 342,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information BusinessBenefitLink(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 343,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information BusinessBenefitLinkText(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 344,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information CouncilPublisher(bool value)
        {
            return new InformationBoolean()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 345,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information CouncilPublisherText(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 346,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information OtherLink(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 347,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information OtherLinkText(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 348,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information Municipality(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 356,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information MeetingPoint(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 357,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information MeetingTime(double value)
        {
            return new InformationDouble()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 358,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information NumberOfDepartures(double value)
        {
            return new InformationDouble()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 361,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information TimeForDeparture(double value)
        {
            return new InformationDouble()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 362,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information StartPoint(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 364,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information TransportTime(double value)
        {
            return new InformationDouble()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 366,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information NumberOfRoom(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 371,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information NumberOfBeds(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 372,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information YoungestParticipants(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 373,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information MinWeight(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 374,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information MinHight(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 375,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information MiniAgeYoung(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 381,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information MinWeightYoung(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 382,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information MaxWeightYoung(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 383,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information MiniAgeAdult(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 384,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information MinWeightAdult(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 385,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information MaxWeightAdult(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 386,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information TransportFrom(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 387,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information TransportTo(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 388,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information Equipment(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 389,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information Currency(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 402,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information NumberOfCampingSites(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 403,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information NumberOfRestaurant(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 404,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information NumberOfAppartments(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 405,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information SquareMeter(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 406,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information NumberOfCabins(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 407,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information PriceDescription(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 415,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information CellNumberContact(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 419,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information PhoneNumber(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 421,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information PriceTo(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 422,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information Population(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 424,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information Newspapers(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 425,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information DestinationIso(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 428,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information AirportsIata(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 429,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information Continent(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 430,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information CheckInLatest(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 432,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information Sponsored(bool value)
        {
            return new InformationBoolean()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 434,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information TitlePartner(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 436,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information DescriptionPartner(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 437,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information ContactPartner(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 438,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information WebSitePartner(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 439,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information Partner(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 440,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information State(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 522,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information NumberOfToilets(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 591,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information NumberOfShowers(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 592,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information DistanceToNearestCityInMeters(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 593,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information DistanceToNearestAlpineSlopeInMeters(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 594,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information DistanceToNearestCrossCountryInMeters(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 595,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information DistanceToNearestRiverInMeters(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 596,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information DistanceToNearestCoastInMeters(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 597,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information DistanceToNearestLakeInMeters(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 598,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information DistanceToNearestFishingInMeters(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 599,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information DistanceToNearestBathInMeters(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 600,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information DistanceToNearestGroceryStoreInMeters(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 601,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information DistanceToNearestRestaurantInMeters(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 602,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information NumberOfBedrooms(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 603,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information Howtogettomeetingpoint(bool value)
        {
            return new InformationBoolean()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 630,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information DistanceToNearestLiftInMeters(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 680,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information DistanceToNearestSkiRentalInMeters(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 681,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information PaymentInfo(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 970,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information Facebookpage(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 972,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information Blogpage(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 973,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information Instagrampage(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 974,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information Pinterestpage(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 975,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information ShowExternalUrl(string value)
        {
            return new InformationString()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 979,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }

        public Information Distancecitycentre(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 988,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information DistanceBeachKm(int value)
        {
            return new InformationInteger()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 991,
                    Culture = CultureInfo.InvariantCulture.ToString()
                },
                Value = value
            };
        }

        public Information PriceFrom(double value)
        {
            return new InformationDouble()
            {
                Attribute = new InformationKey()
                {
                    AttributeId = 1012,
                    Culture = _culture.ToString()
                },
                Value = value
            };
        }


    }
}
