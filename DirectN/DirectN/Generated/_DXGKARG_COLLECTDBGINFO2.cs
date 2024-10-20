// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_COLLECTDBGINFO2
    {
        public uint Reason;
        public IntPtr pBuffer;
        public IntPtr BufferSize;
        public IntPtr pExtension;
        public _DXGK_TDR_TYPE TdrType;
        public uint TdrPayloadSize;
        public IntPtr TdrPayload;
    }
}
