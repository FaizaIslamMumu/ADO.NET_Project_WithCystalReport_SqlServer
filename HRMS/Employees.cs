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
using System.IO;
using System.Drawing.Imaging;

namespace HRMS
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
            showEmployee();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# R_51\XML_ADO_Crystal_Report\Project_Ado.net_Crystal_Report_sql_c#\Human_Resource_Management_System_CS_ADO.NET_SQL_SERVER\HRMS\payRollDB.mdf;Integrated Security=True");
        private void clear()
        {
            txtName.Text = "";
            cmbGender.SelectedIndex = 0;
            cmbPosition.SelectedIndex = 0;
            cmbQualification.SelectedIndex = 0;
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtSalary.Text = "";
            key = 0;

        }
        private void showEmployee()
        {
            con.Open();
            string Query = "select * from EmployeeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query,con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmployeeDVG.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Employees_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM EmployeeTbl", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            EmployeeDVG.DataSource = dt;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HOME h = new HOME();
            h.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(txtImgPath.Text);
            MemoryStream ms = new MemoryStream();
            img.Save(ms,ImageFormat.Bmp);


            
            if (txtName.Text == "" || txtPhone.Text == "" || cmbGender.SelectedIndex == -1 || txtSalary.Text == "" || txtAddress.Text == "" || cmbQualification.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into EmployeeTbl values(@EN,@EG,@EP,@ED,@EA,@EPOS,@JD,@EQ,@EBS,@EIMG)", con);
                    cmd.Parameters.AddWithValue("@EN", txtName.Text);
                    cmd.Parameters.AddWithValue("@EG", cmbGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@EP", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@ED", DOBdateTimePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@EA", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@EPOS", cmbPosition.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@JD", joinDateTimePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@EQ", cmbQualification.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@EBS", Convert.ToInt32(txtSalary.Text));
                    cmd.Parameters.Add(new SqlParameter("@EIMG", SqlDbType.VarBinary) { Value = ms.ToArray() });


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employees Information Saved Successfully!");
                    LoadGrid();
                    con.Close();
                    showEmployee();
                    clear();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        

        private void btnImgUploader_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                this.picEmp.Image = img;
                txtImgPath.Text = openFileDialog1.FileName;
            }
        }
        int key = 0;


        private void btnEdit_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(txtImgPath.Text);
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Bmp);



            if (txtName.Text == "" || txtPhone.Text == "" || cmbGender.SelectedIndex == -1 || txtSalary.Text == "" || txtAddress.Text == "" || cmbQualification.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update EmployeeTbl set txtName=@EN,txtGender=@EG,txtPhone=,@EP,txtAddress=@EA,txtSalary=@EBS,DOBdateTimePicker=@ED,cmbPosition=@EPOS,joinDateTimePicker=@JD,cmbQualification=@EQ,txtImgPath=@EIMG where EmpId=@EmpKey",con);
                    cmd.Parameters.AddWithValue("@EN", txtName.Text);
                    cmd.Parameters.AddWithValue("@EG", cmbGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@JD", joinDateTimePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@EP", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@EA", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@EPOS", cmbPosition.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ED", DOBdateTimePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@EQ", cmbQualification.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@EBS", txtSalary.Text);
                    cmd.Parameters.Add(new SqlParameter("@EIMG", SqlDbType.VarBinary) { Value = ms.ToArray()});
                    cmd.Parameters.AddWithValue("@EmpKey", key);



                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employees Information Updated Successfully!");
                    con.Close();
                    showEmployee();
                    clear();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(txtImgPath.Text);
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Bmp);



            if (key==0)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from EmployeeTbl WHERE EmpId=@EmpKey", con);
                    cmd.Parameters.AddWithValue("@EmpKey",key);
                    

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employees Information Deleted Successfully!");
                    con.Close();
                    showEmployee();
                    clear();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EmployeeDVG_SelectionChanged(object sender, EventArgs e)
        {
            if (this.EmployeeDVG.SelectedRows.Count > 0)
            {
                 
            }
        }

      
    }
    }

