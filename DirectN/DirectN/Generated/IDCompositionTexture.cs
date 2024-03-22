// generated from <Windows SDK Path>\um\dcomp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("929bb1aa-725f-433b-abd7-273075a835f2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionTexture
    {
        [PreserveSig]
        HRESULT SetSourceRect(/* THIS_ _In_ */ ref D2D_RECT_U sourceRect);
        
        [PreserveSig]
        HRESULT SetColorSpace(/* THIS_ _In_ */ DXGI_COLOR_SPACE_TYPE colorSpace);
        
        [PreserveSig]
        HRESULT SetAlphaMode(/* THIS_ _In_ */ DXGI_ALPHA_MODE alphaMode);
        
        [PreserveSig]
        HRESULT GetAvailableFence(/* THIS_ _Out_ */ out ulong fenceValue, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid iid, /* _Outptr_result_maybenull_ */ out IntPtr availableFence);
    }
}
