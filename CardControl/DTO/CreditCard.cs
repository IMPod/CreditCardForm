namespace CardControl.DTO
{
    public class CreditCard
    {
        public CreditCard(int month, int year, string number, string ccv)
        {
            Details = new Details()
            {
                ExpirationMonth = month,
                ExpirationYear = year,
                CCV = ccv,
                Number = number
            };
            IsValid = true;
        }
        public Details @Details { get; set; }
        public bool IsValid {get;} 

    }
}
