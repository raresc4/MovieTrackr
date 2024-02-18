using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void utlizatoriBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utlizatoriBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mainDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDataSet.Utlizatori' table. You can move, or remove it, as needed.
            this.utlizatoriTableAdapter.Fill(this.mainDataSet.Utlizatori);

        }

        private void utlizatoriDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = this.utlizatoriTableAdapter.GetUtilizator(textBox1.Text, textBox2.Text);
            if(result.Rows.Count == 0)
            {
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                MessageBox.Show("Utilizatorul nu exista!");
                return;
            }
            MessageBox.Show("Te-ai logat cu succes!");
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
