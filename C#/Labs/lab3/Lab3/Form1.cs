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

namespace Lab3
{
    public partial class Form1 : Form
    {

        SqlConnection myCon = new SqlConnection();
        DataSet dsUniv = new DataSet();
        DataSet dsFac = new DataSet();
        public Form1()
        {
            InitializeComponent();
            myCon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\trest\\Documents\\II\\Lab3\\Lab3\\Universities.mdf;Integrated Security=True";
            myCon.Open();
            ListBox_Fill();
            PopulateComboBox();
            PopulateDataGridView();
            myCon.Close();
        }

        private void ListBox_Fill()
        {
            dsUniv.Clear();
            dsFac.Clear();
            listBox_Univ.Items.Clear();

            SqlDataAdapter daUniv = new SqlDataAdapter("SELECT * FROM UNIVERSITATI", myCon);
            daUniv.Fill(dsUniv, "Universitati");

            SqlDataAdapter daFac = new SqlDataAdapter("SELECT * FROM FACULTATI", myCon);
            daFac.Fill(dsFac, "Facultati");

            foreach (DataRow dr in dsUniv.Tables["Universitati"].Rows)
            {
                String name = dr.ItemArray.GetValue(1).ToString();
                listBox_Univ.Items.Add(name);
            }

        }

        private void PopulateComboBox()
        {
            SqlDataAdapter daUniv1 = new SqlDataAdapter("SELECT * FROM UNIVERSITATI", myCon);
            DataTable dtUniv = new DataTable();
            daUniv1.Fill(dtUniv);
            Column2.ValueMember = "Code";
            Column2.DisplayMember = "NameUniv";
            DataRow topItem = dtUniv.NewRow();
            topItem[0] = 0;
            topItem[1] = "-Select-";
            dtUniv.Rows.InsertAt(topItem, 0);
            Column2.DataSource = dtUniv;
        }

        private void PopulateDataGridView()
        {
            SqlDataAdapter daFac1 = new SqlDataAdapter("SELECT * FROM FACULTATI", myCon);
            DataTable dtFac = new DataTable();
            daFac1.Fill(dtFac);
            dataGridView1.DataSource = dtFac;
        }

        private void listBox_Univ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox_Univ.SelectedIndex >= 0)
            {
                listBox_Fac.Items.Clear();
                int id = 0, code = 0;
                String UnivSelected = listBox_Univ.SelectedItem.ToString();
                foreach (DataRow dr in dsUniv.Tables["Universitati"].Rows)
                {
                    if (UnivSelected == dr.ItemArray.GetValue(1).ToString())
                    {
                        id = Convert.ToInt32(dr.ItemArray.GetValue(0));
                        textBox_IdUniv.Text = id.ToString();
                        textBox_NameUniv.Text = dr.ItemArray.GetValue(1).ToString();
                        textBox_City.Text = dr.ItemArray.GetValue(2).ToString();
                        code = Convert.ToInt32(dr.ItemArray.GetValue(3));
                        textBox_CodeUniv.Text = code.ToString();
                    }
                }
                foreach (DataRow dr in dsFac.Tables["Facultati"].Rows)
                {
                    if(code == Convert.ToInt32(dr.ItemArray.GetValue(1)))
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
                SqlCommand command = new SqlCommand("INSERT INTO Universitati (Id, NameUniv, City) VALUES (@Id, @Name, @City)", myCon);
                command.Parameters.Add("@Id", SqlDbType.Int).Value = int.Parse(textBox_IdUniv.Text);
                command.Parameters.Add("@Name", SqlDbType.Text).Value = textBox_NameUniv.Text;
                command.Parameters.Add("@City", SqlDbType.Text).Value = textBox_City.Text;
                command.ExecuteNonQuery();

                ListBox_Fill();
                textBox_IdUniv.Clear();
                textBox_NameUniv.Clear();
                textBox_City.Clear();
                textBox_CodeUniv.Clear();
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
                SqlCommand command = new SqlCommand("UPDATE Universitati SET NameUniv = @Name, City = @City, Id = @Id WHERE Code = @Code", myCon);
                command.Parameters.Add("@Id", SqlDbType.Int).Value = int.Parse(textBox_IdUniv.Text);
                command.Parameters.Add("@Name", SqlDbType.Text).Value = textBox_NameUniv.Text;
                command.Parameters.Add("@City", SqlDbType.Text).Value = textBox_City.Text;
                command.Parameters.Add("@Code", SqlDbType.Int).Value = int.Parse(textBox_CodeUniv.Text);
                command.ExecuteNonQuery();

                ListBox_Fill();
                textBox_IdUniv.Clear();
                textBox_NameUniv.Clear();
                textBox_City.Clear();
                textBox_CodeUniv.Clear();
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
                SqlCommand command1 = new SqlCommand("SELECT COUNT (*) FROM Facultati WHERE Code = @Code", myCon);
                command1.Parameters.Add("@Code", SqlDbType.Int).Value = int.Parse(textBox_CodeUniv.Text);
                int n = Convert.ToInt32(command1.ExecuteScalar());
                if (n == 0)
                {
                    SqlCommand command = new SqlCommand("DELETE FROM Universitati WHERE Code = @Code", myCon);
                    command.Parameters.Add("@Code", SqlDbType.Int).Value = int.Parse(textBox_CodeUniv.Text);
                    command.ExecuteNonQuery();

                    ListBox_Fill();
                    textBox_IdUniv.Clear();
                    textBox_NameUniv.Clear();
                    textBox_City.Clear();
                    textBox_CodeUniv.Clear();
                }
                else MessageBox.Show("Universitatea are facultati");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            myCon.Close();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

        }
    }
}
