﻿// generated from <Windows SDK Path>\um\d2d1svg.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("d59bab0a-68a2-455b-a5dc-9eb2854e2490"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1SvgPaint : ID2D1SvgAttribute
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1SvgAttribute
        [PreserveSig]
        new void GetElement(/* _Outptr_result_maybenull_ */ out ID2D1SvgElement element);
        
        [PreserveSig]
        new HRESULT Clone(/* _COM_Outptr_ */ out ID2D1SvgAttribute attribute);
        
        // ID2D1SvgPaint
        [PreserveSig]
        HRESULT SetPaintType(D2D1_SVG_PAINT_TYPE paintType);
        
        [PreserveSig]
        D2D1_SVG_PAINT_TYPE GetPaintType();
        
        [PreserveSig]
        HRESULT SetColor(/* _In_ */ ref _D3DCOLORVALUE color);
        
        [PreserveSig]
        void GetColor(/* _Out_ */ out _D3DCOLORVALUE color);
        
        [PreserveSig]
        HRESULT SetId(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string id);
        
        [PreserveSig]
        HRESULT GetId(/* _Out_writes_(idCount) */ [MarshalAs(UnmanagedType.LPWStr)] string id, uint idCount);
        
        [PreserveSig]
        uint GetIdLength();
    }
}
