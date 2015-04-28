using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


///<summary>
/// Using different Api's or Libraries for recording
/// </summary>


#region Using CS core Library
/// <summary>
/// CS core is a free .Net Library for recording in mp3, wav....
/// </summary>
using CSCore;
#endregion

#region Using Bonsai Library
/// <summary>
/// Using Bonasi Library for audio recording 
/// </summary>
/// I am not able to all bonsai.dll
#endregion


namespace VoiceRecognition
{
    public partial class Practise : Form
    {
        public Practise()
        {
            InitializeComponent();
        }
    }
}


