// generated from <Windows SDK Path>\shared\windef.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct APP_LOCAL_DEVICE_ID
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public byte[] value;
    }
}
