// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _WMSynchronisedLyrics
    {
        public byte bTimeStampFormat;
        public byte bContentType;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pwszContentDescriptor;
        public uint dwLyricsLen;
        public IntPtr pbLyrics;
    }
}
