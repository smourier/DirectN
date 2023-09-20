// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_COPPStatusOutput
    {
        public Guid macKDI;
        public uint cbSizeData;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4076)] 
        public byte[] COPPStatus;
    }
}
