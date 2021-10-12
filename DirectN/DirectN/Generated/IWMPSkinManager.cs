// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmp.h(7049,5)
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
