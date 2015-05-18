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
using Alvas.Audio;

#region <Alvas API>
///<summary><Alvas Library>
/// using Alvas.Audio;
/// </summary>
#endregion

#region <NAudio API>
///<summary><Alvas Library>
using NAudio;
using NAudio.Wave;
/// </summary>
#endregion

namespace VoiceRecognition
{

    public partial class FormVoiceRecognition : Form
    { 
        string[] audioFiles = null;
        string[] groundTruthAudioFingerprints = null;
        string[] configFiles = null;
        string[] matchFiles = null;
        private string dataDirectoryPath = @"data";
        private NAudio.Wave.WaveIn sourceStream = null;
        private NAudio.Wave.DirectSoundOut waveOut = null;
        NAudio.Wave.WaveFileWriter waveWriter = null;

        public FormVoiceRecognition()
        {
            InitializeComponent();
        }


        private void buttonRecordVoice_Click(object sender, EventArgs e)
        {
            
        }

        private void sourceStream_DataAvaliable(object sender, WaveInEventArgs e)
        {
            if (waveWriter == null) return;
            waveWriter.WriteData(e.Buffer, 0, e.BytesRecorded);
            waveWriter.Flush();
        }


        //private void stopRecordingMP3()
        //{
        //    recordWave.Stop();
        //}

        //private void startRecordingMP3()
        //{
        //    showAudioWave();
        //    setOutputFolder();
        //    selectAudioDevice();
        //    recordWave.Start();
        //}

        //private void showAudioWave()
        //{
        //    recordWave.Visible = true;
        //    recordWave.ShowWaveForm = true;
        //}

        //private void selectAudioDevice()
        //{
        //    recordWave.AudioDevice = 0;
        //    recordWave.AudioInputPin = 0;
        //}

        //private void setOutputFolder()
        //{
        //    recordWave.OutputType = AUDIOCAPTURELib.AudioEnum.AUDIO_MP3;
        //    recordWave.MP3Channels = 2;
        //    recordWave.MP3AudioBitrate = 224;
        //    recordWave.MP3SampleRate = 44100;
        //    recordWave.AudioFileName = @"c:\test\darshna1.mp3";
        //}



        //private void startRecordingMP3(string path)
        //{
        //    recordMP3.Close += new EventHandler(recordMP3_closeMp3);
        //    recordMP3.Data += new RecorderEx.DataEventHandler(recordMP3_dataMp3);
        //    FormatDetails[] fdArr = AudioCompressionManager.GetFormatList(AudioCompressionManager.MpegLayer3FormatTag);
        //    IntPtr format = fdArr[fdArr.Length - 1].FormatHandle;//GetMp3Format(2, 56, 24000);
        //    recordMP3.Format = format;
        //    mp3_path = new Mp3Writer(File.Create(path));

        //    recordMP3.StartRecord();
        //}

        //private void recordMP3_dataMp3(object sender, DataEventArgs e)
        //{
        //    mp3_path.WriteData(e.Data);
        //}

        //private void recordMP3_closeMp3(object sender, EventArgs e)
        //{
        //    recordMP3.StopRecord();
        //}

        //public string userSelectedFilePath
        //{
        //    get
        //    {
        //        return textBoxBrowse.Text;
        //    }
        //    set
        //    {
        //        textBoxBrowse.Text = value;
        //    }

        //}

        //private void buttonBrowse_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog FileDialog = new OpenFileDialog();
        //    System.Windows.Forms.DialogResult Dr = FileDialog.ShowDialog();
        //    if (Dr == DialogResult.OK)
        //    {
        //        userSelectedFilePath = FileDialog.FileName;
        //    }
        //}

        //private void buttonIndex_Click(object sender, EventArgs e)
        //{
        //    richTextBox1.Clear();
        //    //comboBoxIndex.Items.Add(textBoxBrowse.Text);
        //    //Read all related data from dataDirectoryPath
        //    string[] subDirectories = Directory.GetDirectories(dataDirectoryPath);
        //    foreach (string subDir in subDirectories)
        //    {
        //        if (Path.GetFileName(subDir).Equals("audio"))
        //        {
        //            audioFiles = Directory.GetFiles(subDir);
        //            foreach (string audiofile in audioFiles)
        //            {
        //                richTextBox1.AppendText(audiofile);
        //                richTextBox1.AppendText(Environment.NewLine);
        //            }
        //        }//End if
        //    }//End foreach
            
        //}



        
        //private void buttonPerformMatching_Click(object sender, EventArgs e)
        //{
            
