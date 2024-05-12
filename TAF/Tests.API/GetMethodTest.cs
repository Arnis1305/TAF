using Core.API.ServiceHelpers;
using FluentAssertions;

namespace Tests.API
{
    [TestFixture]
    public class GetMethodTest : BaseAPITest
    {
        [TestCase(2, "janet.weaver@reqres.in")]
        public void CheckGetSingleUserInfo(int userNumber, string userEmail)
        {
            var userData = UserServiceHelper.GetSingleUserInfo(userNumber);

            userData.Data.Email.Should().Contain(userEmail);
        }

        [TestCase(23, 404)]
        public void CheckGetSingleUserNotFound(int userNumber, int statusCode)
        {
            var response = UserServiceHelper.GetSingleUserNotFoundResponseCode(userNumber);

            response.Should().Be((System.Net.HttpStatusCode)statusCode);
        }
    }
}