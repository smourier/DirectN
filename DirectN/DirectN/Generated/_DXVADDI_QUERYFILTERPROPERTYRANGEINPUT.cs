// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(2489,13)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVADDI_QUERYFILTERPROPERTYRANGEINPUT
    {
        public IntPtr pVideoProcGuid;
        public _DXVADDI_VIDEODESC VideoDesc;
        public _D3DDDIFORMAT RenderTargetFormat;
        public uint FilterSetting;
    }
}
