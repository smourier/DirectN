// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_3.h(1678,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Creates Direct2D resources. This interface also enables the creation of ID2D1Device5 objects.
    /// </summary>
    [Guid("f9976f46-f642-44c1-97ca-da32ea2a2635"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1Factory6 : ID2D1Factory5
    {
        // ID2D1Factory3
        [PreserveSig]
        new HRESULT CreateDevice(/* _In_ */ ref IDXGIDevice dxgiDevice, /* _COM_Outptr_ */ out ID2D1Device2 d2dDevice2);
        
        // ID2D1Factory4
        [PreserveSig]
        new HRESULT CreateDevice(/* _In_ */ ref IDXGIDevice dxgiDevice, /* _COM_Outptr_ */ out ID2D1Device3 d2dDevice3);
        
        // ID2D1Factory5
        [PreserveSig]
        new HRESULT CreateDevice(/* _In_ */ ref IDXGIDevice dxgiDevice, /* _COM_Outptr_ */ out ID2D1Device4 d2dDevice4);
        
        // ID2D1Factory6
        [PreserveSig]
        HRESULT CreateDevice(/* _In_ */ ref IDXGIDevice dxgiDevice, /* _COM_Outptr_ */ out ID2D1Device5 d2dDevice5);
    }
}
