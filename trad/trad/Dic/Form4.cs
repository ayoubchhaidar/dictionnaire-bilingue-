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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dic
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public String constring = "Data Source=DESKTOP-4BPLB63\\SQLEXPRESS02;Initial Catalog=trad;Integrated Security=True";
        public int v = 0;
        public int newID;

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
                    while (reader.Read())
                    {
                        v = reader.GetInt32(0);
                        string item = "ID:'"+reader.GetInt32(0)+"',Type :'" + reader.GetString(2) + "',Traduction:'" + reader.GetString(1) + "',Exemple:<<'" + reader.GetString(3) + "'>>-<<'" + reader.GetString(4) + "'>>"; // assuming the first column is a string colum
                        listBox1.Items.Add(item);

                    }
                    reader.Close();
                    conn.Close();
                }
            }
            else
                MessageBox.Show("meme langue");
        }

        private void mod_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();

            if (string.IsNullOrWhiteSpace(TextBoxmot2.Text) || string.IsNullOrWhiteSpace(TextBoxexemple2.Text) || string.IsNullOrWhiteSpace(type2.Text) || string.IsNullOrWhiteSpace(exemplel2.Text))
            { MessageBox.Show("champ vide"); }

            else
            {

                string q1 = "UPDATE " + comboBox4.SelectedItem.ToString() + " SET Mot_" + comboBox4.SelectedItem.ToString() + "='" + TextBoxmot2.Text + "', type='" + type2.SelectedItem.ToString() + "', exemple='" + TextBoxexemple2.Text + "',exemple2='" + exemplel2.Text + "' WHERE ID_" + comboBox4.SelectedItem.ToString() + "=" + v;
                SqlCommand command2 = new SqlCommand(q1, con);
                command2.ExecuteNonQuery();
                MessageBox.Show("sahitt");
                TextBoxexemple2.Text = ""; TextBoxmot2.Text = ""; type2.SelectedIndex = -1; exemplel2.Text = "";
            }
            listBox1.Items.Clear();
            textBox1.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Hide();
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
                    
                        string word0 = matches[0].Groups[1].Value;
                        string word1 = matches[1].Groups[1].Value;
                        string word2 = matches[2].Groups[1].Value;
                        string word3 = matches[3].Groups[1].Value;
                        string word4 = matches[4].Groups[1].Value;
                        v = int.Parse(word0);
                        int index = type2.FindString(word1);
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

        private void Form4_Load(object sender, EventArgs e)
        {
            TableLayoutPanel1.Visible = true;
            tableLayoutPanel2.Visible = true;
            mod.Visible = true;
            listBox1.Visible = true;
            L.Visible = false;
            comboBox3.Visible = false;
           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Exemple_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Type_Click(object sender, EventArgs e)
        {

        }

        private void Mot_Click(object sender, EventArgs e)
        {

        }

        private void L_Click(object sender, EventArgs e)
        {

        }

        private void L1_Click(object sender, EventArgs e)
        {

        }
    }
}
