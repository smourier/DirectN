// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dtypes.h(1548,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DSTATE__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DTRANSFORMSTATETYPE dtstTransformStateType { get => InteropRuntime.Get<_D3DTRANSFORMSTATETYPE>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_D3DTRANSFORMSTATETYPE>(value, __bits, 0, 32); } }
        public _D3DLIGHTSTATETYPE dlstLightStateType { get => InteropRuntime.Get<_D3DLIGHTSTATETYPE>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_D3DLIGHTSTATETYPE>(value, __bits, 0, 32); } }
        public _D3DRENDERSTATETYPE drstRenderStateType { get => InteropRuntime.Get<_D3DRENDERSTATETYPE>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_D3DRENDERSTATETYPE>(value, __bits, 0, 32); } }
    }
}
