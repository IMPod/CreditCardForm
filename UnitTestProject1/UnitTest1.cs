using System;
using CardControl.DTO;
using CardControl.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodVatidate()
        {
            ICreditCardService service = new CreditCardService();

            // Arrange  
            var data = new Details
            {
                ExpirationMonth = 1,
                ExpirationYear = 2020,
                CCV = "901",
                Number = "4000000000000001"
            };

            // Act
            var el = service.Vatidate(data);

            // Assert
            Assert.IsTrue(el);
        }

        [TestMethod]
        public void TestMethodGetCreditCard()
        {
            ICreditCardService service = new CreditCardService();

            // Arrange  
            var data = new Details
            {
                ExpirationMonth = 1,
                ExpirationYear = 2020,
                CCV = "901",
                Number = "4000000000000001"
            };

            // Act
            var el = service.GetCreditCard(data.ExpirationMonth, data.ExpirationYear, data.Number, data.CCV);

            // Assert
            Assert.IsTrue(el.IsValid);
        }
    }
}
