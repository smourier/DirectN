// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _WMPicture
    {
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pwszMIMEType;
        public byte bPictureType;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pwszDescription;
        public uint dwDataLen;
        public IntPtr pbData;
    }
}
