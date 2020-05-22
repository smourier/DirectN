// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(21278,9)
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
