// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMDT_FENCESTORAGESURFACEDATA
    {
        public uint PhysicalAdapterIndex;
        public _DXGKARG_FENCESTORAGEVALUETYPE FenceStorageValueType;
        public _D3DDDI_NATIVEFENCE_TYPE FenceStorageType;
        public uint PrivateDriverDataSize;
        public IntPtr pPrivateDriverData;
        public _DXGKARG_FENCESTORAGEFLAGS Flags;
        public uint Reserved;
        public _DXGK_ALLOCATIONINFO AllocationInfo;
    }
}
