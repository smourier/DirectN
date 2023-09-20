// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;
using LPDIRECTDRAW7 = DirectN.IDirectDraw7;
using LPDIRECTDRAWSURFACE7 = DirectN.IDirectDrawSurface7;

namespace DirectN
{
    [ComImport, Guid("e6f7ce40-4673-44f1-8f77-5499d68cb4ea"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
