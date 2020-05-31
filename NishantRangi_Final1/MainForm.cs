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
    public partial class MainForm : Form
    {
        /// <summary>
        /// Database dataset.
        /// </summary>
        DataSet UserDataSet = null;
        public MainForm()
        {
            try
            {
                InitializeComponent();
                PopulateListViewFromDB();
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// To populate list view from database.
        /// </summary>
        void PopulateListViewFromDB()
        {
            try
            {
                DatabaseService databaseService = new DatabaseService();
                var dataSet = databaseService.GetData("select userid, firstname, lastname, middleName, username from users");
                if (dataSet != null)
                {
                    if (dataSet.Tables.Count > 0)
                    {
                        if (dataSet.Tables[0].Rows.Count > 0)
                        {
                            UserDataSet = dataSet;
                            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                            {
                                UsersListView.Items.Add(new ListViewItem(new string[]
                                {
                                Convert.ToString(dataSet.Tables[0].Rows[i][MySqlColumn.UserId]),
                                Convert.ToString(dataSet.Tables[0].Rows[i][MySqlColumn.FirstName]),
                                Convert.ToString(dataSet.Tables[0].Rows[i][MySqlColumn.LastName]),
                                Convert.ToString(dataSet.Tables[0].Rows[i][MySqlColumn.MiddleName]),
                                Convert.ToString(dataSet.Tables[0].Rows[i][MySqlColumn.UserName])
                                }));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// Event to double click and open user controls forms.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UsersListView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var listView = sender as ListView;
                var selectedUserId = listView.SelectedItems[0].Text;
                DataRow userDataRow = null;
                if (this.UserDataSet != null)
                {
                    if (this.UserDataSet.Tables.Count > 0)
                    {
                        if (this.UserDataSet.Tables[0].Rows.Count > 0)
                        {
                            for (int i = 0; i < this.UserDataSet.Tables[0].Rows.Count; i++)
                            {
                                if (Convert.ToString(this.UserDataSet.Tables[0].Rows[i][MySqlColumn.UserId]) == selectedUserId)
                                {
                                    userDataRow = this.UserDataSet.Tables[0].Rows[i];
                                }
                            }
                        }
                    }
                }
                if (userDataRow != null)
                {
                    AddOrUpdateUserForm addOrUpdateUserForm = new AddOrUpdateUserForm(userDataRow);
                    var result = addOrUpdateUserForm.ShowDialog();
                    if (result == DialogResult.Cancel)
                    {
                        UsersListView.Items.Clear();
                        PopulateListViewFromDB();
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// Event to exit window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
