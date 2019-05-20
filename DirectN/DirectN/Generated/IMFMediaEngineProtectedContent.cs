// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\mfmediaengine.h(2721,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("9f8021e8-9c8c-487e-bb5c-79aa4779938c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaEngineProtectedContent
    {
        [PreserveSig]
        HRESULT ShareResources(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pUnkDeviceContext);
        
        [PreserveSig]
        HRESULT GetRequiredProtections(/* [annotation][out] _Out_ */ out uint pFrameProtectionFlags);
        
        [PreserveSig]
        HRESULT SetOPMWindow(/* [annotation][in] _In_ */ IntPtr hwnd);
        
        [PreserveSig]
        HRESULT TransferVideoFrame(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pDstSurf, /* optional(MFVideoNormalizedRect) */ IntPtr pSrc, /* [annotation][in] _In_ */ ref tagRECT pDst, /* optional(_MFARGB) */ IntPtr pBorderClr, /* [annotation][out] _Out_ */ out uint pFrameProtectionFlags);
        
        [PreserveSig]
        HRESULT SetContentProtectionManager(/* [annotation][in] _In_opt_ */ IMFContentProtectionManager pCPM);
        
        [PreserveSig]
        HRESULT SetApplicationCertificate(/* [annotation][in] _In_reads_bytes_(cbBlob) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pbBlob, /* [annotation][in] _In_ */ uint cbBlob);
    }
}
