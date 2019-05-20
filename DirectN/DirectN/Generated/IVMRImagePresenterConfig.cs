// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\strmif.h(20537,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("9f3a1c85-8555-49ba-935f-be5b5b29d178"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IVMRImagePresenterConfig
    {
        [PreserveSig]
        HRESULT SetRenderingPrefs(/* [in] */ uint dwRenderFlags);
        
        [PreserveSig]
        HRESULT GetRenderingPrefs(/* [out] */ out uint dwRenderFlags);
    }
}
