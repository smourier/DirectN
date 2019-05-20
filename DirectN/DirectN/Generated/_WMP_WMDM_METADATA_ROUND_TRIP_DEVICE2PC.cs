// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmpdevices.h(65,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
    public partial struct _WMP_WMDM_METADATA_ROUND_TRIP_DEVICE2PC
    {
        public uint dwCurrentTransactionID;
        public uint dwReturnedObjectCount;
        public uint dwUnretrievedObjectCount;
        public uint dwDeletedObjectStartingOffset;
        public uint dwFlags;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)] 
        public string wsObjectPathnameList;
    }
}
