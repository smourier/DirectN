// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1svg.h(700,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Interface describing an SVG 'stroke-dasharray' value.
    /// </summary>
    [ComImport, Guid("f1c0ca52-92a3-4f00-b4ce-f35691efd9d9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1SvgStrokeDashArray : ID2D1SvgAttribute
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1SvgAttribute
        [PreserveSig]
        new void GetElement(/* _Outptr_result_maybenull_ */ out ID2D1SvgElement element);
        
        [PreserveSig]
        new HRESULT Clone(/* _COM_Outptr_ */ out ID2D1SvgAttribute attribute);
        
        // ID2D1SvgStrokeDashArray
        [PreserveSig]
        HRESULT RemoveDashesAtEnd(uint dashesCount);
        
        [PreserveSig]
        HRESULT UpdateDashes(/* _In_reads_(dashesCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D2D1_SVG_LENGTH[] dashes, int dashesCount, uint startIndex);
        
        [PreserveSig]
        HRESULT UpdateDashes(/* _In_reads_(dashesCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] float[] dashes, int dashesCount, uint startIndex);
        
        [PreserveSig]
        HRESULT GetDashes(/* _Out_writes_(dashesCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D2D1_SVG_LENGTH[] dashes, int dashesCount, uint startIndex);
        
        [PreserveSig]
        HRESULT GetDashes(/* _Out_writes_(dashesCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] float[] dashes, int dashesCount, uint startIndex);
        
        [PreserveSig]
        uint GetDashesCount();
    }
}
