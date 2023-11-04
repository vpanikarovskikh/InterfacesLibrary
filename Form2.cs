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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Иванов Петр Сергеевич", "Младший сотрудник", "7119", "620004", "УМВД по Красноярскому краю", "07.07.2019");
            dataGridView1.Rows.Add("Семенов Иван Аркадьевич", "Старший сотрудник", "7112", "340903", "УМВД по Красноярскому краю", "16.02.2012");

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            string conn = "Host=localhost;Port=5432;Username=postgres;Password=24716;Database=interfacesLibraryDb";
            NpgsqlConnection sqlConn = new NpgsqlConnection(conn);

            sqlConn.Open();
            string sql = "SELECT * FROM employee;";
            NpgsqlCommand command = new NpgsqlCommand(sql, sqlConn);
            using NpgsqlDataReader rdr = command.ExecuteReader();

            while (rdr.Read())
            {
                dataGridView1.Rows.Add(rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4), 
                    rdr.GetString(5), rdr.GetDateTime(6));
            }

            sqlConn.Close();

            //ToolTip t = new ToolTip();
            //t.SetToolTip(button3, "Добавить");
            //t.SetToolTip(button5, "Изменить");
            //t.SetToolTip(button4, "Удалить");

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
            Form f1 = new Form1();
            f1.Show();
        }

        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();
            f3.Show();
        }
    }
}
