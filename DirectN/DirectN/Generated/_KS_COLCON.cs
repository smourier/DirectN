// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksmedia.h(3586,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _KS_COLCON
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public byte emph1col { get => InteropRuntime.GetByte(__bits, 0, 4); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetByte(value, __bits, 0, 4); } }
        public byte emph2col { get => InteropRuntime.GetByte(__bits, 4, 4); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetByte(value, __bits, 4, 4); } }
        public byte backcol { get => InteropRuntime.GetByte(__bits, 8, 4); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetByte(value, __bits, 8, 4); } }
        public byte patcol { get => InteropRuntime.GetByte(__bits, 12, 4); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetByte(value, __bits, 12, 4); } }
        public byte emph1con { get => InteropRuntime.GetByte(__bits, 16, 4); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetByte(value, __bits, 16, 4); } }
        public byte emph2con { get => InteropRuntime.GetByte(__bits, 20, 4); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetByte(value, __bits, 20, 4); } }
        public byte backcon { get => InteropRuntime.GetByte(__bits, 24, 4); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetByte(value, __bits, 24, 4); } }
        public byte patcon { get => InteropRuntime.GetByte(__bits, 28, 4); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetByte(value, __bits, 28, 4); } }
    }
}
