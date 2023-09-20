// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_PRESENTFLAGS__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint Blt { get => InteropRuntime.GetUInt32(__bits, 0, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 0, 1); } }
        public uint ColorFill { get => InteropRuntime.GetUInt32(__bits, 1, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 1, 1); } }
        public uint Flip { get => InteropRuntime.GetUInt32(__bits, 2, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 2, 1); } }
        public uint FlipDoNotFlip { get => InteropRuntime.GetUInt32(__bits, 3, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 3, 1); } }
        public uint FlipDoNotWait { get => InteropRuntime.GetUInt32(__bits, 4, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 4, 1); } }
        public uint FlipRestart { get => InteropRuntime.GetUInt32(__bits, 5, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 5, 1); } }
        public uint DstRectValid { get => InteropRuntime.GetUInt32(__bits, 6, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 6, 1); } }
        public uint SrcRectValid { get => InteropRuntime.GetUInt32(__bits, 7, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 7, 1); } }
        public uint RestrictVidPnSource { get => InteropRuntime.GetUInt32(__bits, 8, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 8, 1); } }
        public uint SrcColorKey { get => InteropRuntime.GetUInt32(__bits, 9, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 9, 1); } }
        public uint DstColorKey { get => InteropRuntime.GetUInt32(__bits, 10, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 10, 1); } }
        public uint LinearToSrgb { get => InteropRuntime.GetUInt32(__bits, 11, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 11, 1); } }
        public uint PresentCountValid { get => InteropRuntime.GetUInt32(__bits, 12, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 12, 1); } }
        public uint Rotate { get => InteropRuntime.GetUInt32(__bits, 13, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 13, 1); } }
        public uint PresentToBitmap { get => InteropRuntime.GetUInt32(__bits, 14, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 14, 1); } }
        public uint RedirectedFlip { get => InteropRuntime.GetUInt32(__bits, 15, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 15, 1); } }
        public uint RedirectedBlt { get => InteropRuntime.GetUInt32(__bits, 16, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 16, 1); } }
        public uint FlipStereo { get => InteropRuntime.GetUInt32(__bits, 17, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 17, 1); } }
        public uint FlipStereoTemporaryMono { get => InteropRuntime.GetUInt32(__bits, 18, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 18, 1); } }
        public uint FlipStereoPreferRight { get => InteropRuntime.GetUInt32(__bits, 19, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 19, 1); } }
        public uint BltStereoUseRight { get => InteropRuntime.GetUInt32(__bits, 20, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 20, 1); } }
        public uint PresentHistoryTokenOnly { get => InteropRuntime.GetUInt32(__bits, 21, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 21, 1); } }
        public uint PresentRegionsValid { get => InteropRuntime.GetUInt32(__bits, 22, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 22, 1); } }
        public uint PresentDDA { get => InteropRuntime.GetUInt32(__bits, 23, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 23, 1); } }
        public uint ProtectedContentBlankedOut { get => InteropRuntime.GetUInt32(__bits, 24, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 24, 1); } }
        public uint RemoteSession { get => InteropRuntime.GetUInt32(__bits, 25, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 25, 1); } }
        public uint CrossAdapter { get => InteropRuntime.GetUInt32(__bits, 26, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 26, 1); } }
        public uint DurationValid { get => InteropRuntime.GetUInt32(__bits, 27, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 27, 1); } }
        public uint PresentIndirect { get => InteropRuntime.GetUInt32(__bits, 28, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 28, 1); } }
        public uint PresentHMD { get => InteropRuntime.GetUInt32(__bits, 29, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 29, 1); } }
        public uint Reserved { get => InteropRuntime.GetUInt32(__bits, 30, 2); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 30, 2); } }
    }
}
