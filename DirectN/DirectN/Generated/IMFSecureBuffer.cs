// generated from <Windows SDK Path>\um\mfobjects.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c1209904-e584-4752-a2d6-7f21693f8b21"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSecureBuffer
    {
        [PreserveSig]
        HRESULT GetIdentifier(/* [annotation][out] _Out_ */ out Guid pGuidIdentifier);
    }
}
