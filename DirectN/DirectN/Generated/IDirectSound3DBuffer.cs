// generated from <Windows SDK Path>\um\dsound.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("279afa86-4981-11ce-a521-0020af0be560"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectSound3DBuffer
    {
        [PreserveSig]
        HRESULT GetAllParameters(/* THIS_ _Out_ */ out _DS3DBUFFER pDs3dBuffer);
        
        [PreserveSig]
        HRESULT GetConeAngles(/* THIS_ _Out_ */ out uint pdwInsideConeAngle, /* _Out_ */ out uint pdwOutsideConeAngle);
        
        [PreserveSig]
        HRESULT GetConeOrientation(/* THIS_ _Out_ */ out _D3DVECTOR pvOrientation);
        
        [PreserveSig]
        HRESULT GetConeOutsideVolume(/* THIS_ _Out_ */ out int plConeOutsideVolume);
        
        [PreserveSig]
        HRESULT GetMaxDistance(/* THIS_ _Out_ */ out float pflMaxDistance);
        
        [PreserveSig]
        HRESULT GetMinDistance(/* THIS_ _Out_ */ out float pflMinDistance);
        
        [PreserveSig]
        HRESULT GetMode(/* THIS_ _Out_ */ out uint pdwMode);
        
        [PreserveSig]
        HRESULT GetPosition(/* THIS_ _Out_ */ out _D3DVECTOR pvPosition);
        
        [PreserveSig]
        HRESULT GetVelocity(/* THIS_ _Out_ */ out _D3DVECTOR pvVelocity);
        
        [PreserveSig]
        HRESULT SetAllParameters(/* THIS_ _In_ */ ref _DS3DBUFFER pcDs3dBuffer, uint dwApply);
        
        [PreserveSig]
        HRESULT SetConeAngles(uint dwInsideConeAngle, uint dwOutsideConeAngle, uint dwApply);
        
        [PreserveSig]
        HRESULT SetConeOrientation(float x, float y, float z, uint dwApply);
        
        [PreserveSig]
        HRESULT SetConeOutsideVolume(int lConeOutsideVolume, uint dwApply);
        
        [PreserveSig]
        HRESULT SetMaxDistance(float flMaxDistance, uint dwApply);
        
        [PreserveSig]
        HRESULT SetMinDistance(float flMinDistance, uint dwApply);
        
        [PreserveSig]
        HRESULT SetMode(uint dwMode, uint dwApply);
        
        [PreserveSig]
        HRESULT SetPosition(float x, float y, float z, uint dwApply);
        
        [PreserveSig]
        HRESULT SetVelocity(float x, float y, float z, uint dwApply);
    }
}
