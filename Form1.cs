using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double firstnum;
        double secondnum;
        double answer;
        string operation;


        public Form1()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee_v2DataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.employee_v2DataSet.employee);

        }

        private void button23_Click(object sender, EventArgs e)
        {
            employeeBindingSource.AddNew();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            employeeBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            employeeBindingSource.MoveNext();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            employeeBindingSource.RemoveCurrent();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employee_v2DataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employee_v2DataSet);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Application.Exit()
        }

        private void button27_Click(object sender, EventArgs e)
        {
    

        }

        private void button_click(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            if (label1.Text == "0") ;
            label1.Text = num.Text;

            else
            label1.text label1.text + num.Text;
        }

        private void operations(object sender, EventArgs e)
        {
            Button ops = (Button)sender;
            firstnum = Double.Parse(label1.text);
            label1.text = "";
            operation = ops.Text;
            label2.text = System.Convert.ToString(firstnum) + " " + operation;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!label1.text.Contains("."))
                    label1.Text= label1.Text + num.Text;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length > 0)
                label1.Text = label1.Text.Remove(label1.Text.length - 1, 1);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label2.Text "";
            secondnum = Double.Parse(Label1.Text);
            switch(operation)
            {
                case "+":
                    answer = (firstnum + secondnum);
                    label1.text = System.Convert.Tostring(answer);
                    break;

                case "-":
                    answer = (firstnum - secondnum);
                    labell.Text = System.Convert.ToString(answer);
                    break;
                case "/":
                    answer = (firstnum / secondnum);
                    label1.Text = System.Convert.ToString(answer);
                    break;
                case "*":
                    answer = (firstnum * secondnum);
                    label1.Text = System.Convert.ToString(answer);
                    



                    break;
                default:
                        break;

            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            label1.text = "0";
            label2.text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
