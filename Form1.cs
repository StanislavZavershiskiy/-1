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

namespace GSM_TO3
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;
        SqlDataReader dataReader = null;
      
        private DataTable dataTable = null;
        DataSet myDataSet = null;
        SqlDataAdapter dataAdapter = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Entrance entrance = new Entrance();
            entrance.Show();

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            string sCommand = "";
            comboBox2.Text = "";
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Avto"].ConnectionString);
            sqlConnection.Open();

            sCommand = "SELECT DEPARTMENTS.Department FROM DEPARTMENTS";

            try
            {
                SqlCommand command = new SqlCommand(sCommand, sqlConnection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    comboBox2.Items.Add(dataReader["Department"]);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader != null && dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }
            dataReader.Close();

            // департаменты 

            comboBox3.Text = "";
            comboBox3.Items.Clear();
            string sCommand1 = "";
            sCommand1 = $"SELECT DEPARTMENTS.Department FROM DEPARTMENTS";
            try
            {
                SqlCommand command = new SqlCommand(sCommand1, sqlConnection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    comboBox3.Items.Add(dataReader["Department"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader != null && dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }
            dataReader.Close();

            // МАРКИ АВТО
            comboBox4.Text = "";
            comboBox4.Items.Clear();
            string sCommand2 = "";
            sCommand2 = $"SELECT STAMPS.Brands FROM STAMPS";
            try
            {
                SqlCommand command = new SqlCommand(sCommand2, sqlConnection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    comboBox4.Items.Add(dataReader["Brands"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader != null && dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }
            dataReader.Close();

            // ТИП ТОПЛИВА
            comboBox6.Text = "";
            comboBox6.Items.Clear();
            string sCommand7 = "";
            sCommand7 = $"SELECT TYPE_FUEL.Type_fuel FROM TYPE_FUEL";
            try
            {
                SqlCommand command = new SqlCommand(sCommand7, sqlConnection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    comboBox6.Items.Add(dataReader["Type_fuel"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader != null && dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }
            dataReader.Close();

            // ОБЪЁМ ДВИГАТЕЛЯ 
            comboBox8.Text = "";
            comboBox8.Items.Clear();
            string sCommand11 = "";
            sCommand11 = $"SELECT VOLUME.Volumes FROM VOLUME";
            try
            {
                SqlCommand command = new SqlCommand(sCommand11, sqlConnection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    comboBox8.Items.Add(dataReader["Volumes"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader != null && dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }
            dataReader.Close();

            // НОМЕР МАШИНЫ
            comboBox9.Text = "";
            comboBox9.Items.Clear();
            string sCommand12 = "";
            sCommand12 = $"SELECT STATE_NUMS.State_Num FROM STATE_NUMS";
            try
            {
                SqlCommand command = new SqlCommand(sCommand12, sqlConnection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    comboBox9.Items.Add(dataReader["State_Num"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader != null && dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }
            dataReader.Close();


            // НОМЕР ДВИГАТЕЛЯ
            comboBox10.Text = "";
            comboBox10.Items.Clear();
            string sCommand14 = "";
            sCommand14 = $"SELECT Engines.SerialNumber FROM Engines";
            try
            {
                SqlCommand command14 = new SqlCommand(sCommand14, sqlConnection);
                dataReader = command14.ExecuteReader();
                while (dataReader.Read())
                {
                    comboBox10.Items.Add(dataReader["SerialNumber"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader != null && dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }
            dataReader.Close();

            //  ВОДИТЕЛЬ ФАМИЛИЯ
            comboBox13.Text = "";
            comboBox13.Items.Clear();
            string sCommand15 = "";
            sCommand15 = $"SELECT DRIVERS.Surnames FROM DRIVERS   ";
            try
            {
                SqlCommand command15 = new SqlCommand(sCommand15, sqlConnection);
                dataReader = command15.ExecuteReader();
                while (dataReader.Read())
                {
                    comboBox13.Items.Add(dataReader["Surnames"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader != null && dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }
            dataReader.Close();

            //НОМЕР АВТО

            comboBox12.Text = "";
            comboBox12.Items.Clear();
            string sCommand16 = "";
            sCommand16 = $"SELECT STATE_NUMS.State_Num FROM STATE_NUMS";
            try
            {
                SqlCommand command16 = new SqlCommand(sCommand16, sqlConnection);
                dataReader = command16.ExecuteReader();
                while (dataReader.Read())
                {
                    comboBox12.Items.Add(dataReader["State_Num"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader != null && dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }
            dataReader.Close();








        }





        private void button2_Click(object sender, EventArgs e)
        {

            string COM = $"SELECT DEPARTMENTS.ID_Departments FROM DEPARTMENTS WHERE Department = '{comboBox3.Text}'";
            SqlCommand sComand3 = new SqlCommand(COM, sqlConnection);
            string data = "";
            SqlDataReader reader;
            reader = sComand3.ExecuteReader();
            int ID = 0;
            while (reader.Read())
            {
                ID = Convert.ToInt32(reader["ID_Departments"]);
            }

            reader.Close();

            SqlCommand sComand2 = new SqlCommand($"INSERT INTO [DRIVERS] (Surnames,Names,Patronymics,Licences,ID_Departments) VALUES (N'{textBox8.Text}', N'{textBox13.Text}', N'{textBox14.Text}', N'{textBox15.Text}' , {ID})",sqlConnection);
           
            MessageBox.Show($"{ sComand2.ExecuteNonQuery()} +  Водитель добавлен + {data}");

            reader.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox12.Text = "";
            comboBox1.Items.Clear();
            comboBox12.Items.Clear();
            string sCommand1 = "";
            string sCommand2 = "";
            sCommand1 = $"SELECT MODELS.Titele FROM MODELS JOIN CARS ON MODELS.ID_Models = CARS.ID_Models JOIN DEPARTMENTS ON DEPARTMENTS.ID_Departments = CARS.ID_Departmets WHERE DEPARTMENTS.Department = '{comboBox2.Text}'";

            try
            {
                SqlCommand command1 = new SqlCommand(sCommand1, sqlConnection);
                dataReader = command1.ExecuteReader();

                while (dataReader.Read())
                {
                    comboBox1.Items.Add(dataReader["Titele"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader != null && dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }
            dataReader.Close();

            sCommand2 = $" SELECT STATE_NUMS.State_Num FROM STATE_NUMS JOIN CARS ON STATE_NUMS.ID_State_Num = CARS.ID_Models JOIN DEPARTMENTS ON DEPARTMENTS.ID_Departments = CARS.ID_Departmets WHERE DEPARTMENTS.Department = '{comboBox2.Text}'";

            try
            {

                SqlCommand command2 = new SqlCommand(sCommand2, sqlConnection);

                dataReader = command2.ExecuteReader();
                while (dataReader.Read())
                {
                    comboBox12.Items.Add(dataReader["State_Num"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader != null && dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }
            dataReader.Close();

            //SELECT STATE_NUMS.State_Num FROM STATE_NUMS JOIN CARS ON STATE_NUMS.ID_State_Num = CARS.ID_Models JOIN DEPARTMENTS ON DEPARTMENTS.ID_Departments = CARS.ID_Departmets WHERE DEPARTMENTS.Department = 'Автотранспортная группа'








        }

        private void button3_Click(object sender, EventArgs e)
        {
            string com = $"SELECT DRIVERS.Surnames AS 'Фамилия', DRIVERS.Names  AS 'Имя', DRIVERS.Patronymics AS 'Отчество',DRIVERS.Licences AS 'ВУ',DEPARTMENTS.Department FROM DRIVERS JOIN DEPARTMENTS ON DRIVERS.ID_Departments = DEPARTMENTS.ID_Departments WHERE DEPARTMENTS.Department = '{comboBox3.Text}'";
            dataAdapter = new SqlDataAdapter(com, sqlConnection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns[3].Width =220;

        }

       

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox5.Text = "";
            comboBox5.Items.Clear();
            string sCommand1 = "";
            sCommand1 = $"SELECT MODELS.Titele FROM MODELS  JOIN STAMPS ON STAMPS.ID_Stamps = MODELS.ID_Stamps WHERE STAMPS.Brands = '{comboBox4.Text}'";
            try
            {
                SqlCommand command = new SqlCommand(sCommand1, sqlConnection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    comboBox5.Items.Add(dataReader["Titele"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader != null && dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }
            dataReader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Модель по марке ID

            string COM1 = $"SELECT MODELS.ID_Models FROM MODELS  WHERE MODELS.Titele = '{comboBox5.Text}'";
            SqlCommand sComand2 = new SqlCommand(COM1, sqlConnection);
           // string data1 = "";
            SqlDataReader reader3;
            reader3 = sComand2.ExecuteReader();
            int ID1 = 0;
            while (reader3.Read())
            {
                ID1 = Convert.ToInt32(reader3["ID_Models"]);
            }
            reader3.Close();

            // Двигатель по ID

            string COM2 = $" SELECT Engines.ID_Engines FROM [Engines]  WHERE Engines.SerialNumber = '{comboBox10.Text} '";
            SqlCommand sComand1 = new SqlCommand(COM2, sqlConnection);
            //string data2 = "";
            SqlDataReader reader1;
            reader1 = sComand1.ExecuteReader();
            int ID2 = 0;
            while (reader1.Read())
            {
                ID2 = Convert.ToInt32(reader1["ID_Engines"]);
            }
            reader1.Close();
            
            // НОМЕР МАШИНЫ ID

            string COM3 = $" SELECT STATE_NUMS.ID_State_Num FROM [STATE_NUMS]  WHERE State_Num = '{comboBox9.Text}' ";
            SqlCommand sComand5 = new SqlCommand(COM3, sqlConnection);
            //string data3 = "";
            SqlDataReader reader2;
            reader2 = sComand5.ExecuteReader();
            int ID3 = 0;
            while (reader2.Read())
            {
                ID3 = Convert.ToInt32(reader2["ID_State_Num"]);
            }
            reader2.Close();


            // ПОДРАЗДЕЛЕНИЕ ПО ID

            string COM = $"SELECT DEPARTMENTS.ID_Departments FROM DEPARTMENTS WHERE Department = '{comboBox3.Text}'";
            SqlCommand sComand3 = new SqlCommand(COM, sqlConnection);
            //string data = "";
            SqlDataReader reader5;
            reader5 = sComand3.ExecuteReader();
            int ID = 0;
            while (reader5.Read())
            {
                ID = Convert.ToInt32(reader5["ID_Departments"]);
            }

            reader5.Close();
            

            //ВНЕСЕНИЕ В ТАБЛИЦУ CARS (АВОМОБИЛИ)

            SqlCommand sComand6 = new SqlCommand($"INSERT INTO [CARS] (Year_of_prod, Сolour, VIN, ID_Models, ID_Engines, ID_State_Num, ID_Departmets) VALUES ('{dateTimePicker1.Value}', N'{textBox16.Text}', N'{textBox4.Text}', {ID1}, {ID2}, {ID3},{ID})", sqlConnection);

            MessageBox.Show($"{ sComand6.ExecuteNonQuery()} +  Добавлена единица автотранспорт  ");

            //reader.Close();

            




        }


        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox7.Text = "";
            comboBox7.Items.Clear();
            string sCommand1 = "";
            sCommand1 = $"SELECT TYPE_FUEL.Coeficent FROM TYPE_FUEL WHERE TYPE_FUEL.Type_fuel = '{comboBox6.Text}'";
            try
            {
                SqlCommand command = new SqlCommand(sCommand1, sqlConnection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    comboBox7.Items.Add(dataReader["Coeficent"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader != null && dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }
            dataReader.Close();

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            // Create a new DateTimePicker control and initialize it.
            DateTimePicker dateTimePicker1 = new DateTimePicker();

            // Set the MinDate and MaxDate.
            dateTimePicker1.MinDate = new DateTime(1985, 6, 20);
            dateTimePicker1.MaxDate = DateTime.Today;

            // Set the CustomFormat string.
            dateTimePicker1.CustomFormat = "MMMM dd, yyyy - dddd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            // Show the CheckBox and display the control as an up-down control.
            dateTimePicker1.ShowCheckBox = true;
            dateTimePicker1.ShowUpDown = true;
            
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {


            string COM4 = $"SELECT TYPE_FUEL.ID_Type_fuel FROM TYPE_FUEL WHERE Type_fuel = '{comboBox6.Text}'";
            SqlCommand sComand8 = new SqlCommand(COM4, sqlConnection);
            //string data4 = "";
            SqlDataReader reader5;
            reader5 = sComand8.ExecuteReader();
            int ID4 = 0;
            while (reader5.Read())
            {
                ID4 = Convert.ToInt32(reader5["ID_Type_fuel"]);
            }

            reader5.Close();

            //ОБЪЕМ ПО ID  РАЗОБРАТЬСЯ ПРИ ИНТОВОМ ЗНАЧЕНИИ ОТРАБАТЫВАЕТ НОРМАЛЬНО ПРИ ФЛОАТ ОШИБКА

            string COM5 = $" SELECT VOLUME.ID_Volumes FROM VOLUME  WHERE Volumes = {Convert.ToDouble(comboBox8.Text)} ";
            SqlCommand sComand10 = new SqlCommand(COM5, sqlConnection);
            //string data5 = "";
            SqlDataReader reader6;
            reader6 = sComand10.ExecuteReader();
            int ID5 = 0;
            while (reader6.Read())
            {
                ID5 = Convert.ToInt32(reader6["ID_Volumes"]);
            }
            reader6.Close();

            // ДАТА 

            // ВНЕСЕНИЕ ДВИГАТЕЛИ
            SqlCommand sComand9 = new SqlCommand($"INSERT INTO [Engines] (SerialNumber,Nominal,WinterNominal,E_City,E_Urban,E_Town,E_Borough,E_Village,E_Route_Category_I_III,E_Route_Category_IV_V,E_CargoMileages,E_HighlandsBig,E_Highlands,E_MiddleMountains,E_LowMountains, ID_Volumes,ID_Type_fuel) VALUES (N'{textBox5.Text}', {Convert.ToDouble(textBox11.Text)}, {Convert.ToDouble(textBox12.Text)},{Convert.ToDouble(textBox3.Text)},{Convert.ToDouble(textBox27.Text)},{Convert.ToDouble(textBox28.Text)},{Convert.ToDouble(textBox29.Text)},{Convert.ToDouble(textBox30.Text)},{Convert.ToDouble(textBox31.Text)},{Convert.ToDouble(textBox32.Text)},{Convert.ToDouble(textBox38.Text)},{Convert.ToDouble(textBox33.Text)},{Convert.ToDouble(textBox34.Text)},{Convert.ToDouble(textBox35.Text)},{Convert.ToDouble(textBox36.Text)}, {ID5}, {ID4})", sqlConnection);

            MessageBox.Show($"{ sComand9.ExecuteNonQuery()} +  Добавлен двигатель ");

            //reader.Close();





        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            // Создайте новый элемент управления DateTimePicker и инициализируйте его.
            DateTimePicker dateTimePicker1 = new DateTimePicker();

            // используйте minDate и maxDate.
            dateTimePicker1.MinDate = new DateTime(1985, 6, 20);
            dateTimePicker1.MaxDate = DateTime.Today;

            // Задайте строку пользовательского формата.
            dateTimePicker1.CustomFormat = " dd MMMM , yyyy - dddd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            // Установите флажок и отобразите элемент управления в виде элемента управления вверх-вниз.
            dateTimePicker1.ShowCheckBox = true;
            dateTimePicker1.ShowUpDown = true;
        }






        private void INSERT_MILEAGE_Click(object sender, EventArgs e)
        {
            string COM = $"SELECT DEPARTMENTS.ID_Departments FROM DEPARTMENTS WHERE Department = '{comboBox2.Text}'";
            SqlCommand sComand = new SqlCommand(COM, sqlConnection);
            //string data = "";
            SqlDataReader reader;
            reader = sComand.ExecuteReader();
            int ID = 0;
            while (reader.Read())
            {
                ID = Convert.ToInt32(reader["ID_Departments"]);
            }
            reader.Close();

            string COM1 = $" SELECT DRIVERS.ID_Drivers FROM DRIVERS  WHERE Surnames = '{comboBox13.Text}' ";
            SqlCommand sComand1 = new SqlCommand(COM1, sqlConnection);
            //string data5 = "";
            SqlDataReader reader1;
            reader1 = sComand1.ExecuteReader();
            int ID1 = 0;
            while (reader1.Read())
            {
                ID1 = Convert.ToInt32(reader1["ID_Drivers"]);
            }
            reader1.Close();


            string COM2 = $" SELECT STATE_NUMS.ID_State_Num FROM [STATE_NUMS]  WHERE State_Num = '{comboBox12.Text}' ";
            SqlCommand sComand2 = new SqlCommand(COM2, sqlConnection);
            //string data5 = "";
            SqlDataReader reader2;
            reader2 = sComand2.ExecuteReader();
            int ID2 = 0;
            while (reader2.Read())
            {
                ID2 = Convert.ToInt32(reader2["ID_State_Num"]);
            }
            reader2.Close();



            string COM3 = $" SELECT CARS.ID_Cars FROM  CARS JOIN STATE_NUMS ON  STATE_NUMS.ID_State_Num = CARS.ID_Cars  WHERE STATE_NUMS.State_Num =  '{comboBox12.Text}' ";
            SqlCommand sComand3 = new SqlCommand(COM3, sqlConnection);
            //string data5 = "";
            SqlDataReader reader3;
            reader3 = sComand3.ExecuteReader();
            int ID3 = 0;
            while (reader3.Read())
            {
                ID3 = Convert.ToInt32(reader3["ID_Cars"]);
            }
            reader3.Close();




            SqlCommand sComand23 = new SqlCommand($"INSERT INTO [MILEAGE] (Dates,ID_Departments,ID_Drivers,ID_State_Num,ID_Cars,Waybills,BeforeЕxit,AfterExit,M_City,M_Urban,M_Town,M_Borough,M_Village,M_Route_Category_I_III,M_Route_Category_IV_V,M_Weight,M_CargoMileages,M_HighlandsBig,M_Highlands,M_MiddleMountains,M_LowMountains ) VALUES (@par23,@par24,@par25,@par26, @par27,@par28, @par29, @par30,@par31, @par32, @par33,@par34, @par35,@par36,@par37,@par38,@par39,@par40,@par41,@par42,@par43)", sqlConnection);
            sComand23.Parameters.AddWithValue(@"par23", dateTimePicker2.Value);
            sComand23.Parameters.AddWithValue(@"par24", ID);
            sComand23.Parameters.AddWithValue(@"par25", ID1);
            sComand23.Parameters.AddWithValue(@"par26", ID2);
            sComand23.Parameters.AddWithValue(@"par27", ID3);
            sComand23.Parameters.AddWithValue(@"par28", textBox24.Text);
            sComand23.Parameters.AddWithValue(@"par29", Convert.ToDouble(textBox10.Text));
            sComand23.Parameters.AddWithValue(@"par30", Convert.ToDouble(textBox17.Text));
            sComand23.Parameters.AddWithValue(@"par31", Convert.ToDouble(textBox1.Text));
            sComand23.Parameters.AddWithValue(@"par32", Convert.ToDouble(textBox2.Text));
            sComand23.Parameters.AddWithValue(@"par33", Convert.ToDouble(textBox6.Text));
            sComand23.Parameters.AddWithValue(@"par34", Convert.ToDouble(textBox7.Text));
            sComand23.Parameters.AddWithValue(@"par35", Convert.ToDouble(textBox9.Text));
            sComand23.Parameters.AddWithValue(@"par36", Convert.ToDouble(textBox18.Text));
            sComand23.Parameters.AddWithValue(@"par37", Convert.ToDouble(textBox19.Text));
            sComand23.Parameters.AddWithValue(@"par38", Convert.ToDouble(textBox25.Text));
            sComand23.Parameters.AddWithValue(@"par39", Convert.ToDouble(textBox26.Text));
            sComand23.Parameters.AddWithValue(@"par40", Convert.ToDouble(textBox20.Text));
            sComand23.Parameters.AddWithValue(@"par41", Convert.ToDouble(textBox22.Text));
            sComand23.Parameters.AddWithValue(@"par42", Convert.ToDouble(textBox21.Text));
            sComand23.Parameters.AddWithValue(@"par43", Convert.ToDouble(textBox23.Text));
           // sComand23.Parameters.AddWithValue(@"par44", (Convert.ToDouble(textBox1.Text) * colvalCity / 100.0) + (Convert.ToDouble(textBox2.Text) * colvalUrban / 100.0) + (Convert.ToDouble(textBox6.Text) * colvalTown / 100.0) + (Convert.ToDouble(textBox7.Text) * colvalBorough / 100.0) + (Convert.ToDouble(textBox9.Text) * colvalVillage / 100.0) + (Convert.ToDouble(textBox18.Text) * colvalRoute_Category_I_III / 100.0) + (Convert.ToDouble(textBox19.Text) * colvalRouteRoute_Category_IV_V / 100.0) + (Convert.ToDouble(textBox26.Text) * colvalCargoMileages / 100.0) + (Convert.ToDouble(textBox20.Text) * colvalHighlandsBig / 100) + (Convert.ToDouble(textBox22.Text) * colvalHighlands / 100.0) + (Convert.ToDouble(textBox21.Text) * colvalMiddleMountains / 100.0) + (Convert.ToDouble(textBox23.Text) * colvalLowMountains / 100.0));
            
            MessageBox.Show($"{ sComand23.ExecuteNonQuery()} +  Добавлен пробег автомобиля за сутки ");






            string COM4 = $"SELECT  Engines.E_City FROM Engines  JOIN CARS ON CARS.ID_Cars = Engines. ID_Engines WHERE ID_Cars= {ID3}";
            SqlCommand sComand4 = new SqlCommand(COM4, sqlConnection);
            //string data = "";
            SqlDataReader reader4;
            reader4 = sComand4.ExecuteReader();
            double colvalCity = 0;
            while (reader4.Read())
            {
                colvalCity = Convert.ToDouble(reader4["E_City"]);
            }
            reader4.Close();

            string COM5 = $"SELECT  Engines.E_Urban FROM Engines  JOIN CARS ON CARS.ID_Cars = Engines. ID_Engines WHERE ID_Cars ={ID3}";
            SqlCommand sComand5 = new SqlCommand(COM5, sqlConnection);
            //string data = "";
            SqlDataReader reader5;
            reader5 = sComand5.ExecuteReader();
            double colvalUrban = 0;
            while (reader5.Read())
            {
                colvalUrban = Convert.ToDouble(reader5["E_Urban"]);
            }
            reader5.Close();


            string COM6 = $"SELECT  Engines.E_Town FROM Engines  JOIN CARS ON CARS.ID_Cars = Engines. ID_Engines WHERE ID_Cars ={ID3}";
            SqlCommand sComand6 = new SqlCommand(COM6, sqlConnection);
            //string data = "";
            SqlDataReader reader6;
            reader6 = sComand6.ExecuteReader();
            double colvalTown = 0;
            while (reader6.Read())
            {
                colvalUrban = Convert.ToDouble(reader6["E_Town"]);
            }
            reader6.Close();


            string COM7 = $"SELECT  Engines.E_Borough FROM Engines  JOIN CARS ON CARS.ID_Cars = Engines. ID_Engines WHERE ID_Cars ={ID3}";
            SqlCommand sComand7 = new SqlCommand(COM7, sqlConnection);
            //string data = "";
            SqlDataReader reader7;
            reader7 = sComand7.ExecuteReader();
            double colvalBorough = 0;
            while (reader7.Read())
            {
                colvalBorough = Convert.ToDouble(reader7["E_Borough"]);
            }
            reader7.Close();

            string COM8 = $"SELECT  Engines.E_Village FROM Engines  JOIN CARS ON CARS.ID_Cars = Engines. ID_Engines WHERE ID_Cars ={ID3}";
            SqlCommand sComand8 = new SqlCommand(COM8, sqlConnection);
            //string data = "";
            SqlDataReader reader8;
            reader8 = sComand8.ExecuteReader();
            double colvalVillage = 0;
            while (reader8.Read())
            {
                colvalVillage = Convert.ToDouble(reader8["E_Village"]);
            }
            reader8.Close();


            string COM9 = $"SELECT  Engines.E_Route_Category_I_III FROM Engines  JOIN CARS ON CARS.ID_Cars = Engines. ID_Engines WHERE ID_Cars= {ID3}";
            SqlCommand sComand9 = new SqlCommand(COM9, sqlConnection);
            //string data = "";
            SqlDataReader reader9;
            reader9 = sComand9.ExecuteReader();
            double colvalRoute_Category_I_III = 0;
            while (reader9.Read())
            {
                colvalRoute_Category_I_III = Convert.ToDouble(reader9["E_Route_Category_I_III"]);
            }
            reader9.Close();


            string COM10 = $"SELECT  Engines.E_Route_Category_IV_V FROM Engines  JOIN CARS ON CARS.ID_Cars = Engines. ID_Engines WHERE ID_Cars ={ID3}";
            SqlCommand sComand10 = new SqlCommand(COM10, sqlConnection);
            //string data = "";
            SqlDataReader reader10;
            reader10 = sComand10.ExecuteReader();
            double colvalRouteRoute_Category_IV_V = 0;
            while (reader10.Read())
            {
                colvalRouteRoute_Category_IV_V = Convert.ToDouble(reader10["E_Route_Category_IV_V"]);
            }
            reader10.Close();



            string COM11 = $"SELECT  Engines.E_CargoMileages FROM Engines  JOIN CARS ON CARS.ID_Cars = Engines. ID_Engines WHERE ID_Cars ={ID3}";
            SqlCommand sComand11 = new SqlCommand(COM11, sqlConnection);
            //string data = "";
            SqlDataReader reader11;
            reader11 = sComand11.ExecuteReader();
            double colvalCargoMileages = 0;
            while (reader11.Read())
            {
                colvalCargoMileages = Convert.ToDouble(reader11["E_CargoMileages"]);
            }
            reader11.Close();


            string COM19 = $"SELECT  Engines.E_HighlandsBig FROM Engines  JOIN CARS ON CARS.ID_Cars = Engines. ID_Engines WHERE ID_Cars ={ID3}";
            SqlCommand sComand19 = new SqlCommand(COM19, sqlConnection);
            //string data = "";
            SqlDataReader reader19;
            reader19 = sComand19.ExecuteReader();
            double colvalHighlandsBig = 0;
            while (reader19.Read())
            {
                colvalHighlandsBig = Convert.ToDouble(reader19["E_HighlandsBig"]);
            }
            reader19.Close();


            string COM13 = $"SELECT  Engines.E_Highlands FROM Engines  JOIN CARS ON CARS.ID_Cars = Engines. ID_Engines WHERE ID_Cars ='{ID3}'";
            SqlCommand sComand13 = new SqlCommand(COM13, sqlConnection);
            //string data = "";
            SqlDataReader reader13;
            reader13 = sComand13.ExecuteReader();
            double colvalHighlands = 0;
            while (reader13.Read())
            {
                colvalHighlands = Convert.ToDouble(reader13["E_Highlands"]);
            }
            reader13.Close();

            string COM14 = $"SELECT  Engines.E_MiddleMountains FROM Engines  JOIN CARS ON CARS.ID_Cars = Engines. ID_Engines WHERE ID_Cars= {ID3}";
            SqlCommand sComand14 = new SqlCommand(COM14, sqlConnection);
            //string data = "";
            SqlDataReader reader14;
            reader14 = sComand14.ExecuteReader();
            double colvalMiddleMountains = 0;
            while (reader14.Read())
            {
                colvalMiddleMountains = Convert.ToDouble(reader14["E_MiddleMountains"]);
            }
            reader14.Close();

            string COM15 = $"SELECT  Engines.E_LowMountains FROM Engines  JOIN CARS ON CARS.ID_Cars = Engines. ID_Engines WHERE ID_Cars ={ID3} ";
            SqlCommand sComand15 = new SqlCommand(COM15, sqlConnection);
            //string data = "";
            SqlDataReader reader15;
            reader15 = sComand15.ExecuteReader();
            double colvalLowMountains = 0;
            while (reader15.Read())
            {
                colvalLowMountains = Convert.ToDouble(reader15["E_LowMountains"]);
            }
            reader15.Close();






            SqlCommand sComand22 = new SqlCommand("INSERT INTO [CONSUMPTION] (Dates,ID_Departments,ID_Drivers,ID_State_Num,ID_Cars,Waybills,BeforeЕxit,AfterExit,City,Urban,Town,Borough,Village,Route_Category_I_III,Route_Category_IV_V,C_Weight,CargoMileages,HighlandsBig,Highlands,MiddleMountains,LowMountains,Consumptions) VALUES (@par1,@par2,@par3,@par4,@par5,@par6,@par7,@par8,@par9,@par10,@par11,@par12,@par13,@par14,@par15,@par16,@par17,@par18,@par19,@par20,@par21,@par22)", sqlConnection);
            sComand22.Parameters.AddWithValue(@"par1", dateTimePicker2.Value);
            sComand22.Parameters.AddWithValue(@"par2", ID);
            sComand22.Parameters.AddWithValue(@"par3", ID1);
            sComand22.Parameters.AddWithValue(@"par4", ID2);
            sComand22.Parameters.AddWithValue(@"par5", ID3);
            sComand22.Parameters.AddWithValue(@"par6", textBox24.Text);
            sComand22.Parameters.AddWithValue(@"par7", Convert.ToDouble(textBox37.Text));
            sComand22.Parameters.AddWithValue(@"par8", Convert.ToDouble(textBox37.Text) + Convert.ToDouble(textBox39.Text) - (Convert.ToDouble(textBox1.Text) * colvalCity / 100.0) - (Convert.ToDouble(textBox2.Text) * colvalUrban / 100.0) - (Convert.ToDouble(textBox6.Text) * colvalTown / 100.0) - (Convert.ToDouble(textBox7.Text) * colvalBorough / 100.0) - (Convert.ToDouble(textBox9.Text) * colvalVillage / 100.0) - (Convert.ToDouble(textBox18.Text) * colvalRoute_Category_I_III / 100.0) - (Convert.ToDouble(textBox19.Text) * colvalRouteRoute_Category_IV_V / 100.0) - (Convert.ToDouble(textBox26.Text) * colvalCargoMileages / 100.0) - (Convert.ToDouble(textBox20.Text) * colvalHighlandsBig / 100.0) - (Convert.ToDouble(textBox22.Text) * colvalHighlands / 100.0) - (Convert.ToDouble(textBox21.Text) * colvalMiddleMountains / 100.0) - (Convert.ToDouble(textBox23.Text) * colvalLowMountains / 100.0));
            sComand22.Parameters.AddWithValue(@"par9", Convert.ToDouble(textBox1.Text) * colvalCity / 100.0);
            sComand22.Parameters.AddWithValue(@"par10", Convert.ToDouble(textBox2.Text) * colvalUrban / 100.0);
            sComand22.Parameters.AddWithValue(@"par11", Convert.ToDouble(textBox6.Text) * colvalTown / 100.0);
            sComand22.Parameters.AddWithValue(@"par12", Convert.ToDouble(textBox7.Text) * colvalBorough / 100.0);
            sComand22.Parameters.AddWithValue(@"par13", Convert.ToDouble(textBox9.Text) * colvalVillage / 100.0);
            sComand22.Parameters.AddWithValue(@"par14", Convert.ToDouble(textBox18.Text) * colvalRoute_Category_I_III / 100.0);
            sComand22.Parameters.AddWithValue(@"par15", Convert.ToDouble(textBox19.Text) * colvalRouteRoute_Category_IV_V / 100.0);
            sComand22.Parameters.AddWithValue(@"par16", Convert.ToDouble(textBox25.Text));
            sComand22.Parameters.AddWithValue(@"par17", Convert.ToDouble(textBox26.Text) * colvalCargoMileages / 100.0);
            sComand22.Parameters.AddWithValue(@"par18", Convert.ToDouble(textBox20.Text) * colvalHighlandsBig / 100.0);
            sComand22.Parameters.AddWithValue(@"par19", Convert.ToDouble(textBox22.Text) * colvalHighlands / 100.0);
            sComand22.Parameters.AddWithValue(@"par20", Convert.ToDouble(textBox21.Text) * colvalMiddleMountains / 100.0);
            sComand22.Parameters.AddWithValue(@"par21", Convert.ToDouble(textBox23.Text) * colvalLowMountains / 100.0);
            sComand22.Parameters.AddWithValue(@"par22", (Convert.ToDouble(textBox1.Text) * colvalCity / 100.0) + (Convert.ToDouble(textBox2.Text) * colvalUrban / 100.0) + (Convert.ToDouble(textBox6.Text) * colvalTown / 100.0) + (Convert.ToDouble(textBox7.Text) * colvalBorough / 100.0) + (Convert.ToDouble(textBox9.Text) * colvalVillage / 100.0) + (Convert.ToDouble(textBox18.Text) * colvalRoute_Category_I_III / 100.0) + (Convert.ToDouble(textBox19.Text) * colvalRouteRoute_Category_IV_V / 100.0) + (Convert.ToDouble(textBox26.Text) * colvalCargoMileages / 100.0) + (Convert.ToDouble(textBox20.Text) * colvalHighlandsBig / 100) + (Convert.ToDouble(textBox22.Text) * colvalHighlands / 100.0) + (Convert.ToDouble(textBox21.Text) * colvalMiddleMountains / 100.0) + (Convert.ToDouble(textBox23.Text) * colvalLowMountains / 100.0));
            MessageBox.Show($"{ sComand22.ExecuteNonQuery()} +  Добавлен расход топливая за сутки ");
           


        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox11.Text = "";
            comboBox11.Items.Clear();

            
            string sCommand = "";
            sCommand = $"SELECT STAMPS.Brands  FROM STAMPS  JOIN MODELS ON MODELS.ID_Stamps = STAMPS.ID_Stamps WHERE MODELS.Titele = '{comboBox1.Text}'";
            try
            {
                SqlCommand command = new SqlCommand(sCommand, sqlConnection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    comboBox11.Items.Add(dataReader["Brands"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader != null && dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }
            dataReader.Close();
        }

       
        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
