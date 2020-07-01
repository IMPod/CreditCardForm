using System;
using CardControl.Data.UserControls;
using CardControl.DTO;

namespace CardControl.Services
{
    public class CreditCardService : ICreditCardService
    {
        public CreditCardProperties Clear(CreditCardProperties data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            data = new CreditCardProperties();

            return data;
        }

        public CreditCard GetCreditCard(int month, int year, string number, string ccv)
        {
            if(Vatidate(new Details{ ExpirationMonth = month,ExpirationYear = year,Number = number, CCV = ccv }))
                return new CreditCard(month, year, number, ccv);
            return null;
        }

        public bool Vatidate(Details data)
        {
            long.TryParse(data.Number, out var numbeResult);
            var isNumberValid = data.Number.Length == 16 && numbeResult != 0;
            int.TryParse(data.CCV, out var ccv);

            var isCCVValid = data.CCV.Length == 3 && ccv >= 0;
            var isMonthValid = data.ExpirationMonth != 0;
            var isYearValid = data.ExpirationYear != 0;

            return isNumberValid && isCCVValid && isMonthValid && isYearValid;
        }

    }
}
