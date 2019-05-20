// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\strmif.h(21260,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagDVD_TitleMainAttributes
    {
        public tagDVD_TitleMainAttributes__union_0 __union_0;
        public tagDVD_VideoAttributes VideoAttributes;
        public uint ulNumberOfAudioStreams;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public tagDVD_AudioAttributes[] AudioAttributes;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public tagDVD_MultichannelAudioAttributes[] MultichannelAudioAttributes;
        public uint ulNumberOfSubpictureStreams;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public tagDVD_SubpictureAttributes[] SubpictureAttributes;
    }
}
