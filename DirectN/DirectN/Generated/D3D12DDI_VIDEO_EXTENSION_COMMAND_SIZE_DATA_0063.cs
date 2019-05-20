// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(10128,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_EXTENSION_COMMAND_SIZE_DATA_0063
    {
        public uint NodeIndex;
        public Guid CommandId;
        public IntPtr pCreationParameters;
        public IntPtr CreationParametersSizeInBytes;
        public ulong MemoryPoolL0Size;
        public ulong MemoryPoolL1Size;
    }
}
