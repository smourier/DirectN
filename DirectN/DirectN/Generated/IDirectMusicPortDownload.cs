// generated from <Windows SDK Path>\um\dmusicc.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("d2ac287a-b39b-11d1-8704-00600893b1bd"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectMusicPortDownload
    {
        [PreserveSig]
        HRESULT GetBuffer(uint dwDLId, out IDirectMusicDownload ppIDMDownload);
        
        [PreserveSig]
        HRESULT AllocateBuffer(uint dwSize, out IDirectMusicDownload ppIDMDownload);
        
        [PreserveSig]
        HRESULT GetDLId(ref uint pdwStartDLId, uint dwCount);
        
        [PreserveSig]
        HRESULT GetAppend(ref uint pdwAppend);
        
        [PreserveSig]
        HRESULT Download(IDirectMusicDownload pIDMDownload);
        
        [PreserveSig]
        HRESULT Unload(IDirectMusicDownload pIDMDownload);
    }
}
