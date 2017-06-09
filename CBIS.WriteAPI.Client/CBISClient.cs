using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CBIS.WriteAPI.Client.Models;
using CBIS.WriteAPI.Client.Models.Query;
using RestSharp;

namespace CBIS.WriteAPI.Client
{
    public class CBISClient
    {
        public readonly RestSharp.RestClient Client;
        private readonly string Username;
        private readonly string Password;

        public CBISClient(Uri uri, string username, string password)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException(nameof(username));
            }

            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException(nameof(password));
            }

            Client = new RestSharp.RestClient(uri);
            this.Password = password;
            this.Username = username;
        }

        public bool Ping()
        {
            var request = new RestSharp.RestRequest("ping", Method.GET);
            request.AddHeader("username", this.Username);
            request.AddHeader("password", this.Password);

            var ret = Client.Execute<bool>(request);
            return ret.StatusCode != HttpStatusCode.Unauthorized;
        }

        public bool ProductExists(string reference)
        {
            var request = new RestSharp.RestRequest("exists/" + reference, Method.GET);
            request.AddHeader("username", this.Username);
            request.AddHeader("password", this.Password);

            var ret = Client.Execute<bool>(request);
            return ret.Data;
        }

        public ProductWriteResult ArchiveProduct(string reference)
        {
            var request = new RestSharp.RestRequest("archive/" + reference, Method.POST);
            request.AddHeader("username", this.Username);
            request.AddHeader("password", this.Password);

            var ret = Client.Execute<ProductWriteResult>(request);
            return ret.Data;
        }

        public ProductWriteResult SetInformation(string reference, List<Information> setInformations, List<InformationKey> deleteInformationKeys)
        {
            var request = new RestSharp.RestRequest("information/" + reference, Method.POST);
            request.AddHeader("username", this.Username);
            request.AddHeader("password", this.Password);

            request.AddJsonBody(new EditInformation()
            {
                Set = setInformations,
                Delete = deleteInformationKeys
            });

            var ret = Client.Execute<ProductWriteResult>(request);
            return ret.Data;
        }

        public ProductWriteResult CreateProduct(string reference, string name, string parent)
        {
            var request = new RestSharp.RestRequest("create", Method.POST);
            request.AddHeader("username", this.Username);
            request.AddHeader("password", this.Password);

            request.AddJsonBody(new CreateProduct()
            {
                Name = name,
                Product= reference,
                ParentProduct = parent
            });

            var ret = Client.Execute<ProductWriteResult>(request);
            return ret.Data;
        }

        public bool SetMedia(string reference, List<Media> set, List<string> delete)
        {
            var request = new RestSharp.RestRequest("media/" + reference, Method.POST);
            request.AddHeader("username", this.Username);
            request.AddHeader("password", this.Password);

            request.AddJsonBody(new EditMedia()
            {
                Set = set,
                Delete = delete
            });

            var ret = Client.Execute(request);
            return ret.StatusCode == HttpStatusCode.NoContent;
        }

        public bool SetOccasion(string reference, List<Occasion> set, List<Occasion> delete)
        {
            var request = new RestSharp.RestRequest("occasion/" + reference, Method.POST);
            request.AddHeader("username", this.Username);
            request.AddHeader("password", this.Password);

            request.AddJsonBody(new EditOccasion()
            {
                Set = set,
                Delete = delete
            });

            var ret = Client.Execute(request);
            return ret.StatusCode == HttpStatusCode.OK;
        }
    }
}
