// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\dxgi1_6.h(400,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("068346e8-aaec-4b84-add7-137f513f77a1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGIOutput6
    {
        [PreserveSig]
        HRESULT GetDesc1(/* [annotation][out] _Out_ */ out DXGI_OUTPUT_DESC1 pDesc);
        
        [PreserveSig]
        HRESULT CheckHardwareCompositionSupport(/* [annotation][out] _Out_ */ out uint pFlags);
    }
}
