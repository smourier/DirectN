// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite.h(4642,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Interface that encapsulates information used to render a glyph run.
    /// </summary>
    [ComImport, Guid("7d97dbf7-e085-42d4-81e3-6a883bded118"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteGlyphRunAnalysis
    {
        [PreserveSig]
        HRESULT GetAlphaTextureBounds(DWRITE_TEXTURE_TYPE textureType, /* _Out_ */ out tagRECT textureBounds);
        
        [PreserveSig]
        HRESULT CreateAlphaTexture(DWRITE_TEXTURE_TYPE textureType, /* _In_ */ ref tagRECT textureBounds, /* _Out_writes_bytes_(bufferSize) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] alphaValues, int bufferSize);
        
        [PreserveSig]
        HRESULT GetAlphaBlendParams(/* _In_ */ IDWriteRenderingParams renderingParams, /* _Out_ */ out float blendGamma, /* _Out_ */ out float blendEnhancedContrast, /* _Out_ */ out float blendClearTypeLevel);
    }
}
