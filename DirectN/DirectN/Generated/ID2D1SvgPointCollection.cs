﻿// generated from <Windows SDK Path>\um\d2d1svg.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("9dbe4c0d-3572-4dd9-9825-5530813bb712"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1SvgPointCollection : ID2D1SvgAttribute
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1SvgAttribute
        [PreserveSig]
        new void GetElement(/* _Outptr_result_maybenull_ */ out ID2D1SvgElement element);
        
        [PreserveSig]
        new HRESULT Clone(/* _COM_Outptr_ */ out ID2D1SvgAttribute attribute);
        
        // ID2D1SvgPointCollection
        [PreserveSig]
        HRESULT RemovePointsAtEnd(uint pointsCount);
        
        [PreserveSig]
        HRESULT UpdatePoints(/* _In_reads_(pointsCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D2D_POINT_2F[] points, int pointsCount, uint startIndex);
        
        [PreserveSig]
        HRESULT GetPoints(/* _Out_writes_(pointsCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D2D_POINT_2F[] points, int pointsCount, uint startIndex);
        
        [PreserveSig]
        uint GetPointsCount();
    }
}
