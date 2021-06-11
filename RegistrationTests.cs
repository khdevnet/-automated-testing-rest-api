using ApprovalTests;
using ApprovalTests.Reporters;
using RestApi.Test.Core;
using RestApi.Test.Requests;
using Stubble.Core;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace RestApi.Test
{
    public class RegistrationTests : XunitApprovalBase
    {
        [Fact]
        public async Task PostRegistration()
        {
            var responseBody = await new RegistrationRequest(Apis.Customer)
                  .WithBody($"\\Features\\Registration\\Request\\PostRegistrationRequestBody.json", TestData.User)
                  .SendAsync();
        }


        public RegistrationTests(ITestOutputHelper testOutput) :
            base(testOutput)
        {
        }

        public static string JsonPrettify(string json)
        {
            var jDoc = JsonDocument.Parse(json);
            return JsonSerializer.Serialize(jDoc, new JsonSerializerOptions { WriteIndented = true });
        }
    }
}
