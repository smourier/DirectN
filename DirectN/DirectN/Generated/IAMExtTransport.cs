// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(13040,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("a03cd5f0-3045-11cf-8c44-00aa006b6814"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMExtTransport
    {
        [PreserveSig]
        HRESULT GetCapability(/* [in] */ int Capability, /* [annotation][out] _Out_ */ out long pValue, /* [annotation][out] _Out_ */ out double pdblValue);
        
        [PreserveSig]
        HRESULT put_MediaState(/* [in] */ int State);
        
        [PreserveSig]
        HRESULT get_MediaState(/* [annotation][out] _Out_ */ out long pState);
        
        [PreserveSig]
        HRESULT put_LocalControl(/* [in] */ int State);
        
        [PreserveSig]
        HRESULT get_LocalControl(/* [annotation][out] _Out_ */ out long pState);
        
        [PreserveSig]
        HRESULT GetStatus(/* [in] */ int StatusItem, /* [annotation][out] _Out_ */ out long pValue);
        
        [PreserveSig]
        HRESULT GetTransportBasicParameters(/* [in] */ int Param, /* [annotation][out][in] _Inout_ */ ref long pValue, /* [annotation][out][in] _Inout_ */ out IntPtr ppszData);
        
        [PreserveSig]
        HRESULT SetTransportBasicParameters(/* [in] */ int Param, /* [in] */ int Value, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszData);
        
        [PreserveSig]
        HRESULT GetTransportVideoParameters(/* [in] */ int Param, /* [annotation][out] _Out_ */ out long pValue);
        
        [PreserveSig]
        HRESULT SetTransportVideoParameters(/* [in] */ int Param, /* [in] */ int Value);
        
        [PreserveSig]
        HRESULT GetTransportAudioParameters(/* [in] */ int Param, /* [annotation][out] _Out_ */ out long pValue);
        
        [PreserveSig]
        HRESULT SetTransportAudioParameters(/* [in] */ int Param, /* [in] */ int Value);
        
        [PreserveSig]
        HRESULT put_Mode(/* [in] */ int Mode);
        
        [PreserveSig]
        HRESULT get_Mode(/* [annotation][out] _Out_ */ out long pMode);
        
        [PreserveSig]
        HRESULT put_Rate(/* [in] */ double dblRate);
        
        [PreserveSig]
        HRESULT get_Rate(/* [annotation][out] _Out_ */ out double pdblRate);
        
        [PreserveSig]
        HRESULT GetChase(/* [annotation][out] _Out_ */ out long pEnabled, /* [annotation][out] _Out_ */ out long pOffset, /* [annotation][out] _Out_ */ out IntPtr phEvent);
        
        [PreserveSig]
        HRESULT SetChase(/* [in] */ int Enable, /* [in] */ int Offset, /* [in] */ IntPtr hEvent);
        
        [PreserveSig]
        HRESULT GetBump(/* [annotation][out] _Out_ */ out long pSpeed, /* [annotation][out] _Out_ */ out long pDuration);
        
        [PreserveSig]
        HRESULT SetBump(/* [in] */ int Speed, /* [in] */ int Duration);
        
        [PreserveSig]
        HRESULT get_AntiClogControl(/* [annotation][out] _Out_ */ out long pEnabled);
        
        [PreserveSig]
        HRESULT put_AntiClogControl(/* [in] */ int Enable);
        
        [PreserveSig]
        HRESULT GetEditPropertySet(/* [in] */ int EditID, /* [annotation][out] _Out_ */ out long pState);
        
        [PreserveSig]
        HRESULT SetEditPropertySet(/* [out][in] */ ref long pEditID, /* [in] */ int State);
        
        [PreserveSig]
        HRESULT GetEditProperty(/* [in] */ int EditID, /* [in] */ int Param, /* [annotation][out] _Out_ */ out long pValue);
        
        [PreserveSig]
        HRESULT SetEditProperty(/* [in] */ int EditID, /* [in] */ int Param, /* [in] */ int Value);
        
        [PreserveSig]
        HRESULT get_EditStart(/* [annotation][out] _Out_ */ out long pValue);
        
        [PreserveSig]
        HRESULT put_EditStart(/* [in] */ int Value);
    }
}
