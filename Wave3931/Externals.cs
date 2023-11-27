﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Wave3931
{
    public class Externals
    {
        [DllImport("WaveDLL.dll")]
        public static extern void InitializeAudio(uint SampleRate, int channels);
        [DllImport("WaveDLL.dll")]
        public static extern void SetPBuffer(IntPtr pb);
        [DllImport("WaveDLL.dll")]
        public static extern int GetDataLength();
        [DllImport("WaveDLL.dll")]
        public static extern IntPtr GetPBuffer();
        [DllImport("WaveDLL.dll")]
        public static extern void CleanupAudio();
        [DllImport("WaveDLL.dll")]
        public static extern void StartRecording(IntPtr hwnd);
        [DllImport("WaveDLL.dll")]
        public static extern void StopRecording();
        [DllImport("WaveDLL.dll")]
        public static extern void StartPlaying();
        [DllImport("WaveDLL.dll")]
        public static extern void Init();
        [DllImport("WaveDLL.dll")]
        public static extern void StopPlaying();
        [DllImport("WaveDLL.dll")]
        public static extern void PausePlaying();
        [DllImport("WaveDLL.dll")]
        public static extern void Box(IntPtr hwnd);
        [DllImport("WaveDLL.dll")]
        public static extern void SetPSaveBuffer(IntPtr ps);
        [DllImport("WaveDLL.dll")]
        public static extern void SetDWDataLength(uint dl);
        [DllImport("WaveDLL.dll")]
        public static extern void UpdatePSaveBuffer(IntPtr ps, int dl);

        [DllImport("WaveDLL.dll")]
        public static extern IntPtr GetWaveHdrLPData();
        [DllImport("WaveDLL.dll")]
        public static extern int GetWaveHdrBUFLEN();
        [DllImport("WaveDLL.dll")]
        public static extern void SetWaveHdr(IntPtr lpData, int dwBufferLength, uint dwBytesRecorded, uint dwUser, uint dwFlags, uint dwLoops, uint reserved);
        [DllImport("WaveDLL.dll")]
        public static extern void SetWaveformData(int wFormatTag, uint nChannels, uint nSamplesPerSec, uint nAvgBytesPerSec, uint nBlockAlign, uint wBitsPerSample, uint cbSize);

        [DllImport("WaveDLL.dll")]
        public static extern ushort GET_wFormatTag();

        [DllImport("WaveDLL.dll")]
        public static extern ushort GET_nChannels();

        [DllImport("WaveDLL.dll")]
        public static extern uint GET_nSamplesPerSec();

        [DllImport("WaveDLL.dll")]
        public static extern uint GET_nAvgBytesPerSec();

        [DllImport("WaveDLL.dll")]
        public static extern uint GET_nBlockAlign();

        [DllImport("WaveDLL.dll")]
        public static extern ushort GET_wBitsPerSample();

        [DllImport("WaveDLL.dll")]
        public static extern uint GET_cbSize();
        [DllImport("WaveDLL.dll")]
        public static extern int GetSampleRate();
        [DllImport("WaveDLL.dll")]
        public static extern int SetSampleRate(uint sr);
        [DllImport("WaveDLL.dll")]

        public static extern int SetChannels(uint sr);
        [DllImport("WaveDLL.dll")]
        public static extern void UpdatePSaveBufferStereo(IntPtr leftChannelData, IntPtr rightChannelData, int leftChannelDataLength,
                                                int rightChannelDataLength);
        [DllImport("WaveDLL.dll")]
        public static extern void SetBlockAlign(uint ba);

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("WaveASMDLLFR.dll")]
        public static extern void convolveInASM(int N, int WN, double[] convolutionData, double[] audioData, double[] newSignal);

    }
}