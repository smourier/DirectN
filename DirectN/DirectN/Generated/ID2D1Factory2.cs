// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_2.h(130,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Creates Direct2D resources. This interface also enables the creation of ID2D1Device1 objects.
    /// </summary>
    [Guid("94f81a73-9212-4376-9c58-b16a3a0d3992"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1Factory2
    {
        [PreserveSig]
        HRESULT CreateDevice(/* _In_ */ ref IDXGIDevice dxgiDevice, /* _COM_Outptr_ */ out ID2D1Device1 d2dDevice1);
    }
}
