// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(20627,5)
using System;
using System.Runtime.InteropServices;
using LPDIRECTDRAW7 = DirectN.IDirectDraw7;
using LPDIRECTDRAWSURFACE7 = DirectN.IDirectDrawSurface7;

namespace DirectN
{
    [Guid("e6f7ce40-4673-44f1-8f77-5499d68cb4ea"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IVMRImagePresenterExclModeConfig : IVMRImagePresenterConfig
    {
        // IVMRImagePresenterConfig
        [PreserveSig]
        new HRESULT SetRenderingPrefs(/* [in] */ uint dwRenderFlags);
        
        [PreserveSig]
        new HRESULT GetRenderingPrefs(/* [out] */ out uint dwRenderFlags);
        
        // IVMRImagePresenterExclModeConfig
        [PreserveSig]
        HRESULT SetXlcModeDDObjAndPrimarySurface(/* [in] */ LPDIRECTDRAW7 lpDDObj, /* [in] */ LPDIRECTDRAWSURFACE7 lpPrimarySurf);
        
        [PreserveSig]
        HRESULT GetXlcModeDDObjAndPrimarySurface(/* [out] */ out LPDIRECTDRAW7 lpDDObj, /* [out] */ out LPDIRECTDRAWSURFACE7 lpPrimarySurf);
    }
}
