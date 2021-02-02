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
    public partial class CheckStatus : Form
    {
        public CheckStatus()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDb)\haroongaba;Initial Catalog=UniversityComplaintCell;Integrated Security=True");
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        string tempcompid;   //temp to store the selected comp_id from the combobox
        //void fillcomboid() 
        //{
        //    //SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-UHI0ATQ\SQLEXPRESS;Initial Catalog=UniversityComplaintCell;Integrated Security=True");
        //    string query = "select * from Complaint";
        //    SqlCommand cmd = new SqlCommand(query, cn);
        //    SqlDataReader myreader;

            
        //        cn.Open();
        //        myreader = cmd.ExecuteReader();
        //        while (myreader.Read())
        //        {
        //            int s = Convert.ToInt32(myreader.GetValue(0));
        //            idcombo.Items.Add(s);
        //        }

        //    cn.Close();
        //}

        private void CheckStatus_Load(object sender, EventArgs e)
        {
           // fillcomboid();
        }

        private void status_Click(object sender, EventArgs e)
        {  // tempcompid=idcombo.Text;

        try
        {
            //SqlConnection cn = new SqlConnection(@"Data Source=(LocalDb)\haroongaba;Initial Catalog=UniversityComplaintCell;Integrated Security=True");
            cn.Open();
            string query = "Select C_Email, Title, C_Status from Complaint where Comp_ID = '" + idCombo.Text + "' and C_Email = '" + emailcheck.Text + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            statusview.DataSource = dt;
            cn.Close();

        }

            catch(Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrontPage f2 = new FrontPage();
            f2.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
