// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(661,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_PRESENTHISTORYTOKEN__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 576)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DKMT_FLIPMODEL_PRESENTHISTORYTOKEN Flip { get => InteropRuntime.Get<_D3DKMT_FLIPMODEL_PRESENTHISTORYTOKEN>(__bits, 0, 4608); set { if (__bits == null) __bits = new byte[576]; InteropRuntime.Set<_D3DKMT_FLIPMODEL_PRESENTHISTORYTOKEN>(value, __bits, 0, 4608); } }
        public _D3DKMT_BLTMODEL_PRESENTHISTORYTOKEN Blt { get => InteropRuntime.Get<_D3DKMT_BLTMODEL_PRESENTHISTORYTOKEN>(__bits, 0, 448); set { if (__bits == null) __bits = new byte[576]; InteropRuntime.Set<_D3DKMT_BLTMODEL_PRESENTHISTORYTOKEN>(value, __bits, 0, 448); } }
        public ulong VistaBlt { get => InteropRuntime.GetUInt64(__bits, 0, 64); set { if (__bits == null) __bits = new byte[576]; InteropRuntime.SetUInt64(value, __bits, 0, 64); } }
        public _D3DKMT_GDIMODEL_PRESENTHISTORYTOKEN Gdi { get => InteropRuntime.Get<_D3DKMT_GDIMODEL_PRESENTHISTORYTOKEN>(__bits, 0, 576); set { if (__bits == null) __bits = new byte[576]; InteropRuntime.Set<_D3DKMT_GDIMODEL_PRESENTHISTORYTOKEN>(value, __bits, 0, 576); } }
        public _D3DKMT_FENCE_PRESENTHISTORYTOKEN Fence { get => InteropRuntime.Get<_D3DKMT_FENCE_PRESENTHISTORYTOKEN>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[576]; InteropRuntime.Set<_D3DKMT_FENCE_PRESENTHISTORYTOKEN>(value, __bits, 0, 64); } }
        public _D3DKMT_GDIMODEL_SYSMEM_PRESENTHISTORYTOKEN GdiSysMem { get => InteropRuntime.Get<_D3DKMT_GDIMODEL_SYSMEM_PRESENTHISTORYTOKEN>(__bits, 0, 192); set { if (__bits == null) __bits = new byte[576]; InteropRuntime.Set<_D3DKMT_GDIMODEL_SYSMEM_PRESENTHISTORYTOKEN>(value, __bits, 0, 192); } }
        public _D3DKMT_COMPOSITION_PRESENTHISTORYTOKEN Composition { get => InteropRuntime.Get<_D3DKMT_COMPOSITION_PRESENTHISTORYTOKEN>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[576]; InteropRuntime.Set<_D3DKMT_COMPOSITION_PRESENTHISTORYTOKEN>(value, __bits, 0, 64); } }
        public _D3DKMT_FLIPMANAGER_PRESENTHISTORYTOKEN FlipManager { get => InteropRuntime.Get<_D3DKMT_FLIPMANAGER_PRESENTHISTORYTOKEN>(__bits, 0, 160); set { if (__bits == null) __bits = new byte[576]; InteropRuntime.Set<_D3DKMT_FLIPMANAGER_PRESENTHISTORYTOKEN>(value, __bits, 0, 160); } }
        public _D3DKMT_SURFACECOMPLETE_PRESENTHISTORYTOKEN SurfaceComplete { get => InteropRuntime.Get<_D3DKMT_SURFACECOMPLETE_PRESENTHISTORYTOKEN>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[576]; InteropRuntime.Set<_D3DKMT_SURFACECOMPLETE_PRESENTHISTORYTOKEN>(value, __bits, 0, 64); } }
    }
}
