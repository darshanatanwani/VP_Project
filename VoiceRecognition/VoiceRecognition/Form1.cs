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
        string[] audioFiles = null;
        string[] groundTruthAudioFingerprints = null;
        string[] configFiles = null;
        string[] matchFiles = null;
        private string dataDirectoryPath = @"data";

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
            richTextBox1.Clear();
            //comboBoxIndex.Items.Add(textBoxBrowse.Text);
            //Read all related data from dataDirectoryPath
            string[] subDirectories = Directory.GetDirectories(dataDirectoryPath);
            foreach (string subDir in subDirectories)
            {
                if (Path.GetFileName(subDir).Equals("audio"))
                {
                    audioFiles = Directory.GetFiles(subDir);
                    foreach (string audiofile in audioFiles)
                    {
                        richTextBox1.AppendText(audiofile);
                        richTextBox1.AppendText(Environment.NewLine);
                    }
                }//End if
            }//End foreach
            
        }



        
        private void buttonPerformMatching_Click(object sender, EventArgs e)
        {
            



            //Evaluate system object initialization
            Evaluate evaluate = new Evaluate();
            //EvaluteSystem function call will return false[test failed] or true[test successful]
            if (evaluate.EvaluateSystem(audioFiles, groundTruthAudioFingerprints, configFiles, matchFiles))
            {
                richTextBox_matchResult.ForeColor = Color.Green;
                richTextBox_matchResult.AppendText(Environment.NewLine);
                richTextBox_matchResult.AppendText ("\n\n\n Successful Match");
            }//End if
            else
            {
                string result = "Failure in Matching";
                richTextBox_matchResult.BackColor = Color.Red;
                //richTextBox_matchResult.SelectionFont.Bold = true; 
                richTextBox_matchResult.ForeColor = Color.Red;
                //richTextBox_matchResult.AppendText(Environment.NewLine);
                richTextBox_matchResult.AppendText(result);
                //richTextBox_matchResult.Text = "\n\n\n Failure in Matching";
                //richTextBox_matchResult.BackColor = Color.PaleVioletRed;
                //textBox_matchResult.ForeColor = Color.Red;
                //textBox_matchResult.Text = "\n\n\n Failure in Matching";



            }//End else

            richTextBox_matchResult.ForeColor = Color.White;
        }
    }
}