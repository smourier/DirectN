// generated from <Windows SDK Path>\um\ddraw.h
using System;
using System.Runtime.InteropServices;
using LPDIRECTDRAW = DirectN.IDirectDraw;

namespace DirectN
{
    [ComImport, Guid("6c14db85-a733-11ce-a521-0020af0be560"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectDrawClipper
    {
        [PreserveSig]
        HRESULT GetClipList(ref tagRECT unnamed__0, ref _RGNDATA unnamed__1, ref uint unnamed__2);
        
        [PreserveSig]
        HRESULT GetHWnd(IntPtr unnamed__0);
        
        [PreserveSig]
        HRESULT Initialize(LPDIRECTDRAW unnamed__0, uint unnamed__1);
        
        [PreserveSig]
        HRESULT IsClipListChanged(ref bool unnamed__0);
        
        [PreserveSig]
        HRESULT SetClipList(ref _RGNDATA unnamed__0, uint unnamed__1);
        
        [PreserveSig]
        HRESULT SetHWnd(uint unnamed__0, IntPtr unnamed__1);
    }
}
