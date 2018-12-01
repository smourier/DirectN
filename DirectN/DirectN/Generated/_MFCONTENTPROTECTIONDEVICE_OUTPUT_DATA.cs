// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(17175,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFCONTENTPROTECTIONDEVICE_OUTPUT_DATA
    {
        public uint PrivateDataByteCount;
        public uint MaxHWProtectionDataByteCount;
        public uint HWProtectionDataByteCount;
        public HRESULT Status;
        public long TransportTimeInHundredsOfNanoseconds;
        public long ExecutionTimeInHundredsOfNanoseconds;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public byte OutputData;
    }
}
