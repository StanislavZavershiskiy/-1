using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;
namespace GSM_TO3
{
    public partial class ADMIN : Form
    {
        private SqlConnection sqlConnection = null;
        SqlDataReader dataReader = null;

        private DataTable dataTable = null;
        DataSet myDataSet = null;
        SqlDataAdapter dataAdapter = null;

           
        public ADMIN()
        {
            InitializeComponent();
        }
        private void ADMIN_Load(object sender, EventArgs e)
        {

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Avto"].ConnectionString);
            sqlConnection.Open();
            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
            connectionStringBuilder.DataSource = "";
            connectionStringBuilder.InitialCatalog = "TEMP";
            connectionStringBuilder.IntegratedSecurity = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Entrance entrance = new Entrance();
            entrance.Show();


           

        }

        private void button3_Click(object sender, EventArgs e)      
        {
            
            
            SqlCommand sComand2323 = new SqlCommand($"INSERT INTO [PAP] (Login,Password) VALUES (N'{Login.Text}', N'{Password.Text}')", sqlConnection);
          
            MessageBox.Show($"{ sComand2323.ExecuteNonQuery()} +  Пользователь зарегистрирован"); 
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           string com = $"SELECT PAP.ID_PAP AS 'Номерпо порядку',  PAP.Login  AS 'Логин', PAP.Password AS 'Пароль' FROM PAP";
            
            dataAdapter = new SqlDataAdapter(com, sqlConnection);
             dataTable = new DataTable();
           

            dataTable.Clear();
            dataAdapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
            dataGridView2.Columns[2].Width = 220;


        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Avto"].ConnectionString);
            sqlConnection.Open();
            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
            connectionStringBuilder.DataSource = "";
            connectionStringBuilder.InitialCatalog = "TEMP";
            connectionStringBuilder.IntegratedSecurity = true;
           */
          
            string scommand555 = $"SELECT PAP.Login FROM  PAP";
            string scommand444 = $"SELECT PAP.Password FROM PAP";
            bool permit = false;
            bool permit2 = false;
            SqlCommand sCommand555 = new SqlCommand(scommand555, sqlConnection); //($"SELECT PAP.Login FROM  PAP.Login= '{ textBox1.Text}' AND PAP.Password= '{ textBox2.Text}'",sqlConnection);
             
            dataReader = sCommand555.ExecuteReader();

            while(dataReader.Read())
            {
                if (textBox1.Text == (dataReader["Login"].ToString()))
                {
                    permit = true;
                    break;
                }
            }
            dataReader.Close();
                      
            SqlCommand sCommand444 = new SqlCommand(scommand444,sqlConnection);

            dataReader = sCommand444.ExecuteReader();

            while(dataReader.Read())
            {
                if (textBox2.Text == (dataReader["Password"].ToString()))
                {
                    permit2 = true;
                    break;
                }
            }

            if (permit2 && permit)
                MessageBox.Show($"Вы авторизировались   ");
            else
                MessageBox.Show($" Не верный пароль или логин ");

            dataReader.Close();

            sqlConnection.Close();

            

        }

        private void button4_Click(object sender, EventArgs e)
        {
         
            MD5 md5 = new MD5CryptoServiceProvider();
            string MD1 = "";
            string MD2 = "";

            MD1 = Login.Text;
            MD2 = Password.Text;
            byte[] checkSum1 = md5.ComputeHash(Encoding.UTF8.GetBytes(MD1));
            MD1 = BitConverter.ToString(checkSum1).Replace("-", String.Empty);
            byte[] checkSum2 = md5.ComputeHash(Encoding.UTF8.GetBytes(MD2));
            MD2 = BitConverter.ToString(checkSum2).Replace("-", String.Empty);

            SqlCommand sComand3333 = new SqlCommand($"INSERT INTO [CHAP] (Login,Password) VALUES (@par333,@par334)", sqlConnection);
            sComand3333.Parameters.AddWithValue(@"par333", MD1);
            sComand3333.Parameters.AddWithValue(@"par334", MD2);


            MessageBox.Show($"{ sComand3333.ExecuteNonQuery()} +  Пользователь зарегистрирован");
           
        }

        

        private void button7_Click(object sender, EventArgs e)
        {

            string com = $"SELECT CHAP.ID_CHAP AS 'Номерпо порядку',  CHAP.Login  AS 'Логин', CHAP.Password AS 'Пароль' FROM CHAP";

            dataAdapter = new SqlDataAdapter(com, sqlConnection);
            dataTable = new DataTable();


            dataTable.Clear();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns[2].Width = 320;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            string MD3 = "";
            string MD4 = "";

            MD3 = Login1.Text;
            MD4 = Password1.Text;
            byte[] checkSum1 = md5.ComputeHash(Encoding.UTF8.GetBytes(MD3));
            MD3 = BitConverter.ToString(checkSum1).Replace("-", String.Empty);
            byte[] checkSum2 = md5.ComputeHash(Encoding.UTF8.GetBytes(MD4));
            MD4 = BitConverter.ToString(checkSum2).Replace("-", String.Empty);

            textBox5.Text = MD3.ToString();

            textBox3.Text = MD4.ToString();


            string scommand565 = $"SELECT CHAP.Login FROM  CHAP";
            string scommand464 = $"SELECT CHAP.Password FROM CHAP";
            bool permit3 = false;
            bool permit4 = false;
            SqlCommand sCommand565 = new SqlCommand(scommand565, sqlConnection); 

            dataReader = sCommand565.ExecuteReader();

            while (dataReader.Read())
            {
                if (MD3 == (dataReader["Login"].ToString()))
                {
                    permit3 = true;
                    break;
                }
            }
            dataReader.Close();

            SqlCommand sCommand464 = new SqlCommand(scommand464, sqlConnection);

            dataReader = sCommand464.ExecuteReader();

            while (dataReader.Read())
            {
                if (MD4 == (dataReader["Password"].ToString()))
                {
                    permit4 = true;
                    break;
                }
            }
            
            if (permit3 && permit4)
                MessageBox.Show($"Вы авторизировались   ");
            else
                MessageBox.Show($" Не верный пароль или логин ");

            dataReader.Close();

            sqlConnection.Close();
            textBox6.Text = permit3.ToString();
            textBox4.Text = permit4.ToString();



        }

