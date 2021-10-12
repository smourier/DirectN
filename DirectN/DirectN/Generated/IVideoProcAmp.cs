// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\vidcap.h(1246,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("4050560e-42a7-413a-85c2-09269a2d0f44"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IVideoProcAmp
    {
        [PreserveSig]
        HRESULT get_BacklightCompensation(/* [out] */ out long pValue, /* [out] */ out long pFlags);
        
        [PreserveSig]
        HRESULT put_BacklightCompensation(/* [in] */ int Value, /* [in] */ int Flags);
        
        [PreserveSig]
        HRESULT getRange_BacklightCompensation(/* [out] */ out long pMin, /* [out] */ out long pMax, /* [out] */ out long pSteppingDelta, /* [out] */ out long pDefault, /* [out] */ out long pCapsFlag);
        
        [PreserveSig]
        HRESULT get_Brightness(/* [out] */ out long pValue, /* [out] */ out long pFlags);
        
        [PreserveSig]
        HRESULT put_Brightness(/* [in] */ int Value, /* [in] */ int Flags);
        
        [PreserveSig]
        HRESULT getRange_Brightness(/* [out] */ out long pMin, /* [out] */ out long pMax, /* [out] */ out long pSteppingDelta, /* [out] */ out long pDefault, /* [out] */ out long pCapsFlag);
        
        [PreserveSig]
        HRESULT get_ColorEnable(/* [out] */ out long pValue, /* [out] */ out long pFlags);
        
        [PreserveSig]
        HRESULT put_ColorEnable(/* [in] */ int Value, /* [in] */ int Flags);
        
        [PreserveSig]
        HRESULT getRange_ColorEnable(/* [out] */ out long pMin, /* [out] */ out long pMax, /* [out] */ out long pSteppingDelta, /* [out] */ out long pDefault, /* [out] */ out long pCapsFlag);
        
        [PreserveSig]
        HRESULT get_Contrast(/* [out] */ out long pValue, /* [out] */ out long pFlags);
        
        [PreserveSig]
        HRESULT put_Contrast(/* [in] */ int Value, /* [in] */ int Flags);
        
        [PreserveSig]
        HRESULT getRange_Contrast(/* [out] */ out long pMin, /* [out] */ out long pMax, /* [out] */ out long pSteppingDelta, /* [out] */ out long pDefault, /* [out] */ out long pCapsFlag);
        
        [PreserveSig]
        HRESULT get_Gamma(/* [out] */ out long pValue, /* [out] */ out long pFlags);
        
        [PreserveSig]
        HRESULT put_Gamma(/* [in] */ int Value, /* [in] */ int Flags);
        
        [PreserveSig]
        HRESULT getRange_Gamma(/* [out] */ out long pMin, /* [out] */ out long pMax, /* [out] */ out long pSteppingDelta, /* [out] */ out long pDefault, /* [out] */ out long pCapsFlag);
        
        [PreserveSig]
        HRESULT get_Saturation(/* [out] */ out long pValue, /* [out] */ out long pFlags);
        
        [PreserveSig]
        HRESULT put_Saturation(/* [in] */ int Value, /* [in] */ int Flags);
        
        [PreserveSig]
        HRESULT getRange_Saturation(/* [out] */ out long pMin, /* [out] */ out long pMax, /* [out] */ out long pSteppingDelta, /* [out] */ out long pDefault, /* [out] */ out long pCapsFlag);
        
        [PreserveSig]
        HRESULT get_Sharpness(/* [out] */ out long pValue, /* [out] */ out long pFlags);
        
        [PreserveSig]
        HRESULT put_Sharpness(/* [in] */ int Value, /* [in] */ int Flags);
        
        [PreserveSig]
        HRESULT getRange_Sharpness(/* [out] */ out long pMin, /* [out] */ out long pMax, /* [out] */ out long pSteppingDelta, /* [out] */ out long pDefault, /* [out] */ out long pCapsFlag);
        
        [PreserveSig]
        HRESULT get_WhiteBalance(/* [out] */ out long pValue, /* [out] */ out long pFlags);
        
        [PreserveSig]
        HRESULT put_WhiteBalance(/* [in] */ int Value, /* [in] */ int Flags);
        
        [PreserveSig]
        HRESULT getRange_WhiteBalance(/* [out] */ out long pMin, /* [out] */ out long pMax, /* [out] */ out long pSteppingDelta, /* [out] */ out long pDefault, /* [out] */ out long pCapsFlag);
        
        [PreserveSig]
        HRESULT get_Gain(/* [out] */ out long pValue, /* [out] */ out long pFlags);
        
        [PreserveSig]
        HRESULT put_Gain(/* [in] */ int Value, /* [in] */ int Flags);
        
        [PreserveSig]
        HRESULT getRange_Gain(/* [out] */ out long pMin, /* [out] */ out long pMax, /* [out] */ out long pSteppingDelta, /* [out] */ out long pDefault, /* [out] */ out long pCapsFlag);
        
        [PreserveSig]
        HRESULT get_Hue(/* [out] */ out long pValue, /* [out] */ out long pFlags);
        
        [PreserveSig]
        HRESULT put_Hue(/* [in] */ int Value, /* [in] */ int Flags);
        
        [PreserveSig]
        HRESULT getRange_Hue(/* [out] */ out long pMin, /* [out] */ out long pMax, /* [out] */ out long pSteppingDelta, /* [out] */ out long pDefault, /* [out] */ out long pCapsFlag);
        
        [PreserveSig]
        HRESULT get_DigitalMultiplier(/* [out] */ out long pValue, /* [out] */ out long pFlags);
        
        [PreserveSig]
        HRESULT put_DigitalMultiplier(/* [in] */ int Value, /* [in] */ int Flags);
        
        [PreserveSig]
        HRESULT getRange_DigitalMultiplier(/* [out] */ out long pMin, /* [out] */ out long pMax, /* [out] */ out long pSteppingDelta, /* [out] */ out long pDefault, /* [out] */ out long pCapsFlag);
        
        [PreserveSig]
        HRESULT get_PowerlineFrequency(/* [out] */ out long pValue, /* [out] */ out long pFlags);
        
        [PreserveSig]
        HRESULT put_PowerlineFrequency(/* [in] */ int Value, /* [in] */ int Flags);
        
        [PreserveSig]
        HRESULT getRange_PowerlineFrequency(/* [out] */ out long pMin, /* [out] */ out long pMax, /* [out] */ out long pSteppingDelta, /* [out] */ out long pDefault, /* [out] */ out long pCapsFlag);
        
        [PreserveSig]
        HRESULT get_WhiteBalanceComponent(/* [out] */ out long pValue1, /* [out] */ out long pValue2, /* [out][in] */ ref long pFlags);
        
        [PreserveSig]
        HRESULT put_WhiteBalanceComponent(/* [in] */ int Value1, /* [in] */ int Value2, /* [in] */ int Flags);
        
        [PreserveSig]
        HRESULT getRange_WhiteBalanceComponent(/* [out] */ out long pMin, /* [out] */ out long pMax, /* [out] */ out long pSteppingDelta, /* [out] */ out long pDefault, /* [out][in] */ ref long pCapsFlag);
    }
}
