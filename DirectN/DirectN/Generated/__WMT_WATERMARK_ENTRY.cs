// generated from <Windows SDK Path>\um\wmsdkidl.h
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
