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
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.filmeTableAdapter.GetDataBy(textBox1.Text);
            this.filmeTableAdapter.DeleteFilm(textBox1.Text);
            this.tableAdapterManager.UpdateAll(this.movieDatabaseDataSet);
            this.filmeTableAdapter.Fill(this.movieDatabaseDataSet.Filme);
            Form3 form = new Form3();
            form.Show();
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
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }
    }
}
