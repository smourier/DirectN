﻿// generated from <Windows SDK Path>\um\d2d1svg.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c095e4f4-bb98-43d6-9745-4d1b84ec9888"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1SvgPathData : ID2D1SvgAttribute
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1SvgAttribute
        [PreserveSig]
        new void GetElement(/* _Outptr_result_maybenull_ */ out ID2D1SvgElement element);
        
        [PreserveSig]
        new HRESULT Clone(/* _COM_Outptr_ */ out ID2D1SvgAttribute attribute);
        
        // ID2D1SvgPathData
        [PreserveSig]
        HRESULT RemoveSegmentDataAtEnd(uint dataCount);
        
        [PreserveSig]
        HRESULT UpdateSegmentData(/* _In_reads_(dataCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] float[] data, int dataCount, uint startIndex);
        
        [PreserveSig]
        HRESULT GetSegmentData(/* _Out_writes_(dataCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] float[] data, int dataCount, uint startIndex);
        
        [PreserveSig]
        uint GetSegmentDataCount();
        
        [PreserveSig]
        HRESULT RemoveCommandsAtEnd(uint commandsCount);
        
        [PreserveSig]
        HRESULT UpdateCommands(/* _In_reads_(commandsCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D2D1_SVG_PATH_COMMAND[] commands, int commandsCount, uint startIndex);
        
        [PreserveSig]
        HRESULT GetCommands(/* _Out_writes_(commandsCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D2D1_SVG_PATH_COMMAND[] commands, int commandsCount, uint startIndex);
        
        [PreserveSig]
        uint GetCommandsCount();
        
        [PreserveSig]
        HRESULT CreatePathGeometry(D2D1_FILL_MODE fillMode, /* _COM_Outptr_ */ out ID2D1PathGeometry1 pathGeometry);
    }
}
