// generated from <Windows SDK Path>\um\d2d1svg.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Interface describing an SVG attribute.
    /// </summary>
    [ComImport, Guid("c9cdb0dd-f8c9-4e70-b7c2-301c80292c5e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1SvgAttribute : ID2D1Resource
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1SvgAttribute
        [PreserveSig]
        void GetElement(/* _Outptr_result_maybenull_ */ out ID2D1SvgElement element);
        
        [PreserveSig]
        HRESULT Clone(/* _COM_Outptr_ */ out ID2D1SvgAttribute attribute);
    }
}
