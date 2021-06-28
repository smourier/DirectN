// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1svg.h(931,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Interface for all SVG elements.
    /// </summary>
    [ComImport, Guid("ac7b67a6-183e-49c1-a823-0ebe40b0db29"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1SvgElement : ID2D1Resource
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1SvgElement
        [PreserveSig]
        void GetDocument(/* _Outptr_result_maybenull_ */ out ID2D1SvgDocument document);
        
        [PreserveSig]
        HRESULT GetTagName(/* _Out_writes_(nameCount) */ [MarshalAs(UnmanagedType.LPWStr)] string name, uint nameCount);
        
        [PreserveSig]
        uint GetTagNameLength();
        
        [PreserveSig]
        bool IsTextContent();
        
        [PreserveSig]
        void GetParent(/* _Outptr_result_maybenull_ */ out ID2D1SvgElement parent);
        
        [PreserveSig]
        bool HasChildren();
        
        [PreserveSig]
        void GetFirstChild(/* _Outptr_result_maybenull_ */ out ID2D1SvgElement child);
        
        [PreserveSig]
        void GetLastChild(/* _Outptr_result_maybenull_ */ out ID2D1SvgElement child);
        
        [PreserveSig]
        HRESULT GetPreviousChild(/* _In_ */ ID2D1SvgElement referenceChild, /* _COM_Outptr_result_maybenull_ */ out ID2D1SvgElement previousChild);
        
        [PreserveSig]
        HRESULT GetNextChild(/* _In_ */ ID2D1SvgElement referenceChild, /* _COM_Outptr_result_maybenull_ */ out ID2D1SvgElement nextChild);
        
        [PreserveSig]
        HRESULT InsertChildBefore(/* _In_ */ ID2D1SvgElement newChild, /* _In_opt_ */ ID2D1SvgElement referenceChild);
        
        [PreserveSig]
        HRESULT AppendChild(/* _In_ */ ID2D1SvgElement newChild);
        
        [PreserveSig]
        HRESULT ReplaceChild(/* _In_ */ ID2D1SvgElement newChild, /* _In_ */ ID2D1SvgElement oldChild);
        
        [PreserveSig]
        HRESULT RemoveChild(/* _In_ */ ID2D1SvgElement oldChild);
        
        [PreserveSig]
        HRESULT CreateChild(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string tagName, /* _COM_Outptr_ */ out ID2D1SvgElement newChild);
        
        [PreserveSig]
        bool IsAttributeSpecified(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string name, /* optional(BOOL) */ IntPtr inherited);
        
        [PreserveSig]
        uint GetSpecifiedAttributeCount();
        
        [PreserveSig]
        HRESULT GetSpecifiedAttributeName(uint index, /* _Out_writes_(nameCount) */ [MarshalAs(UnmanagedType.LPWStr)] string name, uint nameCount, /* optional(BOOL) */ IntPtr inherited);
        
        [PreserveSig]
        HRESULT GetSpecifiedAttributeNameLength(uint index, /* _Out_ */ out uint nameLength, /* optional(BOOL) */ IntPtr inherited);
        
        [PreserveSig]
        HRESULT RemoveAttribute(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string name);
        
        [PreserveSig]
        HRESULT SetTextValue(/* _In_reads_(nameCount) */ [MarshalAs(UnmanagedType.LPWStr)] string name, uint nameCount);
        
        [PreserveSig]
        HRESULT GetTextValue(/* _Out_writes_(nameCount) */ [MarshalAs(UnmanagedType.LPWStr)] string name, uint nameCount);
        
        [PreserveSig]
        uint GetTextValueLength();
        
        [PreserveSig]
        HRESULT SetAttributeValue(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string value);
        
        [PreserveSig]
        HRESULT GetAttributeValue(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, /* _Out_writes_(valueCount) */ [MarshalAs(UnmanagedType.LPWStr)] string value, uint valueCount);
        
        [PreserveSig]
        HRESULT GetAttributeValueLength(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, /* _Out_ */ out uint valueLength);
        
        [PreserveSig]
        HRESULT SetAttributeValue(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string name, D2D1_SVG_ATTRIBUTE_POD_TYPE type, /* _In_reads_bytes_(valueSizeInBytes) */ IntPtr value, uint valueSizeInBytes);
        
        [PreserveSig]
        HRESULT GetAttributeValue(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string name, D2D1_SVG_ATTRIBUTE_POD_TYPE type, /* _Out_writes_bytes_(valueSizeInBytes) */ IntPtr value, uint valueSizeInBytes);
        
        [PreserveSig]
        HRESULT SetAttributeValue(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string name, /* _In_ */ ID2D1SvgAttribute value);
        
        [PreserveSig]
        HRESULT GetAttributeValue(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string name, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_result_maybenull_ */ [MarshalAs(UnmanagedType.IUnknown)] out object value);
    }
}
