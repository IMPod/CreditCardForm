using System;
using CardControl.Data.UserControls;
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
        public void DetailsCanBeSet()
        {
            using (var creditCardControl = new CreditCardProperties())
            {
                creditCardControl.Details.Number = "4000000000000001";
                creditCardControl.Details.CCV = "123";
                creditCardControl.Details.ExpirationMonth = 1;
                creditCardControl.Details.ExpirationYear = 2021;
            }
        }

        [TestMethod]
        public void DetailsValidate()
        {
            using (var creditCardControl = new CreditCardProperties())
            {
                creditCardControl.Details.Number = "4000000000000001";
                creditCardControl.Details.CCV = "123";
                creditCardControl.Details.ExpirationMonth = 1;
                creditCardControl.Details.ExpirationYear = 2021;
                Assert.IsTrue(creditCardControl.Validate());

                creditCardControl.Details.Number ="00000001";
                creditCardControl.Details.CCV = "er23";
                creditCardControl.Details.ExpirationMonth = 100;
                creditCardControl.Details.ExpirationYear = 2021;
                Assert.IsFalse(creditCardControl.Validate());

                creditCardControl.Details.Number = "4000000000000001";
                creditCardControl.Details.CCV = "-12";
                creditCardControl.Details.ExpirationMonth = 1;
                creditCardControl.Details.ExpirationYear = 2021;
                Assert.IsFalse(creditCardControl.Validate());
            }
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
