// generated from <Windows SDK Path>\um\mmdeviceapi.h
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
