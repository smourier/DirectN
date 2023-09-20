// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System.Runtime.InteropServices;
using PHYSICAL_ADDRESS = System.Int64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_CREATE_PHYSICAL_MEMORY_OBJECT__union_0__struct_1
    {
        public PHYSICAL_ADDRESS LowestAcceptableAddress;
        public PHYSICAL_ADDRESS HighestAcceptableAddress;
        public PHYSICAL_ADDRESS BoundaryAddressMultiple;
    }
}
