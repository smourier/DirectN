// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsdkidl.h(1577,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _WMT_WEBSTREAM_SAMPLE_HEADER
    {
        public ushort cbLength;
        public ushort wPart;
        public ushort cTotalParts;
        public ushort wSampleType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)] 
        public string wszURL;
    }
}
