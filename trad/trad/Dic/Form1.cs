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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public String constring = "Data Source=DESKTOP-4BPLB63\\SQLEXPRESS02;Initial Catalog=trad;Integrated Security=True";

        public object TextOrientation { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rechercher_Click(object sender, EventArgs e)
        {

        }







        private void Form1_Load_1(object sender, EventArgs e)
        {


        }

        private void admin_Click_1(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            // Get the current location of the label
            Point currentLocation1 = L1.Location;
            Point currentLocation2 = L2.Location;

            // Swap the X and Y coordinates
            int newX1 = currentLocation1.Y;
            int newY1 = currentLocation1.X;
            int newX2 = currentLocation2.Y;
            int newY2 = currentLocation2.X;

            // Create a new point with the swapped coordinates
            Point newLocation1 = new Point(newY2, newX2);
            Point newLocation2 = new Point(newY1, newX1);
            // Set the location of the label to the new point
            L1.Location = newLocation1;
            L2.Location = newLocation2;
            // Get the current selected indexes of the combo boxes
            int currentIndex1 = ComboBox1.SelectedIndex;
            int currentIndex2 = ComboBox2.SelectedIndex;

            // Swap the selected indexes
            ComboBox1.SelectedIndex = currentIndex2;
            ComboBox2.SelectedIndex = currentIndex1;
        }

        private void rechercher_Click_1(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(constring);
            con.Open();

            if (ComboBox1.SelectedItem != ComboBox2.SelectedItem)
            {
                if (ComboBox1.SelectedItem != null && ComboBox2.SelectedItem != null)
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        string query = "SELECT * FROM " + ComboBox2.SelectedItem.ToString() + " WHERE ID_" + ComboBox2.SelectedItem.ToString() + " IN (SELECT ID_" + ComboBox2.SelectedItem.ToString() + " FROM traductions WHERE ID_" + ComboBox1.SelectedItem.ToString() + " = (SELECT ID_" + ComboBox1.SelectedItem.ToString() + " FROM " + ComboBox1.SelectedItem.ToString() + " WHERE CONVERT(varchar(MAX), Mot_" + ComboBox1.SelectedItem.ToString() + ") = '" + TextBox1.Text + "'))";


                        SqlCommand command = new SqlCommand(query, con);
                        SqlDataReader reader = command.ExecuteReader();
                        richTextBox1.Text = "";
                        while (reader.Read())
                        {


                            string item = "Type :'" + reader.GetString(2) + "',Traduction:'" + reader.GetString(1) + "',Exemple:<<'" + reader.GetString(3) + "'>>,<<'" + reader.GetString(4) + "'>>";
                            richTextBox1.AppendText(Environment.NewLine + item);
                            richTextBox1.AppendText(Environment.NewLine + "");


                        }

                        con.Close();

                    }
                }
            }
            else
            {
                MessageBox.Show("same language");

            }

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {


           
            TextBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

      
            TextBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;

       
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            TextBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            TextBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new
             AutoCompleteStringCollection();

            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "SELECT Mot_" + ComboBox1.SelectedItem.ToString() + " FROM " + ComboBox1.SelectedItem.ToString() + "";
            SqlCommand command = new SqlCommand(query, con);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                col.Add(reader.GetString(0));

            }
            reader.Close();
            TextBox1.AutoCompleteCustomSource = col;
            con.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
