using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("fbec5e44-f7be-4b65-b7f8-c0c81fef026d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICDevelopRaw : IWICBitmapFrameDecode
    {
        // IWICBitmapSource
        [PreserveSig]
        new HRESULT GetSize(out int puiWidth, out int puiHeight);

        [PreserveSig]
        new HRESULT GetPixelFormat(out Guid pPixelFormat);

        [PreserveSig]
        new HRESULT GetResolution(out double pDpiX, out double pDpiY);

        [PreserveSig]
        new HRESULT CopyPalette(IWICPalette pIPalette);

        [PreserveSig]
        new HRESULT CopyPixels(WICRect prc, int cbStride, int cbBufferSize, IntPtr pbBuffer);

        // IWICBitmapFrameDecode
        [PreserveSig]
        new HRESULT GetMetadataQueryReader(out IWICMetadataQueryReader ppIMetadataQueryReader);

        [PreserveSig]
        new HRESULT GetColorContexts(int cCount, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] IWICColorContext[] pIColorContexts, out int pcActualCount);

        [PreserveSig]
        new HRESULT GetThumbnail(out IWICBitmapSource ppIThumbnail);

        // IWICDevelopRaw
        [PreserveSig]
        HRESULT QueryRawCapabilitiesInfo(ref WICRawCapabilitiesInfo pInfo);

        [PreserveSig]
        HRESULT LoadParameterSet(WICRawParameterSet ParameterSet);

        [PreserveSig]
        HRESULT GetCurrentParameterSet(out IPropertyBag2 ppCurrentParameterSet);

        [PreserveSig]
        HRESULT SetExposureCompensation(double ev);

        [PreserveSig]
        HRESULT GetExposureCompensation(out double pEV);

        [PreserveSig]
        HRESULT SetWhitePointRGB(int Red, int Green, int Blue);

        [PreserveSig]
        HRESULT GetWhitePointRGB(out int pRed, out int pGreen, out int pBlue);

        [PreserveSig]
        HRESULT SetNamedWhitePoint(WICNamedWhitePoint WhitePoint);

        [PreserveSig]
        HRESULT GetNamedWhitePoint(out WICNamedWhitePoint pWhitePoint);

        [PreserveSig]
        HRESULT SetWhitePointKelvin(int WhitePointKelvin);

        [PreserveSig]
        HRESULT GetWhitePointKelvin(out int pWhitePointKelvin);

        [PreserveSig]
        HRESULT GetKelvinRangeInfo(out int pMinKelvinTemp, out int pMaxKelvinTemp, out int pKelvinTempStepValue);

        [PreserveSig]
        HRESULT SetContrast(double Contrast);

        [PreserveSig]
        HRESULT GetContrast(out double pContrast);

        [PreserveSig]
        HRESULT SetGamma(double Gamma);

        [PreserveSig]
        HRESULT GetGamma(out double pGamma);

        [PreserveSig]
        HRESULT SetSharpness(double Sharpness);

        [PreserveSig]
        HRESULT GetSharpness(out double pSharpness);

        [PreserveSig]
        HRESULT SetSaturation(double Saturation);

        [PreserveSig]
        HRESULT GetSaturation(out double pSaturation);

        [PreserveSig]
        HRESULT SetTint(double Tint);

        [PreserveSig]
        HRESULT GetTint(out double pTint);

        [PreserveSig]
        HRESULT SetNoiseReduction(double NoiseReduction);

        [PreserveSig]
        HRESULT GetNoiseReduction(out double pNoiseReduction);

        [PreserveSig]
        HRESULT SetDestinationColorContext(IWICColorContext pColorContext);

        [PreserveSig]
        HRESULT SetToneCurve(int cbToneCurveSize, IntPtr pToneCurve);

        [PreserveSig]
        HRESULT GetToneCurve(int cbToneCurveBufferSize, IntPtr pToneCurve, out int pcbActualToneCurveBufferSize);

        [PreserveSig]
        HRESULT SetRotation(double Rotation);

        [PreserveSig]
        HRESULT GetRotation(out double pRotation);

        [PreserveSig]
        HRESULT SetRenderMode(WICRawRenderMode RenderMode);

        [PreserveSig]
        HRESULT GetRenderMode(out WICRawRenderMode pRenderMode);

        [PreserveSig]
        HRESULT SetNotificationCallback(IWICDevelopRawNotificationCallback pCallback);
    }
}
