// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3d9types.h(1917,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DDEVINFO_RESOURCEMANAGER
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public _D3DRESOURCESTATS[][] stats;
    }
}
