// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_SUBMITWAITFORSYNCOBJECTSTOHWQUEUE
    {
        public uint hHwQueue;
        public uint ObjectCount;
        public IntPtr ObjectHandleArray;
        public IntPtr FenceValueArray;
    }
}
