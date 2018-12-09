// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmp.h(9458,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("1bb1592f-f040-418a-9f71-17c7512b4d70"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPPlayerServices2 : IWMPPlayerServices
    {
        // IWMPPlayerServices
        [PreserveSig]
        new HRESULT activateUIPlugin(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrPlugin);
        
        [PreserveSig]
        new HRESULT setTaskPane(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrTaskPane);
        
        [PreserveSig]
        new HRESULT setTaskPaneURL(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrTaskPane, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrURL, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrFriendlyName);
        
        // IWMPPlayerServices2
        [PreserveSig]
        HRESULT setBackgroundProcessingPriority(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrPriority);
    }
}
