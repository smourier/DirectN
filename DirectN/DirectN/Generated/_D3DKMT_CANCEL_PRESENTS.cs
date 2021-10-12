// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(767,9)
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
