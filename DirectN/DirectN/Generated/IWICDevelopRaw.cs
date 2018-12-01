// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wincodec.h(7260,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("fbec5e44-f7be-4b65-b7f8-c0c81fef026d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICDevelopRaw : IWICBitmapFrameDecode
    {
        // IWICBitmapSource
        [PreserveSig]
        new HRESULT GetSize(/* [out] __RPC__out */ out uint puiWidth, /* [out] __RPC__out */ out uint puiHeight);
        
        [PreserveSig]
        new HRESULT GetPixelFormat(/* [out] __RPC__out */ out Guid pPixelFormat);
        
        [PreserveSig]
        new HRESULT GetResolution(/* [out] __RPC__out */ out double pDpiX, /* [out] __RPC__out */ out double pDpiY);
        
        [PreserveSig]
        new HRESULT CopyPalette(/* [in] __RPC__in_opt */ IWICPalette pIPalette);
        
        [PreserveSig]
        new HRESULT CopyPixels(/* [unique][in] __RPC__in_opt */ ref WICRect prc, /* [in] */ uint cbStride, /* [in] */ uint cbBufferSize, /* [size_is][out] __RPC__out_ecount_full(cbBufferSize) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] pbBuffer);
        
        // IWICBitmapFrameDecode
        [PreserveSig]
        new HRESULT GetMetadataQueryReader(/* [out] __RPC__deref_out_opt */ out IWICMetadataQueryReader ppIMetadataQueryReader);
        
        [PreserveSig]
        new HRESULT GetColorContexts(/* [in] */ uint cCount, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cCount) */ out IWICColorContext[] ppIColorContexts, /* [out] __RPC__out */ out uint pcActualCount);
        
        [PreserveSig]
        new HRESULT GetThumbnail(/* [out] __RPC__deref_out_opt */ out IWICBitmapSource ppIThumbnail);
        
        // IWICDevelopRaw
        [PreserveSig]
        HRESULT QueryRawCapabilitiesInfo(/* [out][in] */ ref WICRawCapabilitiesInfo pInfo);
        
        [PreserveSig]
        HRESULT LoadParameterSet(/* [in] */ WICRawParameterSet ParameterSet);
        
        [PreserveSig]
        HRESULT GetCurrentParameterSet(/* [out] __RPC__deref_out_opt */ out IPropertyBag2 ppCurrentParameterSet);
        
        [PreserveSig]
        HRESULT SetExposureCompensation(/* [in] */ double ev);
        
        [PreserveSig]
        HRESULT GetExposureCompensation(/* [out] __RPC__out */ out double pEV);
        
        [PreserveSig]
        HRESULT SetWhitePointRGB(/* [in] */ uint Red, /* [in] */ uint Green, /* [in] */ uint Blue);
        
        [PreserveSig]
        HRESULT GetWhitePointRGB(/* [out] __RPC__out */ out uint pRed, /* [out] __RPC__out */ out uint pGreen, /* [out] __RPC__out */ out uint pBlue);
        
        [PreserveSig]
        HRESULT SetNamedWhitePoint(/* [in] */ WICNamedWhitePoint WhitePoint);
        
        [PreserveSig]
        HRESULT GetNamedWhitePoint(/* [out] __RPC__out */ out WICNamedWhitePoint pWhitePoint);
        
        [PreserveSig]
        HRESULT SetWhitePointKelvin(/* [in] */ uint WhitePointKelvin);
        
        [PreserveSig]
        HRESULT GetWhitePointKelvin(/* [out] __RPC__out */ out uint pWhitePointKelvin);
        
        [PreserveSig]
        HRESULT GetKelvinRangeInfo(/* [out] __RPC__out */ out uint pMinKelvinTemp, /* [out] __RPC__out */ out uint pMaxKelvinTemp, /* [out] __RPC__out */ out uint pKelvinTempStepValue);
        
        [PreserveSig]
        HRESULT SetContrast(/* [in] */ double Contrast);
        
        [PreserveSig]
        HRESULT GetContrast(/* [out] __RPC__out */ out double pContrast);
        
        [PreserveSig]
        HRESULT SetGamma(/* [in] */ double Gamma);
        
        [PreserveSig]
        HRESULT GetGamma(/* [out] __RPC__out */ out double pGamma);
        
        [PreserveSig]
        HRESULT SetSharpness(/* [in] */ double Sharpness);
        
        [PreserveSig]
        HRESULT GetSharpness(/* [out] __RPC__out */ out double pSharpness);
        
        [PreserveSig]
        HRESULT SetSaturation(/* [in] */ double Saturation);
        
        [PreserveSig]
        HRESULT GetSaturation(/* [out] __RPC__out */ out double pSaturation);
        
        [PreserveSig]
        HRESULT SetTint(/* [in] */ double Tint);
        
        [PreserveSig]
        HRESULT GetTint(/* [out] __RPC__out */ out double pTint);
        
        [PreserveSig]
        HRESULT SetNoiseReduction(/* [in] */ double NoiseReduction);
        
        [PreserveSig]
        HRESULT GetNoiseReduction(/* [out] __RPC__out */ out double pNoiseReduction);
        
        [PreserveSig]
        HRESULT SetDestinationColorContext(/* [unique][in] __RPC__in_opt */ IWICColorContext pColorContext);
        
        [PreserveSig]
        HRESULT SetToneCurve(/* [in] */ uint cbToneCurveSize, /* [annotation][in] _In_reads_bytes_(cbToneCurveSize) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] WICRawToneCurve[] pToneCurve);
        
        [PreserveSig]
        HRESULT GetToneCurve(/* [in] */ uint cbToneCurveBufferSize, /* [annotation][unique][out] _Out_writes_bytes_to_opt_(cbToneCurveBufferSize, *pcbActualToneCurveBufferSize) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] WICRawToneCurve[] pToneCurve, /* [annotation][unique][out] _Inout_opt_ */ ref uint pcbActualToneCurveBufferSize);
        
        [PreserveSig]
        HRESULT SetRotation(/* [in] */ double Rotation);
        
        [PreserveSig]
        HRESULT GetRotation(/* [out] __RPC__out */ out double pRotation);
        
        [PreserveSig]
        HRESULT SetRenderMode(/* [in] */ WICRawRenderMode RenderMode);
        
        [PreserveSig]
        HRESULT GetRenderMode(/* [out] __RPC__out */ out WICRawRenderMode pRenderMode);
        
        [PreserveSig]
        HRESULT SetNotificationCallback(/* [unique][in] __RPC__in_opt */ IWICDevelopRawNotificationCallback pCallback);
    }
}
