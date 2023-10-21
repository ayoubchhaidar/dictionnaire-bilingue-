using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dic
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public String constring = "Data Source=DESKTOP-4BPLB63\\SQLEXPRESS02;Initial Catalog=trad;Integrated Security=True";
        public int v = 0;
        public int newID;

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "SELECT MAX(ID_FR) AS MaxID FROM (SELECT ID_FR FROM FR UNION SELECT ID_EN FROM EN) AS CombinedTables";
            SqlCommand command = new SqlCommand(query, con);
            object result = command.ExecuteScalar();
            newID = 0;
            if (result != DBNull.Value)
            {
                int maxID = Convert.ToInt32(result);
                newID = maxID + 1;
            }

            con.Close();
            DialogResult resultat=MessageBox.Show("Ajouter à une traduction deja  existante  ?", "Choisir une option", MessageBoxButtons.YesNo);
            if (resultat == DialogResult.Yes)
            {

                
                TableLayoutPanel1.Visible = true;
                tableLayoutPanel2.Visible = true;
               button2.Visible = true;
                listBox1.Visible = true;
                TextBoxexemple2.Visible = false; TextBoxmot2.Visible = false; type2.Visible = false; L.Visible = false; comboBox2.Visible = false; comboBox3.Visible = false; exemplel2.Visible = false;







            }
            if (resultat == DialogResult.No)
            {
                listBox1.Visible = false;
                Add.Visible = true;
                TableLayoutPanel1.Visible = true;
            }
        
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedIndex != comboBox4.SelectedIndex)
            {
                if (ComboBox1.SelectedItem != null && comboBox4.SelectedItem != null)
                {
                    SqlConnection conn = new SqlConnection(constring);
                    conn.Open();
                    string q = "SELECT * FROM [" + ComboBox1.SelectedItem.ToString() + "] WHERE Mot_" + ComboBox1.SelectedItem.ToString() + " LIKE '%" + textBox1.Text + "%'";

                    SqlCommand command1 = new SqlCommand(q, conn);
                    SqlDataReader reader1 = command1.ExecuteReader();

                    if (reader1.Read())
                    {
                        v = reader1.GetInt32(0);
                        
                    }
                    reader1.Close();
                    string query = "SELECT * FROM " + comboBox4.SelectedItem.ToString() + " WHERE ID_" + comboBox4.SelectedItem.ToString() + " IN (SELECT ID_" + comboBox4.SelectedItem.ToString() + " FROM traductions WHERE ID_" + ComboBox1.SelectedItem.ToString() + " = (SELECT ID_" + ComboBox1.SelectedItem.ToString() + " FROM " + ComboBox1.SelectedItem.ToString() + " WHERE CONVERT(varchar(MAX), Mot_" + ComboBox1.SelectedItem.ToString() + ") = '" + textBox1.Text + "'))";
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    listBox1.Items.Clear();
                    while(reader.Read())
                    {
                       
                        string item = "Type :'" + reader.GetString(2) + "',Traduction:'" + reader.GetString(1) + "',Exemple:<<'" + reader.GetString(3) + "'>>-<<'" + reader.GetString(4) + "'>>"; // assuming the first column is a string colum
                        listBox1.Items.Add(item);
                        

                        
                    }
                    reader.Close();
                    conn.Close();
                }
            }
            else
                MessageBox.Show("meme langue");
           
        }

        private void Add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                if (string.IsNullOrWhiteSpace(TextBoxmot.Text) || string.IsNullOrWhiteSpace(type1.Text) || string.IsNullOrWhiteSpace(TextBoxexemple.Text) || string.IsNullOrWhiteSpace(TextBoxmot2.Text) || string.IsNullOrWhiteSpace(type2.Text) || string.IsNullOrWhiteSpace(TextBoxexemple2.Text))
                {
                    MessageBox.Show("Please enter values for all fields.");
                }
                else
                {
                    if (comboBox2.SelectedIndex != comboBox3.SelectedIndex)
                    {
                        if (comboBox2.SelectedItem != null && comboBox3.SelectedItem != null)
                        {
                            try
                            {
                                string queryL1 = "INSERT INTO " + comboBox2.SelectedItem.ToString() + " (ID_" + comboBox2.SelectedItem.ToString() + ", Mot_" + comboBox2.SelectedItem.ToString() + ",type,exemple,exemple2) VALUES (" + newID.ToString() + ",'" + TextBoxmot.Text + "','" + type1.SelectedItem.ToString() + "','" + TextBoxexemple.Text + "','" + TextBoxexemple2.Text + "')";
                                SqlCommand commandL1 = new SqlCommand(queryL1, con);
                                commandL1.ExecuteNonQuery();

                                string queryL2 = "INSERT INTO " + comboBox3.SelectedItem.ToString() + " (ID_" + comboBox3.SelectedItem.ToString() + ", Mot_" + comboBox3.SelectedItem.ToString() + ",type,exemple,exemple2) VALUES (" + newID.ToString() + ",'" + TextBoxmot2.Text + "','" + type2.SelectedItem.ToString() + "','" + TextBoxexemple2.Text + "','" + TextBoxexemple.Text + "')";
                                SqlCommand commandL2 = new SqlCommand(queryL2, con);
                                commandL2.ExecuteNonQuery();


                                string queryTranslation = "INSERT INTO traductions ( ID_FR, ID_EN) VALUES (" + newID.ToString() + "," + newID.ToString() + ")";
                                SqlCommand commandTranslation = new SqlCommand(queryTranslation, con);
                                commandTranslation.ExecuteNonQuery();
                                newID += 1;
                                TextBoxmot.Text = ""; TextBoxmot2.Text = ""; TextBoxexemple.Text = ""; TextBoxexemple2.Text = ""; type1.Text = ""; type2.Text = ""; comboBox2.Text = ""; comboBox3.Text = "";exemplel1.Text = "";exemplel2.Text= "";
                                MessageBox.Show("traduction ajouter");
                            }
                            catch (SqlException ex)
                            {
                                if (ex.Message.Contains("Violation of PRIMARY KEY constraint"))
                                {
                                    MessageBox.Show("ID existant");

                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please select values for all combo boxes.");
                        }

                    }
                    else
                        MessageBox.Show("la meme langue");
                }
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            if (string.IsNullOrWhiteSpace(TextBoxmot.Text) || string.IsNullOrWhiteSpace(TextBoxexemple.Text) || string.IsNullOrWhiteSpace(type1.Text) || string.IsNullOrWhiteSpace(exemplel1.Text))
            { MessageBox.Show("champ vide"); }
            else
            {

                string queryL2 = "INSERT INTO " + comboBox4.SelectedItem.ToString() + " (ID_" + comboBox4.SelectedItem.ToString() + ", Mot_" + comboBox4.SelectedItem.ToString() + ",type,exemple,exemple2) VALUES (" + newID.ToString() + ",'" + TextBoxmot.Text + "','" + type1.SelectedItem.ToString() + "','" + TextBoxexemple.Text + "','" + exemplel1.Text + "')";
                SqlCommand commandL2 = new SqlCommand(queryL2, con);
                commandL2.ExecuteNonQuery();
                string queryTranslation = "INSERT INTO traductions ( ID_" + ComboBox1.SelectedItem.ToString() + ", ID_" + comboBox4.SelectedItem.ToString() + ") VALUES ( " + v.ToString() + "," + newID.ToString() + " )";
                SqlCommand commandTranslation = new SqlCommand(queryTranslation, con);
                commandTranslation.ExecuteNonQuery();
                newID += 1;
                TextBoxmot.Text = "";  TextBoxexemple.Text = "";  type1.Text = ""; exemplel1.Text = ""; 
                MessageBox.Show("traduction ajouter");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pattern = @"'([^']*)'"; // regular expression pattern to match words between single quotes
            if (listBox1.SelectedItems != null && listBox1.SelectedItems.Count > 0)
            {
                StringBuilder extractedWords = new StringBuilder();
                foreach (var selectedItem in listBox1.SelectedItems)
                {
                    MatchCollection matches = Regex.Matches(selectedItem.ToString(), pattern);

                    foreach (Match match in matches)
                    {
                        string word1 = matches[0].Groups[1].Value;
                        string word2 = matches[1].Groups[1].Value;
                        string word3 = matches[2].Groups[1].Value;
                        string word4 = matches[3].Groups[1].Value;


                        int index = type1.FindString(word1);
                        if (index != -1)
                        {
                            type2.SelectedIndex = index;
                        }
                        TextBoxexemple2.Text = word3;
                        TextBoxmot2.Text = word2;
                        exemplel2.Text = word4;

                    }


                }

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
