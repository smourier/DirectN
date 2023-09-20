// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_MONITORLINKINFO
    {
        public _DXGK_MONITORLINKINFO_USAGEHINTS UsageHints;
        public _DXGK_MONITORLINKINFO_CAPABILITIES Capabilities;
        public _D3DKMDT_WIRE_FORMAT_AND_PREFERENCE DitheringSupport;
    }
}
