using RestApi.Test;
using RestApi.Test.Requests;
using System.Threading.Tasks;

namespace Wordpress.Automation.Framework.Workflows
{
    public class RegistrationWorkflow
    {
        public async Task<RegistrationWorkflow> Registration()
        {
            await new RegistrationRequest(Apis.Customer)
                 .WithBody($"\\Features\\Registration\\Request\\PostRegistrationRequestBody.json", TestData.User)
                 .SendAsync();

            return this;
        }
    }
}
