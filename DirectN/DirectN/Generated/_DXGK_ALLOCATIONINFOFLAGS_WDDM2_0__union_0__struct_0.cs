// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_ALLOCATIONINFOFLAGS_WDDM2_0__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint CpuVisible { get => InteropRuntime.GetUInt32(__bits, 0, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 0, 1); } }
        public uint PermanentSysMem { get => InteropRuntime.GetUInt32(__bits, 1, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 1, 1); } }
        public uint Cached { get => InteropRuntime.GetUInt32(__bits, 2, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 2, 1); } }
        public uint Protected { get => InteropRuntime.GetUInt32(__bits, 3, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 3, 1); } }
        public uint ExistingSysMem { get => InteropRuntime.GetUInt32(__bits, 4, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 4, 1); } }
        public uint ExistingKernelSysMem { get => InteropRuntime.GetUInt32(__bits, 5, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 5, 1); } }
        public uint FromEndOfSegment { get => InteropRuntime.GetUInt32(__bits, 6, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 6, 1); } }
        public uint DisableLargePageMapping { get => InteropRuntime.GetUInt32(__bits, 7, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 7, 1); } }
        public uint Overlay { get => InteropRuntime.GetUInt32(__bits, 8, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 8, 1); } }
        public uint Capture { get => InteropRuntime.GetUInt32(__bits, 9, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 9, 1); } }
        public uint CreateInVpr { get => InteropRuntime.GetUInt32(__bits, 10, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 10, 1); } }
        public uint DXGK_ALLOC_RESERVED17 { get => InteropRuntime.GetUInt32(__bits, 11, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 11, 1); } }
        public uint Reserved02 { get => InteropRuntime.GetUInt32(__bits, 12, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 12, 1); } }
        public uint MapApertureCpuVisible { get => InteropRuntime.GetUInt32(__bits, 13, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 13, 1); } }
        public uint HistoryBuffer { get => InteropRuntime.GetUInt32(__bits, 14, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 14, 1); } }
        public uint AccessedPhysically { get => InteropRuntime.GetUInt32(__bits, 15, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 15, 1); } }
        public uint ExplicitResidencyNotification { get => InteropRuntime.GetUInt32(__bits, 16, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 16, 1); } }
        public uint HardwareProtected { get => InteropRuntime.GetUInt32(__bits, 17, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 17, 1); } }
        public uint CpuVisibleOnDemand { get => InteropRuntime.GetUInt32(__bits, 18, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 18, 1); } }
        public uint DXGK_ALLOC_RESERVED16 { get => InteropRuntime.GetUInt32(__bits, 19, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 19, 1); } }
        public uint Reserved15 { get => InteropRuntime.GetUInt32(__bits, 20, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 20, 1); } }
        public uint Reserved14 { get => InteropRuntime.GetUInt32(__bits, 21, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 21, 1); } }
        public uint Reserved13 { get => InteropRuntime.GetUInt32(__bits, 22, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 22, 1); } }
        public uint Reserved12 { get => InteropRuntime.GetUInt32(__bits, 23, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 23, 1); } }
        public uint Reserved11 { get => InteropRuntime.GetUInt32(__bits, 24, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 24, 1); } }
        public uint Reserved10 { get => InteropRuntime.GetUInt32(__bits, 25, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 25, 1); } }
        public uint Reserved9 { get => InteropRuntime.GetUInt32(__bits, 26, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 26, 1); } }
        public uint Reserved4 { get => InteropRuntime.GetUInt32(__bits, 27, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 27, 1); } }
        public uint Reserved3 { get => InteropRuntime.GetUInt32(__bits, 28, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 28, 1); } }
        public uint Reserved2 { get => InteropRuntime.GetUInt32(__bits, 29, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 29, 1); } }
        public uint Reserved1 { get => InteropRuntime.GetUInt32(__bits, 30, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 30, 1); } }
        public uint Reserved0 { get => InteropRuntime.GetUInt32(__bits, 31, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 31, 1); } }
    }
}
