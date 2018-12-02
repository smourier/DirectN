// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\dxgi1_6.h(132,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("3c8d99d1-4fbf-4181-a82c-af66bf7bd24e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGIAdapter4
    {
        [PreserveSig]
        HRESULT GetDesc3(/* [annotation][out] _Out_ */ out DXGI_ADAPTER_DESC3 pDesc);
    }
}
