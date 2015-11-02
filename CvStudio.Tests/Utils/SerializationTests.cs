using System;
using System.Linq;
using System.Threading.Tasks;
using CvStudio.Core.Services;
using CvStudio.Core.Services.Interfaces;
using Moq;
using NUnit.Framework;

namespace CvStudio.Tests.Utils
{
    [TestFixture]
    public class SerializationTests
    {
        [Test]
        public async void SerializationTest1()
        {
            var logServiceMoq = new Mock<ILogService>();
            var serializationService = new JsonSerializerService(logServiceMoq.Object);

            var fakeCvService = new FakeCvService();
            var cvs = await fakeCvService.GetAllCvs();

            var cv = cvs.ElementAt(0);

            var json = await serializationService.Serialize(cv);

            Console.WriteLine(json);
        }
    }
}
