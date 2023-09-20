// generated from <Windows SDK Path>\um\dcompanimation.h
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
