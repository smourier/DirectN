// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddraw.h(1402,1)
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
