// generated from <Windows SDK Path>\um\devicetopology.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("d9bd72ed-290f-4581-9ff3-61027a8fe532"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IKsJackSinkInformation
    {
        [PreserveSig]
        HRESULT GetJackSinkInformation(/* [annotation][out] _Out_ */ out _tagKSJACK_SINK_INFORMATION pJackSinkInformation);
    }
}
