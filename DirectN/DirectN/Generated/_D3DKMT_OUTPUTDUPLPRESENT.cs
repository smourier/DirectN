// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(1367,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_OUTPUTDUPLPRESENT
    {
        public uint hContext;
        public uint hSource;
        public uint VidPnSourceId;
        public uint BroadcastContextCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public uint[] BroadcastContext;
        public _D3DKMT_PRESENT_RGNS PresentRegions;
        public _D3DKMT_OUTPUTDUPLPRESENTFLAGS Flags;
        public uint hIndirectContext;
    }
}
