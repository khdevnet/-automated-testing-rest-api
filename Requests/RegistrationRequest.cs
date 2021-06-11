using System.Net.Http;
using System.Threading.Tasks;
using RestApi.Test.Core;

namespace RestApi.Test.Requests
{
    public class RegistrationRequest
    {
        private readonly string host;
        private StringContent body;

        public RegistrationRequest(string host)
        {
            this.host = host;
        }

        public RegistrationRequest WithBody(string bodyPath, object userData)
        {
            this.body = Extensions
                .ReadAllText(bodyPath)
                .RenderTags(userData)
                .ToJsonContent();
            return this;
        }

        public Task<HttpResponseMessage> SendAsync()
        {
            return new HttpClient().PostAsync($"{host}/registration", body);
        }
    }
}
