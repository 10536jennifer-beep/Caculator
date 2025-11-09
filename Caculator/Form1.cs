using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float firstNumber, secondNumber;
        int operators = -1;
        private void btnOne_Click(object sender, EventArgs e) //輸入數字1
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }
            txtNumber.Text = txtNumber.Text + "1";
        }

        private void btnTwo_Click(object sender, EventArgs e) //輸入數字2
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }
            txtNumber.Text = txtNumber.Text + "2";
        }

        private void btnThree_Click(object sender, EventArgs e) //輸入數字3
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }
            txtNumber.Text = txtNumber.Text + "3";
        }

        private void btnFour_Click(object sender, EventArgs e) //輸入數字4
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }
            txtNumber.Text = txtNumber.Text + "4";
        }

        private void btnFive_Click(object sender, EventArgs e)//輸入數字5
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }
            txtNumber.Text = txtNumber.Text + "5";
        }

        private void btnSix_Click(object sender, EventArgs e) //輸入數字6
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }
            txtNumber.Text = txtNumber.Text + "6";
        }

        private void btnSeven_Click(object sender, EventArgs e) //輸入數字7
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }
            txtNumber.Text = txtNumber.Text + "7";
        }

        private void btnEight_Click(object sender, EventArgs e) //輸入數字8
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }
            txtNumber.Text = txtNumber.Text + "8";
        }

        private void btnNine_Click(object sender, EventArgs e) //輸入數字9
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }
            txtNumber.Text = txtNumber.Text + "9";
        }

        private void btnZero_Click(object sender, EventArgs e) //輸入數字0
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }
            txtNumber.Text = txtNumber.Text + "0";
        }

        private void btnAdd_Click(object sender, EventArgs e) //加工能
        {
            firstNumber = Convert.ToSingle(txtNumber.Text);
            txtNumber.Text = "0";
            operators = 0;
        }

        private void btnMinus_Click(object sender, EventArgs e) //減功能
        {
            firstNumber = Convert.ToSingle(txtNumber.Text);
            txtNumber.Text = "0";
            operators = 1;
        }

        private void btnPlus_Click(object sender, EventArgs e) //乘功能
        {
            firstNumber = Convert.ToSingle(txtNumber.Text);
            txtNumber.Text = "0";
            operators = 2;
        }

        private void btnDivide_Click(object sender, EventArgs e) //除功能
        {
            firstNumber = Convert.ToSingle(txtNumber.Text);
            txtNumber.Text = "0";
            operators = 3;
        }
        private void btnDot_Click(object sender, EventArgs e) //小數點功能
        {
            if (txtNumber.Text.IndexOf(".") == -1)
            {
                txtNumber.Text = txtNumber.Text + ".";
            }
        }

        private void btnEqual_Click(object sender, EventArgs e) //等於功能
        {
            float finalResults = 0f;
            secondNumber = Convert.ToSingle(txtNumber.Text);

            switch (operators)
            {
                case 0:
                    finalResults = firstNumber + secondNumber;
                    break;
                case 1:
                    finalResults = firstNumber - secondNumber;
                    break;
                case 2:
                    finalResults = firstNumber * secondNumber;
                    break;
                case 3:
                    finalResults = firstNumber / secondNumber;
                    break;
            }
            txtNumber.Text = Convert.ToString(finalResults);
        }

        private void btnClear_Click(object sender, EventArgs e) //AC功能
        {
            txtNumber.Text = "0";
            firstNumber = 0f;
            secondNumber = 0f;
            operators = -1;
        }

        
    }
}
