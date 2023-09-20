// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagDVD_AudioAttributes
    {
        public tagDVD_AUDIO_APPMODE AppMode;
        public byte AppModeData;
        public tagDVD_AUDIO_FORMAT AudioFormat;
        public uint Language;
        public tagDVD_AUDIO_LANG_EXT LanguageExtension;
        public bool fHasMultichannelInfo;
        public uint dwFrequency;
        public byte bQuantization;
        public byte bNumberOfChannels;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public uint[] dwReserved;
    }
}
