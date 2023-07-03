// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3d9types.h(1495,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DDEVICE_CREATION_PARAMETERS
    {
        public uint AdapterOrdinal;
        public _D3DDEVTYPE DeviceType;
        public IntPtr hFocusWindow;
        public uint BehaviorFlags;
    }
}
