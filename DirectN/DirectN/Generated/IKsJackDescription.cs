// generated from <Windows SDK Path>\um\devicetopology.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("4509f757-2d46-4637-8e62-ce7db944f57b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IKsJackDescription
    {
        [PreserveSig]
        HRESULT GetJackCount(/* [annotation][out] _Out_ */ out uint pcJacks);
        
        [PreserveSig]
        HRESULT GetJackDescription(/* [in] */ uint nJack, /* [annotation][out] _Out_ */ out KSJACK_DESCRIPTION pDescription);
    }
}
