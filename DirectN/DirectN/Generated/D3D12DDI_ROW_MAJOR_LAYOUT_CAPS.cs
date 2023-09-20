// generated from <Windows SDK Path>\um\d3d12umddi.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_ROW_MAJOR_LAYOUT_CAPS
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public D3D12DDI_ROW_MAJOR_LAYOUT_SUB_CAPS[] SubCaps;
        public D3D12DDI_ROW_MAJOR_LAYOUT_FLAGS Flags;
    }
}
