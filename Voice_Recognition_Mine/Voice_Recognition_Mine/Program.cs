using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Voice_Recognition_Mine
{
    class Program
    {
        static void Main(string[] args)
        {
            //Default data folder
            const string dataDirectoryPath = @"data";

            //Collection of audio files, fingerprint files and config file from data folder
            string[] audioFiles = null;
            string[] groundTruthAudioFingerprints = null;
            string[] configFiles = null;
            string[] matchFiles = null;

            //Read all related data from dataDirectoryPath
            string[] subDirectories = Directory.GetDirectories(dataDirectoryPath);
            foreach (string subDir in subDirectories)
            {
                if (Path.GetFileName(subDir).Equals("audio"))
                {
                    audioFiles = Directory.GetFiles(subDir);
                    foreach(string audiofile in audioFiles)
                    {
                        Console.WriteLine("files in audiodirectory : " + audiofile);
                    }
                }//End if
                else if (Path.GetFileName(subDir).Equals("groundtruth_audio_fingerprints"))
                {
                    groundTruthAudioFingerprints = Directory.GetFiles(subDir);
                }//End else if
                else if (Path.GetFileName(subDir).Equals("config"))
                {
                    configFiles = Directory.GetFiles(subDir);
                }//End else if
                else if (Path.GetFileName(subDir).Equals("match_results"))
                {
                    matchFiles = Directory.GetFiles(subDir);
                }//End else if
            }//End foreach
        }
    }
}
