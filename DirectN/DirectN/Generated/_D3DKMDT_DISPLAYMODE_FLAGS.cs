// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(231,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMDT_DISPLAYMODE_FLAGS
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint ValidatedAgainstMonitorCaps { get => InteropRuntime.GetUInt32(__bits, 0, 1); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt32(value, __bits, 0, 1); } }
        public uint RoundedFakeMode { get => InteropRuntime.GetUInt32(__bits, 1, 1); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt32(value, __bits, 1, 1); } }
        // a field here has no name.
        public _D3DKMDT_MODE_PRUNING_REASON ModePruningReason { get => InteropRuntime.Get<_D3DKMDT_MODE_PRUNING_REASON>(__bits, 32, 4); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<_D3DKMDT_MODE_PRUNING_REASON>(value, __bits, 32, 4); } }
        public uint Stereo { get => InteropRuntime.GetUInt32(__bits, 36, 1); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt32(value, __bits, 36, 1); } }
        public uint AdvancedScanCapable { get => InteropRuntime.GetUInt32(__bits, 37, 1); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt32(value, __bits, 37, 1); } }
        public uint PreferredTiming { get => InteropRuntime.GetUInt32(__bits, 38, 1); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt32(value, __bits, 38, 1); } }
        public uint PhysicalModeSupported { get => InteropRuntime.GetUInt32(__bits, 39, 1); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt32(value, __bits, 39, 1); } }
        public uint Reserved { get => InteropRuntime.GetUInt32(__bits, 40, 24); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt32(value, __bits, 40, 24); } }
    }
}
