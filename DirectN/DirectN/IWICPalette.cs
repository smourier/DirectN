using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("00000040-a8f2-4877-ba0a-fd2b6645fb94"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICPalette
    {
        [PreserveSig]
        HRESULT InitializePredefined(WICBitmapPaletteType ePaletteType, bool fAddTransparentColor);

        [PreserveSig]
        HRESULT InitializeCustom([In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] int[] pColors, int cCount);

        [PreserveSig]
        HRESULT InitializeFromBitmap(IWICBitmapSource pISurface, int cCount, bool fAddTransparentColor);

        [PreserveSig]
        HRESULT InitializeFromPalette(IWICPalette pIPalette);

        [PreserveSig]
        HRESULT GetType(out WICBitmapPaletteType pePaletteType);

        [PreserveSig]
        HRESULT GetColorCount(out int pcCount);

        [PreserveSig]
        HRESULT GetColors(int cCount, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] int[] pColors, out int pcActualColors);

        [PreserveSig]
        HRESULT IsBlackWhite(out bool pfIsBlackWhite);

        [PreserveSig]
        HRESULT IsGrayscale(out bool pfIsGrayscale);

        [PreserveSig]
        HRESULT HasAlpha(out bool pfHasAlpha);
    }
}
