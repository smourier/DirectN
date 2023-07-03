// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(577,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_SCATTERBLTS
    {
        public uint NumBlts;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)] 
        public _D3DKMT_SCATTERBLT[] Blts;
    }
}
