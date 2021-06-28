// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wincodec.h(1118,5)
using System;
using System.Runtime.InteropServices;
using WICColor = System.UInt32;

namespace DirectN
{
    [ComImport, Guid("00000040-a8f2-4877-ba0a-fd2b6645fb94"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICPalette
    {
        [PreserveSig]
        HRESULT InitializePredefined(/* [in] */ WICBitmapPaletteType ePaletteType, /* [in] */ bool fAddTransparentColor);
        
        [PreserveSig]
        HRESULT InitializeCustom(/* [size_is][in] __RPC__in_ecount_full(cCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] WICColor[] pColors, /* [in] */ int cCount);
        
        [PreserveSig]
        HRESULT InitializeFromBitmap(/* [in] __RPC__in_opt */ IWICBitmapSource pISurface, /* [in] */ uint cCount, /* [in] */ bool fAddTransparentColor);
        
        [PreserveSig]
        HRESULT InitializeFromPalette(/* [in] __RPC__in_opt */ IWICPalette pIPalette);
        
        [PreserveSig]
        HRESULT GetType(/* [out] __RPC__out */ out WICBitmapPaletteType pePaletteType);
        
        [PreserveSig]
        HRESULT GetColorCount(/* [out] __RPC__out */ out uint pcCount);
        
        [PreserveSig]
        HRESULT GetColors(/* [in] */ int cCount, /* [size_is][out] __RPC__out_ecount_full(cCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] WICColor[] pColors, /* [out] __RPC__out */ out uint pcActualColors);
        
        [PreserveSig]
        HRESULT IsBlackWhite(/* [out] __RPC__out */ out bool pfIsBlackWhite);
        
        [PreserveSig]
        HRESULT IsGrayscale(/* [out] __RPC__out */ out bool pfIsGrayscale);
        
        [PreserveSig]
        HRESULT HasAlpha(/* [out] __RPC__out */ out bool pfHasAlpha);
    }
}
