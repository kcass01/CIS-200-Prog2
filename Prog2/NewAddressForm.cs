// Program 2
// CIS 200-76
// Fall 2017
// Due: 10/23/2017
// By: D7010

// File: NewAddressForm.cs
// Collects and validates data for a new address.
// does not create the address but rather holds the data

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPVApp
{
    //new address form to appear when the user wants to input a new address.
    public partial class NewAddressForm : Form
    {
        //the constructor for the new address form
        //preconditions: none
        //postconditions: an instance of the form is created. 
        public NewAddressForm()
        {
            InitializeComponent();
        }

        //field variable with min zip
        //pulls from address class for consistency
        public const int MIN_ZIP = Address.MIN_ZIP;
        //field variable with the maximum zip
        //pulls from address class for consistency
        public const int MAX_ZIP = Address.MAX_ZIP;


        //enter button even handler
        //precondition:button clicked
        //postcondition: data validated
        private void enterButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        //cancel button event
        //preconditions: none
        //postconditions: cancels entry and closes form
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            
        }

        //event for validation zip, since it is numeric
        //preconditions:none
        //postconditions: zip validatin returned
        private void zipValidating(object sender, CancelEventArgs e)
        {
            //checks if value is an int, and less than or above max values
            if(!int.TryParse(zipTextBox.Text, out int zip) || zip < MIN_ZIP || zip > MAX_ZIP)
            {
                errorProvider1.SetError((TextBox)sender, "Enter a valid numeric value 00000-99999");
                e.Cancel = true;
            }
        }
        
        //event for evaluating the string values
        //pre:none
        //post:the string will be validated
        private void stringValidating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
                errorProvider1.SetError((TextBox)sender, "Enter a valid string value");
                e.Cancel = true;
            }
        }

        //event for evaluating the combo box value
        //pre:none
        //post:the combo box will be validated
        private void comboValidating(object sender, CancelEventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex < 0)
            {
                errorProvider1.SetError((ComboBox)sender, "Select A State");
                e.Cancel = true;
            }
        }

        //event that occurs after zip is validated
        //pre: valid zip enetered
        //post: error removed
        private void zipValidated(object sender, EventArgs e)
        {
            //checks that zip is a valid int in the desired range
            if (int.TryParse(zipTextBox.Text, out int zip) && (zip >= MIN_ZIP && zip <= MAX_ZIP))
            {
                //clears error provider
                errorProvider1.SetError((TextBox)sender, "");
            }
        }

        //event for validating string
        //pre: string entered
        //post: error cleared
        private void stringValidated(object sender, EventArgs e)
        {
            //checks that the string is not empty or white space
            if (!string.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
                //clears error provider
                errorProvider1.SetError((TextBox)sender, "");
            }
        }

        //event for validating combo box
        //pre: item selected
        //post: error cleared
        private void comboValidated(object sender, EventArgs e)
        {
            //checks if combo has value selected
            //uses casting to make more open
            if (((ComboBox)sender).SelectedIndex >= 0)
            {
                errorProvider1.SetError((ComboBox)sender, "");
            }
        }

        //section for properties to hold neeeded data
        //property for name
        internal string AddressName
        {
            //pre: valid name entered, as confirmed by event
            //post: Name returned
            get
            {
                return nameTextBox.Text;
            }
        }

        //property for line 1
        internal string AddressLineOne
        {
            //pre: valid line 1 entered, as confirmed by event
            //post: line 1 returned
            get
            {
                return lineOneTextBox.Text;
            }
        }

        //property for line 2
        internal string AddressLineTwo
        {
            //pre: valid line 2 entered, as confirmed by event
            //post: line 2 returned
            get
            {
                return lineTwoTextBox.Text;
            }
        }

        //property for city
        internal string City
        {
            //pre: valid city entered, as confirmed by event
            //post: city returned
            get
            {
                return cityTextBox.Text;
            }
        }

        //property for state
        internal string State
        {
            //pre: valid state entered, as confirmed by event
            //post: state returned
            get
            {
                return stateComboBox.SelectedItem.ToString();
            }
        }

        //property for Zip code
        internal int Zip
        {
            //pre: valid zip entered, as confirmed by event
            //no further validation needed since performed by event earlier
            //post: zip returned
            get
            {
                return int.Parse(zipTextBox.Text);
            }
        }

    }
}
