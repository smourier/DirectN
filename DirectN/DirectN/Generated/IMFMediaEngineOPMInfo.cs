﻿// generated from <Windows SDK Path>\um\mfmediaengine.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("765763e6-6c01-4b01-bb0f-b829f60ed28c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaEngineOPMInfo
    {
        [PreserveSig]
        HRESULT GetOPMInfo(/* [annotation][out] _Out_ */ out MF_MEDIA_ENGINE_OPM_STATUS pStatus, /* [annotation][out] _Out_ */ out bool pConstricted);
    }
}
