// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("56a86899-0ad4-11ce-b03a-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMediaFilter
    {
        [PreserveSig]
        HRESULT Stop();
        
        [PreserveSig]
        HRESULT Pause();
        
        [PreserveSig]
        HRESULT Run(long tStart);
        
        [PreserveSig]
        HRESULT GetState(/* [in] */ uint dwMilliSecsTimeout, /* [annotation][out] _Out_ */ out _FilterState State);
        
        [PreserveSig]
        HRESULT SetSyncSource(/* [annotation][in] _In_opt_ */ IReferenceClock pClock);
        
        [PreserveSig]
        HRESULT GetSyncSource(/* [annotation][out] _Outptr_result_maybenull_ */ out IReferenceClock pClock);
    }
}
