// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d10_1shader.h(65,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D10_SHADER_DEBUG_TOKEN_INFO
    {
        public uint File;
        public uint Line;
        public uint Column;
        public uint TokenLength;
        public uint TokenId;
    }
}
