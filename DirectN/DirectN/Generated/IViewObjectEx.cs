// generated from <Windows SDK Path>\um\ocidl.h
using System;
using System.Runtime.InteropServices;
using DVTARGETDEVICE = DirectN.tagDVTARGETDEVICE;

namespace DirectN
{
    [ComImport, Guid("3af24292-0c96-11ce-a0cf-00aa00600ab8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IViewObjectEx
    {
        [PreserveSig]
        HRESULT GetRect(/* [in] */ uint dwAspect, /* [out] __RPC__out */ out _RECTL pRect);
        
        [PreserveSig]
        HRESULT GetViewStatus(/* [out] __RPC__out */ out uint pdwStatus);
        
        [PreserveSig]
        HRESULT QueryHitPoint(/* [in] */ uint dwAspect, /* [in] __RPC__in */ ref tagRECT pRectBounds, /* [in] */ tagPOINT ptlLoc, /* [in] */ int lCloseHint, /* [out] __RPC__out */ out uint pHitResult);
        
        [PreserveSig]
        HRESULT QueryHitRect(/* [in] */ uint dwAspect, /* [in] __RPC__in */ ref tagRECT pRectBounds, /* [in] __RPC__in */ ref tagRECT pRectLoc, /* [in] */ int lCloseHint, /* [out] __RPC__out */ out uint pHitResult);
        
        [PreserveSig]
        HRESULT GetNaturalExtent(/* [in] */ uint dwAspect, /* [in] */ int lindex, /* [in] __RPC__in */ ref DVTARGETDEVICE ptd, /* [in] __RPC__in */ IntPtr hicTargetDev, /* [in] __RPC__in */ ref tagExtentInfo pExtentInfo, /* [out] __RPC__out */ out tagSIZE pSizel);
    }
}
