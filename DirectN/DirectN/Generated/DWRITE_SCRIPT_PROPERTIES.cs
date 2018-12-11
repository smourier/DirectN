// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_1.h(836,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_SCRIPT_PROPERTIES
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint isoScriptCode { get => InteropRuntime.GetUInt32(__bits, 0, 32); set => InteropRuntime.SetUInt32(value, __bits, 0, 32); }
        public uint isoScriptNumber { get => InteropRuntime.GetUInt32(__bits, 32, 32); set => InteropRuntime.SetUInt32(value, __bits, 32, 32); }
        public uint clusterLookahead { get => InteropRuntime.GetUInt32(__bits, 64, 32); set => InteropRuntime.SetUInt32(value, __bits, 64, 32); }
        public uint justificationCharacter { get => InteropRuntime.GetUInt32(__bits, 96, 32); set => InteropRuntime.SetUInt32(value, __bits, 96, 32); }
        public uint restrictCaretToClusters { get => InteropRuntime.GetUInt32(__bits, 128, 1); set => InteropRuntime.SetUInt32(value, __bits, 128, 1); }
        public uint usesWordDividers { get => InteropRuntime.GetUInt32(__bits, 129, 1); set => InteropRuntime.SetUInt32(value, __bits, 129, 1); }
        public uint isDiscreteWriting { get => InteropRuntime.GetUInt32(__bits, 130, 1); set => InteropRuntime.SetUInt32(value, __bits, 130, 1); }
        public uint isBlockWriting { get => InteropRuntime.GetUInt32(__bits, 131, 1); set => InteropRuntime.SetUInt32(value, __bits, 131, 1); }
        public uint isDistributedWithinCluster { get => InteropRuntime.GetUInt32(__bits, 132, 1); set => InteropRuntime.SetUInt32(value, __bits, 132, 1); }
        public uint isConnectedWriting { get => InteropRuntime.GetUInt32(__bits, 133, 1); set => InteropRuntime.SetUInt32(value, __bits, 133, 1); }
        public uint isCursiveWriting { get => InteropRuntime.GetUInt32(__bits, 134, 1); set => InteropRuntime.SetUInt32(value, __bits, 134, 1); }
        public uint reserved { get => InteropRuntime.GetUInt32(__bits, 135, 25); set => InteropRuntime.SetUInt32(value, __bits, 135, 25); }
    }
}
