// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ocidl.h(4791,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("3af24292-0c96-11ce-a0cf-00aa00600ab8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IViewObjectEx
    {
        [PreserveSig]
        HRESULT GetRect(/* [in] */ uint dwAspect, /* [out] __RPC__out */ IntPtr pRect);
        
        [PreserveSig]
        HRESULT GetViewStatus(/* [out] __RPC__out */ out uint pdwStatus);
        
        [PreserveSig]
        HRESULT QueryHitPoint(/* [in] */ uint dwAspect, /* [in] __RPC__in */ IntPtr pRectBounds, /* [in] */ tagPOINT ptlLoc, /* [in] */ int lCloseHint, /* [out] __RPC__out */ out uint pHitResult);
        
        [PreserveSig]
        HRESULT QueryHitRect(/* [in] */ uint dwAspect, /* [in] __RPC__in */ IntPtr pRectBounds, /* [in] __RPC__in */ IntPtr pRectLoc, /* [in] */ int lCloseHint, /* [out] __RPC__out */ out uint pHitResult);
        
        [PreserveSig]
        HRESULT GetNaturalExtent(/* [in] */ uint dwAspect, /* [in] */ int lindex, /* [in] __RPC__in */ ref tagDVTARGETDEVICE ptd, /* [in] __RPC__in */ IntPtr hicTargetDev, /* [in] __RPC__in */ ref tagExtentInfo pExtentInfo, /* [out] __RPC__out */ IntPtr pSizel);
    }
}
