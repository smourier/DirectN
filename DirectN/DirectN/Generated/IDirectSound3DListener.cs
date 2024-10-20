// generated from <Windows SDK Path>\um\dsound.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("279afa84-4981-11ce-a521-0020af0be560"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectSound3DListener
    {
        [PreserveSig]
        HRESULT GetAllParameters(/* THIS_ _Out_ */ out _DS3DLISTENER pListener);
        
        [PreserveSig]
        HRESULT GetDistanceFactor(/* THIS_ _Out_ */ out float pflDistanceFactor);
        
        [PreserveSig]
        HRESULT GetDopplerFactor(/* THIS_ _Out_ */ out float pflDopplerFactor);
        
        [PreserveSig]
        HRESULT GetOrientation(/* THIS_ _Out_ */ out _D3DVECTOR pvOrientFront, /* _Out_ */ out _D3DVECTOR pvOrientTop);
        
        [PreserveSig]
        HRESULT GetPosition(/* THIS_ _Out_ */ out _D3DVECTOR pvPosition);
        
        [PreserveSig]
        HRESULT GetRolloffFactor(/* THIS_ _Out_ */ out float pflRolloffFactor);
        
        [PreserveSig]
        HRESULT GetVelocity(/* THIS_ _Out_ */ out _D3DVECTOR pvVelocity);
        
        [PreserveSig]
        HRESULT SetAllParameters(/* THIS_ _In_ */ ref _DS3DLISTENER pcListener, uint dwApply);
        
        [PreserveSig]
        HRESULT SetDistanceFactor(float flDistanceFactor, uint dwApply);
        
        [PreserveSig]
        HRESULT SetDopplerFactor(float flDopplerFactor, uint dwApply);
        
        [PreserveSig]
        HRESULT SetOrientation(float xFront, float yFront, float zFront, float xTop, float yTop, float zTop, uint dwApply);
        
        [PreserveSig]
        HRESULT SetPosition(float x, float y, float z, uint dwApply);
        
        [PreserveSig]
        HRESULT SetRolloffFactor(float flRolloffFactor, uint dwApply);
        
        [PreserveSig]
        HRESULT SetVelocity(float x, float y, float z, uint dwApply);
        
        [PreserveSig]
        HRESULT CommitDeferredSettings();
    }
}