        private void button5_Click(object sender, EventArgs e)
        {

            MD5 md5 = new MD5CryptoServiceProvider();
            string MD4 = "";
            string MD5 = "";
            bool MD6= false;
            if (radioButton4.Checked== true)
            {
                MD6 = true;
                                

            }
           

            MD4 = Login.Text;
            MD5 = Password.Text;
            MD6 = radioButton4.Checked;
            byte[] checkSum1 = md5.ComputeHash(Encoding.UTF8.GetBytes(MD4));
            MD4 = BitConverter.ToString(checkSum1).Replace("-", String.Empty);
            byte[] checkSum2 = md5.ComputeHash(Encoding.UTF8.GetBytes(MD5));
            MD5 = BitConverter.ToString(checkSum2).Replace("-", String.Empty);


            SqlCommand sComand4444 = new SqlCommand($"INSERT INTO [ROLE] (Login,Password,Is_Role) VALUES (@par335,@par336,@par337)", sqlConnection);
            sComand4444.Parameters.AddWithValue(@"par335", MD4);
            sComand4444.Parameters.AddWithValue(@"par336", MD5);
            sComand4444.Parameters.AddWithValue(@"par337", MD6);
            MessageBox.Show($"{ sComand4444.ExecuteNonQuery()} +  Пользователь зарегистрирован");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            string MD4 = "";
            string MD5 = "";
            bool MD6 = false;
            if (radioButton4.Checked == true)
            {
                MD6 = true;


            }
            MD4 = Login1.Text;
            MD5 = Password1.Text;
            byte[] checkSum1 = md5.ComputeHash(Encoding.UTF8.GetBytes(MD4));
            MD4 = BitConverter.ToString(checkSum1).Replace("-", String.Empty);
            byte[] checkSum2 = md5.ComputeHash(Encoding.UTF8.GetBytes(MD5));
            MD5 = BitConverter.ToString(checkSum2).Replace("-", String.Empty);

            textBox5.Text = MD4.ToString();

            textBox3.Text = MD5.ToString();


            string scommand575 = $"SELECT ROLE.Login FROM  ROLE";
            string scommand474 = $"SELECT ROLE.Password FROM ROLE";
            string scommand484 = $"SELECT ROLE.Is_Role FROM ROLE";
            bool permit5 = false;
            bool permit6 = false;
            bool permit7 = false;
            SqlCommand sCommand575 = new SqlCommand(scommand575, sqlConnection);

            dataReader = sCommand575.ExecuteReader();

            while (dataReader.Read())
            {
                if (MD4 == (dataReader["Login"].ToString()))
                {
                    permit5 = true;
                    break;
                }
            }
            dataReader.Close();

            SqlCommand sCommand474 = new SqlCommand(scommand474, sqlConnection);

            dataReader = sCommand474.ExecuteReader();

            while (dataReader.Read())
            {
                if (MD4 == (dataReader["Password"].ToString()))
                {
                    permit6 = true;
                    break;
                }
            }
            dataReader.Close();
            SqlCommand sCommand484 = new SqlCommand(scommand484, sqlConnection);

            dataReader = sCommand484.ExecuteReader();

            while (dataReader.Read())
            {
                if (MD6 = (bool)dataReader["Is_Role"])
                {
                    permit7 = true;
                    break;
                }


                if (permit5 && permit6 && permit7)
                    MessageBox.Show($"Вы авторизировались как администратор  ");
                else
                    MessageBox.Show($" Не верный пароль или логин ");

                dataReader.Close();

                if (permit7 == false)
                {
                    if (permit5 && permit6)
                    {

                        MessageBox.Show($"Вы авторизировались как Пользователь  ");

                    }
                    else
                        MessageBox.Show($" Не верный пароль или логин ");

                }


            }

        }
       // Отображение пользователей с ролью
        private void button9_Click(object sender, EventArgs e)
        {


            string com1 = $"SELECT  ROLE.ID_ROLE AS 'Номерпо порядку', ROLE.Login AS 'Логин', ROLE.Password AS 'Пароль', ROLE.Is_Role AS 'Роль' FROM ROLE";

            dataAdapter = new SqlDataAdapter(com1, sqlConnection);
            dataTable = new DataTable();


            dataTable.Clear();
            dataAdapter.Fill(dataTable);
            dataGridView3.DataSource = dataTable;
            dataGridView3.Columns[3].Width = 420;
            


        }

    }
}
