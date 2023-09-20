// generated from <Windows SDK Path>\um\strmif.h
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
