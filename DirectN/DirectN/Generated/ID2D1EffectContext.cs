// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1effectauthor.h(897,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The internal context handed to effect authors to create transforms from effects and any other operation tied to context which is not useful to the application facing API.
    /// </summary>
    [ComImport, Guid("3d9f916b-27dc-4ad7-b4f1-64945340f563"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1EffectContext
    {
        [PreserveSig]
        void GetDpi(/* _Out_ */ out float dpiX, /* _Out_ */ out float dpiY);
        
        [PreserveSig]
        HRESULT CreateEffect(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid effectId, /* _COM_Outptr_ */ out ID2D1Effect effect);
        
        [PreserveSig]
        HRESULT GetMaximumSupportedFeatureLevel(/* _In_reads_(featureLevelsCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D3D_FEATURE_LEVEL[] featureLevels, int featureLevelsCount, /* _Out_ */ out D3D_FEATURE_LEVEL maximumSupportedFeatureLevel);
        
        [PreserveSig]
        HRESULT CreateTransformNodeFromEffect(/* _In_ */ ID2D1Effect effect, /* _COM_Outptr_ */ out ID2D1TransformNode transformNode);
        
        [PreserveSig]
        HRESULT CreateBlendTransform(uint numInputs, /* _In_ */ ref D2D1_BLEND_DESCRIPTION blendDescription, /* _COM_Outptr_ */ out ID2D1BlendTransform transform);
        
        [PreserveSig]
        HRESULT CreateBorderTransform(D2D1_EXTEND_MODE extendModeX, D2D1_EXTEND_MODE extendModeY, /* _COM_Outptr_ */ out ID2D1BorderTransform transform);
        
        [PreserveSig]
        HRESULT CreateOffsetTransform(tagPOINT offset, /* _COM_Outptr_ */ out ID2D1OffsetTransform transform);
        
        [PreserveSig]
        HRESULT CreateBoundsAdjustmentTransform(/* _In_ */ ref tagRECT outputRectangle, /* _COM_Outptr_ */ out ID2D1BoundsAdjustmentTransform transform);
        
        [PreserveSig]
        HRESULT LoadPixelShader([MarshalAs(UnmanagedType.LPStruct)] Guid shaderId, /* _In_reads_(shaderBufferCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] shaderBuffer, int shaderBufferCount);
        
        [PreserveSig]
        HRESULT LoadVertexShader([MarshalAs(UnmanagedType.LPStruct)] Guid resourceId, /* _In_reads_(shaderBufferCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] shaderBuffer, int shaderBufferCount);
        
        [PreserveSig]
        HRESULT LoadComputeShader([MarshalAs(UnmanagedType.LPStruct)] Guid resourceId, /* _In_reads_(shaderBufferCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] shaderBuffer, int shaderBufferCount);
        
        [PreserveSig]
        bool IsShaderLoaded([MarshalAs(UnmanagedType.LPStruct)] Guid shaderId);
        
        [PreserveSig]
        HRESULT CreateResourceTexture(/* optional(GUID) */ IntPtr resourceId, /* _In_ */ ref D2D1_RESOURCE_TEXTURE_PROPERTIES resourceTextureProperties, /* _In_reads_opt_(dataSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] byte[] data, /* _In_reads_opt_(resourceTextureProperties->dimensions - 1) */ [MarshalAs(UnmanagedType.LPArray)] uint[] strides, int dataSize, /* _COM_Outptr_ */ out ID2D1ResourceTexture resourceTexture);
        
        [PreserveSig]
        HRESULT FindResourceTexture(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid resourceId, /* _COM_Outptr_ */ out ID2D1ResourceTexture resourceTexture);
        
        [PreserveSig]
        HRESULT CreateVertexBuffer(/* _In_ */ ref D2D1_VERTEX_BUFFER_PROPERTIES vertexBufferProperties, /* optional(GUID) */ IntPtr resourceId, /* optional(D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES) */ IntPtr customVertexBufferProperties, /* _COM_Outptr_ */ out ID2D1VertexBuffer buffer);
        
        [PreserveSig]
        HRESULT FindVertexBuffer(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid resourceId, /* _COM_Outptr_ */ out ID2D1VertexBuffer buffer);
        
        [PreserveSig]
        HRESULT CreateColorContext(D2D1_COLOR_SPACE space, /* _In_reads_opt_(profileSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] profile, int profileSize, /* _COM_Outptr_ */ out ID2D1ColorContext colorContext);
        
        [PreserveSig]
        HRESULT CreateColorContextFromFilename(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string filename, /* _COM_Outptr_ */ out ID2D1ColorContext colorContext);
        
        [PreserveSig]
        HRESULT CreateColorContextFromWicColorContext(/* _In_ */ IWICColorContext wicColorContext, /* _COM_Outptr_ */ out ID2D1ColorContext colorContext);
        
        [PreserveSig]
        HRESULT CheckFeatureSupport(D2D1_FEATURE feature, /* _Out_writes_bytes_(featureSupportDataSize) */ IntPtr featureSupportData, uint featureSupportDataSize);
        
        [PreserveSig]
        bool IsBufferPrecisionSupported(D2D1_BUFFER_PRECISION bufferPrecision);
    }
}
