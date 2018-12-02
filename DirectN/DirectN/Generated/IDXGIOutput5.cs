// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\dxgi1_5.h(106,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("80a07424-ab52-42eb-833c-0c42fd282d98"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGIOutput5
    {
        [PreserveSig]
        HRESULT DuplicateOutput1(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pDevice, /* [in] */ uint Flags, /* [annotation][in] _In_ */ uint SupportedFormatsCount, /* [annotation][in] _In_reads_(SupportedFormatsCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] DXGI_FORMAT[] pSupportedFormats, /* [annotation][out] _COM_Outptr_ */ out IDXGIOutputDuplication ppOutputDuplication);
    }
}
