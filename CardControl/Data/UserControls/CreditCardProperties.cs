using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CardControl.DTO;
using CardControl.Services;

namespace CardControl.Data.UserControls
{
    public partial class CreditCardProperties : UserControl
    {
        public bool StateChanged;
        private ICreditCardService _service;
        const int CardValidityYear = 7;
        const string PicVisa = "..\\..\\..\\CardControl\\Data\\Pictures\\Visa.png";
        const string PicMasterCard = "..\\..\\..\\CardControl\\Data\\Pictures\\MasterCard.png";
        const string PicDefault = "..\\..\\..\\CardControl\\Data\\Pictures\\CrediCardDefault.png";

        int creditMonth => (int)creditMonthComboBox.SelectedItem;
        int creditYear => (int)creditYearComboBox.SelectedItem;
        string creditNumber => creditCardTextBox.Text;
        string ccv => cvvTextBox.Text;

        #region public methods
        public CreditCardProperties()
        {
            InitializeComponent();
            _service = new CreditCardService(); //TODO move to DI
        }

        public bool Validate() => _service.Vatidate(new Details()
        {
            ExpirationMonth = creditMonth,
            ExpirationYear = creditYear,
            CCV = ccv,
            Number = creditNumber
        });

        public CreditCard GetCreditCard() => _service.GetCreditCard(creditMonth, creditYear, creditNumber, ccv);

        public void Clear()
        {
            _service.Clear(this);
        }

        #endregion

        #region private methods
        void creditCardProperties_Load(object sender, EventArgs e)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            creditMonthComboBox.DataSource = list;

            var yearNow = DateTime.Now.Year;
            list = new List<int> { yearNow };

            for (var i = 0; i < CardValidityYear; i++)
                list.Add(yearNow + i);

            creditYearComboBox.DataSource = list;
        }

        void creditCardTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (creditCardTextBox.Text.Length >= 1)
                return;

            switch (e.KeyChar)
            {
                case '4':
                    {
                        pictureBox1.Image = Image.FromFile(PicVisa);
                        break;
                    }
                case '5':
                    {
                        pictureBox1.Image = Image.FromFile(PicMasterCard);
                        break;
                    }
                default:
                    pictureBox1.Image = Image.FromFile(PicDefault);
                    break;
            }

        }
        #endregion

    }
}
