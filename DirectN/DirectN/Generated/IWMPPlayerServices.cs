// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmp.h(9006,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("1d01fbdb-ade2-4c8d-9842-c190b95c3306"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPPlayerServices
    {
        [PreserveSig]
        HRESULT activateUIPlugin(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrPlugin);
        
        [PreserveSig]
        HRESULT setTaskPane(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrTaskPane);
        
        [PreserveSig]
        HRESULT setTaskPaneURL(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrTaskPane, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrURL, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrFriendlyName);
    }
}
