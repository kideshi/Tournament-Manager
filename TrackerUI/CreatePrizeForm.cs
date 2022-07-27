using System;
using System.Windows.Forms;
using ManagerLibrary;
using ManagerLibrary.DataAccess;
using ManagerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (IsValidForm())
            {
                PrizeModel prizeModel = new PrizeModel(
                    placeNumberValue.Text,
                    placeNameValue.Text,
                    prizeAmountValue.Text,
                    prizePercentageValue.Text);

                GlobalConfig.Connection.CreatePrize(prizeModel);

                placeNumberValue.Text = "";
                placeNameValue.Text = "";
                prizeAmountValue.Text = "0";
                prizePercentageValue.Text = "0";
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        private bool IsValidForm()
        {
            bool output = true;
            int placeNumber = 0;
            double prizePercentage = 0;
            decimal prizeAmount = 0;
            bool placeNumberValidValue = int.TryParse(placeNumberValue.Text, out placeNumber);
            bool prizePercentageValid = double.TryParse(prizePercentageValue.Text, out prizePercentage);
            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);

            if (!placeNumberValidValue || placeNumber < 1)
            {
                output = false;
            }

            if (placeNameValue.Text.Length == 0)
            {
                output = false;
            }

            if (!prizeAmountValid || !prizePercentageValid)
            {
                output = false;
            }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }

            return output;
        }
    }
}
