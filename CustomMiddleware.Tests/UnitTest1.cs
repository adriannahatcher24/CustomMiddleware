using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace CustomMiddleware.Tests
{
    public class MiddlewareTests
    {
        private readonly HttpClient _client;

        public MiddlewareTests()
        {
            _client = new HttpClient();
        }

        [Fact]
        public async Task Test_Unauthorized_When_NoCredentialsProvided()
        {
            var response = await _client.GetAsync("https://localhost:XXXX/");
            Assert.Equal(System.Net.HttpStatusCode.Unauthorized, response.StatusCode);
        }

    }
}
