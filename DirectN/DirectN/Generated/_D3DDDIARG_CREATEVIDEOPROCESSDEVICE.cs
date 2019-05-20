// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(1197,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_CREATEVIDEOPROCESSDEVICE
    {
        public IntPtr pVideoProcGuid;
        public _DXVADDI_VIDEODESC VideoDesc;
        public _D3DDDIFORMAT RenderTargetFormat;
        public uint MaxSubStreams;
        public IntPtr hVideoProcess;
    }
}
