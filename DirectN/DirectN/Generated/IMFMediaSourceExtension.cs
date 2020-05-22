// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfmediaengine.h(3857,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("e467b94e-a713-4562-a802-816a42e9008a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaSourceExtension
    {
        [PreserveSig]
        IMFSourceBufferList GetSourceBuffers();
        
        [PreserveSig]
        IMFSourceBufferList GetActiveSourceBuffers();
        
        [PreserveSig]
        MF_MSE_READY GetReadyState();
        
        [PreserveSig]
        void GetDuration();
        
        [PreserveSig]
        HRESULT SetDuration(/* [annotation][in] _In_ */ double duration);
        
        [PreserveSig]
        HRESULT AddSourceBuffer(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.BStr)] string type, /* [annotation][in] _In_ */ IMFSourceBufferNotify pNotify, /* [annotation][out] _Outptr_ */ out IMFSourceBuffer ppSourceBuffer);
        
        [PreserveSig]
        HRESULT RemoveSourceBuffer(/* [annotation][in] _In_ */ IMFSourceBuffer pSourceBuffer);
        
        [PreserveSig]
        HRESULT SetEndOfStream(/* [annotation][in] _In_ */ MF_MSE_ERROR error);
        
        [PreserveSig]
        bool IsTypeSupported(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.BStr)] string type);
        
        [PreserveSig]
        IMFSourceBuffer GetSourceBuffer(/* [annotation][in] _In_ */ uint dwStreamIndex);
    }
}
