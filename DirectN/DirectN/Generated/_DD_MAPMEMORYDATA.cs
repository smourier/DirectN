// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddrawint.h(1427,9)
using System;
using System.Runtime.InteropServices;
using PDD_DIRECTDRAW_GLOBAL = DirectN._DD_DIRECTDRAW_GLOBAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_MAPMEMORYDATA
    {
        public IntPtr lpDD;
        public bool bMap;
        public IntPtr hProcess;
        public ulong fpProcess;
        public HRESULT ddRVal;
    }
}
