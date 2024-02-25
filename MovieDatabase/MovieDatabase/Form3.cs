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
    public partial class Form3 : Form
    {
        Utilizator utilizator;
        public Form3(Utilizator utilizator)
        {
            InitializeComponent();
            this.utilizator = utilizator;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void filmeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filmeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.movieDatabaseDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDatabaseDataSet.Filme' table. You can move, or remove it, as needed.
            this.filmeTableAdapter.Fill(this.movieDatabaseDataSet.Filme);

        }

        private void filmeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool validare(string s)
        {
            for(int i= 0; i<s.Length; i++)
            {
                if (Char.IsDigit(s,i) == false)
                {
                    return false;
                }
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = this.filmeTableAdapter.GetDataBy1(textBox1.Text);
            if (result.Rows.Count != 0)
            {
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                textBox4.Text = string.Empty;
                textBox5.Text = string.Empty;
                MessageBox.Show("Movie already exists!");
                return;
            }
            if(textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0 || textBox4.Text.Length == 0 || textBox4.Text.Length == 0)
            {
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                textBox4.Text = string.Empty;
                textBox5.Text = string.Empty;
                MessageBox.Show("Please enter data in all of the fields!");
                return;
            }
            if(Convert.ToInt32(textBox5.Text) < 1 || Convert.ToInt32(textBox5.Text) > 10 || validare(textBox5.Text) == false)
            {
                textBox5.Text = string.Empty;
                MessageBox.Show("Rating unavailable");
                return;
            }
            this.filmeTableAdapter.InsertFilm(textBox1.Text, Convert.ToInt32(textBox2.Text), textBox3.Text, textBox4.Text, Convert.ToInt32(textBox5.Text),utilizator.Index);
            this.tableAdapterManager.UpdateAll(this.movieDatabaseDataSet);
            this.filmeTableAdapter.Fill(this.movieDatabaseDataSet.Filme);
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5(utilizator);
            form.Show();
            this.Hide();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
