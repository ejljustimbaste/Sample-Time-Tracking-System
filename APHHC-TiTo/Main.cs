using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;

namespace APHHC_TiTo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private string rightPassword;
        private string enteredPassword = "";
        private string name;
        User user = new User();
        SQLHandler handler = new SQLHandler();
        DateTime dtNow;


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBreakIn_Click(object sender, EventArgs e)
        {
            dtNow = handler.getDateTime();
            handler.updateBreakIn(user.dailyLogId, dtNow, handler.getBreakID(user.dailyLogId));
            if (handler.getLunchStatus(user.dailyLogId) == "YES")
            {
                handler.updateStatus(user.dailyLogId, "BREAKED-IN, LUNCH TAKEN");
            }
            else
            {
                handler.updateStatus(user.dailyLogId, "BREAKED-IN"); 
            }
            StartSession(user.dailyLogId);
        }

        private void btnBreakOut_Click(object sender, EventArgs e)
        {
            dtNow = handler.getDateTime();
            handler.insertBreakOut(user.dailyLogId, dtNow);
            if (handler.getLunchStatus(user.dailyLogId) == "YES")
            {
                handler.updateStatus(user.dailyLogId, "BREAKED-OUT, LUNCH TAKEN");
            }

            else
            {
                handler.updateStatus(user.dailyLogId, "BREAKED-OUT"); 
            }
            StartSession(user.dailyLogId);
        }

        private void cmbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!(cmbEmployees.SelectedValue.ToString() == null))
                {
                    name = cmbEmployees.SelectedValue.ToString();
                }

                string connStr = ConfigurationManager.ConnectionStrings[1].ConnectionString;
                string queryString = "SELECT Password FROM dbo.tblEmployees WHERE EmployeeName = \'" + name + "\'";

                using (var connection = new SqlConnection(connStr))
                {
                    var command = new SqlCommand(queryString, connection);
                    connection.Open();
                    rightPassword = command.ExecuteScalar().ToString();
                }


                using (Password passForm = new Password())
                {
                    do
                    {
                        passForm.lblEmployee.Text = name;
                        DialogResult dr = passForm.ShowDialog();


                        if (dr == DialogResult.OK)
                        {
                            enteredPassword = passForm.txtPassword.Text;

                            if (Authenticated(enteredPassword))
                            {
                                EnableLogin();
                            }

                            else
                            {
                                MessageBox.Show("Incorrect Password, Are you sure this is your username?");
                            }
                        }

                        if (dr.Equals(DialogResult.Cancel))
                        {
                            break;
                        }
                    } while (!Authenticated(enteredPassword));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




            //if (Authenticate())
            //{

            //}

            //else
            //{
            //    MessageBox.Show("Incorrect Password, Are you sure this is your username?");
            //}
        }

        private void EnableLogin()
        {
            user.Name = name;
            user.Password = rightPassword;
            user.employeeNumber = handler.getEmployeeNumber(user.Name);
            int loginCheck = handler.checkIfTimedIn(user.employeeNumber);
            if (loginCheck == 0)  //User not Timed-In for the day
            {
                btnTimeIn.Enabled = true;
            }

            else
            {
                StartSession(loginCheck);
            }
        }

        private void StartSession(int dailyLogID)
        {
            user.dailyLogId = dailyLogID;
            user.Status = handler.getStatus(dailyLogID);
            switch (user.Status)
            {
                case "TIMED-IN":         // Morning Time-in
                    btnTimeIn.Enabled = false;
                    btnTimeOut.Enabled = true;
                    btnBreakOut.Enabled = true;
                    btnBreakIn.Enabled = false;
                    btnLunchOut.Enabled = true;
                    btnLunchIn.Enabled = false;
                    break;
                case "LUNCHED-OUT":        //Lunch out
                    btnTimeIn.Enabled = false;
                    btnTimeOut.Enabled = false;
                    btnBreakOut.Enabled = false;
                    btnBreakIn.Enabled = false;
                    btnLunchOut.Enabled = false;
                    btnLunchIn.Enabled = true;
                    break;
                case "LUNCHED-IN":        //Lunch in
                    btnTimeIn.Enabled = false;
                    btnTimeOut.Enabled = true;
                    btnBreakOut.Enabled = true;
                    btnBreakIn.Enabled = false;
                    btnLunchOut.Enabled = false;
                    btnLunchIn.Enabled = false;
                    break;
                case "TIMED-OUT":        //Afternoon Time-out
                    btnTimeIn.Enabled = false;
                    btnTimeOut.Enabled = false;
                    btnBreakOut.Enabled = false;
                    btnBreakIn.Enabled = false;
                    btnLunchOut.Enabled = false;
                    btnLunchIn.Enabled = false;
                    break;
                case "BREAKED-OUT":        //Took a break
                    btnTimeIn.Enabled = false;
                    btnTimeOut.Enabled = false;
                    btnBreakOut.Enabled = false;
                    btnBreakIn.Enabled = true;
                    btnLunchOut.Enabled = false;
                    btnLunchIn.Enabled = false;
                    break;
                case "BREAKED-OUT, LUNCH TAKEN":        //Took a break
                    btnTimeIn.Enabled = false;
                    btnTimeOut.Enabled = false;
                    btnBreakOut.Enabled = false;
                    btnBreakIn.Enabled = true;
                    btnLunchOut.Enabled = false;
                    btnLunchIn.Enabled = false;
                    break;
                case "BREAKED-IN":        //Came back from a break
                    btnTimeIn.Enabled = false;
                    btnTimeOut.Enabled = true;
                    btnBreakOut.Enabled = true;
                    btnBreakIn.Enabled = false;
                    btnLunchOut.Enabled = true;
                    btnLunchIn.Enabled = false;
                    break;
                case "BREAKED-IN, LUNCH TAKEN":        //Came back from a break, lunch taken
                    btnTimeIn.Enabled = false;
                    btnTimeOut.Enabled = true;
                    btnBreakOut.Enabled = true;
                    btnBreakIn.Enabled = false;
                    btnLunchOut.Enabled = false;
                    btnLunchIn.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private bool Authenticated(string enteredPass)
        {
            if (rightPassword == enteredPass)
                return true;
            else
                return false;
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aPHHCDataSet.tblEmployees' table. You can move, or remove it, as needed.
            this.tblEmployeesTableAdapter.Fill(this.aPHHCDataSet.tblEmployees);

        }

        private void btnTimeIn_Click(object sender, EventArgs e)
        {
            dtNow = handler.getDateTime();
            handler.insertTimeInAM(user.employeeNumber, dtNow);
            user.dailyLogId = handler.checkIfTimedIn(user.employeeNumber);
            StartSession(user.dailyLogId);
            // Status updated TIMED-IN at SQL table upon insert, as default value for status
        }

        private void btnTimeOut_Click(object sender, EventArgs e)
        {
            dtNow = handler.getDateTime();
            handler.updateTimeOutPM(user.dailyLogId, dtNow);
            StartSession(user.dailyLogId);
        }

        private void btnLunchOut_Click(object sender, EventArgs e)
        {
            dtNow = handler.getDateTime();
            handler.updateTimeOutAM(user.dailyLogId, dtNow);
            handler.updateLunch(user.dailyLogId, "YES");
            StartSession(user.dailyLogId);
        }

        private void btnLunchIn_Click(object sender, EventArgs e)
        {
            dtNow = handler.getDateTime();
            handler.updateTimeInPM(user.dailyLogId, dtNow);
            StartSession(user.dailyLogId);
        }
    }
}
