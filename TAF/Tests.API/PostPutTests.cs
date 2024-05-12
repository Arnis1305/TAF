using Models;
using Core.API.ServiceHelpers;
using FluentAssertions;

namespace Tests.API
{
    [TestFixture]
    public class PostPutTests : BaseAPITest
    {
        [TestCase(2, "zion resident")]
        public void CheckPutUserInfo(int userNumber, string expectedResult)
        {
            WorkerData workerData = UserServiceHelper.PutSingleUserInformation(userNumber);

            workerData.Job.Should().Contain(expectedResult);
        }

        [TestCase(2, "leader")]
        public void CheckPostUserInfo(int userNumber, string expectedResult)
        {
            WorkerData workerData = UserServiceHelper.PostSingleUserInformation(userNumber);

            workerData.Job.Should().Contain(expectedResult);
        }
    }
}