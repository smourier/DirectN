// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(3250,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_OUTPUTDUPL_SNAPSHOT
    {
        public uint Size;
        public uint SessionProcessCount;
        public uint SessionActiveConnectionsCount;
        public uint NumVidPnSources;
        public uint NumOutputDuplContexts;
        public uint Padding;
        [MarshalAs(UnmanagedType.ByValArray)] 
        public _OUTPUTDUPL_CONTEXT_DEBUG_INFO[] OutputDuplDebugInfos;
    }
}
