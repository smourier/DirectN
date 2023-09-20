// generated from <Windows SDK Path>\shared\d3dkmthk.h
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
