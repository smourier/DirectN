// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfmediaengine.h(593,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("db71a2fc-078a-414e-9df9-8c2531b0aa6c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaTimeRange
    {
        [PreserveSig]
        uint GetLength();
        
        [PreserveSig]
        HRESULT GetStart(/* [annotation][in] _In_ */ uint index, /* [annotation][out] _Out_ */ out double pStart);
        
        [PreserveSig]
        HRESULT GetEnd(/* [annotation][in] _In_ */ uint index, /* [annotation][out] _Out_ */ out double pEnd);
        
        [PreserveSig]
        bool ContainsTime(/* [annotation][in] _In_ */ double time);
        
        [PreserveSig]
        HRESULT AddRange(/* [annotation][in] _In_ */ double startTime, /* [annotation][in] _In_ */ double endTime);
        
        [PreserveSig]
        HRESULT Clear();
    }
}
