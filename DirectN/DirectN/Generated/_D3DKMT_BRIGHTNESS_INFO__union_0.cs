// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(2908,5)
using System;
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
        public _D3DKMT_BRIGHTNESS_POSSIBLE_LEVELS PossibleLevels { get => InteropRuntime.Get<_D3DKMT_BRIGHTNESS_POSSIBLE_LEVELS>(__bits, 0, 4096); set { if (__bits == null) __bits = new byte[1540]; InteropRuntime.Set<_D3DKMT_BRIGHTNESS_POSSIBLE_LEVELS>(value, __bits, 0, 4096); } }
        public byte Brightness { get => InteropRuntime.GetByte(__bits, 0, 8); set { if (__bits == null) __bits = new byte[1540]; InteropRuntime.SetByte(value, __bits, 0, 8); } }
        public _DXGK_BRIGHTNESS_CAPS BrightnessCaps { get => InteropRuntime.Get<_DXGK_BRIGHTNESS_CAPS>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[1540]; InteropRuntime.Set<_DXGK_BRIGHTNESS_CAPS>(value, __bits, 0, 32); } }
        public _DXGK_BRIGHTNESS_STATE BrightnessState { get => InteropRuntime.Get<_DXGK_BRIGHTNESS_STATE>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[1540]; InteropRuntime.Set<_DXGK_BRIGHTNESS_STATE>(value, __bits, 0, 32); } }
        public DXGK_BACKLIGHT_OPTIMIZATION_LEVEL OptimizationLevel { get => InteropRuntime.Get<DXGK_BACKLIGHT_OPTIMIZATION_LEVEL>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[1540]; InteropRuntime.Set<DXGK_BACKLIGHT_OPTIMIZATION_LEVEL>(value, __bits, 0, 32); } }
        public _DXGK_BACKLIGHT_INFO ReductionInfo { get => InteropRuntime.Get<_DXGK_BACKLIGHT_INFO>(__bits, 0, 12320); set { if (__bits == null) __bits = new byte[1540]; InteropRuntime.Set<_DXGK_BACKLIGHT_INFO>(value, __bits, 0, 12320); } }
        public byte VerboseLogging { get => InteropRuntime.GetByte(__bits, 0, 8); set { if (__bits == null) __bits = new byte[1540]; InteropRuntime.SetByte(value, __bits, 0, 8); } }
        public _DXGK_BRIGHTNESS_GET_NIT_RANGES_OUT NitRanges { get => InteropRuntime.Get<_DXGK_BRIGHTNESS_GET_NIT_RANGES_OUT>(__bits, 0, 192); set { if (__bits == null) __bits = new byte[1540]; InteropRuntime.Set<_DXGK_BRIGHTNESS_GET_NIT_RANGES_OUT>(value, __bits, 0, 192); } }
        public _DXGK_BRIGHTNESS_GET_OUT GetBrightnessMillinits { get => InteropRuntime.Get<_DXGK_BRIGHTNESS_GET_OUT>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[1540]; InteropRuntime.Set<_DXGK_BRIGHTNESS_GET_OUT>(value, __bits, 0, 64); } }
        public _DXGK_BRIGHTNESS_SET_IN SetBrightnessMillinits { get => InteropRuntime.Get<_DXGK_BRIGHTNESS_SET_IN>(__bits, 0, 256); set { if (__bits == null) __bits = new byte[1540]; InteropRuntime.Set<_DXGK_BRIGHTNESS_SET_IN>(value, __bits, 0, 256); } }
    }
}
