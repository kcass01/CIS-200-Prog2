// Program 2
// CIS 200-76
// Fall 2017
// Due: 10/23/2017
// By: D7010

// File: NewLetterForm.cs
// The new letter form is a form to collect data for creating a letter.
// it will validate the data, but not create the letter itself.

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
    public partial class NewLetterForm : Form
    {
        //field variable to hold the list of address used to populate combo box
        private List<Address> addresses = new List<Address>();
        
        //constructor for the form
        //preconditions: none
        //postconditions: the form is created and passed the list of address to work with
        public NewLetterForm(List<Address> passedAddresses)
        {
            InitializeComponent();
            addresses = passedAddresses;
        }

        //load event for the form, populates the combo boxes
        //preconditions: none
        //postconditions: combo boxes have the list of address names
        private void NewLetterForm_Load(object sender, EventArgs e)
        {
            //loop to add each address to the boxes
            foreach(Address a in addresses)
            {
                //only will add the name portions of the address
                fromComboBox.Items.Add(a.Name);
                toComboBox.Items.Add(a.Name);
            }
        }

        //even handler for when confirm button is pressed
        //precondition: none
        //postcondition: data validated, closed if valid
        private void enterButton_Click(object sender, EventArgs e)
        {
            //checks if all is valid
            if (this.ValidateChildren())
            {
                //closes and returns okay if so.
                this.DialogResult = DialogResult.OK;
            }
        }

        //even handler for press of cancel button
        //precondition:none
        //postcondition: form close, creation cancelled.
        private void cancelButton_Click(object sender, EventArgs e)
        {
            //cancels and closes form
            this.DialogResult = DialogResult.Cancel;
        }

        //validation events

         //event handler for validating of combo box
         //precondition: none
         //postcondition: data is tested for validity
        private void comboValidating(object sender, CancelEventArgs e)
        {
            //checks if combo box has selected value
            //uses casting on sender to make more dynamic
            if (((ComboBox)sender).SelectedIndex < 0)
            {
                //sets combo box error
                errorProvider1.SetError((ComboBox)sender, "Select an Address");
                //cancels event to return validation as false
                e.Cancel = true;
            }
        }

        //event handler for when combo box is validated.
        //preconditions: none
        //postconditions: combo validated
        private void comboValidated(object sender, EventArgs e)
        {
            //tests if value is selected
            if(((ComboBox)sender).SelectedIndex >= 0)
            {
                //clears error if none left
                errorProvider1.SetError((ComboBox)sender, "");
            }
        }

        //event for validating of the enetered cost
        //precondition: none
        //postcondition: cost is validated
        private void costValidating(object sender, CancelEventArgs e)
        {
            //checks if price can be parsed, and if it is non negative
            //again uses casting to textbox for reusability
            if (!decimal.TryParse(((TextBox)sender).Text, out decimal cost) || cost < 0)
            {
                //sets error provider message
                errorProvider1.SetError((TextBox)sender, "Enter  a valid cost");
                //cancels event to return validation as false
                e.Cancel = true;
            }
        }

        //event for when cost is validated
        //precondition: none
        //postcondition: error cleared if no error remains
        private void costValidated(object sender, EventArgs e)
        {
            //checks if cost is non zero and a decimal
            if (decimal.TryParse(((TextBox)sender).Text, out decimal cost) && cost >= 0)
            {
                //clears error provider
                errorProvider1.SetError((TextBox)sender, "");
            }
        }

        //properties to pass data back to the entry form
        //property for origin address
        internal Address Origin
        {
            //preconditions: none
            //postconditions: address is returned
            get
            {
                //address is pulled from form, since validation already performed 
                return addresses[fromComboBox.SelectedIndex];
            }
        }

        //property for destination address
        internal Address Destination
        {
            //preconditions: none
            //postconditions: destination returned
            get
            {
                //address pulled from form, since validation already performed.
                return addresses[toComboBox.SelectedIndex];
            }
        }

        //property to hold cost
        internal decimal Cost
        {
            //precondition: none
            //postcondtions: cost is returned
            get
            {
                //cost pulled from text box, since already validated
                return decimal.Parse(costTextBox.Text);
            }
        }

    }
}
