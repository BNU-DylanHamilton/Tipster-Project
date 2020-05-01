using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tipster_Project
{
    public partial class tipsterForm : Form
    {
        private double answer, normal, generous, mad, no, tip;

        public tipsterForm()
        {
            InitializeComponent();
            no = 1;
            normal = 1.1;
            generous = 1.15;
            mad = 1.2;
        }

        /// <summary>
        /// This calculates how much people will need to pay,
        /// passes all of the information onto the results
        /// form and then displays all of the needed information
        /// for the user, but will catch any errors on the data
        /// entry part.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculateCosts(object sender, EventArgs e)
        {
            resultsForm newForm = new resultsForm();

            try
            {
                answer = tip / Convert.ToDouble(peopleListBox.SelectedItem);
                newForm.Show();
                newForm.billLabel.Text = billTextBox.Text;
                newForm.peopleLabel.Text = peopleListBox.SelectedItem.ToString();
                newForm.tipTotalLabel.Text = tip.ToString("0.00");
                newForm.totalLabel.Text = "£" + answer.ToString("0.00");
            }
            catch
            {
                MessageBox.Show("Error in Data Entry");
            }
        }

        /// <summary>
        /// This makes sure that the bill amount is entered
        /// in the form first and then adds the tip onto
        /// the bill amount
        /// </summary>
        private void addNoTip(object sender, EventArgs e)
        {
            if (billTextBox.Text == "")
            {
                MessageBox.Show("Please enter the bill amount before selecting a tip.");
            }
            else
            {
                tip = Convert.ToDouble(billTextBox.Text) * no;
            }
        }

        /// <summary>
        /// This makes sure that the bill amount is entered
        /// in the form first and then adds the tip onto
        /// the bill amount
        /// </summary>
        private void addNormalTip(object sender, EventArgs e)
        {
            if (billTextBox.Text == "")
            {
                MessageBox.Show("Please enter the bill amount before selecting a tip.");
            }
            else
            {
                tip = Convert.ToDouble(billTextBox.Text) * normal;
            }
        }

        /// <summary>
        /// This makes sure that the bill amount is entered
        /// in the form first and then adds the tip onto
        /// the bill amount
        /// </summary>
        private void addGenerousTip(object sender, EventArgs e)
        {
            if (billTextBox.Text == "")
            {
                MessageBox.Show("Please enter the bill amount before selecting a tip.");
            }
            else
            {
                tip = Convert.ToDouble(billTextBox.Text) * generous;
            }
        }

        /// <summary>
        /// This makes sure that the bill amount is entered
        /// in the form first and then adds the tip onto
        /// the bill amount
        /// </summary>
        private void addMadTip(object sender, EventArgs e)
        {
            if(billTextBox.Text == "")
            {
                MessageBox.Show("Please enter the bill amount before selecting a tip.");
            }
            else
            {
                tip = Convert.ToDouble(billTextBox.Text) * mad;
            }
        }

        private void closeApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
