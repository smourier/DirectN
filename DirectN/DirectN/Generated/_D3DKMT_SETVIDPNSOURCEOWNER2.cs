// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_SETVIDPNSOURCEOWNER2
    {
        public _D3DKMT_SETVIDPNSOURCEOWNER1 Version1;
        public IntPtr pVidPnSourceNtHandles;
    }
}
