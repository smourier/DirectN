using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using ABORTPROC = System.IntPtr;
using AM_MEDIA_TYPE = DirectN._AMMediaType;
using COLORREF = System.UInt32;
using DXVA2_Fixed32 = DirectN._DXVA2_Fixed32;
using ENHMFENUMPROC = System.IntPtr;
using FONTENUMPROCA = System.IntPtr;
using FONTENUMPROCW = System.IntPtr;
using GOBJENUMPROC = System.IntPtr;
using ICMENUMPROCA = System.IntPtr;
using ICMENUMPROCW = System.IntPtr;
using LINEDDAPROC = System.IntPtr;
using LPCWAVEFORMATEX = DirectN.tWAVEFORMATEX;
using LPD3DHAL_CALLBACKS = DirectN._D3DHAL_CALLBACKS;
using LPD3DHAL_GLOBALDRIVERDATA = DirectN._D3DHAL_GLOBALDRIVERDATA;
using LPDDENUMCALLBACKA = System.IntPtr;
using LPDDENUMCALLBACKEXA = System.IntPtr;
using LPDDENUMCALLBACKEXW = System.IntPtr;
using LPDDENUMCALLBACKW = System.IntPtr;
using LPDDRAWI_DIRECTDRAW_GBL = DirectN._DDRAWI_DIRECTDRAW_GBL;
using LPDIRECTDRAW = DirectN.IDirectDraw;
using LPDIRECTDRAWCLIPPER = DirectN.IDirectDrawClipper;
using LPDIRECTDRAWSURFACE = DirectN.IDirectDrawSurface;
using LPHMIDIIN = DirectN.HMIDIIN__;
using LPHMIDIOUT = DirectN.HMIDIOUT__;
using LPHMIDISTRM = DirectN.HMIDISTRM__;
using LPHMIXER = DirectN.HMIXER__;
using LPHWAVEIN = DirectN.HWAVEIN__;
using LPHWAVEOUT = DirectN.HWAVEOUT__;
using LPMETARECORD = DirectN.__tagMETARECORD;
using LPVIDMEM = DirectN._VIDMEM;
using MFASYNC_WORKQUEUE_TYPE = DirectN.MF;
using MFCameraIntrinsic_DistortionModelType = DirectN._MFCameraIntrinsic_DistortionModelType;
using MFENUMPROC = System.IntPtr;
using MFGPHONE_SIMLINEEVENT_NOTIFY_CALLBACK = System.IntPtr;
using MFPERIODICCALLBACK = System.IntPtr;
using MFWORKITEM_KEY = System.UInt64;
using MPEG1VIDEOINFO = DirectN.tagMPEG1VIDEOINFO;
using MPEG2VIDEOINFO = DirectN.tagMPEG2VIDEOINFO;
using PDXVAHDSW_Plugin = System.IntPtr;
using PROC = System.IntPtr;
using REFWICPixelFormatGUID = System.Guid;
using VIDEOINFOHEADER = DirectN.tagVIDEOINFOHEADER;
using VIDEOINFOHEADER2 = DirectN.tagVIDEOINFOHEADER2;

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
        public static extern HRESULT Direct3DCreate9Ex(uint SDKVersion, out IDirect3D9Ex __unnamed_1);
        
        [DllImport("d3dkmdt")]
        public static extern _D3DKMDT_VIDPN_PRESENT_PATH_ROTATION D3DKMDT_VPPR_GET_CONTENT_ROTATION(_D3DKMDT_VIDPN_PRESENT_PATH_ROTATION Rotation);
        
        [DllImport("d3dkmdt")]
        public static extern _D3DKMDT_VIDPN_PRESENT_PATH_ROTATION D3DKMDT_VPPR_GET_CONTENT_ROTATION_PART(_D3DKMDT_VIDPN_PRESENT_PATH_ROTATION Rotation);
        
        [DllImport("d3dkmdt")]
        public static extern _D3DKMDT_VIDPN_PRESENT_PATH_ROTATION D3DKMDT_VPPR_GET_OFFSET_ROTATION(_D3DKMDT_VIDPN_PRESENT_PATH_ROTATION Rotation);
        
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
        
        [DllImport("ks")]
        public static extern uint KsCreateAllocator(/* _In_ */ IntPtr ConnectionHandle, /* _In_ */ ref KSALLOCATOR_FRAMING AllocatorFraming, /* _Out_ */ out IntPtr AllocatorHandle);
        
        [DllImport("ks")]
        public static extern HRESULT KsCreateAllocator2(/* _In_ */ IntPtr ConnectionHandle, /* _In_ */ ref KSALLOCATOR_FRAMING AllocatorFraming, /* _Out_ */ out IntPtr AllocatorHandle);
        
        [DllImport("ks")]
        public static extern uint KsCreateClock(/* _In_ */ IntPtr ConnectionHandle, /* _In_ */ ref KSCLOCK_CREATE ClockCreate, /* _Out_ */ out IntPtr ClockHandle);
        
        [DllImport("ks")]
        public static extern HRESULT KsCreateClock2(/* _In_ */ IntPtr ConnectionHandle, /* _In_ */ ref KSCLOCK_CREATE ClockCreate, /* _Out_ */ out IntPtr ClockHandle);
        
        [DllImport("ks")]
        public static extern uint KsCreatePin(/* _In_ */ IntPtr FilterHandle, /* _In_ */ ref KSPIN_CONNECT Connect, /* _In_ */ uint DesiredAccess, /* _Out_ */ out IntPtr ConnectionHandle);
        
        [DllImport("ks")]
        public static extern HRESULT KsCreatePin2(/* _In_ */ IntPtr FilterHandle, /* _In_ */ ref KSPIN_CONNECT Connect, /* _In_ */ uint DesiredAccess, /* _Out_ */ out IntPtr ConnectionHandle);
        
        [DllImport("ks")]
        public static extern uint KsCreateTopologyNode(/* _In_ */ IntPtr ParentHandle, /* _In_ */ ref KSNODE_CREATE NodeCreate, /* _In_ */ uint DesiredAccess, /* _Out_ */ out IntPtr NodeHandle);
        
        [DllImport("ks")]
        public static extern HRESULT KsCreateTopologyNode2(/* _In_ */ IntPtr ParentHandle, /* _In_ */ ref KSNODE_CREATE NodeCreate, /* _In_ */ uint DesiredAccess, /* _Out_ */ out IntPtr NodeHandle);
        
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
        public static extern HRESULT CreateAudioMediaType(ref tWAVEFORMATEX pAudioFormat, uint cbAudioFormatSize, out IAudioMediaType ppIAudioMediaType);
        
        [DllImport("audiomediatype")]
        public static extern HRESULT CreateAudioMediaTypeFromUncompressedAudioFormat(ref _UNCOMPRESSEDAUDIOFORMAT pUncompressedAudioFormat, out IAudioMediaType ppIAudioMediaType);
        
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
        public static extern D2D1_LAYER_PARAMETERS LayerParameters(/* _In_ */ ref D2D_RECT_F contentBounds, /* _In_opt_ */ ID2D1Geometry geometricMask, D2D1_ANTIALIAS_MODE maskAntialiasMode, D2D_MATRIX_3X2_F maskTransform, float opacity, /* _In_opt_ */ ID2D1Brush opacityBrush, D2D1_LAYER_OPTIONS layerOptions);
        
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
        public static extern HRESULT D2D1CreateDevice(/* _In_ */ IDXGIDevice dxgiDevice, /* _In_ */ ref D2D1_CREATION_PROPERTIES creationProperties, /* _Outptr_ */ out ID2D1Device d2dDevice);
        
        [DllImport("d2d1")]
        public static extern HRESULT D2D1CreateDeviceContext(/* _In_ */ IDXGISurface dxgiSurface, /* _In_ */ ref D2D1_CREATION_PROPERTIES creationProperties, /* _Outptr_ */ out ID2D1DeviceContext d2dDeviceContext);
        
        [DllImport("d2d1")]
        public static extern void D2D1SinCos(/* _In_ */ float angle, /* _Out_ */ out float s, /* _Out_ */ out float c);
        
        [DllImport("d2d1")]
        public static extern float D2D1Tan(/* _In_ */ float angle);
        
        [DllImport("d2d1")]
        public static extern float D2D1Vec3Length(/* _In_ */ float x, /* _In_ */ float y, /* _In_ */ float z);
        
        [DllImport("d2d1")]
        public static extern D2D1_BITMAP_BRUSH_PROPERTIES1 BitmapBrushProperties1(D2D1_EXTEND_MODE extendModeX, D2D1_EXTEND_MODE extendModeY, D2D1_INTERPOLATION_MODE interpolationMode);
        
        [DllImport("d2d1")]
        public static extern D2D1_BITMAP_PROPERTIES1 BitmapProperties1(D2D1_BITMAP_OPTIONS bitmapOptions, /* _In_ */ D2D1_PIXEL_FORMAT pixelFormat, float dpiX, float dpiY, /* _In_opt_ */ ID2D1ColorContext colorContext);
        
        [DllImport("d2d1")]
        public static extern _D3DCOLORVALUE ConvertColorSpace(D2D1_COLOR_SPACE sourceColorSpace, D2D1_COLOR_SPACE destinationColorSpace, ref _D3DCOLORVALUE color);
        
        [DllImport("d2d1")]
        public static extern D2D1_CREATION_PROPERTIES CreationProperties(D2D1_THREADING_MODE threadingMode, D2D1_DEBUG_LEVEL debugLevel, D2D1_DEVICE_CONTEXT_OPTIONS options);
        
        [DllImport("d2d1")]
        public static extern D2D1_DRAWING_STATE_DESCRIPTION1 DrawingStateDescription1(/* _In_ */ ref D2D1_DRAWING_STATE_DESCRIPTION desc, D2D1_PRIMITIVE_BLEND primitiveBlend, D2D1_UNIT_MODE unitMode);
        
        [DllImport("d2d1")]
        public static extern D2D1_EFFECT_INPUT_DESCRIPTION EffectInputDescription(ID2D1Effect effect, uint inputIndex, D2D_RECT_F inputRectangle);
        
        [DllImport("d2d1")]
        public static extern D2D1_IMAGE_BRUSH_PROPERTIES ImageBrushProperties(D2D_RECT_F sourceRectangle, D2D1_EXTEND_MODE extendModeX, D2D1_EXTEND_MODE extendModeY, D2D1_INTERPOLATION_MODE interpolationMode);
        
        [DllImport("d2d1")]
        public static extern D2D1_LAYER_PARAMETERS1 LayerParameters1(/* _In_ */ ref D2D_RECT_F contentBounds, /* _In_opt_ */ ID2D1Geometry geometricMask, D2D1_ANTIALIAS_MODE maskAntialiasMode, D2D_MATRIX_3X2_F maskTransform, float opacity, /* _In_opt_ */ ID2D1Brush opacityBrush, D2D1_LAYER_OPTIONS1 layerOptions);
        
        [DllImport("d2d1")]
        public static extern tagPOINT Point2L(int x, int y);
        
        [DllImport("d2d1")]
        public static extern D2D1_PRINT_CONTROL_PROPERTIES PrintControlProperties(D2D1_PRINT_FONT_SUBSET_MODE fontSubsetMode, float rasterDpi, D2D1_COLOR_SPACE colorSpace);
        
        [DllImport("d2d1")]
        public static extern tagRECT RectL(int left, int top, int right, int bottom);
        
        [DllImport("d2d1")]
        public static extern D2D1_RENDERING_CONTROLS RenderingControls(D2D1_BUFFER_PRECISION bufferPrecision, D2D_SIZE_U tileSize);
        
        [DllImport("d2d1")]
        public static extern HRESULT SetDpiCompensatedEffectInput(/* _In_ */ ID2D1DeviceContext deviceContext, /* _In_ */ ID2D1Effect effect, uint inputIndex, /* _In_opt_ */ ID2D1Bitmap inputBitmap, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_BORDER_MODE borderMode);
        
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
        public static extern HRESULT D3D10CompileEffectFromMemory(/* _In_reads_bytes_(DataLength) */ [MarshalAs(UnmanagedType.IUnknown)] object pData, IntPtr DataLength, [MarshalAs(UnmanagedType.LPStr)] string pSrcFileName, /* optional(_D3D_SHADER_MACRO) */ IntPtr pDefines, /* _In_opt_ */ ID3DInclude pInclude, uint HLSLFlags, uint FXFlags, /* _Out_ */ out ID3D10Blob ppCompiledEffect, /* _Out_opt_ */ out ID3D10Blob ppErrors);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10CreateEffectFromMemory(/* _In_reads_bytes_(DataLength) */ [MarshalAs(UnmanagedType.IUnknown)] object pData, IntPtr DataLength, uint FXFlags, /* _In_ */ ID3D10Device pDevice, /* _In_opt_ */ ID3D10EffectPool pEffectPool, /* _Out_ */ out ID3D10Effect ppEffect);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10CreateEffectPoolFromMemory(/* _In_reads_bytes_(DataLength) */ [MarshalAs(UnmanagedType.IUnknown)] object pData, IntPtr DataLength, uint FXFlags, /* _In_ */ ID3D10Device pDevice, /* _Out_ */ out ID3D10EffectPool ppEffectPool);
        
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
        public static extern HRESULT D3D10CreateBlob(IntPtr NumBytes, /* _Out_ */ out ID3D10Blob ppBuffer);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10CreateDevice(/* _In_opt_ */ IDXGIAdapter pAdapter, D3D10_DRIVER_TYPE DriverType, IntPtr Software, uint Flags, uint SDKVersion, /* _Out_opt_ */ out ID3D10Device ppDevice);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10CreateDeviceAndSwapChain(/* _In_opt_ */ IDXGIAdapter pAdapter, D3D10_DRIVER_TYPE DriverType, IntPtr Software, uint Flags, uint SDKVersion, /* optional(DXGI_SWAP_CHAIN_DESC) */ IntPtr pSwapChainDesc, /* _Out_opt_ */ out IDXGISwapChain ppSwapChain, /* _Out_opt_ */ out ID3D10Device ppDevice);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10CompileShader(/* _In_reads_bytes_(SrcDataSize) */ [MarshalAs(UnmanagedType.LPStr)] string pSrcData, IntPtr SrcDataSize, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string pFileName, /* optional(_D3D_SHADER_MACRO) */ IntPtr pDefines, /* _In_opt_ */ ID3DInclude pInclude, [MarshalAs(UnmanagedType.LPStr)] string pFunctionName, [MarshalAs(UnmanagedType.LPStr)] string pProfile, uint Flags, /* _Out_ */ out ID3D10Blob ppShader, /* _Out_opt_ */ out ID3D10Blob ppErrorMsgs);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10DisassembleShader(/* _In_reads_bytes_(BytecodeLength) */ IntPtr pShader, IntPtr BytecodeLength, bool EnableColorCode, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string pComments, /* _Out_ */ out ID3D10Blob ppDisassembly);
        
        [DllImport("d3d10")]
        public static extern string D3D10GetGeometryShaderProfile(/* _In_ */ ID3D10Device pDevice);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10GetInputAndOutputSignatureBlob(/* _In_reads_bytes_(BytecodeLength) */ IntPtr pShaderBytecode, IntPtr BytecodeLength, /* _Out_ */ out ID3D10Blob ppSignatureBlob);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10GetInputSignatureBlob(/* _In_reads_bytes_(BytecodeLength) */ IntPtr pShaderBytecode, IntPtr BytecodeLength, /* _Out_ */ out ID3D10Blob ppSignatureBlob);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10GetOutputSignatureBlob(/* _In_reads_bytes_(BytecodeLength) */ IntPtr pShaderBytecode, IntPtr BytecodeLength, /* _Out_ */ out ID3D10Blob ppSignatureBlob);
        
        [DllImport("d3d10")]
        public static extern string D3D10GetPixelShaderProfile(/* _In_ */ ID3D10Device pDevice);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10GetShaderDebugInfo(/* _In_reads_bytes_(BytecodeLength) */ IntPtr pShaderBytecode, IntPtr BytecodeLength, /* _Out_ */ out ID3D10Blob ppDebugInfo);
        
        [DllImport("d3d10")]
        public static extern string D3D10GetVertexShaderProfile(/* _In_ */ ID3D10Device pDevice);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10PreprocessShader(/* _In_reads_bytes_(SrcDataSize) */ [MarshalAs(UnmanagedType.LPStr)] string pSrcData, IntPtr SrcDataSize, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string pFileName, /* optional(_D3D_SHADER_MACRO) */ IntPtr pDefines, /* _In_opt_ */ ID3DInclude pInclude, /* _Out_ */ out ID3D10Blob ppShaderText, /* _Out_opt_ */ out ID3D10Blob ppErrorMsgs);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10ReflectShader(/* _In_reads_bytes_(BytecodeLength) */ IntPtr pShaderBytecode, IntPtr BytecodeLength, /* _Out_ */ out ID3D10ShaderReflection ppReflector);
        
        [DllImport("d3d10")]
        public static extern D3D10DDI_HADAPTER MAKE_D3D10DDI_HADAPTER([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D10DDI_HBLENDSTATE MAKE_D3D10DDI_HBLENDSTATE([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D10DDI_HDEPTHSTENCILSTATE MAKE_D3D10DDI_HDEPTHSTENCILSTATE([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D10DDI_HDEPTHSTENCILVIEW MAKE_D3D10DDI_HDEPTHSTENCILVIEW([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D10DDI_HDEVICE MAKE_D3D10DDI_HDEVICE([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D10DDI_HELEMENTLAYOUT MAKE_D3D10DDI_HELEMENTLAYOUT([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D10DDI_HKMALLOCATION MAKE_D3D10DDI_HKMALLOCATION(uint h);
        
        [DllImport("d3d10")]
        public static extern D3D10DDI_HKMDEVICE MAKE_D3D10DDI_HKMDEVICE(uint h);
        
        [DllImport("d3d10")]
        public static extern D3D10DDI_HKMRESOURCE MAKE_D3D10DDI_HKMRESOURCE(uint h);
        
        [DllImport("d3d10")]
        public static extern D3D10DDI_HQUERY MAKE_D3D10DDI_HQUERY([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D10DDI_HRASTERIZERSTATE MAKE_D3D10DDI_HRASTERIZERSTATE([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D10DDI_HRENDERTARGETVIEW MAKE_D3D10DDI_HRENDERTARGETVIEW([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D10DDI_HRESOURCE MAKE_D3D10DDI_HRESOURCE([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D10DDI_HRTADAPTER MAKE_D3D10DDI_HRTADAPTER([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D10DDI_HRTBLENDSTATE MAKE_D3D10DDI_HRTBLENDSTATE([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D10DDI_HRTCORELAYER MAKE_D3D10DDI_HRTCORELAYER([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D10DDI_HRTDEPTHSTENCILSTATE MAKE_D3D10DDI_HRTDEPTHSTENCILSTATE([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D10DDI_HRTDEPTHSTENCILVIEW MAKE_D3D10DDI_HRTDEPTHSTENCILVIEW([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D10DDI_HRTDEVICE MAKE_D3D10DDI_HRTDEVICE([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D10DDI_HRTELEMENTLAYOUT MAKE_D3D10DDI_HRTELEMENTLAYOUT([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D10DDI_HRTQUERY MAKE_D3D10DDI_HRTQUERY([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D10DDI_HRTRASTERIZERSTATE MAKE_D3D10DDI_HRTRASTERIZERSTATE([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D10DDI_HRTRENDERTARGETVIEW MAKE_D3D10DDI_HRTRENDERTARGETVIEW([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D10DDI_HRTRESOURCE MAKE_D3D10DDI_HRTRESOURCE([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D10DDI_HRTSAMPLER MAKE_D3D10DDI_HRTSAMPLER([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D10DDI_HRTSHADER MAKE_D3D10DDI_HRTSHADER([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D10DDI_HRTSHADERRESOURCEVIEW MAKE_D3D10DDI_HRTSHADERRESOURCEVIEW([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D10DDI_HSAMPLER MAKE_D3D10DDI_HSAMPLER([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D10DDI_HSHADER MAKE_D3D10DDI_HSHADER([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D10DDI_HSHADERRESOURCEVIEW MAKE_D3D10DDI_HSHADERRESOURCEVIEW([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D11DDI_HCOMMANDLIST MAKE_D3D11DDI_HCOMMANDLIST([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D11DDI_HRTCOMMANDLIST MAKE_D3D11DDI_HRTCOMMANDLIST([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D11DDI_HRTUNORDEREDACCESSVIEW MAKE_D3D11DDI_HRTUNORDEREDACCESSVIEW([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D11DDI_HUNORDEREDACCESSVIEW MAKE_D3D11DDI_HUNORDEREDACCESSVIEW([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D11_1DDI_HAUTHCHANNEL MAKE_D3D11_1DDI_HAUTHCHANNEL([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D11_1DDI_HCRYPTOSESSION MAKE_D3D11_1DDI_HCRYPTOSESSION([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D11_1DDI_HDECODE MAKE_D3D11_1DDI_HDECODE([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D11_1DDI_HRTAUTHCHANNEL MAKE_D3D11_1DDI_HRTAUTHCHANNEL([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D11_1DDI_HRTCRYPTOSESSION MAKE_D3D11_1DDI_HRTCRYPTOSESSION([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D11_1DDI_HRTDECODE MAKE_D3D11_1DDI_HRTDECODE([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D11_1DDI_HRTVIDEODECODEROUTPUTVIEW MAKE_D3D11_1DDI_HRTVIDEODECODEROUTPUTVIEW([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D11_1DDI_HRTVIDEOPROCESSOR MAKE_D3D11_1DDI_HRTVIDEOPROCESSOR([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D11_1DDI_HRTVIDEOPROCESSORENUM MAKE_D3D11_1DDI_HRTVIDEOPROCESSORENUM([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D11_1DDI_HRTVIDEOPROCESSORINPUTVIEW MAKE_D3D11_1DDI_HRTVIDEOPROCESSORINPUTVIEW([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D11_1DDI_HRTVIDEOPROCESSOROUTPUTVIEW MAKE_D3D11_1DDI_HRTVIDEOPROCESSOROUTPUTVIEW([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D11_1DDI_HVIDEODECODEROUTPUTVIEW MAKE_D3D11_1DDI_HVIDEODECODEROUTPUTVIEW([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D11_1DDI_HVIDEOPROCESSOR MAKE_D3D11_1DDI_HVIDEOPROCESSOR([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D11_1DDI_HVIDEOPROCESSORENUM MAKE_D3D11_1DDI_HVIDEOPROCESSORENUM([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D11_1DDI_HVIDEOPROCESSORINPUTVIEW MAKE_D3D11_1DDI_HVIDEOPROCESSORINPUTVIEW([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3D11_1DDI_HVIDEOPROCESSOROUTPUTVIEW MAKE_D3D11_1DDI_HVIDEOPROCESSOROUTPUTVIEW([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3DWDDM2_2DDI_HCACHESESSION MAKE_D3DWDDM2_2DDI_HCACHESESSION([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern D3DWDDM2_2DDI_HRTCACHESESSION MAKE_D3DWDDM2_2DDI_HRTCACHESESSION([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10CreateDevice1(/* _In_opt_ */ IDXGIAdapter pAdapter, D3D10_DRIVER_TYPE DriverType, IntPtr Software, uint Flags, D3D10_FEATURE_LEVEL1 HardwareLevel, uint SDKVersion, /* _Out_opt_ */ out ID3D10Device1 ppDevice);
        
        [DllImport("d3d10")]
        public static extern HRESULT D3D10CreateDeviceAndSwapChain1(/* _In_opt_ */ IDXGIAdapter pAdapter, D3D10_DRIVER_TYPE DriverType, IntPtr Software, uint Flags, D3D10_FEATURE_LEVEL1 HardwareLevel, uint SDKVersion, /* optional(DXGI_SWAP_CHAIN_DESC) */ IntPtr pSwapChainDesc, /* _Out_opt_ */ out IDXGISwapChain ppSwapChain, /* _Out_opt_ */ out ID3D10Device1 ppDevice);
        
        [DllImport("d3d11")]
        public static extern uint D3D11CalcSubresource(uint MipSlice, uint ArraySlice, uint MipLevels);
        
        [DllImport("d3d11")]
        public static extern HRESULT D3D11CreateDevice(/* _In_opt_ */ IDXGIAdapter pAdapter, D3D_DRIVER_TYPE DriverType, IntPtr Software, uint Flags, /* _In_reads_opt_( FeatureLevels ) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] D3D_FEATURE_LEVEL[] pFeatureLevels, uint FeatureLevels, uint SDKVersion, /* _COM_Outptr_opt_ */ out ID3D11Device ppDevice, /* _Out_opt_ */ out D3D_FEATURE_LEVEL pFeatureLevel, /* _COM_Outptr_opt_ */ out ID3D11DeviceContext ppImmediateContext);
        
        [DllImport("d3d11")]
        public static extern HRESULT D3D11CreateDeviceAndSwapChain(/* _In_opt_ */ IDXGIAdapter pAdapter, D3D_DRIVER_TYPE DriverType, IntPtr Software, uint Flags, /* _In_reads_opt_( FeatureLevels ) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] D3D_FEATURE_LEVEL[] pFeatureLevels, uint FeatureLevels, uint SDKVersion, /* optional(DXGI_SWAP_CHAIN_DESC) */ IntPtr pSwapChainDesc, /* _COM_Outptr_opt_ */ out IDXGISwapChain ppSwapChain, /* _COM_Outptr_opt_ */ out ID3D11Device ppDevice, /* _Out_opt_ */ out D3D_FEATURE_LEVEL pFeatureLevel, /* _COM_Outptr_opt_ */ out ID3D11DeviceContext ppImmediateContext);
        
        [DllImport("d3d11")]
        public static extern HRESULT D3D11On12CreateDevice(/* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pDevice, uint Flags, /* _In_reads_opt_( FeatureLevels ) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] D3D_FEATURE_LEVEL[] pFeatureLevels, uint FeatureLevels, /* optional(IUnknown) */ IntPtr ppCommandQueues, uint NumQueues, uint NodeMask, /* _COM_Outptr_opt_ */ out ID3D11Device ppDevice, /* _COM_Outptr_opt_ */ out ID3D11DeviceContext ppImmediateContext, /* _Out_opt_ */ out D3D_FEATURE_LEVEL pChosenFeatureLevel);
        
        [DllImport("d3d11")]
        public static extern HRESULT D3DDisassemble11Trace(/* _In_reads_bytes_(SrcDataSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] pSrcData, /* _In_ */ IntPtr SrcDataSize, /* _In_ */ ID3D11ShaderTrace pTrace, /* _In_ */ uint StartStep, /* _In_ */ uint NumSteps, /* _In_ */ uint Flags, /* _COM_Outptr_ */ out ID3D10Blob ppDisassembly);
        
        [DllImport("d3d12")]
        public static extern HRESULT D3D12CreateDevice(/* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pAdapter, D3D_FEATURE_LEVEL MinimumFeatureLevel, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* // Expected: ID3D12Device _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppDevice);
        
        [DllImport("d3d12")]
        public static extern HRESULT D3D12CreateRootSignatureDeserializer(/* _In_reads_bytes_(SrcDataSizeInBytes) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] pSrcData, /* _In_ */ IntPtr SrcDataSizeInBytes, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pRootSignatureDeserializerInterface, /* _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppRootSignatureDeserializer);
        
        [DllImport("d3d12")]
        public static extern HRESULT D3D12CreateVersionedRootSignatureDeserializer(/* _In_reads_bytes_(SrcDataSizeInBytes) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] pSrcData, /* _In_ */ IntPtr SrcDataSizeInBytes, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pRootSignatureDeserializerInterface, /* _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppRootSignatureDeserializer);
        
        [DllImport("d3d12")]
        public static extern HRESULT D3D12EnableExperimentalFeatures(uint NumFeatures, /* __in_ecount(NumFeatures) */ [MarshalAs(UnmanagedType.LPStruct)] Guid pIIDs, /* __in_ecount_opt(NumFeatures) */ [MarshalAs(UnmanagedType.IUnknown)] object pConfigurationStructs, /* __in_ecount_opt(NumFeatures) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] uint[] pConfigurationStructSizes);
        
        [DllImport("d3d12")]
        public static extern HRESULT D3D12GetDebugInterface(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvDebug);
        
        [DllImport("d3d12")]
        public static extern HRESULT D3D12SerializeRootSignature(/* _In_ */ ref D3D12_ROOT_SIGNATURE_DESC pRootSignature, /* _In_ */ D3D_ROOT_SIGNATURE_VERSION Version, /* _Out_ */ out ID3D10Blob ppBlob, /* _Always_(_Outptr_opt_result_maybenull_) */ out ID3D10Blob ppErrorBlob);
        
        [DllImport("d3d12")]
        public static extern HRESULT D3D12SerializeVersionedRootSignature(/* _In_ */ ref D3D12_VERSIONED_ROOT_SIGNATURE_DESC pRootSignature, /* _Out_ */ out ID3D10Blob ppBlob, /* _Always_(_Outptr_opt_result_maybenull_) */ out ID3D10Blob ppErrorBlob);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HCOMMANDALLOCATOR MAKE_D3D12DDI_HCOMMANDALLOCATOR([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HCOMMANDLIST MAKE_D3D12DDI_HCOMMANDLIST([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HCOMMANDPOOL_0040 MAKE_D3D12DDI_HCOMMANDPOOL_0040([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HCOMMANDQUEUE MAKE_D3D12DDI_HCOMMANDQUEUE([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HCOMMANDRECORDER_0040 MAKE_D3D12DDI_HCOMMANDRECORDER_0040([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HCOMMANDSIGNATURE MAKE_D3D12DDI_HCOMMANDSIGNATURE([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HCONTENTPROTECTIONSESSION_0020 MAKE_D3D12DDI_HCONTENTPROTECTIONSESSION_0020(/* optional(void) */ IntPtr h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HCRYPTOSESSIONPOLICY_0030 MAKE_D3D12DDI_HCRYPTOSESSIONPOLICY_0030(/* Build rev 0. #define D3D12DDI_MINOR_VERSION_R3 30 #define D3D12DDI_INTERFACE_VERSION_R3 ((D3D12DDI_MAJOR_VERSION << 16) | D3D12DDI_MINOR_VERSION_R3) #define D3D12DDI_BUILD_VERSION_0030 0 #define D3D12DDI_SUPPORTED_0030 ((((UINT64)D3D12DDI_INTERFACE_VERSION_R3) << 32) | (((UINT64)D3D12DDI_BUILD_VERSION_0030) << 16)) D3D10DDI_H( D3D12DDI_HCRYPTOSESSION_0030 ) */ [MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HCRYPTOSESSION_0030 MAKE_D3D12DDI_HCRYPTOSESSION_0030(/* Build rev 0. #define D3D12DDI_MINOR_VERSION_R3 30 #define D3D12DDI_INTERFACE_VERSION_R3 ((D3D12DDI_MAJOR_VERSION << 16) | D3D12DDI_MINOR_VERSION_R3) #define D3D12DDI_BUILD_VERSION_0030 0 #define D3D12DDI_SUPPORTED_0030 ((((UINT64)D3D12DDI_INTERFACE_VERSION_R3) << 32) | (((UINT64)D3D12DDI_BUILD_VERSION_0030) << 16)) */ [MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HDESCRIPTORHEAP MAKE_D3D12DDI_HDESCRIPTORHEAP([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HFENCE MAKE_D3D12DDI_HFENCE([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HHEAP MAKE_D3D12DDI_HHEAP([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HMETACOMMAND_0052 MAKE_D3D12DDI_HMETACOMMAND_0052([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HPASS MAKE_D3D12DDI_HPASS(/* allocated by runtime. } D3D12DDI_VIDEO_EXTENSION_COMMANDS_DATA_0063; // D3D12DDICAPS_TYPE_VIDEO_0063_EXTENSION_COMMAND_PARAMETER_COUNT typedef struct D3D12DDI_VIDEO_EXTENSION_COMMAND_PARAMETER_COUNT_DATA_0063 { GUID CommandId; // input D3D12DDI_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_0063 Stage; // input UINT ParameterCount; // output UINT ParameterPacking; // output } D3D12DDI_VIDEO_EXTENSION_COMMAND_PARAMETER_COUNT_DATA_0063; // D3D12DDICAPS_TYPE_VIDEO_0063_EXTENSION_COMMAND_PARAMETERS typedef struct D3D12DDI_VIDEO_EXTENSION_COMMAND_PARAMETERS_DATA_0063 { GUID CommandId; // input D3D12DDI_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_0063 Stage; // input UINT ParameterCount; // input _Field_size_full_(ParameterCount) D3D12DDI_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO_0063* pParameterInfos; // output } D3D12DDI_VIDEO_EXTENSION_COMMAND_PARAMETERS_DATA_0063; // D3D12DDICAPS_TYPE_VIDEO_0063_EXTENSION_COMMAND_CAPS typedef struct D3D12DDI_VIDEO_EXTENSION_COMMAND_CAPS_DATA_0063 { UINT NodeIndex; GUID CommandId; _Field_size_bytes_full_opt_(InputDataSizeInBytes) const void *pInputData; SIZE_T InputDataSizeInBytes; _Field_size_bytes_full_(OutputDataSizeInBytes) void *pOutputData; SIZE_T OutputDataSizeInBytes; } D3D12DDI_VIDEO_EXTENSION_COMMAND_CAPS_DATA_0063; // D3D12DDICAPS_TYPE_VIDEO_0063_EXTENSION_COMMAND_SIZE typedef struct D3D12DDI_VIDEO_EXTENSION_COMMAND_SIZE_DATA_0063 { UINT NodeIndex; // input GUID CommandId; // input _Field_size_bytes_full_(CreationParametersDataSizeInBytes) CONST void *pCreationParameters; // input SIZE_T CreationParametersSizeInBytes; // input UINT64 MemoryPoolL0Size; // output UINT64 MemoryPoolL1Size; // output } D3D12DDI_VIDEO_EXTENSION_COMMAND_SIZE_DATA_0063; typedef struct D3D12DDIARG_CREATE_VIDEO_EXTENSION_COMMAND_0063 { UINT NodeMask; GUID CommandId; CONST void* pCreationParameters; SIZE_T CreationParametersDataSizeInBytes; D3D12DDI_HPROTECTEDRESOURCESESSION_0030 hDrvProtectedResourceSession; } D3D12DDIARG_CREATE_VIDEO_EXTENSION_COMMAND_0063; typedef SIZE_T ( APIENTRY* PFND3D12DDI_CALCPRIVATEVIDEOEXTENSIONCOMMANDSIZE_0061 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_VIDEO_EXTENSION_COMMAND_0063* pArgs); typedef HRESULT(APIENTRY* PFND3D12DDI_CREATEVIDEOEXTENSIONCOMMAND_0063) ( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_VIDEO_EXTENSION_COMMAND_0063* pArgs, D3D12DDI_HVIDEOEXTENSIONCOMMAND_0063 hDrvVideoExtensionCommand); typedef VOID(APIENTRY* PFND3D12DDI_DESTROYVIDEOEXTENSIONCOMMAND_0063) ( D3D12DDI_HDEVICE hDrvDevice, D3D12DDI_HVIDEOEXTENSIONCOMMAND_0063 hDrvVideoExtensionCommand); typedef HRESULT(APIENTRY* PFND3D12DDI_INITIALIZE_VIDEO_EXTENSION_COMMAND_0063)( D3D12DDI_HCOMMANDLIST hDrvCommandList, D3D12DDI_HVIDEOEXTENSIONCOMMAND_0063 hDrvVideoExtensionCommand, _In_reads_bytes_(InitializationParametersSizeInBytes) CONST void *pInitializationParameters, _In_ SIZE_T InitializationParametersSizeInBytes); typedef HRESULT(APIENTRY* PFND3D12DDI_EXECUTE_VIDEO_EXTENSION_COMMAND_0063)( D3D12DDI_HCOMMANDLIST hDrvCommandList, D3D12DDI_HVIDEOEXTENSIONCOMMAND_0063 hDrvVideoExtensionCommand, _In_reads_bytes_ (ExecutionParametersSizeInBytes) CONST void *pExecutionParameters, _In_ SIZE_T ExecutionParametersSizeInBytes); typedef struct D3D12DDI_DEVICE_FUNCS_VIDEO_0063 { PFND3D12DDI_VIDEO_GETCAPS pfnGetCaps; PFND3D12DDI_CALCPRIVATEVIDEODECODERSIZE_0032 pfnCalcPrivateVideoDecoderSize; PFND3D12DDI_CREATEVIDEODECODER_0032 pfnCreateVideoDecoder; PFND3D12DDI_DESTROYVIDEODECODER_0021 pfnDestroyVideoDecoder; PFND3D12DDI_CALCPRIVATEVIDEODECODERHEAPSIZE_0033 pfnCalcPrivateVideoDecoderHeapSize; PFND3D12DDI_CREATEVIDEODECODERHEAP_0033 pfnCreateVideoDecoderHeap; PFND3D12DDI_DESTROYVIDEODECODERHEAP_0032 pfnDestroyVideoDecoderHeap; PFND3D12DDI_CALCPRIVATEVIDEOPROCESSORSIZE_0043 pfnCalcPrivateVideoProcessorSize; PFND3D12DDI_CREATEVIDEOPROCESSOR_0043 pfnCreateVideoProcessor; PFND3D12DDI_DESTROYVIDEOPROCESSOR_0021 pfnDestroyVideoProcessor; PFND3D12DDI_CALCPRIVATEVIDEOMOTIONESTIMATORSIZE_0060 pfnCalcPrivateVideoMotionEstimatorSize; PFND3D12DDI_CREATEVIDEOMOTIONESTIMATOR_0060 pfnCreateVideoMotionEstimator; PFND3D12DDI_DESTROYVIDEOMOTIONESTIMATOR_0053 pfnDestroyVideoMotionEstimator; PFND3D12DDI_CALCPRIVATEVIDEOMOTIONVECTORHEAPSIZE_0060 pfnCalcPrivateVideoMotionVectorHeapSize; PFND3D12DDI_CREATEVIDEOMOTIONVECTORHEAP_0060 pfnCreateVideoMotionVectorHeap; PFND3D12DDI_DESTROYVIDEOMOTIONVECTORHEAP_0053 pfnDestroyVideoMotionVectorHeap; PFND3D12DDI_CALCPRIVATEVIDEOEXTENSIONCOMMANDSIZE_0061 pfnCalcPrivateVideoExtensionCommandSize; PFND3D12DDI_CREATEVIDEOEXTENSIONCOMMAND_0063 pfnCreateVideoExtensionCommand; PFND3D12DDI_DESTROYVIDEOEXTENSIONCOMMAND_0063 pfnDestroyVideoExtensionCommand; } D3D12DDI_DEVICE_FUNCS_VIDEO_0063; typedef struct D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_DECODE_0063 { PFND3D12DDI_CLOSECOMMANDLIST pfnCloseCommandList; PFND3D12DDI_RESETCOMMANDLIST_0040 pfnResetCommandList; PFND3D12DDI_DISCARD_RESOURCE_0003 pfnDiscardResource; PFND3D12DDI_SET_MARKER pfnSetMarker; PFND3D12DDI_SET_PREDICATION pfnSetPredication; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnBeginQuery; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnEndQuery; PFND3D12DDI_RESOLVE_QUERY_DATA pfnResolveQueryData; PFND3D12DDI_RESOURCEBARRIER_0022 pfnResourceBarrier; PFND3D12DDI_VIDEO_DECODE_FRAME_0041_1 pfnDecodeFrame; PFND3D12DDI_SETPROTECTEDRESOURCESESSION_0030 pfnSetProtectedResourceSession; PFND3D12DDI_WRITEBUFFERIMMEDIATE_0032 pfnWriteBufferImmediate; PFND3D12DDI_INITIALIZE_VIDEO_EXTENSION_COMMAND_0063 pfnInitializeVideoExtensionCommand; PFND3D12DDI_EXECUTE_VIDEO_EXTENSION_COMMAND_0063 pfnExecuteVideoExtensionCommand; } D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_DECODE_0063; typedef struct D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_PROCESS_0063 { PFND3D12DDI_CLOSECOMMANDLIST pfnCloseCommandList; PFND3D12DDI_RESETCOMMANDLIST_0040 pfnResetCommandList; PFND3D12DDI_DISCARD_RESOURCE_0003 pfnDiscardResource; PFND3D12DDI_SET_MARKER pfnSetMarker; PFND3D12DDI_SET_PREDICATION pfnSetPredication; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnBeginQuery; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnEndQuery; PFND3D12DDI_RESOLVE_QUERY_DATA pfnResolveQueryData; PFND3D12DDI_RESOURCEBARRIER_0022 pfnResourceBarrier; PFND3D12DDI_VIDEO_PROCESS_FRAME_0043 pfnProcessFrame; PFND3D12DDI_SETPROTECTEDRESOURCESESSION_0030 pfnSetProtectedResourceSession; PFND3D12DDI_WRITEBUFFERIMMEDIATE_0032 pfnWriteBufferImmediate; PFND3D12DDI_INITIALIZE_VIDEO_EXTENSION_COMMAND_0063 pfnInitializeVideoExtensionCommand; PFND3D12DDI_EXECUTE_VIDEO_EXTENSION_COMMAND_0063 pfnExecuteVideoExtensionCommand; } D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_PROCESS_0063; typedef struct D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_ENCODE_0063 { PFND3D12DDI_CLOSECOMMANDLIST pfnCloseCommandList; PFND3D12DDI_RESETCOMMANDLIST_0040 pfnResetCommandList; PFND3D12DDI_DISCARD_RESOURCE_0003 pfnDiscardResource; PFND3D12DDI_SET_MARKER pfnSetMarker; PFND3D12DDI_SET_PREDICATION pfnSetPredication; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnBeginQuery; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnEndQuery; PFND3D12DDI_RESOLVE_QUERY_DATA pfnResolveQueryData; PFND3D12DDI_RESOURCEBARRIER_0022 pfnResourceBarrier; PFND3D12DDI_ESTIMATE_MOTION_0053 pfnEstimateMotion; PFND3D12DDI_SETPROTECTEDRESOURCESESSION_0030 pfnSetProtectedResourceSession; PFND3D12DDI_WRITEBUFFERIMMEDIATE_0032 pfnWriteBufferImmediate; PFND3D12DDI_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_0060 pfnResolveVideoMotionVectorHeap; PFND3D12DDI_INITIALIZE_VIDEO_EXTENSION_COMMAND_0063 pfnInitializeVideoExtensionCommand; PFND3D12DDI_EXECUTE_VIDEO_EXTENSION_COMMAND_0063 pfnExecuteVideoExtensionCommand; } D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_ENCODE_0063; //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Query Meta-Command typedef struct D3D12DDICAPS_QUERY_META_COMMAND_CAPS_0061 { GUID CommandId; _Field_size_bytes_full_opt_(QueryInputDataSizeInBytes) const void *pQueryInputData; SIZE_T QueryInputDataSizeInBytes; _Field_size_bytes_full_(QueryOutputDataSizeInBytes) void *pQueryOutputData; SIZE_T QueryOutputDataSizeInBytes; } D3D12DDICAPS_QUERY_META_COMMAND_CAPS_0061; //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Extended Feature Render Pass Experiment // Feature: D3D12DDI_FEATURE_0020_PASS_EXPERIMENT // Version: D3D12DDI_FEATURE_VERSION_PASS_EXPERIMENT_0020_0 // Usermode DDI Min Version: D3D12DDI_SUPPORTED_0020 // // Render Pass Experiment v0.01 // // This is a test to see if drivers can find perf wins from being told when apps are repeating "passes" of consistent workloads. // The app instructs the driver to observe how some passes run and gives the driver a chance to make optimizations for future // runs of the same pass. The contents of a "pass" can be anything - it is up to the app to be relatively consistent in the overall // performance characteristics of a pass. // // This is likely to evolve heavily - just a starting point. // // D3D12DDI_RENDER_PASS_EXPERIMENT_0001 is a prototype DDI table that drivers supporting this experiment expose. // // DDI call flow: // // (1) Create Pass: // pfnCalcPrivatePassSize / pfnCreatePass (can be repeated for any number of pass types) // (2) Find out how driver wants profiling to play out in terms of number of rounds of optimizing and passes per round: // pfnGetPassOptimizationFlow // (3) Repeat for number of optimization rounds driver requested: // Record Observations: // pfnBeginPass... draws etc... pfnEndPass (called for the # of passes per optimization round driver requested) // - D3D12DDI_PASS_FLAG_DRIVER_OBSERVE flag passed to pfnBeginPass // Make optimizations from observations: // pfnOptimizePass // (4) Use optimizations: // pfnBeginPass... draws etc... pfnEndPass // - D3D12DDI_PASS_DRIVER_USE_DISCOVERED_OPTIMIZATIONS flag passed to pfnBeginPass //---------------------------------------------------------------------------------------------------------------------------------- #define D3D12DDI_FEATURE_VERSION_PASS_EXPERIMENT_0020_0 1u */ [MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HPIPELINELIBRARY MAKE_D3D12DDI_HPIPELINELIBRARY(/* } D3D12DDI_3DPIPELINELEVEL; typedef VOID ( APIENTRY* PFND3D12DDI_CHECKFORMATSUPPORT )( D3D12DDI_HDEVICE, DXGI_FORMAT, _Out_ UINT* ); typedef VOID ( APIENTRY* PFND3D12DDI_CHECKMULTISAMPLEQUALITYLEVELS )( D3D12DDI_HDEVICE hDevice, DXGI_FORMAT Format, UINT SampleCount, D3D12DDI_MULTISAMPLE_QUALITY_LEVEL_FLAGS Flags, _Out_ UINT* pNumQualityLevels ); typedef VOID ( APIENTRY* PFND3D12DDI_GETMIPPACKING )( D3D12DDI_HDEVICE hDevice, D3D12DDI_HRESOURCE hTiledResource, _Out_ UINT* pNumPackedMips, _Out_ UINT* pNumTilesForPackedMips ); typedef SIZE_T ( APIENTRY* PFND3D12DDI_CALCPRIVATEELEMENTLAYOUTSIZE )( D3D12DDI_HDEVICE, _In_ CONST D3D12DDIARG_CREATEELEMENTLAYOUT* ); typedef VOID ( APIENTRY* PFND3D12DDI_CREATEELEMENTLAYOUT_0003 )( D3D12DDI_HDEVICE, _In_ CONST D3D12DDIARG_CREATEELEMENTLAYOUT*, D3D12DDI_HELEMENTLAYOUT ); typedef VOID ( APIENTRY* PFND3D12DDI_DESTROYELEMENTLAYOUT )( D3D12DDI_HDEVICE, D3D12DDI_HELEMENTLAYOUT ); typedef SIZE_T ( APIENTRY* PFND3D12DDI_CALCPRIVATEBLENDSTATESIZE )( D3D12DDI_HDEVICE, _In_ CONST D3D12DDI_BLEND_DESC* ); typedef VOID ( APIENTRY* PFND3D12DDI_CREATEBLENDSTATE_0003 )( D3D12DDI_HDEVICE, _In_ CONST D3D12DDI_BLEND_DESC*, D3D12DDI_HBLENDSTATE ); typedef VOID ( APIENTRY* PFND3D12DDI_DESTROYBLENDSTATE )( D3D12DDI_HDEVICE, D3D12DDI_HBLENDSTATE ); typedef SIZE_T ( APIENTRY* PFND3D12DDI_CALCPRIVATEDEPTHSTENCILSTATESIZE )( D3D12DDI_HDEVICE, _In_ CONST D3D12DDI_DEPTH_STENCIL_DESC* ); typedef VOID ( APIENTRY* PFND3D12DDI_CREATEDEPTHSTENCILSTATE_0003 )( D3D12DDI_HDEVICE, _In_ CONST D3D12DDI_DEPTH_STENCIL_DESC*, D3D12DDI_HDEPTHSTENCILSTATE ); typedef VOID ( APIENTRY* PFND3D12DDI_DESTROYDEPTHSTENCILSTATE )( D3D12DDI_HDEVICE, D3D12DDI_HDEPTHSTENCILSTATE ); typedef VOID ( APIENTRY* PFND3D12DDI_DESTROYRASTERIZERSTATE )( D3D12DDI_HDEVICE, D3D12DDI_HRASTERIZERSTATE ); typedef VOID ( APIENTRY* PFND3D12DDI_CLEAR_ROOT_ARGUMENTS )(D3D12DDI_HCOMMANDLIST); typedef VOID ( APIENTRY* PFND3D12DDI_DESTROYSHADER )( D3D12DDI_HDEVICE, D3D12DDI_HSHADER ); typedef VOID ( APIENTRY* PFND3D12DDI_BEGIN_END_QUERY_0003 )( D3D12DDI_HCOMMANDLIST, D3D12DDI_HQUERYHEAP, D3D12DDI_QUERY_TYPE, UINT ); typedef D3DKMT_HANDLE ( APIENTRY* PFND3D12DDI_CHECKRESOURCEALLOCATIONHANDLE )( D3D12DDI_HDEVICE, D3D10DDI_HRESOURCE ); //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 DDI Tables // typedef struct D3D12DDI_COMMAND_LIST_FUNCS_3D_0003 { PFND3D12DDI_CLOSECOMMANDLIST pfnCloseCommandList; PFND3D12DDI_RESETCOMMANDLIST pfnResetCommandList; PFND3D12DDI_DRAWINSTANCED pfnDrawInstanced; PFND3D12DDI_DRAWINDEXEDINSTANCED pfnDrawIndexedInstanced; PFND3D12DDI_DISPATCH pfnDispatch; PFND3D12DDI_CLEAR_UNORDERED_ACCESS_VIEW_UINT_0003 pfnClearUnorderedAccessViewUint; PFND3D12DDI_CLEAR_UNORDERED_ACCESS_VIEW_FLOAT_0003 pfnClearUnorderedAccessViewFloat; PFND3D12DDI_CLEAR_RENDER_TARGET_VIEW_0003 pfnClearRenderTargetView; PFND3D12DDI_CLEAR_DEPTH_STENCIL_VIEW_0003 pfnClearDepthStencilView; PFND3D12DDI_DISCARD_RESOURCE_0003 pfnDiscardResource; PFND3D12DDI_COPYTEXTUREREGION_0003 pfnCopyTextureRegion; PFND3D12DDI_RESOURCECOPY pfnResourceCopy; PFND3D12DDI_COPYTILES pfnCopyTiles; PFND3D12DDI_COPYBUFFERREGION_0003 pfnCopyBufferRegion; PFND3D12DDI_RESOURCERESOLVESUBRESOURCE pfnResourceResolveSubresource; PFND3D12DDI_EXECUTE_BUNDLE pfnExecuteBundle; PFND3D12DDI_EXECUTE_INDIRECT pfnExecuteIndirect; PFND3D12DDI_RESOURCEBARRIER_0003 pfnResourceBarrier; PFND3D12DDI_BLT pfnBlt; PFND3D12DDI_PRESENT_0003 pfnPresent; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnBeginQuery; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnEndQuery; PFND3D12DDI_RESOLVE_QUERY_DATA pfnResolveQueryData; PFND3D12DDI_SET_PREDICATION pfnSetPredication; PFND3D12DDI_IA_SETTOPOLOGY_0003 pfnIaSetTopology; PFND3D12DDI_RS_SETVIEWPORTS_0003 pfnRsSetViewports; PFND3D12DDI_RS_SETSCISSORRECTS_0003 pfnRsSetScissorRects; PFND3D12DDI_OM_SETBLENDFACTOR pfnOmSetBlendFactor; PFND3D12DDI_OM_SETSTENCILREF pfnOmSetStencilRef; PFND3D12DDI_SET_PIPELINE_STATE pfnSetPipelineState; PFND3D12DDI_SET_DESCRIPTOR_HEAPS_0003 pfnSetDescriptorHeaps; PFND3D12DDI_SET_ROOT_SIGNATURE pfnSetComputeRootSignature; PFND3D12DDI_SET_ROOT_SIGNATURE pfnSetGraphicsRootSignature; PFND3D12DDI_SET_ROOT_DESCRIPTOR_TABLE pfnSetComputeRootDescriptorTable; PFND3D12DDI_SET_ROOT_DESCRIPTOR_TABLE pfnSetGraphicsRootDescriptorTable; PFND3D12DDI_SET_ROOT_32BIT_CONSTANT pfnSetComputeRoot32BitConstant; PFND3D12DDI_SET_ROOT_32BIT_CONSTANT pfnSetGraphicsRoot32BitConstant; PFND3D12DDI_SET_ROOT_32BIT_CONSTANTS_0003 pfnSetComputeRoot32BitConstants; PFND3D12DDI_SET_ROOT_32BIT_CONSTANTS_0003 pfnSetGraphicsRoot32BitConstants; PFND3D12DDI_SET_ROOT_BUFFER_VIEW pfnSetComputeRootConstantBufferView; PFND3D12DDI_SET_ROOT_BUFFER_VIEW pfnSetGraphicsRootConstantBufferView; PFND3D12DDI_SET_ROOT_BUFFER_VIEW pfnSetComputeRootShaderResourceView; PFND3D12DDI_SET_ROOT_BUFFER_VIEW pfnSetGraphicsRootShaderResourceView; PFND3D12DDI_SET_ROOT_BUFFER_VIEW pfnSetComputeRootUnorderedAccessView; PFND3D12DDI_SET_ROOT_BUFFER_VIEW pfnSetGraphicsRootUnorderedAccessView; PFND3D12DDI_IA_SET_INDEX_BUFFER pfnIASetIndexBuffer; PFND3D12DDI_IA_SET_VERTEX_BUFFERS_0003 pfnIASetVertexBuffers; PFND3D12DDI_SO_SET_TARGETS_0003 pfnSOSetTargets; PFND3D12DDI_OM_SET_RENDER_TARGETS_0003 pfnOMSetRenderTargets; PFND3D12DDI_SET_MARKER pfnSetMarker; PFND3D12DDI_CLEAR_ROOT_ARGUMENTS pfnClearRootArguments; } D3D12DDI_COMMAND_LIST_FUNCS_3D_0003; typedef struct D3D12DDI_DEVICE_FUNCS_CORE_0003 { PFND3D12DDI_CHECKFORMATSUPPORT pfnCheckFormatSupport; PFND3D12DDI_CHECKMULTISAMPLEQUALITYLEVELS pfnCheckMultisampleQualityLevels; PFND3D12DDI_GETMIPPACKING pfnGetMipPacking; PFND3D12DDI_CALCPRIVATEELEMENTLAYOUTSIZE pfnCalcPrivateElementLayoutSize; PFND3D12DDI_CREATEELEMENTLAYOUT_0003 pfnCreateElementLayout; PFND3D12DDI_DESTROYELEMENTLAYOUT pfnDestroyElementLayout; PFND3D12DDI_CALCPRIVATEBLENDSTATESIZE pfnCalcPrivateBlendStateSize; PFND3D12DDI_CREATEBLENDSTATE_0003 pfnCreateBlendState; PFND3D12DDI_DESTROYBLENDSTATE pfnDestroyBlendState; PFND3D12DDI_CALCPRIVATEDEPTHSTENCILSTATESIZE pfnCalcPrivateDepthStencilStateSize; PFND3D12DDI_CREATEDEPTHSTENCILSTATE_0003 pfnCreateDepthStencilState; PFND3D12DDI_DESTROYDEPTHSTENCILSTATE pfnDestroyDepthStencilState; PFND3D12DDI_CALCPRIVATERASTERIZERSTATESIZE pfnCalcPrivateRasterizerStateSize; PFND3D12DDI_CREATERASTERIZERSTATE_0003 pfnCreateRasterizerState; PFND3D12DDI_DESTROYRASTERIZERSTATE pfnDestroyRasterizerState; PFND3D12DDI_CALC_PRIVATE_SHADER_SIZE pfnCalcPrivateShaderSize; PFND3D12DDI_CREATE_SHADER_0003 pfnCreateVertexShader; PFND3D12DDI_CREATE_SHADER_0003 pfnCreatePixelShader; PFND3D12DDI_CREATE_SHADER_0003 pfnCreateGeometryShader; PFND3D12DDI_CREATE_COMPUTE_SHADER_0003 pfnCreateComputeShader; PFND3D12DDI_CALC_PRIVATE_GEOMETRY_SHADER_WITH_STREAM_OUTPUT pfnCalcPrivateGeometryShaderWithStreamOutput; PFND3D12DDI_CREATE_GEOMETRY_SHADER_WITH_STREAM_OUTPUT_0003 pfnCreateGeometryShaderWithStreamOutput; PFND3D12DDI_CALC_PRIVATE_TESSELLATION_SHADER_SIZE pfnCalcPrivateTessellationShaderSize; PFND3D12DDI_CREATE_TESS_SHADER_0003 pfnCreateHullShader; PFND3D12DDI_CREATE_TESS_SHADER_0003 pfnCreateDomainShader; PFND3D12DDI_DESTROYSHADER pfnDestroyShader; PFND3D12DDI_CALCPRIVATECOMMANDQUEUESIZE_0001 pfnCalcPrivateCommandQueueSize; PFND3D12DDI_CREATECOMMANDQUEUE_0001 pfnCreateCommandQueue; PFND3D12DDI_DESTROYCOMMANDQUEUE pfnDestroyCommandQueue; PFND3D12DDI_CALCPRIVATECOMMANDALLOCATORSIZE pfnCalcPrivateCommandAllocatorSize; PFND3D12DDI_CREATECOMMANDALLOCATOR pfnCreateCommandAllocator; PFND3D12DDI_DESTROYCOMMANDALLOCATOR pfnDestroyCommandAllocator; PFND3D12DDI_RESETCOMMANDALLOCATOR pfnResetCommandAllocator; PFND3D12DDI_CALC_PRIVATE_PIPELINE_STATE_SIZE_0001 pfnCalcPrivatePipelineStateSize; PFND3D12DDI_CREATE_PIPELINE_STATE_0001 pfnCreatePipelineState; PFND3D12DDI_DESTROY_PIPELINE_STATE pfnDestroyPipelineState; PFND3D12DDI_CALC_PRIVATE_COMMAND_LIST_SIZE_0001 pfnCalcPrivateCommandListSize; PFND3D12DDI_CREATE_COMMAND_LIST_0001 pfnCreateCommandList; PFND3D12DDI_DESTROYCOMMANDLIST pfnDestroyCommandList; PFND3D12DDI_CALCPRIVATEFENCESIZE pfnCalcPrivateFenceSize; PFND3D12DDI_CREATEFENCE pfnCreateFence; PFND3D12DDI_DESTROYFENCE pfnDestroyFence; PFND3D12DDI_CALC_PRIVATE_DESCRIPTOR_HEAP_SIZE_0001 pfnCalcPrivateDescriptorHeapSize; PFND3D12DDI_CREATE_DESCRIPTOR_HEAP_0001 pfnCreateDescriptorHeap; PFND3D12DDI_DESTROY_DESCRIPTOR_HEAP pfnDestroyDescriptorHeap; PFND3D12DDI_GET_DESCRIPTOR_SIZE_IN_BYTES pfnGetDescriptorSizeInBytes; PFND3D12DDI_GET_CPU_DESCRIPTOR_HANDLE_FOR_HEAP_START pfnGetCPUDescriptorHandleForHeapStart; PFND3D12DDI_GET_GPU_DESCRIPTOR_HANDLE_FOR_HEAP_START pfnGetGPUDescriptorHandleForHeapStart; PFND3D12DDI_CREATE_SHADER_RESOURCE_VIEW_0002 pfnCreateShaderResourceView; PFND3D12DDI_CREATE_CONSTANT_BUFFER_VIEW pfnCreateConstantBufferView; PFND3D12DDI_CREATE_SAMPLER pfnCreateSampler; PFND3D12DDI_CREATE_UNORDERED_ACCESS_VIEW_0002 pfnCreateUnorderedAccessView; PFND3D12DDI_CREATE_RENDER_TARGET_VIEW_0002 pfnCreateRenderTargetView; PFND3D12DDI_CREATE_DEPTH_STENCIL_VIEW pfnCreateDepthStencilView; PFND3D12DDI_CALC_PRIVATE_ROOT_SIGNATURE_SIZE_0001 pfnCalcPrivateRootSignatureSize; PFND3D12DDI_CREATE_ROOT_SIGNATURE_0001 pfnCreateRootSignature; PFND3D12DDI_DESTROY_ROOT_SIGNATURE pfnDestroyRootSignature; PFND3D12DDI_SERIALIZEOBJECT pfnSerializeObject; PFND3D12DDI_DESTROYOBJECTSERIALIZATION pfnDestroyObjectSerialization; PFND3D12DDI_CALCPRIVATEDESERIALIZEDOBJECTSIZE pfnCalcPrivateDeserializedObjectSize; PFND3D12DDI_CREATEDESERIALIZEDOBJECT pfnCreateDeserializedObject; PFND3D12DDI_MAPHEAP pfnMapHeap; PFND3D12DDI_UNMAPHEAP pfnUnmapHeap; PFND3D12DDI_CALCPRIVATEHEAPANDRESOURCESIZES_0003 pfnCalcPrivateHeapAndResourceSizes; PFND3D12DDI_CREATEHEAPANDRESOURCE_0003 pfnCreateHeapAndResource; PFND3D12DDI_DESTROYHEAPANDRESOURCE pfnDestroyHeapAndResource; PFND3D12DDI_MAKERESIDENT_0001 pfnMakeResident; PFND3D12DDI_EVICT2 pfnEvict; PFND3D12DDI_CALCPRIVATEOPENEDHEAPANDRESOURCESIZES_0003 pfnCalcPrivateOpenedHeapAndResourceSizes; PFND3D12DDI_OPENHEAPANDRESOURCE_0003 pfnOpenHeapAndResource; PFND3D12DDI_COPY_DESCRIPTORS_0003 pfnCopyDescriptors; PFND3D12DDI_COPY_DESCRIPTORS_SIMPLE_0003 pfnCopyDescriptorsSimple; PFND3D12DDI_CALC_PRIVATE_QUERY_HEAP_SIZE_0001 pfnCalcPrivateQueryHeapSize; PFND3D12DDI_CREATE_QUERY_HEAP_0001 pfnCreateQueryHeap; PFND3D12DDI_DESTROY_QUERY_HEAP pfnDestroyQueryHeap; PFND3D12DDI_CALC_PRIVATE_COMMAND_SIGNATURE_SIZE_0001 pfnCalcPrivateCommandSignatureSize; PFND3D12DDI_CREATE_COMMAND_SIGNATURE_0001 pfnCreateCommandSignature; PFND3D12DDI_DESTROY_COMMAND_SIGNATURE pfnDestroyCommandSignature; PFND3D12DDI_CHECKRESOURCEVIRTUALADDRESS pfnCheckResourceVirtualAddress; PFND3D12DDI_CHECKRESOURCEALLOCATIONINFO_0003 pfnCheckResourceAllocationInfo; PFND3D12DDI_CHECKSUBRESOURCEINFO pfnCheckSubresourceInfo; PFND3D12DDI_CHECKEXISITINGRESOURCEALLOCATIONINFO pfnCheckExistingResourceAllocationInfo; PFND3D12DDI_OFFERRESOURCES pfnOfferResources; PFND3D12DDI_RECLAIMRESOURCES_0001 pfnReclaimResources; PFND3D12DDI_GETIMPLICITPHYSICALADAPTERMASK pfnGetImplicitPhysicalAdapterMask; PFND3D12DDI_GET_PRESENT_PRIVATE_DRIVER_DATA_SIZE pfnGetPresentPrivateDriverDataSize; PFND3D12DDI_QUERY_NODE_MAP pfnQueryNodeMap; PFND3D12DDI_RETRIEVE_SHADER_COMMENT_0003 pfnRetrieveShaderComment; PFND3D12DDI_CHECKRESOURCEALLOCATIONHANDLE pfnCheckResourceAllocationHandle; } D3D12DDI_DEVICE_FUNCS_CORE_0003; //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Release 1 #define D3D12DDI_MINOR_VERSION_R1 10 #define D3D12DDI_INTERFACE_VERSION_R1 ((D3D12DDI_MAJOR_VERSION << 16) | D3D12DDI_MINOR_VERSION_R1) #define D3D12DDI_BUILD_VERSION_0010 0 #define D3D12DDI_SUPPORTED_0010 ((((UINT64)D3D12DDI_INTERFACE_VERSION_R1) << 32) | (((UINT64)D3D12DDI_BUILD_VERSION_0010) << 16)) // UMD handle types */ [MarshalAs(UnmanagedType.IUnknown)] out object h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HPIPELINESTATE MAKE_D3D12DDI_HPIPELINESTATE([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HPROTECTEDRESOURCESESSION_0030 MAKE_D3D12DDI_HPROTECTEDRESOURCESESSION_0030(/* Build rev 0. #define D3D12DDI_MINOR_VERSION_R3 30 #define D3D12DDI_INTERFACE_VERSION_R3 ((D3D12DDI_MAJOR_VERSION << 16) | D3D12DDI_MINOR_VERSION_R3) #define D3D12DDI_BUILD_VERSION_0030 0 #define D3D12DDI_SUPPORTED_0030 ((((UINT64)D3D12DDI_INTERFACE_VERSION_R3) << 32) | (((UINT64)D3D12DDI_BUILD_VERSION_0030) << 16)) D3D10DDI_H( D3D12DDI_HCRYPTOSESSION_0030 ) D3D10DDI_H( D3D12DDI_HCRYPTOSESSIONPOLICY_0030 ) */ [MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HQUERYHEAP MAKE_D3D12DDI_HQUERYHEAP([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HROOTSIGNATURE MAKE_D3D12DDI_HROOTSIGNATURE([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HRTCOMMANDLIST MAKE_D3D12DDI_HRTCOMMANDLIST([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HRTCOMMANDQUEUE MAKE_D3D12DDI_HRTCOMMANDQUEUE([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HRTMETACOMMAND_0052 MAKE_D3D12DDI_HRTMETACOMMAND_0052([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HRTPAGINGQUEUE MAKE_D3D12DDI_HRTPAGINGQUEUE([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HRTPIPELINESTATE MAKE_D3D12DDI_HRTPIPELINESTATE([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HRTPROTECTEDSESSION_0030 MAKE_D3D12DDI_HRTPROTECTEDSESSION_0030(/* Build rev 4. // This version is introduced to detect the presence of the SubmitHistorySequence callback // in the KT callback table. #define D3D12DDI_BUILD_VERSION_0064 4 #define D3D12DDI_SUPPORTED_0064 ((((UINT64)D3D12DDI_INTERFACE_VERSION_R6) << 32) | (((UINT64)D3D12DDI_BUILD_VERSION_0064) << 16)) //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Extended Feature Content Protection Resources // Feature: D3D12DDI_FEATURE_0030_CONTENT_PROTECTION_RESOURCES // Version: D3D12DDI_FEATURE_VERSION_CONTENT_PROTECTION_RESOURCES_0030_0 // Usermode DDI Min Version: D3D12DDI_SUPPORTED_0030 #define D3D12DDI_FEATURE_VERSION_CONTENT_PROTECTION_RESOURCES_0030_0 1u */ [MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HRTSCHEDULINGGROUP_0050 MAKE_D3D12DDI_HRTSCHEDULINGGROUP_0050([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HRTSTATEOBJECT_0054 MAKE_D3D12DDI_HRTSTATEOBJECT_0054([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HRTTABLE MAKE_D3D12DDI_HRTTABLE([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HSCHEDULINGGROUP_0050 MAKE_D3D12DDI_HSCHEDULINGGROUP_0050([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HSTATEOBJECT_0054 MAKE_D3D12DDI_HSTATEOBJECT_0054([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HUNORDEREDACCESSVIEWCOUNTER MAKE_D3D12DDI_HUNORDEREDACCESSVIEWCOUNTER([MarshalAs(UnmanagedType.IUnknown)] object h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HVIDEODECODERHEAP_0032 MAKE_D3D12DDI_HVIDEODECODERHEAP_0032(/* } D3D12DDI_CRYPTO_SESSION_TRANSFORM_OPERATION_0030; // D3D12DDICAPS_TYPE_0030_CRYPTO_SESSION_TRANSFORM_SUPPORT typedef struct D3D12DDI_VIDEO_CRYPTO_SESSION_TRANSFORM_SUPPORT_DATA_0030 { UINT NodeIndex; // input GUID DecodeProfile; // input GUID ContentProtectionSystem; // input D3D12DDI_CRYPTO_SESSION_FLAGS_0030 Flags; // input D3D12DDI_BITSTREAM_ENCRYPTION_TYPE_0030 BitstreamEncryption; // input D3D12DDI_CRYPTO_SESSION_TRANSFORM_OPERATION_0030 Operation; // input BOOL ProtectedOutputRequired; // output UINT64 InputAlignment; // output UINT64 InputPreambleSize; // output UINT64 OutputAlignment; // output UINT64 OutputPreambleSize; // output D3D12DDI_CRYPTO_SESSION_TRANSFORM_SUPPORT_FLAGS_0030 Support; // output } D3D12DDI_VIDEO_CRYPTO_SESSION_TRANSFORM_SUPPORT_DATA_0030; typedef struct D3D12DDIARG_CREATE_PROTECTED_RESOURCE_SESSION_0030 { UINT NodeMask; } D3D12DDIARG_CREATE_PROTECTED_RESOURCE_SESSION_0030; typedef SIZE_T ( APIENTRY* PFND3D12DDI_CALCPRIVATEPROTECTEDRESOURCESESSIONSIZE_0030 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_PROTECTED_RESOURCE_SESSION_0030* pArgs ); typedef HRESULT ( APIENTRY* PFND3D12DDI_CREATEPROTECTEDRESOURCESESSION_0030 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_PROTECTED_RESOURCE_SESSION_0030* pArgs, D3D12DDI_HPROTECTEDRESOURCESESSION_0030 hDrvProtectedResourceSession, D3D12DDI_HRTPROTECTEDSESSION_0030 hRtProtectedSession ); typedef struct D3D12DDIARG_OPEN_PROTECTED_RESOURCE_SESSION_0030 { CONST VOID* pPrivateDriverData; UINT PrivateDriverDataSize; } D3D12DDIARG_OPEN_PROTECTED_RESOURCE_SESSION_0030; typedef SIZE_T ( APIENTRY* PFND3D12DDI_CALCPRIVATEOPENEDPROTECTEDRESOURCESESSIONSIZE_0030)( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_OPEN_PROTECTED_RESOURCE_SESSION_0030* pArgs ); typedef HRESULT ( APIENTRY* PFND3D12DDI_OPENPROTECTEDRESOURCESESSION_0030 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_OPEN_PROTECTED_RESOURCE_SESSION_0030* pArgs, D3D12DDI_HPROTECTEDRESOURCESESSION_0030 hDrvProtectedResourceSession ); typedef VOID ( APIENTRY* PFND3D12DDI_DESTROYPROTECTEDRESOURCESESSION_0030 )( D3D12DDI_HDEVICE hDrvDevice, D3D12DDI_HPROTECTEDRESOURCESESSION_0030 hDrvProtectedResourceSession ); // D3D12DDI_TABLE_TYPE_0030_DEVICE_CONTENT_PROTECTION_RESOURCES typedef struct D3D12DDI_DEVICE_FUNCS_CONTENT_PROTECTION_RESOURCES_0030 { PFND3D12DDI_CALCPRIVATEPROTECTEDRESOURCESESSIONSIZE_0030 pfnCalcPrivateProtectedResourceSessionSize; PFND3D12DDI_CREATEPROTECTEDRESOURCESESSION_0030 pfnCreateProtectedResourceSession; PFND3D12DDI_CALCPRIVATEOPENEDPROTECTEDRESOURCESESSIONSIZE_0030 pfnCalcPrivateOpenedProtectedResourceSessionSize; PFND3D12DDI_OPENPROTECTEDRESOURCESESSION_0030 pfnOpenProtectedResourceSession; PFND3D12DDI_DESTROYPROTECTEDRESOURCESESSION_0030 pfnDestroyProtectedResourceSession; } D3D12DDI_DEVICE_FUNCS_CONTENT_PROTECTION_RESOURCES_0030; typedef struct D3D12DDICB_CREATE_PROTECTED_SESSION_0030 { CONST VOID* pPrivateDriverData; UINT PrivateDriverDataSize; } D3D12DDICB_CREATE_PROTECTED_SESSION_0030; typedef HRESULT(APIENTRY CALLBACK* PFND3D12DDI_CREATE_PROTECTED_SESSION_CB_0030)( D3D12DDI_HRTDEVICE hRTDevice, D3D12DDI_HRTPROTECTEDSESSION_0030 hRTProtectedSession, _In_ D3D12DDICB_CREATE_PROTECTED_SESSION_0030* pArgs ); // D3D12DDI_TABLE_TYPE_0030_CONTENT_PROTECTION_CALLBACKS typedef struct D3D12DDI_CONTENT_PROTECTION_CALLBACKS_0030 { PFND3D12DDI_CREATE_PROTECTED_SESSION_CB_0030 pfnCreateProtectedSessionCB; } D3D12DDI_CONTENT_PROTECTION_CALLBACKS_0030; //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Extended Feature Content Protection Resources // Feature: D3D12DDI_FEATURE_0030_CONTENT_PROTECTION_RESOURCES // Version: D3D12DDI_FEATURE_VERSION_CONTENT_PROTECTION_RESOURCES_0030_0 // Usermode DDI Min Version: D3D12DDI_SUPPORTED_0040 #define D3D12DDI_FEATURE_VERSION_CONTENT_PROTECTION_RESOURCES_0040_0 2u //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Extended Feature Content Protection Streaming // Feature: D3D12DDI_FEATURE_0030_CONTENT_PROTECTION_STREAMING // Version: D3D12DDI_FEATURE_VERSION_CONTENT_PROTECTION_STREAMING_0030_0 // Usermode DDI Min Version: D3D12DDI_SUPPORTED_0030 #define D3D12DDI_FEATURE_VERSION_CONTENT_PROTECTION_STREAMING_0030_0 1u typedef struct D3D12DDIARG_CREATE_CRYPTO_SESSION_0030 { UINT NodeMask; GUID DecodeProfile; GUID ContentProtectionSystem; D3D12DDI_BITSTREAM_ENCRYPTION_TYPE_0030 BitstreamEncryption; D3D12DDI_CRYPTO_SESSION_FLAGS_0030 Flags; } D3D12DDIARG_CREATE_CRYPTO_SESSION_0030; typedef SIZE_T ( APIENTRY* PFND3D12DDI_CALCPRIVATECRYPTOSESSIONSIZE_0030 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_CRYPTO_SESSION_0030* pArgs ); typedef HRESULT ( APIENTRY* PFND3D12DDI_CREATECRYPTOSESSION_0030 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_CRYPTO_SESSION_0030* pArgs, D3D12DDI_HCRYPTOSESSION_0030 hDrvCryptoSession, D3D12DDI_HRTPROTECTEDSESSION_0030 hRtProtectedSession ); typedef struct D3D12DDIARG_OPEN_CRYPTO_SESSION_0030 { CONST VOID* pPrivateDriverData; UINT PrivateDriverDataSize; } D3D12DDIARG_OPEN_CRYPTO_SESSION_0030; typedef SIZE_T ( APIENTRY* PFND3D12DDI_CALCPRIVATEOPENEDCRYPTOSESSIONSIZE_0030 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_OPEN_CRYPTO_SESSION_0030* pArgs ); typedef HRESULT ( APIENTRY* PFND3D12DDI_OPENCRYPTOSESSION_0030 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_OPEN_CRYPTO_SESSION_0030* pArgs, D3D12DDI_HCRYPTOSESSION_0030 hDrvCryptoSession ); typedef VOID ( APIENTRY* PFND3D12DDI_DESTROYCRYPTOSESSION_0030 )( D3D12DDI_HDEVICE hDrvDevice, D3D12DDI_HCRYPTOSESSION_0030 hDrvCryptoSession ); typedef HRESULT ( APIENTRY* PFND3D12DDI_GETKEYBASEDATA_0030 ) ( D3D12DDI_HDEVICE hDrvDevice, D3D12DDI_HCRYPTOSESSION_0030 hDrvCryptoSession, _In_reads_bytes_(KeyInputDataSize) CONST VOID* pKeyInputData, UINT KeyInputDataSize, _Out_writes_bytes_(KeyBaseDataSize) VOID* pKeyBaseData, UINT KeyBaseDataSize ); typedef struct D3D12DDIARG_CREATE_CRYPTO_SESSION_POLICY_0030 { const void* pKeyInfo; UINT KeyInfoSize; } D3D12DDIARG_CREATE_CRYPTO_SESSION_POLICY_0030; typedef SIZE_T ( APIENTRY* PFND3D12DDI_CALCPRIVATECRYPTOSESSIONPOLICYSIZE_0030 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_CRYPTO_SESSION_POLICY_0030* pArgs, D3D12DDI_HCRYPTOSESSION_0030 hDrvCryptoSession ); typedef HRESULT ( APIENTRY* PFND3D12DDI_CREATECRYPTOSESSIONPOLICY_0030 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_CRYPTO_SESSION_POLICY_0030* pArgs, D3D12DDI_HCRYPTOSESSION_0030 hDrvCryptoSession, D3D12DDI_HCRYPTOSESSIONPOLICY_0030 hDrvCryptoSessionPolicy, D3D12DDI_HRTPROTECTEDSESSION_0030 hRtProtectedSession ); typedef struct D3D12DDIARG_OPEN_CRYPTO_SESSION_POLICY_0030 { const void* pPrivateDriverData; UINT PrivateDriverDataSize; } D3D12DDIARG_OPEN_CRYPTO_SESSION_POLICY_0030; typedef SIZE_T ( APIENTRY* PFND3D12DDI_CALCPRIVATEOPENEDCRYPTOSESSIONPOLICYSIZE_0030 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_OPEN_CRYPTO_SESSION_POLICY_0030* pArgs ); typedef HRESULT ( APIENTRY* PFND3D12DDI_OPENCRYPTOSESSIONPOLICY_0030 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_OPEN_CRYPTO_SESSION_POLICY_0030* pArgs, D3D12DDI_HCRYPTOSESSIONPOLICY_0030 hDrvCryptoSessionPolicy ); typedef VOID ( APIENTRY* PFND3D12DDI_DESTROYCRYPTOSESSIONPOLICY_0030 )( D3D12DDI_HDEVICE hDrvDevice, D3D12DDI_HCRYPTOSESSIONPOLICY_0030 hDrvCryptoSessionPolicy ); typedef struct D3D12DDI_CRYPTO_SESSION_TRANSFORM_DECRYPT_HEADER_INPUT_ARGUMENTS_0030 { BOOL Enable; _Field_size_bytes_full_(SliceHeadersSize) const void* pSliceHeaders; UINT64 SliceHeadersSize; _Field_size_full_(SliceHeaderCount) const DWORD* pSliceHeadersOffsets; UINT64 SliceHeaderCount; _Field_size_bytes_full_(ContextSize) const void* pContext; UINT64 ContextSize; } D3D12DDI_CRYPTO_SESSION_TRANSFORM_DECRYPT_HEADER_INPUT_ARGUMENTS_0030; typedef struct D3D12DDI_CRYPTO_SESSION_TRANSFORM_INPUT_ARGUMENTS_0030 { D3D12DDI_HCRYPTOSESSIONPOLICY_0030 hDrvCryptoSessionPolicy; D3D12DDI_HRESOURCE hDrvBuffer; UINT64 Size; UINT64 Offset; _Field_size_bytes_full_(IVSize) const void* pIV; UINT IVSize; _Field_size_bytes_full_(SubSampleMappingCount) const void* pSubSampleMappingBlock; UINT SubSampleMappingCount; _Field_size_bytes_full_(ContextSize) const void* pContext; UINT64 ContextSize; D3D12DDI_CRYPTO_SESSION_TRANSFORM_DECRYPT_HEADER_INPUT_ARGUMENTS_0030 EncryptedHeader; } D3D12DDI_CRYPTO_SESSION_TRANSFORM_INPUT_ARGUMENTS_0030; typedef struct D3D12DDI_CRYPTO_SESSION_TRANSFORM_DECRYPT_HEADER_OUTPUT_ARGUMENTS_0030 { BOOL Enable; _Field_size_bytes_full_(SliceHeadersSize) const void *pSliceHeaders; UINT64 SliceHeadersSize; _Field_size_bytes_full_(ContextSize) const void* pContext; UINT64 ContextSize; } D3D12DDI_CRYPTO_SESSION_TRANSFORM_DECRYPT_HEADER_OUTPUT_ARGUMENTS_0030; typedef struct D3D12DDI_CRYPTO_SESSION_TRANSFORM_DECRYPT_OUTPUT_ARGUMENTS_0030 { BOOL Enable; D3D12DDI_HRESOURCE hDrvBuffer; UINT64 Size; UINT64 Offset; } D3D12DDI_CRYPTO_SESSION_TRANSFORM_DECRYPT_OUTPUT_ARGUMENTS_0030; typedef struct D3D12DDI_CRYPTO_SESSION_TRANSFORM_TRANSCRYPT_OUTPUT_ARGUMENTS_0030 { BOOL Enable; _Field_size_bytes_full_(IVSize) void* pIV; UINT IVSize; } D3D12DDI_CRYPTO_SESSION_TRANSFORM_TRANSCRYPT_OUTPUT_ARGUMENTS_0030; typedef struct D3D12DDI_CRYPTO_SESSION_TRANSFORM_OUTPUT_ARGUMENTS_0030 { D3D12DDI_CRYPTO_SESSION_TRANSFORM_DECRYPT_OUTPUT_ARGUMENTS_0030 Decrypt; D3D12DDI_CRYPTO_SESSION_TRANSFORM_TRANSCRYPT_OUTPUT_ARGUMENTS_0030 Transcrypt; D3D12DDI_CRYPTO_SESSION_TRANSFORM_DECRYPT_HEADER_OUTPUT_ARGUMENTS_0030 ClearHeader; } D3D12DDI_CRYPTO_SESSION_TRANSFORM_OUTPUT_ARGUMENTS_0030; typedef HRESULT ( APIENTRY* PFND3D12DDI_TRANSFORMENCRYPTEDDATA_0030 )( D3D12DDI_HDEVICE hDrvDevice, D3D12DDI_CRYPTO_SESSION_TRANSFORM_OPERATION_0030 Operation, _In_ const D3D12DDI_CRYPTO_SESSION_TRANSFORM_OUTPUT_ARGUMENTS_0030* pOutputArguments, _In_ const D3D12DDI_CRYPTO_SESSION_TRANSFORM_INPUT_ARGUMENTS_0030* pInputArguments ); // D3D12DDI_TABLE_TYPE_0030_DEVICE_CONTENT_PROTECTION_STREAMING typedef struct D3D12DDI_DEVICE_FUNCS_CONTENT_PROTECTION_STREAMING_0030 { PFND3D12DDI_CALCPRIVATECRYPTOSESSIONSIZE_0030 pfnCalcPrivateCryptoSessionSize; PFND3D12DDI_CREATECRYPTOSESSION_0030 pfnCreateCryptoSession; PFND3D12DDI_CALCPRIVATEOPENEDCRYPTOSESSIONSIZE_0030 pfnCalcPrivateOpenedCryptoSessionSize; PFND3D12DDI_OPENCRYPTOSESSION_0030 pfnOpenCryptoSession; PFND3D12DDI_DESTROYCRYPTOSESSION_0030 pfnDestroyCryptoSession; PFND3D12DDI_GETKEYBASEDATA_0030 pfnGetKeyBaseData; PFND3D12DDI_CALCPRIVATECRYPTOSESSIONPOLICYSIZE_0030 pfnCalcPrivateCryptoSessionPolicySize; PFND3D12DDI_CREATECRYPTOSESSIONPOLICY_0030 pfnCreateCryptoSessionPolicy; PFND3D12DDI_CALCPRIVATEOPENEDCRYPTOSESSIONPOLICYSIZE_0030 pfnCalcPrivateOpenedCryptoSessionPolicySize; PFND3D12DDI_OPENCRYPTOSESSIONPOLICY_0030 pfnOpenCryptoSessionPolicy; PFND3D12DDI_DESTROYCRYPTOSESSIONPOLICY_0030 pfnDestroyCryptoSessionPolicy; PFND3D12DDI_TRANSFORMENCRYPTEDDATA_0030 pfnTransformEncryptedData; } D3D12DDI_DEVICE_FUNCS_CONTENT_PROTECTION_STREAMING_0030; //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Extended Feature Video // Version: D3D12DDI_FEATURE_VERSION_VIDEO_0030_0 // Usermode DDI Min Version: D3D12DDI_SUPPORTED_0021 typedef struct D3D12DDI_VIDEO_DECODE_DECRYPTION_ARGUMENTS_0030 { D3D12DDI_HCRYPTOSESSIONPOLICY_0030 hDrvCryptoSessionPolicy; CONST VOID* pIV; UINT IVSize; CONST VOID* pSubSampleMappingBlock; UINT SubSampleMappingCount; } D3D12DDI_VIDEO_DECODE_DECRYPTION_ARGUMENTS_0030; //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Extended Feature Video // Version: D3D12DDI_FEATURE_VERSION_VIDEO_0032_0 // Usermode DDI Min Version: D3D12DDI_SUPPORTED_0021 // UMD handle types */ IntPtr h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HVIDEODECODER_0020 MAKE_D3D12DDI_HVIDEODECODER_0020(/* optional(void) */ IntPtr h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HVIDEOEXTENSIONCOMMAND_0063 MAKE_D3D12DDI_HVIDEOEXTENSIONCOMMAND_0063(/* 3D } D3D12DDI_RESOURCE_COORDINATE_0053; typedef struct D3D12DDI_VIDEO_MOTION_ESTIMATOR_OUTPUT_0053 { D3D12DDI_HVIDEOMOTIONVECTORHEAP_0053 hDrvMotionVectorHeap; } D3D12DDI_VIDEO_MOTION_ESTIMATOR_OUTPUT_0053; typedef struct D3D12DDI_VIDEO_MOTION_ESTIMATOR_INPUT_0053 { D3D12DDI_HRESOURCE hDrvInputTexture2D; UINT InputSubresourceIndex; D3D12DDI_HRESOURCE hDrvReferenceTexture2D; UINT ReferenceSubresourceIndex; D3D12DDI_HVIDEOMOTIONVECTORHEAP_0053 hDrvPreviousMotionVectorHeap; } D3D12DDI_VIDEO_MOTION_ESTIMATOR_INPUT_0053; typedef VOID ( APIENTRY* PFND3D12DDI_ESTIMATE_MOTION_0053 )( D3D12DDI_HCOMMANDLIST hDrvCommandList, D3D12DDI_HVIDEOMOTIONESTIMATOR_0053 hDrvMotionEstimator, CONST D3D12DDI_VIDEO_MOTION_ESTIMATOR_OUTPUT_0053* pOutputArguments, CONST D3D12DDI_VIDEO_MOTION_ESTIMATOR_INPUT_0053* pInputArguments ); typedef struct D3D12DDI_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT_0053 { D3D12DDI_HRESOURCE hDrvMotionVectorTexture2D; D3D12DDI_RESOURCE_COORDINATE_0053 MotionVectorCoordinate; D3D12DDI_HRESOURCE hDrvDifferencesMetricTexture2D; D3D12DDI_RESOURCE_COORDINATE_0053 DifferencesMetricCoordinate; } D3D12DDI_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT_0053; typedef struct D3D12DDI_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_INPUT_0053 { D3D12DDI_HVIDEOMOTIONVECTORHEAP_0053 hDrvMotionVectorHeap; UINT PixelWidth; UINT PixelHeight; } D3D12DDI_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_INPUT_0053; typedef VOID ( APIENTRY* PFND3D12DDI_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_0053 )( D3D12DDI_HCOMMANDLIST hDrvCommandList, CONST D3D12DDI_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT_0053* pOutputArguments, CONST D3D12DDI_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_INPUT_0053* pInputArguments ); // D3D12DDI_TABLE_TYPE_0053_COMMAND_LIST_VIDEO_ENCODE typedef struct D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_ENCODE_0053 { PFND3D12DDI_CLOSECOMMANDLIST pfnCloseCommandList; PFND3D12DDI_RESETCOMMANDLIST_0040 pfnResetCommandList; PFND3D12DDI_DISCARD_RESOURCE_0003 pfnDiscardResource; PFND3D12DDI_SET_MARKER pfnSetMarker; PFND3D12DDI_SET_PREDICATION pfnSetPredication; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnBeginQuery; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnEndQuery; PFND3D12DDI_RESOLVE_QUERY_DATA pfnResolveQueryData; PFND3D12DDI_RESOURCEBARRIER_0022 pfnResourceBarrier; PFND3D12DDI_ESTIMATE_MOTION_0053 pfnEstimateMotion; PFND3D12DDI_SETPROTECTEDRESOURCESESSION_0030 pfnSetProtectedResourceSession; PFND3D12DDI_WRITEBUFFERIMMEDIATE_0032 pfnWriteBufferImmediate; PFND3D12DDI_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_0053 pfnResolveVideoMotionVectorHeap; } D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_ENCODE_0053; //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Extended Feature Video // Version: D3D12DDI_FEATURE_VERSION_VIDEO_0060 // Usermode DDI Min Version: D3D12DDI_SUPPORTED_0043 #define D3D12DDI_FEATURE_VERSION_VIDEO_0060_0 14u // D3D12DDICAPS_TYPE_VIDEO_0053_MOTION_ESTIMATOR // *pInfo = nullptr // pData = D3D12DDI_VIDEO_MOTION_ESTIMATOR_DATA_0060 // DataSize = sizeof(D3D12DDI_VIDEO_MOTION_ESTIMATOR_DATA_0060) typedef struct D3D12DDI_VIDEO_MOTION_ESTIMATOR_DATA_0060 { UINT NodeIndex; // input DXGI_FORMAT InputFormat; // input D3D12DDI_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE_FLAGS_0053 BlockSizeFlags; // output D3D12DDI_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAGS_0053 PrecisionFlags; // output D3D12DDI_VIDEO_SIZE_RANGE_0032 SizeRange; // output } D3D12DDI_VIDEO_MOTION_ESTIMATOR_DATA_0060; // D3D12DDICAPS_TYPE_VIDEO_0053_MOTION_ESTIMATOR_SIZE // *pInfo = nullptr // pData = D3D12DDI_VIDEO_MOTION_ESTIMATOR_SIZE_DATA_0060 // DataSize = sizeof(D3D12DDI_VIDEO_MOTION_ESTIMATOR_SIZE_DATA_0060) typedef struct D3D12DDI_VIDEO_MOTION_ESTIMATOR_SIZE_DATA_0060 { UINT NodeMask; // input DXGI_FORMAT InputFormat; // input D3D12DDI_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE_0053 BlockSize; // input D3D12DDI_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_0053 Precision; // input D3D12DDI_VIDEO_SIZE_RANGE_0032 SizeRange; // input BOOL Protected; // input UINT64 MotionEstimatorMemoryPoolL0Size; // output UINT64 MotionEstimatorMemoryPoolL1Size; // output UINT64 MotionVectorHeapMemoryPoolL0Size; // output UINT64 MotionVectorHeapMemoryPoolL1Size; // output } D3D12DDI_VIDEO_MOTION_ESTIMATOR_SIZE_DATA_0060; typedef struct D3D12DDIARG_CREATE_VIDEO_MOTION_ESTIMATOR_0060 { UINT NodeMask; DXGI_FORMAT InputFormat; D3D12DDI_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE_0053 BlockSize; D3D12DDI_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_0053 Precision; D3D12DDI_VIDEO_SIZE_RANGE_0032 SizeRange; D3D12DDI_HPROTECTEDRESOURCESESSION_0030 hDrvProtectedResourceSession; } D3D12DDIARG_CREATE_VIDEO_MOTION_ESTIMATOR_0060; typedef SIZE_T ( APIENTRY* PFND3D12DDI_CALCPRIVATEVIDEOMOTIONESTIMATORSIZE_0060 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_VIDEO_MOTION_ESTIMATOR_0060* pArgs); typedef HRESULT ( APIENTRY* PFND3D12DDI_CREATEVIDEOMOTIONESTIMATOR_0060 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_VIDEO_MOTION_ESTIMATOR_0060* pArgs, D3D12DDI_HVIDEOMOTIONESTIMATOR_0053 hDrvMotionEstimator); typedef struct D3D12DDIARG_CREATE_VIDEO_MOTION_VECTOR_HEAP_0060 { UINT NodeMask; DXGI_FORMAT InputFormat; D3D12DDI_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE_0053 BlockSize; D3D12DDI_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_0053 Precision; D3D12DDI_VIDEO_SIZE_RANGE_0032 SizeRange; D3D12DDI_HPROTECTEDRESOURCESESSION_0030 hDrvProtectedResourceSession; } D3D12DDIARG_CREATE_VIDEO_MOTION_VECTOR_HEAP_0060; typedef SIZE_T ( APIENTRY* PFND3D12DDI_CALCPRIVATEVIDEOMOTIONVECTORHEAPSIZE_0060 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_VIDEO_MOTION_VECTOR_HEAP_0060* pArgs); typedef HRESULT ( APIENTRY* PFND3D12DDI_CREATEVIDEOMOTIONVECTORHEAP_0060 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_VIDEO_MOTION_VECTOR_HEAP_0060* pArgs, D3D12DDI_HVIDEOMOTIONVECTORHEAP_0053 hDrvMotionEstimator); typedef struct D3D12DDI_DEVICE_FUNCS_VIDEO_0060 { PFND3D12DDI_VIDEO_GETCAPS pfnGetCaps; PFND3D12DDI_CALCPRIVATEVIDEODECODERSIZE_0032 pfnCalcPrivateVideoDecoderSize; PFND3D12DDI_CREATEVIDEODECODER_0032 pfnCreateVideoDecoder; PFND3D12DDI_DESTROYVIDEODECODER_0021 pfnDestroyVideoDecoder; PFND3D12DDI_CALCPRIVATEVIDEODECODERHEAPSIZE_0033 pfnCalcPrivateVideoDecoderHeapSize; PFND3D12DDI_CREATEVIDEODECODERHEAP_0033 pfnCreateVideoDecoderHeap; PFND3D12DDI_DESTROYVIDEODECODERHEAP_0032 pfnDestroyVideoDecoderHeap; PFND3D12DDI_CALCPRIVATEVIDEOPROCESSORSIZE_0043 pfnCalcPrivateVideoProcessorSize; PFND3D12DDI_CREATEVIDEOPROCESSOR_0043 pfnCreateVideoProcessor; PFND3D12DDI_DESTROYVIDEOPROCESSOR_0021 pfnDestroyVideoProcessor; PFND3D12DDI_CALCPRIVATEVIDEOMOTIONESTIMATORSIZE_0060 pfnCalcPrivateVideoMotionEstimatorSize; PFND3D12DDI_CREATEVIDEOMOTIONESTIMATOR_0060 pfnCreateVideoMotionEstimator; PFND3D12DDI_DESTROYVIDEOMOTIONESTIMATOR_0053 pfnDestroyVideoMotionEstimator; PFND3D12DDI_CALCPRIVATEVIDEOMOTIONVECTORHEAPSIZE_0060 pfnCalcPrivateVideoMotionVectorHeapSize; PFND3D12DDI_CREATEVIDEOMOTIONVECTORHEAP_0060 pfnCreateVideoMotionVectorHeap; PFND3D12DDI_DESTROYVIDEOMOTIONVECTORHEAP_0053 pfnDestroyVideoMotionVectorHeap; } D3D12DDI_DEVICE_FUNCS_VIDEO_0060; typedef struct D3D12DDI_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT_0060 { D3D12DDI_HRESOURCE hDrvMotionVectorTexture2D; D3D12DDI_RESOURCE_COORDINATE_0053 MotionVectorCoordinate; } D3D12DDI_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT_0060; typedef VOID ( APIENTRY* PFND3D12DDI_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_0060 )( D3D12DDI_HCOMMANDLIST hDrvCommandList, CONST D3D12DDI_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT_0060* pOutputArguments, CONST D3D12DDI_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_INPUT_0053* pInputArguments ); // D3D12DDI_TABLE_TYPE_0053_COMMAND_LIST_VIDEO_ENCODE typedef struct D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_ENCODE_0060 { PFND3D12DDI_CLOSECOMMANDLIST pfnCloseCommandList; PFND3D12DDI_RESETCOMMANDLIST_0040 pfnResetCommandList; PFND3D12DDI_DISCARD_RESOURCE_0003 pfnDiscardResource; PFND3D12DDI_SET_MARKER pfnSetMarker; PFND3D12DDI_SET_PREDICATION pfnSetPredication; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnBeginQuery; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnEndQuery; PFND3D12DDI_RESOLVE_QUERY_DATA pfnResolveQueryData; PFND3D12DDI_RESOURCEBARRIER_0022 pfnResourceBarrier; PFND3D12DDI_ESTIMATE_MOTION_0053 pfnEstimateMotion; PFND3D12DDI_SETPROTECTEDRESOURCESESSION_0030 pfnSetProtectedResourceSession; PFND3D12DDI_WRITEBUFFERIMMEDIATE_0032 pfnWriteBufferImmediate; PFND3D12DDI_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_0060 pfnResolveVideoMotionVectorHeap; } D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_ENCODE_0060; //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Extended Feature Video // Version: D3D12DDI_FEATURE_VERSION_VIDEO_0063 // Usermode DDI Min Version: D3D12DDI_SUPPORTED_0043 #define D3D12DDI_FEATURE_VERSION_VIDEO_0063_0 15u // UMD handle types */ [MarshalAs(UnmanagedType.IUnknown)] out object h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HVIDEOMOTIONESTIMATOR_0053 MAKE_D3D12DDI_HVIDEOMOTIONESTIMATOR_0053(/* } D3D12DDI_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS_0041; DEFINE_ENUM_FLAG_OPERATORS(D3D12DDI_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS_0041); typedef struct D3D12DDI_VIDEO_DECODE_HISTOGRAM_DATA_0041 { UINT NodeIndex; // in GUID DecodeProfile; // in UINT Width; // in UINT Height; // in DXGI_FORMAT DecodeFormat; // in D3D12DDI_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS_0041 Components; // out UINT BinCount; // out UINT CounterBitDepth; // out } D3D12DDI_VIDEO_DECODE_HISTOGRAM_DATA_0041; typedef struct D3D12DDI_VIDEO_DECODE_COMPONENT_HISTOGRAM_0041 { UINT64 Offset; D3D12DDI_HRESOURCE hDrvBuffer; } D3D12DDI_VIDEO_DECODE_COMPONENT_HISTOGRAM_0041; #define D3D12DDI_VIDEO_DECODE_MAX_HISTOGRAM_COMPONENTS 4 typedef struct D3D12DDI_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS_0041 { D3D12DDI_HRESOURCE hDrvOutputTexture2D; UINT OutputSubresource; D3D12DDI_VIDEO_DECODE_CONVERSION_ARGUMENTS_0021 ConversionArguments; D3D12DDI_VIDEO_DECODE_COMPONENT_HISTOGRAM_0041 Histograms[D3D12DDI_VIDEO_DECODE_MAX_HISTOGRAM_COMPONENTS]; } D3D12DDI_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS_0041; typedef VOID ( APIENTRY* PFND3D12DDI_VIDEO_DECODE_FRAME_0041 )( D3D12DDI_HCOMMANDLIST hDrvCommandList, D3D12DDI_HVIDEODECODER_0020 hDrvDecoder, const D3D12DDI_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS_0041* pOutputStreamParameters, const D3D12DDI_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS_0032* pInputStreamParameters ); // D3D12DDI_TABLE_TYPE_0022_COMMAND_LIST_VIDEO_DECODE typedef struct D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_DECODE_0041 { PFND3D12DDI_CLOSECOMMANDLIST pfnCloseCommandList; PFND3D12DDI_RESETCOMMANDLIST_0040 pfnResetCommandList; PFND3D12DDI_DISCARD_RESOURCE_0003 pfnDiscardResource; PFND3D12DDI_SET_MARKER pfnSetMarker; PFND3D12DDI_SET_PREDICATION pfnSetPredication; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnBeginQuery; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnEndQuery; PFND3D12DDI_RESOLVE_QUERY_DATA pfnResolveQueryData; PFND3D12DDI_RESOURCEBARRIER_0022 pfnResourceBarrier; PFND3D12DDI_VIDEO_DECODE_FRAME_0041 pfnDecodeFrame; PFND3D12DDI_SETPROTECTEDRESOURCESESSION_0030 pfnSetProtectedResourceSession; PFND3D12DDI_WRITEBUFFERIMMEDIATE_0032 pfnWriteBufferImmediate; } D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_DECODE_0041; //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Extended Feature Video // Version: D3D12DDI_FEATURE_VERSION_VIDEO_0041_1 // Usermode DDI Min Version: D3D12DDI_SUPPORTED_0040 #define D3D12DDI_FEATURE_VERSION_VIDEO_0041_1 11u typedef struct D3D12DDI_VIDEO_DECODE_CONVERSION_ARGUMENTS_0041 { BOOL Enable; D3D12DDI_HRESOURCE hDrvReferenceTexture2D; UINT ReferenceSubresource; DXGI_COLOR_SPACE_TYPE OutputColorSpace; DXGI_COLOR_SPACE_TYPE DecodeColorSpace; UINT OutputWidth; UINT OutputHeight; } D3D12DDI_VIDEO_DECODE_CONVERSION_ARGUMENTS_0041; typedef struct D3D12DDI_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS_0041_1 { D3D12DDI_HRESOURCE hDrvOutputTexture2D; UINT OutputSubresource; D3D12DDI_VIDEO_DECODE_CONVERSION_ARGUMENTS_0041 ConversionArguments; D3D12DDI_VIDEO_DECODE_COMPONENT_HISTOGRAM_0041 Histograms[D3D12DDI_VIDEO_DECODE_MAX_HISTOGRAM_COMPONENTS]; } D3D12DDI_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS_0041_1; typedef VOID ( APIENTRY* PFND3D12DDI_VIDEO_DECODE_FRAME_0041_1 )( D3D12DDI_HCOMMANDLIST hDrvCommandList, D3D12DDI_HVIDEODECODER_0020 hDrvDecoder, const D3D12DDI_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS_0041_1* pOutputStreamParameters, const D3D12DDI_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS_0032* pInputStreamParameters ); // D3D12DDI_TABLE_TYPE_0022_COMMAND_LIST_VIDEO_DECODE typedef struct D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_DECODE_0041_1 { PFND3D12DDI_CLOSECOMMANDLIST pfnCloseCommandList; PFND3D12DDI_RESETCOMMANDLIST_0040 pfnResetCommandList; PFND3D12DDI_DISCARD_RESOURCE_0003 pfnDiscardResource; PFND3D12DDI_SET_MARKER pfnSetMarker; PFND3D12DDI_SET_PREDICATION pfnSetPredication; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnBeginQuery; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnEndQuery; PFND3D12DDI_RESOLVE_QUERY_DATA pfnResolveQueryData; PFND3D12DDI_RESOURCEBARRIER_0022 pfnResourceBarrier; PFND3D12DDI_VIDEO_DECODE_FRAME_0041_1 pfnDecodeFrame; PFND3D12DDI_SETPROTECTEDRESOURCESESSION_0030 pfnSetProtectedResourceSession; PFND3D12DDI_WRITEBUFFERIMMEDIATE_0032 pfnWriteBufferImmediate; } D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_DECODE_0041_1; //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Extended Feature Video // Version: D3D12DDI_FEATURE_VERSION_VIDEO_0043 // Usermode DDI Min Version: D3D12DDI_SUPPORTED_0040 #define D3D12DDI_FEATURE_VERSION_VIDEO_0043_0 12u typedef struct D3D12DDI_VIDEO_PROCESSOR_INPUT_STREAM_DESC_0043 { DXGI_FORMAT Format; DXGI_COLOR_SPACE_TYPE ColorSpace; DXGI_RATIONAL SourceAspectRatio; DXGI_RATIONAL DestinationAspectRatio; DXGI_RATIONAL FrameRate; D3D12DDI_VIDEO_SIZE_RANGE_0032 SourceSizeRange; D3D12DDI_VIDEO_SIZE_RANGE_0032 DestinationSizeRange; BOOL EnableOrientation; D3D12DDI_VIDEO_PROCESS_FILTER_FLAGS_0020 FilterFlags; D3D12DDI_VIDEO_FRAME_STEREO_FORMAT_0020 StereoFormat; D3D12DDI_VIDEO_PROCESS_DEINTERLACE_FLAGS_0020 DeinterlaceMode; BOOL EnableAlphaBlending; D3D12DDI_VIDEO_PROCESS_LUMA_KEY_0020 LumaKey; UINT NumPastFrames; UINT NumFutureFrames; BOOL EnableAutoProcessing; } D3D12DDI_VIDEO_PROCESSOR_INPUT_STREAM_DESC_0043; typedef struct D3D12DDIARG_CREATE_VIDEO_PROCESSOR_0043 { UINT NodeMask; D3D12DDI_VIDEO_PROCESS_OUTPUT_STREAM_DESC_0032 OutputStream; D3D12DDI_VIDEO_PROCESSOR_INPUT_STREAM_DESC_0043* pInputStreams; UINT NumInputStreams; } D3D12DDIARG_CREATE_VIDEO_PROCESSOR_0043; // D3D12DDICAPS_TYPE_VIDEO_0032_PROCESSOR_SIZE // *pInfo = nullptr // pData = D3D12DDI_VIDEO_PROCESSOR_SIZE_DATA_0043 // DataSize = sizeof(D3D12DDI_VIDEO_PROCESSOR_SIZE_DATA_0043) typedef struct D3D12DDI_VIDEO_PROCESSOR_SIZE_DATA_0043 { D3D12DDIARG_CREATE_VIDEO_PROCESSOR_0043 VideoProcessorDesc; // input UINT64 MemoryPoolL0Size; // output UINT64 MemoryPoolL1Size; // output } D3D12DDI_VIDEO_PROCESSOR_SIZE_DATA_0043; typedef SIZE_T ( APIENTRY* PFND3D12DDI_CALCPRIVATEVIDEOPROCESSORSIZE_0043 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_VIDEO_PROCESSOR_0043* pArgs); typedef HRESULT ( APIENTRY* PFND3D12DDI_CREATEVIDEOPROCESSOR_0043 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_VIDEO_PROCESSOR_0043* pArgs, D3D12DDI_HVIDEOPROCESSOR_0020 hDrvVideoProcessor); typedef struct D3D12DDI_DEVICE_FUNCS_VIDEO_0043 { PFND3D12DDI_VIDEO_GETCAPS pfnGetCaps; PFND3D12DDI_CALCPRIVATEVIDEODECODERSIZE_0032 pfnCalcPrivateVideoDecoderSize; PFND3D12DDI_CREATEVIDEODECODER_0032 pfnCreateVideoDecoder; PFND3D12DDI_DESTROYVIDEODECODER_0021 pfnDestroyVideoDecoder; PFND3D12DDI_CALCPRIVATEVIDEODECODERHEAPSIZE_0033 pfnCalcPrivateVideoDecoderHeapSize; PFND3D12DDI_CREATEVIDEODECODERHEAP_0033 pfnCreateVideoDecoderHeap; PFND3D12DDI_DESTROYVIDEODECODERHEAP_0032 pfnDestroyVideoDecoderHeap; PFND3D12DDI_CALCPRIVATEVIDEOPROCESSORSIZE_0043 pfnCalcPrivateVideoProcessorSize; PFND3D12DDI_CREATEVIDEOPROCESSOR_0043 pfnCreateVideoProcessor; PFND3D12DDI_DESTROYVIDEOPROCESSOR_0021 pfnDestroyVideoProcessor; } D3D12DDI_DEVICE_FUNCS_VIDEO_0043; typedef struct D3D12DDIARG_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS_0043 { D3D12DDI_VIDEO_PROCESS_INPUT_STREAM_0020 InputStream[2]; D3D12DDI_VIDEO_PROCESS_TRANSFORM_0032 Transform; D3D12DDI_VIDEO_PROCESS_INPUT_STREAM_FLAGS_0020 Flags; D3D12DDI_VIDEO_PROCESS_INPUT_STREAM_RATE_INFO_0032 RateInfo; INT FilterLevels[D3D12DDI_VIDEO_PROCESS_MAX_FILTERS_0020]; D3D12DDI_VIDEO_PROCESS_ALPHA_BLENDING_0020 AlphaBlending; D3D12DDI_VIDEO_FIELD_TYPE_0020 FieldType; } D3D12DDIARG_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS_0043; typedef VOID ( APIENTRY* PFND3D12DDI_VIDEO_PROCESS_FRAME_0043) ( D3D12DDI_HCOMMANDLIST hDrvCommandList, D3D12DDI_HVIDEOPROCESSOR_0020 hDrvVideoProcessor, const D3D12DDIARG_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS_0032* pOutputParameters, const D3D12DDIARG_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS_0043* pInputStreamParameters, UINT NumInputStreams ); // D3D12DDI_TABLE_TYPE_0022_COMMAND_LIST_VIDEO_DECODE typedef struct D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_PROCESS_0043 { PFND3D12DDI_CLOSECOMMANDLIST pfnCloseCommandList; PFND3D12DDI_RESETCOMMANDLIST_0040 pfnResetCommandList; PFND3D12DDI_DISCARD_RESOURCE_0003 pfnDiscardResource; PFND3D12DDI_SET_MARKER pfnSetMarker; PFND3D12DDI_SET_PREDICATION pfnSetPredication; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnBeginQuery; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnEndQuery; PFND3D12DDI_RESOLVE_QUERY_DATA pfnResolveQueryData; PFND3D12DDI_RESOURCEBARRIER_0022 pfnResourceBarrier; PFND3D12DDI_VIDEO_PROCESS_FRAME_0043 pfnProcessFrame; PFND3D12DDI_SETPROTECTEDRESOURCESESSION_0030 pfnSetProtectedResourceSession; PFND3D12DDI_WRITEBUFFERIMMEDIATE_0032 pfnWriteBufferImmediate; } D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_PROCESS_0043; //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Extended Feature Video // Version: D3D12DDI_FEATURE_VERSION_VIDEO_0053 // Usermode DDI Min Version: D3D12DDI_SUPPORTED_0043 #define D3D12DDI_FEATURE_VERSION_VIDEO_0053_0 13u // UMD handle types */ [MarshalAs(UnmanagedType.IUnknown)] out object h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HVIDEOMOTIONVECTORHEAP_0053 MAKE_D3D12DDI_HVIDEOMOTIONVECTORHEAP_0053(/* } D3D12DDI_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS_0041; DEFINE_ENUM_FLAG_OPERATORS(D3D12DDI_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS_0041); typedef struct D3D12DDI_VIDEO_DECODE_HISTOGRAM_DATA_0041 { UINT NodeIndex; // in GUID DecodeProfile; // in UINT Width; // in UINT Height; // in DXGI_FORMAT DecodeFormat; // in D3D12DDI_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS_0041 Components; // out UINT BinCount; // out UINT CounterBitDepth; // out } D3D12DDI_VIDEO_DECODE_HISTOGRAM_DATA_0041; typedef struct D3D12DDI_VIDEO_DECODE_COMPONENT_HISTOGRAM_0041 { UINT64 Offset; D3D12DDI_HRESOURCE hDrvBuffer; } D3D12DDI_VIDEO_DECODE_COMPONENT_HISTOGRAM_0041; #define D3D12DDI_VIDEO_DECODE_MAX_HISTOGRAM_COMPONENTS 4 typedef struct D3D12DDI_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS_0041 { D3D12DDI_HRESOURCE hDrvOutputTexture2D; UINT OutputSubresource; D3D12DDI_VIDEO_DECODE_CONVERSION_ARGUMENTS_0021 ConversionArguments; D3D12DDI_VIDEO_DECODE_COMPONENT_HISTOGRAM_0041 Histograms[D3D12DDI_VIDEO_DECODE_MAX_HISTOGRAM_COMPONENTS]; } D3D12DDI_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS_0041; typedef VOID ( APIENTRY* PFND3D12DDI_VIDEO_DECODE_FRAME_0041 )( D3D12DDI_HCOMMANDLIST hDrvCommandList, D3D12DDI_HVIDEODECODER_0020 hDrvDecoder, const D3D12DDI_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS_0041* pOutputStreamParameters, const D3D12DDI_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS_0032* pInputStreamParameters ); // D3D12DDI_TABLE_TYPE_0022_COMMAND_LIST_VIDEO_DECODE typedef struct D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_DECODE_0041 { PFND3D12DDI_CLOSECOMMANDLIST pfnCloseCommandList; PFND3D12DDI_RESETCOMMANDLIST_0040 pfnResetCommandList; PFND3D12DDI_DISCARD_RESOURCE_0003 pfnDiscardResource; PFND3D12DDI_SET_MARKER pfnSetMarker; PFND3D12DDI_SET_PREDICATION pfnSetPredication; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnBeginQuery; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnEndQuery; PFND3D12DDI_RESOLVE_QUERY_DATA pfnResolveQueryData; PFND3D12DDI_RESOURCEBARRIER_0022 pfnResourceBarrier; PFND3D12DDI_VIDEO_DECODE_FRAME_0041 pfnDecodeFrame; PFND3D12DDI_SETPROTECTEDRESOURCESESSION_0030 pfnSetProtectedResourceSession; PFND3D12DDI_WRITEBUFFERIMMEDIATE_0032 pfnWriteBufferImmediate; } D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_DECODE_0041; //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Extended Feature Video // Version: D3D12DDI_FEATURE_VERSION_VIDEO_0041_1 // Usermode DDI Min Version: D3D12DDI_SUPPORTED_0040 #define D3D12DDI_FEATURE_VERSION_VIDEO_0041_1 11u typedef struct D3D12DDI_VIDEO_DECODE_CONVERSION_ARGUMENTS_0041 { BOOL Enable; D3D12DDI_HRESOURCE hDrvReferenceTexture2D; UINT ReferenceSubresource; DXGI_COLOR_SPACE_TYPE OutputColorSpace; DXGI_COLOR_SPACE_TYPE DecodeColorSpace; UINT OutputWidth; UINT OutputHeight; } D3D12DDI_VIDEO_DECODE_CONVERSION_ARGUMENTS_0041; typedef struct D3D12DDI_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS_0041_1 { D3D12DDI_HRESOURCE hDrvOutputTexture2D; UINT OutputSubresource; D3D12DDI_VIDEO_DECODE_CONVERSION_ARGUMENTS_0041 ConversionArguments; D3D12DDI_VIDEO_DECODE_COMPONENT_HISTOGRAM_0041 Histograms[D3D12DDI_VIDEO_DECODE_MAX_HISTOGRAM_COMPONENTS]; } D3D12DDI_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS_0041_1; typedef VOID ( APIENTRY* PFND3D12DDI_VIDEO_DECODE_FRAME_0041_1 )( D3D12DDI_HCOMMANDLIST hDrvCommandList, D3D12DDI_HVIDEODECODER_0020 hDrvDecoder, const D3D12DDI_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS_0041_1* pOutputStreamParameters, const D3D12DDI_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS_0032* pInputStreamParameters ); // D3D12DDI_TABLE_TYPE_0022_COMMAND_LIST_VIDEO_DECODE typedef struct D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_DECODE_0041_1 { PFND3D12DDI_CLOSECOMMANDLIST pfnCloseCommandList; PFND3D12DDI_RESETCOMMANDLIST_0040 pfnResetCommandList; PFND3D12DDI_DISCARD_RESOURCE_0003 pfnDiscardResource; PFND3D12DDI_SET_MARKER pfnSetMarker; PFND3D12DDI_SET_PREDICATION pfnSetPredication; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnBeginQuery; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnEndQuery; PFND3D12DDI_RESOLVE_QUERY_DATA pfnResolveQueryData; PFND3D12DDI_RESOURCEBARRIER_0022 pfnResourceBarrier; PFND3D12DDI_VIDEO_DECODE_FRAME_0041_1 pfnDecodeFrame; PFND3D12DDI_SETPROTECTEDRESOURCESESSION_0030 pfnSetProtectedResourceSession; PFND3D12DDI_WRITEBUFFERIMMEDIATE_0032 pfnWriteBufferImmediate; } D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_DECODE_0041_1; //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Extended Feature Video // Version: D3D12DDI_FEATURE_VERSION_VIDEO_0043 // Usermode DDI Min Version: D3D12DDI_SUPPORTED_0040 #define D3D12DDI_FEATURE_VERSION_VIDEO_0043_0 12u typedef struct D3D12DDI_VIDEO_PROCESSOR_INPUT_STREAM_DESC_0043 { DXGI_FORMAT Format; DXGI_COLOR_SPACE_TYPE ColorSpace; DXGI_RATIONAL SourceAspectRatio; DXGI_RATIONAL DestinationAspectRatio; DXGI_RATIONAL FrameRate; D3D12DDI_VIDEO_SIZE_RANGE_0032 SourceSizeRange; D3D12DDI_VIDEO_SIZE_RANGE_0032 DestinationSizeRange; BOOL EnableOrientation; D3D12DDI_VIDEO_PROCESS_FILTER_FLAGS_0020 FilterFlags; D3D12DDI_VIDEO_FRAME_STEREO_FORMAT_0020 StereoFormat; D3D12DDI_VIDEO_PROCESS_DEINTERLACE_FLAGS_0020 DeinterlaceMode; BOOL EnableAlphaBlending; D3D12DDI_VIDEO_PROCESS_LUMA_KEY_0020 LumaKey; UINT NumPastFrames; UINT NumFutureFrames; BOOL EnableAutoProcessing; } D3D12DDI_VIDEO_PROCESSOR_INPUT_STREAM_DESC_0043; typedef struct D3D12DDIARG_CREATE_VIDEO_PROCESSOR_0043 { UINT NodeMask; D3D12DDI_VIDEO_PROCESS_OUTPUT_STREAM_DESC_0032 OutputStream; D3D12DDI_VIDEO_PROCESSOR_INPUT_STREAM_DESC_0043* pInputStreams; UINT NumInputStreams; } D3D12DDIARG_CREATE_VIDEO_PROCESSOR_0043; // D3D12DDICAPS_TYPE_VIDEO_0032_PROCESSOR_SIZE // *pInfo = nullptr // pData = D3D12DDI_VIDEO_PROCESSOR_SIZE_DATA_0043 // DataSize = sizeof(D3D12DDI_VIDEO_PROCESSOR_SIZE_DATA_0043) typedef struct D3D12DDI_VIDEO_PROCESSOR_SIZE_DATA_0043 { D3D12DDIARG_CREATE_VIDEO_PROCESSOR_0043 VideoProcessorDesc; // input UINT64 MemoryPoolL0Size; // output UINT64 MemoryPoolL1Size; // output } D3D12DDI_VIDEO_PROCESSOR_SIZE_DATA_0043; typedef SIZE_T ( APIENTRY* PFND3D12DDI_CALCPRIVATEVIDEOPROCESSORSIZE_0043 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_VIDEO_PROCESSOR_0043* pArgs); typedef HRESULT ( APIENTRY* PFND3D12DDI_CREATEVIDEOPROCESSOR_0043 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_VIDEO_PROCESSOR_0043* pArgs, D3D12DDI_HVIDEOPROCESSOR_0020 hDrvVideoProcessor); typedef struct D3D12DDI_DEVICE_FUNCS_VIDEO_0043 { PFND3D12DDI_VIDEO_GETCAPS pfnGetCaps; PFND3D12DDI_CALCPRIVATEVIDEODECODERSIZE_0032 pfnCalcPrivateVideoDecoderSize; PFND3D12DDI_CREATEVIDEODECODER_0032 pfnCreateVideoDecoder; PFND3D12DDI_DESTROYVIDEODECODER_0021 pfnDestroyVideoDecoder; PFND3D12DDI_CALCPRIVATEVIDEODECODERHEAPSIZE_0033 pfnCalcPrivateVideoDecoderHeapSize; PFND3D12DDI_CREATEVIDEODECODERHEAP_0033 pfnCreateVideoDecoderHeap; PFND3D12DDI_DESTROYVIDEODECODERHEAP_0032 pfnDestroyVideoDecoderHeap; PFND3D12DDI_CALCPRIVATEVIDEOPROCESSORSIZE_0043 pfnCalcPrivateVideoProcessorSize; PFND3D12DDI_CREATEVIDEOPROCESSOR_0043 pfnCreateVideoProcessor; PFND3D12DDI_DESTROYVIDEOPROCESSOR_0021 pfnDestroyVideoProcessor; } D3D12DDI_DEVICE_FUNCS_VIDEO_0043; typedef struct D3D12DDIARG_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS_0043 { D3D12DDI_VIDEO_PROCESS_INPUT_STREAM_0020 InputStream[2]; D3D12DDI_VIDEO_PROCESS_TRANSFORM_0032 Transform; D3D12DDI_VIDEO_PROCESS_INPUT_STREAM_FLAGS_0020 Flags; D3D12DDI_VIDEO_PROCESS_INPUT_STREAM_RATE_INFO_0032 RateInfo; INT FilterLevels[D3D12DDI_VIDEO_PROCESS_MAX_FILTERS_0020]; D3D12DDI_VIDEO_PROCESS_ALPHA_BLENDING_0020 AlphaBlending; D3D12DDI_VIDEO_FIELD_TYPE_0020 FieldType; } D3D12DDIARG_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS_0043; typedef VOID ( APIENTRY* PFND3D12DDI_VIDEO_PROCESS_FRAME_0043) ( D3D12DDI_HCOMMANDLIST hDrvCommandList, D3D12DDI_HVIDEOPROCESSOR_0020 hDrvVideoProcessor, const D3D12DDIARG_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS_0032* pOutputParameters, const D3D12DDIARG_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS_0043* pInputStreamParameters, UINT NumInputStreams ); // D3D12DDI_TABLE_TYPE_0022_COMMAND_LIST_VIDEO_DECODE typedef struct D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_PROCESS_0043 { PFND3D12DDI_CLOSECOMMANDLIST pfnCloseCommandList; PFND3D12DDI_RESETCOMMANDLIST_0040 pfnResetCommandList; PFND3D12DDI_DISCARD_RESOURCE_0003 pfnDiscardResource; PFND3D12DDI_SET_MARKER pfnSetMarker; PFND3D12DDI_SET_PREDICATION pfnSetPredication; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnBeginQuery; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnEndQuery; PFND3D12DDI_RESOLVE_QUERY_DATA pfnResolveQueryData; PFND3D12DDI_RESOURCEBARRIER_0022 pfnResourceBarrier; PFND3D12DDI_VIDEO_PROCESS_FRAME_0043 pfnProcessFrame; PFND3D12DDI_SETPROTECTEDRESOURCESESSION_0030 pfnSetProtectedResourceSession; PFND3D12DDI_WRITEBUFFERIMMEDIATE_0032 pfnWriteBufferImmediate; } D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_PROCESS_0043; //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Extended Feature Video // Version: D3D12DDI_FEATURE_VERSION_VIDEO_0053 // Usermode DDI Min Version: D3D12DDI_SUPPORTED_0043 #define D3D12DDI_FEATURE_VERSION_VIDEO_0053_0 13u // UMD handle types D3D10DDI_H( D3D12DDI_HVIDEOMOTIONESTIMATOR_0053 ) */ [MarshalAs(UnmanagedType.IUnknown)] out object h);
        
        [DllImport("d3d12umddi")]
        public static extern D3D12DDI_HVIDEOPROCESSOR_0020 MAKE_D3D12DDI_HVIDEOPROCESSOR_0020(/* optional(void) */ IntPtr h);
        
        [DllImport("d3d9")]
        public static extern IDirect3D9 Direct3DCreate9(uint SDKVersion);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DCompile(/* _In_reads_bytes_(SrcDataSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] pSrcData, /* _In_ */ IntPtr SrcDataSize, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string pSourceName, /* _In_reads_opt_(_Inexpressible_(pDefines->Name != NULL)) */ [MarshalAs(UnmanagedType.LPArray)] _D3D_SHADER_MACRO[] pDefines, /* _In_opt_ */ ID3DInclude pInclude, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string pEntrypoint, /* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pTarget, /* _In_ */ uint Flags1, /* _In_ */ uint Flags2, /* _Out_ */ out ID3D10Blob ppCode, /* _Always_(_Outptr_opt_result_maybenull_) */ out ID3D10Blob ppErrorMsgs);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DCompile2(/* _In_reads_bytes_(SrcDataSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] pSrcData, /* _In_ */ IntPtr SrcDataSize, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string pSourceName, /* _In_reads_opt_(_Inexpressible_(pDefines->Name != NULL)) */ [MarshalAs(UnmanagedType.LPArray)] _D3D_SHADER_MACRO[] pDefines, /* _In_opt_ */ ID3DInclude pInclude, /* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pEntrypoint, /* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pTarget, /* _In_ */ uint Flags1, /* _In_ */ uint Flags2, /* _In_ */ uint SecondaryDataFlags, /* _In_reads_bytes_opt_(SecondaryDataSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 11)] IntPtr[] pSecondaryData, /* _In_ */ IntPtr SecondaryDataSize, /* _Out_ */ out ID3D10Blob ppCode, /* _Always_(_Outptr_opt_result_maybenull_) */ out ID3D10Blob ppErrorMsgs);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DCompileFromFile(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pFileName, /* _In_reads_opt_(_Inexpressible_(pDefines->Name != NULL)) */ [MarshalAs(UnmanagedType.LPArray)] _D3D_SHADER_MACRO[] pDefines, /* _In_opt_ */ ID3DInclude pInclude, /* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pEntrypoint, /* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pTarget, /* _In_ */ uint Flags1, /* _In_ */ uint Flags2, /* _Out_ */ out ID3D10Blob ppCode, /* _Always_(_Outptr_opt_result_maybenull_) */ out ID3D10Blob ppErrorMsgs);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DCompressShaders(/* _In_ */ uint uNumShaders, /* _In_reads_(uNumShaders) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] _D3D_SHADER_DATA[] pShaderData, /* _In_ */ uint uFlags, /* _Out_ */ out ID3D10Blob ppCompressedData);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DCreateBlob(/* _In_ */ IntPtr Size, /* _Out_ */ out ID3D10Blob ppBlob);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DCreateFunctionLinkingGraph(/* _In_ */ uint uFlags, /* _Out_ */ out ID3D11FunctionLinkingGraph ppFunctionLinkingGraph);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DCreateLinker(/* __out */ out ID3D11Linker ppLinker);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DDecompressShaders(/* _In_reads_bytes_(SrcDataSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] pSrcData, /* _In_ */ IntPtr SrcDataSize, /* _In_ */ uint uNumShaders, /* _In_ */ uint uStartIndex, /* _In_reads_opt_(uNumShaders) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] uint[] pIndices, /* _In_ */ uint uFlags, /* _Out_writes_(uNumShaders) */ out IntPtr ppShaders, /* _Out_opt_ */ out uint pTotalShaders);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DDisassemble(/* _In_reads_bytes_(SrcDataSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] pSrcData, /* _In_ */ IntPtr SrcDataSize, /* _In_ */ uint Flags, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string szComments, /* _Out_ */ out ID3D10Blob ppDisassembly);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DDisassemble10Effect(/* _In_ */ ID3D10Effect pEffect, /* _In_ */ uint Flags, /* _Out_ */ out ID3D10Blob ppDisassembly);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DDisassembleRegion(/* _In_reads_bytes_(SrcDataSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] pSrcData, /* _In_ */ IntPtr SrcDataSize, /* _In_ */ uint Flags, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string szComments, /* _In_ */ IntPtr StartByteOffset, /* _In_ */ IntPtr NumInsts, /* optional(SIZE_T) */ out IntPtr pFinishByteOffset, /* _Out_ */ out ID3D10Blob ppDisassembly);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DGetBlobPart(/* _In_reads_bytes_(SrcDataSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] pSrcData, /* _In_ */ IntPtr SrcDataSize, /* _In_ */ D3D_BLOB_PART Part, /* _In_ */ uint Flags, /* _Out_ */ out ID3D10Blob ppPart);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DGetDebugInfo(/* _In_reads_bytes_(SrcDataSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] pSrcData, /* _In_ */ IntPtr SrcDataSize, /* _Out_ */ out ID3D10Blob ppDebugInfo);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DGetInputAndOutputSignatureBlob(/* _In_reads_bytes_(SrcDataSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] pSrcData, /* _In_ */ IntPtr SrcDataSize, /* _Out_ */ out ID3D10Blob ppSignatureBlob);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DGetInputSignatureBlob(/* _In_reads_bytes_(SrcDataSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] pSrcData, /* _In_ */ IntPtr SrcDataSize, /* _Out_ */ out ID3D10Blob ppSignatureBlob);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DGetOutputSignatureBlob(/* _In_reads_bytes_(SrcDataSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] pSrcData, /* _In_ */ IntPtr SrcDataSize, /* _Out_ */ out ID3D10Blob ppSignatureBlob);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DGetTraceInstructionOffsets(/* _In_reads_bytes_(SrcDataSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] pSrcData, /* _In_ */ IntPtr SrcDataSize, /* _In_ */ uint Flags, /* _In_ */ IntPtr StartInstIndex, /* _In_ */ IntPtr NumInsts, /* _Out_writes_to_opt_(NumInsts, min(NumInsts, *pTotalInsts)) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] IntPtr[] pOffsets, /* optional(SIZE_T) */ out IntPtr pTotalInsts);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DLoadModule(/* _In_ */ IntPtr pSrcData, /* _In_ */ IntPtr cbSrcDataSize, /* _Out_ */ out ID3D11Module ppModule);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DPreprocess(/* _In_reads_bytes_(SrcDataSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] pSrcData, /* _In_ */ IntPtr SrcDataSize, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string pSourceName, /* optional(_D3D_SHADER_MACRO) */ IntPtr pDefines, /* _In_opt_ */ ID3DInclude pInclude, /* _Out_ */ out ID3D10Blob ppCodeText, /* _Always_(_Outptr_opt_result_maybenull_) */ out ID3D10Blob ppErrorMsgs);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DReadFileToBlob(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pFileName, /* _Out_ */ out ID3D10Blob ppContents);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DReflect(/* _In_reads_bytes_(SrcDataSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] pSrcData, /* _In_ */ IntPtr SrcDataSize, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pInterface, /* _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppReflector);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DReflectLibrary(/* __in_bcount(SrcDataSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] pSrcData, /* __in */ IntPtr SrcDataSize, /* __in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* __out */ [MarshalAs(UnmanagedType.IUnknown)] out object ppReflector);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DSetBlobPart(/* _In_reads_bytes_(SrcDataSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] pSrcData, /* _In_ */ IntPtr SrcDataSize, /* _In_ */ D3D_BLOB_PART Part, /* _In_ */ uint Flags, /* _In_reads_bytes_(PartSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] IntPtr[] pPart, /* _In_ */ IntPtr PartSize, /* _Out_ */ out ID3D10Blob ppNewShader);
        
        [DllImport("D3DCompiler_47")]
        public static extern HRESULT D3DStripShader(/* _In_reads_bytes_(BytecodeLength) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] pShaderBytecode, /* _In_ */ IntPtr BytecodeLength, /* _In_ */ uint uStripFlags, /* _Out_ */ out ID3D10Blob ppStrippedBlob);
        
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
        
        [DllImport("ddkmapi")]
        public static extern uint DxApi(uint dwFunctionNum, IntPtr lpvInBuffer, uint cbInBuffer, IntPtr lpvOutBuffer, uint cbOutBuffer);
        
        [DllImport("ddraw")]
        public static extern HRESULT DirectDrawCreate([MarshalAs(UnmanagedType.LPStruct)] Guid lpGUID, out LPDIRECTDRAW lplpDD, [MarshalAs(UnmanagedType.IUnknown)] object pUnkOuter);
        
        [DllImport("ddraw")]
        public static extern HRESULT DirectDrawCreateClipper(uint dwFlags, out LPDIRECTDRAWCLIPPER lplpDDClipper, [MarshalAs(UnmanagedType.IUnknown)] object pUnkOuter);
        
        [DllImport("ddraw")]
        public static extern HRESULT DirectDrawCreateEx([MarshalAs(UnmanagedType.LPStruct)] Guid lpGuid, [MarshalAs(UnmanagedType.IUnknown)] object lplpDD, [MarshalAs(UnmanagedType.LPStruct)] Guid iid, [MarshalAs(UnmanagedType.IUnknown)] object pUnkOuter);
        
        [DllImport("ddraw")]
        public static extern HRESULT DirectDrawEnumerateA(ref LPDDENUMCALLBACKA lpCallback, IntPtr lpContext);
        
        [DllImport("ddraw")]
        public static extern HRESULT DirectDrawEnumerateExA(ref LPDDENUMCALLBACKEXA lpCallback, IntPtr lpContext, uint dwFlags);
        
        [DllImport("ddraw")]
        public static extern HRESULT DirectDrawEnumerateExW(ref LPDDENUMCALLBACKEXW lpCallback, IntPtr lpContext, uint dwFlags);
        
        [DllImport("ddraw")]
        public static extern HRESULT DirectDrawEnumerateW(ref LPDDENUMCALLBACKW lpCallback, IntPtr lpContext);
        
        [DllImport("ddrawgdi")]
        public static extern bool GdiEntry1(int pDirectDrawGlobal, IntPtr hdc);
        
        [DllImport("ddrawgdi")]
        public static extern bool GdiEntry10(int pDirectDrawGlobal, ref bool pbNewMode);
        
        [DllImport("ddrawgdi")]
        public static extern bool GdiEntry11(int pSurfaceFrom, int pSurfaceTo);
        
        [DllImport("ddrawgdi")]
        public static extern void GdiEntry12(int pSurface, int pSurfaceAttached);
        
        [DllImport("ddrawgdi")]
        public static extern uint GdiEntry13();
        
        [DllImport("ddrawgdi")]
        public static extern IntPtr GdiEntry14(int pDDraw, int pSurface, bool bRelease);
        
        [DllImport("ddrawgdi")]
        public static extern bool GdiEntry15(int pDDraw, IntPtr hdc, IntPtr lpGammaRamp);
        
        [DllImport("ddrawgdi")]
        public static extern uint GdiEntry16(int pDDraw, int pDDSLcl1, int pDDSLcl2);
        
        [DllImport("ddrawgdi")]
        public static extern bool GdiEntry2(int pDirectDrawGlobal, int pHalInfo, int pDDCallbacks, int pDDSurfaceCallbacks, int pDDPaletteCallbacks, ref LPD3DHAL_CALLBACKS pD3dCallbacks, ref LPD3DHAL_GLOBALDRIVERDATA pD3dDriverData, int pD3dBufferCallbacks, int pD3dTextureFormats, ref uint pdwFourCC, /* // Can be NULL */ int pvmList);
        
        [DllImport("ddrawgdi")]
        public static extern bool GdiEntry3(int pDirectDrawGlobal);
        
        [DllImport("ddrawgdi")]
        public static extern bool GdiEntry4(int pSurfaceLocal, bool bPrimarySurface);
        
        [DllImport("ddrawgdi")]
        public static extern bool GdiEntry5(int pSurfaceLocal);
        
        [DllImport("ddrawgdi")]
        public static extern bool GdiEntry6(int pSurfaceLocal, IntPtr hWnd);
        
        [DllImport("ddrawgdi")]
        public static extern IntPtr GdiEntry7(int pSurfaceLocal, ref tagPALETTEENTRY pColorTable);
        
        [DllImport("ddrawgdi")]
        public static extern bool GdiEntry8(int pSurfaceLocal);
        
        [DllImport("ddrawgdi")]
        public static extern IntPtr GdiEntry9(IntPtr hdc, ref tagBITMAPINFO pbmi, uint iUsage, [MarshalAs(UnmanagedType.IUnknown)] object ppvBits, IntPtr hSectionApp, uint dwOffset);
        
        [DllImport("ddrawi")]
        public static extern HRESULT D3DParseUnknownCommand(IntPtr lpvCommands, [MarshalAs(UnmanagedType.IUnknown)] object lplpvReturnedCommand);
        
        [DllImport("ddrawi")]
        public static extern bool DDHAL_SetInfo(ref _DDHALINFO lpDDHALInfo, bool reset);
        
        [DllImport("ddrawi")]
        public static extern ulong DDHAL_VidMemAlloc(ref LPDDRAWI_DIRECTDRAW_GBL lpDD, int heap, uint dwWidth, uint dwHeight);
        
        [DllImport("ddrawi")]
        public static extern void DDHAL_VidMemFree(ref LPDDRAWI_DIRECTDRAW_GBL lpDD, int heap, ulong fpMem);
        
        [DllImport("ddrawi")]
        public static extern LPDIRECTDRAWSURFACE GetNextMipMap(LPDIRECTDRAWSURFACE lpLevel);
        
        [DllImport("ddrawi")]
        public static extern HRESULT LateAllocateSurfaceMem(LPDIRECTDRAWSURFACE lpSurface, uint dwPleaseAllocType, uint dwWidthInBytesOrSize, uint dwHeight);
        
        [DllImport("dmemmgr")]
        public static extern ulong HeapVidMemAllocAligned(ref LPVIDMEM lpVidMem, uint dwWidth, uint dwHeight, ref _SURFACEALIGNMENT lpAlignment, ref int lpNewPitch);
        
        [DllImport("dmemmgr")]
        public static extern ulong VidMemAlloc(ref _VMEMHEAP pvmh, uint width, uint height);
        
        [DllImport("dmemmgr")]
        public static extern void VidMemFree(ref _VMEMHEAP pvmh, ulong ptr);
        
        [DllImport("DWrite")]
        public static extern HRESULT DWriteCreateFactory(/* _In_ */ DWRITE_FACTORY_TYPE factoryType, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid iid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object factory);
        
        [DllImport("dxcapi")]
        public static extern HRESULT DxcCreateInstance(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid rclsid, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [DllImport("dxcapi")]
        public static extern HRESULT DxcCreateInstance2(/* _In_ */ ref IMalloc pMalloc, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid rclsid, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [DllImport("dxgidebug")]
        public static extern HRESULT DXGIGetDebugInterface([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] object ppDebug);
        
        [DllImport("dxtmpl")]
        public static extern bool DXIsValidAddress(IntPtr lp, uint nBytes, bool bReadWrite);
        
        [DllImport("dxva2api")]
        public static extern void DXVA2FixedToFloat(/* _In_ */ DXVA2_Fixed32 _fixed_);
        
        [DllImport("dxva2api")]
        public static extern _DXVA2_Fixed32 DXVA2FloatToFixed(/* _In_ */ float _float_);
        
        [DllImport("dxva2api")]
        public static extern _DXVA2_Fixed32 DXVA2_Fixed32OpaqueAlpha();
        
        [DllImport("dxva2api")]
        public static extern _DXVA2_Fixed32 DXVA2_Fixed32TransparentAlpha();
        
        [DllImport("dxva2")]
        public static extern HRESULT DXVAHD_CreateDevice(/* _In_ */ ref int pD3DDevice, /* _In_ */ ref _DXVAHD_CONTENT_DESC pContentDesc, /* _In_ */ _DXVAHD_DEVICE_USAGE Usage, /* optional(PDXVAHDSW_Plugin) */ IntPtr pPlugin, /* _Outptr_ */ out IDXVAHD_Device ppDevice);
        
        [DllImport("mfplat")]
        public static extern uint HI32(ulong unPacked);
        
        [DllImport("mfplat")]
        public static extern uint LO32(ulong unPacked);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFAddPeriodicCallback(ref MFPERIODICCALLBACK Callback, [MarshalAs(UnmanagedType.IUnknown)] object pContext, /* _Out_opt_ */ out uint pdwKey);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFAllocateSerialWorkQueue(/* _In_ */ uint dwWorkQueue, /* _Out_ OUT */ out uint pdwWorkQueue);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFAllocateWorkQueue(/* _Out_ OUT */ out uint pdwWorkQueue);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFAllocateWorkQueueEx(/* _In_ */ MFASYNC_WORKQUEUE_TYPE WorkQueueType, /* _Out_ OUT */ out uint pdwWorkQueue);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFAverageTimePerFrameToFrameRate(/* _In_ */ ulong unAverageTimePerFrame, /* _Out_ */ out uint punNumerator, /* _Out_ */ out uint punDenominator);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFBeginCreateFile(__MIDL___MIDL_itf_mfobjects_0000_0017_0001 AccessMode, __MIDL___MIDL_itf_mfobjects_0000_0017_0002 OpenMode, __MIDL___MIDL_itf_mfobjects_0000_0017_0003 fFlags, [MarshalAs(UnmanagedType.LPWStr)] string pwszFilePath, IMFAsyncCallback pCallback, [MarshalAs(UnmanagedType.IUnknown)] object pState, /* _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppCancelCookie);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFBeginRegisterWorkQueueWithMMCSS(uint dwWorkQueueId, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string wszClass, uint dwTaskId, /* _In_ */ IMFAsyncCallback pDoneCallback, /* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pDoneState);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFBeginRegisterWorkQueueWithMMCSSEx(uint dwWorkQueueId, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string wszClass, uint dwTaskId, int lPriority, /* _In_ */ IMFAsyncCallback pDoneCallback, /* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pDoneState);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFBeginUnregisterWorkQueueWithMMCSS(uint dwWorkQueueId, /* _In_ */ IMFAsyncCallback pDoneCallback, /* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pDoneState);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCalculateBitmapImageSize(/* _In_reads_bytes_(cbBufSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] tagBITMAPINFOHEADER[] pBMIH, /* _In_ */ uint cbBufSize, /* _Out_ */ out uint pcbImageSize, /* _Out_opt_ */ out bool pbKnown);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCalculateImageSize(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidSubtype, /* _In_ */ uint unWidth, /* _In_ */ uint unHeight, /* _Out_ */ out uint pcbImageSize);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCancelCreateFile([MarshalAs(UnmanagedType.IUnknown)] object pCancelCookie);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCancelWorkItem(ulong Key);
        
        [DllImport("mfplat")]
        public static extern bool MFCompareFullToPartialMediaType(/* _In_ */ IMFMediaType pMFTypeFull, /* _In_ */ IMFMediaType pMFTypePartial);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFConvertColorInfoFromDXVA(/* _Inout_ */ ref _MFVIDEOFORMAT pToFormat, /* _In_ */ uint dwFromDXVA);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFConvertColorInfoToDXVA(/* _Out_ */ out uint pdwToDXVA, /* _In_ */ ref _MFVIDEOFORMAT pFromFormat);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFConvertFromFP16Array(/* _Out_writes_(dwCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] float[] pDest, /* _In_reads_(dwCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ushort[] pSrc, uint dwCount);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFConvertToFP16Array(/* _Out_writes_(dwCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ushort[] pDest, /* _In_reads_(dwCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] float[] pSrc, uint dwCount);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCopyImage(/* _Out_writes_bytes_(_Inexpressible_(abs(lDestStride) * dwLines)) */ [In, Out, MarshalAs(UnmanagedType.LPArray)] byte[] pDest, int lDestStride, /* _In_reads_bytes_(_Inexpressible_(abs(lSrcStride) * dwLines)) */ [MarshalAs(UnmanagedType.LPArray)] byte[] pSrc, int lSrcStride, /* _Out_range_(<=, _Inexpressible_(min(abs(lSrcStride), abs(lDestStride)))) */ uint dwWidthInBytes, uint dwLines);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreate2DMediaBuffer(/* _In_ */ uint dwWidth, /* _In_ */ uint dwHeight, /* _In_ */ uint dwFourCC, /* _In_ */ bool fBottomUp, /* _Out_ */ out IMFMediaBuffer ppBuffer);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateAlignedMemoryBuffer(/* _In_ */ uint cbMaxLength, /* _In_ */ uint cbAligment, /* _Out_ */ out IMFMediaBuffer ppBuffer);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateAMMediaTypeFromMFMediaType(/* _In_ */ IMFMediaType pMFType, /* _In_ */ Guid guidFormatBlockType, /* _Inout_ */ ref AM_MEDIA_TYPE ppAMType);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateAsyncResult([MarshalAs(UnmanagedType.IUnknown)] object punkObject, IMFAsyncCallback pCallback, [MarshalAs(UnmanagedType.IUnknown)] object punkState, /* _Out_ */ out IMFAsyncResult ppAsyncResult);
        
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
        public static extern HRESULT MFCreateLegacyMediaBufferOnMFMediaBuffer(/* _In_opt_ */ IMFSample pSample, /* _In_ */ IMFMediaBuffer pMFMediaBuffer, /* _In_ */ uint cbOffset, /* _Outptr_ */ out IMediaBuffer ppMediaBuffer);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateMediaBufferFromMediaType(/* _In_ */ IMFMediaType pMediaType, /* _In_ */ long llDuration, /* needed for audio _In_ */ uint dwMinLength, /* // 0 means optimized default _In_ */ uint dwMinAlignment, /* // 0 means optimized default _Outptr_ */ out IMFMediaBuffer ppBuffer);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateMediaBufferWrapper(/* _In_ */ IMFMediaBuffer pBuffer, /* _In_ */ uint cbOffset, /* _In_ */ uint dwLength, /* _Out_ */ out IMFMediaBuffer ppBuffer);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateMediaEvent(/* _In_ */ uint met, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidExtendedType, /* _In_ */ HRESULT hrStatus, /* _In_opt_ */ [In, Out] PropVariant pvValue, /* _Out_ */ out IMFMediaEvent ppEvent);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateMediaExtensionActivate(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string szActivatableClassId, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pConfiguration, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvObject);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateMediaType(/* _Outptr_ */ out IMFMediaType ppMFType);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateMediaTypeFromRepresentation(Guid guidRepresentation, /* _In_ */ IntPtr pvRepresentation, /* _Out_ */ out IMFMediaType ppIMediaType);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateMemoryBuffer(/* _In_ */ uint cbMaxLength, /* _Out_ */ out IMFMediaBuffer ppBuffer);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateMFByteStreamWrapper(/* _In_ */ IMFByteStream pStream, /* _Out_ */ out IMFByteStream ppStreamWrapper);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateMFVideoFormatFromMFMediaType(/* _In_ */ IMFMediaType pMFType, /* _Out_ */ out IntPtr ppMFVF, /* // must be deleted with CoTaskMemFree _Out_opt_ */ out uint pcbSize);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateMuxStreamAttributes(/* _In_ */ IMFCollection pAttributesToMux, /* _COM_Outptr_ */ out IMFAttributes ppMuxAttribs);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateMuxStreamMediaType(/* _In_ */ IMFCollection pMediaTypesToMux, /* _COM_Outptr_ */ out IMFMediaType ppMuxMediaType);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateMuxStreamSample(/* _In_ */ IMFCollection pSamplesToMux, /* _COM_Outptr_ */ out IMFSample ppMuxSample);
        
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
        public static extern HRESULT MFCreateVideoMediaTypeFromBitMapInfoHeaderEx(/* _In_reads_bytes_(cbBitMapInfoHeader) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] tagBITMAPINFOHEADER[] pbmihBitMapInfoHeader, /* _In_ */ uint cbBitMapInfoHeader, uint dwPixelAspectRatioX, uint dwPixelAspectRatioY, _MFVideoInterlaceMode InterlaceMode, ulong VideoFlags, uint dwFramesPerSecondNumerator, uint dwFramesPerSecondDenominator, uint dwMaxBitRate, /* _Out_ */ out IMFVideoMediaType ppIVideoMediaType);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateVideoMediaTypeFromSubtype(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pAMSubtype, /* _Out_ */ out IMFVideoMediaType ppIVideoMediaType);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateVideoSampleAllocatorEx(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppSampleAllocator);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateWaveFormatExFromMFMediaType(/* _In_ */ IMFMediaType pMFType, /* _Out_ */ out IntPtr ppWF, /* _Out_opt_ */ out uint pcbSize, /* _In_ */ uint Flags);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateWICBitmapBuffer(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object punkSurface, /* _Outptr_ */ out IMFMediaBuffer ppBuffer);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFEndCreateFile(IMFAsyncResult pResult, /* _Out_ */ out IMFByteStream ppFile);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFEndRegisterWorkQueueWithMMCSS(/* _In_ */ IMFAsyncResult pResult, /* _Out_ */ out uint pdwTaskId);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFEndUnregisterWorkQueueWithMMCSS(/* _In_ */ IMFAsyncResult pResult);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFFrameRateToAverageTimePerFrame(/* _In_ */ uint unNumerator, /* _In_ */ uint unDenominator, /* _Out_ */ out ulong punAverageTimePerFrame);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFGetAttribute2UINT32asUINT64(IMFAttributes pAttributes, [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* _Out_ */ out uint punHigh32, /* _Out_ */ out uint punLow32);
        
        [DllImport("mfplat")]
        public static extern void MFGetAttributeDouble(IMFAttributes pAttributes, [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, double fDefault);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFGetAttributeRatio(IMFAttributes pAttributes, [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* _Out_ */ out uint punNumerator, /* _Out_ */ out uint punDenominator);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFGetAttributesAsBlob(/* _In_ */ IMFAttributes pAttributes, /* _Out_writes_bytes_(cbBufSize) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] pBuf, /* _In_ */ uint cbBufSize);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFGetAttributesAsBlobSize(/* _In_ */ IMFAttributes pAttributes, /* _Out_ */ out uint pcbBufSize);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFGetAttributeSize(IMFAttributes pAttributes, [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* _Out_ */ out uint punWidth, /* _Out_ */ out uint punHeight);
        
        [DllImport("mfplat")]
        public static extern uint MFGetAttributeUINT32(IMFAttributes pAttributes, [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, uint unDefault);
        
        [DllImport("mfplat")]
        public static extern ulong MFGetAttributeUINT64(IMFAttributes pAttributes, [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, ulong unDefault);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFGetContentProtectionSystemCLSID(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidProtectionSystemID, /* _Out_ */ out Guid pclsid);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFGetMFTMerit(/* _Inout_ */ [MarshalAs(UnmanagedType.IUnknown)] object pMFT, /* _In_ */ uint cbVerifier, /* _In_reads_bytes_(cbVerifier) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] verifier, /* _Out_ */ out uint merit);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFGetPlaneSize(uint format, uint dwWidth, uint dwHeight, /* _Out_ */ out uint pdwPlaneSize);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFGetPluginControl(/* _Out_ */ out IMFPluginControl ppPluginControl);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFGetStrideForBitmapInfoHeader(uint format, uint dwWidth, /* _Out_ */ out int pStride);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFGetTimerPeriodicity(/* _Out_ */ out uint Periodicity);
        
        [DllImport("mfplat")]
        public static extern uint MFGetUncompressedVideoFormat(/* _In_ */ ref _MFVIDEOFORMAT pVideoFormat);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFGetWorkQueueMMCSSClass(uint dwWorkQueueId, /* _Out_writes_to_opt_(*pcchClass,*pcchClass) */ [MarshalAs(UnmanagedType.LPWStr)] string pwszClass, /* _Inout_ */ ref uint pcchClass);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFGetWorkQueueMMCSSPriority(uint dwWorkQueueId, /* _Out_ */ out int lPriority);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFGetWorkQueueMMCSSTaskId(uint dwWorkQueueId, /* _Out_ */ out uint pdwTaskId);
        
        [DllImport("mfplat")]
        public static extern void MFHeapAlloc(ulong nSize, uint dwFlags, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string pszFile, int line, _EAllocationType eat);
        
        [DllImport("mfplat")]
        public static extern void MFHeapFree([MarshalAs(UnmanagedType.IUnknown)] object pv);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFInitAMMediaTypeFromMFMediaType(/* _In_ */ IMFMediaType pMFType, /* _In_ */ Guid guidFormatBlockType, /* _Inout_ */ ref AM_MEDIA_TYPE pAMType);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFInitAttributesFromBlob(/* _In_ */ IMFAttributes pAttributes, /* _In_reads_bytes_(cbBufSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] pBuf, /* _In_ */ uint cbBufSize);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFInitMediaTypeFromAMMediaType(/* _In_ */ IMFMediaType pMFType, /* _In_ */ ref AM_MEDIA_TYPE pAMType);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFInitMediaTypeFromMFVideoFormat(/* _In_ */ IMFMediaType pMFType, /* _In_reads_bytes_(cbBufSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] _MFVIDEOFORMAT[] pMFVF, /* _In_ */ uint cbBufSize);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFInitMediaTypeFromMPEG1VideoInfo(/* _In_ */ IMFMediaType pMFType, /* _In_reads_bytes_(cbBufSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] MPEG1VIDEOINFO[] pMP1VI, /* _In_ */ uint cbBufSize, /* optional(GUID) */ IntPtr pSubtype);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFInitMediaTypeFromMPEG2VideoInfo(/* _In_ */ IMFMediaType pMFType, /* _In_reads_bytes_(cbBufSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] MPEG2VIDEOINFO[] pMP2VI, /* _In_ */ uint cbBufSize, /* optional(GUID) */ IntPtr pSubtype);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFInitMediaTypeFromVideoInfoHeader(/* _In_ */ IMFMediaType pMFType, /* _In_reads_bytes_(cbBufSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] VIDEOINFOHEADER[] pVIH, /* _In_ */ uint cbBufSize, /* optional(GUID) */ IntPtr pSubtype);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFInitMediaTypeFromVideoInfoHeader2(/* _In_ */ IMFMediaType pMFType, /* _In_reads_bytes_(cbBufSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] VIDEOINFOHEADER2[] pVIH2, /* _In_ */ uint cbBufSize, /* optional(GUID) */ IntPtr pSubtype);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFInitMediaTypeFromWaveFormatEx(/* _In_ */ IMFMediaType pMFType, /* _In_reads_bytes_(cbBufSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tWAVEFORMATEX[] pWaveFormat, /* _In_ */ uint cbBufSize);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFInitVideoFormat(/* _In_ */ ref _MFVIDEOFORMAT pVideoFormat, /* _In_ */ _MFStandardVideoFormat type);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFInitVideoFormat_RGB(/* _In_ */ ref _MFVIDEOFORMAT pVideoFormat, /* _In_ */ uint dwWidth, /* _In_ */ uint dwHeight, /* _In_ */ uint D3Dfmt);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFInvokeCallback(IMFAsyncResult pAsyncResult);
        
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
        public static extern HRESULT MFPutWaitingWorkItem(IntPtr hEvent, int Priority, /* _In_ */ IMFAsyncResult pResult, /* _Out_opt_ */ out MFWORKITEM_KEY pKey);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFPutWorkItem(uint dwQueue, IMFAsyncCallback pCallback, [MarshalAs(UnmanagedType.IUnknown)] object pState);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFPutWorkItem2(uint dwQueue, int Priority, /* _In_ */ IMFAsyncCallback pCallback, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pState);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFPutWorkItemEx(uint dwQueue, IMFAsyncResult pResult);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFPutWorkItemEx2(uint dwQueue, int Priority, /* _In_ */ IMFAsyncResult pResult);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFRegisterLocalByteStreamHandler(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string szFileExtension, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string szMimeType, /* _In_ */ IMFActivate pActivate);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFRegisterLocalSchemeHandler(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string szScheme, /* _In_ */ IMFActivate pActivate);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFRegisterPlatformWithMMCSS(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string wszClass, /* _Inout_ */ ref uint pdwTaskId, /* _In_ */ int lPriority);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFRemovePeriodicCallback(uint dwKey);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFScheduleWorkItem(IMFAsyncCallback pCallback, [MarshalAs(UnmanagedType.IUnknown)] object pState, long Timeout, /* _Out_opt_ */ out MFWORKITEM_KEY pKey);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFScheduleWorkItemEx(IMFAsyncResult pResult, long Timeout, /* _Out_opt_ */ out MFWORKITEM_KEY pKey);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFSetAttribute2UINT32asUINT64(IMFAttributes pAttributes, [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, uint unHigh32, uint unLow32);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFSetAttributeRatio(IMFAttributes pAttributes, [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, uint unNumerator, uint unDenominator);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFSetAttributeSize(IMFAttributes pAttributes, [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, uint unWidth, uint unHeight);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFShutdown();
        
        [DllImport("mfplat")]
        public static extern HRESULT MFStartup(uint Version, uint dwFlags);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFTEnum(/* _In_ */ Guid guidCategory, /* _In_ */ uint Flags, /* optional(__MIDL___MIDL_itf_mfobjects_0000_0008_0003) */ IntPtr pInputType, /* optional(__MIDL___MIDL_itf_mfobjects_0000_0008_0003) */ IntPtr pOutputType, /* _In_opt_ */ IMFAttributes pAttributes, /* _Outptr_result_buffer_(*pcMFTs) */ out IntPtr ppclsidMFT, /* // must be freed with CoTaskMemFree _Out_ */ out uint pcMFTs);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFTEnum2(/* _In_ */ Guid guidCategory, /* _In_ */ uint Flags, /* optional(__MIDL___MIDL_itf_mfobjects_0000_0008_0003) */ IntPtr pInputType, /* optional(__MIDL___MIDL_itf_mfobjects_0000_0008_0003) */ IntPtr pOutputType, /* _In_opt_ */ IMFAttributes pAttributes, /* _Outptr_result_buffer_( *pnumMFTActivate ) */ out IMFActivate pppMFTActivate, /* _Out_ */ out uint pnumMFTActivate);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFTEnumEx(/* _In_ */ Guid guidCategory, /* _In_ */ uint Flags, /* optional(__MIDL___MIDL_itf_mfobjects_0000_0008_0003) */ IntPtr pInputType, /* optional(__MIDL___MIDL_itf_mfobjects_0000_0008_0003) */ IntPtr pOutputType, /* _Outptr_result_buffer_(*pnumMFTActivate) */ out IMFActivate pppMFTActivate, /* _Out_ */ out uint pnumMFTActivate);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFTGetInfo(/* _In_ */ Guid clsidMFT, /* optional(LPWSTR) */ out IntPtr pszName, /* optional(__MIDL___MIDL_itf_mfobjects_0000_0008_0003) */ out IntPtr ppInputTypes, /* _Out_opt_ */ out uint pcInputTypes, /* optional(__MIDL___MIDL_itf_mfobjects_0000_0008_0003) */ out IntPtr ppOutputTypes, /* _Out_opt_ */ out uint pcOutputTypes, /* _Outptr_opt_result_maybenull_ */ out IMFAttributes ppAttributes);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFTRegister(/* _In_ */ Guid clsidMFT, /* _In_ */ Guid guidCategory, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* _In_ */ uint Flags, /* _In_ */ uint cInputTypes, /* _In_reads_opt_(cInputTypes) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] __MIDL___MIDL_itf_mfobjects_0000_0008_0003[] pInputTypes, /* _In_ */ uint cOutputTypes, /* _In_reads_opt_(cOutputTypes) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] __MIDL___MIDL_itf_mfobjects_0000_0008_0003[] pOutputTypes, /* _In_opt_ */ IMFAttributes pAttributes);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFTRegisterLocal(/* _In_ */ ref IClassFactory pClassFactory, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidCategory, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* _In_ */ uint Flags, /* _In_ */ uint cInputTypes, /* _In_reads_opt_(cInputTypes) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] __MIDL___MIDL_itf_mfobjects_0000_0008_0003[] pInputTypes, /* _In_ */ uint cOutputTypes, /* _In_reads_opt_(cOutputTypes) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] __MIDL___MIDL_itf_mfobjects_0000_0008_0003[] pOutputTypes);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFTRegisterLocalByCLSID(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid clisdMFT, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidCategory, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* _In_ */ uint Flags, /* _In_ */ uint cInputTypes, /* _In_reads_opt_(cInputTypes) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] __MIDL___MIDL_itf_mfobjects_0000_0008_0003[] pInputTypes, /* _In_ */ uint cOutputTypes, /* _In_reads_opt_(cOutputTypes) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] __MIDL___MIDL_itf_mfobjects_0000_0008_0003[] pOutputTypes);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFTUnregister(/* _In_ */ Guid clsidMFT);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFTUnregisterLocal(/* optional(IClassFactory) */ IntPtr pClassFactory);
        
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
        public static extern HRESULT MFUnwrapMediaType(/* _In_ */ IMFMediaType pWrap, /* _Out_ */ out IMFMediaType ppOrig);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFValidateMediaTypeSize(/* _In_ */ Guid FormatType, /* _In_reads_bytes_opt_(cbSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] pBlock, /* _In_ */ uint cbSize);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFWrapMediaType(/* _In_ */ IMFMediaType pOrig, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid MajorType, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid SubType, /* _Out_ */ out IMFMediaType ppWrap);
        
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
        
        [DllImport("mfgphone")]
        public static extern HRESULT MfgPhoneDial(/* _In_ */ uint SimSlot, /* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string DialNumber);
        
        [DllImport("mfgphone")]
        public static extern HRESULT MfgPhoneEndCall(/* _In_ */ uint SimSlot);
        
        [DllImport("mfgphone")]
        public static extern HRESULT MfgPhoneGetSimLineCount(/* _Out_ */ out uint SimLineCount);
        
        [DllImport("mfgphone")]
        public static extern HRESULT MfgPhoneGetSimLineDetail(/* _In_ */ uint SimSlot, /* _Out_writes_bytes_to_opt_(SimLineDetailSize, *RequiredSize) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] _MFGPHONE_SIMLINEDETAIL[] SimLineDetail, /* _In_ */ uint SimLineDetailSize, /* _Out_opt_ _Out_range_(>=, sizeof(MFGPHONE_SIMLINEDETAIL)) */ [Out, MarshalAs(UnmanagedType.LPArray)] uint[] RequiredSize);
        
        [DllImport("mfgphone")]
        public static extern HRESULT MfgPhoneGetSpeaker(/* _Out_ */ out bool pbSpeakerOn);
        
        [DllImport("mfgphone")]
        public static extern HRESULT MfgPhoneInitialize();
        
        [DllImport("mfgphone")]
        public static extern HRESULT MfgPhoneSetSimLineEventNotifyCallback(/* optional(MFGPHONE_SIMLINEEVENT_NOTIFY_CALLBACK) */ IntPtr Callback, /* optional(PVOID) */ IntPtr Context);
        
        [DllImport("mfgphone")]
        public static extern HRESULT MfgPhoneSetSpeaker(/* _In_ */ bool bSpeakerOn);
        
        [DllImport("mfgphone")]
        public static extern HRESULT MfgPhoneUninitialize();
        
        [DllImport("mfplat")]
        public static extern HRESULT CreateNamedPropertyStore(/* _Outptr_ */ out IntPtr ppStore);
        
        [DllImport("mfplat")]
        public static extern HRESULT CreatePropertyStore(/* out _Outptr_ */ out IntPtr ppStore);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreate3GPMediaSink(/* _In_ */ IMFByteStream pIByteStream, /* _In_opt_ */ IMFMediaType pVideoMediaType, /* _In_opt_ */ IMFMediaType pAudioMediaType, /* _Outptr_ */ out IMFMediaSink ppIMediaSink);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateAC3MediaSink(/* _In_ */ IMFByteStream pTargetByteStream, /* _In_ */ IMFMediaType pAudioMediaType, /* _Outptr_ */ out IMFMediaSink ppMediaSink);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateADTSMediaSink(/* _In_ */ IMFByteStream pTargetByteStream, /* _In_ */ IMFMediaType pAudioMediaType, /* _Outptr_ */ out IMFMediaSink ppMediaSink);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateAggregateSource(/* _In_ */ IMFCollection pSourceCollection, /* _Outptr_ */ out IMFMediaSource ppAggSource);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateAudioRenderer(IMFAttributes pAudioAttributes, /* _Outptr_ */ out IMFMediaSink ppSink);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateAudioRendererActivate(/* _Outptr_ */ out IMFActivate ppActivate);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateAVIMediaSink(/* _In_ */ IMFByteStream pIByteStream, /* _In_ */ IMFMediaType pVideoMediaType, /* _In_opt_ */ IMFMediaType pAudioMediaType, /* _Outptr_ */ out IMFMediaSink ppIMediaSink);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateContentDecryptorContext(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidMediaProtectionSystemId, /* _In_opt_ */ IMFDXGIDeviceManager pD3DManager, /* _In_ */ IMFContentProtectionDevice pContentProtectionDevice, /* _Outptr_ */ out IMFContentDecryptorContext ppContentDecryptorContext);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateContentProtectionDevice(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid ProtectionSystemId, /* _Outptr_ */ out IMFContentProtectionDevice ContentProtectionDevice);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateCredentialCache(/* _Outptr_ */ out IMFNetCredentialCache ppCache);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateDeviceSource(/* _In_ */ IMFAttributes pAttributes, /* _Outptr_ */ out IMFMediaSource ppSource);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateDeviceSourceActivate(/* _In_ */ IMFAttributes pAttributes, /* _Outptr_ */ out IMFActivate ppActivate);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateExtendedCameraIntrinsicModel(MFCameraIntrinsic_DistortionModelType distortionModelType, /* _COM_Outptr_ */ out IMFExtendedCameraIntrinsicModel ppExtendedCameraIntrinsicModel);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateExtendedCameraIntrinsics(/* _COM_Outptr_ */ out IMFExtendedCameraIntrinsics ppExtendedCameraIntrinsics);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateFMPEG4MediaSink(/* _In_ */ IMFByteStream pIByteStream, /* _In_opt_ */ IMFMediaType pVideoMediaType, /* _In_opt_ */ IMFMediaType pAudioMediaType, /* _Outptr_ */ out IMFMediaSink ppIMediaSink);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateMediaSession(IMFAttributes pConfiguration, /* _Outptr_ */ out IMFMediaSession ppMediaSession);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateMediaTypeFromProperties(/* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object punkStream, /* _Outptr_ */ out IMFMediaType ppMediaType);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateMFByteStreamOnStream(IStream pStream, /* _Outptr_ */ out IMFByteStream ppByteStream);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateMFByteStreamOnStreamEx(/* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object punkStream, /* _Outptr_ */ out IMFByteStream ppByteStream);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateMP3MediaSink(/* _In_ */ IMFByteStream pTargetByteStream, /* _Outptr_ */ out IMFMediaSink ppMediaSink);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateMPEG4MediaSink(/* _In_ */ IMFByteStream pIByteStream, /* _In_opt_ */ IMFMediaType pVideoMediaType, /* _In_opt_ */ IMFMediaType pAudioMediaType, /* _Outptr_ */ out IMFMediaSink ppIMediaSink);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateMuxSink(/* _In_ */ Guid guidOutputSubType, /* _In_opt_ */ IMFAttributes pOutputAttributes, /* _In_opt_ */ IMFByteStream pOutputByteStream, /* _Outptr_ */ out IMFMediaSink ppMuxSink);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateNetSchemePlugin([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] object ppvHandler);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreatePMPMediaSession(uint dwCreationFlags, IMFAttributes pConfiguration, /* _Outptr_ */ out IMFMediaSession ppMediaSession, /* _Outptr_opt_ */ out IMFActivate ppEnablerActivate);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreatePMPServer(uint dwCreationFlags, /* _Outptr_ */ out IMFPMPServer ppPMPServer);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreatePresentationClock(/* _Outptr_ */ out IMFPresentationClock ppPresentationClock);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreatePresentationDescriptor(uint cStreamDescriptors, /* _In_reads_opt_( cStreamDescriptors ) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] IMFStreamDescriptor[] apStreamDescriptors, /* _Outptr_ */ out IMFPresentationDescriptor ppPresentationDescriptor);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreatePropertiesFromMediaType(/* _In_ */ IMFMediaType pMediaType, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateProtectedEnvironmentAccess(/* _Outptr_ */ out IMFProtectedEnvironmentAccess ppAccess);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateProxyLocator([MarshalAs(UnmanagedType.LPWStr)] string pszProtocol, ref IPropertyStore pProxyConfig, /* _Outptr_ */ out IMFNetProxyLocator ppProxyLocator);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateRemoteDesktopPlugin(/* _Outptr_ */ out IMFRemoteDesktopPlugin ppPlugin);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateSampleCopierMFT(/* _Outptr_ */ out IMFTransform ppCopierMFT);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateSampleGrabberSinkActivate(IMFMediaType pIMFMediaType, IMFSampleGrabberSinkCallback pIMFSampleGrabberSinkCallback, /* _Outptr_ */ out IMFActivate ppIActivate);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateSensorActivityMonitor(/* _In_ */ IMFSensorActivitiesReportCallback pCallback, /* _COM_Outptr_ */ out IMFSensorActivityMonitor ppActivityMonitor);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateSensorGroup(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string SensorGroupSymbolicLink, /* _COM_Outptr_ */ out IMFSensorGroup ppSensorGroup);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateSensorProfile(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid ProfileType, /* _In_ */ uint ProfileIndex, /* _In_opt_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string Constraints, /* _COM_Outptr_ */ out IMFSensorProfile ppProfile);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateSensorProfileCollection(/* _COM_Outptr_ */ out IMFSensorProfileCollection ppSensorProfile);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateSensorStream(/* _In_ */ uint StreamId, /* _In_opt_ */ IMFAttributes pAttributes, /* _In_ */ IMFCollection pMediaTypeCollection, /* _COM_Outptr_ */ out IMFSensorStream ppStream);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateSequencerSegmentOffset(uint dwId, long hnsOffset, /* _Out_ */ [In, Out] PropVariant pvarSegmentOffset);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateSequencerSource([MarshalAs(UnmanagedType.IUnknown)] object pReserved, /* _Outptr_ */ out IMFSequencerSource ppSequencerSource);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateSimpleTypeHandler(/* _Outptr_ */ out IMFMediaTypeHandler ppHandler);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateSourceResolver(/* out _Outptr_ */ out IMFSourceResolver ppISourceResolver);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateStandardQualityManager(/* _Outptr_ */ out IMFQualityManager ppQualityManager);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateStreamDescriptor(uint dwStreamIdentifier, uint cMediaTypes, /* _In_reads_(cMediaTypes) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IMFMediaType[] apMediaTypes, /* _Outptr_ */ out IMFStreamDescriptor ppDescriptor);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateStreamOnMFByteStream(/* _In_ */ IMFByteStream pByteStream, /* _Outptr_ */ out IStream ppStream);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateStreamOnMFByteStreamEx(/* _In_ */ IMFByteStream pByteStream, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateSystemTimeSource(/* _Outptr_ */ out IMFPresentationTimeSource ppSystemTimeSource);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateTopoLoader(/* _Outptr_ */ out IMFTopoLoader ppObj);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateTopology(/* _Outptr_ */ out IMFTopology ppTopo);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateTopologyNode(MF_TOPOLOGY_TYPE NodeType, /* _Outptr_ */ out IMFTopologyNode ppNode);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateTrackedSample(/* _Outptr_ */ out IMFTrackedSample ppMFSample);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateTranscodeProfile(/* _Outptr_ */ out IMFTranscodeProfile ppTranscodeProfile);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateTranscodeSinkActivate(/* _Outptr_ */ out IMFActivate ppActivate);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateTranscodeTopology(/* _In_ */ IMFMediaSource pSrc, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pwszOutputFilePath, /* _In_ */ IMFTranscodeProfile pProfile, /* _Outptr_ */ out IMFTopology ppTranscodeTopo);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateTranscodeTopologyFromByteStream(/* _In_ */ IMFMediaSource pSrc, /* _In_ */ IMFByteStream pOutputStream, /* _In_ */ IMFTranscodeProfile pProfile, /* _Out_ */ out IMFTopology ppTranscodeTopo);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateVideoRendererActivate(/* _In_ */ IntPtr hwndVideo, /* _Outptr_ */ out IMFActivate ppActivate);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFCreateWAVEMediaSink(/* _In_ */ IMFByteStream pTargetByteStream, /* _In_ */ IMFMediaType pAudioMediaType, /* _Outptr_ */ out IMFMediaSink ppMediaSink);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFDeserializePresentationDescriptor(/* _In_ */ uint cbData, /* _In_reads_( cbData ) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] byte[] pbData, /* _Outptr_ */ out IMFPresentationDescriptor ppPD);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFEnumDeviceSources(/* _In_ */ IMFAttributes pAttributes, /* _Outptr_result_buffer_(*pcSourceActivate) */ out IMFActivate pppSourceActivate, /* _Out_ */ out uint pcSourceActivate);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFGetLocalId(/* _In_reads_bytes_(size) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] verifier, /* _In_ */ uint size, /* _Outptr_ */ out IntPtr id);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFGetService([MarshalAs(UnmanagedType.IUnknown)] object punkObject, [MarshalAs(UnmanagedType.LPStruct)] Guid guidService, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvObject);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFGetSupportedMimeTypes(/* _Out_ */ [In, Out] PropVariant pPropVarMimeTypeArray);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFGetSupportedSchemes(/* _Out_ */ [In, Out] PropVariant pPropVarSchemeArray);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFGetSystemId(/* _Outptr_ */ out IMFSystemId ppId);
        
        [DllImport("mfplat")]
        public static extern long MFGetSystemTime();
        
        [DllImport("mfplat")]
        public static extern HRESULT MFGetTopoNodeCurrentType(IMFTopologyNode pNode, uint dwStreamIndex, bool fOutput, /* _Outptr_ */ out IMFMediaType ppType);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFIsContentProtectionDeviceSupported(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid ProtectionSystemId, /* _Out_ */ out bool isSupported);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFLoadSignedLibrary(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* _Outptr_ */ out IMFSignedLibrary ppLib);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFRequireProtectedEnvironment(/* _In_ */ IMFPresentationDescriptor pPresentationDescriptor);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFSerializePresentationDescriptor(/* _In_ */ IMFPresentationDescriptor pPD, /* _Out_ */ out uint pcbData, /* _Outptr_result_bytebuffer_to_(*pcbData, *pcbData) */ out IntPtr ppbData);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFShutdownObject([MarshalAs(UnmanagedType.IUnknown)] object pUnk);
        
        [DllImport("mfplat")]
        public static extern HRESULT MFTranscodeGetAudioOutputAvailableTypes(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidSubType, /* _In_ */ uint dwMFTFlags, /* _In_opt_ */ IMFAttributes pCodecConfig, /* _Outptr_ */ out IMFCollection ppAvailableTypes);
        
        [DllImport("mfobjects")]
        public static extern HRESULT MFDeserializeAttributesFromStream(IMFAttributes pAttr, uint dwOptions, IStream pStm);
        
        [DllImport("mfobjects")]
        public static extern HRESULT MFSerializeAttributesToStream(IMFAttributes pAttr, uint dwOptions, IStream pStm);
        
        [DllImport("mfplay")]
        public static extern HRESULT MFPCreateMediaPlayer(/* _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string pwszURL, /* _In_ */ bool fStartPlayback, /* _In_opt_ */ uint creationOptions, /* _In_opt_ */ IMFPMediaPlayerCallback pCallback, /* optional(HWND__) */ IntPtr hWnd, /* _Out_opt_ */ out IMFPMediaPlayer ppMediaPlayer);
        
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
        public static extern HRESULT ActivateAudioInterfaceAsync(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string deviceInterfacePath, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _In_opt_ */ [In, Out] PropVariant activationParams, /* _In_ */ IActivateAudioInterfaceCompletionHandler completionHandler, /* _COM_Outptr_ */ out IActivateAudioInterfaceAsyncOperation activationOperation);
        
        [DllImport("winmm")]
        public static extern uint auxGetDevCapsA(/* _In_ */ IntPtr uDeviceID, /* _Out_writes_bytes_(cbac) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagAUXCAPSA[] pac, /* _In_ */ uint cbac);
        
        [DllImport("winmm")]
        public static extern uint auxGetDevCapsW(/* _In_ */ IntPtr uDeviceID, /* _Out_writes_bytes_(cbac) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagAUXCAPSW[] pac, /* _In_ */ uint cbac);
        
        [DllImport("winmm")]
        public static extern uint auxGetNumDevs();
        
        [DllImport("winmm")]
        public static extern uint auxGetVolume(/* _In_ */ uint uDeviceID, /* _Out_ */ out uint pdwVolume);
        
        [DllImport("winmm")]
        public static extern uint auxOutMessage(/* _In_ */ uint uDeviceID, /* _In_ */ uint uMsg, /* optional(DWORD_PTR) */ IntPtr dw1, /* optional(DWORD_PTR) */ IntPtr dw2);
        
        [DllImport("winmm")]
        public static extern uint auxSetVolume(/* _In_ */ uint uDeviceID, /* _In_ */ uint dwVolume);
        
        [DllImport("winmm")]
        public static extern uint midiConnect(/* _In_ */ IntPtr hmi, /* _In_ */ IntPtr hmo, /* optional(LPVOID) */ IntPtr pReserved);
        
        [DllImport("winmm")]
        public static extern uint midiDisconnect(/* _In_ */ IntPtr hmi, /* _In_ */ IntPtr hmo, /* optional(LPVOID) */ IntPtr pReserved);
        
        [DllImport("winmm")]
        public static extern uint midiInAddBuffer(/* _In_ */ IntPtr hmi, /* _Out_writes_bytes_(cbmh) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] midihdr_tag[] pmh, /* _In_ */ uint cbmh);
        
        [DllImport("winmm")]
        public static extern uint midiInClose(/* _In_ */ IntPtr hmi);
        
        [DllImport("winmm")]
        public static extern uint midiInGetDevCapsA(/* _In_ */ IntPtr uDeviceID, /* _Out_writes_bytes_(cbmic) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagMIDIINCAPSA[] pmic, /* _In_ */ uint cbmic);
        
        [DllImport("winmm")]
        public static extern uint midiInGetDevCapsW(/* _In_ */ IntPtr uDeviceID, /* _Out_writes_bytes_(cbmic) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagMIDIINCAPSW[] pmic, /* _In_ */ uint cbmic);
        
        [DllImport("winmm")]
        public static extern uint midiInGetErrorTextA(/* _In_ */ uint mmrError, /* _Out_writes_(cchText) */ [MarshalAs(UnmanagedType.LPStr)] string pszText, /* _In_ */ uint cchText);
        
        [DllImport("winmm")]
        public static extern uint midiInGetErrorTextW(/* _In_ */ uint mmrError, /* _Out_writes_(cchText) */ [MarshalAs(UnmanagedType.LPWStr)] string pszText, /* _In_ */ uint cchText);
        
        [DllImport("winmm")]
        public static extern uint midiInGetID(/* _In_ */ IntPtr hmi, /* _Out_ */ out uint puDeviceID);
        
        [DllImport("winmm")]
        public static extern uint midiInGetNumDevs();
        
        [DllImport("winmm")]
        public static extern uint midiInMessage(/* optional(HMIDIIN__) */ IntPtr hmi, /* _In_ */ uint uMsg, /* optional(DWORD_PTR) */ IntPtr dw1, /* optional(DWORD_PTR) */ IntPtr dw2);
        
        [DllImport("winmm")]
        public static extern uint midiInOpen(/* _Out_ */ out IntPtr phmi, /* _In_ */ uint uDeviceID, /* optional(DWORD_PTR) */ IntPtr dwCallback, /* optional(DWORD_PTR) */ IntPtr dwInstance, /* _In_ */ uint fdwOpen);
        
        [DllImport("winmm")]
        public static extern uint midiInPrepareHeader(/* _In_ */ IntPtr hmi, /* _Inout_updates_bytes_(cbmh) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] midihdr_tag[] pmh, /* _In_ */ uint cbmh);
        
        [DllImport("winmm")]
        public static extern uint midiInReset(/* _In_ */ IntPtr hmi);
        
        [DllImport("winmm")]
        public static extern uint midiInStart(/* _In_ */ IntPtr hmi);
        
        [DllImport("winmm")]
        public static extern uint midiInStop(/* _In_ */ IntPtr hmi);
        
        [DllImport("winmm")]
        public static extern uint midiInUnprepareHeader(/* _In_ */ IntPtr hmi, /* _Inout_updates_bytes_(cbmh) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] midihdr_tag[] pmh, /* _In_ */ uint cbmh);
        
        [DllImport("winmm")]
        public static extern uint midiOutCacheDrumPatches(/* _In_ */ IntPtr hmo, /* _In_ */ uint uPatch, /* _In_reads_(MIDIPATCHSIZE) */ [MarshalAs(UnmanagedType.LPArray)] ushort[] pwkya, /* _In_ */ uint fuCache);
        
        [DllImport("winmm")]
        public static extern uint midiOutCachePatches(/* _In_ */ IntPtr hmo, /* _In_ */ uint uBank, /* _In_reads_(MIDIPATCHSIZE) */ [MarshalAs(UnmanagedType.LPArray)] ushort[] pwpa, /* _In_ */ uint fuCache);
        
        [DllImport("winmm")]
        public static extern uint midiOutClose(/* _In_ */ IntPtr hmo);
        
        [DllImport("winmm")]
        public static extern uint midiOutGetDevCapsA(/* _In_ */ IntPtr uDeviceID, /* _Out_writes_bytes_(cbmoc) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagMIDIOUTCAPSA[] pmoc, /* _In_ */ uint cbmoc);
        
        [DllImport("winmm")]
        public static extern uint midiOutGetDevCapsW(/* _In_ */ IntPtr uDeviceID, /* _Out_writes_bytes_(cbmoc) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagMIDIOUTCAPSW[] pmoc, /* _In_ */ uint cbmoc);
        
        [DllImport("winmm")]
        public static extern uint midiOutGetErrorTextA(/* _In_ */ uint mmrError, /* _Out_writes_(cchText) */ [MarshalAs(UnmanagedType.LPStr)] string pszText, /* _In_ */ uint cchText);
        
        [DllImport("winmm")]
        public static extern uint midiOutGetErrorTextW(/* _In_ */ uint mmrError, /* _Out_writes_(cchText) */ [MarshalAs(UnmanagedType.LPWStr)] string pszText, /* _In_ */ uint cchText);
        
        [DllImport("winmm")]
        public static extern uint midiOutGetID(/* _In_ */ IntPtr hmo, /* _Out_ */ out uint puDeviceID);
        
        [DllImport("winmm")]
        public static extern uint midiOutGetNumDevs();
        
        [DllImport("winmm")]
        public static extern uint midiOutGetVolume(/* optional(HMIDIOUT__) */ IntPtr hmo, /* _Out_ */ out uint pdwVolume);
        
        [DllImport("winmm")]
        public static extern uint midiOutLongMsg(/* _In_ */ IntPtr hmo, /* _In_reads_bytes_(cbmh) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] midihdr_tag[] pmh, /* _In_ */ uint cbmh);
        
        [DllImport("winmm")]
        public static extern uint midiOutMessage(/* optional(HMIDIOUT__) */ IntPtr hmo, /* _In_ */ uint uMsg, /* optional(DWORD_PTR) */ IntPtr dw1, /* optional(DWORD_PTR) */ IntPtr dw2);
        
        [DllImport("winmm")]
        public static extern uint midiOutOpen(/* _Out_ */ out IntPtr phmo, /* _In_ */ uint uDeviceID, /* optional(DWORD_PTR) */ IntPtr dwCallback, /* optional(DWORD_PTR) */ IntPtr dwInstance, /* _In_ */ uint fdwOpen);
        
        [DllImport("winmm")]
        public static extern uint midiOutPrepareHeader(/* _In_ */ IntPtr hmo, /* _Inout_updates_bytes_(cbmh) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] midihdr_tag[] pmh, /* _In_ */ uint cbmh);
        
        [DllImport("winmm")]
        public static extern uint midiOutReset(/* _In_ */ IntPtr hmo);
        
        [DllImport("winmm")]
        public static extern uint midiOutSetVolume(/* optional(HMIDIOUT__) */ IntPtr hmo, /* _In_ */ uint dwVolume);
        
        [DllImport("winmm")]
        public static extern uint midiOutShortMsg(/* _In_ */ IntPtr hmo, /* _In_ */ uint dwMsg);
        
        [DllImport("winmm")]
        public static extern uint midiOutUnprepareHeader(/* _In_ */ IntPtr hmo, /* _Inout_updates_bytes_(cbmh) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] midihdr_tag[] pmh, /* _In_ */ uint cbmh);
        
        [DllImport("winmm")]
        public static extern uint midiStreamClose(/* _In_ */ IntPtr hms);
        
        [DllImport("winmm")]
        public static extern uint midiStreamOpen(/* _Out_ */ out IntPtr phms, /* _Inout_updates_(cMidi) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] uint[] puDeviceID, /* _In_ */ uint cMidi, /* optional(DWORD_PTR) */ IntPtr dwCallback, /* optional(DWORD_PTR) */ IntPtr dwInstance, /* _In_ */ uint fdwOpen);
        
        [DllImport("winmm")]
        public static extern uint midiStreamOut(/* _In_ */ IntPtr hms, /* _Out_writes_bytes_(cbmh) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] midihdr_tag[] pmh, /* _In_ */ uint cbmh);
        
        [DllImport("winmm")]
        public static extern uint midiStreamPause(/* _In_ */ IntPtr hms);
        
        [DllImport("winmm")]
        public static extern uint midiStreamPosition(/* _In_ */ IntPtr hms, /* _Out_writes_bytes_(cbmmt) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] mmtime_tag[] lpmmt, /* _In_ */ uint cbmmt);
        
        [DllImport("winmm")]
        public static extern uint midiStreamProperty(/* _In_ */ IntPtr hms, /* _Inout_updates_bytes_(sizeof(DWORD) + sizeof(DWORD)) */ [MarshalAs(UnmanagedType.LPArray)] byte[] lppropdata, /* _In_ */ uint dwProperty);
        
        [DllImport("winmm")]
        public static extern uint midiStreamRestart(/* _In_ */ IntPtr hms);
        
        [DllImport("winmm")]
        public static extern uint midiStreamStop(/* _In_ */ IntPtr hms);
        
        [DllImport("winmm")]
        public static extern uint mixerClose(/* _In_ */ IntPtr hmx);
        
        [DllImport("winmm")]
        public static extern uint mixerGetControlDetailsA(/* optional(HMIXEROBJ__) */ IntPtr hmxobj, /* _Inout_ */ ref tMIXERCONTROLDETAILS pmxcd, /* _In_ */ uint fdwDetails);
        
        [DllImport("winmm")]
        public static extern uint mixerGetControlDetailsW(/* optional(HMIXEROBJ__) */ IntPtr hmxobj, /* _Inout_ */ ref tMIXERCONTROLDETAILS pmxcd, /* _In_ */ uint fdwDetails);
        
        [DllImport("winmm")]
        public static extern uint mixerGetDevCapsA(/* _In_ */ IntPtr uMxId, /* _Out_writes_bytes_(cbmxcaps) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagMIXERCAPSA[] pmxcaps, /* _In_ */ uint cbmxcaps);
        
        [DllImport("winmm")]
        public static extern uint mixerGetDevCapsW(/* _In_ */ IntPtr uMxId, /* _Out_writes_bytes_(cbmxcaps) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagMIXERCAPSW[] pmxcaps, /* _In_ */ uint cbmxcaps);
        
        [DllImport("winmm")]
        public static extern uint mixerGetID(/* optional(HMIXEROBJ__) */ IntPtr hmxobj, /* _Out_ */ out uint puMxId, /* _In_ */ uint fdwId);
        
        [DllImport("winmm")]
        public static extern uint mixerGetLineControlsA(/* optional(HMIXEROBJ__) */ IntPtr hmxobj, /* _Inout_ */ ref tagMIXERLINECONTROLSA pmxlc, /* _In_ */ uint fdwControls);
        
        [DllImport("winmm")]
        public static extern uint mixerGetLineControlsW(/* optional(HMIXEROBJ__) */ IntPtr hmxobj, /* _Inout_ */ ref tagMIXERLINECONTROLSW pmxlc, /* _In_ */ uint fdwControls);
        
        [DllImport("winmm")]
        public static extern uint mixerGetLineInfoA(/* optional(HMIXEROBJ__) */ IntPtr hmxobj, /* _Inout_ */ ref tagMIXERLINEA pmxl, /* _In_ */ uint fdwInfo);
        
        [DllImport("winmm")]
        public static extern uint mixerGetLineInfoW(/* optional(HMIXEROBJ__) */ IntPtr hmxobj, /* _Inout_ */ ref tagMIXERLINEW pmxl, /* _In_ */ uint fdwInfo);
        
        [DllImport("winmm")]
        public static extern uint mixerGetNumDevs();
        
        [DllImport("winmm")]
        public static extern uint mixerMessage(/* optional(HMIXER__) */ IntPtr hmx, /* _In_ */ uint uMsg, /* optional(DWORD_PTR) */ IntPtr dwParam1, /* optional(DWORD_PTR) */ IntPtr dwParam2);
        
        [DllImport("winmm")]
        public static extern uint mixerOpen(/* optional(LPHMIXER) */ out IntPtr phmx, /* _In_ */ uint uMxId, /* optional(DWORD_PTR) */ IntPtr dwCallback, /* optional(DWORD_PTR) */ IntPtr dwInstance, /* _In_ */ uint fdwOpen);
        
        [DllImport("winmm")]
        public static extern uint mixerSetControlDetails(/* optional(HMIXEROBJ__) */ IntPtr hmxobj, /* _In_ */ ref tMIXERCONTROLDETAILS pmxcd, /* _In_ */ uint fdwDetails);
        
        [DllImport("winmm")]
        public static extern uint waveInAddBuffer(/* _In_ */ IntPtr hwi, /* _Inout_updates_bytes_(cbwh) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] wavehdr_tag[] pwh, /* _In_ */ uint cbwh);
        
        [DllImport("winmm")]
        public static extern uint waveInClose(/* _In_ */ IntPtr hwi);
        
        [DllImport("winmm")]
        public static extern uint waveInGetDevCapsA(/* _In_ */ IntPtr uDeviceID, /* _Out_writes_bytes_(cbwic) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagWAVEINCAPSA[] pwic, /* _In_ */ uint cbwic);
        
        [DllImport("winmm")]
        public static extern uint waveInGetDevCapsW(/* _In_ */ IntPtr uDeviceID, /* _Out_writes_bytes_(cbwic) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagWAVEINCAPSW[] pwic, /* _In_ */ uint cbwic);
        
        [DllImport("winmm")]
        public static extern uint waveInGetErrorTextA(/* _In_ */ uint mmrError, /* _Out_writes_(cchText) */ [MarshalAs(UnmanagedType.LPStr)] string pszText, /* _In_ */ uint cchText);
        
        [DllImport("winmm")]
        public static extern uint waveInGetErrorTextW(/* _In_ */ uint mmrError, /* _Out_writes_(cchText) */ [MarshalAs(UnmanagedType.LPWStr)] string pszText, /* _In_ */ uint cchText);
        
        [DllImport("winmm")]
        public static extern uint waveInGetID(/* _In_ */ IntPtr hwi, /* _In_ */ ref uint puDeviceID);
        
        [DllImport("winmm")]
        public static extern uint waveInGetNumDevs();
        
        [DllImport("winmm")]
        public static extern uint waveInGetPosition(/* _In_ */ IntPtr hwi, /* _Inout_updates_bytes_(cbmmt) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] mmtime_tag[] pmmt, /* _In_ */ uint cbmmt);
        
        [DllImport("winmm")]
        public static extern uint waveInMessage(/* optional(HWAVEIN__) */ IntPtr hwi, /* _In_ */ uint uMsg, /* optional(DWORD_PTR) */ IntPtr dw1, /* optional(DWORD_PTR) */ IntPtr dw2);
        
        [DllImport("winmm")]
        public static extern uint waveInOpen(/* optional(LPHWAVEIN) */ out IntPtr phwi, /* _In_ */ uint uDeviceID, /* _In_ */ ref LPCWAVEFORMATEX pwfx, /* optional(DWORD_PTR) */ IntPtr dwCallback, /* optional(DWORD_PTR) */ IntPtr dwInstance, /* _In_ */ uint fdwOpen);
        
        [DllImport("winmm")]
        public static extern uint waveInPrepareHeader(/* _In_ */ IntPtr hwi, /* _Inout_updates_bytes_(cbwh) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] wavehdr_tag[] pwh, /* _In_ */ uint cbwh);
        
        [DllImport("winmm")]
        public static extern uint waveInReset(/* _In_ */ IntPtr hwi);
        
        [DllImport("winmm")]
        public static extern uint waveInStart(/* _In_ */ IntPtr hwi);
        
        [DllImport("winmm")]
        public static extern uint waveInStop(/* _In_ */ IntPtr hwi);
        
        [DllImport("winmm")]
        public static extern uint waveInUnprepareHeader(/* _In_ */ IntPtr hwi, /* _Inout_updates_bytes_(cbwh) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] wavehdr_tag[] pwh, /* _In_ */ uint cbwh);
        
        [DllImport("winmm")]
        public static extern uint waveOutBreakLoop(/* _In_ */ IntPtr hwo);
        
        [DllImport("winmm")]
        public static extern uint waveOutClose(/* _In_ */ IntPtr hwo);
        
        [DllImport("winmm")]
        public static extern uint waveOutGetDevCapsA(/* _In_ */ IntPtr uDeviceID, /* _Out_ */ out tagWAVEOUTCAPSA pwoc, /* _In_ */ uint cbwoc);
        
        [DllImport("winmm")]
        public static extern uint waveOutGetDevCapsW(/* _In_ */ IntPtr uDeviceID, /* _Out_ */ out tagWAVEOUTCAPSW pwoc, /* _In_ */ uint cbwoc);
        
        [DllImport("winmm")]
        public static extern uint waveOutGetErrorTextA(/* _In_ */ uint mmrError, /* _Out_writes_(cchText) */ [MarshalAs(UnmanagedType.LPStr)] string pszText, /* _In_ */ uint cchText);
        
        [DllImport("winmm")]
        public static extern uint waveOutGetErrorTextW(/* _In_ */ uint mmrError, /* _Out_writes_(cchText) */ [MarshalAs(UnmanagedType.LPWStr)] string pszText, /* _In_ */ uint cchText);
        
        [DllImport("winmm")]
        public static extern uint waveOutGetID(/* _In_ */ IntPtr hwo, /* _Out_ */ out uint puDeviceID);
        
        [DllImport("winmm")]
        public static extern uint waveOutGetNumDevs();
        
        [DllImport("winmm")]
        public static extern uint waveOutGetPitch(/* _In_ */ IntPtr hwo, /* _Out_ */ out uint pdwPitch);
        
        [DllImport("winmm")]
        public static extern uint waveOutGetPlaybackRate(/* _In_ */ IntPtr hwo, /* _Out_ */ out uint pdwRate);
        
        [DllImport("winmm")]
        public static extern uint waveOutGetPosition(/* _In_ */ IntPtr hwo, /* _Inout_updates_bytes_(cbmmt) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] mmtime_tag[] pmmt, /* _In_ */ uint cbmmt);
        
        [DllImport("winmm")]
        public static extern uint waveOutGetVolume(/* optional(HWAVEOUT__) */ IntPtr hwo, /* _Out_ */ out uint pdwVolume);
        
        [DllImport("winmm")]
        public static extern uint waveOutMessage(/* optional(HWAVEOUT__) */ IntPtr hwo, /* _In_ */ uint uMsg, /* _In_ */ IntPtr dw1, /* _In_ */ IntPtr dw2);
        
        [DllImport("winmm")]
        public static extern uint waveOutOpen(/* optional(LPHWAVEOUT) */ out IntPtr phwo, /* _In_ */ uint uDeviceID, /* _In_ */ ref LPCWAVEFORMATEX pwfx, /* optional(DWORD_PTR) */ IntPtr dwCallback, /* optional(DWORD_PTR) */ IntPtr dwInstance, /* _In_ */ uint fdwOpen);
        
        [DllImport("winmm")]
        public static extern uint waveOutPause(/* _In_ */ IntPtr hwo);
        
        [DllImport("winmm")]
        public static extern uint waveOutPrepareHeader(/* _In_ */ IntPtr hwo, /* _Inout_updates_bytes_(cbwh) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] wavehdr_tag[] pwh, /* _In_ */ uint cbwh);
        
        [DllImport("winmm")]
        public static extern uint waveOutReset(/* _In_ */ IntPtr hwo);
        
        [DllImport("winmm")]
        public static extern uint waveOutRestart(/* _In_ */ IntPtr hwo);
        
        [DllImport("winmm")]
        public static extern uint waveOutSetPitch(/* _In_ */ IntPtr hwo, /* _In_ */ uint dwPitch);
        
        [DllImport("winmm")]
        public static extern uint waveOutSetPlaybackRate(/* _In_ */ IntPtr hwo, /* _In_ */ uint dwRate);
        
        [DllImport("winmm")]
        public static extern uint waveOutSetVolume(/* optional(HWAVEOUT__) */ IntPtr hwo, /* _In_ */ uint dwVolume);
        
        [DllImport("winmm")]
        public static extern uint waveOutUnprepareHeader(/* _In_ */ IntPtr hwo, /* _Inout_updates_bytes_(cbwh) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] wavehdr_tag[] pwh, /* _In_ */ uint cbwh);
        
        [DllImport("winmm")]
        public static extern uint waveOutWrite(/* _In_ */ IntPtr hwo, /* _Inout_updates_bytes_(cbwh) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] wavehdr_tag[] pwh, /* _In_ */ uint cbwh);
        
        [DllImport("wincodec")]
        public static extern HRESULT WICConvertBitmapSource(/* _In_ */ ref REFWICPixelFormatGUID dstFormat, /* // Destination pixel format _In_ */ IWICBitmapSource pISrc, /* // Source bitmap _Outptr_ */ out IWICBitmapSource ppIDst);
        
        [DllImport("wincodec")]
        public static extern HRESULT WICCreateBitmapFromSection(/* _In_ */ uint width, /* _In_ */ uint height, /* _In_ */ ref REFWICPixelFormatGUID pixelFormat, /* _In_ */ IntPtr hSection, /* _In_ */ uint stride, /* _In_ */ uint offset, /* _Outptr_ */ out IWICBitmap ppIBitmap);
        
        [DllImport("wincodec")]
        public static extern HRESULT WICCreateBitmapFromSectionEx(/* _In_ */ uint width, /* _In_ */ uint height, /* _In_ */ ref REFWICPixelFormatGUID pixelFormat, /* _In_ */ IntPtr hSection, /* _In_ */ uint stride, /* _In_ */ uint offset, /* _In_ */ WICSectionAccessLevel desiredAccessLevel, /* _Outptr_ */ out IWICBitmap ppIBitmap);
        
        [DllImport("wincodec")]
        public static extern HRESULT WICMapGuidToShortName(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _In_ */ uint cchName, /* _Inout_updates_opt_(cchName) */ [MarshalAs(UnmanagedType.LPWStr)] string wzName, /* _Out_ */ out uint pcchActual);
        
        [DllImport("wincodec")]
        public static extern HRESULT WICMapSchemaToName(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidMetadataFormat, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pwzSchema, /* _In_ */ uint cchName, /* _Inout_updates_opt_(cchName) */ [MarshalAs(UnmanagedType.LPWStr)] string wzName, /* _Out_ */ out uint pcchActual);
        
        [DllImport("wincodec")]
        public static extern HRESULT WICMapShortNameToGuid(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string wzName, /* _Out_ */ out Guid pguid);
        
        [DllImport("wincodecsdk")]
        public static extern HRESULT WICGetMetadataContentSize(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidContainerFormat, /* _In_ */ IWICMetadataWriter pIWriter, /* _Out_ */ out ulong pcbSize);
        
        [DllImport("wincodecsdk")]
        public static extern HRESULT WICMatchMetadataContent(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidContainerFormat, /* optional(GUID) */ IntPtr pguidVendor, /* _In_ */ IStream pIStream, /* _Out_ */ out Guid pguidMetadataFormat);
        
        [DllImport("wincodecsdk")]
        public static extern HRESULT WICSerializeMetadataContent(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidContainerFormat, /* _In_ */ IWICMetadataWriter pIWriter, /* _In_ */ uint dwPersistOptions, /* _In_ */ IStream pIStream);
        
        [DllImport("gdi32")]
        public static extern void AbortDoc(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern bool AbortPath(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern IntPtr AddFontMemResourceEx(/* _In_reads_bytes_(cjSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] pFileView, /* _In_ */ uint cjSize, /* _Reserved_ */ ref IntPtr pvResrved, /* _In_ */ ref uint pNumFonts);
        
        [DllImport("gdi32")]
        public static extern void AddFontResourceA(/* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string __unnamed_0);
        
        [DllImport("gdi32")]
        public static extern void AddFontResourceExA(/* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string name, /* _In_ */ uint fl, /* _Reserved_ */ ref IntPtr res);
        
        [DllImport("gdi32")]
        public static extern void AddFontResourceExW(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string name, /* _In_ */ uint fl, /* _Reserved_ */ ref IntPtr res);
        
        [DllImport("gdi32")]
        public static extern void AddFontResourceW(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string __unnamed_0);
        
        [DllImport("gdi32")]
        public static extern bool AlphaBlend(/* _In_ */ IntPtr hdcDest, /* _In_ */ int xoriginDest, /* _In_ */ int yoriginDest, /* _In_ */ int wDest, /* _In_ */ int hDest, /* _In_ */ IntPtr hdcSrc, /* _In_ */ int xoriginSrc, /* _In_ */ int yoriginSrc, /* _In_ */ int wSrc, /* _In_ */ int hSrc, /* _In_ */ _BLENDFUNCTION ftn);
        
        [DllImport("gdi32")]
        public static extern bool AngleArc(/* _In_ */ IntPtr hdc, /* _In_ */ int x, /* _In_ */ int y, /* _In_ */ uint r, /* _In_ */ float StartAngle, /* _In_ */ float SweepAngle);
        
        [DllImport("gdi32")]
        public static extern bool AnimatePalette(/* _In_ */ IntPtr hPal, /* _In_ */ uint iStartIndex, /* _In_ */ uint cEntries, /* _In_reads_(cEntries) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagPALETTEENTRY[] ppe);
        
        [DllImport("gdi32")]
        public static extern bool Arc(/* _In_ */ IntPtr hdc, /* _In_ */ int x1, /* _In_ */ int y1, /* _In_ */ int x2, /* _In_ */ int y2, /* _In_ */ int x3, /* _In_ */ int y3, /* _In_ */ int x4, /* _In_ */ int y4);
        
        [DllImport("gdi32")]
        public static extern bool ArcTo(/* _In_ */ IntPtr hdc, /* _In_ */ int left, /* _In_ */ int top, /* _In_ */ int right, /* _In_ */ int bottom, /* _In_ */ int xr1, /* _In_ */ int yr1, /* _In_ */ int xr2, /* _In_ */ int yr2);
        
        [DllImport("gdi32")]
        public static extern bool BeginPath(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern bool BitBlt(/* _In_ */ IntPtr hdc, /* _In_ */ int x, /* _In_ */ int y, /* _In_ */ int cx, /* _In_ */ int cy, /* optional(HDC__) */ IntPtr hdcSrc, /* _In_ */ int x1, /* _In_ */ int y1, /* _In_ */ uint rop);
        
        [DllImport("gdi32")]
        public static extern bool CancelDC(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern bool CheckColorsInGamut(/* _In_ */ IntPtr hdc, /* _In_reads_(nCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] tagRGBTRIPLE[] lpRGBTriple, /* _Out_writes_bytes_(nCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] IntPtr[] dlpBuffer, /* _In_ */ uint nCount);
        
        [DllImport("gdi32")]
        public static extern void ChoosePixelFormat(/* _In_ */ IntPtr hdc, /* _In_ */ ref tagPIXELFORMATDESCRIPTOR ppfd);
        
        [DllImport("gdi32")]
        public static extern bool Chord(/* _In_ */ IntPtr hdc, /* _In_ */ int x1, /* _In_ */ int y1, /* _In_ */ int x2, /* _In_ */ int y2, /* _In_ */ int x3, /* _In_ */ int y3, /* _In_ */ int x4, /* _In_ */ int y4);
        
        [DllImport("gdi32")]
        public static extern IntPtr CloseEnhMetaFile(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern bool CloseFigure(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern IntPtr CloseMetaFile(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern bool ColorCorrectPalette(/* _In_ */ IntPtr hdc, /* _In_ */ IntPtr hPal, /* _In_ */ uint deFirst, /* _In_ */ uint num);
        
        [DllImport("gdi32")]
        public static extern bool ColorMatchToTarget(/* _In_ */ IntPtr hdc, /* _In_ */ IntPtr hdcTarget, /* _In_ */ uint action);
        
        [DllImport("gdi32")]
        public static extern void CombineRgn(/* optional(HRGN) */ IntPtr hrgnDst, /* optional(HRGN) */ IntPtr hrgnSrc1, /* optional(HRGN) */ IntPtr hrgnSrc2, /* _In_ */ int iMode);
        
        [DllImport("gdi32")]
        public static extern bool CombineTransform(/* _Out_ */ out tagXFORM lpxfOut, /* _In_ */ ref tagXFORM lpxf1, /* _In_ */ ref tagXFORM lpxf2);
        
        [DllImport("gdi32")]
        public static extern IntPtr CopyEnhMetaFileA(/* _In_ */ IntPtr hEnh, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
        
        [DllImport("gdi32")]
        public static extern IntPtr CopyEnhMetaFileW(/* _In_ */ IntPtr hEnh, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
        
        [DllImport("gdi32")]
        public static extern IntPtr CopyMetaFileA(/* _In_ */ IntPtr __unnamed_0, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string __unnamed_1);
        
        [DllImport("gdi32")]
        public static extern IntPtr CopyMetaFileW(/* _In_ */ IntPtr __unnamed_0, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string __unnamed_1);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreateBitmap(/* _In_ */ int nWidth, /* _In_ */ int nHeight, /* _In_ */ uint nPlanes, /* _In_ */ uint nBitCount, /* optional(void) */ IntPtr lpBits);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreateBitmapIndirect(/* _In_ */ ref tagBITMAP pbm);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreateBrushIndirect(/* _In_ */ ref tagLOGBRUSH plbrush);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreateColorSpaceA(/* _In_ */ ref tagLOGCOLORSPACEA lplcs);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreateColorSpaceW(/* _In_ */ ref tagLOGCOLORSPACEW lplcs);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreateCompatibleBitmap(/* _In_ */ IntPtr hdc, /* _In_ */ int cx, /* _In_ */ int cy);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreateCompatibleDC(/* optional(HDC__) */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreateDCA(/* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string pwszDriver, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string pwszDevice, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string pszPort, /* optional(_devicemodeA) */ IntPtr pdm);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreateDCW(/* _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string pwszDriver, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string pwszDevice, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string pszPort, /* optional(_devicemodeW) */ IntPtr pdm);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreateDIBitmap(/* _In_ */ IntPtr hdc, /* optional(tagBITMAPINFOHEADER) */ IntPtr pbmih, /* _In_ */ uint flInit, /* optional(void) */ IntPtr pjBits, /* optional(tagBITMAPINFO) */ IntPtr pbmi, /* _In_ */ uint iUsage);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreateDIBPatternBrush(/* _In_ */ IntPtr h, /* _In_ */ uint iUsage);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreateDIBPatternBrushPt(/* _In_ */ IntPtr lpPackedDIB, /* _In_ */ uint iUsage);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreateDIBSection(/* optional(HDC__) */ IntPtr hdc, /* _In_ */ ref tagBITMAPINFO pbmi, /* _In_ */ uint usage, /* _When_((pbmi->bmiHeader.biBitCount != 0), _Outptr_result_bytebuffer_(_Inexpressible_(GDI_DIBSIZE((pbmi->bmiHeader))))) _When_((pbmi->bmiHeader.biBitCount == 0), _Outptr_result_bytebuffer_((pbmi->bmiHeader).biSizeImage)) */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvBits, /* optional(HANDLE) */ IntPtr hSection, /* _In_ */ uint offset);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreateDiscardableBitmap(/* _In_ */ IntPtr hdc, /* _In_ */ int cx, /* _In_ */ int cy);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreateEllipticRgn(/* _In_ */ int x1, /* _In_ */ int y1, /* _In_ */ int x2, /* _In_ */ int y2);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreateEllipticRgnIndirect(/* _In_ */ ref tagRECT lprect);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreateEnhMetaFileA(/* optional(HDC__) */ IntPtr hdc, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string lpFilename, /* optional(tagRECT) */ IntPtr lprc, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string lpDesc);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreateEnhMetaFileW(/* optional(HDC__) */ IntPtr hdc, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string lpFilename, /* optional(tagRECT) */ IntPtr lprc, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string lpDesc);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreateFontA(/* _In_ */ int cHeight, /* _In_ */ int cWidth, /* _In_ */ int cEscapement, /* _In_ */ int cOrientation, /* _In_ */ int cWeight, /* _In_ */ uint bItalic, /* _In_ */ uint bUnderline, /* _In_ */ uint bStrikeOut, /* _In_ */ uint iCharSet, /* _In_ */ uint iOutPrecision, /* _In_ */ uint iClipPrecision, /* _In_ */ uint iQuality, /* _In_ */ uint iPitchAndFamily, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string pszFaceName);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreateFontIndirectA(/* _In_ */ ref tagLOGFONTA lplf);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreateFontIndirectExA(/* _In_ */ ref tagENUMLOGFONTEXDVA __unnamed_0);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreateFontIndirectExW(/* _In_ */ ref tagENUMLOGFONTEXDVW __unnamed_0);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreateFontIndirectW(/* _In_ */ ref tagLOGFONTW lplf);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreateFontW(/* _In_ */ int cHeight, /* _In_ */ int cWidth, /* _In_ */ int cEscapement, /* _In_ */ int cOrientation, /* _In_ */ int cWeight, /* _In_ */ uint bItalic, /* _In_ */ uint bUnderline, /* _In_ */ uint bStrikeOut, /* _In_ */ uint iCharSet, /* _In_ */ uint iOutPrecision, /* _In_ */ uint iClipPrecision, /* _In_ */ uint iQuality, /* _In_ */ uint iPitchAndFamily, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string pszFaceName);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreateHalftonePalette(/* optional(HDC__) */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreateHatchBrush(/* _In_ */ int iHatch, /* _In_ */ uint color);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreateICA(/* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string pszDriver, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string pszDevice, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string pszPort, /* optional(_devicemodeA) */ IntPtr pdm);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreateICW(/* _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string pszDriver, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string pszDevice, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string pszPort, /* optional(_devicemodeW) */ IntPtr pdm);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreateMetaFileA(/* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string pszFile);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreateMetaFileW(/* _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string pszFile);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreatePalette(/* _In_reads_(_Inexpressible_(2*sizeof(WORD) + plpal->palNumEntries * sizeof(PALETTEENTRY))) */ [MarshalAs(UnmanagedType.LPArray)] tagLOGPALETTE[] plpal);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreatePatternBrush(/* _In_ */ IntPtr hbm);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreatePen(/* _In_ */ int iStyle, /* _In_ */ int cWidth, /* _In_ */ uint color);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreatePenIndirect(/* _In_ */ ref tagLOGPEN plpen);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreatePolygonRgn(/* _In_reads_(cPoint) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] tagPOINT[] pptl, /* _In_ */ int cPoint, /* _In_ */ int iMode);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreatePolyPolygonRgn(/* _In_ */ ref tagPOINT pptl, /* _In_reads_(cPoly) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] int[] pc, /* _In_ */ int cPoly, /* _In_ */ int iMode);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreateRectRgn(/* _In_ */ int x1, /* _In_ */ int y1, /* _In_ */ int x2, /* _In_ */ int y2);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreateRectRgnIndirect(/* _In_ */ ref tagRECT lprect);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreateRoundRectRgn(/* _In_ */ int x1, /* _In_ */ int y1, /* _In_ */ int x2, /* _In_ */ int y2, /* _In_ */ int w, /* _In_ */ int h);
        
        [DllImport("gdi32")]
        public static extern bool CreateScalableFontResourceA(/* _In_ */ uint fdwHidden, /* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string lpszFont, /* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string lpszFile, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string lpszPath);
        
        [DllImport("gdi32")]
        public static extern bool CreateScalableFontResourceW(/* _In_ */ uint fdwHidden, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string lpszFont, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string lpszFile, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string lpszPath);
        
        [DllImport("gdi32")]
        public static extern IntPtr CreateSolidBrush(/* _In_ */ uint color);
        
        [DllImport("gdi32")]
        public static extern bool DeleteColorSpace(/* _In_ */ IntPtr hcs);
        
        [DllImport("gdi32")]
        public static extern bool DeleteDC(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern bool DeleteEnhMetaFile(/* optional(HENHMETAFILE__) */ IntPtr hmf);
        
        [DllImport("gdi32")]
        public static extern bool DeleteMetaFile(/* _In_ */ IntPtr hmf);
        
        [DllImport("gdi32")]
        public static extern bool DeleteObject(/* _In_ */ IntPtr ho);
        
        [DllImport("gdi32")]
        public static extern void DescribePixelFormat(/* _In_ */ IntPtr hdc, /* _In_ */ int iPixelFormat, /* _In_ */ uint nBytes, /* _Out_writes_bytes_opt_(nBytes) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagPIXELFORMATDESCRIPTOR[] ppfd);
        
        [DllImport("gdi32")]
        public static extern void DeviceCapabilitiesA(/* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pDevice, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string pPort, /* _In_ */ ushort fwCapability, /* _Out_writes_opt_(_Inexpressible_(1)) */ [MarshalAs(UnmanagedType.LPStr)] string pOutput, /* optional(_devicemodeA) */ IntPtr pDevMode);
        
        [DllImport("gdi32")]
        public static extern void DeviceCapabilitiesW(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pDevice, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string pPort, /* _In_ */ ushort fwCapability, /* _Out_writes_opt_(_Inexpressible_(1)) */ [MarshalAs(UnmanagedType.LPWStr)] string pOutput, /* optional(_devicemodeW) */ IntPtr pDevMode);
        
        [DllImport("gdi32")]
        public static extern bool DPtoLP(/* _In_ */ IntPtr hdc, /* _Inout_updates_(c) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagPOINT[] lppt, /* _In_ */ int c);
        
        [DllImport("gdi32")]
        public static extern void DrawEscape(/* _In_ */ IntPtr hdc, /* _In_ */ int iEscape, /* _In_ */ int cjIn, /* _In_reads_bytes_opt_(cjIn) */ [MarshalAs(UnmanagedType.LPStr)] string lpIn);
        
        [DllImport("gdi32")]
        public static extern bool Ellipse(/* _In_ */ IntPtr hdc, /* _In_ */ int left, /* _In_ */ int top, /* _In_ */ int right, /* _In_ */ int bottom);
        
        [DllImport("gdi32")]
        public static extern void EndDoc(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern void EndPage(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern bool EndPath(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern bool EnumEnhMetaFile(/* optional(HDC__) */ IntPtr hdc, /* _In_ */ IntPtr hmf, /* _In_ */ ref ENHMFENUMPROC proc, /* optional(LPVOID) */ IntPtr param, /* optional(tagRECT) */ IntPtr lpRect);
        
        [DllImport("gdi32")]
        public static extern void EnumFontFamiliesA(/* _In_ */ IntPtr hdc, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string lpLogfont, /* _In_ */ ref FONTENUMPROCA lpProc, /* _In_ */ long lParam);
        
        [DllImport("gdi32")]
        public static extern void EnumFontFamiliesExA(/* _In_ */ IntPtr hdc, /* _In_ */ ref tagLOGFONTA lpLogfont, /* _In_ */ ref FONTENUMPROCA lpProc, /* _In_ */ long lParam, /* _In_ */ uint dwFlags);
        
        [DllImport("gdi32")]
        public static extern void EnumFontFamiliesExW(/* _In_ */ IntPtr hdc, /* _In_ */ ref tagLOGFONTW lpLogfont, /* _In_ */ ref FONTENUMPROCW lpProc, /* _In_ */ long lParam, /* _In_ */ uint dwFlags);
        
        [DllImport("gdi32")]
        public static extern void EnumFontFamiliesW(/* _In_ */ IntPtr hdc, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string lpLogfont, /* _In_ */ ref FONTENUMPROCW lpProc, /* _In_ */ long lParam);
        
        [DllImport("gdi32")]
        public static extern void EnumFontsA(/* _In_ */ IntPtr hdc, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string lpLogfont, /* _In_ */ ref FONTENUMPROCA lpProc, /* _In_ */ long lParam);
        
        [DllImport("gdi32")]
        public static extern void EnumFontsW(/* _In_ */ IntPtr hdc, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string lpLogfont, /* _In_ */ ref FONTENUMPROCW lpProc, /* _In_ */ long lParam);
        
        [DllImport("gdi32")]
        public static extern void EnumICMProfilesA(/* _In_ */ IntPtr hdc, /* _In_ */ ref ICMENUMPROCA proc, /* _In_opt_ */ long param);
        
        [DllImport("gdi32")]
        public static extern void EnumICMProfilesW(/* _In_ */ IntPtr hdc, /* _In_ */ ref ICMENUMPROCW proc, /* _In_opt_ */ long param);
        
        [DllImport("gdi32")]
        public static extern bool EnumMetaFile(/* _In_ */ IntPtr hdc, /* _In_ */ IntPtr hmf, /* _In_ */ ref MFENUMPROC proc, /* _In_opt_ */ long param);
        
        [DllImport("gdi32")]
        public static extern void EnumObjects(/* _In_ */ IntPtr hdc, /* _In_ */ int nType, /* _In_ */ ref GOBJENUMPROC lpFunc, /* _In_ */ long lParam);
        
        [DllImport("gdi32")]
        public static extern bool EqualRgn(/* _In_ */ IntPtr hrgn1, /* _In_ */ IntPtr hrgn2);
        
        [DllImport("gdi32")]
        public static extern void Escape(/* _In_ */ IntPtr hdc, /* _In_ */ int iEscape, /* _In_ */ int cjIn, /* _In_reads_bytes_opt_(cjIn) */ [MarshalAs(UnmanagedType.LPStr)] string pvIn, /* optional(LPVOID) */ out IntPtr pvOut);
        
        [DllImport("gdi32")]
        public static extern void ExcludeClipRect(/* _In_ */ IntPtr hdc, /* _In_ */ int left, /* _In_ */ int top, /* _In_ */ int right, /* _In_ */ int bottom);
        
        [DllImport("gdi32")]
        public static extern IntPtr ExtCreatePen(/* _In_ */ uint iPenStyle, /* _In_ */ uint cWidth, /* _In_ */ ref tagLOGBRUSH plbrush, /* _In_ */ uint cStyle, /* _In_reads_opt_(cStyle) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] uint[] pstyle);
        
        [DllImport("gdi32")]
        public static extern IntPtr ExtCreateRegion(/* optional(tagXFORM) */ IntPtr lpx, /* _In_ */ uint nCount, /* _In_reads_bytes_(nCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] _RGNDATA[] lpData);
        
        [DllImport("gdi32")]
        public static extern void ExtEscape(/* _In_ */ IntPtr hdc, /* _In_ */ int iEscape, /* _In_ */ int cjInput, /* _In_reads_bytes_opt_(cjInput) */ [MarshalAs(UnmanagedType.LPStr)] string lpInData, /* _In_ */ int cjOutput, /* _Out_writes_bytes_opt_(cjOutput) */ [MarshalAs(UnmanagedType.LPStr)] string lpOutData);
        
        [DllImport("gdi32")]
        public static extern bool ExtFloodFill(/* _In_ */ IntPtr hdc, /* _In_ */ int x, /* _In_ */ int y, /* _In_ */ uint color, /* _In_ */ uint type);
        
        [DllImport("gdi32")]
        public static extern void ExtSelectClipRgn(/* _In_ */ IntPtr hdc, /* optional(HRGN) */ IntPtr hrgn, /* _In_ */ int mode);
        
        [DllImport("gdi32")]
        public static extern bool ExtTextOutA(/* _In_ */ IntPtr hdc, /* _In_ */ int x, /* _In_ */ int y, /* _In_ */ uint options, /* optional(tagRECT) */ IntPtr lprect, /* _In_reads_opt_(c) */ [MarshalAs(UnmanagedType.LPStr)] string lpString, /* _In_ */ uint c, /* _In_reads_opt_(c) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] int[] lpDx);
        
        [DllImport("gdi32")]
        public static extern bool ExtTextOutW(/* _In_ */ IntPtr hdc, /* _In_ */ int x, /* _In_ */ int y, /* _In_ */ uint options, /* optional(tagRECT) */ IntPtr lprect, /* _In_reads_opt_(c) */ [MarshalAs(UnmanagedType.LPWStr)] string lpString, /* _In_ */ uint c, /* _In_reads_opt_(c) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] int[] lpDx);
        
        [DllImport("gdi32")]
        public static extern bool FillPath(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern bool FillRgn(/* _In_ */ IntPtr hdc, /* _In_ */ IntPtr hrgn, /* _In_ */ IntPtr hbr);
        
        [DllImport("gdi32")]
        public static extern bool FixBrushOrgEx(/* _In_ */ IntPtr hdc, /* _In_ */ int x, /* _In_ */ int y, /* optional(tagPOINT) */ IntPtr ptl);
        
        [DllImport("gdi32")]
        public static extern bool FlattenPath(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern bool FloodFill(/* _In_ */ IntPtr hdc, /* _In_ */ int x, /* _In_ */ int y, /* _In_ */ uint color);
        
        [DllImport("gdi32")]
        public static extern bool FrameRgn(/* _In_ */ IntPtr hdc, /* _In_ */ IntPtr hrgn, /* _In_ */ IntPtr hbr, /* _In_ */ int w, /* _In_ */ int h);
        
        [DllImport("gdi32")]
        public static extern bool GdiAlphaBlend(/* _In_ */ IntPtr hdcDest, /* _In_ */ int xoriginDest, /* _In_ */ int yoriginDest, /* _In_ */ int wDest, /* _In_ */ int hDest, /* _In_ */ IntPtr hdcSrc, /* _In_ */ int xoriginSrc, /* _In_ */ int yoriginSrc, /* _In_ */ int wSrc, /* _In_ */ int hSrc, /* _In_ */ _BLENDFUNCTION ftn);
        
        [DllImport("gdi32")]
        public static extern bool GdiComment(/* _In_ */ IntPtr hdc, /* _In_ */ uint nSize, /* _In_reads_bytes_(nSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] lpData);
        
        [DllImport("gdi32")]
        public static extern bool GdiFlush();
        
        [DllImport("gdi32")]
        public static extern uint GdiGetBatchLimit();
        
        [DllImport("gdi32")]
        public static extern bool GdiGradientFill(/* _In_ */ IntPtr hdc, /* _In_reads_(nVertex) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] _TRIVERTEX[] pVertex, /* _In_ */ uint nVertex, /* _In_ */ IntPtr pMesh, /* _In_ */ uint nCount, /* _In_ */ uint ulMode);
        
        [DllImport("gdi32")]
        public static extern uint GdiSetBatchLimit(/* _In_ */ uint dw);
        
        [DllImport("gdi32")]
        public static extern bool GdiTransparentBlt(/* _In_ */ IntPtr hdcDest, /* _In_ */ int xoriginDest, /* _In_ */ int yoriginDest, /* _In_ */ int wDest, /* _In_ */ int hDest, /* _In_ */ IntPtr hdcSrc, /* _In_ */ int xoriginSrc, /* _In_ */ int yoriginSrc, /* _In_ */ int wSrc, /* _In_ */ int hSrc, /* _In_ */ uint crTransparent);
        
        [DllImport("gdi32")]
        public static extern void GetArcDirection(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern bool GetAspectRatioFilterEx(/* _In_ */ IntPtr hdc, /* _Out_ */ out tagSIZE lpsize);
        
        [DllImport("gdi32")]
        public static extern int GetBitmapBits(/* _In_ */ IntPtr hbit, /* _In_ */ int cb, /* _Out_writes_bytes_(cb) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] lpvBits);
        
        [DllImport("gdi32")]
        public static extern bool GetBitmapDimensionEx(/* _In_ */ IntPtr hbit, /* _Out_ */ out tagSIZE lpsize);
        
        [DllImport("gdi32")]
        public static extern uint GetBkColor(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern void GetBkMode(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern uint GetBoundsRect(/* _In_ */ IntPtr hdc, /* _Out_ */ out tagRECT lprect, /* _In_ */ uint flags);
        
        [DllImport("gdi32")]
        public static extern bool GetBrushOrgEx(/* _In_ */ IntPtr hdc, /* _Out_ */ out tagPOINT lppt);
        
        [DllImport("gdi32")]
        public static extern bool GetCharABCWidthsA(/* _In_ */ IntPtr hdc, /* _In_ */ uint wFirst, /* _In_ */ uint wLast, /* _Out_writes_(wLast - wFirst + 1) */ [Out, MarshalAs(UnmanagedType.LPArray)] _ABC[] lpABC);
        
        [DllImport("gdi32")]
        public static extern bool GetCharABCWidthsFloatA(/* _In_ */ IntPtr hdc, /* _In_ */ uint iFirst, /* _In_ */ uint iLast, /* _Out_writes_(iLast + 1 - iFirst) */ [Out, MarshalAs(UnmanagedType.LPArray)] _ABCFLOAT[] lpABC);
        
        [DllImport("gdi32")]
        public static extern bool GetCharABCWidthsFloatW(/* _In_ */ IntPtr hdc, /* _In_ */ uint iFirst, /* _In_ */ uint iLast, /* _Out_writes_(iLast + 1 - iFirst) */ [Out, MarshalAs(UnmanagedType.LPArray)] _ABCFLOAT[] lpABC);
        
        [DllImport("gdi32")]
        public static extern bool GetCharABCWidthsI(/* _In_ */ IntPtr hdc, /* _In_ */ uint giFirst, /* _In_ */ uint cgi, /* _In_reads_opt_(cgi) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ushort[] pgi, /* _Out_writes_(cgi) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] _ABC[] pabc);
        
        [DllImport("gdi32")]
        public static extern bool GetCharABCWidthsW(/* _In_ */ IntPtr hdc, /* _In_ */ uint wFirst, /* _In_ */ uint wLast, /* _Out_writes_(wLast - wFirst + 1) */ [Out, MarshalAs(UnmanagedType.LPArray)] _ABC[] lpABC);
        
        [DllImport("gdi32")]
        public static extern uint GetCharacterPlacementA(/* _In_ */ IntPtr hdc, /* _In_reads_(nCount) */ [MarshalAs(UnmanagedType.LPStr)] string lpString, /* _In_ */ int nCount, /* _In_ */ int nMexExtent, /* _Inout_ */ ref tagGCP_RESULTSA lpResults, /* _In_ */ uint dwFlags);
        
        [DllImport("gdi32")]
        public static extern uint GetCharacterPlacementW(/* _In_ */ IntPtr hdc, /* _In_reads_(nCount) */ [MarshalAs(UnmanagedType.LPWStr)] string lpString, /* _In_ */ int nCount, /* _In_ */ int nMexExtent, /* _Inout_ */ ref tagGCP_RESULTSW lpResults, /* _In_ */ uint dwFlags);
        
        [DllImport("gdi32")]
        public static extern bool GetCharWidth32A(/* _In_ */ IntPtr hdc, /* _In_ */ uint iFirst, /* _In_ */ uint iLast, /* _Out_writes_(iLast + 1 - iFirst) */ [Out, MarshalAs(UnmanagedType.LPArray)] int[] lpBuffer);
        
        [DllImport("gdi32")]
        public static extern bool GetCharWidth32W(/* _In_ */ IntPtr hdc, /* _In_ */ uint iFirst, /* _In_ */ uint iLast, /* _Out_writes_(iLast + 1 - iFirst) */ [Out, MarshalAs(UnmanagedType.LPArray)] int[] lpBuffer);
        
        [DllImport("gdi32")]
        public static extern bool GetCharWidthA(/* _In_ */ IntPtr hdc, /* _In_ */ uint iFirst, /* _In_ */ uint iLast, /* _Out_writes_(iLast + 1 - iFirst) */ [Out, MarshalAs(UnmanagedType.LPArray)] int[] lpBuffer);
        
        [DllImport("gdi32")]
        public static extern bool GetCharWidthFloatA(/* _In_ */ IntPtr hdc, /* _In_ */ uint iFirst, /* _In_ */ uint iLast, /* _Out_writes_(iLast + 1 - iFirst) */ [Out, MarshalAs(UnmanagedType.LPArray)] float[] lpBuffer);
        
        [DllImport("gdi32")]
        public static extern bool GetCharWidthFloatW(/* _In_ */ IntPtr hdc, /* _In_ */ uint iFirst, /* _In_ */ uint iLast, /* _Out_writes_(iLast + 1 - iFirst) */ [Out, MarshalAs(UnmanagedType.LPArray)] float[] lpBuffer);
        
        [DllImport("gdi32")]
        public static extern bool GetCharWidthI(/* _In_ */ IntPtr hdc, /* _In_ */ uint giFirst, /* _In_ */ uint cgi, /* _In_reads_opt_(cgi) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ushort[] pgi, /* _Out_writes_(cgi) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] int[] piWidths);
        
        [DllImport("gdi32")]
        public static extern bool GetCharWidthW(/* _In_ */ IntPtr hdc, /* _In_ */ uint iFirst, /* _In_ */ uint iLast, /* _Out_writes_(iLast + 1 - iFirst) */ [Out, MarshalAs(UnmanagedType.LPArray)] int[] lpBuffer);
        
        [DllImport("gdi32")]
        public static extern void GetClipBox(/* _In_ */ IntPtr hdc, /* _Out_ */ out tagRECT lprect);
        
        [DllImport("gdi32")]
        public static extern void GetClipRgn(/* _In_ */ IntPtr hdc, /* _In_ */ IntPtr hrgn);
        
        [DllImport("gdi32")]
        public static extern bool GetColorAdjustment(/* _In_ */ IntPtr hdc, /* _Out_ */ out tagCOLORADJUSTMENT lpca);
        
        [DllImport("gdi32")]
        public static extern IntPtr GetColorSpace(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern IntPtr GetCurrentObject(/* _In_ */ IntPtr hdc, /* _In_ */ uint type);
        
        [DllImport("gdi32")]
        public static extern bool GetCurrentPositionEx(/* _In_ */ IntPtr hdc, /* _Out_ */ out tagPOINT lppt);
        
        [DllImport("gdi32")]
        public static extern uint GetDCBrushColor(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern bool GetDCOrgEx(/* _In_ */ IntPtr hdc, /* _Out_ */ out tagPOINT lppt);
        
        [DllImport("gdi32")]
        public static extern uint GetDCPenColor(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern void GetDeviceCaps(/* optional(HDC__) */ IntPtr hdc, /* _In_ */ int index);
        
        [DllImport("gdi32")]
        public static extern bool GetDeviceGammaRamp(/* _In_ */ IntPtr hdc, /* _Out_writes_bytes_(3*256*2) */ [Out, MarshalAs(UnmanagedType.LPArray)] IntPtr[] lpRamp);
        
        [DllImport("gdi32")]
        public static extern uint GetDIBColorTable(/* _In_ */ IntPtr hdc, /* _In_ */ uint iStart, /* _In_ */ uint cEntries, /* _Out_writes_to_(cEntries,return) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagRGBQUAD[] prgbq);
        
        [DllImport("gdi32")]
        public static extern void GetDIBits(/* _In_ */ IntPtr hdc, /* _In_ */ IntPtr hbm, /* _In_ */ uint start, /* _In_ */ uint cLines, /* optional(LPVOID) */ out IntPtr lpvBits, /* _At_((LPBITMAPINFOHEADER)lpbmi, _Inout_) */ [MarshalAs(UnmanagedType.LPArray)] tagBITMAPINFO[] lpbmi, /* _In_ */ uint usage);
        
        [DllImport("gdi32")]
        public static extern IntPtr GetEnhMetaFileA(/* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string lpName);
        
        [DllImport("gdi32")]
        public static extern uint GetEnhMetaFileBits(/* _In_ */ IntPtr hEMF, /* _In_ */ uint nSize, /* _Out_writes_bytes_opt_(nSize) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] lpData);
        
        [DllImport("gdi32")]
        public static extern uint GetEnhMetaFileDescriptionA(/* _In_ */ IntPtr hemf, /* _In_ */ uint cchBuffer, /* _Out_writes_opt_(cchBuffer) */ [MarshalAs(UnmanagedType.LPStr)] string lpDescription);
        
        [DllImport("gdi32")]
        public static extern uint GetEnhMetaFileDescriptionW(/* _In_ */ IntPtr hemf, /* _In_ */ uint cchBuffer, /* _Out_writes_opt_(cchBuffer) */ [MarshalAs(UnmanagedType.LPWStr)] string lpDescription);
        
        [DllImport("gdi32")]
        public static extern uint GetEnhMetaFileHeader(/* _In_ */ IntPtr hemf, /* _In_ */ uint nSize, /* _Out_writes_bytes_opt_(nSize) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] tagENHMETAHEADER[] lpEnhMetaHeader);
        
        [DllImport("gdi32")]
        public static extern uint GetEnhMetaFilePaletteEntries(/* _In_ */ IntPtr hemf, /* _In_ */ uint nNumEntries, /* _Out_writes_opt_(nNumEntries) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] tagPALETTEENTRY[] lpPaletteEntries);
        
        [DllImport("gdi32")]
        public static extern uint GetEnhMetaFilePixelFormat(/* _In_ */ IntPtr hemf, /* _In_ */ uint cbBuffer, /* _Out_writes_bytes_opt_(cbBuffer) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] tagPIXELFORMATDESCRIPTOR[] ppfd);
        
        [DllImport("gdi32")]
        public static extern IntPtr GetEnhMetaFileW(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string lpName);
        
        [DllImport("gdi32")]
        public static extern uint GetFontData(/* _In_ */ IntPtr hdc, /* _In_ */ uint dwTable, /* _In_ */ uint dwOffset, /* _Out_writes_bytes_to_opt_(cjBuffer, return) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] IntPtr[] pvBuffer, /* _In_ */ uint cjBuffer);
        
        [DllImport("gdi32")]
        public static extern uint GetFontLanguageInfo(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern uint GetFontUnicodeRanges(/* _In_ */ IntPtr hdc, /* _Out_opt_ */ out tagGLYPHSET lpgs);
        
        [DllImport("gdi32")]
        public static extern uint GetGlyphIndicesA(/* _In_ */ IntPtr hdc, /* _In_reads_(c) */ [MarshalAs(UnmanagedType.LPStr)] string lpstr, /* _In_ */ int c, /* _Out_writes_(c) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ushort[] pgi, /* _In_ */ uint fl);
        
        [DllImport("gdi32")]
        public static extern uint GetGlyphIndicesW(/* _In_ */ IntPtr hdc, /* _In_reads_(c) */ [MarshalAs(UnmanagedType.LPWStr)] string lpstr, /* _In_ */ int c, /* _Out_writes_(c) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ushort[] pgi, /* _In_ */ uint fl);
        
        [DllImport("gdi32")]
        public static extern uint GetGlyphOutlineA(/* _In_ */ IntPtr hdc, /* _In_ */ uint uChar, /* _In_ */ uint fuFormat, /* _Out_ */ out _GLYPHMETRICS lpgm, /* _In_ */ uint cjBuffer, /* _Out_writes_bytes_opt_(cjBuffer) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] IntPtr[] pvBuffer, /* _In_ */ ref _MAT2 lpmat2);
        
        [DllImport("gdi32")]
        public static extern uint GetGlyphOutlineW(/* _In_ */ IntPtr hdc, /* _In_ */ uint uChar, /* _In_ */ uint fuFormat, /* _Out_ */ out _GLYPHMETRICS lpgm, /* _In_ */ uint cjBuffer, /* _Out_writes_bytes_opt_(cjBuffer) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] IntPtr[] pvBuffer, /* _In_ */ ref _MAT2 lpmat2);
        
        [DllImport("gdi32")]
        public static extern void GetGraphicsMode(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern bool GetICMProfileA(/* _In_ */ IntPtr hdc, /* _Inout_ */ ref uint pBufSize, /* _Out_writes_opt_(*pBufSize) */ [MarshalAs(UnmanagedType.LPStr)] string pszFilename);
        
        [DllImport("gdi32")]
        public static extern bool GetICMProfileW(/* _In_ */ IntPtr hdc, /* _Inout_ */ ref uint pBufSize, /* _Out_writes_opt_(*pBufSize) */ [MarshalAs(UnmanagedType.LPWStr)] string pszFilename);
        
        [DllImport("gdi32")]
        public static extern uint GetKerningPairsA(/* _In_ */ IntPtr hdc, /* _In_ */ uint nPairs, /* _Out_writes_to_opt_(nPairs, return) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] tagKERNINGPAIR[] lpKernPair);
        
        [DllImport("gdi32")]
        public static extern uint GetKerningPairsW(/* _In_ */ IntPtr hdc, /* _In_ */ uint nPairs, /* _Out_writes_to_opt_(nPairs, return) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] tagKERNINGPAIR[] lpKernPair);
        
        [DllImport("gdi32")]
        public static extern uint GetLayout(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern bool GetLogColorSpaceA(/* _In_ */ IntPtr hColorSpace, /* _Out_writes_bytes_(nSize) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagLOGCOLORSPACEA[] lpBuffer, /* _In_ */ uint nSize);
        
        [DllImport("gdi32")]
        public static extern bool GetLogColorSpaceW(/* _In_ */ IntPtr hColorSpace, /* _Out_writes_bytes_(nSize) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagLOGCOLORSPACEW[] lpBuffer, /* _In_ */ uint nSize);
        
        [DllImport("gdi32")]
        public static extern void GetMapMode(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern IntPtr GetMetaFileA(/* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string lpName);
        
        [DllImport("gdi32")]
        public static extern uint GetMetaFileBitsEx(/* _In_ */ IntPtr hMF, /* _In_ */ uint cbBuffer, /* _Out_writes_bytes_opt_(cbBuffer) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] lpData);
        
        [DllImport("gdi32")]
        public static extern IntPtr GetMetaFileW(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string lpName);
        
        [DllImport("gdi32")]
        public static extern void GetMetaRgn(/* _In_ */ IntPtr hdc, /* _In_ */ IntPtr hrgn);
        
        [DllImport("gdi32")]
        public static extern bool GetMiterLimit(/* _In_ */ IntPtr hdc, /* _Out_ */ out float plimit);
        
        [DllImport("gdi32")]
        public static extern uint GetNearestColor(/* _In_ */ IntPtr hdc, /* _In_ */ uint color);
        
        [DllImport("gdi32")]
        public static extern uint GetNearestPaletteIndex(/* _In_ */ IntPtr h, /* _In_ */ uint color);
        
        [DllImport("gdi32")]
        public static extern void GetObjectA(/* _In_ */ IntPtr h, /* _In_ */ int c, /* _Out_writes_bytes_opt_(c) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] pv);
        
        [DllImport("gdi32")]
        public static extern uint GetObjectType(/* _In_ */ IntPtr h);
        
        [DllImport("gdi32")]
        public static extern void GetObjectW(/* _In_ */ IntPtr h, /* _In_ */ int c, /* _Out_writes_bytes_opt_(c) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] pv);
        
        [DllImport("gdi32")]
        public static extern uint GetOutlineTextMetricsA(/* _In_ */ IntPtr hdc, /* _In_ */ uint cjCopy, /* _Out_writes_bytes_opt_(cjCopy) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] _OUTLINETEXTMETRICA[] potm);
        
        [DllImport("gdi32")]
        public static extern uint GetOutlineTextMetricsW(/* _In_ */ IntPtr hdc, /* _In_ */ uint cjCopy, /* _Out_writes_bytes_opt_(cjCopy) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] _OUTLINETEXTMETRICW[] potm);
        
        [DllImport("gdi32")]
        public static extern uint GetPaletteEntries(/* _In_ */ IntPtr hpal, /* _In_ */ uint iStart, /* _In_ */ uint cEntries, /* _Out_writes_to_opt_(cEntries,return) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagPALETTEENTRY[] pPalEntries);
        
        [DllImport("gdi32")]
        public static extern void GetPath(/* _In_ */ IntPtr hdc, /* _Out_writes_opt_(cpt) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] tagPOINT[] apt, /* _Out_writes_opt_(cpt) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] aj, int cpt);
        
        [DllImport("gdi32")]
        public static extern uint GetPixel(/* _In_ */ IntPtr hdc, /* _In_ */ int x, /* _In_ */ int y);
        
        [DllImport("gdi32")]
        public static extern void GetPixelFormat(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern void GetPolyFillMode(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern void GetRandomRgn(/* _In_ */ IntPtr hdc, /* _In_ */ IntPtr hrgn, /* _In_ */ int i);
        
        [DllImport("gdi32")]
        public static extern bool GetRasterizerCaps(/* _Out_writes_bytes_(cjBytes) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] _RASTERIZER_STATUS[] lpraststat, /* _In_ */ uint cjBytes);
        
        [DllImport("gdi32")]
        public static extern uint GetRegionData(/* _In_ */ IntPtr hrgn, /* _In_ */ uint nCount, /* _Out_writes_bytes_to_opt_(nCount, return) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] _RGNDATA[] lpRgnData);
        
        [DllImport("gdi32")]
        public static extern void GetRgnBox(/* _In_ */ IntPtr hrgn, /* _Out_ */ out tagRECT lprc);
        
        [DllImport("gdi32")]
        public static extern void GetROP2(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern IntPtr GetStockObject(/* _In_ */ int i);
        
        [DllImport("gdi32")]
        public static extern void GetStretchBltMode(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern uint GetSystemPaletteEntries(/* _In_ */ IntPtr hdc, /* _In_ */ uint iStart, /* _In_ */ uint cEntries, /* _Out_writes_opt_(cEntries) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagPALETTEENTRY[] pPalEntries);
        
        [DllImport("gdi32")]
        public static extern uint GetSystemPaletteUse(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern uint GetTextAlign(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern void GetTextCharacterExtra(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern void GetTextCharset(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern void GetTextCharsetInfo(/* _In_ */ IntPtr hdc, /* _Out_opt_ */ out tagFONTSIGNATURE lpSig, /* _In_ */ uint dwFlags);
        
        [DllImport("gdi32")]
        public static extern uint GetTextColor(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern bool GetTextExtentExPointA(/* _In_ */ IntPtr hdc, /* _In_reads_(cchString) */ [MarshalAs(UnmanagedType.LPStr)] string lpszString, /* _In_ */ int cchString, /* _In_ */ int nMaxExtent, /* _Out_opt_ */ out int lpnFit, /* _Out_writes_to_opt_ (cchString, *lpnFit) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] int[] lpnDx, /* _Out_ */ out tagSIZE lpSize);
        
        [DllImport("gdi32")]
        public static extern bool GetTextExtentExPointI(/* _In_ */ IntPtr hdc, /* _In_reads_(cwchString) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ushort[] lpwszString, /* _In_ */ int cwchString, /* _In_ */ int nMaxExtent, /* _Out_opt_ */ out int lpnFit, /* _Out_writes_to_opt_(cwchString, *lpnFit) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] int[] lpnDx, /* _Out_ */ out tagSIZE lpSize);
        
        [DllImport("gdi32")]
        public static extern bool GetTextExtentExPointW(/* _In_ */ IntPtr hdc, /* _In_reads_(cchString) */ [MarshalAs(UnmanagedType.LPWStr)] string lpszString, /* _In_ */ int cchString, /* _In_ */ int nMaxExtent, /* _Out_opt_ */ out int lpnFit, /* _Out_writes_to_opt_ (cchString, *lpnFit) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] int[] lpnDx, /* _Out_ */ out tagSIZE lpSize);
        
        [DllImport("gdi32")]
        public static extern bool GetTextExtentPoint32A(/* _In_ */ IntPtr hdc, /* _In_reads_(c) */ [MarshalAs(UnmanagedType.LPStr)] string lpString, /* _In_ */ int c, /* _Out_ */ out tagSIZE psizl);
        
        [DllImport("gdi32")]
        public static extern bool GetTextExtentPoint32W(/* _In_ */ IntPtr hdc, /* _In_reads_(c) */ [MarshalAs(UnmanagedType.LPWStr)] string lpString, /* _In_ */ int c, /* _Out_ */ out tagSIZE psizl);
        
        [DllImport("gdi32")]
        public static extern bool GetTextExtentPointA(/* _In_ */ IntPtr hdc, /* _In_reads_(c) */ [MarshalAs(UnmanagedType.LPStr)] string lpString, /* _In_ */ int c, /* _Out_ */ out tagSIZE lpsz);
        
        [DllImport("gdi32")]
        public static extern bool GetTextExtentPointI(/* _In_ */ IntPtr hdc, /* _In_reads_(cgi) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ushort[] pgiIn, /* _In_ */ int cgi, /* _Out_ */ out tagSIZE psize);
        
        [DllImport("gdi32")]
        public static extern bool GetTextExtentPointW(/* _In_ */ IntPtr hdc, /* _In_reads_(c) */ [MarshalAs(UnmanagedType.LPWStr)] string lpString, /* _In_ */ int c, /* _Out_ */ out tagSIZE lpsz);
        
        [DllImport("gdi32")]
        public static extern void GetTextFaceA(/* _In_ */ IntPtr hdc, /* _In_ */ int c, /* _Out_writes_to_opt_(c, return) */ [MarshalAs(UnmanagedType.LPStr)] string lpName);
        
        [DllImport("gdi32")]
        public static extern void GetTextFaceW(/* _In_ */ IntPtr hdc, /* _In_ */ int c, /* _Out_writes_to_opt_(c, return) */ [MarshalAs(UnmanagedType.LPWStr)] string lpName);
        
        [DllImport("gdi32")]
        public static extern bool GetTextMetricsA(/* _In_ */ IntPtr hdc, /* _Out_ */ out tagTEXTMETRICA lptm);
        
        [DllImport("gdi32")]
        public static extern bool GetTextMetricsW(/* _In_ */ IntPtr hdc, /* _Out_ */ out tagTEXTMETRICW lptm);
        
        [DllImport("gdi32")]
        public static extern bool GetViewportExtEx(/* _In_ */ IntPtr hdc, /* _Out_ */ out tagSIZE lpsize);
        
        [DllImport("gdi32")]
        public static extern bool GetViewportOrgEx(/* _In_ */ IntPtr hdc, /* _Out_ */ out tagPOINT lppoint);
        
        [DllImport("gdi32")]
        public static extern bool GetWindowExtEx(/* _In_ */ IntPtr hdc, /* _Out_ */ out tagSIZE lpsize);
        
        [DllImport("gdi32")]
        public static extern bool GetWindowOrgEx(/* _In_ */ IntPtr hdc, /* _Out_ */ out tagPOINT lppoint);
        
        [DllImport("gdi32")]
        public static extern uint GetWinMetaFileBits(/* _In_ */ IntPtr hemf, /* _In_ */ uint cbData16, /* _Out_writes_bytes_opt_(cbData16) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pData16, /* _In_ */ int iMapMode, /* _In_ */ IntPtr hdcRef);
        
        [DllImport("gdi32")]
        public static extern bool GetWorldTransform(/* _In_ */ IntPtr hdc, /* _Out_ */ out tagXFORM lpxf);
        
        [DllImport("gdi32")]
        public static extern bool GradientFill(/* _In_ */ IntPtr hdc, /* _In_reads_(nVertex) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] _TRIVERTEX[] pVertex, /* _In_ */ uint nVertex, /* _In_ */ IntPtr pMesh, /* _In_ */ uint nMesh, /* _In_ */ uint ulMode);
        
        [DllImport("gdi32")]
        public static extern void IntersectClipRect(/* _In_ */ IntPtr hdc, /* _In_ */ int left, /* _In_ */ int top, /* _In_ */ int right, /* _In_ */ int bottom);
        
        [DllImport("gdi32")]
        public static extern bool InvertRgn(/* _In_ */ IntPtr hdc, /* _In_ */ IntPtr hrgn);
        
        [DllImport("gdi32")]
        public static extern bool LineDDA(/* _In_ */ int xStart, /* _In_ */ int yStart, /* _In_ */ int xEnd, /* _In_ */ int yEnd, /* _In_ */ ref LINEDDAPROC lpProc, /* _In_opt_ */ long data);
        
        [DllImport("gdi32")]
        public static extern bool LineTo(/* _In_ */ IntPtr hdc, /* _In_ */ int x, /* _In_ */ int y);
        
        [DllImport("gdi32")]
        public static extern bool LPtoDP(/* _In_ */ IntPtr hdc, /* _Inout_updates_(c) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagPOINT[] lppt, /* _In_ */ int c);
        
        [DllImport("gdi32")]
        public static extern bool MaskBlt(/* _In_ */ IntPtr hdcDest, /* _In_ */ int xDest, /* _In_ */ int yDest, /* _In_ */ int width, /* _In_ */ int height, /* _In_ */ IntPtr hdcSrc, /* _In_ */ int xSrc, /* _In_ */ int ySrc, /* _In_ */ IntPtr hbmMask, /* _In_ */ int xMask, /* _In_ */ int yMask, /* _In_ */ uint rop);
        
        [DllImport("gdi32")]
        public static extern bool ModifyWorldTransform(/* _In_ */ IntPtr hdc, /* optional(tagXFORM) */ IntPtr lpxf, /* _In_ */ uint mode);
        
        [DllImport("gdi32")]
        public static extern bool MoveToEx(/* _In_ */ IntPtr hdc, /* _In_ */ int x, /* _In_ */ int y, /* _Out_opt_ */ out tagPOINT lppt);
        
        [DllImport("gdi32")]
        public static extern void OffsetClipRgn(/* _In_ */ IntPtr hdc, /* _In_ */ int x, /* _In_ */ int y);
        
        [DllImport("gdi32")]
        public static extern void OffsetRgn(/* _In_ */ IntPtr hrgn, /* _In_ */ int x, /* _In_ */ int y);
        
        [DllImport("gdi32")]
        public static extern bool OffsetViewportOrgEx(/* _In_ */ IntPtr hdc, /* _In_ */ int x, /* _In_ */ int y, /* _Out_opt_ */ out tagPOINT lppt);
        
        [DllImport("gdi32")]
        public static extern bool OffsetWindowOrgEx(/* _In_ */ IntPtr hdc, /* _In_ */ int x, /* _In_ */ int y, /* _Out_opt_ */ out tagPOINT lppt);
        
        [DllImport("gdi32")]
        public static extern bool PaintRgn(/* _In_ */ IntPtr hdc, /* _In_ */ IntPtr hrgn);
        
        [DllImport("gdi32")]
        public static extern bool PatBlt(/* _In_ */ IntPtr hdc, /* _In_ */ int x, /* _In_ */ int y, /* _In_ */ int w, /* _In_ */ int h, /* _In_ */ uint rop);
        
        [DllImport("gdi32")]
        public static extern IntPtr PathToRegion(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern bool Pie(/* _In_ */ IntPtr hdc, /* _In_ */ int left, /* _In_ */ int top, /* _In_ */ int right, /* _In_ */ int bottom, /* _In_ */ int xr1, /* _In_ */ int yr1, /* _In_ */ int xr2, /* _In_ */ int yr2);
        
        [DllImport("gdi32")]
        public static extern bool PlayEnhMetaFile(/* _In_ */ IntPtr hdc, /* _In_ */ IntPtr hmf, /* _In_ */ ref tagRECT lprect);
        
        [DllImport("gdi32")]
        public static extern bool PlayEnhMetaFileRecord(/* _In_ */ IntPtr hdc, /* _In_reads_(cht) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] tagHANDLETABLE[] pht, /* _In_ */ ref tagENHMETARECORD pmr, /* _In_ */ uint cht);
        
        [DllImport("gdi32")]
        public static extern bool PlayMetaFile(/* _In_ */ IntPtr hdc, /* _In_ */ IntPtr hmf);
        
        [DllImport("gdi32")]
        public static extern bool PlayMetaFileRecord(/* _In_ */ IntPtr hdc, /* _In_reads_(noObjs) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] tagHANDLETABLE[] lpHandleTable, /* _In_ */ ref LPMETARECORD lpMR, /* _In_ */ uint noObjs);
        
        [DllImport("gdi32")]
        public static extern bool PlgBlt(/* _In_ */ IntPtr hdcDest, /* _In_reads_(3) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] tagPOINT[] lpPoint, /* _In_ */ IntPtr hdcSrc, /* _In_ */ int xSrc, /* _In_ */ int ySrc, /* _In_ */ int width, /* _In_ */ int height, /* optional(HBITMAP__) */ IntPtr hbmMask, /* _In_ */ int xMask, /* _In_ */ int yMask);
        
        [DllImport("gdi32")]
        public static extern bool PolyBezier(/* _In_ */ IntPtr hdc, /* _In_reads_(cpt) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagPOINT[] apt, /* _In_ */ uint cpt);
        
        [DllImport("gdi32")]
        public static extern bool PolyBezierTo(/* _In_ */ IntPtr hdc, /* _In_reads_(cpt) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagPOINT[] apt, /* _In_ */ uint cpt);
        
        [DllImport("gdi32")]
        public static extern bool PolyDraw(/* _In_ */ IntPtr hdc, /* _In_reads_(cpt) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] tagPOINT[] apt, /* _In_reads_(cpt) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] aj, /* _In_ */ int cpt);
        
        [DllImport("gdi32")]
        public static extern bool Polygon(/* _In_ */ IntPtr hdc, /* _In_reads_(cpt) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagPOINT[] apt, /* _In_ */ int cpt);
        
        [DllImport("gdi32")]
        public static extern bool Polyline(/* _In_ */ IntPtr hdc, /* _In_reads_(cpt) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagPOINT[] apt, /* _In_ */ int cpt);
        
        [DllImport("gdi32")]
        public static extern bool PolylineTo(/* _In_ */ IntPtr hdc, /* _In_reads_(cpt) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagPOINT[] apt, /* _In_ */ uint cpt);
        
        [DllImport("gdi32")]
        public static extern bool PolyPolygon(/* _In_ */ IntPtr hdc, /* _In_ */ ref tagPOINT apt, /* _In_reads_(csz) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] int[] asz, /* _In_ */ int csz);
        
        [DllImport("gdi32")]
        public static extern bool PolyPolyline(/* _In_ */ IntPtr hdc, /* _In_ */ ref tagPOINT apt, /* _In_reads_(csz) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] uint[] asz, /* _In_ */ uint csz);
        
        [DllImport("gdi32")]
        public static extern bool PolyTextOutA(/* _In_ */ IntPtr hdc, /* _In_reads_(nstrings) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagPOLYTEXTA[] ppt, /* _In_ */ int nstrings);
        
        [DllImport("gdi32")]
        public static extern bool PolyTextOutW(/* _In_ */ IntPtr hdc, /* _In_reads_(nstrings) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagPOLYTEXTW[] ppt, /* _In_ */ int nstrings);
        
        [DllImport("gdi32")]
        public static extern bool PtInRegion(/* _In_ */ IntPtr hrgn, /* _In_ */ int x, /* _In_ */ int y);
        
        [DllImport("gdi32")]
        public static extern bool PtVisible(/* _In_ */ IntPtr hdc, /* _In_ */ int x, /* _In_ */ int y);
        
        [DllImport("gdi32")]
        public static extern uint RealizePalette(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern bool Rectangle(/* _In_ */ IntPtr hdc, /* _In_ */ int left, /* _In_ */ int top, /* _In_ */ int right, /* _In_ */ int bottom);
        
        [DllImport("gdi32")]
        public static extern bool RectInRegion(/* _In_ */ IntPtr hrgn, /* _In_ */ ref tagRECT lprect);
        
        [DllImport("gdi32")]
        public static extern bool RectVisible(/* _In_ */ IntPtr hdc, /* _In_ */ ref tagRECT lprect);
        
        [DllImport("gdi32")]
        public static extern bool RemoveFontMemResourceEx(/* _In_ */ IntPtr h);
        
        [DllImport("gdi32")]
        public static extern bool RemoveFontResourceA(/* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
        
        [DllImport("gdi32")]
        public static extern bool RemoveFontResourceExA(/* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string name, /* _In_ */ uint fl, /* _Reserved_ */ ref IntPtr pdv);
        
        [DllImport("gdi32")]
        public static extern bool RemoveFontResourceExW(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string name, /* _In_ */ uint fl, /* _Reserved_ */ ref IntPtr pdv);
        
        [DllImport("gdi32")]
        public static extern bool RemoveFontResourceW(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
        
        [DllImport("gdi32")]
        public static extern IntPtr ResetDCA(/* _In_ */ IntPtr hdc, /* _In_ */ ref _devicemodeA lpdm);
        
        [DllImport("gdi32")]
        public static extern IntPtr ResetDCW(/* _In_ */ IntPtr hdc, /* _In_ */ ref _devicemodeW lpdm);
        
        [DllImport("gdi32")]
        public static extern bool ResizePalette(/* _In_ */ IntPtr hpal, /* _In_ */ uint n);
        
        [DllImport("gdi32")]
        public static extern bool RestoreDC(/* _In_ */ IntPtr hdc, /* _In_ */ int nSavedDC);
        
        [DllImport("gdi32")]
        public static extern bool RoundRect(/* _In_ */ IntPtr hdc, /* _In_ */ int left, /* _In_ */ int top, /* _In_ */ int right, /* _In_ */ int bottom, /* _In_ */ int width, /* _In_ */ int height);
        
        [DllImport("gdi32")]
        public static extern void SaveDC(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern bool ScaleViewportExtEx(/* _In_ */ IntPtr hdc, /* _In_ */ int xn, /* _In_ */ int dx, /* _In_ */ int yn, /* _In_ */ int yd, /* _Out_opt_ */ out tagSIZE lpsz);
        
        [DllImport("gdi32")]
        public static extern bool ScaleWindowExtEx(/* _In_ */ IntPtr hdc, /* _In_ */ int xn, /* _In_ */ int xd, /* _In_ */ int yn, /* _In_ */ int yd, /* _Out_opt_ */ out tagSIZE lpsz);
        
        [DllImport("gdi32")]
        public static extern bool SelectClipPath(/* _In_ */ IntPtr hdc, /* _In_ */ int mode);
        
        [DllImport("gdi32")]
        public static extern void SelectClipRgn(/* _In_ */ IntPtr hdc, /* optional(HRGN) */ IntPtr hrgn);
        
        [DllImport("gdi32")]
        public static extern IntPtr SelectObject(/* _In_ */ IntPtr hdc, /* _In_ */ IntPtr h);
        
        [DllImport("gdi32")]
        public static extern IntPtr SelectPalette(/* _In_ */ IntPtr hdc, /* _In_ */ IntPtr hPal, /* _In_ */ bool bForceBkgd);
        
        [DllImport("gdi32")]
        public static extern void SetAbortProc(/* _In_ */ IntPtr hdc, /* _In_ */ ref ABORTPROC proc);
        
        [DllImport("gdi32")]
        public static extern void SetArcDirection(/* _In_ */ IntPtr hdc, /* _In_ */ int dir);
        
        [DllImport("gdi32")]
        public static extern int SetBitmapBits(/* _In_ */ IntPtr hbm, /* _In_ */ uint cb, /* _In_reads_bytes_(cb) */ IntPtr pvBits);
        
        [DllImport("gdi32")]
        public static extern bool SetBitmapDimensionEx(/* _In_ */ IntPtr hbm, /* _In_ */ int w, /* _In_ */ int h, /* _Out_opt_ */ out tagSIZE lpsz);
        
        [DllImport("gdi32")]
        public static extern uint SetBkColor(/* _In_ */ IntPtr hdc, /* _In_ */ uint color);
        
        [DllImport("gdi32")]
        public static extern void SetBkMode(/* _In_ */ IntPtr hdc, /* _In_ */ int mode);
        
        [DllImport("gdi32")]
        public static extern uint SetBoundsRect(/* _In_ */ IntPtr hdc, /* optional(tagRECT) */ IntPtr lprect, /* _In_ */ uint flags);
        
        [DllImport("gdi32")]
        public static extern bool SetBrushOrgEx(/* _In_ */ IntPtr hdc, /* _In_ */ int x, /* _In_ */ int y, /* _Out_opt_ */ out tagPOINT lppt);
        
        [DllImport("gdi32")]
        public static extern bool SetColorAdjustment(/* _In_ */ IntPtr hdc, /* _In_ */ ref tagCOLORADJUSTMENT lpca);
        
        [DllImport("gdi32")]
        public static extern IntPtr SetColorSpace(/* _In_ */ IntPtr hdc, /* _In_ */ IntPtr hcs);
        
        [DllImport("gdi32")]
        public static extern uint SetDCBrushColor(/* _In_ */ IntPtr hdc, /* _In_ */ uint color);
        
        [DllImport("gdi32")]
        public static extern uint SetDCPenColor(/* _In_ */ IntPtr hdc, /* _In_ */ uint color);
        
        [DllImport("gdi32")]
        public static extern bool SetDeviceGammaRamp(/* _In_ */ IntPtr hdc, /* _In_reads_bytes_(3*256*2) */ [MarshalAs(UnmanagedType.LPArray)] IntPtr[] lpRamp);
        
        [DllImport("gdi32")]
        public static extern uint SetDIBColorTable(/* _In_ */ IntPtr hdc, /* _In_ */ uint iStart, /* _In_ */ uint cEntries, /* _In_reads_(cEntries) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagRGBQUAD[] prgbq);
        
        [DllImport("gdi32")]
        public static extern void SetDIBits(/* optional(HDC__) */ IntPtr hdc, /* _In_ */ IntPtr hbm, /* _In_ */ uint start, /* _In_ */ uint cLines, /* _In_ */ IntPtr lpBits, /* _In_ */ ref tagBITMAPINFO lpbmi, /* _In_ */ uint ColorUse);
        
        [DllImport("gdi32")]
        public static extern void SetDIBitsToDevice(/* _In_ */ IntPtr hdc, /* _In_ */ int xDest, /* _In_ */ int yDest, /* _In_ */ uint w, /* _In_ */ uint h, /* _In_ */ int xSrc, /* _In_ */ int ySrc, /* _In_ */ uint StartScan, /* _In_ */ uint cLines, /* _In_ */ IntPtr lpvBits, /* _In_ */ ref tagBITMAPINFO lpbmi, /* _In_ */ uint ColorUse);
        
        [DllImport("gdi32")]
        public static extern IntPtr SetEnhMetaFileBits(/* _In_ */ uint nSize, /* _In_reads_bytes_(nSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] byte[] pb);
        
        [DllImport("gdi32")]
        public static extern void SetGraphicsMode(/* _In_ */ IntPtr hdc, /* _In_ */ int iMode);
        
        [DllImport("gdi32")]
        public static extern void SetICMMode(/* _In_ */ IntPtr hdc, /* _In_ */ int mode);
        
        [DllImport("gdi32")]
        public static extern bool SetICMProfileA(/* _In_ */ IntPtr hdc, /* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
        
        [DllImport("gdi32")]
        public static extern bool SetICMProfileW(/* _In_ */ IntPtr hdc, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
        
        [DllImport("gdi32")]
        public static extern uint SetLayout(/* _In_ */ IntPtr hdc, /* _In_ */ uint l);
        
        [DllImport("gdi32")]
        public static extern void SetMapMode(/* _In_ */ IntPtr hdc, /* _In_ */ int iMode);
        
        [DllImport("gdi32")]
        public static extern uint SetMapperFlags(/* _In_ */ IntPtr hdc, /* _In_ */ uint flags);
        
        [DllImport("gdi32")]
        public static extern IntPtr SetMetaFileBitsEx(/* _In_ */ uint cbBuffer, /* _In_reads_bytes_(cbBuffer) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] byte[] lpData);
        
        [DllImport("gdi32")]
        public static extern void SetMetaRgn(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern bool SetMiterLimit(/* _In_ */ IntPtr hdc, /* _In_ */ float limit, /* _Out_opt_ */ out float old);
        
        [DllImport("gdi32")]
        public static extern uint SetPaletteEntries(/* _In_ */ IntPtr hpal, /* _In_ */ uint iStart, /* _In_ */ uint cEntries, /* _In_reads_(cEntries) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagPALETTEENTRY[] pPalEntries);
        
        [DllImport("gdi32")]
        public static extern uint SetPixel(/* _In_ */ IntPtr hdc, /* _In_ */ int x, /* _In_ */ int y, /* _In_ */ uint color);
        
        [DllImport("gdi32")]
        public static extern bool SetPixelFormat(/* _In_ */ IntPtr hdc, /* _In_ */ int format, /* _In_ */ ref tagPIXELFORMATDESCRIPTOR ppfd);
        
        [DllImport("gdi32")]
        public static extern bool SetPixelV(/* _In_ */ IntPtr hdc, /* _In_ */ int x, /* _In_ */ int y, /* _In_ */ uint color);
        
        [DllImport("gdi32")]
        public static extern void SetPolyFillMode(/* _In_ */ IntPtr hdc, /* _In_ */ int mode);
        
        [DllImport("gdi32")]
        public static extern bool SetRectRgn(/* _In_ */ IntPtr hrgn, /* _In_ */ int left, /* _In_ */ int top, /* _In_ */ int right, /* _In_ */ int bottom);
        
        [DllImport("gdi32")]
        public static extern void SetROP2(/* _In_ */ IntPtr hdc, /* _In_ */ int rop2);
        
        [DllImport("gdi32")]
        public static extern void SetStretchBltMode(/* _In_ */ IntPtr hdc, /* _In_ */ int mode);
        
        [DllImport("gdi32")]
        public static extern uint SetSystemPaletteUse(/* _In_ */ IntPtr hdc, /* _In_ */ uint use);
        
        [DllImport("gdi32")]
        public static extern uint SetTextAlign(/* _In_ */ IntPtr hdc, /* _In_ */ uint align);
        
        [DllImport("gdi32")]
        public static extern void SetTextCharacterExtra(/* _In_ */ IntPtr hdc, /* _In_ */ int extra);
        
        [DllImport("gdi32")]
        public static extern uint SetTextColor(/* _In_ */ IntPtr hdc, /* _In_ */ uint color);
        
        [DllImport("gdi32")]
        public static extern bool SetTextJustification(/* _In_ */ IntPtr hdc, /* _In_ */ int extra, /* _In_ */ int count);
        
        [DllImport("gdi32")]
        public static extern bool SetViewportExtEx(/* _In_ */ IntPtr hdc, /* _In_ */ int x, /* _In_ */ int y, /* _Out_opt_ */ out tagSIZE lpsz);
        
        [DllImport("gdi32")]
        public static extern bool SetViewportOrgEx(/* _In_ */ IntPtr hdc, /* _In_ */ int x, /* _In_ */ int y, /* _Out_opt_ */ out tagPOINT lppt);
        
        [DllImport("gdi32")]
        public static extern bool SetWindowExtEx(/* _In_ */ IntPtr hdc, /* _In_ */ int x, /* _In_ */ int y, /* _Out_opt_ */ out tagSIZE lpsz);
        
        [DllImport("gdi32")]
        public static extern bool SetWindowOrgEx(/* _In_ */ IntPtr hdc, /* _In_ */ int x, /* _In_ */ int y, /* _Out_opt_ */ out tagPOINT lppt);
        
        [DllImport("gdi32")]
        public static extern IntPtr SetWinMetaFileBits(/* _In_ */ uint nSize, /* _In_reads_bytes_(nSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] byte[] lpMeta16Data, /* optional(HDC__) */ IntPtr hdcRef, /* optional(tagMETAFILEPICT) */ IntPtr lpMFP);
        
        [DllImport("gdi32")]
        public static extern bool SetWorldTransform(/* _In_ */ IntPtr hdc, /* _In_ */ ref tagXFORM lpxf);
        
        [DllImport("gdi32")]
        public static extern void StartDocA(/* _In_ */ IntPtr hdc, /* _In_ */ ref _DOCINFOA lpdi);
        
        [DllImport("gdi32")]
        public static extern void StartDocW(/* _In_ */ IntPtr hdc, /* _In_ */ ref _DOCINFOW lpdi);
        
        [DllImport("gdi32")]
        public static extern void StartPage(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern bool StretchBlt(/* _In_ */ IntPtr hdcDest, /* _In_ */ int xDest, /* _In_ */ int yDest, /* _In_ */ int wDest, /* _In_ */ int hDest, /* optional(HDC__) */ IntPtr hdcSrc, /* _In_ */ int xSrc, /* _In_ */ int ySrc, /* _In_ */ int wSrc, /* _In_ */ int hSrc, /* _In_ */ uint rop);
        
        [DllImport("gdi32")]
        public static extern void StretchDIBits(/* _In_ */ IntPtr hdc, /* _In_ */ int xDest, /* _In_ */ int yDest, /* _In_ */ int DestWidth, /* _In_ */ int DestHeight, /* _In_ */ int xSrc, /* _In_ */ int ySrc, /* _In_ */ int SrcWidth, /* _In_ */ int SrcHeight, /* optional(void) */ IntPtr lpBits, /* _In_ */ ref tagBITMAPINFO lpbmi, /* _In_ */ uint iUsage, /* _In_ */ uint rop);
        
        [DllImport("gdi32")]
        public static extern bool StrokeAndFillPath(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern bool StrokePath(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern bool SwapBuffers(IntPtr __unnamed_0);
        
        [DllImport("gdi32")]
        public static extern bool TextOutA(/* _In_ */ IntPtr hdc, /* _In_ */ int x, /* _In_ */ int y, /* _In_reads_(c) */ [MarshalAs(UnmanagedType.LPStr)] string lpString, /* _In_ */ int c);
        
        [DllImport("gdi32")]
        public static extern bool TextOutW(/* _In_ */ IntPtr hdc, /* _In_ */ int x, /* _In_ */ int y, /* _In_reads_(c) */ [MarshalAs(UnmanagedType.LPWStr)] string lpString, /* _In_ */ int c);
        
        [DllImport("gdi32")]
        public static extern bool TranslateCharsetInfo(/* _Inout_ */ ref uint lpSrc, /* _Out_ */ out tagCHARSETINFO lpCs, /* _In_ */ uint dwFlags);
        
        [DllImport("gdi32")]
        public static extern bool TransparentBlt(/* _In_ */ IntPtr hdcDest, /* _In_ */ int xoriginDest, /* _In_ */ int yoriginDest, /* _In_ */ int wDest, /* _In_ */ int hDest, /* _In_ */ IntPtr hdcSrc, /* _In_ */ int xoriginSrc, /* _In_ */ int yoriginSrc, /* _In_ */ int wSrc, /* _In_ */ int hSrc, /* _In_ */ uint crTransparent);
        
        [DllImport("gdi32")]
        public static extern bool UnrealizeObject(/* _In_ */ IntPtr h);
        
        [DllImport("gdi32")]
        public static extern bool UpdateColors(/* _In_ */ IntPtr hdc);
        
        [DllImport("gdi32")]
        public static extern bool UpdateICMRegKeyA(/* _Reserved_ */ uint reserved, /* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string lpszCMID, /* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string lpszFileName, /* _In_ */ uint command);
        
        [DllImport("gdi32")]
        public static extern bool UpdateICMRegKeyW(/* _Reserved_ */ uint reserved, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string lpszCMID, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string lpszFileName, /* _In_ */ uint command);
        
        [DllImport("gdi32")]
        public static extern bool wglCopyContext(IntPtr __unnamed_0, IntPtr __unnamed_1, uint __unnamed_2);
        
        [DllImport("gdi32")]
        public static extern IntPtr wglCreateContext(IntPtr __unnamed_0);
        
        [DllImport("gdi32")]
        public static extern IntPtr wglCreateLayerContext(IntPtr __unnamed_0, int __unnamed_1);
        
        [DllImport("gdi32")]
        public static extern bool wglDeleteContext(IntPtr __unnamed_0);
        
        [DllImport("gdi32")]
        public static extern bool wglDescribeLayerPlane(IntPtr __unnamed_0, int __unnamed_1, int __unnamed_2, uint __unnamed_3, ref tagLAYERPLANEDESCRIPTOR __unnamed_4);
        
        [DllImport("gdi32")]
        public static extern IntPtr wglGetCurrentContext();
        
        [DllImport("gdi32")]
        public static extern IntPtr wglGetCurrentDC();
        
        [DllImport("gdi32")]
        public static extern void wglGetLayerPaletteEntries(IntPtr __unnamed_0, int __unnamed_1, int __unnamed_2, int __unnamed_3, ref COLORREF __unnamed_4);
        
        [DllImport("gdi32")]
        public static extern PROC wglGetProcAddress([MarshalAs(UnmanagedType.LPStr)] string __unnamed_0);
        
        [DllImport("gdi32")]
        public static extern bool wglMakeCurrent(IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [DllImport("gdi32")]
        public static extern bool wglRealizeLayerPalette(IntPtr __unnamed_0, int __unnamed_1, bool __unnamed_2);
        
        [DllImport("gdi32")]
        public static extern void wglSetLayerPaletteEntries(IntPtr __unnamed_0, int __unnamed_1, int __unnamed_2, int __unnamed_3, ref COLORREF __unnamed_4);
        
        [DllImport("gdi32")]
        public static extern bool wglShareLists(IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [DllImport("gdi32")]
        public static extern bool wglSwapLayerBuffers(IntPtr __unnamed_0, uint __unnamed_1);
        
        [DllImport("gdi32")]
        public static extern uint wglSwapMultipleBuffers(uint __unnamed_0, ref _WGLSWAP __unnamed_1);
        
        [DllImport("gdi32")]
        public static extern bool wglUseFontBitmapsA(IntPtr __unnamed_0, uint __unnamed_1, uint __unnamed_2, uint __unnamed_3);
        
        [DllImport("gdi32")]
        public static extern bool wglUseFontBitmapsW(IntPtr __unnamed_0, uint __unnamed_1, uint __unnamed_2, uint __unnamed_3);
        
        [DllImport("gdi32")]
        public static extern bool wglUseFontOutlinesA(IntPtr __unnamed_0, uint __unnamed_1, uint __unnamed_2, uint __unnamed_3, float __unnamed_4, float __unnamed_5, int __unnamed_6, ref _GLYPHMETRICSFLOAT __unnamed_7);
        
        [DllImport("gdi32")]
        public static extern bool wglUseFontOutlinesW(IntPtr __unnamed_0, uint __unnamed_1, uint __unnamed_2, uint __unnamed_3, float __unnamed_4, float __unnamed_5, int __unnamed_6, ref _GLYPHMETRICSFLOAT __unnamed_7);
        
        [DllImport("gdi32")]
        public static extern bool WidenPath(/* _In_ */ IntPtr hdc);
        
        [DllImport("wmcodecdsp")]
        public static extern HRESULT CreateFileIo(/* out */ out IFileIo ppFileIo);
        
        [DllImport("wmcodecdsp")]
        public static extern HRESULT CreateToc(/* out */ out IToc ppTableOfContents);
        
        [DllImport("wmcodecdsp")]
        public static extern HRESULT CreateTocCollection(/* out */ out ITocCollection ppTocCollection);
        
        [DllImport("wmcodecdsp")]
        public static extern HRESULT CreateTocEntry(/* out */ out ITocEntry ppTocEntry);
        
        [DllImport("wmcodecdsp")]
        public static extern HRESULT CreateTocEntryList(/* out */ out ITocEntryList ppTocEntryList);
        
        [DllImport("wmcodecdsp")]
        public static extern HRESULT CreateTocParser(/* out */ out ITocParser ppTocParser);
        
        [DllImport("mf")]
        public static extern HRESULT MFCreateASFContentInfo(/* out */ out IMFASFContentInfo ppIContentInfo);
        
        [DllImport("mf")]
        public static extern HRESULT MFCreateASFIndexer(/* out */ out IMFASFIndexer ppIIndexer);
        
        [DllImport("mf")]
        public static extern HRESULT MFCreateASFIndexerByteStream(/* in */ IMFByteStream pIContentByteStream, /* in */ ulong cbIndexStartOffset, /* out */ out IMFByteStream pIIndexByteStream);
        
        [DllImport("mf")]
        public static extern HRESULT MFCreateASFMediaSink(IMFByteStream pIByteStream, out IMFMediaSink ppIMediaSink);
        
        [DllImport("mf")]
        public static extern HRESULT MFCreateASFMediaSinkActivate([MarshalAs(UnmanagedType.LPWStr)] string pwszFileName, IMFASFContentInfo pContentInfo, out IMFActivate ppIActivate);
        
        [DllImport("mf")]
        public static extern HRESULT MFCreateASFMultiplexer(/* out */ out IMFASFMultiplexer ppIMultiplexer);
        
        [DllImport("mf")]
        public static extern HRESULT MFCreateASFProfile(/* out */ out IMFASFProfile ppIProfile);
        
        [DllImport("mf")]
        public static extern HRESULT MFCreateASFProfileFromPresentationDescriptor(/* in */ IMFPresentationDescriptor pIPD, /* out */ out IMFASFProfile ppIProfile);
        
        [DllImport("mf")]
        public static extern HRESULT MFCreateASFSplitter(/* out */ out IMFASFSplitter ppISplitter);
        
        [DllImport("mf")]
        public static extern HRESULT MFCreateASFStreamingMediaSink(IMFByteStream pIByteStream, out IMFMediaSink ppIMediaSink);
        
        [DllImport("mf")]
        public static extern HRESULT MFCreateASFStreamingMediaSinkActivate(IMFActivate pByteStreamActivate, IMFASFContentInfo pContentInfo, out IMFActivate ppIActivate);
        
        [DllImport("mf")]
        public static extern HRESULT MFCreateASFStreamSelector(/* in */ IMFASFProfile pIASFProfile, /* out */ out IMFASFStreamSelector ppSelector);
        
        [DllImport("mf")]
        public static extern HRESULT MFCreatePresentationDescriptorFromASFProfile(/* in */ IMFASFProfile pIProfile, /* out */ out IMFPresentationDescriptor ppIPD);
        
        [DllImport("mf")]
        public static extern HRESULT MFCreateWMAEncoderActivate(IMFMediaType pMediaType, ref IPropertyStore pEncodingConfigurationProperties, out IMFActivate ppActivate);
        
        [DllImport("mf")]
        public static extern HRESULT MFCreateWMVEncoderActivate(IMFMediaType pMediaType, ref IPropertyStore pEncodingConfigurationProperties, out IMFActivate ppActivate);
        
        [DllImport("wmpdevices")]
        public static extern bool WMPNotifyDeviceArrival();
        
        [DllImport("wmpdevices")]
        public static extern bool WMPNotifyDeviceRemoval();
        
        [DllImport("wmpplug")]
        public static extern bool WMPNotifyPluginAddRemove();
        
        [DllImport("wmvcore")]
        public static extern HRESULT WMCreateBackupRestorer([MarshalAs(UnmanagedType.IUnknown)] object pCallback, out IWMLicenseBackup ppBackup);
        
        [DllImport("wmvcore")]
        public static extern HRESULT WMCreateDeviceRegistration(out IWMDeviceRegistration ppDevReg);
        
        [DllImport("wmvcore")]
        public static extern HRESULT WMCreateDRMTranscryptionManager(out IWMDRMTranscryptionManager ppTranscryptionManager);
        
        [DllImport("wmvcore")]
        public static extern HRESULT WMCreateDRMTranscryptor(out IWMDRMTranscryptor ppTranscryptor);
        
        [DllImport("wmvcore")]
        public static extern HRESULT WMCreateEditor(out IWMMetadataEditor ppEditor);
        
        [DllImport("wmvcore")]
        public static extern HRESULT WMCreateIndexer(out IWMIndexer ppIndexer);
        
        [DllImport("wmvcore")]
        public static extern HRESULT WMCreateLicenseRevocationAgent([MarshalAs(UnmanagedType.IUnknown)] object pCallback, out IWMLicenseRevocationAgent ppLicenseRevocationAgent);
        
        [DllImport("wmvcore")]
        public static extern HRESULT WMCreateProfileManager(out IWMProfileManager ppProfileManager);
        
        [DllImport("wmvcore")]
        public static extern HRESULT WMCreateReader([MarshalAs(UnmanagedType.IUnknown)] object pUnkCert, uint dwRights, out IWMReader ppReader);
        
        [DllImport("wmvcore")]
        public static extern HRESULT WMCreateSyncReader([MarshalAs(UnmanagedType.IUnknown)] object pUnkCert, uint dwRights, out IWMSyncReader ppSyncReader);
        
        [DllImport("wmvcore")]
        public static extern HRESULT WMCreateWriter([MarshalAs(UnmanagedType.IUnknown)] object pUnkCert, out IWMWriter ppWriter);
        
        [DllImport("wmvcore")]
        public static extern HRESULT WMCreateWriterFileSink(out IWMWriterFileSink ppSink);
        
        [DllImport("wmvcore")]
        public static extern HRESULT WMCreateWriterNetworkSink(out IWMWriterNetworkSink ppSink);
        
        [DllImport("wmvcore")]
        public static extern HRESULT WMCreateWriterPushSink(out IWMWriterPushSink ppSink);
        
        [DllImport("wmvcore")]
        public static extern HRESULT WMIsContentProtected([MarshalAs(UnmanagedType.LPWStr)] string pwszFileName, ref bool pfIsProtected);
        
        [DllImport("wmvcore")]
        public static extern HRESULT WMCheckURLExtension(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszURL);
        
        [DllImport("wmvcore")]
        public static extern HRESULT WMCheckURLScheme(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszURLScheme);
        
        [DllImport("wmvcore")]
        public static extern HRESULT WMIsAvailableOffline(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszURL, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszLanguage, /* [out] */ out bool pfIsAvailableOffline);
        
        [DllImport("wmvcore")]
        public static extern HRESULT WMValidateData(/* [in] */ ref byte pbData, /* [in, out] */ ref uint pdwDataSize);
        
        [DllImport("wmvcore")]
        public static extern HRESULT WMCreateSecureChannel(out IWMSecureChannel ppChannel);
        
        [DllImport("wmvcore")]
        public static extern HRESULT WMCreateSecureChannel_Certified(out IWMSecureChannel ppChannel);
        
        [DllImport("wmvcore")]
        public static extern HRESULT WMCreateSecureChannel_Certified_DES(out IWMSecureChannel ppChannel);
        
        [DllImport("wmvcore")]
        public static extern HRESULT WMCreateSecureChannel_DES(out IWMSecureChannel ppChannel);
    }
}
