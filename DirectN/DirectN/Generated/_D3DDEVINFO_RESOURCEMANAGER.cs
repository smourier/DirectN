// generated from <Windows SDK Path>\shared\d3d9types.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DDEVINFO_RESOURCEMANAGER
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public _D3DRESOURCESTATS[] stats;
    }
}
