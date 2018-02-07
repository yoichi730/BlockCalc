namespace WinFormCalc
{
    partial class FormCalc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalc));
            this.gbOperator = new System.Windows.Forms.GroupBox();
            this.cbOperators = new System.Windows.Forms.ComboBox();
            this.ButtonBox = new System.Windows.Forms.GroupBox();
            this.btnMyLucky = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtbArguments = new System.Windows.Forms.MaskedTextBox();
            this.gbOperator.SuspendLayout();
            this.ButtonBox.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOperator
            // 
            this.gbOperator.Controls.Add(this.cbOperators);
            resources.ApplyResources(this.gbOperator, "gbOperator");
            this.gbOperator.Name = "gbOperator";
            this.gbOperator.TabStop = false;
            // 
            // cbOperators
            // 
            resources.ApplyResources(this.cbOperators, "cbOperators");
            this.cbOperators.FormattingEnabled = true;
            this.cbOperators.Name = "cbOperators";
            this.cbOperators.SelectedValueChanged += new System.EventHandler(this.cbOperators_SelectedValueChanged);
            this.cbOperators.EnabledChanged += new System.EventHandler(this.cbOperators_EnabledChanged);
            // 
            // ButtonBox
            // 
            this.ButtonBox.Controls.Add(this.btnMyLucky);
            this.ButtonBox.Controls.Add(this.btnClear);
            this.ButtonBox.Controls.Add(this.btnResult);
            resources.ApplyResources(this.ButtonBox, "ButtonBox");
            this.ButtonBox.Name = "ButtonBox";
            this.ButtonBox.TabStop = false;
            // 
            // btnMyLucky
            // 
            resources.ApplyResources(this.btnMyLucky, "btnMyLucky");
            this.btnMyLucky.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyLucky.Name = "btnMyLucky";
            this.btnMyLucky.UseVisualStyleBackColor = true;
            this.btnMyLucky.Click += new System.EventHandler(this.btnMyLucky_Click);
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnResult
            // 
            resources.ApplyResources(this.btnResult, "btnResult");
            this.btnResult.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResult.Name = "btnResult";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.tbResult);
            resources.ApplyResources(this.gbResult, "gbResult");
            this.gbResult.Name = "gbResult";
            this.gbResult.TabStop = false;
            // 
            // tbResult
            // 
            resources.ApplyResources(this.tbResult, "tbResult");
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtbArguments);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // mtbArguments
            // 
            resources.ApplyResources(this.mtbArguments, "mtbArguments");
            this.mtbArguments.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.mtbArguments.Name = "mtbArguments";
            this.mtbArguments.ReadOnly = true;
            this.mtbArguments.Tag = "";
            this.mtbArguments.TextChanged += new System.EventHandler(this.mtbArguments_TextChanged);
            // 
            // FormCalc
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonBox);
            this.Controls.Add(this.gbOperator);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalc";
            this.ShowIcon = false;
            this.gbOperator.ResumeLayout(false);
            this.ButtonBox.ResumeLayout(false);
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOperator;
        private System.Windows.Forms.GroupBox ButtonBox;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.ComboBox cbOperators;
        private System.Windows.Forms.Button btnMyLucky;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtbArguments;
    }
}

