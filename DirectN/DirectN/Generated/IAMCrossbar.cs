// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(10885,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c6e13380-30ac-11d0-a18c-00a0c9118956"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMCrossbar
    {
        [PreserveSig]
        HRESULT get_PinCounts(/* [annotation][out] _Out_ */ out long OutputPinCount, /* [annotation][out] _Out_ */ out long InputPinCount);
        
        [PreserveSig]
        HRESULT CanRoute(/* [in] */ int OutputPinIndex, /* [in] */ int InputPinIndex);
        
        [PreserveSig]
        HRESULT Route(/* [in] */ int OutputPinIndex, /* [in] */ int InputPinIndex);
        
        [PreserveSig]
        HRESULT get_IsRoutedTo(/* [in] */ int OutputPinIndex, /* [annotation][out] _Out_ */ out long InputPinIndex);
        
        [PreserveSig]
        HRESULT get_CrossbarPinInfo(/* [in] */ bool IsInputPin, /* [in] */ int PinIndex, /* [annotation][out] _Out_ */ out long PinIndexRelated, /* [annotation][out] _Out_ */ out long PhysicalType);
    }
}
