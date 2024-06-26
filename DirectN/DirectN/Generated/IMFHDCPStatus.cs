﻿// generated from <Windows SDK Path>\um\mfmediaengine.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("de400f54-5bf1-40cf-8964-0bea136b1e3d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFHDCPStatus
    {
        [PreserveSig]
        HRESULT Query(/* [annotation][in] _Inout_ */ ref _MF_HDCP_STATUS pStatus, /* [annotation][in] _Inout_ */ ref bool pfStatus);
        
        [PreserveSig]
        HRESULT Set(/* [annotation][in] _In_ */ _MF_HDCP_STATUS status);
    }
}
