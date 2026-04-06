namespace PrinterSimulator
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.textDocument = new System.Windows.Forms.TextBox();
            this.textDimensiune = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.despreButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timerTick = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textDocument
            // 
            this.textDocument.Location = new System.Drawing.Point(145, 25);
            this.textDocument.Name = "textDocument";
            this.textDocument.Size = new System.Drawing.Size(115, 22);
            this.textDocument.TabIndex = 0;
            // 
            // textDimensiune
            // 
            this.textDimensiune.Location = new System.Drawing.Point(487, 25);
            this.textDimensiune.Name = "textDimensiune";
            this.textDimensiune.Size = new System.Drawing.Size(100, 22);
            this.textDimensiune.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Document";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dimensiune";
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(681, 23);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(107, 33);
            this.printButton.TabIndex = 4;
            this.printButton.Text = "Tipărește";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // despreButton
            // 
            this.despreButton.Location = new System.Drawing.Point(702, 324);
            this.despreButton.Name = "despreButton";
            this.despreButton.Size = new System.Drawing.Size(86, 30);
            this.despreButton.TabIndex = 5;
            this.despreButton.Text = "Despre";
            this.despreButton.UseVisualStyleBackColor = true;
            this.despreButton.Click += new System.EventHandler(this.despreButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(702, 384);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(86, 28);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Ieșire";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Imprimantă";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(36, 126);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(577, 286);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // timerTick
            // 
            this.timerTick.Enabled = true;
            this.timerTick.Interval = 500;
            this.timerTick.Tick += new System.EventHandler(this.timerTick_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.despreButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDimensiune);
            this.Controls.Add(this.textDocument);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDocument;
        private System.Windows.Forms.TextBox textDimensiune;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button despreButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timerTick;
    }
}

