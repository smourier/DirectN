// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12video.h(3738,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SIZE
    {
        public uint NodeIndex;
        public Guid CommandId;
        public IntPtr pCreationParameters;
        public IntPtr CreationParametersSizeInBytes;
        public ulong MemoryPoolL0Size;
        public ulong MemoryPoolL1Size;
    }
}
