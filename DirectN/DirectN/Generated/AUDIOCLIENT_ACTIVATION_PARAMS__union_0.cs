// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\audioclientactivationparams.h(94,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct AUDIOCLIENT_ACTIVATION_PARAMS__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public AUDIOCLIENT_PROCESS_LOOPBACK_PARAMS ProcessLoopbackParams { get => InteropRuntime.Get<AUDIOCLIENT_PROCESS_LOOPBACK_PARAMS>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<AUDIOCLIENT_PROCESS_LOOPBACK_PARAMS>(value, __bits, 0, 64); } }
    }
}
