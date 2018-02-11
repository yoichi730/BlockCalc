using System;
using System.Data;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using BlockCalc_2;
using System.Collections.Generic;
using System.Collections;

namespace WinFormCalc
{
    public partial class FormCalc : Form
    {
        
        private BlockCalc_2.My_Expression expr { get; set; }

        public FormCalc()
        {
            InitializeComponent();

            #region Загрузка операций

            expr = new BlockCalc_2.My_Expression();

            var operations = expr.GetOperNames();

            cbOperators.Items.Clear();
            cbOperators.Items.AddRange(operations);

            #endregion

        }
        
        private void btnResult_Click(object sender, EventArgs e)
        {
            if (tbArguments.Text != "" && cbOperators.Text != "")
            {
                // получить операцию
                var oper = $"{cbOperators.SelectedItem}";

                // получить данные
                var args = tbArguments.Text
                    .Trim()
                    .Split(' ')
                    .Select(str => Convert.ToDouble(str))
                    .ToArray();

                // вычислить результат
                var result = expr.Exec(oper, args);

                // показать результат
                tbResult.Text = $"{result}";

                lbHistory.Items.Add(expr.print(oper, args));

                tbArguments.Focus();
                tbArguments.SelectAll();
            }
            
        }

        
        private void btnMyLucky_Click(object sender, EventArgs e)
        {
            if (tbArguments.Text == "" || cbOperators.Text == "")
                ButtonBox.Enabled = false;
            else
            {
                tbResult.Text = "Это - успех!!";
            }
        }

        private void tbArguments_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbArguments.Text == "") tbArguments.Text = "0";

                btnResult_Click(sender, e);
            }
        }

        private void cbOperators_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbArguments.Focus();
            tbArguments.Clear();
            tbResult.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tbArguments.Text != "" && cbOperators.Text != "")
            {
                // получить операцию
                var oper = $"{cbOperators.SelectedItem}";

                // получить данные
                var args = tbArguments.Text
                    .Trim()
                    .Split(' ')
                    .Select(str => Convert.ToDouble(str))
                    .ToArray();

                // вычислить результат
                var result = expr.Exec(oper, args);

                // показать результат
                tbResult.Text = $"{result}";

            }   
       }

        private void tbArguments_TextChanged(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
