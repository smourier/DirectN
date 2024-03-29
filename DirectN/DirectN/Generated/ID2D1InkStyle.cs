﻿// generated from <Windows SDK Path>\um\d2d1_3.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("bae8b344-23fc-4071-8cb5-d05d6f073848"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1InkStyle : ID2D1Resource
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1InkStyle
        [PreserveSig]
        void SetNibTransform(/* _In_ */ ref D2D_MATRIX_3X2_F transform);
        
        [PreserveSig]
        void GetNibTransform(/* _Out_ */ out D2D_MATRIX_3X2_F transform);
        
        [PreserveSig]
        void SetNibShape(D2D1_INK_NIB_SHAPE nibShape);
        
        [PreserveSig]
        D2D1_INK_NIB_SHAPE GetNibShape();
    }
}
