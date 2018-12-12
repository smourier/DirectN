// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddraw.h(1402,1)
using System;
using System.Runtime.InteropServices;
using LPDIRECTDRAW = DirectN.IDirectDraw;

namespace DirectN
{
    [Guid("6c14db85-a733-11ce-a521-0020af0be560"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectDrawClipper
    {
        [PreserveSig]
        HRESULT GetClipList(ref tagRECT __unnamed_0, ref _RGNDATA __unnamed_1, ref uint __unnamed_2);
        
        [PreserveSig]
        HRESULT GetHWnd(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT Initialize(LPDIRECTDRAW __unnamed_0, uint __unnamed_1);
        
        [PreserveSig]
        HRESULT IsClipListChanged(ref bool __unnamed_0);
        
        [PreserveSig]
        HRESULT SetClipList(ref _RGNDATA __unnamed_0, uint __unnamed_1);
        
        [PreserveSig]
        HRESULT SetHWnd(uint __unnamed_0, IntPtr __unnamed_1);
    }
}
