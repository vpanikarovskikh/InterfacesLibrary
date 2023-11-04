using Npgsql;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        public string nameIzd;
        public string addressIzd;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void издательстваToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.Show();
        }

        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();
            f3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Пингвин", "г. Москва, ул. Ленина, 26, каб. 501");
            dataGridView1.Rows.Add("Просвещение", "г. Москва, ул. Советская, 320, каб. 212");

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            string conn = "Host=localhost;Port=5432;Username=postgres;Password=24716;Database=interfacesLibraryDb";
            NpgsqlConnection sqlConn = new NpgsqlConnection(conn);

            sqlConn.Open();
            string sql = "SELECT * FROM publisher;";
            NpgsqlCommand command = new NpgsqlCommand(sql, sqlConn);
            using NpgsqlDataReader rdr = command.ExecuteReader();

            while (rdr.Read())
            {
                dataGridView1.Rows.Add(rdr.GetString(1), rdr.GetString(2));
            }

            sqlConn.Close();


            //textBox1.Text = "Введите для поиска записи";//подсказка
            //textBox1.ForeColor = Color.Gray; 

            label2.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            textBox3.Visible = false;
            button6.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Вы хотите удалить эту запись?",
                                     "Удалить?",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // If 'Yes', do something here.
            }
            else
            {
                // If 'No', do something here.
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            label2.Visible = true;
            textBox2.Visible = true;
            label3.Visible = true;
            textBox3.Visible = true;
            button6.Visible = true;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) 
        {
            nameIzd = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            addressIzd = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            label2.Visible = true;
            textBox2.Visible = true;
            label3.Visible = true;
            textBox3.Visible = true;
            button6.Visible = true;
            textBox2.Text = nameIzd;
            textBox3.Text = addressIzd;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string conn = "Host=localhost;Port=5432;Username=postgres;Password=24716;Database=interfacesLibraryDb";
            NpgsqlConnection sqlConn = new NpgsqlConnection(conn);

            sqlConn.Open();
            var izdName = textBox2.Text.ToString();
            var izdAddress = textBox3.Text.ToString();
            string sql = string.Format("INSERT INTO publisher VALUES ('2', '{0}', '{1}');", izdName, izdAddress);
            NpgsqlCommand command = new NpgsqlCommand(sql, sqlConn);
            command.ExecuteNonQuery();
            sqlConn.Close();
        }

        //private void textBox1_Leave(object sender, EventArgs e)//происходит когда элемент стает активным
        //{
        //    if (string.IsNullOrEmpty(textBox1.Text))
        //    {
        //        textBox1.Text = "Введите для поиска записи";//подсказка
        //        textBox1.ForeColor = Color.Gray;
        //    }
        //}
        //private void textBox1_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = null;
        //    textBox1.ForeColor = Color.Black;
        //}
    }
}