// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(1635,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_PRESENTATIONCAPS__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint NoScreenToScreenBlt { get => InteropRuntime.GetUInt32(__bits, 0, 1); set => InteropRuntime.SetUInt32(value, __bits, 0, 1); }
        public uint NoOverlapScreenBlt { get => InteropRuntime.GetUInt32(__bits, 1, 1); set => InteropRuntime.SetUInt32(value, __bits, 1, 1); }
        public uint SupportKernelModeCommandBuffer { get => InteropRuntime.GetUInt32(__bits, 2, 1); set => InteropRuntime.SetUInt32(value, __bits, 2, 1); }
        public uint NoSameBitmapAlphaBlend { get => InteropRuntime.GetUInt32(__bits, 3, 1); set => InteropRuntime.SetUInt32(value, __bits, 3, 1); }
        public uint NoSameBitmapStretchBlt { get => InteropRuntime.GetUInt32(__bits, 4, 1); set => InteropRuntime.SetUInt32(value, __bits, 4, 1); }
        public uint NoSameBitmapTransparentBlt { get => InteropRuntime.GetUInt32(__bits, 5, 1); set => InteropRuntime.SetUInt32(value, __bits, 5, 1); }
        public uint NoSameBitmapOverlappedAlphaBlend { get => InteropRuntime.GetUInt32(__bits, 6, 1); set => InteropRuntime.SetUInt32(value, __bits, 6, 1); }
        public uint NoSameBitmapOverlappedStretchBlt { get => InteropRuntime.GetUInt32(__bits, 7, 1); set => InteropRuntime.SetUInt32(value, __bits, 7, 1); }
        public uint DriverSupportsCddDwmInterop { get => InteropRuntime.GetUInt32(__bits, 8, 1); set => InteropRuntime.SetUInt32(value, __bits, 8, 1); }
        public uint Reserved0 { get => InteropRuntime.GetUInt32(__bits, 9, 1); set => InteropRuntime.SetUInt32(value, __bits, 9, 1); }
        public uint AlignmentShift { get => InteropRuntime.GetUInt32(__bits, 10, 4); set => InteropRuntime.SetUInt32(value, __bits, 10, 4); }
        public uint MaxTextureWidthShift { get => InteropRuntime.GetUInt32(__bits, 14, 3); set => InteropRuntime.SetUInt32(value, __bits, 14, 3); }
        public uint MaxTextureHeightShift { get => InteropRuntime.GetUInt32(__bits, 17, 3); set => InteropRuntime.SetUInt32(value, __bits, 17, 3); }
        public uint SupportAllBltRops { get => InteropRuntime.GetUInt32(__bits, 20, 1); set => InteropRuntime.SetUInt32(value, __bits, 20, 1); }
        public uint SupportMirrorStretchBlt { get => InteropRuntime.GetUInt32(__bits, 21, 1); set => InteropRuntime.SetUInt32(value, __bits, 21, 1); }
        public uint SupportMonoStretchBltModes { get => InteropRuntime.GetUInt32(__bits, 22, 1); set => InteropRuntime.SetUInt32(value, __bits, 22, 1); }
        public uint StagingRectStartPitchAligned { get => InteropRuntime.GetUInt32(__bits, 23, 1); set => InteropRuntime.SetUInt32(value, __bits, 23, 1); }
        public uint NoSameBitmapBitBlt { get => InteropRuntime.GetUInt32(__bits, 24, 1); set => InteropRuntime.SetUInt32(value, __bits, 24, 1); }
        public uint NoSameBitmapOverlappedBitBlt { get => InteropRuntime.GetUInt32(__bits, 25, 1); set => InteropRuntime.SetUInt32(value, __bits, 25, 1); }
        public uint Reserved1 { get => InteropRuntime.GetUInt32(__bits, 26, 1); set => InteropRuntime.SetUInt32(value, __bits, 26, 1); }
        public uint NoTempSurfaceForClearTypeBlend { get => InteropRuntime.GetUInt32(__bits, 27, 1); set => InteropRuntime.SetUInt32(value, __bits, 27, 1); }
        public uint SupportSoftwareDeviceBitmaps { get => InteropRuntime.GetUInt32(__bits, 28, 1); set => InteropRuntime.SetUInt32(value, __bits, 28, 1); }
        public uint NoCacheCoherentApertureMemory { get => InteropRuntime.GetUInt32(__bits, 29, 1); set => InteropRuntime.SetUInt32(value, __bits, 29, 1); }
        public uint SupportLinearHeap { get => InteropRuntime.GetUInt32(__bits, 30, 1); set => InteropRuntime.SetUInt32(value, __bits, 30, 1); }
        public uint Reserved { get => InteropRuntime.GetUInt32(__bits, 31, 1); set => InteropRuntime.SetUInt32(value, __bits, 31, 1); }
    }
}
