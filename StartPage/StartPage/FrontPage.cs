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
    public partial class FrontPage : Form
    {
        public FrontPage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        
                
        
        }

        private void Complaint_Click(object sender, EventArgs e)
        {
            this.Hide();
            complaintandmember f2 = new complaintandmember();
            f2.Show();
          
        }

        private void status_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckStatus c2 = new CheckStatus();
            c2.Show();
        }

        private void Member_Click(object sender, EventArgs e)
        {
            this.Hide();
            Member form = new Member();
            form.Show();
        }

        private void FrontPage_Load(object sender, EventArgs e)
        {

        }
    }
}
