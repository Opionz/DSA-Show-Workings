using NUnit.Framework;

namespace Business.Test
{
    [TestFixture]
    public class SerialPortParserTests
    {
        [Test]
        public void ParsePort_COM1_Returns1()
        {
            SerialPortParser sp = new SerialPortParser();
            int result = sp.ParsePort("COM1");
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void ParsePort_InvalidFormat_ThrowsInvalidFormatException()
        {
            SerialPortParser sp = new SerialPortParser();
            TestDelegate action = () => sp.ParsePort("1");
            Assert.Throws<FormatException>(action);
        }
    }
}
