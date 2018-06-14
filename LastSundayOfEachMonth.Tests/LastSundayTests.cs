using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastSundayOfEachMonth.Tests
{
    [TestFixture]
    public class LastSundayTests
    {

        [TestCase("2018-01-28", 2018, 0)]
        [TestCase("2018-02-25", 2018, 1)]
        [TestCase("2018-03-25", 2018, 2)]
        public void Find_GivenYear2018_ShouldReturnLastSundayOfAMonth(string expected ,int year,int index)
        {
            //---------------Arrange-------------------
            var sut = CreateLastSunday();   
            //---------------Act ----------------------
            var actual = sut.FindLastSunday(year);
            //---------------Assert -----------------------
            Assert.AreEqual(expected, actual[index]);
        }

        [Test]
        public void Find_GivenYear2018_ShouldReturnLastSundayOfTheFirst4Months()
        {
            //---------------Arrange-------------------
            var sut = CreateLastSunday();
            var expected = "2018-01-28\n2018-02-25\n2018-03-25\n2018-04-29";
            //---------------Act ----------------------
            var actual = sut.FindLastSunday(2018);
            //---------------Assert -----------------------
            Assert.AreEqual(expected, actual[0] + "\n" + actual[1] + "\n" + actual[2] + "\n" + actual[3]);
        }
      
        [Test]
        public void Find_GivenYear2018_ShouldReturnLastSundayOfTheFirst5Months()
        {
            //---------------Arrange-------------------
            var sut = CreateLastSunday();
            var expected = "2018-01-28\n2018-02-25\n2018-03-25\n2018-04-29\n2018-05-27";
            //---------------Act ----------------------
            var actual = sut.FindLastSunday(2018);
            //---------------Assert -----------------------
            Assert.AreEqual(expected, actual[0] + "\n" + actual[1] + "\n" + actual[2] + "\n" + actual[3] + "\n" + actual[4] );
        }


        [Test]
        public void Find_GivenYear2018_ShouldReturnLastSundayOfTheFirst9Months()
        {
            //---------------Arrange-------------------
            var sut = CreateLastSunday();
            var expected = "2018-01-28\n2018-02-25\n2018-03-25\n2018-04-29\n2018-05-27\n2018-06-24\n2018-07-29\n2018-08-26\n2018-09-30";
            //---------------Act ----------------------
            var actual = sut.FindLastSunday(2018);
            //---------------Assert -----------------------
            Assert.AreEqual(expected, actual[0] + "\n" + actual[1] + "\n" + actual[2] + "\n" + actual[3] + "\n" + actual[4] + "\n" + actual[5] + "\n" + actual[6] + "\n" + actual[7] + "\n" + actual[8]);
        }

        [Test]
        public void Find_GivenYear2018_ShouldReturnLastSundayOfEachMonth()
        {
            //---------------Arrange-------------------
            var sut = CreateLastSunday();
            var expected = "2018-01-28\n2018-02-25\n2018-03-25\n2018-04-29\n2018-05-27\n2018-06-24\n2018-07-29\n2018-08-26\n2018-09-30\n2018-10-28\n2018-11-25\n2018-12-30";
            //---------------Act ----------------------
            var actual = sut.FindLastSunday(2018);
            //---------------Assert -----------------------
            Assert.AreEqual(expected, actual[0] + "\n" + actual[1] + "\n" + actual[2] + "\n" + actual[3] + "\n" + actual[4] + "\n" + actual[5] + "\n" + actual[6] + "\n" + actual[7] + "\n" + actual[8] + "\n" + actual[9] + "\n" + actual[10] + "\n" + actual[11]);
        }

        [Test]
        public void Find_GivenYear2013_ShouldReturnLastSundayOfEachMonth()
        {
            //---------------Arrange-------------------
            var sut = CreateLastSunday();
            var expected = "2013-01-27\n2013-02-24\n2013-03-31\n2013-04-28\n2013-05-26\n2013-06-30\n2013-07-28\n2013-08-25\n2013-09-29\n2013-10-27\n2013-11-24\n2013-12-29";
            //---------------Act ----------------------
            var actual = sut.FindLastSunday(2013);
            //---------------Assert -----------------------
            Assert.AreEqual(expected, actual[0] + "\n" + actual[1] + "\n" + actual[2] + "\n" + actual[3] + "\n" + actual[4] + "\n" + actual[5] + "\n" + actual[6] + "\n" + actual[7] + "\n" + actual[8] + "\n" + actual[9] + "\n" + actual[10] + "\n" + actual[11]);
        }

        [TestCase("2020-02-23", 2020, 1)]
        [TestCase("2024-02-25", 2024, 1)]
        [TestCase("2032-02-29", 2032, 1)]
        public void Find_GivenLeapYears_ShouldReturnLastSundayOfFeb(string expected, int year, int index)
        {
            //---------------Arrange-------------------
            var sut = CreateLastSunday();
            //---------------Act ----------------------
            var actual = sut.FindLastSunday(year);
            //---------------Assert -----------------------
            Assert.AreEqual(expected, actual[index]);
        }

        private static LastSunday CreateLastSunday()
        {
            return new LastSunday();
        }
    }
}
