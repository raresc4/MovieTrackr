﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDatabaseDataSet.Filme' table. You can move, or remove it, as needed.
            this.filmeTableAdapter.Fill(this.movieDatabaseDataSet.Filme);
            // TODO: This line of code loads data into the 'mainDataSet.Utlizatori' table. You can move, or remove it, as needed.
            this.utlizatoriTableAdapter.Fill(this.mainDataSet.Utlizatori);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void utlizatoriBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utlizatoriBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mainDataSet);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            var result = this.filmeTableAdapter.GetDataBy(textBox1.Text);
            if(result.Rows.Count != 0)
            {
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                textBox4.Text = string.Empty;
                MessageBox.Show("Movie already exists");
                return;
            }
            this.filmeTableAdapter.InsertFilm(textBox1.Text,Convert.ToInt32(textBox2.Text),textBox3.Text,textBox4.Text);
            this.tableAdapterManager1.UpdateAll(this.movieDatabaseDataSet);
            this.filmeTableAdapter.Fill(this.movieDatabaseDataSet.Filme);
            MessageBox.Show(textBox1.Text + " was succesfully added");
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }

        private void filmeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }
    }
}
