namespace Speed
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSeed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLungime = new System.Windows.Forms.TextBox();
            this.buttonGenRandom = new System.Windows.Forms.Button();
            this.buttonGenCresc = new System.Windows.Forms.Button();
            this.buttonGenDesc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonButtonStopwatch = new System.Windows.Forms.RadioButton();
            this.radioButtonPerformance = new System.Windows.Forms.RadioButton();
            this.radioButtonDateTime = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonQuickSort = new System.Windows.Forms.Button();
            this.buttonShellSort = new System.Windows.Forms.Button();
            this.buttonBubbleSort = new System.Windows.Forms.Button();
            this.textBoxRezultat = new System.Windows.Forms.TextBox();
            this.buttonSterge = new System.Windows.Forms.Button();
            this.buttonDespre = new System.Windows.Forms.Button();
            this.buttonInchide = new System.Windows.Forms.Button();
            this.progressBarQuick = new System.Windows.Forms.ProgressBar();
            this.progressBarShell = new System.Windows.Forms.ProgressBar();
            this.progressBarBubble = new System.Windows.Forms.ProgressBar();
            this.progressBarSelection = new System.Windows.Forms.ProgressBar();
            this.buttonSelectionSort = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "RandomSeed";
            // 
            // textBoxSeed
            // 
            this.textBoxSeed.Location = new System.Drawing.Point(169, 22);
            this.textBoxSeed.Name = "textBoxSeed";
            this.textBoxSeed.Size = new System.Drawing.Size(100, 22);
            this.textBoxSeed.TabIndex = 1;
            this.textBoxSeed.Text = "1234";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lungimea vectorului";
            // 
            // textBoxLungime
            // 
            this.textBoxLungime.Location = new System.Drawing.Point(654, 25);
            this.textBoxLungime.Name = "textBoxLungime";
            this.textBoxLungime.Size = new System.Drawing.Size(100, 22);
            this.textBoxLungime.TabIndex = 3;
            this.textBoxLungime.Text = "10000";
            // 
            // buttonGenRandom
            // 
            this.buttonGenRandom.Location = new System.Drawing.Point(50, 112);
            this.buttonGenRandom.Name = "buttonGenRandom";
            this.buttonGenRandom.Size = new System.Drawing.Size(136, 55);
            this.buttonGenRandom.TabIndex = 4;
            this.buttonGenRandom.Text = "Genereaza vector aleatoriu";
            this.buttonGenRandom.UseVisualStyleBackColor = true;
            this.buttonGenRandom.Click += new System.EventHandler(this.buttonGenRandom_Click);
            // 
            // buttonGenCresc
            // 
            this.buttonGenCresc.Location = new System.Drawing.Point(309, 112);
            this.buttonGenCresc.Name = "buttonGenCresc";
            this.buttonGenCresc.Size = new System.Drawing.Size(136, 55);
            this.buttonGenCresc.TabIndex = 5;
            this.buttonGenCresc.Text = "Genereaza vector sortat crescator";
            this.buttonGenCresc.UseVisualStyleBackColor = true;
            this.buttonGenCresc.Click += new System.EventHandler(this.buttonGenCresc_Click);
            // 
            // buttonGenDesc
            // 
            this.buttonGenDesc.Location = new System.Drawing.Point(580, 112);
            this.buttonGenDesc.Name = "buttonGenDesc";
            this.buttonGenDesc.Size = new System.Drawing.Size(136, 55);
            this.buttonGenDesc.TabIndex = 6;
            this.buttonGenDesc.Text = "Genereaza vector sortat descrescator";
            this.buttonGenDesc.UseVisualStyleBackColor = true;
            this.buttonGenDesc.Click += new System.EventHandler(this.buttonGenDesc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonButtonStopwatch);
            this.groupBox1.Controls.Add(this.radioButtonPerformance);
            this.groupBox1.Controls.Add(this.radioButtonDateTime);
            this.groupBox1.Location = new System.Drawing.Point(56, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 91);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metoda de masurare";
            // 
            // radioButtonButtonStopwatch
            // 
            this.radioButtonButtonStopwatch.AutoSize = true;
            this.radioButtonButtonStopwatch.Location = new System.Drawing.Point(547, 41);
            this.radioButtonButtonStopwatch.Name = "radioButtonButtonStopwatch";
            this.radioButtonButtonStopwatch.Size = new System.Drawing.Size(90, 20);
            this.radioButtonButtonStopwatch.TabIndex = 9;
            this.radioButtonButtonStopwatch.TabStop = true;
            this.radioButtonButtonStopwatch.Text = "Stopwatch";
            this.radioButtonButtonStopwatch.UseVisualStyleBackColor = true;
            this.radioButtonButtonStopwatch.CheckedChanged += new System.EventHandler(this.radioButtonButtonStopwatch_CheckedChanged);
            // 
            // radioButtonPerformance
            // 
            this.radioButtonPerformance.AutoSize = true;
            this.radioButtonPerformance.Location = new System.Drawing.Point(253, 39);
            this.radioButtonPerformance.Name = "radioButtonPerformance";
            this.radioButtonPerformance.Size = new System.Drawing.Size(154, 20);
            this.radioButtonPerformance.TabIndex = 9;
            this.radioButtonPerformance.TabStop = true;
            this.radioButtonPerformance.Text = "Performance Counter";
            this.radioButtonPerformance.UseVisualStyleBackColor = true;
            this.radioButtonPerformance.CheckedChanged += new System.EventHandler(this.radioButtonPerformance_CheckedChanged);
            // 
            // radioButtonDateTime
            // 
            this.radioButtonDateTime.AutoSize = true;
            this.radioButtonDateTime.Location = new System.Drawing.Point(20, 39);
            this.radioButtonDateTime.Name = "radioButtonDateTime";
            this.radioButtonDateTime.Size = new System.Drawing.Size(88, 20);
            this.radioButtonDateTime.TabIndex = 8;
            this.radioButtonDateTime.TabStop = true;
            this.radioButtonDateTime.Text = "DateTime";
            this.radioButtonDateTime.UseVisualStyleBackColor = true;
            this.radioButtonDateTime.CheckedChanged += new System.EventHandler(this.radioButtonDateTime_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Timp de executie";
            // 
            // buttonQuickSort
            // 
            this.buttonQuickSort.Location = new System.Drawing.Point(50, 360);
            this.buttonQuickSort.Name = "buttonQuickSort";
            this.buttonQuickSort.Size = new System.Drawing.Size(136, 34);
            this.buttonQuickSort.TabIndex = 9;
            this.buttonQuickSort.Text = "Quick Sort";
            this.buttonQuickSort.UseVisualStyleBackColor = true;
            this.buttonQuickSort.Click += new System.EventHandler(this.buttonQuickSort_Click);
            // 
            // buttonShellSort
            // 
            this.buttonShellSort.Location = new System.Drawing.Point(50, 414);
            this.buttonShellSort.Name = "buttonShellSort";
            this.buttonShellSort.Size = new System.Drawing.Size(136, 34);
            this.buttonShellSort.TabIndex = 10;
            this.buttonShellSort.Text = "Shell Sort";
            this.buttonShellSort.UseVisualStyleBackColor = true;
            this.buttonShellSort.Click += new System.EventHandler(this.buttonShellSort_Click);
            // 
            // buttonBubbleSort
            // 
            this.buttonBubbleSort.Location = new System.Drawing.Point(50, 465);
            this.buttonBubbleSort.Name = "buttonBubbleSort";
            this.buttonBubbleSort.Size = new System.Drawing.Size(136, 34);
            this.buttonBubbleSort.TabIndex = 11;
            this.buttonBubbleSort.Text = "Bubble Sort";
            this.buttonBubbleSort.UseVisualStyleBackColor = true;
            this.buttonBubbleSort.Click += new System.EventHandler(this.buttonBubbleSort_Click);
            // 
            // textBoxRezultat
            // 
            this.textBoxRezultat.Location = new System.Drawing.Point(50, 575);
            this.textBoxRezultat.Multiline = true;
            this.textBoxRezultat.Name = "textBoxRezultat";
            this.textBoxRezultat.Size = new System.Drawing.Size(704, 214);
            this.textBoxRezultat.TabIndex = 15;
            // 
            // buttonSterge
            // 
            this.buttonSterge.Location = new System.Drawing.Point(133, 795);
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.Size = new System.Drawing.Size(136, 34);
            this.buttonSterge.TabIndex = 16;
            this.buttonSterge.Text = "Sterge";
            this.buttonSterge.UseVisualStyleBackColor = true;
            this.buttonSterge.Click += new System.EventHandler(this.buttonSterge_Click);
            // 
            // buttonDespre
            // 
            this.buttonDespre.Location = new System.Drawing.Point(341, 795);
            this.buttonDespre.Name = "buttonDespre";
            this.buttonDespre.Size = new System.Drawing.Size(136, 34);
            this.buttonDespre.TabIndex = 17;
            this.buttonDespre.Text = "Despre";
            this.buttonDespre.UseVisualStyleBackColor = true;
            this.buttonDespre.Click += new System.EventHandler(this.buttonDespre_Click);
            // 
            // buttonInchide
            // 
            this.buttonInchide.Location = new System.Drawing.Point(557, 795);
            this.buttonInchide.Name = "buttonInchide";
            this.buttonInchide.Size = new System.Drawing.Size(136, 34);
            this.buttonInchide.TabIndex = 18;
            this.buttonInchide.Text = "Inchide";
            this.buttonInchide.UseVisualStyleBackColor = true;
            this.buttonInchide.Click += new System.EventHandler(this.buttonInchide_Click);
            // 
            // progressBarQuick
            // 
            this.progressBarQuick.Location = new System.Drawing.Point(233, 360);
            this.progressBarQuick.Name = "progressBarQuick";
            this.progressBarQuick.Size = new System.Drawing.Size(521, 34);
            this.progressBarQuick.TabIndex = 19;
            // 
            // progressBarShell
            // 
            this.progressBarShell.Location = new System.Drawing.Point(233, 414);
            this.progressBarShell.Name = "progressBarShell";
            this.progressBarShell.Size = new System.Drawing.Size(521, 34);
            this.progressBarShell.TabIndex = 20;
            // 
            // progressBarBubble
            // 
            this.progressBarBubble.Location = new System.Drawing.Point(233, 465);
            this.progressBarBubble.Name = "progressBarBubble";
            this.progressBarBubble.Size = new System.Drawing.Size(521, 34);
            this.progressBarBubble.TabIndex = 21;
            // 
            // progressBarSelection
            // 
            this.progressBarSelection.Location = new System.Drawing.Point(233, 518);
            this.progressBarSelection.Name = "progressBarSelection";
            this.progressBarSelection.Size = new System.Drawing.Size(521, 34);
            this.progressBarSelection.TabIndex = 23;
            this.progressBarSelection.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // buttonSelectionSort
            // 
            this.buttonSelectionSort.Location = new System.Drawing.Point(50, 518);
            this.buttonSelectionSort.Name = "buttonSelectionSort";
            this.buttonSelectionSort.Size = new System.Drawing.Size(136, 34);
            this.buttonSelectionSort.TabIndex = 22;
            this.buttonSelectionSort.Text = "Selection Sort";
            this.buttonSelectionSort.UseVisualStyleBackColor = true;
            this.buttonSelectionSort.Click += new System.EventHandler(this.buttonSelectionSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 883);
            this.Controls.Add(this.progressBarSelection);
            this.Controls.Add(this.buttonSelectionSort);
            this.Controls.Add(this.progressBarBubble);
            this.Controls.Add(this.progressBarShell);
            this.Controls.Add(this.progressBarQuick);
            this.Controls.Add(this.buttonInchide);
            this.Controls.Add(this.buttonDespre);
            this.Controls.Add(this.buttonSterge);
            this.Controls.Add(this.textBoxRezultat);
            this.Controls.Add(this.buttonBubbleSort);
            this.Controls.Add(this.buttonShellSort);
            this.Controls.Add(this.buttonQuickSort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonGenDesc);
            this.Controls.Add(this.buttonGenCresc);
            this.Controls.Add(this.buttonGenRandom);
            this.Controls.Add(this.textBoxLungime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSeed);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Evaluarea vitezei de executie - Sortari";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLungime;
        private System.Windows.Forms.Button buttonGenRandom;
        private System.Windows.Forms.Button buttonGenCresc;
        private System.Windows.Forms.Button buttonGenDesc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonButtonStopwatch;
        private System.Windows.Forms.RadioButton radioButtonPerformance;
        private System.Windows.Forms.RadioButton radioButtonDateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonQuickSort;
        private System.Windows.Forms.Button buttonShellSort;
        private System.Windows.Forms.Button buttonBubbleSort;
        private System.Windows.Forms.TextBox textBoxRezultat;
        private System.Windows.Forms.Button buttonSterge;
        private System.Windows.Forms.Button buttonDespre;
        private System.Windows.Forms.Button buttonInchide;
        private System.Windows.Forms.ProgressBar progressBarQuick;
        private System.Windows.Forms.ProgressBar progressBarShell;
        private System.Windows.Forms.ProgressBar progressBarBubble;
        private System.Windows.Forms.ProgressBar progressBarSelection;
        private System.Windows.Forms.Button buttonSelectionSort;
    }
}

