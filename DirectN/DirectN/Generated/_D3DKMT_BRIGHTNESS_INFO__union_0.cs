// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DXGK_BACKLIGHT_OPTIMIZATION_LEVEL = DirectN.DxgkBacklightOptimization;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_BRIGHTNESS_INFO__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1540)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DKMT_BRIGHTNESS_POSSIBLE_LEVELS PossibleLevels {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DKMT_BRIGHTNESS_POSSIBLE_LEVELS>(__bits, 0, 2056);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1540]; InteropRuntime.Set<_D3DKMT_BRIGHTNESS_POSSIBLE_LEVELS>(value, __bits, 0, 2056); } }
        public byte Brightness {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetByte(__bits, 0, 8);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1540]; InteropRuntime.SetByte(value, __bits, 0, 8); } }
        public _DXGK_BRIGHTNESS_CAPS BrightnessCaps {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGK_BRIGHTNESS_CAPS>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1540]; InteropRuntime.Set<_DXGK_BRIGHTNESS_CAPS>(value, __bits, 0, 32); } }
        public _DXGK_BRIGHTNESS_STATE BrightnessState {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGK_BRIGHTNESS_STATE>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1540]; InteropRuntime.Set<_DXGK_BRIGHTNESS_STATE>(value, __bits, 0, 32); } }
        public DXGK_BACKLIGHT_OPTIMIZATION_LEVEL OptimizationLevel {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<DXGK_BACKLIGHT_OPTIMIZATION_LEVEL>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1540]; InteropRuntime.Set<DXGK_BACKLIGHT_OPTIMIZATION_LEVEL>(value, __bits, 0, 32); } }
        public _DXGK_BACKLIGHT_INFO ReductionInfo {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGK_BACKLIGHT_INFO>(__bits, 0, 12320);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1540]; InteropRuntime.Set<_DXGK_BACKLIGHT_INFO>(value, __bits, 0, 12320); } }
        public byte VerboseLogging {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetByte(__bits, 0, 8);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1540]; InteropRuntime.SetByte(value, __bits, 0, 8); } }
        public _DXGK_BRIGHTNESS_GET_NIT_RANGES_OUT NitRanges {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGK_BRIGHTNESS_GET_NIT_RANGES_OUT>(__bits, 0, 1632);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1540]; InteropRuntime.Set<_DXGK_BRIGHTNESS_GET_NIT_RANGES_OUT>(value, __bits, 0, 1632); } }
        public _DXGK_BRIGHTNESS_GET_OUT GetBrightnessMillinits {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGK_BRIGHTNESS_GET_OUT>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1540]; InteropRuntime.Set<_DXGK_BRIGHTNESS_GET_OUT>(value, __bits, 0, 64); } }
        public _DXGK_BRIGHTNESS_SET_IN SetBrightnessMillinits {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGK_BRIGHTNESS_SET_IN>(__bits, 0, 256);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1540]; InteropRuntime.Set<_DXGK_BRIGHTNESS_SET_IN>(value, __bits, 0, 256); } }
        public _D3DKMT_BRIGHTNESS_INTERFACE_VERSION BrightnessInterfaceSupported {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DKMT_BRIGHTNESS_INTERFACE_VERSION>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1540]; InteropRuntime.Set<_D3DKMT_BRIGHTNESS_INTERFACE_VERSION>(value, __bits, 0, 32); } }
    }
}
