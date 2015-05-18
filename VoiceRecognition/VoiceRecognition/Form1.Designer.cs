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
            this.tabPageMatch = new System.Windows.Forms.TabPage();
            this.PbWave = new System.Windows.Forms.PictureBox();
            this.container = new System.Windows.Forms.SplitContainer();
            this.buttonRecordVoice = new System.Windows.Forms.Button();
            this.buttonRefreshAudioList = new System.Windows.Forms.Button();
            this.listAudioDevice = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.lb_showUserText = new System.Windows.Forms.Label();
            this.bt_ConvertToMP3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageMatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbWave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.container)).BeginInit();
            this.container.Panel1.SuspendLayout();
            this.container.Panel2.SuspendLayout();
            this.container.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageMatch
            // 
            this.tabPageMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPageMatch.Controls.Add(this.label1);
            this.tabPageMatch.Controls.Add(this.bt_ConvertToMP3);
            this.tabPageMatch.Controls.Add(this.lb_showUserText);
            this.tabPageMatch.Controls.Add(this.container);
            this.tabPageMatch.Controls.Add(this.PbWave);
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
            this.PbWave.Location = new System.Drawing.Point(27, 392);
            this.PbWave.Name = "PbWave";
            this.PbWave.Size = new System.Drawing.Size(476, 15);
            this.PbWave.TabIndex = 5;
            this.PbWave.TabStop = false;
            this.PbWave.Visible = false;
            // 
            // container
            // 
            this.container.Location = new System.Drawing.Point(8, 37);
            this.container.Name = "container";
            // 
            // container.Panel1
            // 
            this.container.Panel1.Controls.Add(this.listAudioDevice);
            // 
            // container.Panel2
            // 
            this.container.Panel2.Controls.Add(this.buttonRefreshAudioList);
            this.container.Panel2.Controls.Add(this.buttonRecordVoice);
            this.container.Size = new System.Drawing.Size(519, 134);
            this.container.SplitterDistance = 333;
            this.container.TabIndex = 8;
            // 
            // buttonRecordVoice
            // 
            this.buttonRecordVoice.Location = new System.Drawing.Point(24, 69);
            this.buttonRecordVoice.Name = "buttonRecordVoice";
            this.buttonRecordVoice.Size = new System.Drawing.Size(143, 34);
            this.buttonRecordVoice.TabIndex = 0;
            this.buttonRecordVoice.Text = "Record";
            this.buttonRecordVoice.UseVisualStyleBackColor = true;
            this.buttonRecordVoice.Visible = false;
            this.buttonRecordVoice.Click += new System.EventHandler(this.buttonRecordVoice_Click_1);
            // 
            // buttonRefreshAudioList
            // 
            this.buttonRefreshAudioList.Location = new System.Drawing.Point(24, 25);
            this.buttonRefreshAudioList.Name = "buttonRefreshAudioList";
            this.buttonRefreshAudioList.Size = new System.Drawing.Size(143, 38);
            this.buttonRefreshAudioList.TabIndex = 6;
            this.buttonRefreshAudioList.Text = "Refresh Audio Device List";
            this.buttonRefreshAudioList.UseVisualStyleBackColor = true;
            this.buttonRefreshAudioList.Click += new System.EventHandler(this.buttonRefreshAudioList_Click_1);
            // 
            // listAudioDevice
            // 
            this.listAudioDevice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listAudioDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listAudioDevice.Location = new System.Drawing.Point(0, 0);
            this.listAudioDevice.MultiSelect = false;
            this.listAudioDevice.Name = "listAudioDevice";
            this.listAudioDevice.Size = new System.Drawing.Size(333, 134);
            this.listAudioDevice.TabIndex = 0;
            this.listAudioDevice.UseCompatibleStateImageBehavior = false;
            this.listAudioDevice.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Audio Device";
            this.columnHeader1.Width = 189;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Channels";
            this.columnHeader2.Width = 112;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMatch);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(541, 476);
            this.tabControl1.TabIndex = 0;
            // 
            // lb_showUserText
            // 
            this.lb_showUserText.AutoSize = true;
            this.lb_showUserText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_showUserText.ForeColor = System.Drawing.Color.Chartreuse;
            this.lb_showUserText.Location = new System.Drawing.Point(65, 213);
            this.lb_showUserText.Name = "lb_showUserText";
            this.lb_showUserText.Size = new System.Drawing.Size(411, 18);
            this.lb_showUserText.TabIndex = 9;
            this.lb_showUserText.Text = "You have recorded your WAV now convert it into MP3";
            this.lb_showUserText.Visible = false;
            // 
            // bt_ConvertToMP3
            // 
            this.bt_ConvertToMP3.Location = new System.Drawing.Point(186, 271);
            this.bt_ConvertToMP3.Name = "bt_ConvertToMP3";
            this.bt_ConvertToMP3.Size = new System.Drawing.Size(143, 34);
            this.bt_ConvertToMP3.TabIndex = 7;
            this.bt_ConvertToMP3.Text = "Convert To MP3";
            this.bt_ConvertToMP3.UseVisualStyleBackColor = true;
            this.bt_ConvertToMP3.Visible = false;
            this.bt_ConvertToMP3.Click += new System.EventHandler(this.bt_ConvertToMP3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(47, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Now convert your WAV to MP3";
            this.label1.Visible = false;
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
            this.tabPageMatch.ResumeLayout(false);
            this.tabPageMatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbWave)).EndInit();
            this.container.Panel1.ResumeLayout(false);
            this.container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.container)).EndInit();
            this.container.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabPage tabPageMatch;
        private System.Windows.Forms.SplitContainer container;
        private System.Windows.Forms.ListView listAudioDevice;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button buttonRefreshAudioList;
        private System.Windows.Forms.Button buttonRecordVoice;
        private System.Windows.Forms.PictureBox PbWave;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label lb_showUserText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_ConvertToMP3;

        #endregion
        // private System.Windows.Forms.PictureBox pbwave;
    }
}

