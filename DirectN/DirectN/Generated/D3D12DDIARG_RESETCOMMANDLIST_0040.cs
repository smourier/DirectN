// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(6356,9)
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
