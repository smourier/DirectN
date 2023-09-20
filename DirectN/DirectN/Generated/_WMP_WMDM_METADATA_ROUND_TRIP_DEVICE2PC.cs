// generated from <Windows SDK Path>\um\wmpdevices.h
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
