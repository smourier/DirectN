﻿// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("56181d2d-e221-4adb-b1c8-3cee6a53f76f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMetadataProvider
    {
        [PreserveSig]
        HRESULT GetMFMetadata(/* [in] __RPC__in_opt */ IMFPresentationDescriptor pPresentationDescriptor, /* [in] */ uint dwStreamIdentifier, /* [in] */ uint dwFlags, /* [out] __RPC__deref_out_opt */ out IMFMetadata ppMFMetadata);
    }
}
