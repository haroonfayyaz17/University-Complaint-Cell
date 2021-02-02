using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StartPage
{
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\haroongaba;Initial Catalog=UniversityComplaintCell;Integrated Security=True;MultipleActiveResultSets=True");
        String id, Mname = "", Dname = "", designation = "";

        void IntializeLables(Panel panel)
        {
            foreach (Control c in panel.Controls)
            {
                if (c.GetType() == typeof(TextBox) || c.GetType() == typeof(RichTextBox))
                    c.Text = "";
            }
            complaintIDLbl.Text = "Complaint No: ";
            nameLbl.Text = "Name:";
            CEmailLbl.Text = "Email:";
            contactNoLbl.Text = "Contact No:";
            C_TypeLbl.Text = "Employee/Student:";
            departmentLbl.Text = "Department:";
            DateLbl.Text = "Date:";
        }
        void IntializeMemberPanelLabels()
        {
            MNamelbl.Text = "Name:";
            EMaillbl.Text = "Email:";
            DnameLbl.Text = "Department Name: ";
            designationLbl.Text = "Designation: ";

        }
        void MemberPanelExecutionCommands()
        {
            IntializeMemberPanelLabels();
            string query;

            try
            {
                if (designation.ToLower() == "director")
                    query = "select c.Comp_ID AS 'Complaint No.',n.Email As 'Complainant Email',c.title As 'Complaint Title',c.c_date As 'Date',c.c_status As 'Status' from Complaint c,Complainant n where c.C_Email=n.Email";
                else
                    query = "select c.Comp_ID AS 'Complaint No.',n.Email As 'Complainant Email',c.title As 'Complaint Title',c.c_date As 'Date',c.c_status As 'Status' from Complaint c,Complainant n where c.DeptName=(Select Dname from Member where Email='" + memberEmailtxt.Text + "') AND c.C_Email=n.Email";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                complaintGrid.DataSource = dt;
                if (Dname == "")
                    DnameLbl.Visible = false;
                else
                    DnameLbl.Visible = true;
                MNamelbl.Text = MNamelbl.Text + " " + Mname;
                EMaillbl.Text = EMaillbl.Text + " " + memberEmailtxt.Text;
                DnameLbl.Text = DnameLbl.Text + " " + Dname;
                designationLbl.Text = designationLbl.Text + " " + designation;
            }
            catch (Exception ex)
            { }

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string login = "Select name,email,Dname,RTRIM(designation) As designation from Member where (Email ='" + memberEmailtxt.Text + "')";
                SqlCommand cmd = new SqlCommand(login, con);
                SqlDataReader reader = cmd.ExecuteReader();
                int c = 0;
                string query;

                while (reader.Read())
                {
                    Mname = Convert.ToString(reader["Name"]);
                    Dname = Convert.ToString(reader["Dname"]);
                    designation = Convert.ToString(reader["designation"]);
                    c++;
                }

                if (c == 1)
                {
                    IntializeMemberPanelLabels();
                    loginPanel.Visible = false;
                    memberComplaintPanel.Visible = true;
                    MemberPanelExecutionCommands();

                }
                else
                    MessageBox.Show("Incorrect Email");
                con.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(complaintGrid.SelectedRows.Count.ToString()) == 1)
            {
                con.Open();
                SqlCommand cmd;
                SqlDataReader complaintReader, complainantReader;
                memberComplaintPanel.Visible = false;
                viewComplaintPanel.Visible = true;
                try
                {

                    id = complaintGrid.SelectedRows[0].Cells[0].Value.ToString();
                    string query = "Select * from Complaint where (Comp_ID = '" + id + "')";
                    string query1 = "select * from Complainant where Email=(select C_Email from Complaint where Comp_ID= '" + id + "')";

                    cmd = new SqlCommand(query, con);
                    complaintReader = cmd.ExecuteReader();
                    cmd = new SqlCommand(query1, con);
                    complainantReader = cmd.ExecuteReader();
                    while (complainantReader.Read())
                    {
                        nameLbl.Text = nameLbl.Text + " " + Convert.ToString(complainantReader["Name"]);
                        CEmailLbl.Text = CEmailLbl.Text + " " + Convert.ToString(complainantReader["Email"]);
                        C_TypeLbl.Text = C_TypeLbl.Text + " " + Convert.ToString(complainantReader["C_Type"]);
                        contactNoLbl.Text = contactNoLbl.Text + " " + Convert.ToString(complainantReader["ContactNo"]);
                    }
                    while (complaintReader.Read())
                    {
                        StatusCombo.Text = Convert.ToString(complaintReader["C_Status"]);
                        complaintIDLbl.Text = complaintIDLbl.Text + " " + Convert.ToString(complaintReader["Comp_ID"]);
                        DateTime dt = Convert.ToDateTime(complaintReader["C_Date"]);
                        departmentLbl.Text = departmentLbl.Text + " " + Convert.ToString(complaintReader["DeptName"]);
                        DateLbl.Text = DateLbl.Text + " " + dt.ToLongDateString();
                        TitleBox.Text = Convert.ToString(complaintReader["Title"]);
                        descriptTxt.Text = Convert.ToString(complaintReader["C_Description"]);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();

            }
            else
            {
                MessageBox.Show("Select a Complaint");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            viewComplaintPanel.Visible = false;
            memberComplaintPanel.Visible = true;
            IntializeLables(viewComplaintPanel);
            MemberPanelExecutionCommands();
        }

        private void logOutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrontPage form = new FrontPage();
            form.Show();
        }

        private void updateStatus_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Update Complaint Set C_Status = '" + StatusCombo.Text + "' " + "where Comp_ID='" + id + "' ";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Complaint Status Updated Successfully");
                complaintGrid.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }

        private void Member_Load(object sender, EventArgs e)
        {

        }

        private void Back1_Click(object sender, EventArgs e)
        {
            loginPanel.Visible = true;
            memberComplaintPanel.Visible = false;
            viewComplaintPanel.Visible = false;
        }

        private void back2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrontPage f2 = new FrontPage();
            f2.Show();
        }

        private void back3_Click(object sender, EventArgs e)
        {
            loginPanel.Visible = false;
            viewComplaintPanel.Visible = false;
            memberComplaintPanel.Visible = true;
        }
    }
}
