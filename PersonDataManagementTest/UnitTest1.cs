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
        [TestMethod]
        public void Top2Test()
        {
            List<string> expected = new List<string> { "ram", "arun" };
            List<string> actual = data.RetrivePersonAgeLessThan60();
            Assert.AreEqual(expected, actual);
        }
    }
}
