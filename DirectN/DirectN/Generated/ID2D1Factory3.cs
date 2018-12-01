// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_3.h(997,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Creates Direct2D resources. This interface also enables the creation of ID2D1Device2 objects.
    /// </summary>
    [Guid("0869759f-4f00-413f-b03e-2bda45404d0f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1Factory3
    {
        [PreserveSig]
        HRESULT CreateDevice(/* _In_ */ ref IDXGIDevice dxgiDevice, /* _COM_Outptr_ */ out ID2D1Device2 d2dDevice2);
    }
}
