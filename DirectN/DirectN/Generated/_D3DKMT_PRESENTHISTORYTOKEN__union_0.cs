// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_PRESENTHISTORYTOKEN__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1064)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DKMT_FLIPMODEL_PRESENTHISTORYTOKEN Flip {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DKMT_FLIPMODEL_PRESENTHISTORYTOKEN>(__bits, 0, 8512);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1064]; InteropRuntime.Set<_D3DKMT_FLIPMODEL_PRESENTHISTORYTOKEN>(value, __bits, 0, 8512); } }
        public _D3DKMT_BLTMODEL_PRESENTHISTORYTOKEN Blt {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DKMT_BLTMODEL_PRESENTHISTORYTOKEN>(__bits, 0, 2304);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1064]; InteropRuntime.Set<_D3DKMT_BLTMODEL_PRESENTHISTORYTOKEN>(value, __bits, 0, 2304); } }
        public ulong VistaBlt {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt64(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1064]; InteropRuntime.SetUInt64(value, __bits, 0, 64); } }
        public _D3DKMT_GDIMODEL_PRESENTHISTORYTOKEN Gdi {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DKMT_GDIMODEL_PRESENTHISTORYTOKEN>(__bits, 0, 2432);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1064]; InteropRuntime.Set<_D3DKMT_GDIMODEL_PRESENTHISTORYTOKEN>(value, __bits, 0, 2432); } }
        public _D3DKMT_FENCE_PRESENTHISTORYTOKEN Fence {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DKMT_FENCE_PRESENTHISTORYTOKEN>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1064]; InteropRuntime.Set<_D3DKMT_FENCE_PRESENTHISTORYTOKEN>(value, __bits, 0, 64); } }
        public _D3DKMT_GDIMODEL_SYSMEM_PRESENTHISTORYTOKEN GdiSysMem {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DKMT_GDIMODEL_SYSMEM_PRESENTHISTORYTOKEN>(__bits, 0, 192);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1064]; InteropRuntime.Set<_D3DKMT_GDIMODEL_SYSMEM_PRESENTHISTORYTOKEN>(value, __bits, 0, 192); } }
        public _D3DKMT_COMPOSITION_PRESENTHISTORYTOKEN Composition {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DKMT_COMPOSITION_PRESENTHISTORYTOKEN>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1064]; InteropRuntime.Set<_D3DKMT_COMPOSITION_PRESENTHISTORYTOKEN>(value, __bits, 0, 64); } }
        public _D3DKMT_FLIPMANAGER_PRESENTHISTORYTOKEN FlipManager {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DKMT_FLIPMANAGER_PRESENTHISTORYTOKEN>(__bits, 0, 192);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1064]; InteropRuntime.Set<_D3DKMT_FLIPMANAGER_PRESENTHISTORYTOKEN>(value, __bits, 0, 192); } }
        public _D3DKMT_SURFACECOMPLETE_PRESENTHISTORYTOKEN SurfaceComplete {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DKMT_SURFACECOMPLETE_PRESENTHISTORYTOKEN>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1064]; InteropRuntime.Set<_D3DKMT_SURFACECOMPLETE_PRESENTHISTORYTOKEN>(value, __bits, 0, 64); } }
    }
}
