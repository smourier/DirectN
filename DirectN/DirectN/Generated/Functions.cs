using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    public static partial class Functions
    {
        [DllImport("d3d9")]
        public static extern void D3DPERF_BeginEvent(uint col, [MarshalAs(UnmanagedType.LPWStr)] string wszName);
        
        [DllImport("d3d9")]
        public static extern void D3DPERF_EndEvent();
        
        [DllImport("d3d9")]
        public static extern uint D3DPERF_GetStatus();
        
        [DllImport("d3d9")]
        public static extern bool D3DPERF_QueryRepeatFrame();
        
        [DllImport("d3d9")]
        public static extern void D3DPERF_SetMarker(uint col, [MarshalAs(UnmanagedType.LPWStr)] string wszName);
        
        [DllImport("d3d9")]
        public static extern void D3DPERF_SetOptions(uint dwOptions);
        
        [DllImport("d3d9")]
        public static extern void D3DPERF_SetRegion(uint col, [MarshalAs(UnmanagedType.LPWStr)] string wszName);
        
        /// <summary>
        /// ******************* /* D3D9Ex interfaces /********************
        /// </summary>
        [DllImport("d3d9")]
        public static extern HRESULT Direct3DCreate9Ex(uint SDKVersion, IDirect3D9Ex __unnamed_1);
        
        [DllImport("dxgi")]
        public static extern HRESULT CreateDXGIFactory([MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppFactory);
        
        [DllImport("dxgi")]
        public static extern HRESULT CreateDXGIFactory1([MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppFactory);
        
        [DllImport("dxgi1_3")]
        public static extern HRESULT CreateDXGIFactory2(uint Flags, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppFactory);
        
        [DllImport("dxgi1_3")]
        public static extern HRESULT DXGIGetDebugInterface1(uint Flags, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object pDebug);
        
        [DllImport("dxgi1_6")]
        public static extern HRESULT DXGIDeclareAdapterRemovalSupport();
        
        [DllImport("audioenginebaseapo")]
        public static extern HRESULT EnumerateAPOs(IntPtr pfnCallback, IntPtr pvRefData);
        
        [DllImport("audioenginebaseapo")]
        public static extern HRESULT GetAPOProperties([MarshalAs(UnmanagedType.LPStruct)] Guid clsid, ref APO_REG_PROPERTIES pProperties);
        
        [DllImport("audioenginebaseapo")]
        public static extern HRESULT RegisterAPO(ref APO_REG_PROPERTIES pProperties);
        
        [DllImport("audioenginebaseapo")]
        public static extern HRESULT RegisterAPONotification(IntPtr hEvent);
        
        [DllImport("audioenginebaseapo")]
        public static extern HRESULT UnregisterAPO([MarshalAs(UnmanagedType.LPStruct)] Guid clsid);
        
        [DllImport("audioenginebaseapo")]
        public static extern HRESULT UnregisterAPONotification(IntPtr hEvent);
        
        [DllImport("audiomediatype")]
        public static extern HRESULT CreateAudioMediaType(ref tWAVEFORMATEX pAudioFormat, uint cbAudioFormatSize, IAudioMediaType ppIAudioMediaType);
        
        [DllImport("audiomediatype")]
        public static extern HRESULT CreateAudioMediaTypeFromUncompressedAudioFormat(ref _UNCOMPRESSEDAUDIOFORMAT pUncompressedAudioFormat, IAudioMediaType ppIAudioMediaType);
        
        [DllImport("d2d1")]
        public static extern HRESULT D2D1CreateFactory(/* _In_ */ D2D1_FACTORY_TYPE factoryType, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object factory);
        
        [DllImport("d2d1")]
        public static extern bool D2D1InvertMatrix(/* _Inout_ */ ref D2D_MATRIX_3X2_F matrix);
        
        [DllImport("d2d1")]
        public static extern bool D2D1IsMatrixInvertible(/* _In_ */ ref D2D_MATRIX_3X2_F matrix);
        
        [DllImport("d2d1")]
        public static extern void D2D1MakeRotateMatrix(/* _In_ */ float angle, /* _In_ */ D2D_POINT_2F center, /* _Out_ */ out D2D_MATRIX_3X2_F matrix);
        
        [DllImport("d2d1")]
        public static extern void D2D1MakeSkewMatrix(/* _In_ */ float angleX, /* _In_ */ float angleY, /* _In_ */ D2D_POINT_2F center, /* _Out_ */ out D2D_MATRIX_3X2_F matrix);
        
        [DllImport("d2d1")]
        public static extern D2D1_ARC_SEGMENT ArcSegment(/* _In_ */ ref D2D_POINT_2F point, /* _In_ */ ref D2D_SIZE_F size, /* _In_ */ float rotationAngle, /* _In_ */ D2D1_SWEEP_DIRECTION sweepDirection, /* _In_ */ D2D1_ARC_SIZE arcSize);
        
        [DllImport("d2d1")]
        public static extern D2D1_BEZIER_SEGMENT BezierSegment(/* _In_ */ ref D2D_POINT_2F point1, /* _In_ */ ref D2D_POINT_2F point2, /* _In_ */ ref D2D_POINT_2F point3);
        
        [DllImport("d2d1")]
        public static extern D2D1_BITMAP_BRUSH_PROPERTIES BitmapBrushProperties(D2D1_EXTEND_MODE extendModeX, D2D1_EXTEND_MODE extendModeY, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode);
        
        [DllImport("d2d1")]
        public static extern D2D1_BITMAP_PROPERTIES BitmapProperties(ref D2D1_PIXEL_FORMAT pixelFormat, float dpiX, float dpiY);
        
        [DllImport("d2d1")]
        public static extern D2D1_BRUSH_PROPERTIES BrushProperties(/* _In_ */ float opacity, /* _In_ */ ref D2D_MATRIX_3X2_F transform);
        
        [DllImport("d2d1")]
        public static extern D2D1_DRAWING_STATE_DESCRIPTION DrawingStateDescription(D2D1_ANTIALIAS_MODE antialiasMode, D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode, ulong tag1, ulong tag2, /* _In_ */ ref D2D_MATRIX_3X2_F transform);
        
        [DllImport("d2d1")]
        public static extern D2D1_ELLIPSE Ellipse(/* _In_ */ ref D2D_POINT_2F center, float radiusX, float radiusY);
        
        [DllImport("d2d1")]
        public static extern float FloatMax();
        
        [DllImport("d2d1")]
        public static extern D2D1_GRADIENT_STOP GradientStop(float position, /* _In_ */ ref _D3DCOLORVALUE color);
        
        [DllImport("d2d1")]
        public static extern D2D1_HWND_RENDER_TARGET_PROPERTIES HwndRenderTargetProperties(/* _In_ */ IntPtr hwnd, /* _In_ */ D2D_SIZE_U pixelSize, /* _In_ */ D2D1_PRESENT_OPTIONS presentOptions);
        
        [DllImport("d2d1")]
        public static extern D2D_MATRIX_3X2_F IdentityMatrix();
        
        [DllImport("d2d1")]
        public static extern D2D_RECT_F InfiniteRect();
        
        [DllImport("d2d1")]
        public static extern D2D1_LAYER_PARAMETERS LayerParameters(/* _In_ */ ref D2D_RECT_F contentBounds, /* _In_opt_ */ ref ID2D1Geometry geometricMask, D2D1_ANTIALIAS_MODE maskAntialiasMode, D2D_MATRIX_3X2_F maskTransform, float opacity, /* _In_opt_ */ ref ID2D1Brush opacityBrush, D2D1_LAYER_OPTIONS layerOptions);
        
        [DllImport("d2d1")]
        public static extern D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES LinearGradientBrushProperties(/* _In_ */ ref D2D_POINT_2F startPoint, /* _In_ */ ref D2D_POINT_2F endPoint);
        
        [DllImport("d2d1")]
        public static extern D2D1_PIXEL_FORMAT PixelFormat(/* _In_ */ DXGI_FORMAT dxgiFormat, /* _In_ */ D2D1_ALPHA_MODE alphaMode);
        
        [DllImport("d2d1")]
        public static extern D2D_POINT_2F Point2F(float x, float y);
        
        [DllImport("d2d1")]
        public static extern D2D_POINT_2U Point2U(uint x, uint y);
        
        [DllImport("d2d1")]
        public static extern D2D1_QUADRATIC_BEZIER_SEGMENT QuadraticBezierSegment(/* _In_ */ ref D2D_POINT_2F point1, /* _In_ */ ref D2D_POINT_2F point2);
        
        [DllImport("d2d1")]
        public static extern D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES RadialGradientBrushProperties(/* _In_ */ ref D2D_POINT_2F center, /* _In_ */ ref D2D_POINT_2F gradientOriginOffset, float radiusX, float radiusY);
        
        [DllImport("d2d1")]
        public static extern D2D_RECT_F RectF(float left, float top, float right, float bottom);
        
        [DllImport("d2d1")]
        public static extern D2D_RECT_U RectU(uint left, uint top, uint right, uint bottom);
        
        [DllImport("d2d1")]
        public static extern D2D1_RENDER_TARGET_PROPERTIES RenderTargetProperties(D2D1_RENDER_TARGET_TYPE type, /* _In_ */ ref D2D1_PIXEL_FORMAT pixelFormat, float dpiX, float dpiY, D2D1_RENDER_TARGET_USAGE usage, D2D1_FEATURE_LEVEL minLevel);
        
        [DllImport("d2d1")]
        public static extern D2D1_ROUNDED_RECT RoundedRect(/* _In_ */ ref D2D_RECT_F rect, float radiusX, float radiusY);
        
        [DllImport("d2d1")]
        public static extern D2D_SIZE_F SizeF(float width, float height);
        
        [DllImport("d2d1")]
        public static extern D2D_SIZE_U SizeU(uint width, uint height);
        
        [DllImport("d2d1")]
        public static extern D2D1_STROKE_STYLE_PROPERTIES StrokeStyleProperties(D2D1_CAP_STYLE startCap, D2D1_CAP_STYLE endCap, D2D1_CAP_STYLE dashCap, D2D1_LINE_JOIN lineJoin, float miterLimit, D2D1_DASH_STYLE dashStyle, float dashOffset);
        
        [DllImport("d2d1")]
        public static extern _D3DCOLORVALUE D2D1ConvertColorSpace(D2D1_COLOR_SPACE sourceColorSpace, D2D1_COLOR_SPACE destinationColorSpace, /* _In_ */ ref _D3DCOLORVALUE color);
        
        [DllImport("d2d1")]
        public static extern HRESULT D2D1CreateDevice(/* _In_ */ ref IDXGIDevice dxgiDevice, /* _In_ */ ref D2D1_CREATION_PROPERTIES creationProperties, /* _Outptr_ */ out ID2D1Device d2dDevice);
        
        [DllImport("d2d1")]
        public static extern HRESULT D2D1CreateDeviceContext(/* _In_ */ ref IDXGISurface dxgiSurface, /* _In_ */ ref D2D1_CREATION_PROPERTIES creationProperties, /* _Outptr_ */ out ID2D1DeviceContext d2dDeviceContext);
        
        [DllImport("d2d1")]
        public static extern void D2D1SinCos(/* _In_ */ float angle, /* _Out_ */ out float s, /* _Out_ */ out float c);
        
        [DllImport("d2d1")]
        public static extern float D2D1Tan(/* _In_ */ float angle);
        
        [DllImport("d2d1")]
        public static extern float D2D1Vec3Length(/* _In_ */ float x, /* _In_ */ float y, /* _In_ */ float z);
        
        [DllImport("d2d1")]
        public static extern D2D1_BITMAP_BRUSH_PROPERTIES1 BitmapBrushProperties1(D2D1_EXTEND_MODE extendModeX, D2D1_EXTEND_MODE extendModeY, D2D1_INTERPOLATION_MODE interpolationMode);
        
        [DllImport("d2d1")]
        public static extern D2D1_BITMAP_PROPERTIES1 BitmapProperties1(D2D1_BITMAP_OPTIONS bitmapOptions, /* _In_ */ D2D1_PIXEL_FORMAT pixelFormat, float dpiX, float dpiY, /* _In_opt_ */ ref ID2D1ColorContext colorContext);
        
        [DllImport("d2d1")]
        public static extern _D3DCOLORVALUE ConvertColorSpace(D2D1_COLOR_SPACE sourceColorSpace, D2D1_COLOR_SPACE destinationColorSpace, ref _D3DCOLORVALUE color);
        
        [DllImport("d2d1")]
        public static extern D2D1_CREATION_PROPERTIES CreationProperties(D2D1_THREADING_MODE threadingMode, D2D1_DEBUG_LEVEL debugLevel, D2D1_DEVICE_CONTEXT_OPTIONS options);
        
        [DllImport("d2d1")]
        public static extern D2D1_DRAWING_STATE_DESCRIPTION1 DrawingStateDescription1(/* _In_ */ ref D2D1_DRAWING_STATE_DESCRIPTION desc, D2D1_PRIMITIVE_BLEND primitiveBlend, D2D1_UNIT_MODE unitMode);
        
        [DllImport("d2d1")]
        public static extern D2D1_EFFECT_INPUT_DESCRIPTION EffectInputDescription(ref ID2D1Effect effect, uint inputIndex, D2D_RECT_F inputRectangle);
        
        [DllImport("d2d1")]
        public static extern D2D1_IMAGE_BRUSH_PROPERTIES ImageBrushProperties(D2D_RECT_F sourceRectangle, D2D1_EXTEND_MODE extendModeX, D2D1_EXTEND_MODE extendModeY, D2D1_INTERPOLATION_MODE interpolationMode);
        
        [DllImport("d2d1")]
        public static extern D2D1_LAYER_PARAMETERS1 LayerParameters1(/* _In_ */ ref D2D_RECT_F contentBounds, /* _In_opt_ */ ref ID2D1Geometry geometricMask, D2D1_ANTIALIAS_MODE maskAntialiasMode, D2D_MATRIX_3X2_F maskTransform, float opacity, /* _In_opt_ */ ref ID2D1Brush opacityBrush, D2D1_LAYER_OPTIONS1 layerOptions);
        
        [DllImport("d2d1")]
        public static extern tagPOINT Point2L(int x, int y);
        
        [DllImport("d2d1")]
        public static extern D2D1_PRINT_CONTROL_PROPERTIES PrintControlProperties(D2D1_PRINT_FONT_SUBSET_MODE fontSubsetMode, float rasterDpi, D2D1_COLOR_SPACE colorSpace);
        
        [DllImport("d2d1")]
        public static extern tagRECT RectL(int left, int top, int right, int bottom);
        
        [DllImport("d2d1")]
        public static extern D2D1_RENDERING_CONTROLS RenderingControls(D2D1_BUFFER_PRECISION bufferPrecision, D2D_SIZE_U tileSize);
        
        [DllImport("d2d1")]
        public static extern HRESULT SetDpiCompensatedEffectInput(/* _In_ */ ref ID2D1DeviceContext deviceContext, /* _In_ */ ref ID2D1Effect effect, uint inputIndex, /* _In_opt_ */ ref ID2D1Bitmap inputBitmap, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_BORDER_MODE borderMode);
        
        [DllImport("d2d1")]
        public static extern D2D1_STROKE_STYLE_PROPERTIES1 StrokeStyleProperties1(D2D1_CAP_STYLE startCap, D2D1_CAP_STYLE endCap, D2D1_CAP_STYLE dashCap, D2D1_LINE_JOIN lineJoin, float miterLimit, D2D1_DASH_STYLE dashStyle, float dashOffset, D2D1_STROKE_TRANSFORM_TYPE transformType);
        
        [DllImport("d2d1")]
        public static extern D2D_VECTOR_2F Vector2F(float x, float y);
        
        [DllImport("d2d1")]
        public static extern D2D_VECTOR_3F Vector3F(float x, float y, float z);
        
        [DllImport("d2d1")]
        public static extern D2D_VECTOR_4F Vector4F(float x, float y, float z, float w);
        
        [DllImport("d2d1")]
        public static extern float D2D1ComputeMaximumScaleFactor(/* _In_ */ ref D2D_MATRIX_3X2_F matrix);
        
        [DllImport("d2d1")]
        public static extern float ComputeFlatteningTolerance(/* _In_ */ ref D2D_MATRIX_3X2_F matrix, float dpiX, float dpiY, float maxZoomFactor);
        
        [DllImport("d2d1")]
        public static extern void D2D1GetGradientMeshInteriorPointsFromCoonsPatch(/* _In_ */ ref D2D_POINT_2F pPoint0, /* _In_ */ ref D2D_POINT_2F pPoint1, /* _In_ */ ref D2D_POINT_2F pPoint2, /* _In_ */ ref D2D_POINT_2F pPoint3, /* _In_ */ ref D2D_POINT_2F pPoint4, /* _In_ */ ref D2D_POINT_2F pPoint5, /* _In_ */ ref D2D_POINT_2F pPoint6, /* _In_ */ ref D2D_POINT_2F pPoint7, /* _In_ */ ref D2D_POINT_2F pPoint8, /* _In_ */ ref D2D_POINT_2F pPoint9, /* _In_ */ ref D2D_POINT_2F pPoint10, /* _In_ */ ref D2D_POINT_2F pPoint11, /* _Out_ */ out D2D_POINT_2F pTensorPoint11, /* _Out_ */ out D2D_POINT_2F pTensorPoint12, /* _Out_ */ out D2D_POINT_2F pTensorPoint21, /* _Out_ */ out D2D_POINT_2F pTensorPoint22);
        
        [DllImport("d2d1")]
        public static extern D2D1_GRADIENT_MESH_PATCH GradientMeshPatch(D2D_POINT_2F point00, D2D_POINT_2F point01, D2D_POINT_2F point02, D2D_POINT_2F point03, D2D_POINT_2F point10, D2D_POINT_2F point11, D2D_POINT_2F point12, D2D_POINT_2F point13, D2D_POINT_2F point20, D2D_POINT_2F point21, D2D_POINT_2F point22, D2D_POINT_2F point23, D2D_POINT_2F point30, D2D_POINT_2F point31, D2D_POINT_2F point32, D2D_POINT_2F point33, _D3DCOLORVALUE color00, _D3DCOLORVALUE color03, _D3DCOLORVALUE color30, _D3DCOLORVALUE color33, D2D1_PATCH_EDGE_MODE topEdgeMode, D2D1_PATCH_EDGE_MODE leftEdgeMode, D2D1_PATCH_EDGE_MODE bottomEdgeMode, D2D1_PATCH_EDGE_MODE rightEdgeMode);
        
        [DllImport("d2d1")]
        public static extern D2D1_GRADIENT_MESH_PATCH GradientMeshPatchFromCoonsPatch(D2D_POINT_2F point0, D2D_POINT_2F point1, D2D_POINT_2F point2, D2D_POINT_2F point3, D2D_POINT_2F point4, D2D_POINT_2F point5, D2D_POINT_2F point6, D2D_POINT_2F point7, D2D_POINT_2F point8, D2D_POINT_2F point9, D2D_POINT_2F point10, D2D_POINT_2F point11, _D3DCOLORVALUE color0, _D3DCOLORVALUE color1, _D3DCOLORVALUE color2, _D3DCOLORVALUE color3, D2D1_PATCH_EDGE_MODE topEdgeMode, D2D1_PATCH_EDGE_MODE leftEdgeMode, D2D1_PATCH_EDGE_MODE bottomEdgeMode, D2D1_PATCH_EDGE_MODE rightEdgeMode);
        
        [DllImport("d2d1")]
        public static extern D2D_RECT_U InfiniteRectU();
        
        [DllImport("d2d1")]
        public static extern D2D1_INK_BEZIER_SEGMENT InkBezierSegment(ref D2D1_INK_POINT point1, ref D2D1_INK_POINT point2, ref D2D1_INK_POINT point3);
        
        [DllImport("d2d1")]
        public static extern D2D1_INK_POINT InkPoint(ref D2D_POINT_2F point, float radius);
        
        [DllImport("d2d1")]
        public static extern D2D1_INK_STYLE_PROPERTIES InkStyleProperties(D2D1_INK_NIB_SHAPE nibShape, ref D2D_MATRIX_3X2_F nibTransform);
        
        [DllImport("d2d1")]
        public static extern D2D1_SIMPLE_COLOR_PROFILE SimpleColorProfile(ref D2D_POINT_2F redPrimary, ref D2D_POINT_2F greenPrimary, ref D2D_POINT_2F bluePrimary, D2D1_GAMMA1 gamma, ref D2D_POINT_2F whitePointXZ);
        
        [DllImport("d3d10")]
        public static extern uint D3D10CalcSubresource(uint MipSlice, uint ArraySlice, uint MipLevels);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10CompileEffectFromMemory(/* _In_reads_bytes_(DataLength) */ out IntPtr pData, ulong DataLength, [MarshalAs(UnmanagedType.LPStr)] string pSrcFileName, /* _In_opt_ */ ref _D3D_SHADER_MACRO pDefines, /* _In_opt_ */ ID3DInclude pInclude, uint HLSLFlags, uint FXFlags, /* _Out_ */ out ID3D10Blob ppCompiledEffect, /* _Out_opt_ */ out ID3D10Blob ppErrors);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10CreateEffectFromMemory(/* _In_reads_bytes_(DataLength) */ out IntPtr pData, ulong DataLength, uint FXFlags, /* _In_ */ ID3D10Device pDevice, /* _In_opt_ */ ID3D10EffectPool pEffectPool, /* _Out_ */ out ID3D10Effect ppEffect);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10CreateEffectPoolFromMemory(/* _In_reads_bytes_(DataLength) */ out IntPtr pData, ulong DataLength, uint FXFlags, /* _In_ */ ID3D10Device pDevice, /* _Out_ */ out ID3D10EffectPool ppEffectPool);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10CreateStateBlock(/* _In_ */ ID3D10Device pDevice, /* _In_ */ ref _D3D10_STATE_BLOCK_MASK pStateBlockMask, /* _Out_ */ out ID3D10StateBlock ppStateBlock);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10DisassembleEffect(/* _In_ */ ID3D10Effect pEffect, bool EnableColorCode, /* _Out_ */ out ID3D10Blob ppDisassembly);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10StateBlockMaskDifference(/* _In_ */ ref _D3D10_STATE_BLOCK_MASK pA, /* _In_ */ ref _D3D10_STATE_BLOCK_MASK pB, /* _Out_ */ out _D3D10_STATE_BLOCK_MASK pResult);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10StateBlockMaskDisableAll(/* _Out_ */ out _D3D10_STATE_BLOCK_MASK pMask);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10StateBlockMaskDisableCapture(/* _Inout_ */ ref _D3D10_STATE_BLOCK_MASK pMask, _D3D10_DEVICE_STATE_TYPES StateType, uint RangeStart, uint RangeLength);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10StateBlockMaskEnableAll(/* _Out_ */ out _D3D10_STATE_BLOCK_MASK pMask);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10StateBlockMaskEnableCapture(/* _Inout_ */ ref _D3D10_STATE_BLOCK_MASK pMask, _D3D10_DEVICE_STATE_TYPES StateType, uint RangeStart, uint RangeLength);
        
        [DllImport("d3d10")]
        public static extern bool D3D10StateBlockMaskGetSetting(/* _In_ */ ref _D3D10_STATE_BLOCK_MASK pMask, _D3D10_DEVICE_STATE_TYPES StateType, uint Entry);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10StateBlockMaskIntersect(/* _In_ */ ref _D3D10_STATE_BLOCK_MASK pA, /* _In_ */ ref _D3D10_STATE_BLOCK_MASK pB, /* _Out_ */ out _D3D10_STATE_BLOCK_MASK pResult);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10StateBlockMaskUnion(/* _In_ */ ref _D3D10_STATE_BLOCK_MASK pA, /* _In_ */ ref _D3D10_STATE_BLOCK_MASK pB, /* _Out_ */ out _D3D10_STATE_BLOCK_MASK pResult);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10CreateBlob(ulong NumBytes, /* _Out_ */ out IntPtr ppBuffer);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10CreateDevice(/* _In_opt_ */ ref IDXGIAdapter pAdapter, D3D10_DRIVER_TYPE DriverType, IntPtr Software, uint Flags, uint SDKVersion, /* _Out_opt_ */ out ID3D10Device ppDevice);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10CreateDeviceAndSwapChain(/* _In_opt_ */ ref IDXGIAdapter pAdapter, D3D10_DRIVER_TYPE DriverType, IntPtr Software, uint Flags, uint SDKVersion, /* _In_opt_ */ ref DXGI_SWAP_CHAIN_DESC pSwapChainDesc, /* _Out_opt_ */ out IDXGISwapChain ppSwapChain, /* _Out_opt_ */ out ID3D10Device ppDevice);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10CompileShader(/* _In_reads_bytes_(SrcDataSize) */ [MarshalAs(UnmanagedType.LPStr)] string pSrcData, ulong SrcDataSize, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string pFileName, /* _In_opt_ */ ref _D3D_SHADER_MACRO pDefines, /* _In_opt_ */ IntPtr pInclude, [MarshalAs(UnmanagedType.LPStr)] string pFunctionName, [MarshalAs(UnmanagedType.LPStr)] string pProfile, uint Flags, /* _Out_ */ out ID3D10Blob ppShader, /* _Out_opt_ */ out ID3D10Blob ppErrorMsgs);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10DisassembleShader(/* _In_reads_bytes_(BytecodeLength) */ out IntPtr pShader, ulong BytecodeLength, bool EnableColorCode, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string pComments, /* _Out_ */ out ID3D10Blob ppDisassembly);
        
        [DllImport("d3d10")]
        public static extern string D3D10GetGeometryShaderProfile(/* _In_ */ ID3D10Device pDevice);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10GetInputAndOutputSignatureBlob(/* _In_reads_bytes_(BytecodeLength) */ out IntPtr pShaderBytecode, ulong BytecodeLength, /* _Out_ */ out ID3D10Blob ppSignatureBlob);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10GetInputSignatureBlob(/* _In_reads_bytes_(BytecodeLength) */ out IntPtr pShaderBytecode, ulong BytecodeLength, /* _Out_ */ out ID3D10Blob ppSignatureBlob);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10GetOutputSignatureBlob(/* _In_reads_bytes_(BytecodeLength) */ out IntPtr pShaderBytecode, ulong BytecodeLength, /* _Out_ */ out ID3D10Blob ppSignatureBlob);
        
        [DllImport("d3d10")]
        public static extern string D3D10GetPixelShaderProfile(/* _In_ */ ID3D10Device pDevice);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10GetShaderDebugInfo(/* _In_reads_bytes_(BytecodeLength) */ out IntPtr pShaderBytecode, ulong BytecodeLength, /* _Out_ */ out ID3D10Blob ppDebugInfo);
        
        [DllImport("d3d10")]
        public static extern string D3D10GetVertexShaderProfile(/* _In_ */ ID3D10Device pDevice);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10PreprocessShader(/* _In_reads_bytes_(SrcDataSize) */ [MarshalAs(UnmanagedType.LPStr)] string pSrcData, ulong SrcDataSize, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string pFileName, /* _In_opt_ */ ref _D3D_SHADER_MACRO pDefines, /* _In_opt_ */ IntPtr pInclude, /* _Out_ */ out ID3D10Blob ppShaderText, /* _Out_opt_ */ out ID3D10Blob ppErrorMsgs);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10ReflectShader(/* _In_reads_bytes_(BytecodeLength) */ out IntPtr pShaderBytecode, ulong BytecodeLength, /* _Out_ */ out ID3D10ShaderReflection ppReflector);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10CreateDevice1(/* _In_opt_ */ ref IDXGIAdapter pAdapter, D3D10_DRIVER_TYPE DriverType, IntPtr Software, uint Flags, D3D10_FEATURE_LEVEL1 HardwareLevel, uint SDKVersion, /* _Out_opt_ */ out ID3D10Device1 ppDevice);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10CreateDeviceAndSwapChain1(/* _In_opt_ */ ref IDXGIAdapter pAdapter, D3D10_DRIVER_TYPE DriverType, IntPtr Software, uint Flags, D3D10_FEATURE_LEVEL1 HardwareLevel, uint SDKVersion, /* _In_opt_ */ ref DXGI_SWAP_CHAIN_DESC pSwapChainDesc, /* _Out_opt_ */ out IDXGISwapChain ppSwapChain, /* _Out_opt_ */ out ID3D10Device1 ppDevice);
        
        [DllImport("d3d11")]
        public static extern uint D3D11CalcSubresource(uint MipSlice, uint ArraySlice, uint MipLevels);
        
        [DllImport("d3d11")]
        public static extern HRESULT D3D11CreateDevice(/* _In_opt_ */ ref IDXGIAdapter pAdapter, D3D_DRIVER_TYPE DriverType, IntPtr Software, uint Flags, /* _In_reads_opt_( FeatureLevels ) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] D3D_FEATURE_LEVEL[] pFeatureLevels, uint FeatureLevels, uint SDKVersion, /* _COM_Outptr_opt_ */ out ID3D11Device ppDevice, /* _Out_opt_ */ out D3D_FEATURE_LEVEL pFeatureLevel, /* _COM_Outptr_opt_ */ out ID3D11DeviceContext ppImmediateContext);
        
        [DllImport("d3d11")]
        public static extern HRESULT D3D11CreateDeviceAndSwapChain(/* _In_opt_ */ ref IDXGIAdapter pAdapter, D3D_DRIVER_TYPE DriverType, IntPtr Software, uint Flags, /* _In_reads_opt_( FeatureLevels ) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] D3D_FEATURE_LEVEL[] pFeatureLevels, uint FeatureLevels, uint SDKVersion, /* _In_opt_ */ ref DXGI_SWAP_CHAIN_DESC pSwapChainDesc, /* _COM_Outptr_opt_ */ out IDXGISwapChain ppSwapChain, /* _COM_Outptr_opt_ */ out ID3D11Device ppDevice, /* _Out_opt_ */ out D3D_FEATURE_LEVEL pFeatureLevel, /* _COM_Outptr_opt_ */ out ID3D11DeviceContext ppImmediateContext);
        
        [DllImport("d3d11")]
        public static extern HRESULT D3D11On12CreateDevice(/* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pDevice, uint Flags, /* _In_reads_opt_( FeatureLevels ) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] D3D_FEATURE_LEVEL[] pFeatureLevels, uint FeatureLevels, /* _In_reads_opt_( NumQueues ) */ [MarshalAs(UnmanagedType.IUnknown)] object ppCommandQueues, uint NumQueues, uint NodeMask, /* _COM_Outptr_opt_ */ out ID3D11Device ppDevice, /* _COM_Outptr_opt_ */ out ID3D11DeviceContext ppImmediateContext, /* _Out_opt_ */ out D3D_FEATURE_LEVEL pChosenFeatureLevel);
        
        [DllImport("d3d11")]
        public static extern HRESULT D3DDisassemble11Trace(/* _In_reads_bytes_(SrcDataSize) */ IntPtr pSrcData, /* _In_ */ ulong SrcDataSize, /* _In_ */ ID3D11ShaderTrace pTrace, /* _In_ */ uint StartStep, /* _In_ */ uint NumSteps, /* _In_ */ uint Flags, /* _COM_Outptr_ */ out ID3D10Blob ppDisassembly);
        
        [DllImport("d3d12")]
        public static extern HRESULT D3D12CreateDevice(/* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pAdapter, D3D_FEATURE_LEVEL MinimumFeatureLevel, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* // Expected: ID3D12Device _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppDevice);
        
        [DllImport("d3d12")]
        public static extern HRESULT D3D12CreateRootSignatureDeserializer(/* _In_reads_bytes_(SrcDataSizeInBytes) */ IntPtr pSrcData, /* _In_ */ ulong SrcDataSizeInBytes, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pRootSignatureDeserializerInterface, /* _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppRootSignatureDeserializer);
        
        [DllImport("d3d12")]
        public static extern HRESULT D3D12CreateVersionedRootSignatureDeserializer(/* _In_reads_bytes_(SrcDataSizeInBytes) */ IntPtr pSrcData, /* _In_ */ ulong SrcDataSizeInBytes, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pRootSignatureDeserializerInterface, /* _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppRootSignatureDeserializer);
        
        [DllImport("d3d12")]
        public static extern HRESULT D3D12EnableExperimentalFeatures(uint NumFeatures, /* __in_ecount(NumFeatures) */ [MarshalAs(UnmanagedType.LPStruct)] Guid pIIDs, /* __in_ecount_opt(NumFeatures) */ out IntPtr pConfigurationStructs, /* __in_ecount_opt(NumFeatures) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] uint[] pConfigurationStructSizes);
        
        [DllImport("d3d12")]
        public static extern HRESULT D3D12GetDebugInterface(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvDebug);
        
        [DllImport("d3d12")]
        public static extern HRESULT D3D12SerializeRootSignature(/* _In_ */ ref D3D12_ROOT_SIGNATURE_DESC pRootSignature, /* _In_ */ D3D_ROOT_SIGNATURE_VERSION Version, /* _Out_ */ out ID3D10Blob ppBlob, /* _Always_(_Outptr_opt_result_maybenull_) */ out ID3D10Blob[] ppErrorBlob);
        
        [DllImport("d3d12")]
        public static extern HRESULT D3D12SerializeVersionedRootSignature(/* _In_ */ ref D3D12_VERSIONED_ROOT_SIGNATURE_DESC pRootSignature, /* _Out_ */ out ID3D10Blob ppBlob, /* _Always_(_Outptr_opt_result_maybenull_) */ out ID3D10Blob[] ppErrorBlob);
        
        [DllImport("d3d9helper")]
        public static extern IDirect3D9 Direct3DCreate9(uint SDKVersion);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DCompile(/* _In_reads_bytes_(SrcDataSize) */ IntPtr pSrcData, /* _In_ */ ulong SrcDataSize, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string pSourceName, /* _In_reads_opt_(_Inexpressible_(pDefines->Name != NULL)) */ [In, Out, MarshalAs(UnmanagedType.LPArray)] _D3D_SHADER_MACRO[] pDefines, /* _In_opt_ */ ID3DInclude pInclude, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string pEntrypoint, /* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pTarget, /* _In_ */ uint Flags1, /* _In_ */ uint Flags2, /* _Out_ */ out ID3D10Blob ppCode, /* _Always_(_Outptr_opt_result_maybenull_) */ out ID3D10Blob[] ppErrorMsgs);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DCompile2(/* _In_reads_bytes_(SrcDataSize) */ IntPtr pSrcData, /* _In_ */ ulong SrcDataSize, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string pSourceName, /* _In_reads_opt_(_Inexpressible_(pDefines->Name != NULL)) */ [In, Out, MarshalAs(UnmanagedType.LPArray)] _D3D_SHADER_MACRO[] pDefines, /* _In_opt_ */ ID3DInclude pInclude, /* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pEntrypoint, /* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pTarget, /* _In_ */ uint Flags1, /* _In_ */ uint Flags2, /* _In_ */ uint SecondaryDataFlags, /* _In_reads_bytes_opt_(SecondaryDataSize) */ IntPtr pSecondaryData, /* _In_ */ ulong SecondaryDataSize, /* _Out_ */ out ID3D10Blob ppCode, /* _Always_(_Outptr_opt_result_maybenull_) */ out ID3D10Blob[] ppErrorMsgs);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DCompileFromFile(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pFileName, /* _In_reads_opt_(_Inexpressible_(pDefines->Name != NULL)) */ [In, Out, MarshalAs(UnmanagedType.LPArray)] _D3D_SHADER_MACRO[] pDefines, /* _In_opt_ */ ID3DInclude pInclude, /* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pEntrypoint, /* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pTarget, /* _In_ */ uint Flags1, /* _In_ */ uint Flags2, /* _Out_ */ out ID3D10Blob ppCode, /* _Always_(_Outptr_opt_result_maybenull_) */ out ID3D10Blob[] ppErrorMsgs);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DCompressShaders(/* _In_ */ uint uNumShaders, /* _In_reads_(uNumShaders) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] _D3D_SHADER_DATA[] pShaderData, /* _In_ */ uint uFlags, /* _Out_ */ out ID3D10Blob ppCompressedData);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DCreateBlob(/* _In_ */ ulong Size, /* _Out_ */ out ID3D10Blob ppBlob);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DCreateFunctionLinkingGraph(/* _In_ */ uint uFlags, /* _Out_ */ out ID3D11FunctionLinkingGraph ppFunctionLinkingGraph);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DCreateLinker(/* __out */ out ID3D11Linker ppLinker);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DDecompressShaders(/* _In_reads_bytes_(SrcDataSize) */ IntPtr pSrcData, /* _In_ */ ulong SrcDataSize, /* _In_ */ uint uNumShaders, /* _In_ */ uint uStartIndex, /* _In_reads_opt_(uNumShaders) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] uint[] pIndices, /* _In_ */ uint uFlags, /* _Out_writes_(uNumShaders) */ out ID3D10Blob[] ppShaders, /* _Out_opt_ */ out uint pTotalShaders);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DDisassemble(/* _In_reads_bytes_(SrcDataSize) */ IntPtr pSrcData, /* _In_ */ ulong SrcDataSize, /* _In_ */ uint Flags, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string szComments, /* _Out_ */ out ID3D10Blob ppDisassembly);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DDisassemble10Effect(/* _In_ */ ref ID3D10Effect pEffect, /* _In_ */ uint Flags, /* _Out_ */ out ID3D10Blob ppDisassembly);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DDisassembleRegion(/* _In_reads_bytes_(SrcDataSize) */ IntPtr pSrcData, /* _In_ */ ulong SrcDataSize, /* _In_ */ uint Flags, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string szComments, /* _In_ */ ulong StartByteOffset, /* _In_ */ ulong NumInsts, /* _Out_opt_ */ out ulong pFinishByteOffset, /* _Out_ */ out ID3D10Blob ppDisassembly);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DGetBlobPart(/* _In_reads_bytes_(SrcDataSize) */ IntPtr pSrcData, /* _In_ */ ulong SrcDataSize, /* _In_ */ D3D_BLOB_PART Part, /* _In_ */ uint Flags, /* _Out_ */ out ID3D10Blob ppPart);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DGetDebugInfo(/* _In_reads_bytes_(SrcDataSize) */ IntPtr pSrcData, /* _In_ */ ulong SrcDataSize, /* _Out_ */ out ID3D10Blob ppDebugInfo);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DGetInputAndOutputSignatureBlob(/* _In_reads_bytes_(SrcDataSize) */ IntPtr pSrcData, /* _In_ */ ulong SrcDataSize, /* _Out_ */ out ID3D10Blob ppSignatureBlob);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DGetInputSignatureBlob(/* _In_reads_bytes_(SrcDataSize) */ IntPtr pSrcData, /* _In_ */ ulong SrcDataSize, /* _Out_ */ out ID3D10Blob ppSignatureBlob);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DGetOutputSignatureBlob(/* _In_reads_bytes_(SrcDataSize) */ IntPtr pSrcData, /* _In_ */ ulong SrcDataSize, /* _Out_ */ out ID3D10Blob ppSignatureBlob);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DGetTraceInstructionOffsets(/* _In_reads_bytes_(SrcDataSize) */ IntPtr pSrcData, /* _In_ */ ulong SrcDataSize, /* _In_ */ uint Flags, /* _In_ */ ulong StartInstIndex, /* _In_ */ ulong NumInsts, /* _Out_writes_to_opt_(NumInsts, min(NumInsts, *pTotalInsts)) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] ulong[] pOffsets, /* _Out_opt_ */ out ulong pTotalInsts);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DLoadModule(/* _In_ */ IntPtr pSrcData, /* _In_ */ ulong cbSrcDataSize, /* _Out_ */ out ID3D11Module ppModule);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DPreprocess(/* _In_reads_bytes_(SrcDataSize) */ IntPtr pSrcData, /* _In_ */ ulong SrcDataSize, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string pSourceName, /* _In_opt_ */ ref _D3D_SHADER_MACRO pDefines, /* _In_opt_ */ ID3DInclude pInclude, /* _Out_ */ out ID3D10Blob ppCodeText, /* _Always_(_Outptr_opt_result_maybenull_) */ out ID3D10Blob[] ppErrorMsgs);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DReadFileToBlob(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pFileName, /* _Out_ */ out ID3D10Blob ppContents);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DReflect(/* _In_reads_bytes_(SrcDataSize) */ IntPtr pSrcData, /* _In_ */ ulong SrcDataSize, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pInterface, /* _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppReflector);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DReflectLibrary(/* __in_bcount(SrcDataSize) */ IntPtr pSrcData, /* __in */ ulong SrcDataSize, /* __in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* __out */ [MarshalAs(UnmanagedType.IUnknown)] out object ppReflector);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DSetBlobPart(/* _In_reads_bytes_(SrcDataSize) */ IntPtr pSrcData, /* _In_ */ ulong SrcDataSize, /* _In_ */ D3D_BLOB_PART Part, /* _In_ */ uint Flags, /* _In_reads_bytes_(PartSize) */ IntPtr pPart, /* _In_ */ ulong PartSize, /* _Out_ */ out ID3D10Blob ppNewShader);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DStripShader(/* _In_reads_bytes_(BytecodeLength) */ IntPtr pShaderBytecode, /* _In_ */ ulong BytecodeLength, /* _In_ */ uint uStripFlags, /* _Out_ */ out ID3D10Blob ppStrippedBlob);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DWriteBlobToFile(/* _In_ */ ID3D10Blob pBlob, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pFileName, /* _In_ */ bool bOverwrite);
        
        [DllImport("d3dcsx")]
        public static extern HRESULT D3DX11CreateFFT(ID3D11DeviceContext pDeviceContext, /* _In_ */ ref D3DX11_FFT_DESC pDesc, uint Flags, /* _Out_ */ out D3DX11_FFT_BUFFER_INFO pBufferInfo, /* _Out_ */ out ID3DX11FFT ppFFT);
        
        [DllImport("d3dcsx")]
        public static extern HRESULT D3DX11CreateFFT1DComplex(ID3D11DeviceContext pDeviceContext, uint X, uint Flags, /* _Out_ */ out D3DX11_FFT_BUFFER_INFO pBufferInfo, /* _Out_ */ out ID3DX11FFT ppFFT);
        
        [DllImport("d3dcsx")]
        public static extern HRESULT D3DX11CreateFFT1DReal(ID3D11DeviceContext pDeviceContext, uint X, uint Flags, /* _Out_ */ out D3DX11_FFT_BUFFER_INFO pBufferInfo, /* _Out_ */ out ID3DX11FFT ppFFT);
        
        [DllImport("d3dcsx")]
        public static extern HRESULT D3DX11CreateFFT2DComplex(ID3D11DeviceContext pDeviceContext, uint X, uint Y, uint Flags, /* _Out_ */ out D3DX11_FFT_BUFFER_INFO pBufferInfo, /* _Out_ */ out ID3DX11FFT ppFFT);
        
        [DllImport("d3dcsx")]
        public static extern HRESULT D3DX11CreateFFT2DReal(ID3D11DeviceContext pDeviceContext, uint X, uint Y, uint Flags, /* _Out_ */ out D3DX11_FFT_BUFFER_INFO pBufferInfo, /* _Out_ */ out ID3DX11FFT ppFFT);
        
        [DllImport("d3dcsx")]
        public static extern HRESULT D3DX11CreateFFT3DComplex(ID3D11DeviceContext pDeviceContext, uint X, uint Y, uint Z, uint Flags, /* _Out_ */ out D3DX11_FFT_BUFFER_INFO pBufferInfo, /* _Out_ */ out ID3DX11FFT ppFFT);
        
        [DllImport("d3dcsx")]
        public static extern HRESULT D3DX11CreateFFT3DReal(ID3D11DeviceContext pDeviceContext, uint X, uint Y, uint Z, uint Flags, /* _Out_ */ out D3DX11_FFT_BUFFER_INFO pBufferInfo, /* _Out_ */ out ID3DX11FFT ppFFT);
        
        [DllImport("d3dcsx")]
        public static extern HRESULT D3DX11CreateScan(/* _In_ */ ID3D11DeviceContext pDeviceContext, uint MaxElementScanSize, uint MaxScanCount, /* _Out_ */ out ID3DX11Scan ppScan);
        
        [DllImport("d3dcsx")]
        public static extern HRESULT D3DX11CreateSegmentedScan(/* _In_ */ ID3D11DeviceContext pDeviceContext, uint MaxElementScanSize, /* _Out_ */ out ID3DX11SegmentedScan ppScan);
        
        [DllImport("ddraw")]
        public static extern HRESULT DirectDrawCreate([MarshalAs(UnmanagedType.LPStruct)] Guid lpGUID, ref IntPtr lplpDD, [MarshalAs(UnmanagedType.IUnknown)] object pUnkOuter);
        
        [DllImport("ddraw")]
        public static extern HRESULT DirectDrawCreateClipper(uint dwFlags, ref IntPtr lplpDDClipper, [MarshalAs(UnmanagedType.IUnknown)] object pUnkOuter);
        
        [DllImport("ddraw")]
        public static extern HRESULT DirectDrawCreateEx([MarshalAs(UnmanagedType.LPStruct)] Guid lpGuid, [MarshalAs(UnmanagedType.IUnknown)] object lplpDD, [MarshalAs(UnmanagedType.LPStruct)] Guid iid, [MarshalAs(UnmanagedType.IUnknown)] object pUnkOuter);
        
        [DllImport("ddraw")]
        public static extern HRESULT DirectDrawEnumerateA(IntPtr lpCallback, IntPtr lpContext);
        
        [DllImport("ddraw")]
        public static extern HRESULT DirectDrawEnumerateExA(IntPtr lpCallback, IntPtr lpContext, uint dwFlags);
        
        [DllImport("ddraw")]
        public static extern HRESULT DirectDrawEnumerateExW(IntPtr lpCallback, IntPtr lpContext, uint dwFlags);
        
        [DllImport("ddraw")]
        public static extern HRESULT DirectDrawEnumerateW(IntPtr lpCallback, IntPtr lpContext);
        
        /// <summary>
        /// Creates a DirectWrite factory object that is used for subsequent creation of individual DirectWrite objects.  <param name="factoryType">Identifies whether the factory object will be shared or isolated.</param> <param name="iid">Identifies the DirectWrite factory interface, such as __uuidof(IDWriteFactory).</param> <param name="factory">Receives the DirectWrite factory object.</param> <returns> Standard HRESULT error code. </returns> <remarks> Obtains DirectWrite factory object that is used for subsequent creation of individual DirectWrite classes. DirectWrite factory contains internal state such as font loader registration and cached font data. In most cases it is recommended to use the shared factory object, because it allows multiple components that use DirectWrite to share internal DirectWrite state and reduce memory usage. However, there are cases when it is desirable to reduce the impact of a component, such as a plug-in from an untrusted source, on the rest of the process by sandboxing and isolating it from the rest of the process components. In such cases, it is recommended to use an isolated factory for the sandboxed component. </remarks>
        /// </summary>
        [DllImport("dwrite")]
        public static extern HRESULT DWriteCreateFactory(/* _In_ */ DWRITE_FACTORY_TYPE factoryType, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid iid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object factory);
        
        [DllImport("dxcapi")]
        public static extern HRESULT DxcCreateInstance(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid rclsid, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [DllImport("dxcapi")]
        public static extern HRESULT DxcCreateInstance2(/* _In_ */ ref IMalloc pMalloc, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid rclsid, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [DllImport("dxgidebug")]
        public static extern HRESULT DXGIGetDebugInterface([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] object ppDebug);
        
        [DllImport("dxtmpl")]
        public static extern bool DXIsValidAddress(ref IntPtr lp, uint nBytes, bool bReadWrite);
        
        [DllImport("dxva2api")]
        public static extern void DXVA2FixedToFloat(/* _In_ */ _DXVA2_Fixed32 _fixed_);
        
        [DllImport("dxva2api")]
        public static extern _DXVA2_Fixed32 DXVA2FloatToFixed(/* _In_ */ float _float_);
        
        [DllImport("dxva2api")]
        public static extern _DXVA2_Fixed32 DXVA2_Fixed32OpaqueAlpha();
        
        [DllImport("dxva2api")]
        public static extern _DXVA2_Fixed32 DXVA2_Fixed32TransparentAlpha();
        
        [DllImport("dxvahd")]
        public static extern HRESULT DXVAHD_CreateDevice(/* _In_ */ ref int pD3DDevice, /* _In_ */ ref _DXVAHD_CONTENT_DESC pContentDesc, /* _In_ */ _DXVAHD_DEVICE_USAGE Usage, /* _In_opt_ */ IntPtr pPlugin, /* _Outptr_ */ out IDXVAHD_Device ppDevice);
        
        [DllImport("evr")]
        public static extern HRESULT MFCreateVideoMixer(/* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pOwner, [MarshalAs(UnmanagedType.LPStruct)] Guid riidDevice, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [DllImport("evr")]
        public static extern HRESULT MFCreateVideoMixerAndPresenter(/* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pMixerOwner, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pPresenterOwner, [MarshalAs(UnmanagedType.LPStruct)] Guid riidMixer, /* _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvVideoMixer, [MarshalAs(UnmanagedType.LPStruct)] Guid riidPresenter, /* _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvVideoPresenter);
        
        [DllImport("evr")]
        public static extern HRESULT MFCreateVideoPresenter(/* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pOwner, [MarshalAs(UnmanagedType.LPStruct)] Guid riidDevice, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Outptr_result_maybenull_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppVideoPresenter);
        
        [DllImport("evr")]
        public static extern HRESULT MFCreateVideoRenderer([MarshalAs(UnmanagedType.LPStruct)] Guid riidRenderer, /* _Outptr_result_maybenull_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppVideoRenderer);
        
        [DllImport("evr")]
        public static extern HRESULT MFCreateVideoSampleAllocator(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppSampleAllocator);
        
        [DllImport("evr")]
        public static extern HRESULT MFCreateVideoSampleFromSurface(/* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pUnkSurface, /* _Out_ */ out IMFSample ppSample);
        
        [DllImport("mfplat")]
        public static extern uint HI32(ulong unPacked);
        
        [DllImport("mfplat")]
        public static extern uint LO32(ulong unPacked);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFAddPeriodicCallback(IntPtr Callback, [MarshalAs(UnmanagedType.IUnknown)] object pContext, /* _Out_opt_ */ out uint pdwKey);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFAllocateSerialWorkQueue(/* _In_ */ uint dwWorkQueue, /* _Out_ OUT */ out uint pdwWorkQueue);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFAllocateWorkQueue(/* _Out_ OUT */ out uint pdwWorkQueue);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFAllocateWorkQueueEx(/* _In_ */ MF WorkQueueType, /* _Out_ OUT */ out uint pdwWorkQueue);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFAverageTimePerFrameToFrameRate(/* _In_ */ ulong unAverageTimePerFrame, /* _Out_ */ out uint punNumerator, /* _Out_ */ out uint punDenominator);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFBeginCreateFile(__MIDL___MIDL_itf_mfobjects_0000_0017_0001 AccessMode, __MIDL___MIDL_itf_mfobjects_0000_0017_0002 OpenMode, __MIDL___MIDL_itf_mfobjects_0000_0017_0003 fFlags, [MarshalAs(UnmanagedType.LPWStr)] string pwszFilePath, ref IMFAsyncCallback pCallback, [MarshalAs(UnmanagedType.IUnknown)] object pState, /* _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppCancelCookie);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFBeginRegisterWorkQueueWithMMCSS(uint dwWorkQueueId, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string wszClass, uint dwTaskId, /* _In_ */ ref IMFAsyncCallback pDoneCallback, /* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pDoneState);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFBeginRegisterWorkQueueWithMMCSSEx(uint dwWorkQueueId, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string wszClass, uint dwTaskId, int lPriority, /* _In_ */ ref IMFAsyncCallback pDoneCallback, /* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pDoneState);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFBeginUnregisterWorkQueueWithMMCSS(uint dwWorkQueueId, /* _In_ */ ref IMFAsyncCallback pDoneCallback, /* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pDoneState);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCalculateBitmapImageSize(/* _In_reads_bytes_(cbBufSize) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] tagBITMAPINFOHEADER[] pBMIH, /* _In_ */ uint cbBufSize, /* _Out_ */ out uint pcbImageSize, /* _Out_opt_ */ out bool pbKnown);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCalculateImageSize(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidSubtype, /* _In_ */ uint unWidth, /* _In_ */ uint unHeight, /* _Out_ */ out uint pcbImageSize);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCancelCreateFile([MarshalAs(UnmanagedType.IUnknown)] object pCancelCookie);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCancelWorkItem(ulong Key);
        
        [DllImport("mfplat")]
        public static extern bool MFCompareFullToPartialMediaType(/* _In_ */ ref IMFMediaType pMFTypeFull, /* _In_ */ ref IMFMediaType pMFTypePartial);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFConvertColorInfoFromDXVA(/* _Inout_ */ ref _MFVIDEOFORMAT pToFormat, /* _In_ */ uint dwFromDXVA);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFConvertColorInfoToDXVA(/* _Out_ */ out uint pdwToDXVA, /* _In_ */ ref _MFVIDEOFORMAT pFromFormat);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFConvertFromFP16Array(/* _Out_writes_(dwCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] float[] pDest, /* _In_reads_(dwCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ushort[] pSrc, uint dwCount);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFConvertToFP16Array(/* _Out_writes_(dwCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ushort[] pDest, /* _In_reads_(dwCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] float[] pSrc, uint dwCount);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCopyImage(/* _Out_writes_bytes_(_Inexpressible_(abs(lDestStride) * dwLines)) */ [In, Out, MarshalAs(UnmanagedType.LPArray)] byte[] pDest, int lDestStride, /* _In_reads_bytes_(_Inexpressible_(abs(lSrcStride) * dwLines)) */ [In, Out, MarshalAs(UnmanagedType.LPArray)] byte[] pSrc, int lSrcStride, /* _Out_range_(<=, _Inexpressible_(min(abs(lSrcStride), abs(lDestStride)))) */ uint dwWidthInBytes, uint dwLines);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreate2DMediaBuffer(/* _In_ */ uint dwWidth, /* _In_ */ uint dwHeight, /* _In_ */ uint dwFourCC, /* _In_ */ bool fBottomUp, /* _Out_ */ out IMFMediaBuffer ppBuffer);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateAlignedMemoryBuffer(/* _In_ */ uint cbMaxLength, /* _In_ */ uint cbAligment, /* _Out_ */ out IMFMediaBuffer ppBuffer);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateAMMediaTypeFromMFMediaType(/* _In_ */ ref IMFMediaType pMFType, /* _In_ */ Guid guidFormatBlockType, /* _Inout_ */ ref _AMMediaType ppAMType);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateAsyncResult([MarshalAs(UnmanagedType.IUnknown)] object punkObject, ref IMFAsyncCallback pCallback, [MarshalAs(UnmanagedType.IUnknown)] object punkState, /* _Out_ */ out IMFAsyncResult ppAsyncResult);
        
        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////// Attributes //////////////////////////////////// /////////////////////////////////////////////////////////////////////////////
        /// </summary>
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateAttributes(/* _Out_ */ out IMFAttributes ppMFAttributes, /* _In_ */ uint cInitialSize);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateAudioMediaType(/* _In_ */ ref tWAVEFORMATEX pAudioFormat, /* _Out_ */ out IMFAudioMediaType ppIAudioMediaType);
        
        /// <summary>
        /// //////////////////////////// Collection //////////////////////////// /////////////////////////////////////////////////////////////////////////////
        /// </summary>
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateCollection(/* _Out_ */ out IMFCollection ppIMFCollection);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateDXGIDeviceManager(/* _Out_ */ out uint resetToken, /* _Outptr_ */ out IMFDXGIDeviceManager ppDeviceManager);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateDXGISurfaceBuffer(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object punkSurface, /* _In_ */ uint uSubresourceIndex, /* _In_ */ bool fBottomUpWhenLinear, /* _Outptr_ */ out IMFMediaBuffer ppBuffer);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateDXSurfaceBuffer(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object punkSurface, /* _In_ */ bool fBottomUpWhenLinear, /* _Outptr_ */ out IMFMediaBuffer ppBuffer);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateEventQueue(/* _Out_ */ out IMFMediaEventQueue ppMediaEventQueue);
        
        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////// ////////////////////////////// Files ////////////////////////////// ////////////////////////////////////////////////////////////////////////////
        /// </summary>
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateFile(__MIDL___MIDL_itf_mfobjects_0000_0017_0001 AccessMode, __MIDL___MIDL_itf_mfobjects_0000_0017_0002 OpenMode, __MIDL___MIDL_itf_mfobjects_0000_0017_0003 fFlags, [MarshalAs(UnmanagedType.LPWStr)] string pwszFileURL, /* _Out_ */ out IMFByteStream ppIByteStream);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateLegacyMediaBufferOnMFMediaBuffer(/* _In_opt_ */ ref IMFSample pSample, /* _In_ */ ref IMFMediaBuffer pMFMediaBuffer, /* _In_ */ uint cbOffset, /* _Outptr_ */ out IMediaBuffer ppMediaBuffer);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateMediaBufferFromMediaType(/* _In_ */ ref IMFMediaType pMediaType, /* _In_ */ long llDuration, /* needed for audio _In_ */ uint dwMinLength, /* // 0 means optimized default _In_ */ uint dwMinAlignment, /* // 0 means optimized default _Outptr_ */ out IMFMediaBuffer ppBuffer);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateMediaBufferWrapper(/* _In_ */ ref IMFMediaBuffer pBuffer, /* _In_ */ uint cbOffset, /* _In_ */ uint dwLength, /* _Out_ */ out IMFMediaBuffer ppBuffer);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateMediaEvent(/* _In_ */ uint met, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidExtendedType, /* _In_ */ HRESULT hrStatus, /* _In_opt_ */ PropVariant pvValue, /* _Out_ */ out IMFMediaEvent ppEvent);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateMediaExtensionActivate(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string szActivatableClassId, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pConfiguration, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvObject);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateMediaType(/* _Outptr_ */ out IMFMediaType ppMFType);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateMediaTypeFromRepresentation(Guid guidRepresentation, /* _In_ */ IntPtr pvRepresentation, /* _Out_ */ out IMFMediaType ppIMediaType);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateMemoryBuffer(/* _In_ */ uint cbMaxLength, /* _Out_ */ out IMFMediaBuffer ppBuffer);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateMFByteStreamWrapper(/* _In_ */ ref IMFByteStream pStream, /* _Out_ */ out IMFByteStream ppStreamWrapper);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateMFVideoFormatFromMFMediaType(/* _In_ */ ref IMFMediaType pMFType, /* _Out_ */ out _MFVIDEOFORMAT ppMFVF, /* // must be deleted with CoTaskMemFree _Out_opt_ */ out uint pcbSize);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateMuxStreamAttributes(/* _In_ */ ref IMFCollection pAttributesToMux, /* _COM_Outptr_ */ out IMFAttributes ppMuxAttribs);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateMuxStreamMediaType(/* _In_ */ ref IMFCollection pMediaTypesToMux, /* _COM_Outptr_ */ out IMFMediaType ppMuxMediaType);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateMuxStreamSample(/* _In_ */ ref IMFCollection pSamplesToMux, /* _COM_Outptr_ */ out IMFSample ppMuxSample);
        
        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////// //////////////////////////// Samples ////////////////////////////////////// /////////////////////////////////////////////////////////////////////////////
        /// </summary>
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateSample(/* _Out_ */ out IMFSample ppIMFSample);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateTempFile(__MIDL___MIDL_itf_mfobjects_0000_0017_0001 AccessMode, __MIDL___MIDL_itf_mfobjects_0000_0017_0002 OpenMode, __MIDL___MIDL_itf_mfobjects_0000_0017_0003 fFlags, /* _Out_ */ out IMFByteStream ppIByteStream);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateVideoMediaType(/* _In_ */ ref _MFVIDEOFORMAT pVideoFormat, /* _Out_ */ out IMFVideoMediaType ppIVideoMediaType);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateVideoMediaTypeFromBitMapInfoHeader(/* _In_ */ ref tagBITMAPINFOHEADER pbmihBitMapInfoHeader, uint dwPixelAspectRatioX, uint dwPixelAspectRatioY, _MFVideoInterlaceMode InterlaceMode, ulong VideoFlags, ulong qwFramesPerSecondNumerator, ulong qwFramesPerSecondDenominator, uint dwMaxBitRate, /* _Out_ */ out IMFVideoMediaType ppIVideoMediaType);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateVideoMediaTypeFromBitMapInfoHeaderEx(/* _In_reads_bytes_(cbBitMapInfoHeader) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] tagBITMAPINFOHEADER[] pbmihBitMapInfoHeader, /* _In_ */ uint cbBitMapInfoHeader, uint dwPixelAspectRatioX, uint dwPixelAspectRatioY, _MFVideoInterlaceMode InterlaceMode, ulong VideoFlags, uint dwFramesPerSecondNumerator, uint dwFramesPerSecondDenominator, uint dwMaxBitRate, /* _Out_ */ out IMFVideoMediaType ppIVideoMediaType);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateVideoMediaTypeFromSubtype(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pAMSubtype, /* _Out_ */ out IMFVideoMediaType ppIVideoMediaType);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateVideoSampleAllocatorEx(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppSampleAllocator);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateWaveFormatExFromMFMediaType(/* _In_ */ ref IMFMediaType pMFType, /* _Out_ */ out tWAVEFORMATEX ppWF, /* _Out_opt_ */ out uint pcbSize, /* _In_ */ uint Flags);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateWICBitmapBuffer(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object punkSurface, /* _Outptr_ */ out IMFMediaBuffer ppBuffer);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFEndCreateFile(ref IMFAsyncResult pResult, /* _Out_ */ out IMFByteStream ppFile);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFEndRegisterWorkQueueWithMMCSS(/* _In_ */ ref IMFAsyncResult pResult, /* _Out_ */ out uint pdwTaskId);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFEndUnregisterWorkQueueWithMMCSS(/* _In_ */ ref IMFAsyncResult pResult);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFFrameRateToAverageTimePerFrame(/* _In_ */ uint unNumerator, /* _In_ */ uint unDenominator, /* _Out_ */ out ulong punAverageTimePerFrame);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFGetAttribute2UINT32asUINT64(ref IMFAttributes pAttributes, [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* _Out_ */ out uint punHigh32, /* _Out_ */ out uint punLow32);
        
        [DllImport("mfplat")]
        public static extern void MFGetAttributeDouble(ref IMFAttributes pAttributes, [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, double fDefault);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFGetAttributeRatio(ref IMFAttributes pAttributes, [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* _Out_ */ out uint punNumerator, /* _Out_ */ out uint punDenominator);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFGetAttributesAsBlob(/* _In_ */ ref IMFAttributes pAttributes, /* _Out_writes_bytes_(cbBufSize) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] pBuf, /* _In_ */ uint cbBufSize);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFGetAttributesAsBlobSize(/* _In_ */ ref IMFAttributes pAttributes, /* _Out_ */ out uint pcbBufSize);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFGetAttributeSize(ref IMFAttributes pAttributes, [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* _Out_ */ out uint punWidth, /* _Out_ */ out uint punHeight);
        
        [DllImport("mfplat")]
        public static extern uint MFGetAttributeUINT32(ref IMFAttributes pAttributes, [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, uint unDefault);
        
        [DllImport("mfplat")]
        public static extern ulong MFGetAttributeUINT64(ref IMFAttributes pAttributes, [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, ulong unDefault);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFGetContentProtectionSystemCLSID(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidProtectionSystemID, /* _Out_ */ out Guid pclsid);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFGetMFTMerit(/* _Inout_ */ [MarshalAs(UnmanagedType.IUnknown)] object pMFT, /* _In_ */ uint cbVerifier, /* _In_reads_bytes_(cbVerifier) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] verifier, /* _Out_ */ out uint merit);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFGetPlaneSize(uint format, uint dwWidth, uint dwHeight, /* _Out_ */ out uint pdwPlaneSize);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFGetPluginControl(/* _Out_ */ out IMFPluginControl ppPluginControl);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFGetStrideForBitmapInfoHeader(uint format, uint dwWidth, /* _Out_ */ out long pStride);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFGetTimerPeriodicity(/* _Out_ */ out uint Periodicity);
        
        [DllImport("mfplat")]
        public static extern uint MFGetUncompressedVideoFormat(/* _In_ */ ref _MFVIDEOFORMAT pVideoFormat);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFGetWorkQueueMMCSSClass(uint dwWorkQueueId, /* _Out_writes_to_opt_(*pcchClass,*pcchClass) */ [MarshalAs(UnmanagedType.LPWStr)] string pwszClass, /* _Inout_ */ ref uint pcchClass);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFGetWorkQueueMMCSSPriority(uint dwWorkQueueId, /* _Out_ */ out long lPriority);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFGetWorkQueueMMCSSTaskId(uint dwWorkQueueId, /* _Out_ */ IntPtr pdwTaskId);
        
        [DllImport("mfplat")]
        public static extern void MFHeapAlloc(ulong nSize, uint dwFlags, /* _In_opt_ */ ref byte pszFile, int line, _EAllocationType eat);
        
        [DllImport("mfplat")]
        public static extern void MFHeapFree(ref IntPtr pv);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFInitAMMediaTypeFromMFMediaType(/* _In_ */ ref IMFMediaType pMFType, /* _In_ */ Guid guidFormatBlockType, /* _Inout_ */ ref _AMMediaType pAMType);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFInitAttributesFromBlob(/* _In_ */ ref IMFAttributes pAttributes, /* _In_reads_bytes_(cbBufSize) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] pBuf, /* _In_ */ uint cbBufSize);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFInitMediaTypeFromAMMediaType(/* _In_ */ ref IMFMediaType pMFType, /* _In_ */ ref _AMMediaType pAMType);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFInitMediaTypeFromMFVideoFormat(/* _In_ */ ref IMFMediaType pMFType, /* _In_reads_bytes_(cbBufSize) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] _MFVIDEOFORMAT[] pMFVF, /* _In_ */ uint cbBufSize);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFInitMediaTypeFromMPEG1VideoInfo(/* _In_ */ ref IMFMediaType pMFType, /* _In_reads_bytes_(cbBufSize) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagMPEG1VIDEOINFO[] pMP1VI, /* _In_ */ uint cbBufSize, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pSubtype);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFInitMediaTypeFromMPEG2VideoInfo(/* _In_ */ ref IMFMediaType pMFType, /* _In_reads_bytes_(cbBufSize) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagMPEG2VIDEOINFO[] pMP2VI, /* _In_ */ uint cbBufSize, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pSubtype);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFInitMediaTypeFromVideoInfoHeader(/* _In_ */ ref IMFMediaType pMFType, /* _In_reads_bytes_(cbBufSize) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagVIDEOINFOHEADER[] pVIH, /* _In_ */ uint cbBufSize, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pSubtype);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFInitMediaTypeFromVideoInfoHeader2(/* _In_ */ ref IMFMediaType pMFType, /* _In_reads_bytes_(cbBufSize) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagVIDEOINFOHEADER2[] pVIH2, /* _In_ */ uint cbBufSize, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pSubtype);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFInitMediaTypeFromWaveFormatEx(/* _In_ */ ref IMFMediaType pMFType, /* _In_reads_bytes_(cbBufSize) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tWAVEFORMATEX[] pWaveFormat, /* _In_ */ uint cbBufSize);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFInitVideoFormat(/* _In_ */ ref _MFVIDEOFORMAT pVideoFormat, /* _In_ */ _MFStandardVideoFormat type);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFInitVideoFormat_RGB(/* _In_ */ ref _MFVIDEOFORMAT pVideoFormat, /* _In_ */ uint dwWidth, /* _In_ */ uint dwHeight, /* _In_ */ uint D3Dfmt);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFInvokeCallback(ref IMFAsyncResult pAsyncResult);
        
        [DllImport("mfplat")]
        public static extern bool MFIsFormatYUV(uint Format);
        
        [DllImport("mfplat")]
        public static extern long MFllMulDiv(long a, long b, long c, long d);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFLockDXGIDeviceManager(/* _Out_opt_ */ out uint pResetToken, /* _Outptr_ */ out IMFDXGIDeviceManager ppManager);
        
        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////// ////////////////////////////// Platform /////////////////////////////// /////////////////////////////////////////////////////////////////////////////
        /// </summary>
        [DllImport("mfplat")]
        public static extern HRESULT MFLockPlatform();
        
        [DllImport("mfplat")]
        public static extern HRESULT MFLockSharedWorkQueue(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string wszClass, /* _In_ */ int BasePriority, /* _Inout_ */ ref uint pdwTaskId, /* _Out_ */ out uint pID);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFLockWorkQueue(/* _In_ */ uint dwWorkQueue);
        
        [DllImport("mfplat")]
        public static extern DXGI_FORMAT MFMapDX9FormatToDXGIFormat(/* _In_ */ uint dx9);
        
        [DllImport("mfplat")]
        public static extern uint MFMapDXGIFormatToDX9Format(/* _In_ */ DXGI_FORMAT dx11);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFPutWaitingWorkItem(IntPtr hEvent, int Priority, /* _In_ */ ref IMFAsyncResult pResult, /* _Out_opt_ */ out ulong pKey);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFPutWorkItem(uint dwQueue, ref IMFAsyncCallback pCallback, [MarshalAs(UnmanagedType.IUnknown)] object pState);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFPutWorkItem2(uint dwQueue, int Priority, /* _In_ */ ref IMFAsyncCallback pCallback, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pState);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFPutWorkItemEx(uint dwQueue, ref IMFAsyncResult pResult);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFPutWorkItemEx2(uint dwQueue, int Priority, /* _In_ */ ref IMFAsyncResult pResult);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFRegisterLocalByteStreamHandler(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string szFileExtension, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string szMimeType, /* _In_ */ ref IMFActivate pActivate);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFRegisterLocalSchemeHandler(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string szScheme, /* _In_ */ ref IMFActivate pActivate);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFRegisterPlatformWithMMCSS(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string wszClass, /* _Inout_ */ ref uint pdwTaskId, /* _In_ */ int lPriority);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFRemovePeriodicCallback(uint dwKey);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFScheduleWorkItem(ref IMFAsyncCallback pCallback, [MarshalAs(UnmanagedType.IUnknown)] object pState, long Timeout, /* _Out_opt_ */ out ulong pKey);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFScheduleWorkItemEx(ref IMFAsyncResult pResult, long Timeout, /* _Out_opt_ */ out ulong pKey);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFSetAttribute2UINT32asUINT64(ref IMFAttributes pAttributes, [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, uint unHigh32, uint unLow32);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFSetAttributeRatio(ref IMFAttributes pAttributes, [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, uint unNumerator, uint unDenominator);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFSetAttributeSize(ref IMFAttributes pAttributes, [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, uint unWidth, uint unHeight);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFShutdown();
        
        [DllImport("mfplat")]
        public static extern HRESULT MFStartup(uint Version, uint dwFlags);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFTEnum(/* _In_ */ Guid guidCategory, /* _In_ */ uint Flags, /* _In_opt_ */ ref __MIDL___MIDL_itf_mfobjects_0000_0008_0003 pInputType, /* _In_opt_ */ ref __MIDL___MIDL_itf_mfobjects_0000_0008_0003 pOutputType, /* _In_opt_ */ ref IMFAttributes pAttributes, /* _Outptr_result_buffer_(*pcMFTs) */ out Guid ppclsidMFT, /* // must be freed with CoTaskMemFree _Out_ */ out uint pcMFTs);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFTEnum2(/* _In_ */ Guid guidCategory, /* _In_ */ uint Flags, /* _In_opt_ */ ref __MIDL___MIDL_itf_mfobjects_0000_0008_0003 pInputType, /* _In_opt_ */ ref __MIDL___MIDL_itf_mfobjects_0000_0008_0003 pOutputType, /* _In_opt_ */ ref IMFAttributes pAttributes, /* _Outptr_result_buffer_( *pnumMFTActivate ) */ out IMFActivate[] pppMFTActivate, /* _Out_ */ out uint pnumMFTActivate);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFTEnumEx(/* _In_ */ Guid guidCategory, /* _In_ */ uint Flags, /* _In_opt_ */ ref __MIDL___MIDL_itf_mfobjects_0000_0008_0003 pInputType, /* _In_opt_ */ ref __MIDL___MIDL_itf_mfobjects_0000_0008_0003 pOutputType, /* _Outptr_result_buffer_(*pnumMFTActivate) */ out IMFActivate[] pppMFTActivate, /* _Out_ */ out uint pnumMFTActivate);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFTGetInfo(/* _In_ */ Guid clsidMFT, /* _Out_opt_ */ out IntPtr pszName, /* _Outptr_opt_result_buffer_(*pcInputTypes) */ out __MIDL___MIDL_itf_mfobjects_0000_0008_0003[] ppInputTypes, /* _Out_opt_ */ out uint pcInputTypes, /* _Outptr_opt_result_buffer_(*pcOutputTypes) */ out __MIDL___MIDL_itf_mfobjects_0000_0008_0003[] ppOutputTypes, /* _Out_opt_ */ out uint pcOutputTypes, /* _Outptr_opt_result_maybenull_ */ out IMFAttributes ppAttributes);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFTRegister(/* _In_ */ Guid clsidMFT, /* _In_ */ Guid guidCategory, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* _In_ */ uint Flags, /* _In_ */ uint cInputTypes, /* _In_reads_opt_(cInputTypes) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] __MIDL___MIDL_itf_mfobjects_0000_0008_0003[] pInputTypes, /* _In_ */ uint cOutputTypes, /* _In_reads_opt_(cOutputTypes) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] __MIDL___MIDL_itf_mfobjects_0000_0008_0003[] pOutputTypes, /* _In_opt_ */ ref IMFAttributes pAttributes);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFTRegisterLocal(/* _In_ */ ref IClassFactory pClassFactory, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidCategory, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* _In_ */ uint Flags, /* _In_ */ uint cInputTypes, /* _In_reads_opt_(cInputTypes) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] __MIDL___MIDL_itf_mfobjects_0000_0008_0003[] pInputTypes, /* _In_ */ uint cOutputTypes, /* _In_reads_opt_(cOutputTypes) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] __MIDL___MIDL_itf_mfobjects_0000_0008_0003[] pOutputTypes);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFTRegisterLocalByCLSID(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid clisdMFT, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidCategory, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* _In_ */ uint Flags, /* _In_ */ uint cInputTypes, /* _In_reads_opt_(cInputTypes) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] __MIDL___MIDL_itf_mfobjects_0000_0008_0003[] pInputTypes, /* _In_ */ uint cOutputTypes, /* _In_reads_opt_(cOutputTypes) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] __MIDL___MIDL_itf_mfobjects_0000_0008_0003[] pOutputTypes);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFTUnregister(/* _In_ */ Guid clsidMFT);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFTUnregisterLocal(/* _In_opt_ */ ref IClassFactory pClassFactory);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFTUnregisterLocalByCLSID(/* _In_ */ Guid clsidMFT);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFUnlockDXGIDeviceManager();
        
        [DllImport("mfplat")]
        public static extern HRESULT MFUnlockPlatform();
        
        [DllImport("mfplat")]
        public static extern HRESULT MFUnlockWorkQueue(/* _In_ */ uint dwWorkQueue);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFUnregisterPlatformFromMMCSS();
        
        [DllImport("mfplat")]
        public static extern HRESULT MFUnwrapMediaType(/* _In_ */ ref IMFMediaType pWrap, /* _Out_ */ out IMFMediaType ppOrig);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFValidateMediaTypeSize(/* _In_ */ Guid FormatType, /* _In_reads_bytes_opt_(cbSize) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] pBlock, /* _In_ */ uint cbSize);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFWrapMediaType(/* _In_ */ ref IMFMediaType pOrig, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid MajorType, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid SubType, /* _Out_ */ out IMFMediaType ppWrap);
        
        [DllImport("mfplat")]
        public static extern ulong Pack2UINT32AsUINT64(uint unHigh, uint unLow);
        
        [DllImport("mfplat")]
        public static extern ulong PackRatio(int nNumerator, uint unDenominator);
        
        [DllImport("mfplat")]
        public static extern ulong PackSize(uint unWidth, uint unHeight);
        
        [DllImport("mfplat")]
        public static extern void Unpack2UINT32AsUINT64(ulong unPacked, /* _Out_ */ out uint punHigh, /* _Out_ */ out uint punLow);
        
        [DllImport("mfplat")]
        public static extern void UnpackRatio(ulong unPacked, /* _Out_ */ out int pnNumerator, /* _Out_ */ out uint punDenominator);
        
        [DllImport("mfplat")]
        public static extern void UnpackSize(ulong unPacked, /* _Out_ */ out uint punWidth, /* _Out_ */ out uint punHeight);
        
        [DllImport("mfidl")]
        public static extern HRESULT CreateNamedPropertyStore(/* _Outptr_ */ out INamedPropertyStore ppStore);
        
        [DllImport("mfidl")]
        public static extern HRESULT CreatePropertyStore(/* out _Outptr_ */ out IPropertyStore ppStore);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreate3GPMediaSink(/* _In_ */ IMFByteStream pIByteStream, /* _In_opt_ */ IMFMediaType pVideoMediaType, /* _In_opt_ */ IMFMediaType pAudioMediaType, /* _Outptr_ */ out IMFMediaSink ppIMediaSink);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateAC3MediaSink(/* _In_ */ IMFByteStream pTargetByteStream, /* _In_ */ IMFMediaType pAudioMediaType, /* _Outptr_ */ out IMFMediaSink ppMediaSink);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateADTSMediaSink(/* _In_ */ IMFByteStream pTargetByteStream, /* _In_ */ IMFMediaType pAudioMediaType, /* _Outptr_ */ out IMFMediaSink ppMediaSink);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateAggregateSource(/* _In_ */ IMFCollection pSourceCollection, /* _Outptr_ */ out IMFMediaSource ppAggSource);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateAudioRenderer(IMFAttributes pAudioAttributes, /* _Outptr_ */ out IMFMediaSink ppSink);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateAudioRendererActivate(/* _Outptr_ */ out IMFActivate ppActivate);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateAVIMediaSink(/* _In_ */ IMFByteStream pIByteStream, /* _In_ */ IMFMediaType pVideoMediaType, /* _In_opt_ */ IMFMediaType pAudioMediaType, /* _Outptr_ */ out IMFMediaSink ppIMediaSink);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateContentDecryptorContext(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidMediaProtectionSystemId, /* _In_opt_ */ IMFDXGIDeviceManager pD3DManager, /* _In_ */ IMFContentProtectionDevice pContentProtectionDevice, /* _Outptr_ */ out IMFContentDecryptorContext ppContentDecryptorContext);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateContentProtectionDevice(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid ProtectionSystemId, /* _Outptr_ */ out IMFContentProtectionDevice ContentProtectionDevice);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateCredentialCache(/* _Outptr_ */ out IMFNetCredentialCache ppCache);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateDeviceSource(/* _In_ */ IMFAttributes pAttributes, /* _Outptr_ */ out IMFMediaSource ppSource);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateDeviceSourceActivate(/* _In_ */ IMFAttributes pAttributes, /* _Outptr_ */ out IMFActivate ppActivate);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateExtendedCameraIntrinsicModel(_MFCameraIntrinsic_DistortionModelType distortionModelType, /* _COM_Outptr_ */ out IMFExtendedCameraIntrinsicModel ppExtendedCameraIntrinsicModel);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateExtendedCameraIntrinsics(/* _COM_Outptr_ */ out IMFExtendedCameraIntrinsics ppExtendedCameraIntrinsics);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateFMPEG4MediaSink(/* _In_ */ IMFByteStream pIByteStream, /* _In_opt_ */ IMFMediaType pVideoMediaType, /* _In_opt_ */ IMFMediaType pAudioMediaType, /* _Outptr_ */ out IMFMediaSink ppIMediaSink);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateMediaSession(IMFAttributes pConfiguration, /* _Outptr_ */ out IMFMediaSession ppMediaSession);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateMediaTypeFromProperties(/* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object punkStream, /* _Outptr_ */ out IMFMediaType ppMediaType);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateMFByteStreamOnStream(ref IStream pStream, /* _Outptr_ */ out IMFByteStream ppByteStream);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateMFByteStreamOnStreamEx(/* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object punkStream, /* _Outptr_ */ out IMFByteStream ppByteStream);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateMP3MediaSink(/* _In_ */ IMFByteStream pTargetByteStream, /* _Outptr_ */ out IMFMediaSink ppMediaSink);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateMPEG4MediaSink(/* _In_ */ IMFByteStream pIByteStream, /* _In_opt_ */ IMFMediaType pVideoMediaType, /* _In_opt_ */ IMFMediaType pAudioMediaType, /* _Outptr_ */ out IMFMediaSink ppIMediaSink);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateMuxSink(/* _In_ */ Guid guidOutputSubType, /* _In_opt_ */ IMFAttributes pOutputAttributes, /* _In_opt_ */ IMFByteStream pOutputByteStream, /* _Outptr_ */ out IMFMediaSink ppMuxSink);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateNetSchemePlugin([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] object ppvHandler);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreatePMPMediaSession(uint dwCreationFlags, IMFAttributes pConfiguration, /* _Outptr_ */ out IMFMediaSession ppMediaSession, /* _Outptr_opt_ */ out IMFActivate ppEnablerActivate);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreatePMPServer(uint dwCreationFlags, /* _Outptr_ */ out IMFPMPServer ppPMPServer);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreatePresentationClock(/* _Outptr_ */ out IMFPresentationClock ppPresentationClock);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreatePresentationDescriptor(uint cStreamDescriptors, /* _In_reads_opt_( cStreamDescriptors ) */ out IMFStreamDescriptor[] apStreamDescriptors, /* _Outptr_ */ out IMFPresentationDescriptor ppPresentationDescriptor);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreatePropertiesFromMediaType(/* _In_ */ IMFMediaType pMediaType, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateProtectedEnvironmentAccess(/* _Outptr_ */ out IMFProtectedEnvironmentAccess ppAccess);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateProxyLocator([MarshalAs(UnmanagedType.LPWStr)] string pszProtocol, IPropertyStore pProxyConfig, /* _Outptr_ */ out IMFNetProxyLocator ppProxyLocator);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateRemoteDesktopPlugin(/* _Outptr_ */ out IMFRemoteDesktopPlugin ppPlugin);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateSampleCopierMFT(/* _Outptr_ */ out IMFTransform ppCopierMFT);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateSampleGrabberSinkActivate(IMFMediaType pIMFMediaType, IMFSampleGrabberSinkCallback pIMFSampleGrabberSinkCallback, /* _Outptr_ */ out IMFActivate ppIActivate);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateSensorActivityMonitor(/* _In_ */ IMFSensorActivitiesReportCallback pCallback, /* _COM_Outptr_ */ out IMFSensorActivityMonitor ppActivityMonitor);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateSensorGroup(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string SensorGroupSymbolicLink, /* _COM_Outptr_ */ out IMFSensorGroup ppSensorGroup);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateSensorProfile(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid ProfileType, /* _In_ */ uint ProfileIndex, /* _In_opt_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string Constraints, /* _COM_Outptr_ */ out IMFSensorProfile ppProfile);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateSensorProfileCollection(/* _COM_Outptr_ */ out IMFSensorProfileCollection ppSensorProfile);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateSensorStream(/* _In_ */ uint StreamId, /* _In_opt_ */ IMFAttributes pAttributes, /* _In_ */ IMFCollection pMediaTypeCollection, /* _COM_Outptr_ */ out IMFSensorStream ppStream);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateSequencerSegmentOffset(uint dwId, long hnsOffset, /* _Out_ */ out PropVariant pvarSegmentOffset);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateSequencerSource([MarshalAs(UnmanagedType.IUnknown)] object pReserved, /* _Outptr_ */ out IMFSequencerSource ppSequencerSource);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateSimpleTypeHandler(/* _Outptr_ */ out IMFMediaTypeHandler ppHandler);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateSourceResolver(/* out _Outptr_ */ out IMFSourceResolver ppISourceResolver);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateStandardQualityManager(/* _Outptr_ */ out IMFQualityManager ppQualityManager);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateStreamDescriptor(uint dwStreamIdentifier, uint cMediaTypes, /* _In_reads_(cMediaTypes) */ out IMFMediaType[] apMediaTypes, /* _Outptr_ */ out IMFStreamDescriptor ppDescriptor);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateStreamOnMFByteStream(/* _In_ */ IMFByteStream pByteStream, /* _Outptr_ */ out IStream ppStream);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateStreamOnMFByteStreamEx(/* _In_ */ IMFByteStream pByteStream, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateSystemTimeSource(/* _Outptr_ */ out IMFPresentationTimeSource ppSystemTimeSource);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateTopoLoader(/* _Outptr_ */ out IMFTopoLoader ppObj);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateTopology(/* _Outptr_ */ out IMFTopology ppTopo);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateTopologyNode(MF_TOPOLOGY_TYPE NodeType, /* _Outptr_ */ out IMFTopologyNode ppNode);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateTrackedSample(/* _Outptr_ */ out IMFTrackedSample ppMFSample);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateTranscodeProfile(/* _Outptr_ */ out IMFTranscodeProfile ppTranscodeProfile);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateTranscodeSinkActivate(/* _Outptr_ */ out IMFActivate ppActivate);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateTranscodeTopology(/* _In_ */ IMFMediaSource pSrc, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pwszOutputFilePath, /* _In_ */ IMFTranscodeProfile pProfile, /* _Outptr_ */ out IMFTopology ppTranscodeTopo);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateTranscodeTopologyFromByteStream(/* _In_ */ IMFMediaSource pSrc, /* _In_ */ IMFByteStream pOutputStream, /* _In_ */ IMFTranscodeProfile pProfile, /* _Out_ */ out IMFTopology ppTranscodeTopo);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateVideoRendererActivate(/* _In_ */ IntPtr hwndVideo, /* _Outptr_ */ out IMFActivate ppActivate);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFCreateWAVEMediaSink(/* _In_ */ IMFByteStream pTargetByteStream, /* _In_ */ IMFMediaType pAudioMediaType, /* _Outptr_ */ out IMFMediaSink ppMediaSink);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFDeserializePresentationDescriptor(/* _In_ */ uint cbData, /* _In_reads_( cbData ) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] byte[] pbData, /* _Outptr_ */ out IMFPresentationDescriptor ppPD);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFEnumDeviceSources(/* _In_ */ IMFAttributes pAttributes, /* _Outptr_result_buffer_(*pcSourceActivate) */ out IMFActivate[] pppSourceActivate, /* _Out_ */ out uint pcSourceActivate);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFGetLocalId(/* _In_reads_bytes_(size) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] verifier, /* _In_ */ uint size, /* _Outptr_ */ out IntPtr id);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFGetService([MarshalAs(UnmanagedType.IUnknown)] object punkObject, [MarshalAs(UnmanagedType.LPStruct)] Guid guidService, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvObject);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFGetSupportedMimeTypes(/* _Out_ */ out PropVariant pPropVarMimeTypeArray);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFGetSupportedSchemes(/* _Out_ */ out PropVariant pPropVarSchemeArray);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFGetSystemId(/* _Outptr_ */ out IMFSystemId ppId);
        
        [DllImport("mfidl")]
        public static extern long MFGetSystemTime();
        
        [DllImport("mfidl")]
        public static extern HRESULT MFGetTopoNodeCurrentType(IMFTopologyNode pNode, uint dwStreamIndex, bool fOutput, /* _Outptr_ */ out IMFMediaType ppType);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFIsContentProtectionDeviceSupported(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid ProtectionSystemId, /* _Out_ */ out bool isSupported);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFLoadSignedLibrary(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* _Outptr_ */ out IMFSignedLibrary ppLib);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFRequireProtectedEnvironment(/* _In_ */ IMFPresentationDescriptor pPresentationDescriptor);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFSerializePresentationDescriptor(/* _In_ */ IMFPresentationDescriptor pPD, /* _Out_ */ out uint pcbData, /* _Outptr_result_bytebuffer_to_(*pcbData, *pcbData) */ out byte[] ppbData);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFShutdownObject([MarshalAs(UnmanagedType.IUnknown)] object pUnk);
        
        [DllImport("mfidl")]
        public static extern HRESULT MFTranscodeGetAudioOutputAvailableTypes(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidSubType, /* _In_ */ uint dwMFTFlags, /* _In_opt_ */ IMFAttributes pCodecConfig, /* _Outptr_ */ out IMFCollection ppAvailableTypes);
        
        [DllImport("mfobjects")]
        public static extern HRESULT MFDeserializeAttributesFromStream(IMFAttributes pAttr, uint dwOptions, ref IStream pStm);
        
        [DllImport("mfobjects")]
        public static extern HRESULT MFSerializeAttributesToStream(IMFAttributes pAttr, uint dwOptions, ref IStream pStm);
        
        [DllImport("mfplay")]
        public static extern HRESULT MFPCreateMediaPlayer(/* _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string pwszURL, /* _In_ */ bool fStartPlayback, /* _In_opt_ */ uint creationOptions, /* _In_opt_ */ IMFPMediaPlayerCallback pCallback, /* _In_opt_ */ IntPtr hWnd, /* _Out_opt_ */ out IMFPMediaPlayer ppMediaPlayer);
        
        [DllImport("mfreadwrite")]
        public static extern HRESULT MFCreateSinkWriterFromMediaSink(/* _In_ */ ref int pMediaSink, /* _In_opt_ */ IMFAttributes pAttributes, /* _Out_ */ out IMFSinkWriter ppSinkWriter);
        
        [DllImport("mfreadwrite")]
        public static extern HRESULT MFCreateSinkWriterFromURL(/* _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string pwszOutputURL, /* _In_opt_ */ IMFByteStream pByteStream, /* _In_opt_ */ IMFAttributes pAttributes, /* _Out_ */ out IMFSinkWriter ppSinkWriter);
        
        [DllImport("mfreadwrite")]
        public static extern HRESULT MFCreateSourceReaderFromByteStream(/* _In_ */ IMFByteStream pByteStream, /* _In_opt_ */ IMFAttributes pAttributes, /* _Out_ */ out IMFSourceReader ppSourceReader);
        
        [DllImport("mfreadwrite")]
        public static extern HRESULT MFCreateSourceReaderFromMediaSource(/* _In_ */ ref int pMediaSource, /* _In_opt_ */ IMFAttributes pAttributes, /* _Out_ */ out IMFSourceReader ppSourceReader);
        
        [DllImport("mfreadwrite")]
        public static extern HRESULT MFCreateSourceReaderFromURL(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pwszURL, /* _In_opt_ */ IMFAttributes pAttributes, /* _Out_ */ out IMFSourceReader ppSourceReader);
        
        [DllImport("mftransform")]
        public static extern HRESULT MFCreateTransformActivate(/* _Out_ */ out IMFActivate ppActivate);
        
        [DllImport("mmdeviceapi")]
        public static extern HRESULT ActivateAudioInterfaceAsync(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string deviceInterfacePath, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _In_opt_ */ PropVariant activationParams, /* _In_ */ IActivateAudioInterfaceCompletionHandler completionHandler, /* _COM_Outptr_ */ out IActivateAudioInterfaceAsyncOperation activationOperation);
        
        [DllImport("propsys")]
        public static extern HRESULT PropVariantToWinRTPropertyValue(/* _In_ */ PropVariant propvar, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_result_maybenull_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [DllImport("propsys")]
        public static extern HRESULT PSCoerceToCanonicalValue(/* _In_ */ ref _tagpropertykey key, /* _Inout_ */ PropVariant ppropvar);
        
        [DllImport("propsys")]
        public static extern HRESULT PSCreateAdapterFromPropertyStore(/* _In_ */ IPropertyStore pps, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [DllImport("propsys")]
        public static extern HRESULT PSCreateDelayedMultiplexPropertyStore(/* _In_ */ GETPROPERTYSTOREFLAGS flags, /* _In_ */ IDelayedPropertyStoreFactory pdpsf, /* _In_reads_(cStores) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] uint[] rgStoreIds, /* _In_ */ uint cStores, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [DllImport("propsys")]
        public static extern HRESULT PSCreateMemoryPropertyStore(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [DllImport("propsys")]
        public static extern HRESULT PSCreateMultiplexPropertyStore(/* _In_reads_(cStores) */ [MarshalAs(UnmanagedType.IUnknown)] object prgpunkStores, /* _In_ */ uint cStores, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [DllImport("propsys")]
        public static extern HRESULT PSCreatePropertyChangeArray(/* _In_reads_opt_(cChanges) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] _tagpropertykey[] rgpropkey, /* _In_reads_opt_(cChanges) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] PKA_FLAGS[] rgflags, /* _In_reads_opt_(cChanges) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] PropVariant[] rgpropvar, /* _In_ */ uint cChanges, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [DllImport("propsys")]
        public static extern HRESULT PSCreatePropertyStoreFromObject(/* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object punk, /* _In_ */ uint grfMode, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [DllImport("propsys")]
        public static extern HRESULT PSCreatePropertyStoreFromPropertySetStorage(/* _In_ */ ref IPropertySetStorage ppss, /* _In_ */ uint grfMode, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [DllImport("propsys")]
        public static extern HRESULT PSCreateSimplePropertyChange(/* _In_ */ PKA_FLAGS flags, /* _In_ */ ref _tagpropertykey key, /* _In_ */ PropVariant propvar, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [DllImport("propsys")]
        public static extern HRESULT PSEnumeratePropertyDescriptions(/* _In_ */ PROPDESC_ENUMFILTER filterOn, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [DllImport("propsys")]
        public static extern HRESULT PSFormatForDisplay(/* _In_ */ ref _tagpropertykey propkey, /* _In_ */ PropVariant propvar, /* _In_ */ PROPDESC_FORMAT_FLAGS pdfFlags, /* _Out_writes_(cchText) */ [MarshalAs(UnmanagedType.LPWStr)] string pwszText, /* _In_ */ uint cchText);
        
        [DllImport("propsys")]
        public static extern HRESULT PSFormatForDisplayAlloc(/* _In_ */ ref _tagpropertykey key, /* _In_ */ PropVariant propvar, /* _In_ */ PROPDESC_FORMAT_FLAGS pdff, /* _Outptr_ */ out IntPtr ppszDisplay);
        
        [DllImport("propsys")]
        public static extern HRESULT PSFormatPropertyValue(/* _In_ */ IPropertyStore pps, /* _In_ */ IPropertyDescription ppd, /* _In_ */ PROPDESC_FORMAT_FLAGS pdff, /* _Outptr_ */ out IntPtr ppszDisplay);
        
        [DllImport("propsys")]
        public static extern HRESULT PSGetImageReferenceForValue(/* _In_ */ ref _tagpropertykey propkey, /* _In_ */ PropVariant propvar, /* _Outptr_ */ out IntPtr ppszImageRes);
        
        [DllImport("propsys")]
        public static extern HRESULT PSGetItemPropertyHandler(/* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object punkItem, /* _In_ */ bool fReadWrite, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [DllImport("propsys")]
        public static extern HRESULT PSGetItemPropertyHandlerWithCreateObject(/* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object punkItem, /* _In_ */ bool fReadWrite, /* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object punkCreateObject, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [DllImport("propsys")]
        public static extern HRESULT PSGetNamedPropertyFromPropertyStorage(/* _In_reads_bytes_(cb) */ IntPtr psps, /* _In_ */ uint cb, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* _Out_ */ out PropVariant ppropvar);
        
        [DllImport("propsys")]
        public static extern HRESULT PSGetNameFromPropertyKey(/* _In_ */ ref _tagpropertykey propkey, /* _Outptr_ */ out IntPtr ppszCanonicalName);
        
        [DllImport("propsys")]
        public static extern HRESULT PSGetPropertyDescription(/* _In_ */ ref _tagpropertykey propkey, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [DllImport("propsys")]
        public static extern HRESULT PSGetPropertyDescriptionByName(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pszCanonicalName, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [DllImport("propsys")]
        public static extern HRESULT PSGetPropertyDescriptionListFromString(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pszPropList, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [DllImport("propsys")]
        public static extern HRESULT PSGetPropertyFromPropertyStorage(/* _In_reads_bytes_(cb) */ IntPtr psps, /* _In_ */ uint cb, /* _In_ */ ref _tagpropertykey rpkey, /* _Out_ */ out PropVariant ppropvar);
        
        [DllImport("propsys")]
        public static extern HRESULT PSGetPropertyKeyFromName(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* _Out_ */ out _tagpropertykey ppropkey);
        
        [DllImport("propsys")]
        public static extern HRESULT PSGetPropertySystem(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [DllImport("propsys")]
        public static extern HRESULT PSGetPropertyValue(/* _In_ */ IPropertyStore pps, /* _In_ */ IPropertyDescription ppd, /* _Out_ */ out PropVariant ppropvar);
        
        [DllImport("propsys")]
        public static extern HRESULT PSLookupPropertyHandlerCLSID(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pszFilePath, /* _Out_ */ out Guid pclsid);
        
        [DllImport("propsys")]
        public static extern HRESULT PSPropertyBag_Delete(/* _In_ */ ref IPropertyBag propBag, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propName);
        
        [DllImport("propsys")]
        public static extern HRESULT PSPropertyBag_ReadBOOL(/* _In_ */ ref IPropertyBag propBag, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propName, /* _Out_ */ out bool value);
        
        [DllImport("propsys")]
        public static extern HRESULT PSPropertyBag_ReadBSTR(/* _In_ */ ref IPropertyBag propBag, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propName, /* _Outptr_ */ out IntPtr value);
        
        [DllImport("propsys")]
        public static extern HRESULT PSPropertyBag_ReadDWORD(/* _In_ */ ref IPropertyBag propBag, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propName, /* _Out_ */ out uint value);
        
        [DllImport("propsys")]
        public static extern HRESULT PSPropertyBag_ReadGUID(/* _In_ */ ref IPropertyBag propBag, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propName, /* _Out_ */ out Guid value);
        
        [DllImport("propsys")]
        public static extern HRESULT PSPropertyBag_ReadInt(/* _In_ */ ref IPropertyBag propBag, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propName, /* _Out_ */ out int value);
        
        [DllImport("propsys")]
        public static extern HRESULT PSPropertyBag_ReadLONG(/* _In_ */ ref IPropertyBag propBag, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propName, /* _Out_ */ out long value);
        
        [DllImport("propsys")]
        public static extern HRESULT PSPropertyBag_ReadPOINTL(/* _In_ */ ref IPropertyBag propBag, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propName, /* _Out_ */ out _POINTL value);
        
        [DllImport("propsys")]
        public static extern HRESULT PSPropertyBag_ReadPOINTS(/* _In_ */ ref IPropertyBag propBag, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propName, /* _Out_ */ out tagPOINTS value);
        
        [DllImport("propsys")]
        public static extern HRESULT PSPropertyBag_ReadPropertyKey(/* _In_ */ ref IPropertyBag propBag, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propName, /* _Out_ */ out _tagpropertykey value);
        
        [DllImport("propsys")]
        public static extern HRESULT PSPropertyBag_ReadRECTL(/* _In_ */ ref IPropertyBag propBag, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propName, /* _Out_ */ out _RECTL value);
        
        [DllImport("propsys")]
        public static extern HRESULT PSPropertyBag_ReadSHORT(/* _In_ */ ref IPropertyBag propBag, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propName, /* _Out_ */ out short value);
        
        [DllImport("propsys")]
        public static extern HRESULT PSPropertyBag_ReadStr(/* _In_ */ ref IPropertyBag propBag, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propName, /* _Out_writes_(characterCount) */ [MarshalAs(UnmanagedType.LPWStr)] string value, int characterCount);
        
        [DllImport("propsys")]
        public static extern HRESULT PSPropertyBag_ReadStrAlloc(/* _In_ */ ref IPropertyBag propBag, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propName, /* _Outptr_ */ out IntPtr value);
        
        [DllImport("propsys")]
        public static extern HRESULT PSPropertyBag_ReadStream(/* _In_ */ ref IPropertyBag propBag, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propName, /* _Outptr_ */ out IStream value);
        
        [DllImport("propsys")]
        public static extern HRESULT PSPropertyBag_ReadType(/* _In_ */ ref IPropertyBag propBag, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propName, /* _Out_ */ out object var, ushort type);
        
        [DllImport("propsys")]
        public static extern HRESULT PSPropertyBag_ReadULONGLONG(/* _In_ */ ref IPropertyBag propBag, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propName, /* _Out_ */ out ulong value);
        
        [DllImport("propsys")]
        public static extern HRESULT PSPropertyBag_ReadUnknown(/* _In_ */ ref IPropertyBag propBag, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propName, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [DllImport("propsys")]
        public static extern HRESULT PSPropertyBag_WriteBOOL(/* _In_ */ ref IPropertyBag propBag, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propName, bool value);
        
        [DllImport("propsys")]
        public static extern HRESULT PSPropertyBag_WriteBSTR(/* _In_ */ ref IPropertyBag propBag, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propName, /* _In_ */ [MarshalAs(UnmanagedType.BStr)] string value);
        
        [DllImport("propsys")]
        public static extern HRESULT PSPropertyBag_WriteDWORD(/* _In_ */ ref IPropertyBag propBag, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propName, uint value);
        
        [DllImport("propsys")]
        public static extern HRESULT PSPropertyBag_WriteGUID(/* _In_ */ ref IPropertyBag propBag, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propName, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid value);
        
        [DllImport("propsys")]
        public static extern HRESULT PSPropertyBag_WriteInt(/* _In_ */ ref IPropertyBag propBag, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propName, int value);
        
        [DllImport("propsys")]
        public static extern HRESULT PSPropertyBag_WriteLONG(/* _In_ */ ref IPropertyBag propBag, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propName, int value);
        
        [DllImport("propsys")]
        public static extern HRESULT PSPropertyBag_WritePOINTL(/* _In_ */ ref IPropertyBag propBag, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propName, /* _In_ */ ref _POINTL value);
        
        [DllImport("propsys")]
        public static extern HRESULT PSPropertyBag_WritePOINTS(/* _In_ */ ref IPropertyBag propBag, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propName, /* _In_ */ ref tagPOINTS value);
        
        [DllImport("propsys")]
        public static extern HRESULT PSPropertyBag_WritePropertyKey(/* _In_ */ ref IPropertyBag propBag, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propName, /* _In_ */ ref _tagpropertykey value);
        
        [DllImport("propsys")]
        public static extern HRESULT PSPropertyBag_WriteRECTL(/* _In_ */ ref IPropertyBag propBag, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propName, /* _In_ */ ref _RECTL value);
        
        [DllImport("propsys")]
        public static extern HRESULT PSPropertyBag_WriteSHORT(/* _In_ */ ref IPropertyBag propBag, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propName, short value);
        
        [DllImport("propsys")]
        public static extern HRESULT PSPropertyBag_WriteStr(/* _In_ */ ref IPropertyBag propBag, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propName, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string value);
        
        [DllImport("propsys")]
        public static extern HRESULT PSPropertyBag_WriteStream(/* _In_ */ ref IPropertyBag propBag, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propName, /* _In_ */ ref IStream value);
        
        [DllImport("propsys")]
        public static extern HRESULT PSPropertyBag_WriteULONGLONG(/* _In_ */ ref IPropertyBag propBag, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propName, ulong value);
        
        [DllImport("propsys")]
        public static extern HRESULT PSPropertyBag_WriteUnknown(/* _In_ */ ref IPropertyBag propBag, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propName, /* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object punk);
        
        [DllImport("propsys")]
        public static extern HRESULT PSPropertyKeyFromString(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pszString, /* _Out_ */ out _tagpropertykey pkey);
        
        [DllImport("propsys")]
        public static extern HRESULT PSRefreshPropertySchema();
        
        [DllImport("propsys")]
        public static extern HRESULT PSRegisterPropertySchema(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pszPath);
        
        [DllImport("propsys")]
        public static extern HRESULT PSSetPropertyValue(/* _In_ */ IPropertyStore pps, /* _In_ */ IPropertyDescription ppd, /* _In_ */ PropVariant propvar);
        
        [DllImport("propsys")]
        public static extern HRESULT PSStringFromPropertyKey(/* _In_ */ ref _tagpropertykey pkey, /* _Out_writes_(cch) */ [MarshalAs(UnmanagedType.LPWStr)] string psz, /* _In_ */ uint cch);
        
        [DllImport("propsys")]
        public static extern HRESULT PSUnregisterPropertySchema(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pszPath);
        
        [DllImport("propsys")]
        public static extern HRESULT WinRTPropertyValueToPropVariant(/* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object punkPropertyValue, /* _Out_ */ out PropVariant ppropvar);
        
        [DllImport("wincodec")]
        public static extern HRESULT WICConvertBitmapSource(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid dstFormat, /* // Destination pixel format _In_ */ IWICBitmapSource pISrc, /* // Source bitmap _Outptr_ */ out IWICBitmapSource ppIDst);
        
        [DllImport("wincodec")]
        public static extern HRESULT WICCreateBitmapFromSection(/* _In_ */ uint width, /* _In_ */ uint height, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pixelFormat, /* _In_ */ IntPtr hSection, /* _In_ */ uint stride, /* _In_ */ uint offset, /* _Outptr_ */ out IWICBitmap ppIBitmap);
        
        [DllImport("wincodec")]
        public static extern HRESULT WICCreateBitmapFromSectionEx(/* _In_ */ uint width, /* _In_ */ uint height, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pixelFormat, /* _In_ */ IntPtr hSection, /* _In_ */ uint stride, /* _In_ */ uint offset, /* _In_ */ WICSectionAccessLevel desiredAccessLevel, /* _Outptr_ */ out IWICBitmap ppIBitmap);
        
        [DllImport("wincodec")]
        public static extern HRESULT WICMapGuidToShortName(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _In_ */ uint cchName, /* _Inout_updates_opt_(cchName) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] char[] wzName, /* _Out_ */ out uint pcchActual);
        
        [DllImport("wincodec")]
        public static extern HRESULT WICMapSchemaToName(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidMetadataFormat, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pwzSchema, /* _In_ */ uint cchName, /* _Inout_updates_opt_(cchName) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] char[] wzName, /* _Out_ */ out uint pcchActual);
        
        [DllImport("wincodec")]
        public static extern HRESULT WICMapShortNameToGuid(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string wzName, /* _Out_ */ out Guid pguid);
        
        [DllImport("wincodecsdk")]
        public static extern HRESULT WICGetMetadataContentSize(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidContainerFormat, /* _In_ */ IWICMetadataWriter pIWriter, /* _Out_ */ out ulong pcbSize);
        
        [DllImport("wincodecsdk")]
        public static extern HRESULT WICMatchMetadataContent(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidContainerFormat, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pguidVendor, /* _In_ */ ref IStream pIStream, /* _Out_ */ out Guid pguidMetadataFormat);
        
        [DllImport("wincodecsdk")]
        public static extern HRESULT WICSerializeMetadataContent(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidContainerFormat, /* _In_ */ IWICMetadataWriter pIWriter, /* _In_ */ uint dwPersistOptions, /* _In_ */ ref IStream pIStream);
    }
}
