// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_3.h(1210,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Creates Direct2D resources. This interface also enables the creation of ID2D1Device3 objects.
    /// </summary>
    [Guid("bd4ec2d2-0662-4bee-ba8e-6f29f032e096"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1Factory4 : ID2D1Factory3
    {
        // ID2D1Factory3
        [PreserveSig]
        new HRESULT CreateDevice(/* _In_ */ ref IDXGIDevice dxgiDevice, /* _COM_Outptr_ */ out ID2D1Device2 d2dDevice2);
        
        // ID2D1Factory4
        [PreserveSig]
        HRESULT CreateDevice(/* _In_ */ ref IDXGIDevice dxgiDevice, /* _COM_Outptr_ */ out ID2D1Device3 d2dDevice3);
    }
}
