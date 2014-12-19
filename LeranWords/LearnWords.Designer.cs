namespace LeranWords
{
    partial class LearnWords
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
            this.comboBoxSelectListWithWords = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.groupBoxForDirection = new System.Windows.Forms.GroupBox();
            this.radioButtonPolishRussian = new System.Windows.Forms.RadioButton();
            this.radioButtonRussianPolish = new System.Windows.Forms.RadioButton();
            this.textBoxForWordToBeTranslated = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLogWithResults = new System.Windows.Forms.TextBox();
            this.backgroundWorkerMain = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxForTypedTranslation = new System.Windows.Forms.TextBox();
            this.buttonCheckTranslation = new System.Windows.Forms.Button();
            this.backgroundWorkerForCheckingTranslation = new System.ComponentModel.BackgroundWorker();
            this.groupBoxForDirection.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxSelectListWithWords
            // 
            this.comboBoxSelectListWithWords.FormattingEnabled = true;
            this.comboBoxSelectListWithWords.Location = new System.Drawing.Point(141, 27);
            this.comboBoxSelectListWithWords.Name = "comboBoxSelectListWithWords";
            this.comboBoxSelectListWithWords.Size = new System.Drawing.Size(283, 21);
            this.comboBoxSelectListWithWords.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select list with words:";
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(535, 14);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(196, 45);
            this.buttonRun.TabIndex = 2;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(535, 88);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(196, 45);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // groupBoxForDirection
            // 
            this.groupBoxForDirection.Controls.Add(this.radioButtonPolishRussian);
            this.groupBoxForDirection.Controls.Add(this.radioButtonRussianPolish);
            this.groupBoxForDirection.Location = new System.Drawing.Point(12, 64);
            this.groupBoxForDirection.Name = "groupBoxForDirection";
            this.groupBoxForDirection.Size = new System.Drawing.Size(113, 69);
            this.groupBoxForDirection.TabIndex = 4;
            this.groupBoxForDirection.TabStop = false;
            this.groupBoxForDirection.Text = "Select direction";
            // 
            // radioButtonPolishRussian
            // 
            this.radioButtonPolishRussian.AutoSize = true;
            this.radioButtonPolishRussian.Location = new System.Drawing.Point(6, 50);
            this.radioButtonPolishRussian.Name = "radioButtonPolishRussian";
            this.radioButtonPolishRussian.Size = new System.Drawing.Size(100, 17);
            this.radioButtonPolishRussian.TabIndex = 1;
            this.radioButtonPolishRussian.Text = "Polish - Russian";
            this.radioButtonPolishRussian.UseVisualStyleBackColor = true;
            // 
            // radioButtonRussianPolish
            // 
            this.radioButtonRussianPolish.AutoSize = true;
            this.radioButtonRussianPolish.Checked = true;
            this.radioButtonRussianPolish.Location = new System.Drawing.Point(6, 26);
            this.radioButtonRussianPolish.Name = "radioButtonRussianPolish";
            this.radioButtonRussianPolish.Size = new System.Drawing.Size(100, 17);
            this.radioButtonRussianPolish.TabIndex = 0;
            this.radioButtonRussianPolish.TabStop = true;
            this.radioButtonRussianPolish.Text = "Russian - Polish";
            this.radioButtonRussianPolish.UseVisualStyleBackColor = true;
            // 
            // textBoxForWordToBeTranslated
            // 
            this.textBoxForWordToBeTranslated.Enabled = false;
            this.textBoxForWordToBeTranslated.Location = new System.Drawing.Point(266, 73);
            this.textBoxForWordToBeTranslated.Name = "textBoxForWordToBeTranslated";
            this.textBoxForWordToBeTranslated.Size = new System.Drawing.Size(221, 20);
            this.textBoxForWordToBeTranslated.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Translate this word:";
            // 
            // textBoxLogWithResults
            // 
            this.textBoxLogWithResults.Enabled = false;
            this.textBoxLogWithResults.Location = new System.Drawing.Point(12, 160);
            this.textBoxLogWithResults.Multiline = true;
            this.textBoxLogWithResults.Name = "textBoxLogWithResults";
            this.textBoxLogWithResults.Size = new System.Drawing.Size(730, 312);
            this.textBoxLogWithResults.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Type translation here:";
            // 
            // textBoxForTypedTranslation
            // 
            this.textBoxForTypedTranslation.Location = new System.Drawing.Point(266, 113);
            this.textBoxForTypedTranslation.Name = "textBoxForTypedTranslation";
            this.textBoxForTypedTranslation.Size = new System.Drawing.Size(133, 20);
            this.textBoxForTypedTranslation.TabIndex = 8;
            // 
            // buttonCheckTranslation
            // 
            this.buttonCheckTranslation.Location = new System.Drawing.Point(420, 107);
            this.buttonCheckTranslation.Name = "buttonCheckTranslation";
            this.buttonCheckTranslation.Size = new System.Drawing.Size(88, 34);
            this.buttonCheckTranslation.TabIndex = 10;
            this.buttonCheckTranslation.Text = "Check translation";
            this.buttonCheckTranslation.UseVisualStyleBackColor = true;
            this.buttonCheckTranslation.Click += new System.EventHandler(this.buttonCheckTranslation_Click);
            // 
            // LearnWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 484);
            this.Controls.Add(this.buttonCheckTranslation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxForTypedTranslation);
            this.Controls.Add(this.textBoxLogWithResults);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxForWordToBeTranslated);
            this.Controls.Add(this.groupBoxForDirection);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSelectListWithWords);
            this.KeyPreview = true;
            this.Name = "LearnWords";
            this.Text = "LearnWords";
            this.Load += new System.EventHandler(this.LearnWords_Load);
            this.groupBoxForDirection.ResumeLayout(false);
            this.groupBoxForDirection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSelectListWithWords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.GroupBox groupBoxForDirection;
        private System.Windows.Forms.RadioButton radioButtonPolishRussian;
        private System.Windows.Forms.RadioButton radioButtonRussianPolish;
        private System.Windows.Forms.TextBox textBoxForWordToBeTranslated;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLogWithResults;
        private System.ComponentModel.BackgroundWorker backgroundWorkerMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxForTypedTranslation;
        private System.Windows.Forms.Button buttonCheckTranslation;
        private System.ComponentModel.BackgroundWorker backgroundWorkerForCheckingTranslation;
    }
}

