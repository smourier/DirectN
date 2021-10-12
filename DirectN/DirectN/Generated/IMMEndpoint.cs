// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mmdeviceapi.h(664,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("1be09788-6894-4089-8586-9a2a6c265ac5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMMEndpoint
    {
        [PreserveSig]
        HRESULT GetDataFlow(/* [annotation][out] _Out_ */ out __MIDL___MIDL_itf_mmdeviceapi_0000_0000_0001 pDataFlow);
    }
}
