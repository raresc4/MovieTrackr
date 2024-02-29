using MovieDatabase.MovieDatabaseDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MovieDatabase
{
    public partial class Form4 : Form
    {
        Utilizator utilizator;
        public Form4(Utilizator utilizator)
        {
            InitializeComponent();
            this.utilizator = utilizator;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = this.filmeTableAdapter.GetDataBy1(textBox1.Text);
            if(result.Rows.Count == 0 )
            {
                textBox1.Text = string.Empty;
                MessageBox.Show("The movie you're trying to delete does not exist!");
                return;
            }
            this.filmeTableAdapter.DeleteFilm(textBox1.Text);
            this.tableAdapterManager.UpdateAll(this.movieDatabaseDataSet);
            this.filmeTableAdapter.Fill(this.movieDatabaseDataSet.Filme);
            MessageBox.Show(textBox1.Text + " was deleted succesfully!");
            textBox1.Text = string.Empty;
            Form5 form2 = new Form5(utilizator);
            form2.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void filmeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filmeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.movieDatabaseDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDatabaseDataSet.Filme' table. You can move, or remove it, as needed.
            this.filmeTableAdapter.Fill(this.movieDatabaseDataSet.Filme);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5(utilizator);
            form.Show();
            this.Hide();
        }
    }
}
