// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsdkidl.h(1596,9)
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
