// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(8271,9)
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
