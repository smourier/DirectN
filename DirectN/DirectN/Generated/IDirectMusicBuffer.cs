// generated from <Windows SDK Path>\um\dmusicc.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("d2ac2878-b39b-11d1-8704-00600893b1bd"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectMusicBuffer
    {
        [PreserveSig]
        HRESULT Flush();
        
        [PreserveSig]
        HRESULT TotalTime(ref long prtTime);
        
        [PreserveSig]
        HRESULT PackStructured(long rt, uint dwChannelGroup, uint dwChannelMessage);
        
        [PreserveSig]
        HRESULT PackUnstructured(long rt, uint dwChannelGroup, uint cb, IntPtr lpb);
        
        [PreserveSig]
        HRESULT ResetReadPtr();
        
        [PreserveSig]
        HRESULT GetNextEvent(ref long prt, ref uint pdwChannelGroup, ref uint pdwLength, IntPtr ppData);
        
        [PreserveSig]
        HRESULT GetRawBufferPtr(IntPtr ppData);
        
        [PreserveSig]
        HRESULT GetStartTime(ref long prt);
        
        [PreserveSig]
        HRESULT GetUsedBytes(ref uint pcb);
        
        [PreserveSig]
        HRESULT GetMaxBytes(ref uint pcb);
        
        [PreserveSig]
        HRESULT GetBufferFormat([MarshalAs(UnmanagedType.LPStruct)] Guid pGuidFormat);
        
        [PreserveSig]
        HRESULT SetStartTime(long rt);
        
        [PreserveSig]
        HRESULT SetUsedBytes(uint cb);
    }
}
