// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;
using LUID = DirectN._LUID;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_CANCEL_PRESENTS
    {
        public uint cbSize;
        public uint hDevice;
        public _D3DKMT_CANCEL_PRESENTS_FLAGS Flags;
        public D3DKMT_CANCEL_PRESENTS_OPERATION Operation;
        public ulong CancelFromPresentId;
        public LUID CompSurfaceLuid;
        public ulong BindId;
    }
}
