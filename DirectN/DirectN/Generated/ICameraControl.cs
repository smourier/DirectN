// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\vidcap.h(391,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("2ba1785d-4d1b-44ef-85e8-c7f1d3f20184"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ICameraControl
    {
        [PreserveSig]
        HRESULT get_Exposure(/* [out] */ out long pValue, /* [out] */ out long pFlags);
        
        [PreserveSig]
        HRESULT put_Exposure(/* [in] */ int Value, /* [in] */ int Flags);
        
        [PreserveSig]
        HRESULT getRange_Exposure(/* [out] */ out long pMin, /* [out] */ out long pMax, /* [out] */ out long pSteppingDelta, /* [out] */ out long pDefault, /* [out] */ out long pCapsFlag);
        
        [PreserveSig]
        HRESULT get_Focus(/* [out] */ out long pValue, /* [out] */ out long pFlags);
        
        [PreserveSig]
        HRESULT put_Focus(/* [in] */ int Value, /* [in] */ int Flags);
        
        [PreserveSig]
        HRESULT getRange_Focus(/* [out] */ out long pMin, /* [out] */ out long pMax, /* [out] */ out long pSteppingDelta, /* [out] */ out long pDefault, /* [out] */ out long pCapsFlag);
        
        [PreserveSig]
        HRESULT get_Iris(/* [out] */ out long pValue, /* [out] */ out long pFlags);
        
        [PreserveSig]
        HRESULT put_Iris(/* [in] */ int Value, /* [in] */ int Flags);
        
        [PreserveSig]
        HRESULT getRange_Iris(/* [out] */ out long pMin, /* [out] */ out long pMax, /* [out] */ out long pSteppingDelta, /* [out] */ out long pDefault, /* [out] */ out long pCapsFlag);
        
        [PreserveSig]
        HRESULT get_Zoom(/* [out] */ out long pValue, /* [out] */ out long pFlags);
        
        [PreserveSig]
        HRESULT put_Zoom(/* [in] */ int Value, /* [in] */ int Flags);
        
        [PreserveSig]
        HRESULT getRange_Zoom(/* [out] */ out long pMin, /* [out] */ out long pMax, /* [out] */ out long pSteppingDelta, /* [out] */ out long pDefault, /* [out] */ out long pCapsFlag);
        
        [PreserveSig]
        HRESULT get_FocalLengths(/* [out] */ out long plOcularFocalLength, /* [out] */ out long plObjectiveFocalLengthMin, /* [out] */ out long plObjectiveFocalLengthMax);
        
        [PreserveSig]
        HRESULT get_Pan(/* [out] */ out long pValue, /* [out] */ out long pFlags);
        
        [PreserveSig]
        HRESULT put_Pan(/* [in] */ int Value, /* [in] */ int Flags);
        
        [PreserveSig]
        HRESULT getRange_Pan(/* [out] */ out long pMin, /* [out] */ out long pMax, /* [out] */ out long pSteppingDelta, /* [out] */ out long pDefault, /* [out] */ out long pCapsFlag);
        
        [PreserveSig]
        HRESULT get_Tilt(/* [out] */ out long pValue, /* [out] */ out long pFlags);
        
        [PreserveSig]
        HRESULT put_Tilt(/* [in] */ int Value, /* [in] */ int Flags);
        
        [PreserveSig]
        HRESULT getRange_Tilt(/* [out] */ out long pMin, /* [out] */ out long pMax, /* [out] */ out long pSteppingDelta, /* [out] */ out long pDefault, /* [out] */ out long pCapsFlag);
        
        [PreserveSig]
        HRESULT get_PanTilt(/* [out] */ out long pPanValue, /* [out] */ out long pTiltValue, /* [out] */ out long pFlags);
        
        [PreserveSig]
        HRESULT put_PanTilt(/* [in] */ int PanValue, /* [in] */ int TiltValue, /* [in] */ int Flags);
        
        [PreserveSig]
        HRESULT get_Roll(/* [out] */ out long pValue, /* [out] */ out long pFlags);
        
        [PreserveSig]
        HRESULT put_Roll(/* [in] */ int Value, /* [in] */ int Flags);
        
        [PreserveSig]
        HRESULT getRange_Roll(/* [out] */ out long pMin, /* [out] */ out long pMax, /* [out] */ out long pSteppingDelta, /* [out] */ out long pDefault, /* [out] */ out long pCapsFlag);
        
        [PreserveSig]
        HRESULT get_ExposureRelative(/* [out] */ out long pValue, /* [out] */ out long pFlags);
        
        [PreserveSig]
        HRESULT put_ExposureRelative(/* [in] */ int Value, /* [in] */ int Flags);
        
        [PreserveSig]
        HRESULT getRange_ExposureRelative(/* [out] */ out long pMin, /* [out] */ out long pMax, /* [out] */ out long pSteppingDelta, /* [out] */ out long pDefault, /* [out] */ out long pCapsFlag);
        
        [PreserveSig]
        HRESULT get_FocusRelative(/* [out] */ out long pValue, /* [out] */ out long pFlags);
        
        [PreserveSig]
        HRESULT put_FocusRelative(/* [in] */ int Value, /* [in] */ int Flags);
        
        [PreserveSig]
        HRESULT getRange_FocusRelative(/* [out] */ out long pMin, /* [out] */ out long pMax, /* [out] */ out long pSteppingDelta, /* [out] */ out long pDefault, /* [out] */ out long pCapsFlag);
        
        [PreserveSig]
        HRESULT get_IrisRelative(/* [out] */ out long pValue, /* [out] */ out long pFlags);
        
        [PreserveSig]
        HRESULT put_IrisRelative(/* [in] */ int Value, /* [in] */ int Flags);
        
        [PreserveSig]
        HRESULT getRange_IrisRelative(/* [out] */ out long pMin, /* [out] */ out long pMax, /* [out] */ out long pSteppingDelta, /* [out] */ out long pDefault, /* [out] */ out long pCapsFlag);
        
        [PreserveSig]
        HRESULT get_ZoomRelative(/* [out] */ out long pValue, /* [out] */ out long pFlags);
        
        [PreserveSig]
        HRESULT put_ZoomRelative(/* [in] */ int Value, /* [in] */ int Flags);
        
        [PreserveSig]
        HRESULT getRange_ZoomRelative(/* [out] */ out long pMin, /* [out] */ out long pMax, /* [out] */ out long pSteppingDelta, /* [out] */ out long pDefault, /* [out] */ out long pCapsFlag);
        
        [PreserveSig]
        HRESULT get_PanRelative(/* [out] */ out long pValue, /* [out] */ out long pFlags);
        
        [PreserveSig]
        HRESULT put_PanRelative(/* [in] */ int Value, /* [in] */ int Flags);
        
        [PreserveSig]
        HRESULT get_TiltRelative(/* [out] */ out long pValue, /* [out] */ out long pFlags);
        
        [PreserveSig]
        HRESULT put_TiltRelative(/* [in] */ int Value, /* [in] */ int Flags);
        
        [PreserveSig]
        HRESULT getRange_TiltRelative(/* [out] */ out long pMin, /* [out] */ out long pMax, /* [out] */ out long pSteppingDelta, /* [out] */ out long pDefault, /* [out] */ out long pCapsFlag);
        
        [PreserveSig]
        HRESULT get_PanTiltRelative(/* [out] */ out long pPanValue, /* [out] */ out long pTiltValue, /* [out] */ out long pFlags);
        
        [PreserveSig]
        HRESULT put_PanTiltRelative(/* [in] */ int PanValue, /* [in] */ int TiltValue, /* [in] */ int Flags);
        
        [PreserveSig]
        HRESULT getRange_PanRelative(/* [out] */ out long pMin, /* [out] */ out long pMax, /* [out] */ out long pSteppingDelta, /* [out] */ out long pDefault, /* [out] */ out long pCapsFlag);
        
        [PreserveSig]
        HRESULT get_RollRelative(/* [out] */ out long pValue, /* [out] */ out long pFlags);
        
        [PreserveSig]
        HRESULT put_RollRelative(/* [in] */ int Value, /* [in] */ int Flags);
        
        [PreserveSig]
        HRESULT getRange_RollRelative(/* [out] */ out long pMin, /* [out] */ out long pMax, /* [out] */ out long pSteppingDelta, /* [out] */ out long pDefault, /* [out] */ out long pCapsFlag);
        
        [PreserveSig]
        HRESULT get_ScanMode(/* [out] */ out long pValue, /* [out] */ out long pFlags);
        
        [PreserveSig]
        HRESULT put_ScanMode(/* [in] */ int Value, /* [in] */ int Flags);
        
        [PreserveSig]
        HRESULT get_PrivacyMode(/* [out] */ out long pValue, /* [out] */ out long pFlags);
        
        [PreserveSig]
        HRESULT put_PrivacyMode(/* [in] */ int Value, /* [in] */ int Flags);
    }
}
