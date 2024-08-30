using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Scientific_Calculator
{
    public partial class Form1 : Form

    {
        double enterFirstValue, enterSecondValue;
        string op;
        public Form1()
        {
            InitializeComponent();
        }



        private void numberOperator(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            if (!string.IsNullOrEmpty(op))
            {
                MessageBox.Show("Please complete the current operation before entering a new operator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            enterFirstValue = Convert.ToDouble(txtResult.Text);
            op = num.Text;
            txtResult.Text = "";
            labelCurrentOperation.Text = enterFirstValue + " " + op;
        }

        private void buttonequalto_Click(object sender, EventArgs e)
        {
            try
            {
                enterSecondValue = Convert.ToDouble(txtResult.Text);

                switch (op)
                {
                    case "+":
                        txtResult.Text = (enterFirstValue + enterSecondValue).ToString();
                        break;

                    case "-":
                        txtResult.Text = (enterFirstValue - enterSecondValue).ToString();
                        break;

                    case "*":
                        txtResult.Text = (enterFirstValue * enterSecondValue).ToString();
                        break;
                    
                    case "/":
                        txtResult.Text = (enterFirstValue / enterSecondValue).ToString();
                        break;

                    case "Mod":
                        txtResult.Text = (enterFirstValue % enterSecondValue).ToString();
                        break;

                    case "Exp":
                        double i = Convert.ToDouble(txtResult.Text);
                        double j = enterSecondValue;
                        txtResult.Text = Math.Exp(i * Math.Log(j * 4)).ToString();
                        break;

                    default:
                        break;
                }

                labelCurrentOperation.Text = "";
                op = null;
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter numeric values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            op = null;
            labelCurrentOperation.Text = "";
        }

        private void buttoncleareverything_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            enterFirstValue = 0;
            enterSecondValue = 0;
            op = null;
            labelCurrentOperation.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(-1 * q);

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            }
            if (txtResult.Text == "")
            {
                txtResult.Text = "0";
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 250; //734,367
            txtResult.Width = 220; //328
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 250; //734,367
            txtResult.Width = 220; //328
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 490; //734,367
            txtResult.Width = 460; //328
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCal;

            exitCal = MessageBox.Show("Confirm if you want to exit", "Scientific Calculator",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitCal == DialogResult.Yes)
            {
                System.Windows.Forms. Application.Exit();
            }
        
        }

        private void buttonpi_Click(object sender, EventArgs e)
        {
            txtResult.Text = "3.141592653589976323";
        }

        private void buttonlog_Click(object sender, EventArgs e)
        {
            double logg = Convert.ToDouble(txtResult.Text);
            logg = Math.Log10(logg);
            txtResult.Text = Convert.ToString(logg);
        }

        private void buttonSquareRoot_Click(object sender, EventArgs e)
        {
            double sq = Convert.ToDouble(txtResult.Text);
            sq = Math.Sqrt(sq);
            txtResult.Text = Convert.ToString(sq);
        }

        private void buttonx2_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(x);
        }

        private void buttonx3_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(x);
        }

        private void buttonSinh_Click(object sender, EventArgs e)
        {
            double sh = Convert.ToDouble(txtResult.Text);
            sh = Math.Sinh(sh);
            txtResult.Text = Convert.ToString(sh);
        }

        private void buttonCosh_Click(object sender, EventArgs e)
        {
            double ch = Convert.ToDouble(txtResult.Text);
            ch = Math.Cosh(ch);
            txtResult.Text = Convert.ToString(ch);
        }

        private void buttonTanh_Click(object sender, EventArgs e)
        {
            double th = Convert.ToDouble(txtResult.Text);
            th = Math.Tanh(th);
            txtResult.Text = Convert.ToString(th);
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            double sin = Convert.ToDouble(txtResult.Text);
            sin = Math.Sin(sin);
            txtResult.Text = Convert.ToString(sin);
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            double cos = Convert.ToDouble(txtResult.Text);
            cos = Math.Cos(cos);
            txtResult.Text = Convert.ToString(cos);
        }

        private void buttonTan_Click(object sender, EventArgs e)
        {
            double tan = Convert.ToDouble(txtResult.Text);
            tan = Math.Tanh(tan);
            txtResult.Text = Convert.ToString(tan);
        }

        private void buttonDec_Click(object sender, EventArgs e)
        {
            double dec = Convert.ToDouble(txtResult.Text);  

            int i1 = Convert.ToInt32(dec);
            int i2 = (int)dec;

            txtResult.Text = Convert.ToString(i2);
        }

        private void buttonOneDividedByX_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtResult.Text) / Convert.ToDouble(100);
            txtResult.Text = Convert.ToString(a);
        }

        private void buttonlnx_Click(object sender, EventArgs e)
        {
            double lnx = Convert.ToDouble(txtResult.Text);
            lnx = Math.Log(lnx);
            txtResult.Text = Convert.ToString(lnx);
        }

        private void buttonPercenatge_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtResult.Text) / Convert.ToDouble(100);
            txtResult.Text = Convert.ToString(a);
        }

        private void buttonBin_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 2);
        }

        private void buttonHex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 16);
        }

        private void buttonOct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 8);
        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            if (txtResult.Text == "0")
                txtResult.Text = "";
            {
                if (num.Text == ".")
                {
                    if (!txtResult.Text.Contains("."))

                        txtResult.Text = txtResult.Text + num.Text;
                }
                else
                {
                    txtResult.Text = txtResult.Text + num.Text;
                }

            }
        }
    }
    }




            
               
        
