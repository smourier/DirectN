// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1effectauthor.h(500,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// A transform uses this interface to specify how to render a particular pass using pixel and vertex shaders.
    /// </summary>
    [ComImport, Guid("693ce632-7f2f-45de-93fe-18d88b37aa21"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1DrawInfo : ID2D1RenderInfo
    {
        // ID2D1RenderInfo
        [PreserveSig]
        new HRESULT SetInputDescription(uint inputIndex, D2D1_INPUT_DESCRIPTION inputDescription);
        
        [PreserveSig]
        new HRESULT SetOutputBuffer(D2D1_BUFFER_PRECISION bufferPrecision, D2D1_CHANNEL_DEPTH channelDepth);
        
        [PreserveSig]
        new void SetCached(bool isCached);
        
        [PreserveSig]
        new void SetInstructionCountHint(uint instructionCount);
        
        // ID2D1DrawInfo
        [PreserveSig]
        HRESULT SetPixelShaderConstantBuffer(/* _In_reads_(bufferCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] buffer, int bufferCount);
        
        [PreserveSig]
        HRESULT SetResourceTexture(uint textureIndex, /* _In_ */ ID2D1ResourceTexture resourceTexture);
        
        [PreserveSig]
        HRESULT SetVertexShaderConstantBuffer(/* _In_reads_(bufferCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] buffer, int bufferCount);
        
        [PreserveSig]
        HRESULT SetPixelShader(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid shaderId, D2D1_PIXEL_OPTIONS pixelOptions);
        
        [PreserveSig]
        HRESULT SetVertexProcessing(/* _In_opt_ */ ID2D1VertexBuffer vertexBuffer, D2D1_VERTEX_OPTIONS vertexOptions, /* optional(D2D1_BLEND_DESCRIPTION) */ IntPtr blendDescription, /* optional(D2D1_VERTEX_RANGE) */ IntPtr vertexRange, /* optional(GUID) */ IntPtr vertexShader);
    }
}
