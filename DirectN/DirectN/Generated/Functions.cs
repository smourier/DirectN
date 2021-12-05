using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using AM_MEDIA_TYPE = DirectN._AMMediaType;
using FNAPONOTIFICATIONCALLBACK = System.IntPtr;
using COMPOSITION_FRAME_ID = System.UInt64;
using LPD3DHAL_CALLBACKS = DirectN._D3DHAL_CALLBACKS;
using LPD3DHAL_GLOBALDRIVERDATA = DirectN._D3DHAL_GLOBALDRIVERDATA;
using LUID = DirectN._LUID;
using MFASYNC_WORKQUEUE_TYPE = DirectN.MF;
using MFPERIODICCALLBACK = System.IntPtr;
using MFWORKITEM_KEY = System.UInt64;
using MPEG1VIDEOINFO = DirectN.tagMPEG1VIDEOINFO;
using MPEG2VIDEOINFO = DirectN.tagMPEG2VIDEOINFO;
using PDXVAHDSW_Plugin = System.IntPtr;
using SECURITY_ATTRIBUTES = DirectN._SECURITY_ATTRIBUTES;
using VIDEOINFOHEADER = DirectN.tagVIDEOINFOHEADER;
using VIDEOINFOHEADER2 = DirectN.tagVIDEOINFOHEADER2;

namespace DirectN
{
    public static partial class Functions
    {
        [DllImport("d3d9", ExactSpelling = true)]
        public static extern void D3DPERF_BeginEvent(uint col, [MarshalAs(UnmanagedType.LPWStr)] string wszName);

        [DllImport("d3d9", ExactSpelling = true)]
        public static extern void D3DPERF_EndEvent();

        [DllImport("d3d9", ExactSpelling = true)]
        public static extern uint D3DPERF_GetStatus();

        [DllImport("d3d9", ExactSpelling = true)]
        public static extern bool D3DPERF_QueryRepeatFrame();

        [DllImport("d3d9", ExactSpelling = true)]
        public static extern void D3DPERF_SetMarker(uint col, [MarshalAs(UnmanagedType.LPWStr)] string wszName);

        [DllImport("d3d9", ExactSpelling = true)]
        public static extern void D3DPERF_SetOptions(uint dwOptions);

        [DllImport("d3d9", ExactSpelling = true)]
        public static extern void D3DPERF_SetRegion(uint col, [MarshalAs(UnmanagedType.LPWStr)] string wszName);

        /// <summary>
        /// ******************* /* D3D9Ex interfaces /********************
        /// </summary>
        [DllImport("d3d9", ExactSpelling = true)]
        public static extern HRESULT Direct3DCreate9Ex(uint SDKVersion, out IDirect3D9Ex unnamed__1);

        [DllImport("dxgi", ExactSpelling = true)]
        public static extern HRESULT DXGIDeclareAdapterRemovalSupport();

        [DllImport("audiomediatype", ExactSpelling = true)]
        public static extern HRESULT CreateAudioMediaType(ref tWAVEFORMATEX pAudioFormat, uint cbAudioFormatSize, out IAudioMediaType ppIAudioMediaType);

        [DllImport("audiomediatype", ExactSpelling = true)]
        public static extern HRESULT CreateAudioMediaTypeFromUncompressedAudioFormat(ref _UNCOMPRESSEDAUDIOFORMAT pUncompressedAudioFormat, out IAudioMediaType ppIAudioMediaType);

        [DllImport("d3d11", ExactSpelling = true)]
        public static extern HRESULT D3D11On12CreateDevice(/* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pDevice, uint Flags, /* _In_reads_opt_( FeatureLevels ) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] D3D_FEATURE_LEVEL[] pFeatureLevels, int FeatureLevels, /* _In_reads_opt_( NumQueues ) */ [MarshalAs(UnmanagedType.IUnknown)] object ppCommandQueues, uint NumQueues, uint NodeMask, /* _COM_Outptr_opt_ */ out ID3D11Device ppDevice, /* _COM_Outptr_opt_ */ out ID3D11DeviceContext ppImmediateContext, /* optional(D3D_FEATURE_LEVEL) */ IntPtr pChosenFeatureLevel);

        [DllImport("D3DCompiler_47", ExactSpelling = true)]
        public static extern HRESULT D3DDisassemble11Trace(/* _In_reads_bytes_(SrcDataSize) */ IntPtr pSrcData, /* _In_ */ IntPtr SrcDataSize, /* _In_ */ ID3D11ShaderTrace pTrace, /* _In_ */ uint StartStep, /* _In_ */ uint NumSteps, /* _In_ */ uint Flags, /* _COM_Outptr_ */ out ID3D10Blob ppDisassembly);

