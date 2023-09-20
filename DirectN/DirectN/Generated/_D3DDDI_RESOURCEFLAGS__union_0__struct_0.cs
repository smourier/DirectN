// generated from <Windows SDK Path>\shared\d3dukmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_RESOURCEFLAGS__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint RenderTarget { get => InteropRuntime.GetUInt32(__bits, 0, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 0, 1); } }
        public uint ZBuffer { get => InteropRuntime.GetUInt32(__bits, 1, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 1, 1); } }
        public uint Dynamic { get => InteropRuntime.GetUInt32(__bits, 2, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 2, 1); } }
        public uint HintStatic { get => InteropRuntime.GetUInt32(__bits, 3, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 3, 1); } }
        public uint AutogenMipmap { get => InteropRuntime.GetUInt32(__bits, 4, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 4, 1); } }
        public uint DMap { get => InteropRuntime.GetUInt32(__bits, 5, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 5, 1); } }
        public uint WriteOnly { get => InteropRuntime.GetUInt32(__bits, 6, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 6, 1); } }
        public uint NotLockable { get => InteropRuntime.GetUInt32(__bits, 7, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 7, 1); } }
        public uint Points { get => InteropRuntime.GetUInt32(__bits, 8, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 8, 1); } }
        public uint RtPatches { get => InteropRuntime.GetUInt32(__bits, 9, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 9, 1); } }
        public uint NPatches { get => InteropRuntime.GetUInt32(__bits, 10, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 10, 1); } }
        public uint SharedResource { get => InteropRuntime.GetUInt32(__bits, 11, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 11, 1); } }
        public uint DiscardRenderTarget { get => InteropRuntime.GetUInt32(__bits, 12, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 12, 1); } }
        public uint Video { get => InteropRuntime.GetUInt32(__bits, 13, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 13, 1); } }
        public uint CaptureBuffer { get => InteropRuntime.GetUInt32(__bits, 14, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 14, 1); } }
        public uint Primary { get => InteropRuntime.GetUInt32(__bits, 15, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 15, 1); } }
        public uint Texture { get => InteropRuntime.GetUInt32(__bits, 16, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 16, 1); } }
        public uint CubeMap { get => InteropRuntime.GetUInt32(__bits, 17, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 17, 1); } }
        public uint Volume { get => InteropRuntime.GetUInt32(__bits, 18, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 18, 1); } }
        public uint VertexBuffer { get => InteropRuntime.GetUInt32(__bits, 19, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 19, 1); } }
        public uint IndexBuffer { get => InteropRuntime.GetUInt32(__bits, 20, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 20, 1); } }
        public uint DecodeRenderTarget { get => InteropRuntime.GetUInt32(__bits, 21, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 21, 1); } }
        public uint DecodeCompressedBuffer { get => InteropRuntime.GetUInt32(__bits, 22, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 22, 1); } }
        public uint VideoProcessRenderTarget { get => InteropRuntime.GetUInt32(__bits, 23, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 23, 1); } }
        public uint CpuOptimized { get => InteropRuntime.GetUInt32(__bits, 24, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 24, 1); } }
        public uint MightDrawFromLocked { get => InteropRuntime.GetUInt32(__bits, 25, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 25, 1); } }
        public uint Overlay { get => InteropRuntime.GetUInt32(__bits, 26, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 26, 1); } }
        public uint MatchGdiPrimary { get => InteropRuntime.GetUInt32(__bits, 27, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 27, 1); } }
        public uint InterlacedRefresh { get => InteropRuntime.GetUInt32(__bits, 28, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 28, 1); } }
        public uint TextApi { get => InteropRuntime.GetUInt32(__bits, 29, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 29, 1); } }
        public uint RestrictedContent { get => InteropRuntime.GetUInt32(__bits, 30, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 30, 1); } }
        public uint RestrictSharedAccess { get => InteropRuntime.GetUInt32(__bits, 31, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 31, 1); } }
    }
}
