// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(2790,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_PROCESS_VERIFIER_OPTION
    {
        public IntPtr hProcess;
        public _D3DKMT_PROCESS_VERIFIER_OPTION_TYPE Type;
        public _D3DKMT_VERIFIER_OPTION_MODE Mode;
        public _D3DKMT_PROCESS_VERIFIER_OPTION_DATA Data;
    }
}
