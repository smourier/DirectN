﻿// generated from <Windows SDK Path>\um\ocidl.h
using System;
using System.Runtime.InteropServices;
using LRESULT = System.Int64;

namespace DirectN
{
    [ComImport, Guid("1c2056cc-5ef4-101b-8bc8-00aa003e3b29"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IOleInPlaceObjectWindowless
    {
        [PreserveSig]
        HRESULT OnWindowMessage(/* [in] */ uint msg, /* [in] */ ulong wParam, /* [in] */ long lParam, /* [out] __RPC__out */ out LRESULT plResult);
        
        [PreserveSig]
        HRESULT GetDropTarget(/* [out] __RPC__deref_out_opt */ out IntPtr ppDropTarget);
    }
}
