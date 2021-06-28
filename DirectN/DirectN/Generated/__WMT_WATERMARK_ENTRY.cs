// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmsdkidl.h(1632,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct __WMT_WATERMARK_ENTRY
    {
        public tagWMT_WATERMARK_ENTRY_TYPE wmetType;
        public Guid clsid;
        public uint cbDisplayName;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pwszDisplayName;
    }
}
