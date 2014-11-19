using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPNCalculator
{
    public partial class frmRPNCalculator : Form
    {
        double dblFirstNum = 0;
        double dblSecondNum = 0;
        double dblAnswer = 0;
        string strFirstNum = "0";
        string strSecondNum = "0";
        string strAnswer = "0";
        string strTest = "0";
        double dblNumCheck = 0;
        public bool isNum;


        public frmRPNCalculator()
        {
            InitializeComponent();
        }

        private void txtFirstNum_Leave(object sender, EventArgs e)
        {
            strFirstNum = txtFirstNum.Text.ToString();
            strTest = strFirstNum;

            bool isNum = double.TryParse(strTest,System.Globalization.NumberStyles.Number,
                System.Globalization.CultureInfo.CurrentCulture.NumberFormat,out dblNumCheck);

            if (isNum)
            {
                dblFirstNum = double.Parse(strFirstNum);
            }
            else
            {
                txtFirstNum.Text = "";
                strFirstNum = "";
                txtFirstNum.Lines.Initialize();
                MessageBox.Show("That is not a number. PRESS CLEAR and try again");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstNum.Text = "0";
            txtSecondNum.Text = "0";
            txtAnswer.Text = "0";
        }

        private void txtSecondNum_Leave(object sender, EventArgs e)
        {
            strSecondNum = txtSecondNum.Text.ToString();
            strTest = strSecondNum;

            bool isNum = double.TryParse(strTest, System.Globalization.NumberStyles.Number,
                System.Globalization.CultureInfo.CurrentCulture.NumberFormat, out dblNumCheck);

            if (isNum)
            {
                dblSecondNum = double.Parse(strSecondNum);
            }
            else
            {
                txtSecondNum.Text = "";
                strSecondNum = "";
                txtSecondNum.Lines.Initialize();
                MessageBox.Show("That is not a number. PRESS CLEAR and try again");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dblAnswer = (dblFirstNum + dblSecondNum);
            strAnswer = dblAnswer.ToString();
            txtAnswer.Text = strAnswer;
        }

        private void btnSubt_Click(object sender, EventArgs e)
        {
            dblAnswer = (dblFirstNum - dblSecondNum);
            strAnswer = dblAnswer.ToString();
            txtAnswer.Text = strAnswer;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            dblAnswer = (dblFirstNum * dblSecondNum);
            strAnswer = dblAnswer.ToString();
            txtAnswer.Text = strAnswer;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            dblAnswer = (dblFirstNum / dblSecondNum);
            strAnswer = dblAnswer.ToString();
            txtAnswer.Text = strAnswer;
        }

        private void frmRPNCalculator_Load(object sender, EventArgs e)
        {
            txtFirstNum.Text = "First Number";
            txtSecondNum.Text = "Second Number";
        }

        private void txtFirstNum_MouseDown(object sender, MouseEventArgs e)
        {
            txtFirstNum.Text = "";
        }

        private void txtSecondNum_MouseDown(object sender, MouseEventArgs e)
        {
            txtSecondNum.Text = "";
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
