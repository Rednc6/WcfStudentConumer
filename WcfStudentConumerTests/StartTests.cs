using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfStudentConumer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfStudentConumer.WcfServiceReference;


namespace WcfStudentConumer.Tests
{
    [TestClass()]
    public class StartTests
    {
        [TestMethod()]
        public void starttahthingyTest()
        {
            Student x = new Student
            {
                _personID = 1,
                _firstName = "Dick",
                _lastName = "Peter",
                _address =  "Hell",
                _city = "Paradise Lost"
            };



            Assert.IsInstanceOfType(x, typeof(Student));
        }
    }
}