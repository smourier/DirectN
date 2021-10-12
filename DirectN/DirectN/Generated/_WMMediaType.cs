// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsdkidl.h(1732,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _WMMediaType
    {
        public Guid majortype;
        public Guid subtype;
        public bool bFixedSizeSamples;
        public bool bTemporalCompression;
        public uint lSampleSize;
        public Guid formattype;
        [MarshalAs(UnmanagedType.IUnknown)] 
        public object pUnk;
        public uint cbFormat;
        public IntPtr pbFormat;
    }
}
