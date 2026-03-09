namespace MagicSquare
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonChm = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pictureBoxSquare = new System.Windows.Forms.PictureBox();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSquare)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dimensiunea:";
            // 
            // textBoxSize
            // 
            this.helpProvider.SetHelpKeyword(this.textBoxSize, "web\\pag2.htm");
            this.helpProvider.SetHelpNavigator(this.textBoxSize, System.Windows.Forms.HelpNavigator.Topic);
            this.textBoxSize.Location = new System.Drawing.Point(135, 25);
            this.textBoxSize.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSize.Name = "textBoxSize";
            this.helpProvider.SetShowHelp(this.textBoxSize, true);
            this.textBoxSize.Size = new System.Drawing.Size(89, 22);
            this.textBoxSize.TabIndex = 1;
            this.textBoxSize.Text = "3";
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(24, 23);
            this.buttonDraw.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(100, 28);
            this.buttonDraw.TabIndex = 2;
            this.buttonDraw.Text = "Deseneaza";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(148, 23);
            this.buttonAbout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(100, 28);
            this.buttonAbout.TabIndex = 3;
            this.buttonAbout.Text = "Despre";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(24, 59);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 28);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Salveaza";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(148, 59);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 28);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Iesire";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Suma:";
            // 
            // textBoxSum
            // 
            this.helpProvider.SetHelpKeyword(this.textBoxSum, "web\\pag3.htm");
            this.helpProvider.SetHelpNavigator(this.textBoxSum, System.Windows.Forms.HelpNavigator.Topic);
            this.textBoxSum.Location = new System.Drawing.Point(135, 60);
            this.textBoxSum.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.ReadOnly = true;
            this.helpProvider.SetShowHelp(this.textBoxSum, true);
            this.textBoxSum.Size = new System.Drawing.Size(89, 22);
            this.textBoxSum.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonChm);
            this.groupBox1.Location = new System.Drawing.Point(576, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(145, 106);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Help";
            // 
            // buttonChm
            // 
            this.buttonChm.Location = new System.Drawing.Point(26, 25);
            this.buttonChm.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChm.Name = "buttonChm";
            this.buttonChm.Size = new System.Drawing.Size(100, 28);
            this.buttonChm.TabIndex = 9;
            this.buttonChm.Text = "Ajutor";
            this.buttonChm.UseVisualStyleBackColor = true;
            this.buttonChm.Click += new System.EventHandler(this.buttonChm_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSum);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxSize);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(16, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(247, 106);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setari";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonClose);
            this.groupBox3.Controls.Add(this.buttonDraw);
            this.groupBox3.Controls.Add(this.buttonAbout);
            this.groupBox3.Controls.Add(this.buttonSave);
            this.groupBox3.Location = new System.Drawing.Point(283, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(272, 106);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Patrat";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Images (*.png)|*.png";
            this.saveFileDialog.InitialDirectory = ".";
            // 
            // pictureBoxSquare
            // 
            this.pictureBoxSquare.Location = new System.Drawing.Point(16, 138);
            this.pictureBoxSquare.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxSquare.Name = "pictureBoxSquare";
            this.pictureBoxSquare.Size = new System.Drawing.Size(705, 460);
            this.pictureBoxSquare.TabIndex = 12;
            this.pictureBoxSquare.TabStop = false;
            this.pictureBoxSquare.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxSquare_Paint);
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "MagicHelp.chm";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(735, 611);
            this.Controls.Add(this.pictureBoxSquare);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.helpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.helpProvider.SetShowHelp(this, true);
            this.Text = "Patratul magic";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSquare)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonChm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.PictureBox pictureBoxSquare;
        private System.Windows.Forms.HelpProvider helpProvider;
    }
}

