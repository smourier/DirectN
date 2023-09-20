// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_WAITFORSYNCHRONIZATIONOBJECT
    {
        public uint hContext;
        public uint ObjectCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public uint[] ObjectHandleArray;
    }
}
