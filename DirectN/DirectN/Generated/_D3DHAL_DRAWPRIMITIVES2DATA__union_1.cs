// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dhal.h(1645,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_DRAWPRIMITIVES2DATA__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint dwVertexSize { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
        public HRESULT ddrval { get => InteropRuntime.Get<HRESULT>(__bits, 0, 0); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<HRESULT>(value, __bits, 0, 0); } }
    }
}
