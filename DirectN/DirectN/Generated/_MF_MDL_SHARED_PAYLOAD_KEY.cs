// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ks.h(6486,13)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MF_MDL_SHARED_PAYLOAD_KEY
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _MF_MDL_SHARED_PAYLOAD_KEY__struct_0 combined { get => InteropRuntime.Get<_MF_MDL_SHARED_PAYLOAD_KEY__struct_0>(__bits, 0, 128); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<_MF_MDL_SHARED_PAYLOAD_KEY__struct_0>(value, __bits, 0, 128); } }
        public Guid GMDLHandle { get => InteropRuntime.Get<Guid>(__bits, 0, 128); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<Guid>(value, __bits, 0, 128); } }
    }
}
