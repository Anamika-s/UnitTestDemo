using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestFixture]
    internal class EmployeeTest
    {
        NumericLibrary.Employee employee;
        [SetUp]
        public void Setup()
        {
            employee = new NumericLibrary.Employee();
        }
        [TestCase("HR", 11, "Max 10 Leaves allowed")]
        [TestCase("HR", 9, "Only 6 Leaves allowed")]
        [TestCase("Accts", 11, "Only 6 Leaves allowed")]
        [TestCase("IT", 11, "No Leaves")]

        public void GetLeavesTest(string dept, int exp, string expected)
        {
            string actual = employee.GetLeaves(dept, exp);
            Assert.AreEqual(expected, actual);
        }


        // Moq Testing

        [Test]
        public void AddCustomer()
        {
            Mock<NumericLibrary.EMail> obj = new Mock<NumericLibrary.EMail>();
            obj.Setup(x => x.SendEmail()).Returns(true);
            NumericLibrary.Employee employee = new NumericLibrary.Employee();
            bool actual = employee.AddCustomer(obj.Object);
            Assert.AreEqual(true, actual);
        }


    }
}

