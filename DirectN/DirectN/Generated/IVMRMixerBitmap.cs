// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(21146,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("1e673275-0257-40aa-af20-7c608d4a0428"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IVMRMixerBitmap
    {
        [PreserveSig]
        HRESULT SetAlphaBitmap(/* [in] */ ref _VMRALPHABITMAP pBmpParms);
        
        [PreserveSig]
        HRESULT UpdateAlphaBitmapParameters(/* [in] */ ref _VMRALPHABITMAP pBmpParms);
        
        [PreserveSig]
        HRESULT GetAlphaBitmapParameters(/* [out] */ out _VMRALPHABITMAP pBmpParms);
    }
}
