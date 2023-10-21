using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dic
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public String constring = "Data Source=DESKTOP-4BPLB63\\SQLEXPRESS02;Initial Catalog=trad;Integrated Security=True";
        public int newID;
        class trad
        {
            private string Mot_L1;
            private string Mot_L2;
            private string Type;
            private string Expl1;
            private string Expl2;
            public trad(string Mot_L1, String Mot_L2, String Type, string Expl1, string Expl2)
            {
                this.Mot_L1 = Mot_L1;
                this.Mot_L2 = Mot_L2;
                this.Expl1 = Expl1;
                this.Expl2 = Expl2;
                this.Type = Type;
            }
            public override string ToString()
            {
                return $"{Mot_L1},{Mot_L2},{Type},{Expl1},{Expl2}";
            }

        }
        private void Form5_Load(object sender, EventArgs e)
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
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult resultat = MessageBox.Show("exporter la base   ?", "Choisir une option", MessageBoxButtons.YesNoCancel);
            if (resultat == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                string fileName = "export.txt";
                StreamWriter writer = new StreamWriter(fileName);

                // Create a DataTable to store the results
                DataTable dt = new DataTable();

                string q = "select * from traductions";
                SqlCommand command = new SqlCommand(q, con);

                // Use a SqlDataAdapter to fill the DataTable with the results of the query
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    int id = (int)row["ID_FR"]; // assuming the ID column is named "ID"
                    int id2 = (int)row["ID_EN"];
                    // construct the queries to search for the row in the "FR" and "EN" tables
                    string q1 = "select Mot_FR,type,exemple from FR where ID_FR=" + id;
                    string q2 = "select Mot_EN,exemple from EN where ID_EN=" + id2;

                    // execute the queries and retrieve the data
                    string Mot_l1 = "", type = "", exemple1 = "", Mot_l2 = "", exemple2 = "";
                    using (SqlCommand command1 = new SqlCommand(q1, con))
                    using (SqlDataReader reader1 = command1.ExecuteReader())
                    {
                        if (reader1.Read())
                        {
                            Mot_l1 = reader1.GetString(0);
                            type = reader1.GetString(1);
                            exemple1 = reader1.GetString(2);
                        }
                    }

                    using (SqlCommand command2 = new SqlCommand(q2, con))
                    using (SqlDataReader reader2 = command2.ExecuteReader())
                    {
                        if (reader2.Read())
                        {
                            Mot_l2 = reader2.GetString(0);
                            exemple2 = reader2.GetString(1);
                        }
                    }

                    // write the data for the current row to the file
                    trad obj = new trad(Mot_l1, Mot_l2, type, exemple1, exemple2);
                    writer.WriteLine(obj.ToString());
                }

                writer.Close();
                con.Dispose();
            }
           
        }

        private void import_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Visible = true;
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void IM_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            string fichier = "C:\\Users\\Ayoub\\Desktop\\import.txt";
            con.Open();
            if (File.Exists(fichier))
            {

                using (StreamReader reader = new StreamReader(fichier))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (ComboBox1.SelectedIndex != comboBox4.SelectedIndex)
                        {
                            if (ComboBox1.SelectedItem != null && comboBox4.SelectedItem != null)
                            {
                                string[] lineWords = line.Split(',');
                                string queryL0 = "SELECT COUNT(*) FROM " + ComboBox1.SelectedItem.ToString() + " WHERE CONVERT(varchar(max), Mot_" + ComboBox1.SelectedItem.ToString() + ") = '" + lineWords[0] + "'";
                                SqlCommand command = new SqlCommand(queryL0, con);
                                int count = (int)command.ExecuteScalar();

                                if (count == 0)
                                {
                                    try
                                    {
                                        string queryL1 = "INSERT INTO " + ComboBox1.SelectedItem.ToString() + " (ID_" + ComboBox1.SelectedItem.ToString() + ", Mot_" + ComboBox1.SelectedItem.ToString() + ",type,exemple,exemple2) VALUES (" + newID.ToString() + ",'" + lineWords[0] + "','" + lineWords[2] + "','" + lineWords[3] + "','" + lineWords[4] + "')";
                                        SqlCommand commandL1 = new SqlCommand(queryL1, con);
                                        commandL1.ExecuteNonQuery();

                                        string queryL2 = "INSERT INTO " + comboBox4.SelectedItem.ToString() + " (ID_" + comboBox4.SelectedItem.ToString() + ", Mot_" + comboBox4.SelectedItem.ToString() + ",type,exemple,exemple2) VALUES (" + newID.ToString() + ",'" + lineWords[1] + "','" + lineWords[2] + "','" + lineWords[4] + "','" + lineWords[3] + "')";
                                        SqlCommand commandL2 = new SqlCommand(queryL2, con);
                                        commandL2.ExecuteNonQuery();


                                        string queryTranslation = "INSERT INTO traductions ( ID_" + ComboBox1.SelectedItem.ToString() + ", ID_" + comboBox4.SelectedItem.ToString() + ") VALUES (" + newID.ToString() + "," + newID.ToString() + ")";
                                        SqlCommand commandTranslation = new SqlCommand(queryTranslation, con);
                                        commandTranslation.ExecuteNonQuery();
                                        newID += 1;
                                    }
                                    catch (IndexOutOfRangeException ex)
                                    {
                                        MessageBox.Show("champ vide");
                                    }
                                }

                                else
                                {
                                    try
                                    {
                                        string q = "SELECT ID_" + ComboBox1.SelectedItem.ToString() + " FROM " + ComboBox1.SelectedItem.ToString() + " WHERE CONVERT(varchar(max), Mot_" + ComboBox1.SelectedItem.ToString() + ") = '" + lineWords[0] + "'";
                                        SqlCommand cmd = new SqlCommand(q, con);
                                        cmd.ExecuteNonQuery();
                                        SqlDataReader reader1 = cmd.ExecuteReader();
                                        int id = 0;
                                        while (reader1.Read())
                                        {
                                            id = reader1.GetInt32(0);
                                        }
                                        reader1.Close();
                                        string queryL2 = "INSERT INTO " + comboBox4.SelectedItem.ToString() + " (ID_" + comboBox4.SelectedItem.ToString() + " , Mot_" + comboBox4.SelectedItem.ToString() + " ,type,exemple,exemple2) VALUES (" + newID.ToString() + ",'" + lineWords[1] + "','" + lineWords[2] + "','" + lineWords[4] + "','" + lineWords[3] + "')";
                                        SqlCommand commandL2 = new SqlCommand(queryL2, con);
                                        commandL2.ExecuteNonQuery();
                                        string queryTranslation = "INSERT INTO traductions ( ID_" + ComboBox1.SelectedItem.ToString() + ", ID_" + comboBox4.SelectedItem.ToString() + " ) VALUES (" + id.ToString() + "," + newID.ToString() + ")";
                                        SqlCommand commandTranslation = new SqlCommand(queryTranslation, con);
                                        commandTranslation.ExecuteNonQuery();
                                        newID += 1;
                                    }
                                    catch (IndexOutOfRangeException ex)
                                    {
                                        MessageBox.Show("champ vide");
                                    }

                                }
                            }
                            else
                                MessageBox.Show("aucune langue");
                            }
                        else
                            MessageBox.Show("meme langue");
                    }
                }
            }
       
            con.Close();
            tableLayoutPanel2.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
   
}
