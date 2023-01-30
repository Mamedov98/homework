using AdoNetAppHomeWork.Services;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AdoNetAppHomeWork
{
    public partial class Form1 : Form
    {

        private readonly DbConfigService _dbConfigService;
        private string _connectionString;
        public Form1()
        {
            InitializeComponent();
            _dbConfigService = new("FruitandVegetable");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _connectionString = _dbConfigService.GetConnectionString();


        }

        private void button1_Click(object sender, EventArgs e) // 
        {

            DbConfigService configService = new("FruitandVegetable");

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();


            if (_connectionString != null)
            {
                using SqlConnection conn = new(_dbConfigService.GetConnectionString());
                conn.Open();



                using SqlCommand command = new("select * from PRODUCT ", conn);

                var reader = command.ExecuteReader();

                var cols = reader.GetColumnSchema();

                var tables = reader.GetSchemaTable();

                comboBox1.Items.Add(tables);

                foreach (var item in cols)
                {
                    dataGridView1.Columns.Add(item.ColumnName, item.ColumnName);
                }

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);
                }
            }


        }

        private void button2_Click(object sender, EventArgs e) // ÙÛÍÚ˚ 
        {

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();


            DbConfigService configService = new("FruitandVegetable");



            if (_connectionString != null)
            {
                using SqlConnection conn = new(_dbConfigService.GetConnectionString());
                conn.Open();



                using SqlCommand command = new("select * from PRODUCT where  Category = N'Fruits'", conn);

                var reader = command.ExecuteReader();

                var cols = reader.GetColumnSchema();

                var tables = reader.GetSchemaTable();

                comboBox1.Items.Add(tables);

                foreach (var item in cols)
                {
                    dataGridView1.Columns.Add(item.ColumnName, item.ColumnName);
                }

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)  ///     ˆ‚ÂÚ
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            using SqlConnection conn = new(_dbConfigService.GetConnectionString());
            conn.Open();


            using SqlCommand command = new(" SELECT * FROM PRODUCT;", conn);
            SqlDataReader reader = command.ExecuteReader();
            var cols = reader.GetColumnSchema();
            foreach (var item in cols)
            {
                dataGridView1.Columns.Add(item.ColumnName, item.ColumnName);
            }

            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[1],reader[3]);
            }
        }
        private void button4_Click(object sender, EventArgs e)    //  ¿ÀŒ–»» ¬€ÿ≈ N ◊»—À¿

        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            DbConfigService configService = new("FruitandVegetable");



            if (_connectionString != null)
            {
                using SqlConnection conn = new(_dbConfigService.GetConnectionString());
                conn.Open();



                using SqlCommand command = new("SELECT * FROM PRODUCT Where Calories > 50", conn);

                var reader = command.ExecuteReader();

                var cols = reader.GetColumnSchema();

                var tables = reader.GetSchemaTable();

                comboBox1.Items.Add(tables);

                foreach (var item in cols)
                {
                    dataGridView1.Columns.Add(item.ColumnName, item.ColumnName);
                }

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);
                }
            }

        }

        private void MaxCall_Click(object sender, EventArgs e)
        {
           
            DbConfigService configService = new("FruitandVegetable");



            if (_connectionString != null)
            {
                using SqlConnection conn = new(_dbConfigService.GetConnectionString());
                conn.Open();



                using SqlCommand command = new("SELECT MAX(Calories) FROM PRODUCT ", conn);

                var reader = command.ExecuteScalar();

                textBox1.Text = command.ExecuteScalar().ToString();
               

            }


        }
        private void button5_Click(object sender, EventArgs e) // Ã»Õ»Ã¿À‹Õ€…  ¿ÀÀŒ–»…
        {

            DbConfigService configService = new("FruitandVegetable");



            if (_connectionString != null)
            {
                using SqlConnection conn = new(_dbConfigService.GetConnectionString());
                conn.Open();



                using SqlCommand command = new("SELECT MIN(Calories) FROM PRODUCT ", conn);

                var reader = command.ExecuteScalar();

                textBox2.Text = command.ExecuteScalar().ToString();


            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DbConfigService configService = new("FruitandVegetable");



            if (_connectionString != null)
            {
                using SqlConnection conn = new(_dbConfigService.GetConnectionString());
                conn.Open();



                using SqlCommand command = new("SELECT AVG(Calories) FROM PRODUCT ", conn);

                var reader = command.ExecuteScalar();

                textBox3.Text = command.ExecuteScalar().ToString();


            }
        }

        private void button7_Click(object sender, EventArgs e) // ŒÀ»◊≈—“¬Œ ‘–” “Œ¬ 
        {
            using SqlConnection conn = new(_dbConfigService.GetConnectionString());
            conn.Open();



            using SqlCommand command = new("SELECT * FROM PRODUCT Where Category = N'Fruits' ", conn);

            var reader = command.ExecuteReader();

            int countfruit = 0;
            while (reader.Read())
            {
                countfruit++;
            }
            textBox4.Text = countfruit.ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new(_dbConfigService.GetConnectionString());
            conn.Open();



            using SqlCommand command = new("SELECT * FROM PRODUCT Where Category = N'Vegetables' ", conn);

            var reader = command.ExecuteReader();

            int countfruit = 0;
            while (reader.Read())
            {
                countfruit++;
            }
            textBox5.Text = countfruit.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear(); 
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text= string.Empty;
            textBox4.Text= string.Empty;
            textBox5.Text = string.Empty;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            DbConfigService configService = new("FruitandVegetable");



            if (_connectionString != null)
            {
                using SqlConnection conn = new(_dbConfigService.GetConnectionString());
                conn.Open();



                using SqlCommand command = new("SELECT * FROM PRODUCT Where Calories < 50", conn);

                var reader = command.ExecuteReader();

                var cols = reader.GetColumnSchema();

                var tables = reader.GetSchemaTable();

                comboBox1.Items.Add(tables);

                foreach (var item in cols)
                {
                    dataGridView1.Columns.Add(item.ColumnName, item.ColumnName);
                }

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();


            DbConfigService configService = new("FruitandVegetable");



            if (_connectionString != null)
            {
                using SqlConnection conn = new(_dbConfigService.GetConnectionString());
                conn.Open();



                using SqlCommand command = new("select * from PRODUCT where  Category = N'Vegetables'", conn);

                var reader = command.ExecuteReader();

                var cols = reader.GetColumnSchema();

                var tables = reader.GetSchemaTable();

                comboBox1.Items.Add(tables);

                foreach (var item in cols)
                {
                    dataGridView1.Columns.Add(item.ColumnName, item.ColumnName);
                }

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            using SqlConnection conn = new(_dbConfigService.GetConnectionString());
            conn.Open();


            using SqlCommand command = new(" SELECT * FROM PRODUCT where Colour like N'Red';", conn);
            SqlDataReader reader = command.ExecuteReader();
            var cols = reader.GetColumnSchema();
            foreach (var item in cols)
            {
                dataGridView1.Columns.Add(item.ColumnName, item.ColumnName);
            }

            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[1], reader[3]);
            }
        }
    }
}
