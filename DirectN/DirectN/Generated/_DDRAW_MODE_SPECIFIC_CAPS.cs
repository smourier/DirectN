// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(2186,13)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDRAW_MODE_SPECIFIC_CAPS
    {
        public uint Head;
        public uint Caps;
        public uint CKeyCaps;
        public uint FxCaps;
        public uint MaxVisibleOverlays;
        public uint MinOverlayStretch;
        public uint MaxOverlayStretch;
    }
}
