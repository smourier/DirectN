// generated from <Windows SDK Path>\um\d3d12umddi.h
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
