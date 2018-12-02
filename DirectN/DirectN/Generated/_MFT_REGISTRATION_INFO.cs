// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(16143,9)
using System;
using System.Runtime.InteropServices;
using MFT_REGISTER_TYPE_INFO = DirectN.__MIDL___MIDL_itf_mfobjects_0000_0008_0003;

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
