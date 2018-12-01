// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(17166,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFCONTENTPROTECTIONDEVICE_INPUT_DATA
    {
        public uint HWProtectionFunctionID;
        public uint PrivateDataByteCount;
        public uint HWProtectionDataByteCount;
        public uint Reserved;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public byte[] InputData;
    }
}
