// generated from <Windows SDK Path>\um\dcomp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("4b3363f0-643b-41b7-b6e0-ccf22d34467c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionMatrixTransform3D : IDCompositionTransform3D
    {
        // IDCompositionEffect
        
        // IDCompositionTransform3D
        
        // IDCompositionMatrixTransform3D
        [PreserveSig]
        HRESULT SetMatrix(ref _D3DMATRIX matrix);
        
        [PreserveSig]
        HRESULT SetMatrixElement(/* THIS_ _In_ */ int row, /* _In_ */ int column, /* _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetMatrixElement(/* THIS_ _In_ */ int row, /* _In_ */ int column, /* _In_ */ float value);
    }
}
