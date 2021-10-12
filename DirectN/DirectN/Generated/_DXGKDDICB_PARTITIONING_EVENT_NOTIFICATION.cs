// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(9375,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _DXGKDDICB_PARTITIONING_EVENT_NOTIFICATION
    {
        public IntPtr hAdapter;
        public _DXGIDDI_PARTITIONING_EVENT_TYPE EventType;
        public uint PartitionId;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 255)] 
        public string EventDescription;
        public ulong EventData1;
        public ulong EventData2;
        public ulong EventData3;
        public ulong EventData4;
        public ulong EventData5;
    }
}
