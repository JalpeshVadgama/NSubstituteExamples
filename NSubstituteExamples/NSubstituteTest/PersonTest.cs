using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using NSubstituteBasicDemo;

namespace NSubstituteTest
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void ToCheck_Whether_Person_FullName_Work_Or_Not()
        {
            //Creating Substiute for person
            var person = Substitute.For<IPerson>();
            
            //Adding a return value
            person.GetFullName("Jalpesh", "Vadgama").Returns("Jalpesh Vadgama");

            //Asserting to check whether its fine or not
            Assert.AreEqual("Jalpesh Vadgama", person.GetFullName("Jalpesh", "Vadgama"));

        }
    }
}
