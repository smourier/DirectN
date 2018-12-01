// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(1059,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_RESOURCEFLAGS__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint RenderTarget => InteropRuntime.GetUInt32Bits(__bits, 0, 1);
        public uint ZBuffer => InteropRuntime.GetUInt32Bits(__bits, 1, 1);
        public uint Dynamic => InteropRuntime.GetUInt32Bits(__bits, 2, 1);
        public uint HintStatic => InteropRuntime.GetUInt32Bits(__bits, 3, 1);
        public uint AutogenMipmap => InteropRuntime.GetUInt32Bits(__bits, 4, 1);
        public uint DMap => InteropRuntime.GetUInt32Bits(__bits, 5, 1);
        public uint WriteOnly => InteropRuntime.GetUInt32Bits(__bits, 6, 1);
        public uint NotLockable => InteropRuntime.GetUInt32Bits(__bits, 7, 1);
        public uint Points => InteropRuntime.GetUInt32Bits(__bits, 8, 1);
        public uint RtPatches => InteropRuntime.GetUInt32Bits(__bits, 9, 1);
        public uint NPatches => InteropRuntime.GetUInt32Bits(__bits, 10, 1);
        public uint SharedResource => InteropRuntime.GetUInt32Bits(__bits, 11, 1);
        public uint DiscardRenderTarget => InteropRuntime.GetUInt32Bits(__bits, 12, 1);
        public uint Video => InteropRuntime.GetUInt32Bits(__bits, 13, 1);
        public uint CaptureBuffer => InteropRuntime.GetUInt32Bits(__bits, 14, 1);
        public uint Primary => InteropRuntime.GetUInt32Bits(__bits, 15, 1);
        public uint Texture => InteropRuntime.GetUInt32Bits(__bits, 16, 1);
        public uint CubeMap => InteropRuntime.GetUInt32Bits(__bits, 17, 1);
        public uint Volume => InteropRuntime.GetUInt32Bits(__bits, 18, 1);
        public uint VertexBuffer => InteropRuntime.GetUInt32Bits(__bits, 19, 1);
        public uint IndexBuffer => InteropRuntime.GetUInt32Bits(__bits, 20, 1);
        public uint DecodeRenderTarget => InteropRuntime.GetUInt32Bits(__bits, 21, 1);
        public uint DecodeCompressedBuffer => InteropRuntime.GetUInt32Bits(__bits, 22, 1);
        public uint VideoProcessRenderTarget => InteropRuntime.GetUInt32Bits(__bits, 23, 1);
        public uint CpuOptimized => InteropRuntime.GetUInt32Bits(__bits, 24, 1);
        public uint MightDrawFromLocked => InteropRuntime.GetUInt32Bits(__bits, 25, 1);
        public uint Overlay => InteropRuntime.GetUInt32Bits(__bits, 26, 1);
        public uint MatchGdiPrimary => InteropRuntime.GetUInt32Bits(__bits, 27, 1);
        public uint InterlacedRefresh => InteropRuntime.GetUInt32Bits(__bits, 28, 1);
        public uint TextApi => InteropRuntime.GetUInt32Bits(__bits, 29, 1);
        public uint RestrictedContent => InteropRuntime.GetUInt32Bits(__bits, 30, 1);
        public uint RestrictSharedAccess => InteropRuntime.GetUInt32Bits(__bits, 31, 1);
    }
}
