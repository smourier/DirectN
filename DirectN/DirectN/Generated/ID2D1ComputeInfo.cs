// generated from <Windows SDK Path>\um\d2d1effectauthor.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// A transform uses this interface to specify how to render a particular pass using compute shader.
    /// </summary>
    [ComImport, Guid("5598b14b-9fd7-48b7-9bdb-8f0964eb38bc"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1ComputeInfo : ID2D1RenderInfo
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
        
        // ID2D1ComputeInfo
        [PreserveSig]
        HRESULT SetComputeShaderConstantBuffer(/* _In_reads_(bufferCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] buffer, int bufferCount);
        
        [PreserveSig]
        HRESULT SetComputeShader(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid shaderId);
        
        [PreserveSig]
        HRESULT SetResourceTexture(uint textureIndex, /* _In_ */ ID2D1ResourceTexture resourceTexture);
    }
}
