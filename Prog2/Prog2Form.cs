// Program 2
// CIS 200-76
// Fall 2017
// Due: 10/23/2017
// By: D7010

// File: Prog2Form.cs
// The program 2 form serves as the main form of the application
// and will launch the other forms

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
    public partial class Prog2Form : Form
    {
        public Prog2Form()
        {
            InitializeComponent();

            //add example data to holder
            // Test Data - Magic Numbers OK - taken from prog ab solution
            currentView.AddAddress("John Smith", "123 Any St.", "Apt. 45",
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            currentView.AddAddress("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            currentView.AddAddress("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            currentView.AddAddress("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            currentView.AddAddress("John Doe", "111 Market St.",
                "Jeffersonville", "IN", 47130); // Test Address 5
        }

        //field variable to hold Grading ID
        private const string GRADING_ID = "D7010";
        //field to hold section number
        private const string SECTION_NUMBER = "CIS 200-76";

        //create an instance of the business logic class
        UserParcelView currentView = new UserParcelView();

        //event handler for the about button click
        //preconditions: none
        //postconditions: grager's information returned.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //shows a messagebox with information, has an information icon
            MessageBox.Show("Grading ID: "+ GRADING_ID + Environment.NewLine + "Section: "+SECTION_NUMBER, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //event handler for the exit button
        //preconditions: none
        //Postconditions: program closes
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //closes the form and program
            this.Close();
        }

        //event handler for clicking of add address menu item
        //pre:buttomn clicked
        //post: launch form for creating new address
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create an instance of the form
            NewAddressForm inputForm = new NewAddressForm();
            //show the form as a dialogue box
            inputForm.ShowDialog();
            //if the dialogue is returned as successful
            if (inputForm.DialogResult == DialogResult.OK)
            {
                //checks if 2nd string was a valid value, if so has two address lines
                if (String.IsNullOrWhiteSpace(inputForm.AddressLineTwo))
                {
                    currentView.AddAddress(inputForm.AddressName, inputForm.AddressLineOne,
                        inputForm.City, inputForm.State, inputForm.Zip);
                }
                //otherwise defaults to 1 address line
                else
                {
                    currentView.AddAddress(inputForm.AddressName, inputForm.AddressLineOne,
                        inputForm.AddressLineTwo, inputForm.City, inputForm.State, inputForm.Zip);
                }
            }
        }


        //event handler for when the new letter button is pressed 
        //preconditions: none
        //postconditions: letter dialogue shown, new letter may be added.
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create instance of new letter class
            NewLetterForm inputLetter = new NewLetterForm(currentView.AddressList);
            //launch as a dialoge
            inputLetter.ShowDialog();
            //if all data from the form is valid
            if (DialogResult.OK == inputLetter.DialogResult)
            {
                //creates an instance of the letter in the business logic
                currentView.AddLetter(inputLetter.Origin, inputLetter.Destination, inputLetter.Cost);
            }
        }

        //event handler for address report button
        //preconditions: none
        //postconditions: report is displayed to form
        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //clears the textbox first for new data
            reportTextBox.Clear();
            //loop to print each address in the list to the box.
            foreach(Address a in currentView.AddressList)
            {
                reportTextBox.Text += a.ToString() + Environment.NewLine + 
                    "-------------------------------------------------" + Environment.NewLine;
            }
        }

        //event handler for parcel report button
        //preconditions: none
        //postconditions: report is displayed to form
        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //again starts by clearing the text box
            reportTextBox.Clear();
            //loop that will print the tostring of each parcel to the box.
            foreach (Parcel p in currentView.ParcelList)
            {
                reportTextBox.Text += p.ToString() + Environment.NewLine +
                    "-------------------------------------------------" + Environment.NewLine;
            }
        }
    }
}
