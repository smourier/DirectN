// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1_3.h(690,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Represents a device-dependent representation of a gradient mesh composed of patches. Use the ID2D1DeviceContext2::CreateGradientMesh method to create an instance of ID2D1GradientMesh.
    /// </summary>
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
