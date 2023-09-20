// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_RESETCOMMANDLIST_0040
    {
        public D3D12DDI_HCOMMANDRECORDER_0040 hDrvCommandRecorder;
        public ulong ID;
        public D3D12DDI_COMMAND_LIST_FLAGS CommandListFlags;
    }
}