        //    //Evaluate system object initialization
        //    Evaluate evaluate = new Evaluate();
        //    //EvaluteSystem function call will return false[test failed] or true[test successful]
        //    if (evaluate.EvaluateSystem(audioFiles, groundTruthAudioFingerprints, configFiles, matchFiles))
        //    {
        //        richTextBox_matchResult.ForeColor = Color.Green;
        //        richTextBox_matchResult.AppendText(Environment.NewLine);
        //        richTextBox_matchResult.AppendText ("\n\n\n Successful Match");
        //    }//End if
        //    else
        //    {
        //        string result = "Failure in Matching";
        //        richTextBox_matchResult.BackColor = Color.Red;
        //        //richTextBox_matchResult.SelectionFont.Bold = true; 
        //        richTextBox_matchResult.ForeColor = Color.Red;
        //        //richTextBox_matchResult.AppendText(Environment.NewLine);
        //        richTextBox_matchResult.AppendText(result);
        //        //richTextBox_matchResult.Text = "\n\n\n Failure in Matching";
        //        //richTextBox_matchResult.BackColor = Color.PaleVioletRed;
        //        //textBox_matchResult.ForeColor = Color.Red;
        //        //textBox_matchResult.Text = "\n\n\n Failure in Matching";

        //    }//End else

        //    richTextBox_matchResult.ForeColor = Color.White;
        //}

        private void buttonRecordVoice_Click_1(object sender, EventArgs e)
        {
            if (buttonRecordVoice.Text == "Record")
            {
                buttonRecordVoice.Text = "Stop";
                PbWave.Visible = true;
                //startRecordingMP3();
                //string path = Path.ChangeExtension(Application.ExecutablePath, ".wav");
                //startRecordingMP3(path);
                try
                {
                    if (listAudioDevice.SelectedItems.Count == 0) return;

                    SaveFileDialog save = new SaveFileDialog();
                    save.Filter = "Wave File (*.wav)|*.wav";
                    if (save.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                        return;

                    int deviceNumber = listAudioDevice.SelectedItems[0].Index;

                    sourceStream = new NAudio.Wave.WaveIn();
                    sourceStream.DeviceNumber = deviceNumber;
                    sourceStream.WaveFormat = new NAudio.Wave.WaveFormat(44100, NAudio.Wave.WaveIn.GetCapabilities(deviceNumber).Channels);

                    sourceStream.DataAvailable += new EventHandler<NAudio.Wave.WaveInEventArgs>(sourceStream_DataAvaliable);
                    waveWriter = new NAudio.Wave.WaveFileWriter(save.FileName, sourceStream.WaveFormat);
                    sourceStream.StartRecording();

                    // afterwards
                    //waveOut = new NAudio.Wave.DirectSoundOut();
                    //NAudio.Wave.WaveInProvider waveIn = new NAudio.Wave.WaveInProvider(sourceStream);
                    //waveOut.Init(waveIn);
                    //sourceStream.StartRecording();
                    //waveOut.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Plz select AUDIO Device");
                }
            }
            else if (buttonRecordVoice.Text == "Stop")
            {
                buttonRecordVoice.Text = "Record";
                PbWave.Visible = false;
                //stopRecordingMP3();

                // disppsing the resources if in use
                if (waveOut != null)
                {
                    waveOut.Stop();
                    waveOut.Dispose();
                    waveOut = null;
                }
                if (sourceStream != null)
                {
                    sourceStream.StopRecording();
                    sourceStream.Dispose();
                    sourceStream = null;
                }
                if (waveWriter != null)
                {
                    waveWriter.Dispose();
                    waveWriter = null;
                }
                lb_showUserText.Visible = true;
                bt_ConvertToMP3.Visible = true;
            }
        }




        /// <summary>
        /// To Refresh the List of Audio Devices Avaliable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRefreshAudioList_Click_1(object sender, EventArgs e)
        {
            ListAudioDevicesAvalibale();
        }

        /// <summary>
        /// To List the Audio Devices in the AUDIO Devices Listbox
        /// </summary>
        private void ListAudioDevicesAvalibale()
        {
            List<NAudio.Wave.WaveInCapabilities> sources = new List<NAudio.Wave.WaveInCapabilities>();
            for (int i = 0; i < NAudio.Wave.WaveIn.DeviceCount; i++)
            {
                sources.Add(NAudio.Wave.WaveIn.GetCapabilities(i));
            }
            // just like clear first the items in the list
            listAudioDevice.Items.Clear();

            foreach (var source in sources)
            {
                ListViewItem item = new ListViewItem(source.ProductName);
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, source.Channels.ToString()));
                listAudioDevice.Items.Add(item);
            }
            buttonRecordVoice.Visible = true;
        }

        /// <summary>
        /// To call the convert method for mp3 converstion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_ConvertToMP3_Click(object sender, EventArgs e)
        {
            container.Visible = false;
            lb_showUserText.Visible = false;
            bt_ConvertToMP3.Visible = false;
            pnlMain.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Method to convert Wav to MP3
        /// </summary>

    }
}