namespace GUI
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
            this.textInput = new System.Windows.Forms.TextBox();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.buttDescompunere = new System.Windows.Forms.Button();
            this.buttonDespre = new System.Windows.Forms.Button();
            this.buttonIesire = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(169, 119);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(117, 22);
            this.textInput.TabIndex = 0;
            // 
            // textOutput
            // 
            this.textOutput.Location = new System.Drawing.Point(365, 116);
            this.textOutput.Name = "textOutput";
            this.textOutput.Size = new System.Drawing.Size(253, 22);
            this.textOutput.TabIndex = 1;
            // 
            // buttDescompunere
            // 
            this.buttDescompunere.Location = new System.Drawing.Point(272, 198);
            this.buttDescompunere.Name = "buttDescompunere";
            this.buttDescompunere.Size = new System.Drawing.Size(128, 34);
            this.buttDescompunere.TabIndex = 2;
            this.buttDescompunere.Text = "Descompunere";
            this.buttDescompunere.UseVisualStyleBackColor = true;
            this.buttDescompunere.Click += new System.EventHandler(this.buttDescompunere_Click);
            // 
            // buttonDespre
            // 
            this.buttonDespre.Location = new System.Drawing.Point(184, 313);
            this.buttonDespre.Name = "buttonDespre";
            this.buttonDespre.Size = new System.Drawing.Size(117, 34);
            this.buttonDespre.TabIndex = 3;
            this.buttonDespre.Text = "Despre";
            this.buttonDespre.UseVisualStyleBackColor = true;
            this.buttonDespre.Click += new System.EventHandler(this.buttonDespre_Click);
            // 
            // buttonIesire
            // 
            this.buttonIesire.Location = new System.Drawing.Point(442, 313);
            this.buttonIesire.Name = "buttonIesire";
            this.buttonIesire.Size = new System.Drawing.Size(128, 34);
            this.buttonIesire.TabIndex = 4;
            this.buttonIesire.Text = "Iesire";
            this.buttonIesire.UseVisualStyleBackColor = true;
            this.buttonIesire.Click += new System.EventHandler(this.buttonIesire_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonIesire);
            this.Controls.Add(this.buttonDespre);
            this.Controls.Add(this.buttDescompunere);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.textInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.TextBox textOutput;
        private System.Windows.Forms.Button buttDescompunere;
        private System.Windows.Forms.Button buttonDespre;
        private System.Windows.Forms.Button buttonIesire;
        private System.Windows.Forms.Label label1;
    }
}

