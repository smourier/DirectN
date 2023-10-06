// generated from <Windows SDK Path>\um\d2d1_3.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("f292e401-c050-4cde-83d7-04962d3b23c2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1GradientMesh : ID2D1Resource
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1GradientMesh
        [PreserveSig]
        uint GetPatchCount();
        
        [PreserveSig]
        HRESULT GetPatches(uint startIndex, /* _Out_writes_(patchesCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] D2D1_GRADIENT_MESH_PATCH[] patches, int patchesCount);
    }
}
