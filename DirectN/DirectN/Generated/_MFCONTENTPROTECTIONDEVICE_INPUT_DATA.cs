// generated from <Windows SDK Path>\um\mfidl.h
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
