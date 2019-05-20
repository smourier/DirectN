// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(10138,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATE_VIDEO_EXTENSION_COMMAND_0063
    {
        public uint NodeMask;
        public Guid CommandId;
        public IntPtr pCreationParameters;
        public IntPtr CreationParametersDataSizeInBytes;
        public D3D12DDI_HPROTECTEDRESOURCESESSION_0030 hDrvProtectedResourceSession;
    }
}
