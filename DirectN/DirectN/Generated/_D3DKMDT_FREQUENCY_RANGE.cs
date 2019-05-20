// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmdt.h(795,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMDT_FREQUENCY_RANGE
    {
        public _D3DDDI_RATIONAL MinVSyncFreq;
        public _D3DDDI_RATIONAL MaxVSyncFreq;
        public _D3DDDI_RATIONAL MinHSyncFreq;
        public _D3DDDI_RATIONAL MaxHSyncFreq;
    }
}
