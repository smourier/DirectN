// generated from <Windows SDK Path>\um\ddraw.h
using System;
using System.Runtime.InteropServices;
using LPDIRECTDRAW = DirectN.IDirectDraw;

namespace DirectN
{
    [ComImport, Guid("6c14db84-a733-11ce-a521-0020af0be560"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectDrawPalette
    {
        [PreserveSig]
        HRESULT GetCaps(ref uint unnamed__0);
        
        [PreserveSig]
        HRESULT GetEntries(uint unnamed__0, uint unnamed__1, uint unnamed__2, ref tagPALETTEENTRY unnamed__3);
        
        [PreserveSig]
        HRESULT Initialize(LPDIRECTDRAW unnamed__0, uint unnamed__1, ref tagPALETTEENTRY unnamed__2);
        
        [PreserveSig]
        HRESULT SetEntries(uint unnamed__0, uint unnamed__1, uint unnamed__2, ref tagPALETTEENTRY unnamed__3);
    }
}
