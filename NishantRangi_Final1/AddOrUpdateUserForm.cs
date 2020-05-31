using NishantRangi_Final1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NishantRangi_Final1
{
    // Todo: details based on word doc
    public partial class AddOrUpdateUserForm : Form
    {
        /// <summary>
        /// Form data row.
        /// </summary>
        DataRow userDataRow = null;
        public AddOrUpdateUserForm(DataRow userDataRow)
        {
            try
            {
                InitializeComponent();
                if (userDataRow != null)
                {
                    this.userDataRow = userDataRow;
                }
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// Event to close user controls dialog box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
            }
        }


        /// <summary>
        /// Form load event to populate user control data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddOrUpdateUserForm_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateFormData();
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// To populate form data.
        /// </summary>
        void PopulateFormData()
        {
            try
            {
                if (this.userDataRow != null)
                {
                    FisrtNameTextBox.Text = Convert.ToString(this.userDataRow[MySqlColumn.FirstName]);
                    LastNameTextBox.Text = Convert.ToString(this.userDataRow[MySqlColumn.LastName]);
                    MiddleNameTextBox.Text = Convert.ToString(this.userDataRow[MySqlColumn.MiddleName]);
                    UserNameTextBox.Text = Convert.ToString(this.userDataRow[MySqlColumn.UserName]);
                }
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// Event to save or update user data in database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = FisrtNameTextBox.Text;
                string lastName = LastNameTextBox.Text;
                string middleName = MiddleNameTextBox.Text;
                string userName = UserNameTextBox.Text;

                string query = "update " + Table.Users + " set "
                                + MySqlColumn.FirstName + "='" + firstName + "', "
                                + MySqlColumn.LastName + "='" + lastName + "', "
                                + MySqlColumn.MiddleName + "='" + middleName + "', "
                                + MySqlColumn.UserName + "='" + userName +"'"
                                + " where " + MySqlColumn.UserId + "=" + this.userDataRow[MySqlColumn.UserId] + "";
                DatabaseService databaseService = new DatabaseService();
                bool isSuccess = databaseService.AddOrUpdateData(query);
                if (isSuccess)
                {
                    this.userDataRow[MySqlColumn.FirstName] = firstName;
                    this.userDataRow[MySqlColumn.LastName] = lastName;
                    this.userDataRow[MySqlColumn.MiddleName] = middleName;
                    this.userDataRow[MySqlColumn.UserName] = userName;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
