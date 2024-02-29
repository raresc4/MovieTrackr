using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MovieDatabase
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void utlizatoriBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utlizatoriBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mainDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDataSet.Utlizatori' table. You can move, or remove it, as needed.
            this.utlizatoriTableAdapter.Fill(this.mainDataSet.Utlizatori);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = this.utlizatoriTableAdapter.GetUtilizator(textBox1.Text, textBox2.Text);
            if(result.Rows.Count != 0)
            {
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                MessageBox.Show("User already in use");
                return;
            }
            if(textBox1.Text.Length == 0 ||  textBox2.Text.Length == 0) {
                textBox1.Text = string.Empty ;
                textBox2.Text = string.Empty ;
                MessageBox.Show("Please enter username or password!");
                return; 
            }
            this.utlizatoriTableAdapter.InsertUtilizator(textBox1.Text, textBox2.Text);
            this.tableAdapterManager.UpdateAll(this.mainDataSet);
            this.utlizatoriTableAdapter.Fill(this.mainDataSet.Utlizatori);
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
