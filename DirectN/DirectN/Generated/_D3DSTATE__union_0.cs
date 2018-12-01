// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dtypes.h(1548,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DSTATE__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public _D3DTRANSFORMSTATETYPE dtstTransformStateType => InteropRuntime.GetBits<_D3DTRANSFORMSTATETYPE>(__bits, 0, 32);
        public _D3DLIGHTSTATETYPE dlstLightStateType => InteropRuntime.GetBits<_D3DLIGHTSTATETYPE>(__bits, 0, 32);
        public _D3DRENDERSTATETYPE drstRenderStateType => InteropRuntime.GetBits<_D3DRENDERSTATETYPE>(__bits, 0, 32);
    }
}
