namespace L2
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.textX0 = new System.Windows.Forms.TextBox();
            this.textX1 = new System.Windows.Forms.TextBox();
            this.textX2 = new System.Windows.Forms.TextBox();
            this.EcPolinomialaSelect = new System.Windows.Forms.RadioButton();
            this.CalculeazaButton = new System.Windows.Forms.Button();
            this.DespreButton = new System.Windows.Forms.Button();
            this.IesireButton = new System.Windows.Forms.Button();
            this.comboBoxTrig = new System.Windows.Forms.ComboBox();
            this.EcTrigonometricaSelect = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textArg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSolutie = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.textX0);
            this.groupBox1.Controls.Add(this.textX1);
            this.groupBox1.Controls.Add(this.textX2);
            this.groupBox1.Controls.Add(this.EcPolinomialaSelect);
            this.groupBox1.Location = new System.Drawing.Point(57, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "= 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "x";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(122, 61);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(22, 16);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "X2";
            this.labelX2.Click += new System.EventHandler(this.labelX2_Click);
            // 
            // textX0
            // 
            this.textX0.Location = new System.Drawing.Point(275, 58);
            this.textX0.Name = "textX0";
            this.textX0.Size = new System.Drawing.Size(65, 22);
            this.textX0.TabIndex = 2;
            this.textX0.TextChanged += new System.EventHandler(this.textX0_TextChanged);
            // 
            // textX1
            // 
            this.textX1.Location = new System.Drawing.Point(167, 58);
            this.textX1.Name = "textX1";
            this.textX1.Size = new System.Drawing.Size(58, 22);
            this.textX1.TabIndex = 2;
            this.textX1.TextChanged += new System.EventHandler(this.textX1_TextChanged);
            // 
            // textX2
            // 
            this.textX2.Location = new System.Drawing.Point(51, 58);
            this.textX2.Name = "textX2";
            this.textX2.Size = new System.Drawing.Size(65, 22);
            this.textX2.TabIndex = 1;
            this.textX2.TextChanged += new System.EventHandler(this.textX2_TextChanged);
            // 
            // EcPolinomialaSelect
            // 
            this.EcPolinomialaSelect.AutoSize = true;
            this.EcPolinomialaSelect.Location = new System.Drawing.Point(51, 21);
            this.EcPolinomialaSelect.Name = "EcPolinomialaSelect";
            this.EcPolinomialaSelect.Size = new System.Drawing.Size(146, 20);
            this.EcPolinomialaSelect.TabIndex = 0;
            this.EcPolinomialaSelect.TabStop = true;
            this.EcPolinomialaSelect.Text = "Ecuatie polinomiala";
            this.EcPolinomialaSelect.UseVisualStyleBackColor = true;
            this.EcPolinomialaSelect.CheckedChanged += new System.EventHandler(this.EcPolinomialaSelect_CheckedChanged);
            // 
            // CalculeazaButton
            // 
            this.CalculeazaButton.Location = new System.Drawing.Point(549, 119);
            this.CalculeazaButton.Name = "CalculeazaButton";
            this.CalculeazaButton.Size = new System.Drawing.Size(111, 31);
            this.CalculeazaButton.TabIndex = 1;
            this.CalculeazaButton.Text = "Calculeaza";
            this.CalculeazaButton.UseVisualStyleBackColor = true;
            this.CalculeazaButton.Click += new System.EventHandler(this.CalculeazaButton_Click);
            // 
            // DespreButton
            // 
            this.DespreButton.Location = new System.Drawing.Point(549, 174);
            this.DespreButton.Name = "DespreButton";
            this.DespreButton.Size = new System.Drawing.Size(111, 23);
            this.DespreButton.TabIndex = 2;
            this.DespreButton.Text = "Despre";
            this.DespreButton.UseVisualStyleBackColor = true;
            this.DespreButton.Click += new System.EventHandler(this.DespreButton_Click);
            // 
            // IesireButton
            // 
            this.IesireButton.Location = new System.Drawing.Point(549, 216);
            this.IesireButton.Name = "IesireButton";
            this.IesireButton.Size = new System.Drawing.Size(111, 23);
            this.IesireButton.TabIndex = 3;
            this.IesireButton.Text = "Iesire";
            this.IesireButton.UseVisualStyleBackColor = true;
            this.IesireButton.Click += new System.EventHandler(this.IesireButton_Click);
            // 
            // comboBoxTrig
            // 
            this.comboBoxTrig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTrig.FormattingEnabled = true;
            this.comboBoxTrig.Items.AddRange(new object[] {
            "Sin",
            "Cos",
            "Tan"});
            this.comboBoxTrig.Location = new System.Drawing.Point(51, 59);
            this.comboBoxTrig.Name = "comboBoxTrig";
            this.comboBoxTrig.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTrig.TabIndex = 4;
            this.comboBoxTrig.SelectedIndexChanged += new System.EventHandler(this.comboBoxTrig_SelectedIndexChanged);
            // 
            // EcTrigonometricaSelect
            // 
            this.EcTrigonometricaSelect.AutoSize = true;
            this.EcTrigonometricaSelect.Location = new System.Drawing.Point(51, 21);
            this.EcTrigonometricaSelect.Name = "EcTrigonometricaSelect";
            this.EcTrigonometricaSelect.Size = new System.Drawing.Size(161, 20);
            this.EcTrigonometricaSelect.TabIndex = 5;
            this.EcTrigonometricaSelect.TabStop = true;
            this.EcTrigonometricaSelect.Text = "Ecuatie trigonometrica";
            this.EcTrigonometricaSelect.UseVisualStyleBackColor = true;
            this.EcTrigonometricaSelect.CheckedChanged += new System.EventHandler(this.EcTrigonometricaSelect_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "=";
            // 
            // textArg
            // 
            this.textArg.Location = new System.Drawing.Point(270, 59);
            this.textArg.Name = "textArg";
            this.textArg.Size = new System.Drawing.Size(58, 22);
            this.textArg.TabIndex = 7;
            this.textArg.TextChanged += new System.EventHandler(this.textArg_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Solutie";
            // 
            // textBoxSolutie
            // 
            this.textBoxSolutie.Location = new System.Drawing.Point(51, 68);
            this.textBoxSolutie.Name = "textBoxSolutie";
            this.textBoxSolutie.Size = new System.Drawing.Size(330, 22);
            this.textBoxSolutie.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EcTrigonometricaSelect);
            this.groupBox2.Controls.Add(this.comboBoxTrig);
            this.groupBox2.Controls.Add(this.textArg);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(57, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 126);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxSolutie);
            this.groupBox3.Location = new System.Drawing.Point(57, 309);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(407, 109);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.IesireButton);
            this.Controls.Add(this.DespreButton);
            this.Controls.Add(this.CalculeazaButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton EcPolinomialaSelect;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.TextBox textX0;
        private System.Windows.Forms.TextBox textX1;
        private System.Windows.Forms.TextBox textX2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CalculeazaButton;
        private System.Windows.Forms.Button DespreButton;
        private System.Windows.Forms.Button IesireButton;
        private System.Windows.Forms.ComboBox comboBoxTrig;
        private System.Windows.Forms.RadioButton EcTrigonometricaSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textArg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSolutie;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

