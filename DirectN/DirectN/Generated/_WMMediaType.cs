// generated from <Windows SDK Path>\um\wmsdkidl.h
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
