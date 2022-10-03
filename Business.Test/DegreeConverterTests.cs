using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Test
{
    [TestFixture]
    public class DegreeConverterTests
    {
        [Test]
        public void CheckIfFahrenheit_NotNull()
        {
            DegreeConverter degreeConverter = new DegreeConverter();
            Assert.IsNotNull(degreeConverter);
        }

        [Test]
        public void CheckIfCelsius_NotNull()
        {
            DegreeConverter degreeConverter = new DegreeConverter();
            Assert.IsNotNull(degreeConverter);
        }
    }
}
