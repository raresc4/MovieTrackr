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
    public partial class Form5 : Form
    {
        Utilizator utilizator;
        public Form5(Utilizator utilizator)
        {
            InitializeComponent();
            this.utilizator = utilizator;
        }

        private void filmeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filmeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.movieDatabaseDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDatabaseDataSet.Filme' table. You can move, or remove it, as needed.
            this.filmeTableAdapter.Fill(this.movieDatabaseDataSet.Filme);
            // TODO: This line of code loads data into the 'movieDatabaseDataSet.Filme' table. You can move, or remove it, as needed.
            this.filmeTableAdapter.Fill(this.movieDatabaseDataSet.Filme);

        }

        private void filmeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(utilizator);
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form2 = new Form4(utilizator);
            form2.Show(); 
            this.Hide();
        }

        private void filmeBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.filmeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.movieDatabaseDataSet);

        }
    }
}
