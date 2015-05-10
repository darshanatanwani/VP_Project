namespace VoiceRecognition
{
    partial class FormVoiceRecognition
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageIndex = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBoxIndex = new System.Windows.Forms.ComboBox();
            this.labelIndex = new System.Windows.Forms.Label();
            this.buttonIndex = new System.Windows.Forms.Button();
            this.labelAudioFilePath = new System.Windows.Forms.Label();
            this.textBoxBrowse = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.tabPageMatch = new System.Windows.Forms.TabPage();
            this.PbWave = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_matchResult = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonPerformMatching = new System.Windows.Forms.Button();
            this.buttonRecordVoice = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageIndex.SuspendLayout();
            this.tabPageMatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbWave)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageIndex);
            this.tabControl1.Controls.Add(this.tabPageMatch);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(541, 476);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageIndex
            // 
            this.tabPageIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPageIndex.Controls.Add(this.richTextBox1);
            this.tabPageIndex.Controls.Add(this.comboBoxIndex);
            this.tabPageIndex.Controls.Add(this.labelIndex);
            this.tabPageIndex.Controls.Add(this.buttonIndex);
            this.tabPageIndex.Controls.Add(this.labelAudioFilePath);
            this.tabPageIndex.Controls.Add(this.textBoxBrowse);
            this.tabPageIndex.Controls.Add(this.buttonBrowse);
            this.tabPageIndex.Location = new System.Drawing.Point(4, 22);
            this.tabPageIndex.Name = "tabPageIndex";
            this.tabPageIndex.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIndex.Size = new System.Drawing.Size(533, 450);
            this.tabPageIndex.TabIndex = 0;
            this.tabPageIndex.Text = "Index";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(135, 134);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(275, 258);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // comboBoxIndex
            // 
            this.comboBoxIndex.FormattingEnabled = true;
            this.comboBoxIndex.Location = new System.Drawing.Point(135, 134);
            this.comboBoxIndex.Name = "comboBoxIndex";
            this.comboBoxIndex.Size = new System.Drawing.Size(275, 21);
            this.comboBoxIndex.TabIndex = 6;
            this.comboBoxIndex.Visible = false;
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelIndex.Location = new System.Drawing.Point(37, 142);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(77, 13);
            this.labelIndex.TabIndex = 5;
            this.labelIndex.Text = "Index File Path";
            // 
            // buttonIndex
            // 
            this.buttonIndex.Location = new System.Drawing.Point(416, 134);
            this.buttonIndex.Name = "buttonIndex";
            this.buttonIndex.Size = new System.Drawing.Size(75, 23);
            this.buttonIndex.TabIndex = 4;
            this.buttonIndex.Text = "Index";
            this.buttonIndex.UseVisualStyleBackColor = true;
            this.buttonIndex.Click += new System.EventHandler(this.buttonIndex_Click);
            // 
            // labelAudioFilePath
            // 
            this.labelAudioFilePath.AutoSize = true;
            this.labelAudioFilePath.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAudioFilePath.Location = new System.Drawing.Point(37, 61);
            this.labelAudioFilePath.Name = "labelAudioFilePath";
            this.labelAudioFilePath.Size = new System.Drawing.Size(78, 13);
            this.labelAudioFilePath.TabIndex = 3;
            this.labelAudioFilePath.Text = "Audio File Path";
            // 
            // textBoxBrowse
            // 
            this.textBoxBrowse.Location = new System.Drawing.Point(135, 54);
            this.textBoxBrowse.Name = "textBoxBrowse";
            this.textBoxBrowse.Size = new System.Drawing.Size(275, 20);
            this.textBoxBrowse.TabIndex = 2;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(416, 53);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 20);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // tabPageMatch
            // 
            this.tabPageMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPageMatch.Controls.Add(this.PbWave);
            this.tabPageMatch.Controls.Add(this.label1);
            this.tabPageMatch.Controls.Add(this.richTextBox_matchResult);
            this.tabPageMatch.Controls.Add(this.progressBar1);
            this.tabPageMatch.Controls.Add(this.buttonPerformMatching);
            this.tabPageMatch.Controls.Add(this.buttonRecordVoice);
            this.tabPageMatch.Location = new System.Drawing.Point(4, 22);
            this.tabPageMatch.Name = "tabPageMatch";
            this.tabPageMatch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMatch.Size = new System.Drawing.Size(533, 450);
            this.tabPageMatch.TabIndex = 1;
            this.tabPageMatch.Text = "Match";
            // 
            // PbWave
            // 
            this.PbWave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbWave.Image = global::VoiceRecognition.Properties.Resources.waveanimation1;
            this.PbWave.Location = new System.Drawing.Point(25, 194);
            this.PbWave.Name = "PbWave";
            this.PbWave.Size = new System.Drawing.Size(476, 37);
            this.PbWave.TabIndex = 5;
            this.PbWave.TabStop = false;
            this.PbWave.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Matches";
            // 
            // richTextBox_matchResult
            // 
            this.richTextBox_matchResult.Location = new System.Drawing.Point(0, 289);
            this.richTextBox_matchResult.Name = "richTextBox_matchResult";
            this.richTextBox_matchResult.Size = new System.Drawing.Size(533, 161);
            this.richTextBox_matchResult.TabIndex = 3;
            this.richTextBox_matchResult.Text = "";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 247);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(533, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // buttonPerformMatching
            // 
            this.buttonPerformMatching.Location = new System.Drawing.Point(294, 6);
            this.buttonPerformMatching.Name = "buttonPerformMatching";
            this.buttonPerformMatching.Size = new System.Drawing.Size(189, 33);
            this.buttonPerformMatching.TabIndex = 1;
            this.buttonPerformMatching.Text = "Perform Matching";
            this.buttonPerformMatching.UseVisualStyleBackColor = true;
            this.buttonPerformMatching.Click += new System.EventHandler(this.buttonPerformMatching_Click);
            // 
            // buttonRecordVoice
            // 
            this.buttonRecordVoice.Location = new System.Drawing.Point(51, 6);
            this.buttonRecordVoice.Name = "buttonRecordVoice";
            this.buttonRecordVoice.Size = new System.Drawing.Size(189, 33);
            this.buttonRecordVoice.TabIndex = 0;
            this.buttonRecordVoice.Text = "Record Voice";
            this.buttonRecordVoice.UseVisualStyleBackColor = true;
            this.buttonRecordVoice.Click += new System.EventHandler(this.buttonRecordVoice_Click);
            // 
            // FormVoiceRecognition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(539, 474);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FormVoiceRecognition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voice Recognition";
            this.tabControl1.ResumeLayout(false);
            this.tabPageIndex.ResumeLayout(false);
            this.tabPageIndex.PerformLayout();
            this.tabPageMatch.ResumeLayout(false);
            this.tabPageMatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbWave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageIndex;
        private System.Windows.Forms.TabPage tabPageMatch;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxBrowse;
        private System.Windows.Forms.Button buttonIndex;
        private System.Windows.Forms.Label labelAudioFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox_matchResult;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonPerformMatching;
        private System.Windows.Forms.Button buttonRecordVoice;
        private System.Windows.Forms.PictureBox PbWave;
        private System.Windows.Forms.ComboBox comboBoxIndex;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.RichTextBox richTextBox1;
        // private System.Windows.Forms.PictureBox pbwave;
    }
}

