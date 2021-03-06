using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonDataManagement;
using System.Collections.Generic;

namespace PersonDataManagementTest
{
    [TestClass]
    public class UnitTest1
    {
        DataManagement data;
        [TestInitialize]
        public void TestSetup()
        {
            data = new DataManagement();
            data.CreateList();

        }
        //test method to check whether the average age is equal
        [TestMethod]
        public void AverageAgeTest()
        {
            double expected = 30.428571428571427;
            double actual = data.AverageAge();
            Assert.AreEqual(expected, actual);
        }
        //test method to check the top two data of the persons below 60 years of age
        [TestMethod]
        public void Top2Test()
        {
            List<string> expected = new List<string> { "ram", "arun" };
            List<string> actual = data.RetrivePersonAgeLessThan60();
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        //checking for multiple test cases
        [TestMethod]
        [DataRow("ram", true)]
        [DataRow("arun", true)]
        [DataRow("chan", false)]
        public void SearchPersonTest(string name, bool expected)
        {
            bool actual = data.SpecificDataRetrival(name);
            Assert.AreEqual(expected, actual);
        }
        //skipping the persons whose age are less than 60
        [TestMethod]
        public void SkippingThePerson()
        {
            List<string> expected = new List<string> { "abc", "chen" };
            List<string> actual = data.SkippingPersonAgeLessThan60();
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
