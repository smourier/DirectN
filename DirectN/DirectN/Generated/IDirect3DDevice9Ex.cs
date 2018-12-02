// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3d9.h(205,1)
using System;
using System.Runtime.InteropServices;
using PALETTEENTRY = DirectN.tagPALETTEENTRY;
using POINT = DirectN.tagPOINT;
using RECT = DirectN.tagRECT;
using RGNDATA = DirectN._RGNDATA;

namespace DirectN
{
    [Guid("b18b10ce-2649-405a-870f-95f777d4313a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DDevice9Ex : IDirect3DDevice9
    {
        // IDirect3DDevice9
        [PreserveSig]
        new HRESULT TestCooperativeLevel();
        
        [PreserveSig]
        new uint GetAvailableTextureMem();
        
        [PreserveSig]
        new HRESULT EvictManagedResources();
        
        [PreserveSig]
        new HRESULT GetDirect3D(IDirect3D9 ppD3D9);
        
        [PreserveSig]
        new HRESULT GetDeviceCaps(ref _D3DCAPS9 pCaps);
        
        [PreserveSig]
        new HRESULT GetDisplayMode(uint iSwapChain, ref _D3DDISPLAYMODE pMode);
        
        [PreserveSig]
        new HRESULT GetCreationParameters(ref _D3DDEVICE_CREATION_PARAMETERS pParameters);
        
        [PreserveSig]
        new HRESULT SetCursorProperties(uint XHotSpot, uint YHotSpot, IDirect3DSurface9 pCursorBitmap);
        
        [PreserveSig]
        new void SetCursorPosition(int X, int Y, uint Flags);
        
        [PreserveSig]
        new bool ShowCursor(bool bShow);
        
        [PreserveSig]
        new HRESULT CreateAdditionalSwapChain(ref _D3DPRESENT_PARAMETERS_ pPresentationParameters, IDirect3DSwapChain9 pSwapChain);
        
        [PreserveSig]
        new HRESULT GetSwapChain(uint iSwapChain, IDirect3DSwapChain9 pSwapChain);
        
        [PreserveSig]
        new uint GetNumberOfSwapChains();
        
        [PreserveSig]
        new HRESULT Reset(ref _D3DPRESENT_PARAMETERS_ pPresentationParameters);
        
        [PreserveSig]
        new HRESULT Present(ref RECT pSourceRect, ref RECT pDestRect, ref IntPtr hDestWindowOverride, ref RGNDATA pDirtyRegion);
        
        [PreserveSig]
        new HRESULT GetBackBuffer(uint iSwapChain, uint iBackBuffer, _D3DBACKBUFFER_TYPE Type, IDirect3DSurface9 ppBackBuffer);
        
        [PreserveSig]
        new HRESULT GetRasterStatus(uint iSwapChain, ref _D3DRASTER_STATUS pRasterStatus);
        
        [PreserveSig]
        new HRESULT SetDialogBoxMode(bool bEnableDialogs);
        
        [PreserveSig]
        new void SetGammaRamp(uint iSwapChain, uint Flags, ref _D3DGAMMARAMP pRamp);
        
        [PreserveSig]
        new void GetGammaRamp(uint iSwapChain, ref _D3DGAMMARAMP pRamp);
        
        [PreserveSig]
        new HRESULT CreateTexture(uint Width, uint Height, uint Levels, uint Usage, _D3DFORMAT Format, _D3DPOOL Pool, IDirect3DTexture9 ppTexture, ref IntPtr pSharedHandle);
        
        [PreserveSig]
        new HRESULT CreateVolumeTexture(uint Width, uint Height, uint Depth, uint Levels, uint Usage, _D3DFORMAT Format, _D3DPOOL Pool, IDirect3DVolumeTexture9 ppVolumeTexture, ref IntPtr pSharedHandle);
        
        [PreserveSig]
        new HRESULT CreateCubeTexture(uint EdgeLength, uint Levels, uint Usage, _D3DFORMAT Format, _D3DPOOL Pool, IDirect3DCubeTexture9 ppCubeTexture, ref IntPtr pSharedHandle);
        
        [PreserveSig]
        new HRESULT CreateVertexBuffer(uint Length, uint Usage, uint FVF, _D3DPOOL Pool, IDirect3DVertexBuffer9 ppVertexBuffer, ref IntPtr pSharedHandle);
        
        [PreserveSig]
        new HRESULT CreateIndexBuffer(uint Length, uint Usage, _D3DFORMAT Format, _D3DPOOL Pool, IDirect3DIndexBuffer9 ppIndexBuffer, ref IntPtr pSharedHandle);
        
        [PreserveSig]
        new HRESULT CreateRenderTarget(uint Width, uint Height, _D3DFORMAT Format, _D3DMULTISAMPLE_TYPE MultiSample, uint MultisampleQuality, bool Lockable, IDirect3DSurface9 ppSurface, ref IntPtr pSharedHandle);
        
        [PreserveSig]
        new HRESULT CreateDepthStencilSurface(uint Width, uint Height, _D3DFORMAT Format, _D3DMULTISAMPLE_TYPE MultiSample, uint MultisampleQuality, bool Discard, IDirect3DSurface9 ppSurface, ref IntPtr pSharedHandle);
        
        [PreserveSig]
        new HRESULT UpdateSurface(IDirect3DSurface9 pSourceSurface, ref RECT pSourceRect, IDirect3DSurface9 pDestinationSurface, ref POINT pDestPoint);
        
        [PreserveSig]
        new HRESULT UpdateTexture(IDirect3DBaseTexture9 pSourceTexture, IDirect3DBaseTexture9 pDestinationTexture);
        
        [PreserveSig]
        new HRESULT GetRenderTargetData(IDirect3DSurface9 pRenderTarget, IDirect3DSurface9 pDestSurface);
        
        [PreserveSig]
        new HRESULT GetFrontBufferData(uint iSwapChain, IDirect3DSurface9 pDestSurface);
        
        [PreserveSig]
        new HRESULT StretchRect(IDirect3DSurface9 pSourceSurface, ref RECT pSourceRect, IDirect3DSurface9 pDestSurface, ref RECT pDestRect, _D3DTEXTUREFILTERTYPE Filter);
        
        [PreserveSig]
        new HRESULT ColorFill(IDirect3DSurface9 pSurface, ref RECT pRect, uint color);
        
        [PreserveSig]
        new HRESULT CreateOffscreenPlainSurface(uint Width, uint Height, _D3DFORMAT Format, _D3DPOOL Pool, IDirect3DSurface9 ppSurface, ref IntPtr pSharedHandle);
        
        [PreserveSig]
        new HRESULT SetRenderTarget(uint RenderTargetIndex, IDirect3DSurface9 pRenderTarget);
        
        [PreserveSig]
        new HRESULT GetRenderTarget(uint RenderTargetIndex, IDirect3DSurface9 ppRenderTarget);
        
        [PreserveSig]
        new HRESULT SetDepthStencilSurface(IDirect3DSurface9 pNewZStencil);
        
        [PreserveSig]
        new HRESULT GetDepthStencilSurface(IDirect3DSurface9 ppZStencilSurface);
        
        [PreserveSig]
        new HRESULT BeginScene();
        
        [PreserveSig]
        new HRESULT EndScene();
        
        [PreserveSig]
        new HRESULT Clear(uint Count, ref _D3DRECT pRects, uint Flags, uint Color, float Z, uint Stencil);
        
        [PreserveSig]
        new HRESULT SetTransform(_D3DTRANSFORMSTATETYPE State, ref _D3DMATRIX pMatrix);
        
        [PreserveSig]
        new HRESULT GetTransform(_D3DTRANSFORMSTATETYPE State, ref _D3DMATRIX pMatrix);
        
        [PreserveSig]
        new HRESULT MultiplyTransform(_D3DTRANSFORMSTATETYPE __unnamed_0, ref _D3DMATRIX __unnamed_1);
        
        [PreserveSig]
        new HRESULT SetViewport(ref _D3DVIEWPORT9 pViewport);
        
        [PreserveSig]
        new HRESULT GetViewport(ref _D3DVIEWPORT9 pViewport);
        
        [PreserveSig]
        new HRESULT SetMaterial(ref _D3DMATERIAL9 pMaterial);
        
        [PreserveSig]
        new HRESULT GetMaterial(ref _D3DMATERIAL9 pMaterial);
        
        [PreserveSig]
        new HRESULT SetLight(uint Index, ref _D3DLIGHT9 __unnamed_1);
        
        [PreserveSig]
        new HRESULT GetLight(uint Index, ref _D3DLIGHT9 __unnamed_1);
        
        [PreserveSig]
        new HRESULT LightEnable(uint Index, bool Enable);
        
        [PreserveSig]
        new HRESULT GetLightEnable(uint Index, ref bool pEnable);
        
        [PreserveSig]
        new HRESULT SetClipPlane(uint Index, ref float pPlane);
        
        [PreserveSig]
        new HRESULT GetClipPlane(uint Index, ref float pPlane);
        
        [PreserveSig]
        new HRESULT SetRenderState(_D3DRENDERSTATETYPE State, uint Value);
        
        [PreserveSig]
        new HRESULT GetRenderState(_D3DRENDERSTATETYPE State, ref uint pValue);
        
        [PreserveSig]
        new HRESULT CreateStateBlock(_D3DSTATEBLOCKTYPE Type, IDirect3DStateBlock9 ppSB);
        
        [PreserveSig]
        new HRESULT BeginStateBlock();
        
        [PreserveSig]
        new HRESULT EndStateBlock(IDirect3DStateBlock9 ppSB);
        
        [PreserveSig]
        new HRESULT SetClipStatus(ref _D3DCLIPSTATUS9 pClipStatus);
        
        [PreserveSig]
        new HRESULT GetClipStatus(ref _D3DCLIPSTATUS9 pClipStatus);
        
        [PreserveSig]
        new HRESULT GetTexture(uint Stage, IDirect3DBaseTexture9 ppTexture);
        
        [PreserveSig]
        new HRESULT SetTexture(uint Stage, IDirect3DBaseTexture9 pTexture);
        
        [PreserveSig]
        new HRESULT GetTextureStageState(uint Stage, _D3DTEXTURESTAGESTATETYPE Type, ref uint pValue);
        
        [PreserveSig]
        new HRESULT SetTextureStageState(uint Stage, _D3DTEXTURESTAGESTATETYPE Type, uint Value);
        
        [PreserveSig]
        new HRESULT GetSamplerState(uint Sampler, _D3DSAMPLERSTATETYPE Type, ref uint pValue);
        
        [PreserveSig]
        new HRESULT SetSamplerState(uint Sampler, _D3DSAMPLERSTATETYPE Type, uint Value);
        
        [PreserveSig]
        new HRESULT ValidateDevice(ref uint pNumPasses);
        
        [PreserveSig]
        new HRESULT SetPaletteEntries(uint PaletteNumber, ref PALETTEENTRY pEntries);
        
        [PreserveSig]
        new HRESULT GetPaletteEntries(uint PaletteNumber, ref PALETTEENTRY pEntries);
        
        [PreserveSig]
        new HRESULT SetCurrentTexturePalette(uint PaletteNumber);
        
        [PreserveSig]
        new HRESULT GetCurrentTexturePalette(ref uint PaletteNumber);
        
        [PreserveSig]
        new HRESULT SetScissorRect(ref RECT pRect);
        
        [PreserveSig]
        new HRESULT GetScissorRect(ref RECT pRect);
        
        [PreserveSig]
        new HRESULT SetSoftwareVertexProcessing(bool bSoftware);
        
        [PreserveSig]
        new bool GetSoftwareVertexProcessing();
        
        [PreserveSig]
        new HRESULT SetNPatchMode(float nSegments);
        
        [PreserveSig]
        new void GetNPatchMode();
        
        [PreserveSig]
        new HRESULT DrawPrimitive(_D3DPRIMITIVETYPE PrimitiveType, uint StartVertex, uint PrimitiveCount);
        
        [PreserveSig]
        new HRESULT DrawIndexedPrimitive(_D3DPRIMITIVETYPE __unnamed_0, int BaseVertexIndex, uint MinVertexIndex, uint NumVertices, uint startIndex, uint primCount);
        
        [PreserveSig]
        new HRESULT DrawPrimitiveUP(_D3DPRIMITIVETYPE PrimitiveType, uint PrimitiveCount, [MarshalAs(UnmanagedType.IUnknown)] object pVertexStreamZeroData, uint VertexStreamZeroStride);
        
        [PreserveSig]
        new HRESULT DrawIndexedPrimitiveUP(_D3DPRIMITIVETYPE PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, [MarshalAs(UnmanagedType.IUnknown)] object pIndexData, _D3DFORMAT IndexDataFormat, [MarshalAs(UnmanagedType.IUnknown)] object pVertexStreamZeroData, uint VertexStreamZeroStride);
        
        [PreserveSig]
        new HRESULT ProcessVertices(uint SrcStartIndex, uint DestIndex, uint VertexCount, IDirect3DVertexBuffer9 pDestBuffer, IDirect3DVertexDeclaration9 pVertexDecl, uint Flags);
        
        [PreserveSig]
        new HRESULT CreateVertexDeclaration(ref _D3DVERTEXELEMENT9 pVertexElements, IDirect3DVertexDeclaration9 ppDecl);
        
        [PreserveSig]
        new HRESULT SetVertexDeclaration(IDirect3DVertexDeclaration9 pDecl);
        
        [PreserveSig]
        new HRESULT GetVertexDeclaration(IDirect3DVertexDeclaration9 ppDecl);
        
        [PreserveSig]
        new HRESULT SetFVF(uint FVF);
        
        [PreserveSig]
        new HRESULT GetFVF(ref uint pFVF);
        
        [PreserveSig]
        new HRESULT CreateVertexShader(ref uint pFunction, IDirect3DVertexShader9 ppShader);
        
        [PreserveSig]
        new HRESULT SetVertexShader(IDirect3DVertexShader9 pShader);
        
        [PreserveSig]
        new HRESULT GetVertexShader(IDirect3DVertexShader9 ppShader);
        
        [PreserveSig]
        new HRESULT SetVertexShaderConstantF(uint StartRegister, ref float pConstantData, uint Vector4fCount);
        
        [PreserveSig]
        new HRESULT GetVertexShaderConstantF(uint StartRegister, ref float pConstantData, uint Vector4fCount);
        
        [PreserveSig]
        new HRESULT SetVertexShaderConstantI(uint StartRegister, ref int pConstantData, uint Vector4iCount);
        
        [PreserveSig]
        new HRESULT GetVertexShaderConstantI(uint StartRegister, ref int pConstantData, uint Vector4iCount);
        
        [PreserveSig]
        new HRESULT SetVertexShaderConstantB(uint StartRegister, ref bool pConstantData, uint BoolCount);
        
        [PreserveSig]
        new HRESULT GetVertexShaderConstantB(uint StartRegister, ref bool pConstantData, uint BoolCount);
        
        [PreserveSig]
        new HRESULT SetStreamSource(uint StreamNumber, IDirect3DVertexBuffer9 pStreamData, uint OffsetInBytes, uint Stride);
        
        [PreserveSig]
        new HRESULT GetStreamSource(uint StreamNumber, IDirect3DVertexBuffer9 ppStreamData, ref uint pOffsetInBytes, ref uint pStride);
        
        [PreserveSig]
        new HRESULT SetStreamSourceFreq(uint StreamNumber, uint Setting);
        
        [PreserveSig]
        new HRESULT GetStreamSourceFreq(uint StreamNumber, ref uint pSetting);
        
        [PreserveSig]
        new HRESULT SetIndices(IDirect3DIndexBuffer9 pIndexData);
        
        [PreserveSig]
        new HRESULT GetIndices(IDirect3DIndexBuffer9 ppIndexData);
        
        [PreserveSig]
        new HRESULT CreatePixelShader(ref uint pFunction, IDirect3DPixelShader9 ppShader);
        
        [PreserveSig]
        new HRESULT SetPixelShader(IDirect3DPixelShader9 pShader);
        
        [PreserveSig]
        new HRESULT GetPixelShader(IDirect3DPixelShader9 ppShader);
        
        [PreserveSig]
        new HRESULT SetPixelShaderConstantF(uint StartRegister, ref float pConstantData, uint Vector4fCount);
        
        [PreserveSig]
        new HRESULT GetPixelShaderConstantF(uint StartRegister, ref float pConstantData, uint Vector4fCount);
        
        [PreserveSig]
        new HRESULT SetPixelShaderConstantI(uint StartRegister, ref int pConstantData, uint Vector4iCount);
        
        [PreserveSig]
        new HRESULT GetPixelShaderConstantI(uint StartRegister, ref int pConstantData, uint Vector4iCount);
        
        [PreserveSig]
        new HRESULT SetPixelShaderConstantB(uint StartRegister, ref bool pConstantData, uint BoolCount);
        
        [PreserveSig]
        new HRESULT GetPixelShaderConstantB(uint StartRegister, ref bool pConstantData, uint BoolCount);
        
        [PreserveSig]
        new HRESULT DrawRectPatch(uint Handle, ref float pNumSegs, ref _D3DRECTPATCH_INFO pRectPatchInfo);
        
        [PreserveSig]
        new HRESULT DrawTriPatch(uint Handle, ref float pNumSegs, ref _D3DTRIPATCH_INFO pTriPatchInfo);
        
        [PreserveSig]
        new HRESULT DeletePatch(uint Handle);
        
        [PreserveSig]
        new HRESULT CreateQuery(_D3DQUERYTYPE Type, IDirect3DQuery9 ppQuery);
        
        // IDirect3DDevice9Ex
        [PreserveSig]
        HRESULT SetConvolutionMonoKernel(uint width, uint height, ref float rows, ref float columns);
        
        [PreserveSig]
        HRESULT ComposeRects(IDirect3DSurface9 pSrc, IDirect3DSurface9 pDst, IDirect3DVertexBuffer9 pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9 pDstRectDescs, _D3DCOMPOSERECTSOP Operation, int Xoffset, int Yoffset);
        
        [PreserveSig]
        HRESULT PresentEx(ref RECT pSourceRect, ref RECT pDestRect, ref IntPtr hDestWindowOverride, ref RGNDATA pDirtyRegion, uint dwFlags);
        
        [PreserveSig]
        HRESULT GetGPUThreadPriority(ref int pPriority);
        
        [PreserveSig]
        HRESULT SetGPUThreadPriority(int Priority);
        
        [PreserveSig]
        HRESULT WaitForVBlank(uint iSwapChain);
        
        [PreserveSig]
        HRESULT CheckResourceResidency(IDirect3DResource9 pResourceArray, uint NumResources);
        
        [PreserveSig]
        HRESULT SetMaximumFrameLatency(uint MaxLatency);
        
        [PreserveSig]
        HRESULT GetMaximumFrameLatency(ref uint pMaxLatency);
        
        [PreserveSig]
        HRESULT CheckDeviceState(ref IntPtr hDestinationWindow);
        
        [PreserveSig]
        HRESULT CreateRenderTargetEx(uint Width, uint Height, _D3DFORMAT Format, _D3DMULTISAMPLE_TYPE MultiSample, uint MultisampleQuality, bool Lockable, IDirect3DSurface9 ppSurface, ref IntPtr pSharedHandle, uint Usage);
        
        [PreserveSig]
        HRESULT CreateOffscreenPlainSurfaceEx(uint Width, uint Height, _D3DFORMAT Format, _D3DPOOL Pool, IDirect3DSurface9 ppSurface, ref IntPtr pSharedHandle, uint Usage);
        
        [PreserveSig]
        HRESULT CreateDepthStencilSurfaceEx(uint Width, uint Height, _D3DFORMAT Format, _D3DMULTISAMPLE_TYPE MultiSample, uint MultisampleQuality, bool Discard, IDirect3DSurface9 ppSurface, ref IntPtr pSharedHandle, uint Usage);
        
        [PreserveSig]
        HRESULT ResetEx(ref _D3DPRESENT_PARAMETERS_ pPresentationParameters, ref D3DDISPLAYMODEEX pFullscreenDisplayMode);
        
        [PreserveSig]
        HRESULT GetDisplayModeEx(uint iSwapChain, ref D3DDISPLAYMODEEX pMode, ref D3DDISPLAYROTATION pRotation);
    }
}
