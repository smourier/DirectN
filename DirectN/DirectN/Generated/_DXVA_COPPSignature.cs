// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_COPPSignature
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)] 
        public byte[] Signature;
    }
}
