// generated from <Windows SDK Path>\um\ddraw.h
using System;
using System.Runtime.InteropServices;
using LPDDCOLORCONTROL = DirectN._DDCOLORCONTROL;

namespace DirectN
{
    [ComImport, Guid("4b9f0ee0-0d7e-11d0-9b06-00a0c903a3b8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectDrawColorControl
    {
        [PreserveSig]
        HRESULT GetColorControls(ref LPDDCOLORCONTROL unnamed__0);
        
        [PreserveSig]
        HRESULT SetColorControls(ref LPDDCOLORCONTROL unnamed__0);
    }
}
