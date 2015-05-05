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
                    foreach (string audiofile in audioFiles)
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

            //Evaluate system object initialization
            Evaluate evaluate = new Evaluate();
            //EvaluteSystem function call will return false[test failed] or true[test successful]
            if (evaluate.EvaluateSystem(audioFiles, groundTruthAudioFingerprints, configFiles, matchFiles))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\n [TEST SUCCESSFULLY COMPLETE] \n\n");
            }//End if
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n [TEST FAILED] \n\n");
            }//End else

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}