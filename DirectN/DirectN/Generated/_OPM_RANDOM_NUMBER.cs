// generated from <Windows SDK Path>\um\ksopmapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _OPM_RANDOM_NUMBER
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public byte[] abRandomNumber;
    }
}
