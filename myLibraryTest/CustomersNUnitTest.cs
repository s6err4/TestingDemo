using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLibrary
{
    [TestFixture]
    public class CustomersNUnitTest
    {
        [Test]
        public void FullName_ReturnEmpty()
        {
            //1. Arrange
            Customer customer = new Customer();

            //2. Act
            String result = customer.FullName;

            //3. Assert
            Assert.That(result, Is.EqualTo(" "));
        }

        [Test]
        public void FullName_ReturnFullName()
        {
            Customer customer = new Customer
            {
                FirstName = "Andres",
                LastName = "Sierra"

            };
            String result = customer.FullName;


            Assert.That(result, Is.Not.EqualTo(" "));
            Assert.That(result, Is.EqualTo("Andres Sierra").IgnoreCase);

        }
    }
}
    
