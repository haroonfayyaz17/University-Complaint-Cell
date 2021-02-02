using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StartPage
{
    public partial class complaintandmember : Form
    {
        public complaintandmember()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDb)\haroongaba;Initial Catalog=UniversityComplaintCell;Integrated Security=True");
        void FillCombo()
        {
            string query = "select * from Department";
            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataReader myreader;


            cn.Open();
            myreader = cmd.ExecuteReader();
            while (myreader.Read())
            {
                string s = myreader.GetString(0);
                DepartmentCombo.Items.Add(s);
            }

            cn.Close();

        }
        private void complaintpic_Click(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void Date_Click(object sender, EventArgs e)
        {

        }

        private void complaintitle_Click(object sender, EventArgs e)
        {

        }

        private void Department_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            string tempid = "";
            if (NameBox.Text == "")
                MessageBox.Show("Please Enter The Name");

            else if (EmailBox.Text == "")
                MessageBox.Show("Please Enter The Email");

            else if (TitleBox.Text == "")
                MessageBox.Show("Please Enter The Complaint Title");

            else if (Descriptionbox.Text == "")
                MessageBox.Show("Please Enter The Complaint Description");


            else if (DepartmentCombo.Text == "")
                MessageBox.Show("Please Select The Department");

            else
            {
                cn.Open();
                cmd = new SqlCommand("INSERT INTO Complainant(Email,Name,C_Type,ContactNo) VALUES ('" + EmailBox.Text + "', '" + NameBox.Text + "', '" + designationbox.Text + "', '" + contactbox.Text + "'  ) ", cn);

                cmd.ExecuteNonQuery();
                String date= DateTime.Today.ToString("dd-MMM-yy");

                cmd = new SqlCommand("INSERT INTO Complaint(C_Email,Title,C_Description,Deptname,C_Status,C_Date) VALUES ('" + EmailBox.Text + "', '" + TitleBox.Text + "', '" + Descriptionbox.Text + "', '" + DepartmentCombo.Text + "', '" + "Unresolved" + "' , '" + date + "' ) ", cn);
                cmd.ExecuteNonQuery();


                cmd = new SqlCommand("select max(Comp_ID) as Comp_ID from Complaint ", cn);
                var newreader = cmd.ExecuteReader();
                while (newreader.Read())
                {
                    tempid = Convert.ToString(newreader["Comp_ID"]);
                }


                MessageBox.Show("Your Complaint ID is: " + tempid.ToString());

                EmailBox.Clear();
                TitleBox.Clear();
                Descriptionbox.Clear();
                DepartmentCombo.Text = " ";
                NameBox.Clear();
                contactbox.Clear();
                designationbox.Text = " ";

                cn.Close();
            }

        }

        private void complaintandmember_Load(object sender, EventArgs e)
        {
            FillCombo();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrontPage f2 = new FrontPage();
            f2.Show();
        }
    }
}
