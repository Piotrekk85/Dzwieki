﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication2
{
       
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"applause_y.wav");
            simpleSound.PlayLooping();
        }

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            playSimpleSound();
            Application.Run(new Form1());
        }
    }
}
