// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("56a868af-0ad4-11ce-b03a-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDistributorNotify
    {
        [PreserveSig]
        HRESULT Stop();
        
        [PreserveSig]
        HRESULT Pause();
        
        [PreserveSig]
        HRESULT Run(long tStart);
        
        [PreserveSig]
        HRESULT SetSyncSource(/* [in] */ IReferenceClock pClock);
        
        [PreserveSig]
        HRESULT NotifyGraphChange();
    }
}
