// generated from <Windows SDK Path>\shared\d3dkmthk.h
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
