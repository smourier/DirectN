// generated from <Windows SDK Path>\um\wmp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("076f2fa6-ed30-448b-8cc5-3f3ef3529c7a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPSkinManager
    {
        [PreserveSig]
        HRESULT SetVisualStyle(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrPath);
    }
}
