using System.Diagnostics.Eventing.Reader;
using System.Globalization;

namespace TAN.ComparePopulation.UI
{
    public partial class frmComparePopulation : Form
    {
        public frmComparePopulation()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Declare, validate, and assign Variables
            double dblStartingPop;
            double.TryParse(txtStartingPop.Text, out dblStartingPop);

            double dblEndingPop;
            double.TryParse(txtEndingPop.Text, out dblEndingPop);

            double dblPercentIncrease;
            double dblPercentDecrease;

            double dblFactor;

            int intStateAbbr;
            intStateAbbr = (txtState).TextLength;

            try
            {
                if (string.IsNullOrEmpty(txtCity.Text))
                {
                    //Message Box for if city or state textboxes left blank
                    MessageBox.Show("Please enter a City and State", "Error",
                                    MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);

                    //Return Cursor to City Textbox
                    txtCity.Focus();
                    txtCity.SelectAll();
                }
                else if (string.IsNullOrEmpty(txtState.Text))
                {
                    //Message Box for if city or state textboxes left blank
                    MessageBox.Show("Please enter a City and State", "Error",
                                    MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);

                    //Return Cursor to City Textbox
                    txtState.Focus();
                    txtState.SelectAll();
                }
                else if (intStateAbbr < 2)
                {
                    //Message Box for if State textbox has 1 character in it
                    MessageBox.Show("State textbox must contain TWO letters.", "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                    //Return Cursor to State Textbox
                    txtState.Focus();
                    txtState.SelectAll();
                }
                else if (double.TryParse(txtStartingPop.Text, out dblStartingPop) && double.TryParse(txtEndingPop.Text, out dblEndingPop))
                {
                    // Check to see if negative number was entered
                    if (dblStartingPop > 0 && dblEndingPop >= 0)
                    {

                        if (dblStartingPop > dblEndingPop)
                        {
                            //Do Math
                            dblFactor = (dblStartingPop - dblEndingPop);
                            dblPercentDecrease = dblFactor / dblStartingPop;

                            //Display Result
                            lblPercentDecrease.Text = dblPercentDecrease.ToString("p");

                            //Message Box for Pop Decrease
                            MessageBox.Show("Decrease in Population for " + txtCity.Text + ", " + txtState.Text);

                            //Return Cursor to Starting Pop
                            txtStartingPop.Select();
                            txtStartingPop.Focus();
                        }

                        else if (dblStartingPop < dblEndingPop)
                        {
                            //Do Math
                            dblFactor = dblEndingPop - dblStartingPop;
                            dblPercentIncrease = dblFactor / dblStartingPop;

                            //Display Result
                            lblPercentIncrease.Text = dblPercentIncrease.ToString("p");

                            //Message Box for Pop Increase
                            MessageBox.Show("Increase in Population for " + txtCity.Text + ", " + txtState.Text);

                            //Return Cursor to Starting Pop
                            txtStartingPop.Select();
                            txtStartingPop.Focus();
                        }
                        else
                        {

                            //Do Math for No increase 
                            dblFactor = dblEndingPop - dblStartingPop;
                            dblPercentIncrease = dblFactor / dblStartingPop;

                            //Display Result
                            lblPercentIncrease.Text = dblPercentIncrease.ToString("p");

                            //Do Math
                            dblFactor = (dblStartingPop - dblEndingPop);
                            dblPercentDecrease = dblFactor / dblStartingPop;

                            //Display Result
                            lblPercentDecrease.Text = dblPercentDecrease.ToString("p");

                            //Message box for no change in pop
                            MessageBox.Show("There was no increase or decrease for " + txtCity.Text + ", " + txtState.Text);

                            //Return Cursor to Starting Pop
                            txtStartingPop.Select();
                            txtStartingPop.Focus();
                        }
                    }
                    else if (dblStartingPop == 0)
                    {
                        //Message Box if a zero is entered in starting pop
                        MessageBox.Show("Percent change is undefined when the starting quantity is ZERO",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);

                        //Return Cursor to Starting Pop
                        txtStartingPop.SelectAll();
                        txtStartingPop.Focus();
                    }
                    else
                    {
                        //Keep Increase and Decrease Labels Empty
                        lblPercentDecrease.Text = String.Empty;
                        lblPercentIncrease.Text = String.Empty;

                        //Error message when a negative number is entered
                        MessageBox.Show("Negative numbers are not allowed, please enter a positive number",
                                                   "Error", MessageBoxButtons.OK,
                                                   MessageBoxIcon.Error);

                        //Return Cursor to Starting Pop
                        txtStartingPop.Select();
                        txtStartingPop.Focus();
                    }
                }
                else
                {
                    //Display Error Message to user
                    MessageBox.Show("Please enter numeric values");

                    //Return Cursor to Starting Pop
                    txtStartingPop.Select();
                    txtStartingPop.Focus();
                }
            }
            catch (Exception ex)
            {

                //Display Error Information to user
                MessageBox.Show(ex.Message);

                //Return Cursor to Starting Pop
                txtStartingPop.Select();
                txtStartingPop.Focus();

            }

        }

        private void txtState_TextChanged(object sender, EventArgs e)
        {
            //Limit txtState to 2 characters
            txtState.MaxLength = 2;

            //Clear calculated data
            lblPercentDecrease.Text = string.Empty;
            lblPercentIncrease.Text = string.Empty;

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            //Clear calculated data
            lblPercentDecrease.Text = string.Empty;
            lblPercentIncrease.Text = string.Empty;
        }

        private void txtStartingPop_TextChanged(object sender, EventArgs e)
        {
            //Clear calculated data
            lblPercentDecrease.Text = string.Empty;
            lblPercentIncrease.Text = string.Empty;
        }

        private void txtEndingPop_TextChanged(object sender, EventArgs e)
        {
            //Clear calculated data
            lblPercentDecrease.Text = string.Empty;
            lblPercentIncrease.Text = string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear the calculations and inputs
            txtCity.Text = string.Empty;
            txtCity.Focus();
            txtState.Text = string.Empty;

            txtStartingPop.Text = string.Empty;
            txtEndingPop.Text = string.Empty;

            lblPercentDecrease.Text = string.Empty;
            lblPercentIncrease.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close the App
            Application.Exit();
        }
    }
}
