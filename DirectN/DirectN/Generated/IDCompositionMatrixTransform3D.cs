// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dcomp.h(962,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("4b3363f0-643b-41b7-b6e0-ccf22d34467c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionMatrixTransform3D : IDCompositionTransform3D
    {
        // IDCompositionEffect
        
        // IDCompositionTransform3D
        
        // IDCompositionMatrixTransform3D
        [PreserveSig]
        HRESULT SetMatrix(ref _D3DMATRIX matrix);
        
        [PreserveSig]
        HRESULT SetMatrixElement(/* THIS_ _In_ */ int row, /* _In_ */ int column, /* _In_ */ float value);
        
        [PreserveSig]
        HRESULT SetMatrixElement(/* THIS_ _In_ */ int row, /* _In_ */ int column, /* _In_ */ IDCompositionAnimation animation);
    }
}
