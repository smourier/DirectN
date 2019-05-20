// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(4535,9)
using System;
using System.Runtime.InteropServices;
using PFND3D12DDI_COPYTILEMAPPINGS = System.IntPtr;
using PFND3D12DDI_EXECUTECOMMANDLISTS = System.IntPtr;
using PFND3D12DDI_SIGNAL_FENCE = System.IntPtr;
using PFND3D12DDI_UPDATETILEMAPPINGS = System.IntPtr;
using PFND3D12DDI_WAIT_FOR_FENCE = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_COMMAND_QUEUE_FUNCS_VIDEO_0020
    {
        public IntPtr pfnExecuteCommandLists;
        public IntPtr pfnUpdateTileMappings;
        public IntPtr pfnCopyTileMappings;
        public IntPtr pfnSignalFence;
        public IntPtr pfnWaitForFence;
    }
}
