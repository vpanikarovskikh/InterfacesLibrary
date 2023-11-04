using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Старший сотрудник");
            dataGridView1.Rows.Add("Младший сотрудник");

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            string conn = "Host=localhost;Port=5432;Username=postgres;Password=24716;Database=interfacesLibraryDb";
            NpgsqlConnection sqlConn = new NpgsqlConnection(conn);

            sqlConn.Open();
            string sql = "SELECT * FROM post;";
            NpgsqlCommand command = new NpgsqlCommand(sql, sqlConn);
            using NpgsqlDataReader rdr = command.ExecuteReader();

            while (rdr.Read())
            {
                dataGridView1.Rows.Add(rdr.GetString(1));
            }

            sqlConn.Close();
            //textBox1.Text = "Введите для поиска записи";//подсказка
            //textBox1.ForeColor = Color.Gray;
        }
        private void textBox1_Leave(object sender, EventArgs e)//происходит когда элемент стает активным
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "Введите для поиска записи";//подсказка
                textBox1.ForeColor = Color.Gray;
            }
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox1.ForeColor = Color.Black;
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.Show();
        }

        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f1 = new Form1();
            f1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
