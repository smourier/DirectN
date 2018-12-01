// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_1.h(2223,1)
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    /// <summary>
    /// Creates Direct2D resources.
    /// </summary>
    [Guid("bb12d362-daee-4b9a-aa1d-14ba401cfa1f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1Factory1
    {
        [PreserveSig]
        HRESULT CreateDevice(/* _In_ */ ref IDXGIDevice dxgiDevice, /* _COM_Outptr_ */ out ID2D1Device d2dDevice);
        
        [PreserveSig]
        HRESULT CreateStrokeStyle(/* _In_ */ ref D2D1_STROKE_STYLE_PROPERTIES1 strokeStyleProperties, /* _In_reads_opt_(dashesCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] float[] dashes, uint dashesCount, /* _COM_Outptr_ */ out ID2D1StrokeStyle1 strokeStyle);
        
        [PreserveSig]
        HRESULT CreatePathGeometry(/* _COM_Outptr_ */ out ID2D1PathGeometry1 pathGeometry);
        
        [PreserveSig]
        HRESULT CreateDrawingStateBlock(/* _In_opt_ */ ref D2D1_DRAWING_STATE_DESCRIPTION1 drawingStateDescription, /* _In_opt_ */ ref IDWriteRenderingParams textRenderingParams, /* _COM_Outptr_ */ out ID2D1DrawingStateBlock1 drawingStateBlock);
        
        [PreserveSig]
        HRESULT CreateGdiMetafile(/* _In_ */ ref IStream metafileStream, /* _COM_Outptr_ */ out ID2D1GdiMetafile metafile);
        
        [PreserveSig]
        HRESULT RegisterEffectFromStream(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid classId, /* _In_ */ ref IStream propertyXml, /* _In_reads_opt_(bindingsCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] D2D1_PROPERTY_BINDING[] bindings, uint bindingsCount, /* _In_ */ IntPtr effectFactory);
        
        [PreserveSig]
        HRESULT RegisterEffectFromString(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid classId, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propertyXml, /* _In_reads_opt_(bindingsCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] D2D1_PROPERTY_BINDING[] bindings, uint bindingsCount, /* _In_ */ IntPtr effectFactory);
        
        [PreserveSig]
        HRESULT UnregisterEffect(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid classId);
        
        [PreserveSig]
        HRESULT GetRegisteredEffects(/* _Out_writes_to_opt_(effectsCount, *effectsReturned) */ out Guid effects, uint effectsCount, /* _Out_opt_ */ out uint effectsReturned, /* _Out_opt_ */ out uint effectsRegistered);
        
        [PreserveSig]
        HRESULT GetEffectProperties(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid effectId, /* _COM_Outptr_ */ out ID2D1Properties properties);
    }
}
