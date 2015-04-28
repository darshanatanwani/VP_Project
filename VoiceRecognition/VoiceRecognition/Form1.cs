using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VoiceRecognition
{
    public partial class FormVoiceRecognition : Form
    {
        public FormVoiceRecognition()
        {
            InitializeComponent();
        }

        private void buttonRecordVoice_Click(object sender, EventArgs e)
        {
            if (buttonRecordVoice.Text == "Record Voice")
            {
                buttonRecordVoice.Text = "Stop Recording";
                PbWave .Visible = true;

            }
            else if (buttonRecordVoice.Text == "Stop Recording")
            {
                buttonRecordVoice.Text = "Record Voice";
                PbWave .Visible = false;
            }
        }

        public string userSelectedFilePath
        {
            get
            {
                return textBoxBrowse.Text;
            }
            set
            {
                textBoxBrowse.Text = value;
            }

        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileDialog = new OpenFileDialog();
            System.Windows.Forms.DialogResult Dr = FileDialog.ShowDialog();
            if (Dr == DialogResult.OK)
            {
                userSelectedFilePath = FileDialog.FileName;
            }
        }

        private void buttonIndex_Click(object sender, EventArgs e)
        {
            comboBoxIndex.Items.Add(textBoxBrowse.Text);
          
        }
    }
}