﻿// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("149c4d73-b4be-4f8d-8b87-079e926b6add"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFLocalMFTRegistration
    {
        [PreserveSig]
        HRESULT RegisterMFTs(/* [size_is][in] __RPC__in_ecount_full(cMFTs) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] _MFT_REGISTRATION_INFO[] pMFTs, int cMFTs);
    }
}
