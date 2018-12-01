// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_1.h(1370,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Represents a bitmap that can be used as a surface for an ID2D1DeviceContext or mapped into system memory, and can contain additional color context information.
    /// </summary>
    [Guid("a898a84c-3873-4588-b08b-ebbf978df041"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1Bitmap1
    {
        [PreserveSig]
        void GetColorContext(/* _Outptr_result_maybenull_ */ out ID2D1ColorContext colorContext);
        
        [PreserveSig]
        D2D1_BITMAP_OPTIONS GetOptions();
        
        [PreserveSig]
        HRESULT GetSurface(/* _COM_Outptr_result_maybenull_ */ out IDXGISurface dxgiSurface);
        
        [PreserveSig]
        HRESULT Map(D2D1_MAP_OPTIONS options, /* _Out_ */ out D2D1_MAPPED_RECT mappedRect);
        
        [PreserveSig]
        HRESULT Unmap();
    }
}
