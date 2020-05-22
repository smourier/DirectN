// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(16291,9)
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
