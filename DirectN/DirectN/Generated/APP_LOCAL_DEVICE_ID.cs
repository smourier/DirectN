// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\windef.h(207,9)
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
