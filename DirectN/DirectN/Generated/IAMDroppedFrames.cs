// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(10143,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c6e13344-30ac-11d0-a18c-00a0c9118956"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMDroppedFrames
    {
        [PreserveSig]
        HRESULT GetNumDropped(/* [annotation][out] _Out_ */ out long plDropped);
        
        [PreserveSig]
        HRESULT GetNumNotDropped(/* [annotation][out] _Out_ */ out long plNotDropped);
        
        [PreserveSig]
        HRESULT GetDroppedInfo(/* [in] */ int lSize, /* [annotation][out] _Out_ */ out long plArray, /* [annotation][out] _Out_ */ out long plNumCopied);
        
        [PreserveSig]
        HRESULT GetAverageFrameSize(/* [annotation][out] _Out_ */ out long plAverageSize);
    }
}
