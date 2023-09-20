// generated from <Windows SDK Path>\um\audioengineendpoint.h
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
