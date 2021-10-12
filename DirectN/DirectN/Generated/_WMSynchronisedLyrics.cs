// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsdkidl.h(1605,9)
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
