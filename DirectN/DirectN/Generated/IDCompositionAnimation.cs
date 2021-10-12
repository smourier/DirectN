// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dcompanimation.h(93,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("cbfd91d9-51b2-45e4-b3de-d19ccfb863c5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionAnimation
    {
        [PreserveSig]
        HRESULT Reset();
        
        [PreserveSig]
        HRESULT SetAbsoluteBeginTime(long beginTime);
        
        [PreserveSig]
        HRESULT AddCubic(double beginOffset, float constantCoefficient, float linearCoefficient, float quadraticCoefficient, float cubicCoefficient);
        
        [PreserveSig]
        HRESULT AddSinusoidal(double beginOffset, float bias, float amplitude, float frequency, float phase);
        
        [PreserveSig]
        HRESULT AddRepeat(double beginOffset, double durationToRepeat);
        
        [PreserveSig]
        HRESULT End(double endOffset, float endValue);
    }
}
