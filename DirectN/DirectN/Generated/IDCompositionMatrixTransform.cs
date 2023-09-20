// generated from <Windows SDK Path>\um\dcomp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("16cdff07-c503-419c-83f2-0965c7af1fa6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionMatrixTransform : IDCompositionTransform
    {
        // IDCompositionEffect
        
        // IDCompositionTransform3D
        
        // IDCompositionTransform
        
        // IDCompositionMatrixTransform
        [PreserveSig]
        HRESULT SetMatrix(ref D2D_MATRIX_3X2_F matrix);
        
        [PreserveSig]
        HRESULT SetMatrixElement(/* THIS_ _In_ */ int row, /* _In_ */ int column, /* _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetMatrixElement(/* THIS_ _In_ */ int row, /* _In_ */ int column, /* _In_ */ float value);
    }
}
