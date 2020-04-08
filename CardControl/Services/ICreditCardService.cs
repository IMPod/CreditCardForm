using CardControl.Data.UserControls;
using CardControl.DTO;

namespace CardControl.Services
{
    public interface ICreditCardService
    {
        /// <summary>
        /// Check validate object
        /// </summary>
        /// <param name="data">Checked object</param>
        /// <returns>true if all field is valid</returns>
        bool Vatidate(Details data);
        /// <summary>
        /// Get new Details
        /// </summary>
        /// <param name="month">Credit month</param>
        /// <param name="year">Credit year</param>
        /// <param name="number">Credit number</param>
        /// <param name="ccv">Credit ccv</param>
        /// <returns>Filled Details</returns>
        CreditCard GetCreditCard(int month, int year, string number, string ccv);
        /// <summary>
        /// Clear all fields
        /// </summary>
        /// <returns>Empty CreditCardProperties</returns>
        CreditCardProperties Clear(CreditCardProperties data);
    }
}
