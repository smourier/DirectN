// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_3.h(1521,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Creates Direct2D resources. This interface also enables the creation of ID2D1Device4 objects.
    /// </summary>
    [Guid("c4349994-838e-4b0f-8cab-44997d9eeacc"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1Factory5 : ID2D1Factory4
    {
        // ID2D1Factory3
        [PreserveSig]
        new HRESULT CreateDevice(/* _In_ */ ref IDXGIDevice dxgiDevice, /* _COM_Outptr_ */ out ID2D1Device2 d2dDevice2);
        
        // ID2D1Factory4
        [PreserveSig]
        new HRESULT CreateDevice(/* _In_ */ ref IDXGIDevice dxgiDevice, /* _COM_Outptr_ */ out ID2D1Device3 d2dDevice3);
        
        // ID2D1Factory5
        [PreserveSig]
        HRESULT CreateDevice(/* _In_ */ ref IDXGIDevice dxgiDevice, /* _COM_Outptr_ */ out ID2D1Device4 d2dDevice4);
    }
}
