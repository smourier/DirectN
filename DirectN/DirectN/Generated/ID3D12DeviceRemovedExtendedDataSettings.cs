﻿// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("82bc481c-6b9b-4030-aedb-7ee3d1df1e63"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12DeviceRemovedExtendedDataSettings
    {
        [PreserveSig]
        void SetAutoBreadcrumbsEnablement(D3D12_DRED_ENABLEMENT Enablement);
        
        [PreserveSig]
        void SetPageFaultEnablement(D3D12_DRED_ENABLEMENT Enablement);
        
        [PreserveSig]
        void SetWatsonDumpEnablement(D3D12_DRED_ENABLEMENT Enablement);
    }
}
