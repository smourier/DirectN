// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\audioengineendpoint.h(202,5)
using System;
using System.Runtime.InteropServices;
using HNSTIME = System.Int64;

namespace DirectN
{
    [ComImport, Guid("30a99515-1527-4451-af9f-00c5f0234daf"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioEndpoint
    {
        [PreserveSig]
        HRESULT GetFrameFormat(/* [out] */ out IntPtr ppFormat);
        
        [PreserveSig]
        HRESULT GetFramesPerPacket(/* [out] */ out uint pFramesPerPacket);
        
        [PreserveSig]
        HRESULT GetLatency(/* [out] */ out HNSTIME pLatency);
        
        [PreserveSig]
        HRESULT SetStreamFlags(/* [in] */ uint streamFlags);
        
        [PreserveSig]
        HRESULT SetEventHandle(/* [in] */ IntPtr eventHandle);
    }
}
