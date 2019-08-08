// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dcomp.h(689,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("16cdff07-c503-419c-83f2-0965c7af1fa6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionMatrixTransform : IDCompositionTransform
    {
        // IDCompositionEffect
        
        // IDCompositionTransform3D
        
        // IDCompositionTransform
        
        // IDCompositionMatrixTransform
        [PreserveSig]
        HRESULT SetMatrix(ref D2D_MATRIX_3X2_F matrix);
        
        [PreserveSig]
        HRESULT SetMatrixElement(/* THIS_ _In_ */ int row, /* _In_ */ int column, /* _In_ */ float value);
        
        [PreserveSig]
        HRESULT SetMatrixElement(/* THIS_ _In_ */ int row, /* _In_ */ int column, /* _In_ */ IDCompositionAnimation animation);
    }
}
