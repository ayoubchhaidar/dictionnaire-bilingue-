using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dic
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public String constring = "Data Source=DESKTOP-4BPLB63\\SQLEXPRESS02;Initial Catalog=trad;Integrated Security=True";
        public int v = 0;
        public int id = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedIndex != comboBox4.SelectedIndex)
            {
                if (ComboBox1.SelectedItem != null && comboBox4.SelectedItem != null)
                {
                    SqlConnection conn = new SqlConnection(constring);
                    conn.Open();
                    string query = "SELECT * FROM " + comboBox4.SelectedItem.ToString() + " WHERE ID_" + comboBox4.SelectedItem.ToString() + " IN (SELECT ID_" + comboBox4.SelectedItem.ToString() + " FROM traductions WHERE ID_" + ComboBox1.SelectedItem.ToString() + " = (SELECT ID_" + ComboBox1.SelectedItem.ToString() + " FROM " + ComboBox1.SelectedItem.ToString() + " WHERE CONVERT(varchar(MAX), Mot_" + ComboBox1.SelectedItem.ToString() + ") = '" + textBox1.Text + "'))";
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    listBox1.Items.Clear();
                    while (reader.Read()){
                        v=reader.GetInt32(0);
                        string item = "Type :'" + reader.GetString(2) + "',Traduction:'" + reader.GetString(1) + "',Exemple:<<'" + reader.GetString(3) + "'>>-<<'" + reader.GetString(4) + "'>>"; // assuming the first column is a string colum
                        listBox1.Items.Add(item);                       
                    }
                     reader.Close();
                    string query1 = "SELECT * FROM " + ComboBox1.SelectedItem.ToString() + " WHERE CAST(Mot_" + ComboBox1.SelectedItem.ToString() + " AS NVARCHAR(MAX)) = @searchWord";
                    SqlCommand cmd = new SqlCommand(query1, conn);
                    cmd.Parameters.AddWithValue("@searchWord", textBox1.Text);
                    SqlDataReader reader1 = cmd.ExecuteReader();


                    // Process the results...
                    while (reader1.Read())
                        {
                            v = reader1.GetInt32(0);
                           
                        }
                   

                  
                }
             
            }
            else

                MessageBox.Show("meme langue");
            
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();

            DataTable dt = new DataTable();


            string query = "SELECT ID_" + comboBox4.SelectedItem.ToString() + " FROM traductions WHERE ID_" + ComboBox1.SelectedItem.ToString() + "=" + v;

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                int id = (int)row[0];
                string q2 = "DELETE FROM traductions WHERE ID_" + comboBox4.SelectedItem.ToString() + " =" + id;
                SqlCommand command2 = new SqlCommand(q2, con);
                command2.ExecuteNonQuery();
                string q1 = "DELETE FROM " + comboBox4.SelectedItem.ToString() + " WHERE ID_" + comboBox4.SelectedItem.ToString() + "=" + id;
                SqlCommand command = new SqlCommand(q1, con);
                command.ExecuteNonQuery();
            }


            string q3 = "DELETE FROM " + ComboBox1.SelectedItem.ToString() + " WHERE ID_" + ComboBox1.SelectedItem.ToString() + "="+v;
            SqlCommand command3 = new SqlCommand(q3, con);
            command3.ExecuteNonQuery();

           
          
                
                MessageBox.Show("Row deleted successfully.");

            listBox1.Items.Clear();
            textBox1.Text = "";



            con.Close();
        }

        private void  linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

           
            tableLayoutPanel2.Visible = true;
            supprimer.Visible = true;
            listBox1.Visible = true;
            
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
