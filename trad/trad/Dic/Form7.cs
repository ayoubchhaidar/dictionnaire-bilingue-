using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dic
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        public String constring = "Data Source=DESKTOP-4BPLB63\\SQLEXPRESS02;Initial Catalog=trad;Integrated Security=True";
        private void supprimer_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "SELECT * FROM Users ";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read()) {
                if(reader.GetString(0) == user.Text)
                {
                    if (reader.GetString(1) == pwd.Text)
                    {
                        Form2 form2 = new Form2();
                        form2.Show();
                        this.Hide();
                    }
                   
                }
                else
                {
                    MessageBox.Show("nom utilisateur or mot de passe incorect");
                }    
            }
        }
    }
}
