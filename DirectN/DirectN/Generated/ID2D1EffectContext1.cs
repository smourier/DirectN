// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1effectauthor_1.h(34,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The internal context handed to effect authors to create transforms from effects and any other operation tied to context which is not useful to the application facing API.
    /// </summary>
    [Guid("84ab595a-fc81-4546-bacd-e8ef4d8abe7a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1EffectContext1 : ID2D1EffectContext
    {
        // ID2D1EffectContext
        [PreserveSig]
        new void GetDpi(/* _Out_ */ out float dpiX, /* _Out_ */ out float dpiY);
        
        [PreserveSig]
        new HRESULT CreateEffect(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid effectId, /* _COM_Outptr_ */ out ID2D1Effect effect);
        
        [PreserveSig]
        new HRESULT GetMaximumSupportedFeatureLevel(/* _In_reads_(featureLevelsCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D3D_FEATURE_LEVEL[] featureLevels, uint featureLevelsCount, /* _Out_ */ out D3D_FEATURE_LEVEL maximumSupportedFeatureLevel);
        
        [PreserveSig]
        new HRESULT CreateTransformNodeFromEffect(/* _In_ */ ID2D1Effect effect, /* _COM_Outptr_ */ out ID2D1TransformNode transformNode);
        
        [PreserveSig]
        new HRESULT CreateBlendTransform(uint numInputs, /* _In_ */ ref D2D1_BLEND_DESCRIPTION blendDescription, /* _COM_Outptr_ */ out ID2D1BlendTransform transform);
        
        [PreserveSig]
        new HRESULT CreateBorderTransform(D2D1_EXTEND_MODE extendModeX, D2D1_EXTEND_MODE extendModeY, /* _COM_Outptr_ */ out ID2D1BorderTransform transform);
        
        [PreserveSig]
        new HRESULT CreateOffsetTransform(tagPOINT offset, /* _COM_Outptr_ */ out ID2D1OffsetTransform transform);
        
        [PreserveSig]
        new HRESULT CreateBoundsAdjustmentTransform(/* _In_ */ ref tagRECT outputRectangle, /* _COM_Outptr_ */ out ID2D1BoundsAdjustmentTransform transform);
        
        [PreserveSig]
        new HRESULT LoadPixelShader([MarshalAs(UnmanagedType.LPStruct)] Guid shaderId, /* _In_reads_(shaderBufferCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] shaderBuffer, uint shaderBufferCount);
        
        [PreserveSig]
        new HRESULT LoadVertexShader([MarshalAs(UnmanagedType.LPStruct)] Guid resourceId, /* _In_reads_(shaderBufferCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] shaderBuffer, uint shaderBufferCount);
        
        [PreserveSig]
        new HRESULT LoadComputeShader([MarshalAs(UnmanagedType.LPStruct)] Guid resourceId, /* _In_reads_(shaderBufferCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] shaderBuffer, uint shaderBufferCount);
        
        [PreserveSig]
        new bool IsShaderLoaded([MarshalAs(UnmanagedType.LPStruct)] Guid shaderId);
        
        [PreserveSig]
        new HRESULT CreateResourceTexture(/* optional(GUID) */ IntPtr resourceId, /* _In_ */ ref D2D1_RESOURCE_TEXTURE_PROPERTIES resourceTextureProperties, /* _In_reads_opt_(dataSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] byte[] data, /* _In_reads_opt_(resourceTextureProperties->dimensions - 1) */ [MarshalAs(UnmanagedType.LPArray)] uint[] strides, uint dataSize, /* _COM_Outptr_ */ out ID2D1ResourceTexture resourceTexture);
        
        [PreserveSig]
        new HRESULT FindResourceTexture(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid resourceId, /* _COM_Outptr_ */ out ID2D1ResourceTexture resourceTexture);
        
        [PreserveSig]
        new HRESULT CreateVertexBuffer(/* _In_ */ ref D2D1_VERTEX_BUFFER_PROPERTIES vertexBufferProperties, /* optional(GUID) */ IntPtr resourceId, /* optional(D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES) */ IntPtr customVertexBufferProperties, /* _COM_Outptr_ */ out ID2D1VertexBuffer buffer);
        
        [PreserveSig]
        new HRESULT FindVertexBuffer(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid resourceId, /* _COM_Outptr_ */ out ID2D1VertexBuffer buffer);
        
        [PreserveSig]
        new HRESULT CreateColorContext(D2D1_COLOR_SPACE space, /* _In_reads_opt_(profileSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] profile, uint profileSize, /* _COM_Outptr_ */ out ID2D1ColorContext colorContext);
        
        [PreserveSig]
        new HRESULT CreateColorContextFromFilename(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string filename, /* _COM_Outptr_ */ out ID2D1ColorContext colorContext);
        
        [PreserveSig]
        new HRESULT CreateColorContextFromWicColorContext(/* _In_ */ IWICColorContext wicColorContext, /* _COM_Outptr_ */ out ID2D1ColorContext colorContext);
        
        [PreserveSig]
        new HRESULT CheckFeatureSupport(D2D1_FEATURE feature, /* _Out_writes_bytes_(featureSupportDataSize) */ IntPtr featureSupportData, uint featureSupportDataSize);
        
        [PreserveSig]
        new bool IsBufferPrecisionSupported(D2D1_BUFFER_PRECISION bufferPrecision);
        
        // ID2D1EffectContext1
        [PreserveSig]
        HRESULT CreateLookupTable3D(D2D1_BUFFER_PRECISION precision, /* _In_reads_(3) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] uint[] extents, /* _In_reads_(dataCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] data, uint dataCount, /* _In_reads_(2) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] uint[] strides, /* _COM_Outptr_ */ out ID2D1LookupTable3D lookupTable);
    }
}
