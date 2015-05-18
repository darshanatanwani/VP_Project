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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_toConvert_mp3 = new System.Windows.Forms.Button();
            this.tb_mp3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_toConvert_wav = new System.Windows.Forms.Button();
            this.tb_wave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_ConvertToMP3 = new System.Windows.Forms.Button();
            this.lb_showUserText = new System.Windows.Forms.Label();
            this.container = new System.Windows.Forms.SplitContainer();
            this.listAudioDevice = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonRefreshAudioList = new System.Windows.Forms.Button();
            this.buttonRecordVoice = new System.Windows.Forms.Button();
            this.PbWave = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.bt_convert_WavToMp3 = new System.Windows.Forms.Button();
            this.tabPageMatch.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.container)).BeginInit();
            this.container.Panel1.SuspendLayout();
            this.container.Panel2.SuspendLayout();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbWave)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageMatch
            // 
            this.tabPageMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPageMatch.Controls.Add(this.pnlMain);
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
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.bt_convert_WavToMp3);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.bt_toConvert_mp3);
            this.pnlMain.Controls.Add(this.tb_mp3);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.bt_toConvert_wav);
            this.pnlMain.Controls.Add(this.tb_wave);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Location = new System.Drawing.Point(8, 6);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(519, 434);
            this.pnlMain.TabIndex = 1;
            this.pnlMain.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label4.Location = new System.Drawing.Point(94, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Destination File Path For Mp3";
            // 
            // bt_toConvert_mp3
            // 
            this.bt_toConvert_mp3.Location = new System.Drawing.Point(381, 241);
            this.bt_toConvert_mp3.Name = "bt_toConvert_mp3";
            this.bt_toConvert_mp3.Size = new System.Drawing.Size(75, 23);
            this.bt_toConvert_mp3.TabIndex = 5;
            this.bt_toConvert_mp3.Text = "browse";
            this.bt_toConvert_mp3.UseVisualStyleBackColor = true;
            this.bt_toConvert_mp3.Click += new System.EventHandler(this.bt_toConvert_mp3_Click);
            // 
            // tb_mp3
            // 
            this.tb_mp3.Location = new System.Drawing.Point(97, 244);
            this.tb_mp3.Name = "tb_mp3";
            this.tb_mp3.Size = new System.Drawing.Size(278, 20);
            this.tb_mp3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label3.Location = new System.Drawing.Point(94, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Wav File Path";
            // 
            // bt_toConvert_wav
            // 
            this.bt_toConvert_wav.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt_toConvert_wav.Location = new System.Drawing.Point(381, 181);
            this.bt_toConvert_wav.Name = "bt_toConvert_wav";
            this.bt_toConvert_wav.Size = new System.Drawing.Size(75, 23);
            this.bt_toConvert_wav.TabIndex = 2;
            this.bt_toConvert_wav.Text = "browse";
            this.bt_toConvert_wav.UseVisualStyleBackColor = true;
            this.bt_toConvert_wav.Click += new System.EventHandler(this.bt_toConvert_wav_Click);
            // 
            // tb_wave
            // 
            this.tb_wave.Location = new System.Drawing.Point(97, 184);
            this.tb_wave.Name = "tb_wave";
            this.tb_wave.Size = new System.Drawing.Size(278, 20);
            this.tb_wave.TabIndex = 1;
            this.tb_wave.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(136, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "Conversion To MP3";
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMatch);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(541, 476);
            this.tabControl1.TabIndex = 0;
            // 
            // bt_convert_WavToMp3
            // 
            this.bt_convert_WavToMp3.Location = new System.Drawing.Point(216, 305);
            this.bt_convert_WavToMp3.Name = "bt_convert_WavToMp3";
            this.bt_convert_WavToMp3.Size = new System.Drawing.Size(117, 30);
            this.bt_convert_WavToMp3.TabIndex = 7;
            this.bt_convert_WavToMp3.Text = "Convert";
            this.bt_convert_WavToMp3.UseVisualStyleBackColor = true;
            this.bt_convert_WavToMp3.Click += new System.EventHandler(this.bt_convert_WavToMp3_Click);
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
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.container.Panel1.ResumeLayout(false);
            this.container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.container)).EndInit();
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbWave)).EndInit();
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
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_toConvert_wav;
        private System.Windows.Forms.TextBox tb_wave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_toConvert_mp3;
        private System.Windows.Forms.TextBox tb_mp3;
        private System.Windows.Forms.Button bt_convert_WavToMp3;

        #endregion
        // private System.Windows.Forms.PictureBox pbwave;
    }
}

