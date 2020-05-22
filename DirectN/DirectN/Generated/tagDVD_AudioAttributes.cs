// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(21119,9)
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