        [DllImport("d3d9", ExactSpelling = true)]
        public static extern IDirect3D9 Direct3DCreate9(uint SDKVersion);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTAcquireKeyedMutex(/* _Inout_ */ ref _D3DKMT_ACQUIREKEYEDMUTEX unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTAcquireKeyedMutex2(/* _Inout_ */ ref _D3DKMT_ACQUIREKEYEDMUTEX2 unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTAdjustFullscreenGamma(/* _In_ */ ref _D3DKMT_ADJUSTFULLSCREENGAMMA unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTChangeSurfacePointer(/* _In_ */ ref _D3DKMT_CHANGESURFACEPOINTER unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTChangeVideoMemoryReservation(/* _In_ */ ref _D3DKMT_CHANGEVIDEOMMEMORYRESERVATION unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern byte D3DKMTCheckExclusiveOwnership();

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTCheckMonitorPowerState(/* _In_ */ ref _D3DKMT_CHECKMONITORPOWERSTATE unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTCheckMultiPlaneOverlaySupport(/* _Inout_ */ ref _D3DKMT_CHECKMULTIPLANEOVERLAYSUPPORT unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTCheckMultiPlaneOverlaySupport2(/* _Inout_ */ ref _D3DKMT_CHECKMULTIPLANEOVERLAYSUPPORT2 unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTCheckMultiPlaneOverlaySupport3(/* _Inout_ */ ref _D3DKMT_CHECKMULTIPLANEOVERLAYSUPPORT3 unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTCheckOcclusion(/* _In_ */ ref _D3DKMT_CHECKOCCLUSION unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTCheckSharedResourceAccess(/* _In_ */ ref _D3DKMT_CHECKSHAREDRESOURCEACCESS unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTCheckVidPnExclusiveOwnership(/* _In_ */ ref _D3DKMT_CHECKVIDPNEXCLUSIVEOWNERSHIP unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTCloseAdapter(/* _In_ */ ref _D3DKMT_CLOSEADAPTER unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTConfigureSharedResource(/* _In_ */ ref _D3DKMT_CONFIGURESHAREDRESOURCE unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTCreateAllocation(/* _Inout_ */ ref _D3DKMT_CREATEALLOCATION unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTCreateAllocation2(/* _Inout_ */ ref _D3DKMT_CREATEALLOCATION unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTCreateContext(/* _Inout_ */ ref _D3DKMT_CREATECONTEXT unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTCreateContextVirtual(/* _In_ */ ref _D3DKMT_CREATECONTEXTVIRTUAL unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTCreateDCFromMemory(/* _Inout_ */ ref _D3DKMT_CREATEDCFROMMEMORY unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTCreateDevice(/* _Inout_ */ ref _D3DKMT_CREATEDEVICE unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTCreateHwContext(/* _Inout_ */ ref _D3DKMT_CREATEHWCONTEXT unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTCreateHwQueue(/* _Inout_ */ ref _D3DKMT_CREATEHWQUEUE unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTCreateKeyedMutex(/* _Inout_ */ ref _D3DKMT_CREATEKEYEDMUTEX unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTCreateKeyedMutex2(/* _Inout_ */ ref _D3DKMT_CREATEKEYEDMUTEX2 unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTCreateOutputDupl(/* _In_ */ ref _D3DKMT_CREATE_OUTPUTDUPL unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTCreateOverlay(/* _Inout_ */ ref _D3DKMT_CREATEOVERLAY unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTCreatePagingQueue(/* _Inout_ */ ref _D3DKMT_CREATEPAGINGQUEUE unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTCreateProtectedSession(/* _Inout_ */ ref _D3DKMT_CREATEPROTECTEDSESSION unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTCreateSynchronizationObject(/* _Inout_ */ ref _D3DKMT_CREATESYNCHRONIZATIONOBJECT unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTCreateSynchronizationObject2(/* _Inout_ */ ref _D3DKMT_CREATESYNCHRONIZATIONOBJECT2 unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTDestroyAllocation(/* _In_ */ ref _D3DKMT_DESTROYALLOCATION unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTDestroyAllocation2(/* _In_ */ ref _D3DKMT_DESTROYALLOCATION2 unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTDestroyContext(/* _In_ */ ref _D3DKMT_DESTROYCONTEXT unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTDestroyDCFromMemory(/* _In_ */ ref _D3DKMT_DESTROYDCFROMMEMORY unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTDestroyDevice(/* _In_ */ ref _D3DKMT_DESTROYDEVICE unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTDestroyHwContext(/* _In_ */ ref _D3DKMT_DESTROYHWCONTEXT unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTDestroyHwQueue(/* _In_ */ ref _D3DKMT_DESTROYHWQUEUE unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTDestroyKeyedMutex(/* _In_ */ ref _D3DKMT_DESTROYKEYEDMUTEX unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTDestroyOutputDupl(/* _In_ */ ref _D3DKMT_DESTROY_OUTPUTDUPL unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTDestroyOverlay(/* _In_ */ ref _D3DKMT_DESTROYOVERLAY unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTDestroyPagingQueue(/* _Inout_ */ ref D3DDDI_DESTROYPAGINGQUEUE unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTDestroyProtectedSession(/* _Inout_ */ ref _D3DKMT_DESTROYPROTECTEDSESSION unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTDestroySynchronizationObject(/* _In_ */ ref _D3DKMT_DESTROYSYNCHRONIZATIONOBJECT unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTEnumAdapters(/* _Inout_ */ ref _D3DKMT_ENUMADAPTERS unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTEnumAdapters2(/* _Inout_ */ ref _D3DKMT_ENUMADAPTERS2 unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTEnumAdapters3(/* _Inout_ */ ref _D3DKMT_ENUMADAPTERS3 unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTEscape(/* _In_ */ ref _D3DKMT_ESCAPE unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTEvict(/* _Inout_ */ ref _D3DKMT_EVICT unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTFlipOverlay(/* _In_ */ ref _D3DKMT_FLIPOVERLAY unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTFlushHeapTransitions(/* _In_ */ ref _D3DKMT_FLUSHHEAPTRANSITIONS unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTFreeGpuVirtualAddress(/* _In_ */ ref _D3DKMT_FREEGPUVIRTUALADDRESS unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTGetAllocationPriority(/* _In_ */ ref _D3DKMT_GETALLOCATIONPRIORITY unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTGetContextInProcessSchedulingPriority(/* _Inout_ */ ref _D3DKMT_GETCONTEXTINPROCESSSCHEDULINGPRIORITY unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTGetContextSchedulingPriority(/* _Inout_ */ ref _D3DKMT_GETCONTEXTSCHEDULINGPRIORITY unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTGetDeviceState(/* _Inout_ */ ref _D3DKMT_GETDEVICESTATE unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTGetDisplayModeList(/* _Inout_ */ ref _D3DKMT_GETDISPLAYMODELIST unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTGetDWMVerticalBlankEvent(/* _In_ */ ref _D3DKMT_GETVERTICALBLANKEVENT unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTGetMultiPlaneOverlayCaps(/* _Inout_ */ ref _D3DKMT_GET_MULTIPLANE_OVERLAY_CAPS unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTGetMultisampleMethodList(/* _Inout_ */ ref _D3DKMT_GETMULTISAMPLEMETHODLIST unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTGetOverlayState(/* _Inout_ */ ref _D3DKMT_GETOVERLAYSTATE unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTGetPostCompositionCaps(/* _Inout_ */ ref _D3DKMT_GET_POST_COMPOSITION_CAPS unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTGetPresentHistory(/* _Inout_ */ ref _D3DKMT_GETPRESENTHISTORY unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTGetPresentQueueEvent(/* _In_ */ uint hAdapter, /* _Inout_ */ IntPtr unnamed__1);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTGetProcessDeviceRemovalSupport(/* _Inout_ */ ref _D3DKMT_GETPROCESSDEVICEREMOVALSUPPORT unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTGetProcessSchedulingPriorityClass(/* _In_ */ IntPtr unnamed__0, /* _Out_ */ out _D3DKMT_SCHEDULINGPRIORITYCLASS unnamed__1);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTGetResourcePresentPrivateDriverData(/* _Inout_ */ ref _D3DDDI_GETRESOURCEPRESENTPRIVATEDRIVERDATA unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTGetRuntimeData(/* _Inout_ */ ref _D3DKMT_GETRUNTIMEDATA unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTGetScanLine(/* _Inout_ */ ref _D3DKMT_GETSCANLINE unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTGetSharedPrimaryHandle(/* _Inout_ */ ref _D3DKMT_GETSHAREDPRIMARYHANDLE unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTGetSharedResourceAdapterLuid(/* _Inout_ */ ref _D3DKMT_GETSHAREDRESOURCEADAPTERLUID unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTInvalidateActiveVidPn(/* _In_ */ ref _D3DKMT_INVALIDATEACTIVEVIDPN unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTInvalidateCache(/* _In_ */ ref _D3DKMT_INVALIDATECACHE unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTLock(/* _Inout_ */ ref _D3DKMT_LOCK unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTLock2(/* _Inout_ */ ref _D3DKMT_LOCK2 unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTMakeResident(/* _Inout_ */ ref D3DDDI_MAKERESIDENT unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTMapGpuVirtualAddress(/* _Inout_ */ ref D3DDDI_MAPGPUVIRTUALADDRESS unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTMarkDeviceAsError(/* _In_ */ ref _D3DKMT_MARKDEVICEASERROR unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTOfferAllocations(/* _In_ */ ref _D3DKMT_OFFERALLOCATIONS unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTOpenAdapterFromDeviceName(/* _Inout_ */ ref _D3DKMT_OPENADAPTERFROMDEVICENAME unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTOpenAdapterFromGdiDisplayName(/* _Inout_ */ ref _D3DKMT_OPENADAPTERFROMGDIDISPLAYNAME unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTOpenAdapterFromHdc(/* _Inout_ */ ref _D3DKMT_OPENADAPTERFROMHDC unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTOpenAdapterFromLuid(/* _Inout_ */ ref _D3DKMT_OPENADAPTERFROMLUID unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTOpenKeyedMutex(/* _Inout_ */ ref _D3DKMT_OPENKEYEDMUTEX unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTOpenKeyedMutex2(/* _Inout_ */ ref _D3DKMT_OPENKEYEDMUTEX2 unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTOpenKeyedMutexFromNtHandle(/* _Inout_ */ ref _D3DKMT_OPENKEYEDMUTEXFROMNTHANDLE unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTOpenNtHandleFromName(/* _Inout_ */ ref _D3DKMT_OPENNTHANDLEFROMNAME unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTOpenProtectedSessionFromNtHandle(/* _Inout_ */ ref _D3DKMT_OPENPROTECTEDSESSIONFROMNTHANDLE unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTOpenResource(/* _Inout_ */ ref _D3DKMT_OPENRESOURCE unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTOpenResource2(/* _Inout_ */ ref _D3DKMT_OPENRESOURCE unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTOpenResourceFromNtHandle(/* _Inout_ */ ref _D3DKMT_OPENRESOURCEFROMNTHANDLE unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTOpenSynchronizationObject(/* _Inout_ */ ref _D3DKMT_OPENSYNCHRONIZATIONOBJECT unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTOpenSyncObjectFromNtHandle(/* _Inout_ */ ref _D3DKMT_OPENSYNCOBJECTFROMNTHANDLE unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTOpenSyncObjectFromNtHandle2(/* _Inout_ */ ref _D3DKMT_OPENSYNCOBJECTFROMNTHANDLE2 unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTOpenSyncObjectNtHandleFromName(/* _Inout_ */ ref _D3DKMT_OPENSYNCOBJECTNTHANDLEFROMNAME unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTOutputDuplGetFrameInfo(/* _Inout_ */ ref _D3DKMT_OUTPUTDUPL_GET_FRAMEINFO unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTOutputDuplGetMetaData(/* _Inout_ */ ref _D3DKMT_OUTPUTDUPL_METADATA unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTOutputDuplGetPointerShapeData(/* _Inout_ */ ref _D3DKMT_OUTPUTDUPL_GET_POINTER_SHAPE_DATA unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTOutputDuplPresent(/* _In_ */ ref _D3DKMT_OUTPUTDUPLPRESENT unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTOutputDuplPresentToHwQueue(/* _In_ */ ref _D3DKMT_OUTPUTDUPLPRESENTTOHWQUEUE unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTOutputDuplReleaseFrame(/* _Inout_ */ ref _D3DKMT_OUTPUTDUPL_RELEASE_FRAME unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTPollDisplayChildren(/* _In_ */ ref _D3DKMT_POLLDISPLAYCHILDREN unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTPresent(/* _Inout_ */ ref _D3DKMT_PRESENT unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTPresentMultiPlaneOverlay(/* _In_ */ ref D3DKMT_PRESENT_MULTIPLANE_OVERLAY unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTPresentMultiPlaneOverlay2(/* _In_ */ ref _D3DKMT_PRESENT_MULTIPLANE_OVERLAY2 unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTPresentMultiPlaneOverlay3(/* _In_ */ ref _D3DKMT_PRESENT_MULTIPLANE_OVERLAY3 unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTPresentRedirected(/* _In_ */ ref _D3DKMT_PRESENT_REDIRECTED unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTQueryAdapterInfo(/* _Inout_ */ ref _D3DKMT_QUERYADAPTERINFO unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTQueryAllocationResidency(/* _In_ */ ref _D3DKMT_QUERYALLOCATIONRESIDENCY unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTQueryClockCalibration(/* _Inout_ */ ref _D3DKMT_QUERYCLOCKCALIBRATION unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTQueryFSEBlock(/* _Inout_ */ ref _D3DKMT_QUERYFSEBLOCK unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTQueryProcessOfferInfo(/* _Inout_ */ ref _D3DKMT_QUERYPROCESSOFFERINFO unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTQueryProtectedSessionInfoFromNtHandle(/* _Inout_ */ ref _D3DKMT_QUERYPROTECTEDSESSIONINFOFROMNTHANDLE unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTQueryProtectedSessionStatus(/* _Inout_ */ ref _D3DKMT_QUERYPROTECTEDSESSIONSTATUS unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTQueryRemoteVidPnSourceFromGdiDisplayName(/* _Inout_ */ ref _D3DKMT_QUERYREMOTEVIDPNSOURCEFROMGDIDISPLAYNAME unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTQueryResourceInfo(/* _Inout_ */ ref _D3DKMT_QUERYRESOURCEINFO unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTQueryResourceInfoFromNtHandle(/* _Inout_ */ ref _D3DKMT_QUERYRESOURCEINFOFROMNTHANDLE unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTQueryVideoMemoryInfo(/* _Inout_ */ ref _D3DKMT_QUERYVIDEOMEMORYINFO unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTQueryVidPnExclusiveOwnership(/* _Inout_ */ ref _D3DKMT_QUERYVIDPNEXCLUSIVEOWNERSHIP unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTReclaimAllocations(/* _Inout_ */ ref _D3DKMT_RECLAIMALLOCATIONS unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTReclaimAllocations2(/* _Inout_ */ ref _D3DKMT_RECLAIMALLOCATIONS2 unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTRegisterTrimNotification(/* _Inout_ */ ref _D3DKMT_REGISTERTRIMNOTIFICATION unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTReleaseKeyedMutex(/* _Inout_ */ ref _D3DKMT_RELEASEKEYEDMUTEX unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTReleaseKeyedMutex2(/* _Inout_ */ ref _D3DKMT_RELEASEKEYEDMUTEX2 unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTReleaseProcessVidPnSourceOwners(/* _In_ */ IntPtr unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTRender(/* _Inout_ */ ref _D3DKMT_RENDER unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTReserveGpuVirtualAddress(/* _Inout_ */ ref D3DDDI_RESERVEGPUVIRTUALADDRESS unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTSetAllocationPriority(/* _In_ */ ref _D3DKMT_SETALLOCATIONPRIORITY unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTSetContextInProcessSchedulingPriority(/* _In_ */ ref _D3DKMT_SETCONTEXTINPROCESSSCHEDULINGPRIORITY unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTSetContextSchedulingPriority(/* _In_ */ ref _D3DKMT_SETCONTEXTSCHEDULINGPRIORITY unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTSetDisplayMode(/* _Inout_ */ ref _D3DKMT_SETDISPLAYMODE unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTSetDisplayPrivateDriverFormat(/* _In_ */ ref _D3DKMT_SETDISPLAYPRIVATEDRIVERFORMAT unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTSetFSEBlock(/* _In_ */ ref _D3DKMT_SETFSEBLOCK unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTSetGammaRamp(/* _In_ */ ref _D3DKMT_SETGAMMARAMP unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTSetHwProtectionTeardownRecovery(/* _In_ */ ref _D3DKMT_SETHWPROTECTIONTEARDOWNRECOVERY unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTSetMonitorColorSpaceTransform(/* _In_ */ ref _D3DKMT_SET_COLORSPACE_TRANSFORM unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTSetProcessSchedulingPriorityClass(/* _In_ */ IntPtr unnamed__0, /* _In_ */ _D3DKMT_SCHEDULINGPRIORITYCLASS unnamed__1);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTSetQueuedLimit(/* _In_ */ ref _D3DKMT_SETQUEUEDLIMIT unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTSetStablePowerState(/* _In_ */ ref _D3DKMT_SETSTABLEPOWERSTATE unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTSetSyncRefreshCountWaitTarget(/* _In_ */ ref _D3DKMT_SETSYNCREFRESHCOUNTWAITTARGET unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTSetVidPnSourceHwProtection(/* _In_ */ ref _D3DKMT_SETVIDPNSOURCEHWPROTECTION unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTSetVidPnSourceOwner(/* _In_ */ ref _D3DKMT_SETVIDPNSOURCEOWNER unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTSetVidPnSourceOwner1(/* _In_ */ ref _D3DKMT_SETVIDPNSOURCEOWNER1 unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTSetVidPnSourceOwner2(/* _In_ */ ref _D3DKMT_SETVIDPNSOURCEOWNER2 unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTSharedPrimaryLockNotification(/* _In_ */ ref _D3DKMT_SHAREDPRIMARYLOCKNOTIFICATION unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTSharedPrimaryUnLockNotification(/* _In_ */ ref _D3DKMT_SHAREDPRIMARYUNLOCKNOTIFICATION unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTShareObjects(/* _In_range_(1, D3DKMT_MAX_OBJECTS_PER_HANDLE) */ int cObjects, /* _In_reads_(cObjects) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] uint[] hObjects, /* _In_ */ IntPtr pObjectAttributes, /* _In_ */ uint dwDesiredAccess, /* _Out_ */ out IntPtr phSharedNtHandle);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTSignalSynchronizationObject(/* _In_ */ ref _D3DKMT_SIGNALSYNCHRONIZATIONOBJECT unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTSignalSynchronizationObject2(/* _In_ */ ref _D3DKMT_SIGNALSYNCHRONIZATIONOBJECT2 unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTSignalSynchronizationObjectFromCpu(/* _In_ */ ref _D3DKMT_SIGNALSYNCHRONIZATIONOBJECTFROMCPU unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTSignalSynchronizationObjectFromGpu(/* _In_ */ ref _D3DKMT_SIGNALSYNCHRONIZATIONOBJECTFROMGPU unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTSignalSynchronizationObjectFromGpu2(/* _In_ */ ref _D3DKMT_SIGNALSYNCHRONIZATIONOBJECTFROMGPU2 unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTSubmitCommand(/* _In_ */ ref _D3DKMT_SUBMITCOMMAND unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTSubmitCommandToHwQueue(/* _In_ */ ref _D3DKMT_SUBMITCOMMANDTOHWQUEUE unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTSubmitPresentBltToHwQueue(/* _In_ */ ref _D3DKMT_SUBMITPRESENTBLTTOHWQUEUE unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTSubmitPresentToHwQueue(/* _Inout_ */ ref _D3DKMT_SUBMITPRESENTTOHWQUEUE unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTSubmitSignalSyncObjectsToHwQueue(/* _In_ */ ref _D3DKMT_SUBMITSIGNALSYNCOBJECTSTOHWQUEUE unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTSubmitWaitForSyncObjectsToHwQueue(/* _In_ */ ref _D3DKMT_SUBMITWAITFORSYNCOBJECTSTOHWQUEUE unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTTrimProcessCommitment(/* _Inout_ */ ref _D3DKMT_TRIMPROCESSCOMMITMENT unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTUnlock(/* _In_ */ ref _D3DKMT_UNLOCK unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTUnlock2(/* _In_ */ ref _D3DKMT_UNLOCK2 unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTUnregisterTrimNotification(/* _Inout_ */ ref _D3DKMT_UNREGISTERTRIMNOTIFICATION unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTUpdateAllocationProperty(/* _Inout_ */ ref D3DDDI_UPDATEALLOCPROPERTY unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTUpdateGpuVirtualAddress(/* _In_ */ ref _D3DKMT_UPDATEGPUVIRTUALADDRESS unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTUpdateOverlay(/* _In_ */ ref _D3DKMT_UPDATEOVERLAY unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTWaitForIdle(/* IN */ ref _D3DKMT_WAITFORIDLE unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTWaitForSynchronizationObject(/* _In_ */ ref _D3DKMT_WAITFORSYNCHRONIZATIONOBJECT unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTWaitForSynchronizationObject2(/* _In_ */ ref _D3DKMT_WAITFORSYNCHRONIZATIONOBJECT2 unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTWaitForSynchronizationObjectFromCpu(/* _In_ */ ref _D3DKMT_WAITFORSYNCHRONIZATIONOBJECTFROMCPU unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTWaitForSynchronizationObjectFromGpu(/* _In_ */ ref _D3DKMT_WAITFORSYNCHRONIZATIONOBJECTFROMGPU unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTWaitForVerticalBlankEvent(/* _In_ */ ref _D3DKMT_WAITFORVERTICALBLANKEVENT unnamed__0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int D3DKMTWaitForVerticalBlankEvent2(/* _In_ */ ref _D3DKMT_WAITFORVERTICALBLANKEVENT2 unnamed__0);

        [DllImport("Windows.Media.MediaControl", ExactSpelling = true)]
        public static extern HRESULT CreateCaptureAudioStateMonitor(/* _Outptr_ */ out IAudioStateMonitor audioStateMonitor);

        [DllImport("Windows.Media.MediaControl", ExactSpelling = true)]
        public static extern HRESULT CreateCaptureAudioStateMonitorForCategory(/* _In_ */ _AUDIO_STREAM_CATEGORY category, /* _Outptr_ */ out IAudioStateMonitor audioStateMonitor);

        [DllImport("Windows.Media.MediaControl", ExactSpelling = true)]
        public static extern HRESULT CreateCaptureAudioStateMonitorForCategoryAndDeviceId(/* _In_ */ _AUDIO_STREAM_CATEGORY category, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string deviceId, /* _Outptr_ */ out IAudioStateMonitor audioStateMonitor);

        [DllImport("Windows.Media.MediaControl", ExactSpelling = true)]
        public static extern HRESULT CreateCaptureAudioStateMonitorForCategoryAndDeviceRole(/* _In_ */ _AUDIO_STREAM_CATEGORY category, /* _In_ */ int role, /* _Outptr_ */ out IAudioStateMonitor audioStateMonitor);

        /// <summary>
        /// ************************************************************************
        /// </summary>
        [DllImport("Windows.Media.MediaControl", ExactSpelling = true)]
        public static extern HRESULT CreateRenderAudioStateMonitor(/* _Outptr_ */ out IAudioStateMonitor audioStateMonitor);

        [DllImport("Windows.Media.MediaControl", ExactSpelling = true)]
        public static extern HRESULT CreateRenderAudioStateMonitorForCategory(/* _In_ */ _AUDIO_STREAM_CATEGORY category, /* _Outptr_ */ out IAudioStateMonitor audioStateMonitor);

        [DllImport("Windows.Media.MediaControl", ExactSpelling = true)]
        public static extern HRESULT CreateRenderAudioStateMonitorForCategoryAndDeviceId(/* _In_ */ _AUDIO_STREAM_CATEGORY category, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string deviceId, /* _Outptr_ */ out IAudioStateMonitor audioStateMonitor);

        [DllImport("Windows.Media.MediaControl", ExactSpelling = true)]
        public static extern HRESULT CreateRenderAudioStateMonitorForCategoryAndDeviceRole(/* _In_ */ _AUDIO_STREAM_CATEGORY category, /* _In_ */ int role, /* _Outptr_ */ out IAudioStateMonitor audioStateMonitor);

        [DllImport("d3d9", ExactSpelling = true)]
        public static extern IDirect3D9 Direct3DCreate9On12(uint SDKVersion, ref _D3D9ON12_ARGS pOverrideList, uint NumOverrideEntries);

        [DllImport("d3d9", ExactSpelling = true)]
        public static extern HRESULT Direct3DCreate9On12Ex(uint SDKVersion, ref _D3D9ON12_ARGS pOverrideList, uint NumOverrideEntries, out IDirect3D9Ex ppOutputInterface);

        [DllImport("D3DCompiler_47", ExactSpelling = true)]
        public static extern HRESULT D3DCompile(/* _In_reads_bytes_(SrcDataSize) */ IntPtr pSrcData, /* _In_ */ IntPtr SrcDataSize, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string pSourceName, /* _In_reads_opt_(_Inexpressible_(pDefines->Name != NULL)) */ [MarshalAs(UnmanagedType.LPArray)] _D3D_SHADER_MACRO[] pDefines, /* _In_opt_ */ ID3DInclude pInclude, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string pEntrypoint, /* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pTarget, /* _In_ */ uint Flags1, /* _In_ */ uint Flags2, /* _Out_ */ out ID3D10Blob ppCode, /* _Always_(_Outptr_opt_result_maybenull_) */ out ID3D10Blob ppErrorMsgs);

        [DllImport("D3DCompiler_47", ExactSpelling = true)]
        public static extern HRESULT D3DCompile2(/* _In_reads_bytes_(SrcDataSize) */ IntPtr pSrcData, /* _In_ */ IntPtr SrcDataSize, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string pSourceName, /* _In_reads_opt_(_Inexpressible_(pDefines->Name != NULL)) */ [MarshalAs(UnmanagedType.LPArray)] _D3D_SHADER_MACRO[] pDefines, /* _In_opt_ */ ID3DInclude pInclude, /* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pEntrypoint, /* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pTarget, /* _In_ */ uint Flags1, /* _In_ */ uint Flags2, /* _In_ */ uint SecondaryDataFlags, /* optional(LPCVOID) */ IntPtr pSecondaryData, /* _In_ */ IntPtr SecondaryDataSize, /* _Out_ */ out ID3D10Blob ppCode, /* _Always_(_Outptr_opt_result_maybenull_) */ out ID3D10Blob ppErrorMsgs);

        [DllImport("D3DCompiler_47", ExactSpelling = true)]
        public static extern HRESULT D3DCompileFromFile(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pFileName, /* _In_reads_opt_(_Inexpressible_(pDefines->Name != NULL)) */ [MarshalAs(UnmanagedType.LPArray)] _D3D_SHADER_MACRO[] pDefines, /* _In_opt_ */ ID3DInclude pInclude, /* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pEntrypoint, /* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pTarget, /* _In_ */ uint Flags1, /* _In_ */ uint Flags2, /* _Out_ */ out ID3D10Blob ppCode, /* _Always_(_Outptr_opt_result_maybenull_) */ out ID3D10Blob ppErrorMsgs);

        [DllImport("D3DCompiler_47", ExactSpelling = true)]
        public static extern HRESULT D3DCompressShaders(/* _In_ */ int uNumShaders, /* _In_reads_(uNumShaders) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] _D3D_SHADER_DATA[] pShaderData, /* _In_ */ uint uFlags, /* _Out_ */ out ID3D10Blob ppCompressedData);

        [DllImport("D3DCompiler_47", ExactSpelling = true)]
        public static extern HRESULT D3DCreateBlob(/* _In_ */ IntPtr Size, /* _Out_ */ out ID3D10Blob ppBlob);

        [DllImport("D3DCompiler_47", ExactSpelling = true)]
        public static extern HRESULT D3DCreateFunctionLinkingGraph(/* _In_ */ uint uFlags, /* _Out_ */ out ID3D11FunctionLinkingGraph ppFunctionLinkingGraph);

        [DllImport("D3DCompiler_47", ExactSpelling = true)]
        public static extern HRESULT D3DCreateLinker(/* __out */ out ID3D11Linker ppLinker);

        [DllImport("D3DCompiler_47", ExactSpelling = true)]
        public static extern HRESULT D3DDecompressShaders(/* _In_reads_bytes_(SrcDataSize) */ IntPtr pSrcData, /* _In_ */ IntPtr SrcDataSize, /* _In_ */ int uNumShaders, /* _In_ */ uint uStartIndex, /* _In_reads_opt_(uNumShaders) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] uint[] pIndices, /* _In_ */ uint uFlags, /* _Out_writes_(uNumShaders) */ out IntPtr ppShaders, /* optional(UINT) */ IntPtr pTotalShaders);

        [DllImport("D3DCompiler_47", ExactSpelling = true)]
        public static extern HRESULT D3DDisassemble(/* _In_reads_bytes_(SrcDataSize) */ IntPtr pSrcData, /* _In_ */ IntPtr SrcDataSize, /* _In_ */ uint Flags, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string szComments, /* _Out_ */ out ID3D10Blob ppDisassembly);

        [DllImport("D3DCompiler_47", ExactSpelling = true)]
        public static extern HRESULT D3DDisassemble10Effect(/* _In_ */ ID3D10Effect pEffect, /* _In_ */ uint Flags, /* _Out_ */ out ID3D10Blob ppDisassembly);

        [DllImport("D3DCompiler_47", ExactSpelling = true)]
        public static extern HRESULT D3DDisassembleRegion(/* _In_reads_bytes_(SrcDataSize) */ IntPtr pSrcData, /* _In_ */ IntPtr SrcDataSize, /* _In_ */ uint Flags, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string szComments, /* _In_ */ IntPtr StartByteOffset, /* _In_ */ IntPtr NumInsts, /* optional(SIZE_T) */ IntPtr pFinishByteOffset, /* _Out_ */ out ID3D10Blob ppDisassembly);

        [DllImport("D3DCompiler_47", ExactSpelling = true)]
        public static extern HRESULT D3DGetBlobPart(/* _In_reads_bytes_(SrcDataSize) */ IntPtr pSrcData, /* _In_ */ IntPtr SrcDataSize, /* _In_ */ D3D_BLOB_PART Part, /* _In_ */ uint Flags, /* _Out_ */ out ID3D10Blob ppPart);

        [DllImport("D3DCompiler_47", ExactSpelling = true)]
        public static extern HRESULT D3DGetDebugInfo(/* _In_reads_bytes_(SrcDataSize) */ IntPtr pSrcData, /* _In_ */ IntPtr SrcDataSize, /* _Out_ */ out ID3D10Blob ppDebugInfo);

        [DllImport("D3DCompiler_47", ExactSpelling = true)]
        public static extern HRESULT D3DGetInputAndOutputSignatureBlob(/* _In_reads_bytes_(SrcDataSize) */ IntPtr pSrcData, /* _In_ */ IntPtr SrcDataSize, /* _Out_ */ out ID3D10Blob ppSignatureBlob);

        [DllImport("D3DCompiler_47", ExactSpelling = true)]
        public static extern HRESULT D3DGetInputSignatureBlob(/* _In_reads_bytes_(SrcDataSize) */ IntPtr pSrcData, /* _In_ */ IntPtr SrcDataSize, /* _Out_ */ out ID3D10Blob ppSignatureBlob);

        [DllImport("D3DCompiler_47", ExactSpelling = true)]
        public static extern HRESULT D3DGetOutputSignatureBlob(/* _In_reads_bytes_(SrcDataSize) */ IntPtr pSrcData, /* _In_ */ IntPtr SrcDataSize, /* _Out_ */ out ID3D10Blob ppSignatureBlob);

        [DllImport("D3DCompiler_47", ExactSpelling = true)]
        public static extern HRESULT D3DGetTraceInstructionOffsets(/* _In_reads_bytes_(SrcDataSize) */ IntPtr pSrcData, /* _In_ */ IntPtr SrcDataSize, /* _In_ */ uint Flags, /* _In_ */ IntPtr StartInstIndex, /* _In_ */ IntPtr NumInsts, /* _Out_writes_to_opt_(NumInsts, min(NumInsts, *pTotalInsts)) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] IntPtr[] pOffsets, /* optional(SIZE_T) */ IntPtr pTotalInsts);

        [DllImport("D3DCompiler_47", ExactSpelling = true)]
        public static extern HRESULT D3DLoadModule(/* _In_ */ IntPtr pSrcData, /* _In_ */ IntPtr cbSrcDataSize, /* _Out_ */ out ID3D11Module ppModule);

        [DllImport("D3DCompiler_47", ExactSpelling = true)]
        public static extern HRESULT D3DPreprocess(/* _In_reads_bytes_(SrcDataSize) */ IntPtr pSrcData, /* _In_ */ IntPtr SrcDataSize, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string pSourceName, /* optional(_D3D_SHADER_MACRO) */ IntPtr pDefines, /* _In_opt_ */ ID3DInclude pInclude, /* _Out_ */ out ID3D10Blob ppCodeText, /* _Always_(_Outptr_opt_result_maybenull_) */ out ID3D10Blob ppErrorMsgs);

        [DllImport("D3DCompiler_47", ExactSpelling = true)]
        public static extern HRESULT D3DReadFileToBlob(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pFileName, /* _Out_ */ out ID3D10Blob ppContents);

        [DllImport("D3DCompiler_47", ExactSpelling = true)]
        public static extern HRESULT D3DReflect(/* _In_reads_bytes_(SrcDataSize) */ IntPtr pSrcData, /* _In_ */ IntPtr SrcDataSize, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pInterface, /* _Out_ */ out IntPtr ppReflector);

        [DllImport("D3DCompiler_47", ExactSpelling = true)]
        public static extern HRESULT D3DReflectLibrary(/* __in_bcount(SrcDataSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] pSrcData, /* __in */ IntPtr SrcDataSize, /* __in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* __out */ out IntPtr ppReflector);

        [DllImport("D3DCompiler_47", ExactSpelling = true)]
        public static extern HRESULT D3DSetBlobPart(/* _In_reads_bytes_(SrcDataSize) */ IntPtr pSrcData, /* _In_ */ IntPtr SrcDataSize, /* _In_ */ D3D_BLOB_PART Part, /* _In_ */ uint Flags, /* _In_reads_bytes_(PartSize) */ IntPtr pPart, /* _In_ */ IntPtr PartSize, /* _Out_ */ out ID3D10Blob ppNewShader);

        [DllImport("D3DCompiler_47", ExactSpelling = true)]
        public static extern HRESULT D3DStripShader(/* _In_reads_bytes_(BytecodeLength) */ IntPtr pShaderBytecode, /* _In_ */ IntPtr BytecodeLength, /* _In_ */ uint uStripFlags, /* _Out_ */ out ID3D10Blob ppStrippedBlob);

        [DllImport("D3DCompiler_47", ExactSpelling = true)]
        public static extern HRESULT D3DWriteBlobToFile(/* _In_ */ ID3D10Blob pBlob, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pFileName, /* _In_ */ bool bOverwrite);

        [DllImport("d3dcsx_42", ExactSpelling = true)]
        public static extern HRESULT D3DX11CreateFFT(ID3D11DeviceContext pDeviceContext, /* _In_ */ ref D3DX11_FFT_DESC pDesc, uint Flags, /* _Out_ */ out D3DX11_FFT_BUFFER_INFO pBufferInfo, /* _Out_ */ out ID3DX11FFT ppFFT);

        [DllImport("d3dcsx_42", ExactSpelling = true)]
        public static extern HRESULT D3DX11CreateFFT1DComplex(ID3D11DeviceContext pDeviceContext, uint X, uint Flags, /* _Out_ */ out D3DX11_FFT_BUFFER_INFO pBufferInfo, /* _Out_ */ out ID3DX11FFT ppFFT);

        [DllImport("d3dcsx_42", ExactSpelling = true)]
        public static extern HRESULT D3DX11CreateFFT1DReal(ID3D11DeviceContext pDeviceContext, uint X, uint Flags, /* _Out_ */ out D3DX11_FFT_BUFFER_INFO pBufferInfo, /* _Out_ */ out ID3DX11FFT ppFFT);

        [DllImport("d3dcsx_42", ExactSpelling = true)]
        public static extern HRESULT D3DX11CreateFFT2DComplex(ID3D11DeviceContext pDeviceContext, uint X, uint Y, uint Flags, /* _Out_ */ out D3DX11_FFT_BUFFER_INFO pBufferInfo, /* _Out_ */ out ID3DX11FFT ppFFT);

        [DllImport("d3dcsx_42", ExactSpelling = true)]
        public static extern HRESULT D3DX11CreateFFT2DReal(ID3D11DeviceContext pDeviceContext, uint X, uint Y, uint Flags, /* _Out_ */ out D3DX11_FFT_BUFFER_INFO pBufferInfo, /* _Out_ */ out ID3DX11FFT ppFFT);

        [DllImport("d3dcsx_42", ExactSpelling = true)]
        public static extern HRESULT D3DX11CreateFFT3DComplex(ID3D11DeviceContext pDeviceContext, uint X, uint Y, uint Z, uint Flags, /* _Out_ */ out D3DX11_FFT_BUFFER_INFO pBufferInfo, /* _Out_ */ out ID3DX11FFT ppFFT);

        [DllImport("d3dcsx_42", ExactSpelling = true)]
        public static extern HRESULT D3DX11CreateFFT3DReal(ID3D11DeviceContext pDeviceContext, uint X, uint Y, uint Z, uint Flags, /* _Out_ */ out D3DX11_FFT_BUFFER_INFO pBufferInfo, /* _Out_ */ out ID3DX11FFT ppFFT);

        [DllImport("d3dcsx_42", ExactSpelling = true)]
        public static extern HRESULT D3DX11CreateScan(/* _In_ */ ID3D11DeviceContext pDeviceContext, uint MaxElementScanSize, uint MaxScanCount, /* _Out_ */ out ID3DX11Scan ppScan);

        [DllImport("d3dcsx_42", ExactSpelling = true)]
        public static extern HRESULT D3DX11CreateSegmentedScan(/* _In_ */ ID3D11DeviceContext pDeviceContext, uint MaxElementScanSize, /* _Out_ */ out ID3DX11SegmentedScan ppScan);

        [DllImport("dcomp", ExactSpelling = true)]
        public static extern HRESULT DCompositionAttachMouseDragToHwnd(/* _In_ */ IDCompositionVisual visual, /* _In_ */ IntPtr hwnd, /* _In_ */ bool enable);

        [DllImport("dcomp", ExactSpelling = true)]
        public static extern HRESULT DCompositionAttachMouseWheelToHwnd(/* _In_ */ IDCompositionVisual visual, /* _In_ */ IntPtr hwnd, /* _In_ */ bool enable);

        [DllImport("dcomp", ExactSpelling = true)]
        public static extern HRESULT DCompositionBoostCompositorClock(/* _In_ */ bool enable);

        [DllImport("dcomp", ExactSpelling = true)]
        public static extern HRESULT DCompositionCreateDevice(/* _In_opt_ */ IDXGIDevice dxgiDevice, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid iid, /* _Outptr_ */ out IntPtr dcompositionDevice);

        [DllImport("dcomp", ExactSpelling = true)]
        public static extern HRESULT DCompositionCreateDevice2(/* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object renderingDevice, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid iid, /* _Outptr_ */ out IntPtr dcompositionDevice);

        [DllImport("dcomp", ExactSpelling = true)]
        public static extern HRESULT DCompositionCreateDevice3(/* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object renderingDevice, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid iid, /* _Outptr_ */ out IntPtr dcompositionDevice);

        [DllImport("dcomp", ExactSpelling = true)]
        public static extern HRESULT DCompositionCreateSurfaceHandle(/* _In_ */ uint desiredAccess, /* optional(SECURITY_ATTRIBUTES) */ IntPtr securityAttributes, /* _Out_ */ out IntPtr surfaceHandle);

        [DllImport("dcomp", ExactSpelling = true)]
        public static extern HRESULT DCompositionGetFrameId(/* _In_ */ COMPOSITION_FRAME_ID_TYPE frameIdType, /* _Out_ */ out COMPOSITION_FRAME_ID frameId);

        [DllImport("dcomp", ExactSpelling = true)]
        public static extern HRESULT DCompositionGetStatistics(/* _In_ */ ulong frameId, /* _Out_ */ out tagCOMPOSITION_FRAME_STATS frameStats, /* _In_ */ uint targetIdCount, /* _Out_writes_opt_(targetCount) */ [Out, MarshalAs(UnmanagedType.LPArray)] tagCOMPOSITION_TARGET_ID[] targetIds, /* optional(UINT) */ IntPtr actualTargetIdCount);

        [DllImport("dcomp", ExactSpelling = true)]
        public static extern HRESULT DCompositionGetTargetStatistics(/* _In_ */ ulong frameId, /* _In_ */ ref tagCOMPOSITION_TARGET_ID targetId, /* _Out_ */ out tagCOMPOSITION_TARGET_STATS targetStats);

        [DllImport("dcomp", ExactSpelling = true)]
        public static extern uint DCompositionWaitForCompositorClock(/* _In_range_(0, DCOMPOSITION_MAX_WAITFORCOMPOSITORCLOCK_OBJECTS) */ int count, /* _In_reads_opt_(count) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] IntPtr[] handles, /* _In_ */ uint timeoutInMs);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern bool GdiEntry1(int pDirectDrawGlobal, IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern bool GdiEntry10(int pDirectDrawGlobal, ref bool pbNewMode);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern bool GdiEntry11(int pSurfaceFrom, int pSurfaceTo);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern void GdiEntry12(int pSurface, int pSurfaceAttached);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern uint GdiEntry13();

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern IntPtr GdiEntry14(int pDDraw, int pSurface, bool bRelease);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern bool GdiEntry15(int pDDraw, IntPtr hdc, IntPtr lpGammaRamp);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern uint GdiEntry16(int pDDraw, int pDDSLcl1, int pDDSLcl2);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern bool GdiEntry2(int pDirectDrawGlobal, int pHalInfo, int pDDCallbacks, int pDDSurfaceCallbacks, int pDDPaletteCallbacks, ref LPD3DHAL_CALLBACKS pD3dCallbacks, ref LPD3DHAL_GLOBALDRIVERDATA pD3dDriverData, int pD3dBufferCallbacks, int pD3dTextureFormats, ref uint pdwFourCC, /* // Can be NULL */ int pvmList);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern bool GdiEntry3(int pDirectDrawGlobal);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern bool GdiEntry4(int pSurfaceLocal, bool bPrimarySurface);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern bool GdiEntry5(int pSurfaceLocal);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern bool GdiEntry6(int pSurfaceLocal, IntPtr hWnd);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern IntPtr GdiEntry7(int pSurfaceLocal, ref tagPALETTEENTRY pColorTable);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern bool GdiEntry8(int pSurfaceLocal);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern IntPtr GdiEntry9(IntPtr hdc, ref tagBITMAPINFO pbmi, uint iUsage, IntPtr ppvBits, IntPtr hSectionApp, uint dwOffset);

        /// <summary>
        /// Creates a single uninitialized object of the class associated with a specified CLSID.  <param name="rclsid"> The CLSID associated with the data and code that will be used to create the object. </param> <param name="riid"> A reference to the identifier of the interface to be used to communicate with the object. </param> <param name="ppv"> Address of pointer variable that receives the interface pointer requested in riid. Upon successful return, *ppv contains the requested interface pointer. Upon failure, *ppv contains NULL.</param> <remarks> While this function is similar to CoCreateInstance, there is no COM involvement. </remarks>
        /// </summary>
        [DllImport("dxilconv", ExactSpelling = true)]
        public static extern HRESULT DxcCreateInstance(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid rclsid, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Out_ */ out IntPtr ppv);

        [DllImport("dxilconv", ExactSpelling = true)]
        public static extern HRESULT DxcCreateInstance2(/* _In_ */ IMalloc pMalloc, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid rclsid, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Out_ */ out IntPtr ppv);

        [DllImport("dxcore", ExactSpelling = true)]
        public static extern HRESULT DXCoreCreateAdapterFactory([MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvFactory);

        [DllImport("dxgidebug", ExactSpelling = true)]
        public static extern HRESULT DXGIGetDebugInterface([MarshalAs(UnmanagedType.LPStruct)] Guid riid, IntPtr ppDebug);

        [DllImport("dxva2", ExactSpelling = true)]
        public static extern HRESULT DXVAHD_CreateDevice(/* _In_ */ IDirect3DDevice9Ex pD3DDevice, /* _In_ */ ref _DXVAHD_CONTENT_DESC pContentDesc, /* _In_ */ _DXVAHD_DEVICE_USAGE Usage, /* optional(PDXVAHDSW_Plugin) */ IntPtr pPlugin, /* _Outptr_ */ out IDXVAHD_Device ppDevice);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFAddPeriodicCallback(ref MFPERIODICCALLBACK Callback, [MarshalAs(UnmanagedType.IUnknown)] object pContext, /* optional(DWORD) */ IntPtr pdwKey);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFAllocateSerialWorkQueue(/* _In_ */ uint dwWorkQueue, /* _Out_ OUT */ out uint pdwWorkQueue);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFAllocateWorkQueue(/* _Out_ OUT */ out uint pdwWorkQueue);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFAllocateWorkQueueEx(/* _In_ */ MFASYNC_WORKQUEUE_TYPE WorkQueueType, /* _Out_ OUT */ out uint pdwWorkQueue);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFAverageTimePerFrameToFrameRate(/* _In_ */ ulong unAverageTimePerFrame, /* _Out_ */ out uint punNumerator, /* _Out_ */ out uint punDenominator);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFBeginCreateFile(__MIDL___MIDL_itf_mfobjects_0000_0017_0001 AccessMode, __MIDL___MIDL_itf_mfobjects_0000_0017_0002 OpenMode, __MIDL___MIDL_itf_mfobjects_0000_0017_0003 fFlags, [MarshalAs(UnmanagedType.LPWStr)] string pwszFilePath, IMFAsyncCallback pCallback, [MarshalAs(UnmanagedType.IUnknown)] object pState, /* _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppCancelCookie);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFBeginRegisterWorkQueueWithMMCSS(uint dwWorkQueueId, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string wszClass, uint dwTaskId, /* _In_ */ IMFAsyncCallback pDoneCallback, /* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pDoneState);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFBeginRegisterWorkQueueWithMMCSSEx(uint dwWorkQueueId, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string wszClass, uint dwTaskId, int lPriority, /* _In_ */ IMFAsyncCallback pDoneCallback, /* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pDoneState);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFBeginUnregisterWorkQueueWithMMCSS(uint dwWorkQueueId, /* _In_ */ IMFAsyncCallback pDoneCallback, /* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pDoneState);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCalculateBitmapImageSize(/* _In_reads_bytes_(cbBufSize) */ ref tagBITMAPINFOHEADER pBMIH, /* _In_ */ uint cbBufSize, /* _Out_ */ out uint pcbImageSize, /* optional(BOOL) */ IntPtr pbKnown);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCalculateImageSize(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidSubtype, /* _In_ */ uint unWidth, /* _In_ */ uint unHeight, /* _Out_ */ out uint pcbImageSize);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCancelCreateFile([MarshalAs(UnmanagedType.IUnknown)] object pCancelCookie);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCancelWorkItem(ulong Key);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCombineSamples(/* _In_ */ IMFSample pSample, /* _In_ */ IMFSample pSampleToAdd, /* _In_ */ uint dwMaxMergedDurationInMS, /* _Out_ */ out bool pMerged);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern bool MFCompareFullToPartialMediaType(/* _In_ */ IMFMediaType pMFTypeFull, /* _In_ */ IMFMediaType pMFTypePartial);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFConvertColorInfoFromDXVA(/* _Inout_ */ ref _MFVIDEOFORMAT pToFormat, /* _In_ */ uint dwFromDXVA);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFConvertColorInfoToDXVA(/* _Out_ */ out uint pdwToDXVA, /* _In_ */ ref _MFVIDEOFORMAT pFromFormat);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFConvertFromFP16Array(/* _Out_writes_(dwCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] float[] pDest, /* _In_reads_(dwCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ushort[] pSrc, int dwCount);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFConvertToFP16Array(/* _Out_writes_(dwCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ushort[] pDest, /* _In_reads_(dwCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] float[] pSrc, int dwCount);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCopyImage(/* _Out_writes_bytes_(_Inexpressible_(abs(lDestStride) * dwLines)) */ [In, Out, MarshalAs(UnmanagedType.LPArray)] byte[] pDest, int lDestStride, /* _In_reads_bytes_(_Inexpressible_(abs(lSrcStride) * dwLines)) */ [MarshalAs(UnmanagedType.LPArray)] byte[] pSrc, int lSrcStride, /* _Out_range_(<=, _Inexpressible_(min(abs(lSrcStride), abs(lDestStride)))) */ uint dwWidthInBytes, uint dwLines);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreate2DMediaBuffer(/* _In_ */ uint dwWidth, /* _In_ */ uint dwHeight, /* _In_ */ uint dwFourCC, /* _In_ */ bool fBottomUp, /* _Out_ */ out IMFMediaBuffer ppBuffer);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateAlignedMemoryBuffer(/* _In_ */ uint cbMaxLength, /* _In_ */ uint cbAligment, /* _Out_ */ out IMFMediaBuffer ppBuffer);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateAMMediaTypeFromMFMediaType(/* _In_ */ IMFMediaType pMFType, /* _In_ */ Guid guidFormatBlockType, /* _Inout_ */ ref AM_MEDIA_TYPE ppAMType);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateAsyncResult([MarshalAs(UnmanagedType.IUnknown)] object punkObject, IMFAsyncCallback pCallback, [MarshalAs(UnmanagedType.IUnknown)] object punkState, /* _Out_ */ out IMFAsyncResult ppAsyncResult);

        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////// Attributes //////////////////////////////////// /////////////////////////////////////////////////////////////////////////////
        /// </summary>
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateAttributes(/* _Out_ */ out IMFAttributes ppMFAttributes, /* _In_ */ uint cInitialSize);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateAudioMediaType(/* _In_ */ ref tWAVEFORMATEX pAudioFormat, /* _Out_ */ out IMFAudioMediaType ppIAudioMediaType);

        /// <summary>
        /// //////////////////////////// Collection //////////////////////////// /////////////////////////////////////////////////////////////////////////////
        /// </summary>
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateCollection(/* _Out_ */ out IMFCollection ppIMFCollection);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateDXGIDeviceManager(/* _Out_ */ out uint resetToken, /* _Outptr_ */ out IMFDXGIDeviceManager ppDeviceManager);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateDXGISurfaceBuffer(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object punkSurface, /* _In_ */ uint uSubresourceIndex, /* _In_ */ bool fBottomUpWhenLinear, /* _Outptr_ */ out IMFMediaBuffer ppBuffer);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateDXSurfaceBuffer(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object punkSurface, /* _In_ */ bool fBottomUpWhenLinear, /* _Outptr_ */ out IMFMediaBuffer ppBuffer);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateEventQueue(/* _Out_ */ out IMFMediaEventQueue ppMediaEventQueue);

        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////// ////////////////////////////// Files ////////////////////////////// ////////////////////////////////////////////////////////////////////////////
        /// </summary>
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateFile(__MIDL___MIDL_itf_mfobjects_0000_0017_0001 AccessMode, __MIDL___MIDL_itf_mfobjects_0000_0017_0002 OpenMode, __MIDL___MIDL_itf_mfobjects_0000_0017_0003 fFlags, [MarshalAs(UnmanagedType.LPWStr)] string pwszFileURL, /* _Out_ */ out IMFByteStream ppIByteStream);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateLegacyMediaBufferOnMFMediaBuffer(/* _In_opt_ */ IMFSample pSample, /* _In_ */ IMFMediaBuffer pMFMediaBuffer, /* _In_ */ uint cbOffset, /* _Outptr_ */ out IMediaBuffer ppMediaBuffer);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateMediaBufferFromMediaType(/* _In_ */ IMFMediaType pMediaType, /* _In_ */ long llDuration, /* needed for audio _In_ */ uint dwMinLength, /* // 0 means optimized default _In_ */ uint dwMinAlignment, /* // 0 means optimized default _Outptr_ */ out IMFMediaBuffer ppBuffer);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateMediaBufferWrapper(/* _In_ */ IMFMediaBuffer pBuffer, /* _In_ */ uint cbOffset, /* _In_ */ uint dwLength, /* _Out_ */ out IMFMediaBuffer ppBuffer);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateMediaEvent(/* _In_ */ uint met, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidExtendedType, /* _In_ */ HRESULT hrStatus, /* _In_opt_ */ [In, Out] PropVariant pvValue, /* _Out_ */ out IMFMediaEvent ppEvent);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateMediaExtensionActivate(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string szActivatableClassId, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pConfiguration, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Outptr_ */ out IntPtr ppvObject);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateMediaType(/* _Outptr_ */ out IMFMediaType ppMFType);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateMediaTypeFromRepresentation(Guid guidRepresentation, /* _In_ */ IntPtr pvRepresentation, /* _Out_ */ out IMFMediaType ppIMediaType);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateMemoryBuffer(/* _In_ */ uint cbMaxLength, /* _Out_ */ out IMFMediaBuffer ppBuffer);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateMFByteStreamWrapper(/* _In_ */ IMFByteStream pStream, /* _Out_ */ out IMFByteStream ppStreamWrapper);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateMFVideoFormatFromMFMediaType(/* _In_ */ IMFMediaType pMFType, /* _Out_ */ out IntPtr ppMFVF, /* optional(UINT32) */ IntPtr pcbSize);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateMuxStreamAttributes(/* _In_ */ IMFCollection pAttributesToMux, /* _COM_Outptr_ */ out IMFAttributes ppMuxAttribs);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateMuxStreamMediaType(/* _In_ */ IMFCollection pMediaTypesToMux, /* _COM_Outptr_ */ out IMFMediaType ppMuxMediaType);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateMuxStreamSample(/* _In_ */ IMFCollection pSamplesToMux, /* _COM_Outptr_ */ out IMFSample ppMuxSample);

        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////// //////////////////////////// Samples ////////////////////////////////////// /////////////////////////////////////////////////////////////////////////////
        /// </summary>
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateSample(/* _Out_ */ out IMFSample ppIMFSample);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateTempFile(__MIDL___MIDL_itf_mfobjects_0000_0017_0001 AccessMode, __MIDL___MIDL_itf_mfobjects_0000_0017_0002 OpenMode, __MIDL___MIDL_itf_mfobjects_0000_0017_0003 fFlags, /* _Out_ */ out IMFByteStream ppIByteStream);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateVideoMediaType(/* _In_ */ ref _MFVIDEOFORMAT pVideoFormat, /* _Out_ */ out IMFVideoMediaType ppIVideoMediaType);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateVideoMediaTypeFromBitMapInfoHeader(/* _In_ */ ref tagBITMAPINFOHEADER pbmihBitMapInfoHeader, uint dwPixelAspectRatioX, uint dwPixelAspectRatioY, _MFVideoInterlaceMode InterlaceMode, ulong VideoFlags, ulong qwFramesPerSecondNumerator, ulong qwFramesPerSecondDenominator, uint dwMaxBitRate, /* _Out_ */ out IMFVideoMediaType ppIVideoMediaType);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateVideoMediaTypeFromBitMapInfoHeaderEx(/* _In_reads_bytes_(cbBitMapInfoHeader) */ ref tagBITMAPINFOHEADER pbmihBitMapInfoHeader, /* _In_ */ uint cbBitMapInfoHeader, uint dwPixelAspectRatioX, uint dwPixelAspectRatioY, _MFVideoInterlaceMode InterlaceMode, ulong VideoFlags, uint dwFramesPerSecondNumerator, uint dwFramesPerSecondDenominator, uint dwMaxBitRate, /* _Out_ */ out IMFVideoMediaType ppIVideoMediaType);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateVideoMediaTypeFromSubtype(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pAMSubtype, /* _Out_ */ out IMFVideoMediaType ppIVideoMediaType);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateVideoSampleAllocatorEx(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Outptr_ */ out IntPtr ppSampleAllocator);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateWaveFormatExFromMFMediaType(/* _In_ */ IMFMediaType pMFType, /* _Out_ */ out IntPtr ppWF, /* optional(UINT32) */ IntPtr pcbSize, /* _In_ */ uint Flags);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateWICBitmapBuffer(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object punkSurface, /* _Outptr_ */ out IMFMediaBuffer ppBuffer);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFEndCreateFile(IMFAsyncResult pResult, /* _Out_ */ out IMFByteStream ppFile);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFEndRegisterWorkQueueWithMMCSS(/* _In_ */ IMFAsyncResult pResult, /* _Out_ */ out uint pdwTaskId);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFEndUnregisterWorkQueueWithMMCSS(/* _In_ */ IMFAsyncResult pResult);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFFrameRateToAverageTimePerFrame(/* _In_ */ uint unNumerator, /* _In_ */ uint unDenominator, /* _Out_ */ out ulong punAverageTimePerFrame);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFGetAttributesAsBlob(/* _In_ */ IMFAttributes pAttributes, /* _Out_writes_bytes_(cbBufSize) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] pBuf, /* _In_ */ int cbBufSize);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFGetAttributesAsBlobSize(/* _In_ */ IMFAttributes pAttributes, /* _Out_ */ out uint pcbBufSize);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFGetContentProtectionSystemCLSID(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidProtectionSystemID, /* _Out_ */ out Guid pclsid);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFGetMFTMerit(/* _Inout_ */ [MarshalAs(UnmanagedType.IUnknown)] object pMFT, /* _In_ */ int cbVerifier, /* _In_reads_bytes_(cbVerifier) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] verifier, /* _Out_ */ out uint merit);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFGetPlaneSize(uint format, uint dwWidth, uint dwHeight, /* _Out_ */ out uint pdwPlaneSize);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFGetPluginControl(/* _Out_ */ out IMFPluginControl ppPluginControl);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFGetStrideForBitmapInfoHeader(uint format, uint dwWidth, /* _Out_ */ out int pStride);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFGetTimerPeriodicity(/* _Out_ */ out uint Periodicity);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern uint MFGetUncompressedVideoFormat(/* _In_ */ ref _MFVIDEOFORMAT pVideoFormat);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFGetWorkQueueMMCSSClass(uint dwWorkQueueId, /* _Out_writes_to_opt_(*pcchClass,*pcchClass) */ [MarshalAs(UnmanagedType.LPWStr)] string pwszClass, /* _Inout_ */ ref uint pcchClass);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFGetWorkQueueMMCSSPriority(uint dwWorkQueueId, /* _Out_ */ out int lPriority);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFGetWorkQueueMMCSSTaskId(uint dwWorkQueueId, /* _Out_ */ out uint pdwTaskId);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern void MFHeapAlloc(ulong nSize, uint dwFlags, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string pszFile, int line, _EAllocationType eat);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern void MFHeapFree(IntPtr pv);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFInitAMMediaTypeFromMFMediaType(/* _In_ */ IMFMediaType pMFType, /* _In_ */ Guid guidFormatBlockType, /* _Inout_ */ ref AM_MEDIA_TYPE pAMType);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFInitAttributesFromBlob(/* _In_ */ IMFAttributes pAttributes, /* _In_reads_bytes_(cbBufSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] pBuf, /* _In_ */ int cbBufSize);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFInitMediaTypeFromAMMediaType(/* _In_ */ IMFMediaType pMFType, /* _In_ */ ref AM_MEDIA_TYPE pAMType);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFInitMediaTypeFromMFVideoFormat(/* _In_ */ IMFMediaType pMFType, /* _In_reads_bytes_(cbBufSize) */ ref _MFVIDEOFORMAT pMFVF, /* _In_ */ uint cbBufSize);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFInitMediaTypeFromMPEG1VideoInfo(/* _In_ */ IMFMediaType pMFType, /* _In_reads_bytes_(cbBufSize) */ ref MPEG1VIDEOINFO pMP1VI, /* _In_ */ uint cbBufSize, /* optional(GUID) */ IntPtr pSubtype);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFInitMediaTypeFromMPEG2VideoInfo(/* _In_ */ IMFMediaType pMFType, /* _In_reads_bytes_(cbBufSize) */ ref MPEG2VIDEOINFO pMP2VI, /* _In_ */ uint cbBufSize, /* optional(GUID) */ IntPtr pSubtype);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFInitMediaTypeFromVideoInfoHeader(/* _In_ */ IMFMediaType pMFType, /* _In_reads_bytes_(cbBufSize) */ ref VIDEOINFOHEADER pVIH, /* _In_ */ uint cbBufSize, /* optional(GUID) */ IntPtr pSubtype);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFInitMediaTypeFromVideoInfoHeader2(/* _In_ */ IMFMediaType pMFType, /* _In_reads_bytes_(cbBufSize) */ ref VIDEOINFOHEADER2 pVIH2, /* _In_ */ uint cbBufSize, /* optional(GUID) */ IntPtr pSubtype);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFInitMediaTypeFromWaveFormatEx(/* _In_ */ IMFMediaType pMFType, /* _In_reads_bytes_(cbBufSize) */ ref tWAVEFORMATEX pWaveFormat, /* _In_ */ uint cbBufSize);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFInitVideoFormat(/* _In_ */ ref _MFVIDEOFORMAT pVideoFormat, /* _In_ */ _MFStandardVideoFormat type);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFInitVideoFormat_RGB(/* _In_ */ ref _MFVIDEOFORMAT pVideoFormat, /* _In_ */ uint dwWidth, /* _In_ */ uint dwHeight, /* _In_ */ uint D3Dfmt);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFInvokeCallback(IMFAsyncResult pAsyncResult);

        [DllImport("evr", ExactSpelling = true)]
        public static extern bool MFIsFormatYUV(uint Format);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern long MFllMulDiv(long a, long b, long c, long d);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFLockDXGIDeviceManager(/* optional(UINT) */ IntPtr pResetToken, /* _Outptr_ */ out IMFDXGIDeviceManager ppManager);

        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////// ////////////////////////////// Platform /////////////////////////////// /////////////////////////////////////////////////////////////////////////////
        /// </summary>
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFLockPlatform();

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFLockSharedWorkQueue(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string wszClass, /* _In_ */ int BasePriority, /* _Inout_ */ ref uint pdwTaskId, /* _Out_ */ out uint pID);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFLockWorkQueue(/* _In_ */ uint dwWorkQueue);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern DXGI_FORMAT MFMapDX9FormatToDXGIFormat(/* _In_ */ uint dx9);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern uint MFMapDXGIFormatToDX9Format(/* _In_ */ DXGI_FORMAT dx11);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFPutWaitingWorkItem(IntPtr hEvent, int Priority, /* _In_ */ IMFAsyncResult pResult, /* optional(MFWORKITEM_KEY) */ IntPtr pKey);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFPutWorkItem(uint dwQueue, IMFAsyncCallback pCallback, [MarshalAs(UnmanagedType.IUnknown)] object pState);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFPutWorkItem2(uint dwQueue, int Priority, /* _In_ */ IMFAsyncCallback pCallback, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pState);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFPutWorkItemEx(uint dwQueue, IMFAsyncResult pResult);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFPutWorkItemEx2(uint dwQueue, int Priority, /* _In_ */ IMFAsyncResult pResult);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFRegisterLocalByteStreamHandler(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string szFileExtension, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string szMimeType, /* _In_ */ IMFActivate pActivate);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFRegisterLocalSchemeHandler(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string szScheme, /* _In_ */ IMFActivate pActivate);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFRegisterPlatformWithMMCSS(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string wszClass, /* _Inout_ */ ref uint pdwTaskId, /* _In_ */ int lPriority);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFRemovePeriodicCallback(uint dwKey);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFScheduleWorkItem(IMFAsyncCallback pCallback, [MarshalAs(UnmanagedType.IUnknown)] object pState, long Timeout, /* optional(MFWORKITEM_KEY) */ IntPtr pKey);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFScheduleWorkItemEx(IMFAsyncResult pResult, long Timeout, /* optional(MFWORKITEM_KEY) */ IntPtr pKey);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFShutdown();

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFSplitSample(/* _In_ */ IMFSample pSample, /* _Out_writes_to_(dwOutputSampleMaxCount, *pdwOutputSampleCount) */ out IntPtr pOutputSamples, /* _In_ */ uint dwOutputSampleMaxCount, /* _Out_ */ out uint pdwOutputSampleCount);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFStartup(uint Version, uint dwFlags);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFTEnum(/* _In_ */ Guid guidCategory, /* _In_ */ uint Flags, /* optional(__MIDL___MIDL_itf_mfobjects_0000_0008_0003) */ IntPtr pInputType, /* optional(__MIDL___MIDL_itf_mfobjects_0000_0008_0003) */ IntPtr pOutputType, /* _In_opt_ */ IMFAttributes pAttributes, /* _Outptr_result_buffer_(*pcMFTs) */ out IntPtr ppclsidMFT, /* // must be freed with CoTaskMemFree _Out_ */ out uint pcMFTs);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFTEnum2(/* _In_ */ Guid guidCategory, /* _In_ */ uint Flags, /* optional(__MIDL___MIDL_itf_mfobjects_0000_0008_0003) */ IntPtr pInputType, /* optional(__MIDL___MIDL_itf_mfobjects_0000_0008_0003) */ IntPtr pOutputType, /* _In_opt_ */ IMFAttributes pAttributes, /* _Outptr_result_buffer_( *pnumMFTActivate ) */ out IMFActivate pppMFTActivate, /* _Out_ */ out uint pnumMFTActivate);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFTEnumEx(/* _In_ */ Guid guidCategory, /* _In_ */ uint Flags, /* optional(__MIDL___MIDL_itf_mfobjects_0000_0008_0003) */ IntPtr pInputType, /* optional(__MIDL___MIDL_itf_mfobjects_0000_0008_0003) */ IntPtr pOutputType, /* _Outptr_result_buffer_(*pnumMFTActivate) */ out IMFActivate pppMFTActivate, /* _Out_ */ out uint pnumMFTActivate);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFTGetInfo(/* _In_ */ Guid clsidMFT, /* optional(LPWSTR) */ out IntPtr pszName, /* optional(__MIDL___MIDL_itf_mfobjects_0000_0008_0003) */ IntPtr ppInputTypes, /* optional(UINT32) */ IntPtr pcInputTypes, /* optional(__MIDL___MIDL_itf_mfobjects_0000_0008_0003) */ IntPtr ppOutputTypes, /* optional(UINT32) */ IntPtr pcOutputTypes, /* _Outptr_opt_result_maybenull_ */ out IMFAttributes ppAttributes);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFTRegister(/* _In_ */ Guid clsidMFT, /* _In_ */ Guid guidCategory, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* _In_ */ uint Flags, /* _In_ */ int cInputTypes, /* _In_reads_opt_(cInputTypes) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] __MIDL___MIDL_itf_mfobjects_0000_0008_0003[] pInputTypes, /* _In_ */ int cOutputTypes, /* _In_reads_opt_(cOutputTypes) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] __MIDL___MIDL_itf_mfobjects_0000_0008_0003[] pOutputTypes, /* _In_opt_ */ IMFAttributes pAttributes);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFTRegisterLocal(/* _In_ */ IClassFactory pClassFactory, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidCategory, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* _In_ */ uint Flags, /* _In_ */ int cInputTypes, /* _In_reads_opt_(cInputTypes) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] __MIDL___MIDL_itf_mfobjects_0000_0008_0003[] pInputTypes, /* _In_ */ int cOutputTypes, /* _In_reads_opt_(cOutputTypes) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] __MIDL___MIDL_itf_mfobjects_0000_0008_0003[] pOutputTypes);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFTRegisterLocalByCLSID(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid clisdMFT, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidCategory, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* _In_ */ uint Flags, /* _In_ */ int cInputTypes, /* _In_reads_opt_(cInputTypes) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] __MIDL___MIDL_itf_mfobjects_0000_0008_0003[] pInputTypes, /* _In_ */ int cOutputTypes, /* _In_reads_opt_(cOutputTypes) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] __MIDL___MIDL_itf_mfobjects_0000_0008_0003[] pOutputTypes);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFTUnregister(/* _In_ */ Guid clsidMFT);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFTUnregisterLocal(/* optional(IClassFactory) */ IntPtr pClassFactory);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFTUnregisterLocalByCLSID(/* _In_ */ Guid clsidMFT);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFUnlockDXGIDeviceManager();

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFUnlockPlatform();

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFUnlockWorkQueue(/* _In_ */ uint dwWorkQueue);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFUnregisterPlatformFromMMCSS();

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFUnwrapMediaType(/* _In_ */ IMFMediaType pWrap, /* _Out_ */ out IMFMediaType ppOrig);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFValidateMediaTypeSize(/* _In_ */ Guid FormatType, /* _In_reads_bytes_opt_(cbSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] pBlock, /* _In_ */ int cbSize);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFWrapMediaType(/* _In_ */ IMFMediaType pOrig, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid MajorType, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid SubType, /* _Out_ */ out IMFMediaType ppWrap);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT CreateNamedPropertyStore(/* _Outptr_ */ out IntPtr ppStore);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT CreatePropertyStore(/* out _Outptr_ */ out IntPtr ppStore);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreate3GPMediaSink(/* _In_ */ IMFByteStream pIByteStream, /* optional(IMFMediaType) */ IntPtr pVideoMediaType, /* optional(IMFMediaType) */ IntPtr pAudioMediaType, /* _Outptr_ */ out IMFMediaSink ppIMediaSink);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateAC3MediaSink(/* _In_ */ IMFByteStream pTargetByteStream, /* _In_ */ IMFMediaType pAudioMediaType, /* _Outptr_ */ out IMFMediaSink ppMediaSink);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateADTSMediaSink(/* _In_ */ IMFByteStream pTargetByteStream, /* _In_ */ IMFMediaType pAudioMediaType, /* _Outptr_ */ out IMFMediaSink ppMediaSink);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateAggregateSource(/* _In_ */ IMFCollection pSourceCollection, /* _Outptr_ */ out IMFMediaSource ppAggSource);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateAudioRenderer(IMFAttributes pAudioAttributes, /* _Outptr_ */ out IMFMediaSink ppSink);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateAudioRendererActivate(/* _Outptr_ */ out IntPtr ppActivate);

        [DllImport("mfsrcsnk", ExactSpelling = true)]
        public static extern HRESULT MFCreateAVIMediaSink(/* _In_ */ IMFByteStream pIByteStream, /* _In_ */ IMFMediaType pVideoMediaType, /* optional(IMFMediaType) */ IntPtr pAudioMediaType, /* _Outptr_ */ out IMFMediaSink ppIMediaSink);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateCameraOcclusionStateMonitor(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string symbolicLink, /* _In_ */ IMFCameraOcclusionStateReportCallback callback, /* _COM_Outptr_ */ out IMFCameraOcclusionStateMonitor occlusionStateMonitor);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateContentDecryptorContext(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidMediaProtectionSystemId, /* optional(IMFDXGIDeviceManager) */ IntPtr pD3DManager, /* _In_ */ IMFContentProtectionDevice pContentProtectionDevice, /* _Outptr_ */ out IMFContentDecryptorContext ppContentDecryptorContext);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateContentProtectionDevice(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid ProtectionSystemId, /* _Outptr_ */ out IMFContentProtectionDevice ContentProtectionDevice);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateCredentialCache(/* _Outptr_ */ out IMFNetCredentialCache ppCache);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateDeviceSource(/* _In_ */ IMFAttributes pAttributes, /* _Outptr_ */ out IMFMediaSource ppSource);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateDeviceSourceActivate(/* _In_ */ IMFAttributes pAttributes, /* _Outptr_ */ out IntPtr ppActivate);

        [DllImport("mfcore", ExactSpelling = true)]
        public static extern HRESULT MFCreateExtendedCameraIntrinsicModel(int distortionModelType, /* _COM_Outptr_ */ out IMFExtendedCameraIntrinsicModel ppExtendedCameraIntrinsicModel);

        [DllImport("mfcore", ExactSpelling = true)]
        public static extern HRESULT MFCreateExtendedCameraIntrinsics(/* _COM_Outptr_ */ out IMFExtendedCameraIntrinsics ppExtendedCameraIntrinsics);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateFMPEG4MediaSink(/* _In_ */ IMFByteStream pIByteStream, /* optional(IMFMediaType) */ IntPtr pVideoMediaType, /* optional(IMFMediaType) */ IntPtr pAudioMediaType, /* _Outptr_ */ out IMFMediaSink ppIMediaSink);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateMediaSession(IMFAttributes pConfiguration, /* _Outptr_ */ out IMFMediaSession ppMediaSession);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateMediaTypeFromProperties(/* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object punkStream, /* _Outptr_ */ out IntPtr ppMediaType);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateMFByteStreamOnStream(IStream pStream, /* _Outptr_ */ out IntPtr ppByteStream);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateMFByteStreamOnStreamEx(/* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object punkStream, /* _Outptr_ */ out IntPtr ppByteStream);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateMP3MediaSink(/* _In_ */ IMFByteStream pTargetByteStream, /* _Outptr_ */ out IMFMediaSink ppMediaSink);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateMPEG4MediaSink(/* _In_ */ IMFByteStream pIByteStream, /* optional(IMFMediaType) */ IntPtr pVideoMediaType, /* optional(IMFMediaType) */ IntPtr pAudioMediaType, /* _Outptr_ */ out IMFMediaSink ppIMediaSink);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateMuxSink(/* _In_ */ Guid guidOutputSubType, /* optional(IMFAttributes) */ IntPtr pOutputAttributes, /* optional(IMFByteStream) */ IntPtr pOutputByteStream, /* _Outptr_ */ out IMFMediaSink ppMuxSink);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateNetSchemePlugin([MarshalAs(UnmanagedType.LPStruct)] Guid riid, IntPtr ppvHandler);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreatePMPMediaSession(uint dwCreationFlags, IMFAttributes pConfiguration, /* _Outptr_ */ out IMFMediaSession ppMediaSession, /* optional(IMFActivate) */ IntPtr ppEnablerActivate);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreatePMPServer(uint dwCreationFlags, /* _Outptr_ */ out IMFPMPServer ppPMPServer);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreatePresentationClock(/* _Outptr_ */ out IMFPresentationClock ppPresentationClock);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreatePresentationDescriptor(int cStreamDescriptors, /* _In_reads_opt_( cStreamDescriptors ) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] IMFStreamDescriptor[] apStreamDescriptors, /* _Outptr_ */ out IMFPresentationDescriptor ppPresentationDescriptor);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreatePropertiesFromMediaType(/* _In_ */ IMFMediaType pMediaType, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Outptr_ */ out IntPtr ppv);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateProtectedEnvironmentAccess(/* _Outptr_ */ out IMFProtectedEnvironmentAccess ppAccess);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateProxyLocator([MarshalAs(UnmanagedType.LPWStr)] string pszProtocol, IPropertyStore pProxyConfig, /* _Outptr_ */ out IMFNetProxyLocator ppProxyLocator);

        [DllImport("mfsensorgroup", ExactSpelling = true)]
        public static extern HRESULT MFCreateRelativePanelWatcher(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string videoDeviceId, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string displayMonitorDeviceId, /* _COM_Outptr_ */ out IMFRelativePanelWatcher ppRelativePanelWatcher);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateRemoteDesktopPlugin(/* _Outptr_ */ out IMFRemoteDesktopPlugin ppPlugin);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateSampleCopierMFT(/* _Outptr_ */ out IntPtr ppCopierMFT);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateSampleGrabberSinkActivate(IMFMediaType pIMFMediaType, IMFSampleGrabberSinkCallback pIMFSampleGrabberSinkCallback, /* _Outptr_ */ out IntPtr ppIActivate);

        [DllImport("mfsensorgroup", ExactSpelling = true)]
        public static extern HRESULT MFCreateSensorActivityMonitor(/* _In_ */ IMFSensorActivitiesReportCallback pCallback, /* _COM_Outptr_ */ out IMFSensorActivityMonitor ppActivityMonitor);

        [DllImport("mfsensorgroup", ExactSpelling = true)]
        public static extern HRESULT MFCreateSensorGroup(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string SensorGroupSymbolicLink, /* _COM_Outptr_ */ out IMFSensorGroup ppSensorGroup);

        [DllImport("mfsensorgroup", ExactSpelling = true)]
        public static extern HRESULT MFCreateSensorProfile(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid ProfileType, /* _In_ */ uint ProfileIndex, /* _In_opt_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string Constraints, /* _COM_Outptr_ */ out IMFSensorProfile ppProfile);

        [DllImport("mfsensorgroup", ExactSpelling = true)]
        public static extern HRESULT MFCreateSensorProfileCollection(/* _COM_Outptr_ */ out IMFSensorProfileCollection ppSensorProfile);

        [DllImport("mfsensorgroup", ExactSpelling = true)]
        public static extern HRESULT MFCreateSensorStream(/* _In_ */ uint StreamId, /* optional(IMFAttributes) */ IntPtr pAttributes, /* _In_ */ IMFCollection pMediaTypeCollection, /* _COM_Outptr_ */ out IMFSensorStream ppStream);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateSequencerSegmentOffset(uint dwId, long hnsOffset, /* _Out_ */ [In, Out] PropVariant pvarSegmentOffset);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateSequencerSource([MarshalAs(UnmanagedType.IUnknown)] object pReserved, /* _Outptr_ */ out IMFSequencerSource ppSequencerSource);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateSimpleTypeHandler(/* _Outptr_ */ out IMFMediaTypeHandler ppHandler);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateSourceResolver(/* out _Outptr_ */ out IMFSourceResolver ppISourceResolver);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateStandardQualityManager(/* _Outptr_ */ out IMFQualityManager ppQualityManager);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateStreamDescriptor(uint dwStreamIdentifier, int cMediaTypes, /* _In_reads_(cMediaTypes) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IMFMediaType[] apMediaTypes, /* _Outptr_ */ out IMFStreamDescriptor ppDescriptor);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateStreamOnMFByteStream(/* _In_ */ IMFByteStream pByteStream, /* _Outptr_ */ out IStream ppStream);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateStreamOnMFByteStreamEx(/* _In_ */ IMFByteStream pByteStream, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Outptr_ */ out IntPtr ppv);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateSystemTimeSource(/* _Outptr_ */ out IMFPresentationTimeSource ppSystemTimeSource);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateTopoLoader(/* _Outptr_ */ out IMFTopoLoader ppObj);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateTopology(/* _Outptr_ */ out IMFTopology ppTopo);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateTopologyNode(MF_TOPOLOGY_TYPE NodeType, /* _Outptr_ */ out IMFTopologyNode ppNode);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateTrackedSample(/* _Outptr_ */ out IMFTrackedSample ppMFSample);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateTranscodeProfile(/* _Outptr_ */ out IMFTranscodeProfile ppTranscodeProfile);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateTranscodeSinkActivate(/* _Outptr_ */ out IntPtr ppActivate);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateTranscodeTopology(/* _In_ */ IMFMediaSource pSrc, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pwszOutputFilePath, /* _In_ */ IMFTranscodeProfile pProfile, /* _Outptr_ */ out IMFTopology ppTranscodeTopo);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateTranscodeTopologyFromByteStream(/* _In_ */ IMFMediaSource pSrc, /* _In_ */ IMFByteStream pOutputStream, /* _In_ */ IMFTranscodeProfile pProfile, /* _Out_ */ out IMFTopology ppTranscodeTopo);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateVideoRendererActivate(/* _In_ */ IntPtr hwndVideo, /* _Outptr_ */ out IntPtr ppActivate);

        [DllImport("mfsrcsnk", ExactSpelling = true)]
        public static extern HRESULT MFCreateWAVEMediaSink(/* _In_ */ IMFByteStream pTargetByteStream, /* _In_ */ IMFMediaType pAudioMediaType, /* _Outptr_ */ out IMFMediaSink ppMediaSink);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFDeserializePresentationDescriptor(/* _In_ */ int cbData, /* _In_reads_( cbData ) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] byte[] pbData, /* _Outptr_ */ out IMFPresentationDescriptor ppPD);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFEnumDeviceSources(/* _In_ */ IMFAttributes pAttributes, /* _Outptr_result_buffer_(*pcSourceActivate) */ out IntPtr pppSourceActivate, /* _Out_ */ out uint pcSourceActivate);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFGetLocalId(/* _In_reads_bytes_(size) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] verifier, /* _In_ */ int size, /* _Outptr_ */ out IntPtr id);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFGetService([MarshalAs(UnmanagedType.IUnknown)] object punkObject, [MarshalAs(UnmanagedType.LPStruct)] Guid guidService, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Outptr_ */ out IntPtr ppvObject);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFGetSupportedMimeTypes(/* _Out_ */ [In, Out] PropVariant pPropVarMimeTypeArray);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFGetSupportedSchemes(/* _Out_ */ [In, Out] PropVariant pPropVarSchemeArray);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFGetSystemId(/* _Outptr_ */ out IMFSystemId ppId);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern long MFGetSystemTime();

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFGetTopoNodeCurrentType(IMFTopologyNode pNode, uint dwStreamIndex, bool fOutput, /* _Outptr_ */ out IntPtr ppType);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFIsContentProtectionDeviceSupported(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid ProtectionSystemId, /* _Out_ */ out bool isSupported);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFLoadSignedLibrary(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* _Outptr_ */ out IMFSignedLibrary ppLib);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFRequireProtectedEnvironment(/* _In_ */ IMFPresentationDescriptor pPresentationDescriptor);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFSerializePresentationDescriptor(/* _In_ */ IMFPresentationDescriptor pPD, /* _Out_ */ out uint pcbData, /* _Outptr_result_bytebuffer_to_(*pcbData, *pcbData) */ out IntPtr ppbData);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFShutdownObject([MarshalAs(UnmanagedType.IUnknown)] object pUnk);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFTranscodeGetAudioOutputAvailableTypes(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidSubType, /* _In_ */ uint dwMFTFlags, /* optional(IMFAttributes) */ IntPtr pCodecConfig, /* _Outptr_ */ out IntPtr ppAvailableTypes);

        [DllImport("mfgphone", ExactSpelling = true)]
        public static extern HRESULT MfgPhoneDial(/* _In_ */ uint SimSlot, /* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string DialNumber);

        [DllImport("mfgphone", ExactSpelling = true)]
        public static extern HRESULT MfgPhoneEndCall(/* _In_ */ uint SimSlot);

        [DllImport("mfgphone", ExactSpelling = true)]
        public static extern HRESULT MfgPhoneGetSimLineCount(/* _Out_ */ out uint SimLineCount);

        [DllImport("mfgphone", ExactSpelling = true)]
        public static extern HRESULT MfgPhoneGetSimLineDetail(/* _In_ */ uint SimSlot, /* optional(_MFGPHONE_SIMLINEDETAIL) */ IntPtr SimLineDetail, /* _In_ */ uint SimLineDetailSize, /* _Out_opt_ _Out_range_(>=, sizeof(MFGPHONE_SIMLINEDETAIL)) */ [Out, MarshalAs(UnmanagedType.LPArray)] uint[] RequiredSize);

        [DllImport("mfgphone", ExactSpelling = true)]
        public static extern HRESULT MfgPhoneGetSpeaker(/* _Out_ */ out bool pbSpeakerOn);

        [DllImport("mfgphone", ExactSpelling = true)]
        public static extern HRESULT MfgPhoneInitialize();

        [DllImport("mfgphone", ExactSpelling = true)]
        public static extern HRESULT MfgPhoneSetSimLineEventNotifyCallback(/* optional(MFGPHONE_SIMLINEEVENT_NOTIFY_CALLBACK) */ IntPtr Callback, /* optional(PVOID) */ IntPtr Context);

        [DllImport("mfgphone", ExactSpelling = true)]
        public static extern HRESULT MfgPhoneSetSpeaker(/* _In_ */ bool bSpeakerOn);

        [DllImport("mfgphone", ExactSpelling = true)]
        public static extern HRESULT MfgPhoneUninitialize();

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateEncryptedMediaExtensionsStoreActivate(/* _In_ */ IMFPMPHostApp pmpHost, /* _In_ */ IStream objectStream, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string classId, /* _Outptr_ */ out IMFActivate activate);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateD3D12SynchronizationObject(/* [annotation][in] _In_ */ ID3D12Device pDevice, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][out] _Outptr_ */ out IntPtr ppvSyncObject);

        [DllImport("mfplay", ExactSpelling = true)]
        public static extern HRESULT MFPCreateMediaPlayer(/* _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string pwszURL, /* _In_ */ bool fStartPlayback, /* _In_opt_ */ uint creationOptions, /* _In_opt_ */ IMFPMediaPlayerCallback pCallback, /* optional(HWND__) */ IntPtr hWnd, /* _Out_opt_ */ out IMFPMediaPlayer ppMediaPlayer);

        [DllImport("mfreadwrite", ExactSpelling = true)]
        public static extern HRESULT MFCreateSinkWriterFromMediaSink(/* _In_ */ IMFMediaSink pMediaSink, /* _In_opt_ */ IMFAttributes pAttributes, /* _Out_ */ out IMFSinkWriter ppSinkWriter);

        [DllImport("mfreadwrite", ExactSpelling = true)]
        public static extern HRESULT MFCreateSinkWriterFromURL(/* _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string pwszOutputURL, /* _In_opt_ */ IMFByteStream pByteStream, /* _In_opt_ */ IMFAttributes pAttributes, /* _Out_ */ out IMFSinkWriter ppSinkWriter);

        [DllImport("mfreadwrite", ExactSpelling = true)]
        public static extern HRESULT MFCreateSourceReaderFromByteStream(/* _In_ */ IMFByteStream pByteStream, /* _In_opt_ */ IMFAttributes pAttributes, /* _Out_ */ out IMFSourceReader ppSourceReader);

        [DllImport("mfreadwrite", ExactSpelling = true)]
        public static extern HRESULT MFCreateSourceReaderFromMediaSource(/* _In_ */ IMFMediaSource pMediaSource, /* _In_opt_ */ IMFAttributes pAttributes, /* _Out_ */ out IMFSourceReader ppSourceReader);

        [DllImport("mfreadwrite", ExactSpelling = true)]
        public static extern HRESULT MFCreateSourceReaderFromURL(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pwszURL, /* _In_opt_ */ IMFAttributes pAttributes, /* _Out_ */ out IMFSourceReader ppSourceReader);

        [DllImport("mfsensorgroup", ExactSpelling = true)]
        public static extern HRESULT MFCreateVirtualCamera(/* _In_ */ __MIDL___MIDL_itf_mfvirtualcamera_0000_0000_0001 type, /* _In_ */ __MIDL___MIDL_itf_mfvirtualcamera_0000_0000_0002 lifetime, /* _In_ */ __MIDL___MIDL_itf_mfvirtualcamera_0000_0000_0003 access, /* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string friendlyName, /* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string sourceId, /* _In_reads_opt_(categoryCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] Guid[] categories, /* _In_ */ int categoryCount, /* _COM_Outptr_ */ out IMFVirtualCamera virtualCamera);

        [DllImport("mfsensorgroup", ExactSpelling = true)]
        public static extern HRESULT MFIsVirtualCameraTypeSupported(/* _In_ */ __MIDL___MIDL_itf_mfvirtualcamera_0000_0000_0001 type, /* _Out_ */ out bool supported);

        [DllImport("MMDevAPI", ExactSpelling = true)]
        public static extern HRESULT ActivateAudioInterfaceAsync(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string deviceInterfacePath, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _In_opt_ */ [In, Out] PropVariant activationParams, /* _In_ */ IActivateAudioInterfaceCompletionHandler completionHandler, /* _COM_Outptr_ */ out IActivateAudioInterfaceAsyncOperation activationOperation);

        [DllImport("dxva2", ExactSpelling = true)]
        public static extern HRESULT OPMGetVideoOutputForTarget(/* _In_ */ ref LUID pAdapterLuid, /* _In_ */ uint VidPnTarget, /* _In_ */ _OPM_VIDEO_OUTPUT_SEMANTICS vos, /* _COM_Outptr_ */ out IOPMVideoOutput ppOPMVideoOutput);

        [DllImport("dxva2", ExactSpelling = true)]
        public static extern HRESULT OPMGetVideoOutputsFromHMONITOR(/* _In_ */ IntPtr hMonitor, /* _In_ */ _OPM_VIDEO_OUTPUT_SEMANTICS vos, /* _Out_ */ out uint pulNumVideoOutputs, /* _Outptr_result_buffer_(*pulNumVideoOutputs) */ out IOPMVideoOutput pppOPMVideoOutputArray);

        [DllImport("dxva2", ExactSpelling = true)]
        public static extern HRESULT OPMGetVideoOutputsFromIDirect3DDevice9Object(/* _In_ */ IDirect3DDevice9 pDirect3DDevice9, /* _In_ */ _OPM_VIDEO_OUTPUT_SEMANTICS vos, /* _Out_ */ out uint pulNumVideoOutputs, /* _Outptr_result_buffer_(*pulNumVideoOutputs) */ out IOPMVideoOutput pppOPMVideoOutputArray);

        [DllImport("WindowsCodecs", ExactSpelling = true)]
        public static extern HRESULT WICGetMetadataContentSize(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidContainerFormat, /* _In_ */ IWICMetadataWriter pIWriter, /* _Out_ */ out ulong pcbSize);

        [DllImport("WindowsCodecs", ExactSpelling = true)]
        public static extern HRESULT WICMatchMetadataContent(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidContainerFormat, /* optional(GUID) */ IntPtr pguidVendor, /* _In_ */ IStream pIStream, /* _Out_ */ out Guid pguidMetadataFormat);

        [DllImport("WindowsCodecs", ExactSpelling = true)]
        public static extern HRESULT WICSerializeMetadataContent(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidContainerFormat, /* _In_ */ IWICMetadataWriter pIWriter, /* _In_ */ uint dwPersistOptions, /* _In_ */ IStream pIStream);

        [DllImport("wmcodecdsp", ExactSpelling = true)]
        public static extern HRESULT CreateFileIo(/* out */ out IFileIo ppFileIo);

        [DllImport("wmcodecdsp", ExactSpelling = true)]
        public static extern HRESULT CreateToc(/* out */ out IToc ppTableOfContents);

        [DllImport("wmcodecdsp", ExactSpelling = true)]
        public static extern HRESULT CreateTocCollection(/* out */ out ITocCollection ppTocCollection);

        [DllImport("wmcodecdsp", ExactSpelling = true)]
        public static extern HRESULT CreateTocEntry(/* out */ out ITocEntry ppTocEntry);

        [DllImport("wmcodecdsp", ExactSpelling = true)]
        public static extern HRESULT CreateTocEntryList(/* out */ out ITocEntryList ppTocEntryList);

        [DllImport("wmcodecdsp", ExactSpelling = true)]
        public static extern HRESULT CreateTocParser(/* out */ out ITocParser ppTocParser);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateASFContentInfo(/* out */ out IMFASFContentInfo ppIContentInfo);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateASFIndexer(/* out */ out IMFASFIndexer ppIIndexer);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateASFIndexerByteStream(/* in */ IMFByteStream pIContentByteStream, /* in */ ulong cbIndexStartOffset, /* out */ out IMFByteStream pIIndexByteStream);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateASFMediaSink(IMFByteStream pIByteStream, out IMFMediaSink ppIMediaSink);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateASFMediaSinkActivate([MarshalAs(UnmanagedType.LPWStr)] string pwszFileName, IMFASFContentInfo pContentInfo, out IMFActivate ppIActivate);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateASFMultiplexer(/* out */ out IMFASFMultiplexer ppIMultiplexer);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateASFProfile(/* out */ out IMFASFProfile ppIProfile);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateASFProfileFromPresentationDescriptor(/* in */ IMFPresentationDescriptor pIPD, /* out */ out IMFASFProfile ppIProfile);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateASFSplitter(/* out */ out IMFASFSplitter ppISplitter);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateASFStreamingMediaSink(IMFByteStream pIByteStream, out IMFMediaSink ppIMediaSink);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateASFStreamingMediaSinkActivate(IMFActivate pByteStreamActivate, IMFASFContentInfo pContentInfo, out IMFActivate ppIActivate);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateASFStreamSelector(/* in */ IMFASFProfile pIASFProfile, /* out */ out IMFASFStreamSelector ppSelector);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreatePresentationDescriptorFromASFProfile(/* in */ IMFASFProfile pIProfile, /* out */ out IMFPresentationDescriptor ppIPD);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateWMAEncoderActivate(IMFMediaType pMediaType, IPropertyStore pEncodingConfigurationProperties, out IMFActivate ppActivate);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateWMVEncoderActivate(IMFMediaType pMediaType, IPropertyStore pEncodingConfigurationProperties, out IMFActivate ppActivate);

        [DllImport("wmvcore", ExactSpelling = true)]
        public static extern HRESULT WMCreateBackupRestorer([MarshalAs(UnmanagedType.IUnknown)] object pCallback, out IWMLicenseBackup ppBackup);

        [DllImport("wmvcore", ExactSpelling = true)]
        public static extern HRESULT WMCreateDeviceRegistration(out IWMDeviceRegistration ppDevReg);

        [DllImport("wmvcore", ExactSpelling = true)]
        public static extern HRESULT WMCreateDRMTranscryptionManager(out IWMDRMTranscryptionManager ppTranscryptionManager);

        [DllImport("wmvcore", ExactSpelling = true)]
        public static extern HRESULT WMCreateDRMTranscryptor(out IWMDRMTranscryptor ppTranscryptor);

        [DllImport("wmvcore", ExactSpelling = true)]
        public static extern HRESULT WMCreateEditor(out IWMMetadataEditor ppEditor);

        [DllImport("wmvcore", ExactSpelling = true)]
        public static extern HRESULT WMCreateIndexer(out IWMIndexer ppIndexer);

        [DllImport("wmvcore", ExactSpelling = true)]
        public static extern HRESULT WMCreateLicenseRevocationAgent([MarshalAs(UnmanagedType.IUnknown)] object pCallback, out IWMLicenseRevocationAgent ppLicenseRevocationAgent);

        [DllImport("wmvcore", ExactSpelling = true)]
        public static extern HRESULT WMCreateProfileManager(out IWMProfileManager ppProfileManager);

        [DllImport("wmvcore", ExactSpelling = true)]
        public static extern HRESULT WMCreateReader([MarshalAs(UnmanagedType.IUnknown)] object pUnkCert, uint dwRights, out IWMReader ppReader);

        [DllImport("wmvcore", ExactSpelling = true)]
        public static extern HRESULT WMCreateSyncReader([MarshalAs(UnmanagedType.IUnknown)] object pUnkCert, uint dwRights, out IWMSyncReader ppSyncReader);

        [DllImport("wmvcore", ExactSpelling = true)]
        public static extern HRESULT WMCreateWriter([MarshalAs(UnmanagedType.IUnknown)] object pUnkCert, out IWMWriter ppWriter);

        [DllImport("wmvcore", ExactSpelling = true)]
        public static extern HRESULT WMCreateWriterFileSink(out IWMWriterFileSink ppSink);

        [DllImport("wmvcore", ExactSpelling = true)]
        public static extern HRESULT WMCreateWriterNetworkSink(out IWMWriterNetworkSink ppSink);

        [DllImport("wmvcore", ExactSpelling = true)]
        public static extern HRESULT WMCreateWriterPushSink(out IWMWriterPushSink ppSink);

        [DllImport("wmvcore", ExactSpelling = true)]
        public static extern HRESULT WMIsContentProtected([MarshalAs(UnmanagedType.LPWStr)] string pwszFileName, ref bool pfIsProtected);

        [DllImport("wmvcore", ExactSpelling = true)]
        public static extern HRESULT WMCheckURLExtension(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszURL);

        [DllImport("wmvcore", ExactSpelling = true)]
        public static extern HRESULT WMCheckURLScheme(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszURLScheme);

        [DllImport("wmvcore", ExactSpelling = true)]
        public static extern HRESULT WMIsAvailableOffline(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszURL, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszLanguage, /* [out] */ out bool pfIsAvailableOffline);

        [DllImport("wmvcore", ExactSpelling = true)]
        public static extern HRESULT WMValidateData(/* [in] */ ref byte pbData, /* [in, out] */ ref uint pdwDataSize);

        [DllImport("wmvcore", ExactSpelling = true)]
        public static extern HRESULT WMCreateSecureChannel(out IWMSecureChannel ppChannel);

        [DllImport("wmvcore", ExactSpelling = true)]
        public static extern HRESULT WMCreateSecureChannel_Certified(out IWMSecureChannel ppChannel);

        [DllImport("wmvcore", ExactSpelling = true)]
        public static extern HRESULT WMCreateSecureChannel_Certified_DES(out IWMSecureChannel ppChannel);

        [DllImport("wmvcore", ExactSpelling = true)]
        public static extern HRESULT WMCreateSecureChannel_DES(out IWMSecureChannel ppChannel);
    }
}
