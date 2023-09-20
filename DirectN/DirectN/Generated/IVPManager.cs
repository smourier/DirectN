// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("aac18c18-e186-46d2-825d-a1f8dc8e395a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IVPManager
    {
        [PreserveSig]
        HRESULT SetVideoPortIndex(/* [in] */ uint dwVideoPortIndex);
        
        [PreserveSig]
        HRESULT GetVideoPortIndex(/* [out] */ out uint pdwVideoPortIndex);
    }
}
