// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagDVD_MenuAttributes
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public bool[] fCompatibleRegion;
        public tagDVD_VideoAttributes VideoAttributes;
        public bool fAudioPresent;
        public tagDVD_AudioAttributes AudioAttributes;
        public bool fSubpicturePresent;
        public tagDVD_SubpictureAttributes SubpictureAttributes;
    }
}
