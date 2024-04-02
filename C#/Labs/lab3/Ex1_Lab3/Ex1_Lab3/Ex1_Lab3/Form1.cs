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

namespace Ex1_Lab3
{
    public partial class Form1 : Form
    {
        SqlConnection myCon = new SqlConnection();//prin acest obiect ne conectam la baza de date
        DataSet dsUniv = new DataSet();// vom salva rezultatele a doua interogari de tipul select (* from univ, * from prop)
        DataSet dsFac = new DataSet();

        public Form1()
        {
            InitializeComponent();
            myCon.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'D:\Facultate\AN III, SEM II\II\Lab3\Ex1_Lab3\Ex1_Lab3\Universities.mdf'; Integrated Security = True";
            myCon.Open();
            ListBox_Fill();

            
            myCon.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ListBox_Fill()
        {
            dsUniv.Clear();
            dsFac.Clear();
            listBox_Univ.Items.Clear();

            SqlDataAdapter daUniv = new SqlDataAdapter("Select * from UNIVERSITATE", myCon);
            daUniv.Fill(dsUniv, "Universitate");

            SqlDataAdapter daFac = new SqlDataAdapter("Select * from FACULTATI", myCon);
            daFac.Fill(dsFac, "Facultati");

            foreach(DataRow dr in dsUniv.Tables["Universitate"].Rows)
            {
                String name = dr.ItemArray.GetValue(3).ToString();// getvalue(1) pt ca folosim primul parametru din tabela Univ
                listBox_Univ.Items.Add(name);
            }
        }

        private void listBox_Univ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox_Univ.SelectedIndex >= 0)
            {
                listBox_Fac.Items.Clear();
                int id = 0;
                int code = 0;
                String UnivSelected = listBox_Univ.SelectedItem.ToString();
                foreach (DataRow dr in dsUniv.Tables["Universitate"].Rows)
                {
                    if (UnivSelected == dr.ItemArray.GetValue(3).ToString())
                    {
                        id = Convert.ToInt32(dr.ItemArray.GetValue(0));
                        textBox_IdUniv.Text = id.ToString();
                        textBox_NumeUniv.Text = dr.ItemArray.GetValue(3).ToString();
                        textBox_City.Text = dr.ItemArray.GetValue(2).ToString();
                        code = Convert.ToInt32(dr.ItemArray.GetValue(1)); 
                        textBox_CodUniv.Text = code.ToString();
                    }
                }
                foreach (DataRow dr in dsFac.Tables["Facultati"].Rows)
                {
                    if (code == Convert.ToInt32(dr.ItemArray.GetValue(1)))
                    {

                        String nameFac = dr.ItemArray.GetValue(2).ToString(); 
                        listBox_Fac.Items.Add(nameFac);
                    }
                }
            }

        }

        private void button_InsertUniv_Click(object sender, EventArgs e)
        {
            myCon.Open();
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO Universitate (Id, City, NameUni) VALUES (@Id, @City, @Name)", myCon);
                command.Parameters.Add("@Id", SqlDbType.Int).Value = int.Parse(textBox_IdUniv.Text);
                command.Parameters.Add("@Name", SqlDbType.Text).Value = textBox_NumeUniv.Text;
                command.Parameters.Add("@City", SqlDbType.Text).Value = textBox_City.Text;
                command.ExecuteNonQuery();

                ListBox_Fill();
                textBox_IdUniv.Clear();
                textBox_NumeUniv.Clear();
                textBox_City.Clear();
                textBox_CodUniv.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            myCon.Close();
        }

        private void button_UpdateUniv_Click(object sender, EventArgs e)
        {
            myCon.Open();
            try
            {
                SqlCommand command = new SqlCommand("UPDATE Universitate SET NameUni = @NameUni, City = @City, Id = @Id WHERE Code = @Code", myCon);
                command.Parameters.Add("@Id", SqlDbType.Int).Value = int.Parse(textBox_IdUniv.Text);
                command.Parameters.Add("@Code", SqlDbType.Int).Value = int.Parse(textBox_CodUniv.Text);
                command.Parameters.Add("@City", SqlDbType.Text).Value = textBox_City.Text;
                command.Parameters.Add("@NameUni", SqlDbType.Text).Value = textBox_NumeUniv.Text;
                command.ExecuteNonQuery();

                ListBox_Fill();
                textBox_IdUniv.Clear();
                textBox_NumeUniv.Clear();
                textBox_City.Clear();
                textBox_CodUniv.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            myCon.Close();
        }

        private void button_DeleteUniv_Click(object sender, EventArgs e)
        {
            myCon.Open();
            try
            {
                SqlCommand command1 = new SqlCommand("SELECT COUNT(*) FROM Facultati WHERE Code=@Code", myCon);
                command1.Parameters.Add("@Code", SqlDbType.Int).Value = Convert.ToInt32(textBox_CodUniv.Text);
                int n = Convert.ToInt32(command1.ExecuteScalar());
                if (n == 0)
                {
                    SqlCommand command = new SqlCommand("DELETE FROM Universitate WHERE Code=@Code", myCon);
                    command.Parameters.Add("@Code", SqlDbType.Int).Value = Convert.ToInt32(textBox_CodUniv.Text);
                    command.ExecuteNonQuery();

                    ListBox_Fill();
                    textBox_IdUniv.Clear();
                    textBox_NumeUniv.Clear();
                    textBox_City.Clear();
                    textBox_CodUniv.Clear();
                }
                else MessageBox.Show("Universitatea are Facultati!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            myCon.Close();
        }
    }
}
