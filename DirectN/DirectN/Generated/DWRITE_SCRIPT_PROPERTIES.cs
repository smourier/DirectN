// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_1.h(836,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_SCRIPT_PROPERTIES
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        public byte[] __bits;
        public uint isoScriptCode => InteropRuntime.GetUInt32Bits(__bits, 0, 32);
        public uint isoScriptNumber => InteropRuntime.GetUInt32Bits(__bits, 32, 32);
        public uint clusterLookahead => InteropRuntime.GetUInt32Bits(__bits, 64, 32);
        public uint justificationCharacter => InteropRuntime.GetUInt32Bits(__bits, 96, 32);
        public uint restrictCaretToClusters => InteropRuntime.GetUInt32Bits(__bits, 128, 1);
        public uint usesWordDividers => InteropRuntime.GetUInt32Bits(__bits, 129, 1);
        public uint isDiscreteWriting => InteropRuntime.GetUInt32Bits(__bits, 130, 1);
        public uint isBlockWriting => InteropRuntime.GetUInt32Bits(__bits, 131, 1);
        public uint isDistributedWithinCluster => InteropRuntime.GetUInt32Bits(__bits, 132, 1);
        public uint isConnectedWriting => InteropRuntime.GetUInt32Bits(__bits, 133, 1);
        public uint isCursiveWriting => InteropRuntime.GetUInt32Bits(__bits, 134, 1);
        public uint reserved => InteropRuntime.GetUInt32Bits(__bits, 135, 25);
    }
}
