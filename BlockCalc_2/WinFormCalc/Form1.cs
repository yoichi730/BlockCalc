using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlockCalc_2;

namespace WinFormCalc
{
    public partial class FormCalc : Form
    {

      public FormCalc()
        {
            InitializeComponent();

            #region Загрузка операций

            My_Expression expr = new My_Expression();

            //получаем список операторов и загружаем его в cbOperators
                        
            cbOperators.Items.AddRange(expr.getOperations());

            #endregion

            
            
        }

        

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (mtbArguments.Text == "" || cbOperators.Text == "")
                ButtonBox.Enabled = false;
            else
            {
                mtbArguments.Clear();
                tbResult.Clear();
            }
            
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (mtbArguments.Text == "" || cbOperators.Text == "")
                ButtonBox.Enabled = false;
            else
            {
                var args = mtbArguments.Text.Trim(' ').Split(' ')
                    .Select(str => Convert.ToDouble(str)).ToArray();

                My_Expression expr = new My_Expression();

                string[] operations = expr.getOperations();

                if (cbOperators.Text == "SUM") tbResult.Text = $"{expr.SUM(args.Length, args)}";
                if (cbOperators.Text == "SUB") tbResult.Text = $"{expr.SUB(args.Length, args)}";
                if (cbOperators.Text == "DIV") tbResult.Text = $"{expr.DIV(args.Length, args)}";
                if (cbOperators.Text == "MUL") tbResult.Text = $"{expr.MUL(args.Length, args)}";

            }
        }

        private void btnMyLucky_Click(object sender, EventArgs e)
        {
            if (mtbArguments.Text == "" || cbOperators.Text == "")
                ButtonBox.Enabled = false;
            else
            {
                Random rndOper = new Random();
                Random[] rndArg = new Random[100];
                tbResult.Text = "Это - успех!!";
            }
        }

        private void cbOperators_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        private void cbOperators_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbOperators.Text != "") mtbArguments.ReadOnly = false;
            mtbArguments.Text = "";
            
        }

        

        private void mtbArguments_TextChanged(object sender, EventArgs e)
        {
            ButtonBox.Enabled = true;
        }
    }
}
