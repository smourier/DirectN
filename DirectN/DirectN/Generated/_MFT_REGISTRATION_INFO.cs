// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFT_REGISTRATION_INFO
    {
        public Guid clsid;
        public Guid guidCategory;
        public uint uiFlags;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pszName;
        public uint cInTypes;
        public IntPtr pInTypes;
        public uint cOutTypes;
        public IntPtr pOutTypes;
    }
}
