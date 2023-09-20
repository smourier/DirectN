// generated from <Windows SDK Path>\um\vidcap.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("e30eb3a5-b36b-42dc-8527-cd25136c083c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISelector
    {
        [PreserveSig]
        HRESULT get_NumSources(/* [out] */ out uint pdwNumSources);
        
        [PreserveSig]
        HRESULT get_SourceNodeId(/* [out] */ out uint pdwPinId);
        
        [PreserveSig]
        HRESULT put_SourceNodeId(/* [in] */ uint dwPinId);
    }
}
