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

        [DllImport("dxgi1_6", ExactSpelling = true)]
        public static extern HRESULT DXGIDeclareAdapterRemovalSupport();

        [DllImport("audioenginebaseapo", ExactSpelling = true)]
        public static extern HRESULT EnumerateAPOs(FNAPONOTIFICATIONCALLBACK pfnCallback, IntPtr pvRefData);

        [DllImport("audioenginebaseapo", ExactSpelling = true)]
        public static extern HRESULT GetAPOProperties([MarshalAs(UnmanagedType.LPStruct)] Guid clsid, ref APO_REG_PROPERTIES pProperties);

        [DllImport("audioenginebaseapo", ExactSpelling = true)]
        public static extern HRESULT RegisterAPO(ref APO_REG_PROPERTIES pProperties);

        [DllImport("audioenginebaseapo", ExactSpelling = true)]
        public static extern HRESULT RegisterAPONotification(IntPtr hEvent);

        [DllImport("audioenginebaseapo", ExactSpelling = true)]
        public static extern HRESULT UnregisterAPO([MarshalAs(UnmanagedType.LPStruct)] Guid clsid);

        [DllImport("audioenginebaseapo", ExactSpelling = true)]
        public static extern HRESULT UnregisterAPONotification(IntPtr hEvent);

        [DllImport("audiomediatype", ExactSpelling = true)]
        public static extern HRESULT CreateAudioMediaType(ref tWAVEFORMATEX pAudioFormat, uint cbAudioFormatSize, out IAudioMediaType ppIAudioMediaType);
        
        [DllImport("audiomediatype", ExactSpelling = true)]
        public static extern HRESULT CreateAudioMediaTypeFromUncompressedAudioFormat(ref _UNCOMPRESSEDAUDIOFORMAT pUncompressedAudioFormat, out IAudioMediaType ppIAudioMediaType);

        [DllImport("d3d11", ExactSpelling = true)]
        public static extern HRESULT D3D11On12CreateDevice(/* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pDevice, uint Flags, /* _In_reads_opt_( FeatureLevels ) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] D3D_FEATURE_LEVEL[] pFeatureLevels, int FeatureLevels, /* _In_reads_opt_( NumQueues ) */ [MarshalAs(UnmanagedType.IUnknown)] object ppCommandQueues, uint NumQueues, uint NodeMask, /* _COM_Outptr_opt_ */ out ID3D11Device ppDevice, /* _COM_Outptr_opt_ */ out ID3D11DeviceContext ppImmediateContext, /* optional(D3D_FEATURE_LEVEL) */ IntPtr pChosenFeatureLevel);

        [DllImport("d3d11", ExactSpelling = true)]
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

        [DllImport("audiostatemonitorapi", ExactSpelling = true)]
        public static extern HRESULT CreateCaptureAudioStateMonitor(/* _Outptr_ */ out IAudioStateMonitor audioStateMonitor);
        
        [DllImport("audiostatemonitorapi", ExactSpelling = true)]
        public static extern HRESULT CreateCaptureAudioStateMonitorForCategory(/* _In_ */ _AUDIO_STREAM_CATEGORY category, /* _Outptr_ */ out IAudioStateMonitor audioStateMonitor);
        
        [DllImport("audiostatemonitorapi", ExactSpelling = true)]
        public static extern HRESULT CreateCaptureAudioStateMonitorForCategoryAndDeviceId(/* _In_ */ _AUDIO_STREAM_CATEGORY category, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string deviceId, /* _Outptr_ */ out IAudioStateMonitor audioStateMonitor);
        
        [DllImport("audiostatemonitorapi", ExactSpelling = true)]
        public static extern HRESULT CreateCaptureAudioStateMonitorForCategoryAndDeviceRole(/* _In_ */ _AUDIO_STREAM_CATEGORY category, /* _In_ */ int role, /* _Outptr_ */ out IAudioStateMonitor audioStateMonitor);
        
        /// <summary>
        /// ************************************************************************
        /// </summary>
        [DllImport("audiostatemonitorapi", ExactSpelling = true)]
        public static extern HRESULT CreateRenderAudioStateMonitor(/* _Outptr_ */ out IAudioStateMonitor audioStateMonitor);
        
        [DllImport("audiostatemonitorapi", ExactSpelling = true)]
        public static extern HRESULT CreateRenderAudioStateMonitorForCategory(/* _In_ */ _AUDIO_STREAM_CATEGORY category, /* _Outptr_ */ out IAudioStateMonitor audioStateMonitor);
        
        [DllImport("audiostatemonitorapi", ExactSpelling = true)]
        public static extern HRESULT CreateRenderAudioStateMonitorForCategoryAndDeviceId(/* _In_ */ _AUDIO_STREAM_CATEGORY category, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string deviceId, /* _Outptr_ */ out IAudioStateMonitor audioStateMonitor);
        
        [DllImport("audiostatemonitorapi", ExactSpelling = true)]
        public static extern HRESULT CreateRenderAudioStateMonitorForCategoryAndDeviceRole(/* _In_ */ _AUDIO_STREAM_CATEGORY category, /* _In_ */ int role, /* _Outptr_ */ out IAudioStateMonitor audioStateMonitor);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HCOMMANDALLOCATOR MAKE_D3D12DDI_HCOMMANDALLOCATOR(IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HCOMMANDLIST MAKE_D3D12DDI_HCOMMANDLIST(IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HCOMMANDPOOL_0040 MAKE_D3D12DDI_HCOMMANDPOOL_0040(IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HCOMMANDQUEUE MAKE_D3D12DDI_HCOMMANDQUEUE(IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HCOMMANDRECORDER_0040 MAKE_D3D12DDI_HCOMMANDRECORDER_0040(IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HCOMMANDSIGNATURE MAKE_D3D12DDI_HCOMMANDSIGNATURE(IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HCONTENTPROTECTIONSESSION_0020 MAKE_D3D12DDI_HCONTENTPROTECTIONSESSION_0020(/* optional(void) */ IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HCRYPTOSESSIONPOLICY_0030 MAKE_D3D12DDI_HCRYPTOSESSIONPOLICY_0030(/* Build rev 0. #define D3D12DDI_MINOR_VERSION_R3 30 #define D3D12DDI_INTERFACE_VERSION_R3 ((D3D12DDI_MAJOR_VERSION << 16) | D3D12DDI_MINOR_VERSION_R3) #define D3D12DDI_BUILD_VERSION_0030 0 #define D3D12DDI_SUPPORTED_0030 ((((UINT64)D3D12DDI_INTERFACE_VERSION_R3) << 32) | (((UINT64)D3D12DDI_BUILD_VERSION_0030) << 16)) D3D10DDI_H( D3D12DDI_HCRYPTOSESSION_0030 ) */ IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HCRYPTOSESSION_0030 MAKE_D3D12DDI_HCRYPTOSESSION_0030(/* Build rev 0. #define D3D12DDI_MINOR_VERSION_R3 30 #define D3D12DDI_INTERFACE_VERSION_R3 ((D3D12DDI_MAJOR_VERSION << 16) | D3D12DDI_MINOR_VERSION_R3) #define D3D12DDI_BUILD_VERSION_0030 0 #define D3D12DDI_SUPPORTED_0030 ((((UINT64)D3D12DDI_INTERFACE_VERSION_R3) << 32) | (((UINT64)D3D12DDI_BUILD_VERSION_0030) << 16)) */ IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HDESCRIPTORHEAP MAKE_D3D12DDI_HDESCRIPTORHEAP(IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HFENCE MAKE_D3D12DDI_HFENCE(IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HHEAP MAKE_D3D12DDI_HHEAP(IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HMETACOMMAND_0052 MAKE_D3D12DDI_HMETACOMMAND_0052(IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HPASS MAKE_D3D12DDI_HPASS(/* optional(void) */ out IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HPIPELINELIBRARY MAKE_D3D12DDI_HPIPELINELIBRARY(/* } D3D12DDI_3DPIPELINELEVEL; typedef VOID ( APIENTRY* PFND3D12DDI_CHECKFORMATSUPPORT )( D3D12DDI_HDEVICE, DXGI_FORMAT, _Out_ UINT* ); typedef VOID ( APIENTRY* PFND3D12DDI_CHECKMULTISAMPLEQUALITYLEVELS )( D3D12DDI_HDEVICE hDevice, DXGI_FORMAT Format, UINT SampleCount, D3D12DDI_MULTISAMPLE_QUALITY_LEVEL_FLAGS Flags, _Out_ UINT* pNumQualityLevels ); typedef VOID ( APIENTRY* PFND3D12DDI_GETMIPPACKING )( D3D12DDI_HDEVICE hDevice, D3D12DDI_HRESOURCE hTiledResource, _Out_ UINT* pNumPackedMips, _Out_ UINT* pNumTilesForPackedMips ); typedef SIZE_T ( APIENTRY* PFND3D12DDI_CALCPRIVATEELEMENTLAYOUTSIZE )( D3D12DDI_HDEVICE, _In_ CONST D3D12DDIARG_CREATEELEMENTLAYOUT* ); typedef VOID ( APIENTRY* PFND3D12DDI_CREATEELEMENTLAYOUT_0003 )( D3D12DDI_HDEVICE, _In_ CONST D3D12DDIARG_CREATEELEMENTLAYOUT*, D3D12DDI_HELEMENTLAYOUT ); typedef VOID ( APIENTRY* PFND3D12DDI_DESTROYELEMENTLAYOUT )( D3D12DDI_HDEVICE, D3D12DDI_HELEMENTLAYOUT ); typedef SIZE_T ( APIENTRY* PFND3D12DDI_CALCPRIVATEBLENDSTATESIZE )( D3D12DDI_HDEVICE, _In_ CONST D3D12DDI_BLEND_DESC* ); typedef VOID ( APIENTRY* PFND3D12DDI_CREATEBLENDSTATE_0003 )( D3D12DDI_HDEVICE, _In_ CONST D3D12DDI_BLEND_DESC*, D3D12DDI_HBLENDSTATE ); typedef VOID ( APIENTRY* PFND3D12DDI_DESTROYBLENDSTATE )( D3D12DDI_HDEVICE, D3D12DDI_HBLENDSTATE ); typedef SIZE_T ( APIENTRY* PFND3D12DDI_CALCPRIVATEDEPTHSTENCILSTATESIZE )( D3D12DDI_HDEVICE, _In_ CONST D3D12DDI_DEPTH_STENCIL_DESC* ); typedef VOID ( APIENTRY* PFND3D12DDI_CREATEDEPTHSTENCILSTATE_0003 )( D3D12DDI_HDEVICE, _In_ CONST D3D12DDI_DEPTH_STENCIL_DESC*, D3D12DDI_HDEPTHSTENCILSTATE ); typedef VOID ( APIENTRY* PFND3D12DDI_DESTROYDEPTHSTENCILSTATE )( D3D12DDI_HDEVICE, D3D12DDI_HDEPTHSTENCILSTATE ); typedef VOID ( APIENTRY* PFND3D12DDI_DESTROYRASTERIZERSTATE )( D3D12DDI_HDEVICE, D3D12DDI_HRASTERIZERSTATE ); typedef VOID ( APIENTRY* PFND3D12DDI_CLEAR_ROOT_ARGUMENTS )(D3D12DDI_HCOMMANDLIST); typedef VOID ( APIENTRY* PFND3D12DDI_DESTROYSHADER )( D3D12DDI_HDEVICE, D3D12DDI_HSHADER ); typedef VOID ( APIENTRY* PFND3D12DDI_BEGIN_END_QUERY_0003 )( D3D12DDI_HCOMMANDLIST, D3D12DDI_HQUERYHEAP, D3D12DDI_QUERY_TYPE, UINT ); typedef D3DKMT_HANDLE ( APIENTRY* PFND3D12DDI_CHECKRESOURCEALLOCATIONHANDLE )( D3D12DDI_HDEVICE, D3D10DDI_HRESOURCE ); //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 DDI Tables // typedef struct D3D12DDI_COMMAND_LIST_FUNCS_3D_0003 { PFND3D12DDI_CLOSECOMMANDLIST pfnCloseCommandList; PFND3D12DDI_RESETCOMMANDLIST pfnResetCommandList; PFND3D12DDI_DRAWINSTANCED pfnDrawInstanced; PFND3D12DDI_DRAWINDEXEDINSTANCED pfnDrawIndexedInstanced; PFND3D12DDI_DISPATCH pfnDispatch; PFND3D12DDI_CLEAR_UNORDERED_ACCESS_VIEW_UINT_0003 pfnClearUnorderedAccessViewUint; PFND3D12DDI_CLEAR_UNORDERED_ACCESS_VIEW_FLOAT_0003 pfnClearUnorderedAccessViewFloat; PFND3D12DDI_CLEAR_RENDER_TARGET_VIEW_0003 pfnClearRenderTargetView; PFND3D12DDI_CLEAR_DEPTH_STENCIL_VIEW_0003 pfnClearDepthStencilView; PFND3D12DDI_DISCARD_RESOURCE_0003 pfnDiscardResource; PFND3D12DDI_COPYTEXTUREREGION_0003 pfnCopyTextureRegion; PFND3D12DDI_RESOURCECOPY pfnResourceCopy; PFND3D12DDI_COPYTILES pfnCopyTiles; PFND3D12DDI_COPYBUFFERREGION_0003 pfnCopyBufferRegion; PFND3D12DDI_RESOURCERESOLVESUBRESOURCE pfnResourceResolveSubresource; PFND3D12DDI_EXECUTE_BUNDLE pfnExecuteBundle; PFND3D12DDI_EXECUTE_INDIRECT pfnExecuteIndirect; PFND3D12DDI_RESOURCEBARRIER_0003 pfnResourceBarrier; PFND3D12DDI_BLT pfnBlt; PFND3D12DDI_PRESENT_0003 pfnPresent; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnBeginQuery; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnEndQuery; PFND3D12DDI_RESOLVE_QUERY_DATA pfnResolveQueryData; PFND3D12DDI_SET_PREDICATION pfnSetPredication; PFND3D12DDI_IA_SETTOPOLOGY_0003 pfnIaSetTopology; PFND3D12DDI_RS_SETVIEWPORTS_0003 pfnRsSetViewports; PFND3D12DDI_RS_SETSCISSORRECTS_0003 pfnRsSetScissorRects; PFND3D12DDI_OM_SETBLENDFACTOR pfnOmSetBlendFactor; PFND3D12DDI_OM_SETSTENCILREF pfnOmSetStencilRef; PFND3D12DDI_SET_PIPELINE_STATE pfnSetPipelineState; PFND3D12DDI_SET_DESCRIPTOR_HEAPS_0003 pfnSetDescriptorHeaps; PFND3D12DDI_SET_ROOT_SIGNATURE pfnSetComputeRootSignature; PFND3D12DDI_SET_ROOT_SIGNATURE pfnSetGraphicsRootSignature; PFND3D12DDI_SET_ROOT_DESCRIPTOR_TABLE pfnSetComputeRootDescriptorTable; PFND3D12DDI_SET_ROOT_DESCRIPTOR_TABLE pfnSetGraphicsRootDescriptorTable; PFND3D12DDI_SET_ROOT_32BIT_CONSTANT pfnSetComputeRoot32BitConstant; PFND3D12DDI_SET_ROOT_32BIT_CONSTANT pfnSetGraphicsRoot32BitConstant; PFND3D12DDI_SET_ROOT_32BIT_CONSTANTS_0003 pfnSetComputeRoot32BitConstants; PFND3D12DDI_SET_ROOT_32BIT_CONSTANTS_0003 pfnSetGraphicsRoot32BitConstants; PFND3D12DDI_SET_ROOT_BUFFER_VIEW pfnSetComputeRootConstantBufferView; PFND3D12DDI_SET_ROOT_BUFFER_VIEW pfnSetGraphicsRootConstantBufferView; PFND3D12DDI_SET_ROOT_BUFFER_VIEW pfnSetComputeRootShaderResourceView; PFND3D12DDI_SET_ROOT_BUFFER_VIEW pfnSetGraphicsRootShaderResourceView; PFND3D12DDI_SET_ROOT_BUFFER_VIEW pfnSetComputeRootUnorderedAccessView; PFND3D12DDI_SET_ROOT_BUFFER_VIEW pfnSetGraphicsRootUnorderedAccessView; PFND3D12DDI_IA_SET_INDEX_BUFFER pfnIASetIndexBuffer; PFND3D12DDI_IA_SET_VERTEX_BUFFERS_0003 pfnIASetVertexBuffers; PFND3D12DDI_SO_SET_TARGETS_0003 pfnSOSetTargets; PFND3D12DDI_OM_SET_RENDER_TARGETS_0003 pfnOMSetRenderTargets; PFND3D12DDI_SET_MARKER pfnSetMarker; PFND3D12DDI_CLEAR_ROOT_ARGUMENTS pfnClearRootArguments; } D3D12DDI_COMMAND_LIST_FUNCS_3D_0003; typedef struct D3D12DDI_DEVICE_FUNCS_CORE_0003 { PFND3D12DDI_CHECKFORMATSUPPORT pfnCheckFormatSupport; PFND3D12DDI_CHECKMULTISAMPLEQUALITYLEVELS pfnCheckMultisampleQualityLevels; PFND3D12DDI_GETMIPPACKING pfnGetMipPacking; PFND3D12DDI_CALCPRIVATEELEMENTLAYOUTSIZE pfnCalcPrivateElementLayoutSize; PFND3D12DDI_CREATEELEMENTLAYOUT_0003 pfnCreateElementLayout; PFND3D12DDI_DESTROYELEMENTLAYOUT pfnDestroyElementLayout; PFND3D12DDI_CALCPRIVATEBLENDSTATESIZE pfnCalcPrivateBlendStateSize; PFND3D12DDI_CREATEBLENDSTATE_0003 pfnCreateBlendState; PFND3D12DDI_DESTROYBLENDSTATE pfnDestroyBlendState; PFND3D12DDI_CALCPRIVATEDEPTHSTENCILSTATESIZE pfnCalcPrivateDepthStencilStateSize; PFND3D12DDI_CREATEDEPTHSTENCILSTATE_0003 pfnCreateDepthStencilState; PFND3D12DDI_DESTROYDEPTHSTENCILSTATE pfnDestroyDepthStencilState; PFND3D12DDI_CALCPRIVATERASTERIZERSTATESIZE pfnCalcPrivateRasterizerStateSize; PFND3D12DDI_CREATERASTERIZERSTATE_0003 pfnCreateRasterizerState; PFND3D12DDI_DESTROYRASTERIZERSTATE pfnDestroyRasterizerState; PFND3D12DDI_CALC_PRIVATE_SHADER_SIZE pfnCalcPrivateShaderSize; PFND3D12DDI_CREATE_SHADER_0003 pfnCreateVertexShader; PFND3D12DDI_CREATE_SHADER_0003 pfnCreatePixelShader; PFND3D12DDI_CREATE_SHADER_0003 pfnCreateGeometryShader; PFND3D12DDI_CREATE_COMPUTE_SHADER_0003 pfnCreateComputeShader; PFND3D12DDI_CALC_PRIVATE_GEOMETRY_SHADER_WITH_STREAM_OUTPUT pfnCalcPrivateGeometryShaderWithStreamOutput; PFND3D12DDI_CREATE_GEOMETRY_SHADER_WITH_STREAM_OUTPUT_0003 pfnCreateGeometryShaderWithStreamOutput; PFND3D12DDI_CALC_PRIVATE_TESSELLATION_SHADER_SIZE pfnCalcPrivateTessellationShaderSize; PFND3D12DDI_CREATE_TESS_SHADER_0003 pfnCreateHullShader; PFND3D12DDI_CREATE_TESS_SHADER_0003 pfnCreateDomainShader; PFND3D12DDI_DESTROYSHADER pfnDestroyShader; PFND3D12DDI_CALCPRIVATECOMMANDQUEUESIZE_0001 pfnCalcPrivateCommandQueueSize; PFND3D12DDI_CREATECOMMANDQUEUE_0001 pfnCreateCommandQueue; PFND3D12DDI_DESTROYCOMMANDQUEUE pfnDestroyCommandQueue; PFND3D12DDI_CALCPRIVATECOMMANDALLOCATORSIZE pfnCalcPrivateCommandAllocatorSize; PFND3D12DDI_CREATECOMMANDALLOCATOR pfnCreateCommandAllocator; PFND3D12DDI_DESTROYCOMMANDALLOCATOR pfnDestroyCommandAllocator; PFND3D12DDI_RESETCOMMANDALLOCATOR pfnResetCommandAllocator; PFND3D12DDI_CALC_PRIVATE_PIPELINE_STATE_SIZE_0001 pfnCalcPrivatePipelineStateSize; PFND3D12DDI_CREATE_PIPELINE_STATE_0001 pfnCreatePipelineState; PFND3D12DDI_DESTROY_PIPELINE_STATE pfnDestroyPipelineState; PFND3D12DDI_CALC_PRIVATE_COMMAND_LIST_SIZE_0001 pfnCalcPrivateCommandListSize; PFND3D12DDI_CREATE_COMMAND_LIST_0001 pfnCreateCommandList; PFND3D12DDI_DESTROYCOMMANDLIST pfnDestroyCommandList; PFND3D12DDI_CALCPRIVATEFENCESIZE pfnCalcPrivateFenceSize; PFND3D12DDI_CREATEFENCE pfnCreateFence; PFND3D12DDI_DESTROYFENCE pfnDestroyFence; PFND3D12DDI_CALC_PRIVATE_DESCRIPTOR_HEAP_SIZE_0001 pfnCalcPrivateDescriptorHeapSize; PFND3D12DDI_CREATE_DESCRIPTOR_HEAP_0001 pfnCreateDescriptorHeap; PFND3D12DDI_DESTROY_DESCRIPTOR_HEAP pfnDestroyDescriptorHeap; PFND3D12DDI_GET_DESCRIPTOR_SIZE_IN_BYTES pfnGetDescriptorSizeInBytes; PFND3D12DDI_GET_CPU_DESCRIPTOR_HANDLE_FOR_HEAP_START pfnGetCPUDescriptorHandleForHeapStart; PFND3D12DDI_GET_GPU_DESCRIPTOR_HANDLE_FOR_HEAP_START pfnGetGPUDescriptorHandleForHeapStart; PFND3D12DDI_CREATE_SHADER_RESOURCE_VIEW_0002 pfnCreateShaderResourceView; PFND3D12DDI_CREATE_CONSTANT_BUFFER_VIEW pfnCreateConstantBufferView; PFND3D12DDI_CREATE_SAMPLER pfnCreateSampler; PFND3D12DDI_CREATE_UNORDERED_ACCESS_VIEW_0002 pfnCreateUnorderedAccessView; PFND3D12DDI_CREATE_RENDER_TARGET_VIEW_0002 pfnCreateRenderTargetView; PFND3D12DDI_CREATE_DEPTH_STENCIL_VIEW pfnCreateDepthStencilView; PFND3D12DDI_CALC_PRIVATE_ROOT_SIGNATURE_SIZE_0001 pfnCalcPrivateRootSignatureSize; PFND3D12DDI_CREATE_ROOT_SIGNATURE_0001 pfnCreateRootSignature; PFND3D12DDI_DESTROY_ROOT_SIGNATURE pfnDestroyRootSignature; PFND3D12DDI_SERIALIZEOBJECT pfnSerializeObject; PFND3D12DDI_DESTROYOBJECTSERIALIZATION pfnDestroyObjectSerialization; PFND3D12DDI_CALCPRIVATEDESERIALIZEDOBJECTSIZE pfnCalcPrivateDeserializedObjectSize; PFND3D12DDI_CREATEDESERIALIZEDOBJECT pfnCreateDeserializedObject; PFND3D12DDI_MAPHEAP pfnMapHeap; PFND3D12DDI_UNMAPHEAP pfnUnmapHeap; PFND3D12DDI_CALCPRIVATEHEAPANDRESOURCESIZES_0003 pfnCalcPrivateHeapAndResourceSizes; PFND3D12DDI_CREATEHEAPANDRESOURCE_0003 pfnCreateHeapAndResource; PFND3D12DDI_DESTROYHEAPANDRESOURCE pfnDestroyHeapAndResource; PFND3D12DDI_MAKERESIDENT_0001 pfnMakeResident; PFND3D12DDI_EVICT2 pfnEvict; PFND3D12DDI_CALCPRIVATEOPENEDHEAPANDRESOURCESIZES_0003 pfnCalcPrivateOpenedHeapAndResourceSizes; PFND3D12DDI_OPENHEAPANDRESOURCE_0003 pfnOpenHeapAndResource; PFND3D12DDI_COPY_DESCRIPTORS_0003 pfnCopyDescriptors; PFND3D12DDI_COPY_DESCRIPTORS_SIMPLE_0003 pfnCopyDescriptorsSimple; PFND3D12DDI_CALC_PRIVATE_QUERY_HEAP_SIZE_0001 pfnCalcPrivateQueryHeapSize; PFND3D12DDI_CREATE_QUERY_HEAP_0001 pfnCreateQueryHeap; PFND3D12DDI_DESTROY_QUERY_HEAP pfnDestroyQueryHeap; PFND3D12DDI_CALC_PRIVATE_COMMAND_SIGNATURE_SIZE_0001 pfnCalcPrivateCommandSignatureSize; PFND3D12DDI_CREATE_COMMAND_SIGNATURE_0001 pfnCreateCommandSignature; PFND3D12DDI_DESTROY_COMMAND_SIGNATURE pfnDestroyCommandSignature; PFND3D12DDI_CHECKRESOURCEVIRTUALADDRESS pfnCheckResourceVirtualAddress; PFND3D12DDI_CHECKRESOURCEALLOCATIONINFO_0003 pfnCheckResourceAllocationInfo; PFND3D12DDI_CHECKSUBRESOURCEINFO pfnCheckSubresourceInfo; PFND3D12DDI_CHECKEXISITINGRESOURCEALLOCATIONINFO pfnCheckExistingResourceAllocationInfo; PFND3D12DDI_OFFERRESOURCES pfnOfferResources; PFND3D12DDI_RECLAIMRESOURCES_0001 pfnReclaimResources; PFND3D12DDI_GETIMPLICITPHYSICALADAPTERMASK pfnGetImplicitPhysicalAdapterMask; PFND3D12DDI_GET_PRESENT_PRIVATE_DRIVER_DATA_SIZE pfnGetPresentPrivateDriverDataSize; PFND3D12DDI_QUERY_NODE_MAP pfnQueryNodeMap; PFND3D12DDI_RETRIEVE_SHADER_COMMENT_0003 pfnRetrieveShaderComment; PFND3D12DDI_CHECKRESOURCEALLOCATIONHANDLE pfnCheckResourceAllocationHandle; } D3D12DDI_DEVICE_FUNCS_CORE_0003; //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Release 1 #define D3D12DDI_MINOR_VERSION_R1 10 #define D3D12DDI_INTERFACE_VERSION_R1 ((D3D12DDI_MAJOR_VERSION << 16) | D3D12DDI_MINOR_VERSION_R1) #define D3D12DDI_BUILD_VERSION_0010 0 #define D3D12DDI_SUPPORTED_0010 ((((UINT64)D3D12DDI_INTERFACE_VERSION_R1) << 32) | (((UINT64)D3D12DDI_BUILD_VERSION_0010) << 16)) // UMD handle types */ out IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HPIPELINESTATE MAKE_D3D12DDI_HPIPELINESTATE(IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HPROTECTEDRESOURCESESSION_0030 MAKE_D3D12DDI_HPROTECTEDRESOURCESESSION_0030(/* Build rev 0. #define D3D12DDI_MINOR_VERSION_R3 30 #define D3D12DDI_INTERFACE_VERSION_R3 ((D3D12DDI_MAJOR_VERSION << 16) | D3D12DDI_MINOR_VERSION_R3) #define D3D12DDI_BUILD_VERSION_0030 0 #define D3D12DDI_SUPPORTED_0030 ((((UINT64)D3D12DDI_INTERFACE_VERSION_R3) << 32) | (((UINT64)D3D12DDI_BUILD_VERSION_0030) << 16)) D3D10DDI_H( D3D12DDI_HCRYPTOSESSION_0030 ) D3D10DDI_H( D3D12DDI_HCRYPTOSESSIONPOLICY_0030 ) */ IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HQUERYHEAP MAKE_D3D12DDI_HQUERYHEAP(IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HROOTSIGNATURE MAKE_D3D12DDI_HROOTSIGNATURE(IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HRTCOMMANDLIST MAKE_D3D12DDI_HRTCOMMANDLIST(IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HRTCOMMANDQUEUE MAKE_D3D12DDI_HRTCOMMANDQUEUE(IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HRTMETACOMMAND_0052 MAKE_D3D12DDI_HRTMETACOMMAND_0052(IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HRTPAGINGQUEUE MAKE_D3D12DDI_HRTPAGINGQUEUE(IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HRTPIPELINESTATE MAKE_D3D12DDI_HRTPIPELINESTATE(IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HRTPROTECTEDSESSION_0030 MAKE_D3D12DDI_HRTPROTECTEDSESSION_0030(/* Build rev 4. // Adding shader cap: // BOOL AtomicInt64OnDescriptorHeapResource; // BOOL MeshShaderPerPrimitiveShadingRateSupported // #define D3D12DDI_BUILD_VERSION_0084 4 #define D3D12DDI_SUPPORTED_0084 ((((UINT64)D3D12DDI_INTERFACE_VERSION_R8) << 32) | (((UINT64)D3D12DDI_BUILD_VERSION_0084) << 16)) // D3D12DDICAPS_TYPE_SHADER typedef struct D3D12DDI_SHADER_CAPS_0084 { D3D12DDI_SHADER_MIN_PRECISION MinPrecision; // Bitmask BOOL DoubleOps; BOOL ShaderSpecifiedStencilRef; BOOL TypedUAVLoadAdditionalFormats; BOOL ROVs; BOOL WaveOps; UINT WaveLaneCountMin; UINT WaveLaneCountMax; UINT TotalLaneCount; BOOL Int64Ops; BOOL Native16BitOps; BOOL AtomicInt64OnTypedResource; BOOL AtomicInt64OnGroupShared; BOOL DerivativesInMeshAndAmplificationShaders; D3D12DDI_WAVE_MMA_TIER WaveMMATier; BOOL AtomicInt64OnDescriptorHeapResource; } D3D12DDI_SHADER_CAPS_0084; //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Extended Feature Content Protection Resources // Feature: D3D12DDI_FEATURE_0030_CONTENT_PROTECTION_RESOURCES // Version: D3D12DDI_FEATURE_VERSION_CONTENT_PROTECTION_RESOURCES_0030_0 // Usermode DDI Min Version: D3D12DDI_SUPPORTED_0030 #define D3D12DDI_FEATURE_VERSION_CONTENT_PROTECTION_RESOURCES_0030_0 1u */ IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HRTSCHEDULINGGROUP_0050 MAKE_D3D12DDI_HRTSCHEDULINGGROUP_0050(IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HRTSTATEOBJECT_0054 MAKE_D3D12DDI_HRTSTATEOBJECT_0054(IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HRTTABLE MAKE_D3D12DDI_HRTTABLE(IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HSCHEDULINGGROUP_0050 MAKE_D3D12DDI_HSCHEDULINGGROUP_0050(IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HSTATEOBJECT_0054 MAKE_D3D12DDI_HSTATEOBJECT_0054(IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HUNORDEREDACCESSVIEWCOUNTER MAKE_D3D12DDI_HUNORDEREDACCESSVIEWCOUNTER(IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HVIDEODECODERHEAP_0032 MAKE_D3D12DDI_HVIDEODECODERHEAP_0032(/* } D3D12DDI_CRYPTO_SESSION_TRANSFORM_OPERATION_0030; // D3D12DDICAPS_TYPE_0030_CRYPTO_SESSION_TRANSFORM_SUPPORT typedef struct D3D12DDI_VIDEO_CRYPTO_SESSION_TRANSFORM_SUPPORT_DATA_0030 { UINT NodeIndex; // input GUID DecodeProfile; // input GUID ContentProtectionSystem; // input D3D12DDI_CRYPTO_SESSION_FLAGS_0030 Flags; // input D3D12DDI_BITSTREAM_ENCRYPTION_TYPE_0030 BitstreamEncryption; // input D3D12DDI_CRYPTO_SESSION_TRANSFORM_OPERATION_0030 Operation; // input BOOL ProtectedOutputRequired; // output UINT64 InputAlignment; // output UINT64 InputPreambleSize; // output UINT64 OutputAlignment; // output UINT64 OutputPreambleSize; // output D3D12DDI_CRYPTO_SESSION_TRANSFORM_SUPPORT_FLAGS_0030 Support; // output } D3D12DDI_VIDEO_CRYPTO_SESSION_TRANSFORM_SUPPORT_DATA_0030; typedef struct D3D12DDIARG_CREATE_PROTECTED_RESOURCE_SESSION_0030 { UINT NodeMask; } D3D12DDIARG_CREATE_PROTECTED_RESOURCE_SESSION_0030; typedef SIZE_T ( APIENTRY* PFND3D12DDI_CALCPRIVATEPROTECTEDRESOURCESESSIONSIZE_0030 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_PROTECTED_RESOURCE_SESSION_0030* pArgs ); typedef HRESULT ( APIENTRY* PFND3D12DDI_CREATEPROTECTEDRESOURCESESSION_0030 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_PROTECTED_RESOURCE_SESSION_0030* pArgs, D3D12DDI_HPROTECTEDRESOURCESESSION_0030 hDrvProtectedResourceSession, D3D12DDI_HRTPROTECTEDSESSION_0030 hRtProtectedSession ); typedef struct D3D12DDIARG_OPEN_PROTECTED_RESOURCE_SESSION_0030 { CONST VOID* pPrivateDriverData; UINT PrivateDriverDataSize; } D3D12DDIARG_OPEN_PROTECTED_RESOURCE_SESSION_0030; typedef SIZE_T ( APIENTRY* PFND3D12DDI_CALCPRIVATEOPENEDPROTECTEDRESOURCESESSIONSIZE_0030)( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_OPEN_PROTECTED_RESOURCE_SESSION_0030* pArgs ); typedef HRESULT ( APIENTRY* PFND3D12DDI_OPENPROTECTEDRESOURCESESSION_0030 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_OPEN_PROTECTED_RESOURCE_SESSION_0030* pArgs, D3D12DDI_HPROTECTEDRESOURCESESSION_0030 hDrvProtectedResourceSession ); typedef VOID ( APIENTRY* PFND3D12DDI_DESTROYPROTECTEDRESOURCESESSION_0030 )( D3D12DDI_HDEVICE hDrvDevice, D3D12DDI_HPROTECTEDRESOURCESESSION_0030 hDrvProtectedResourceSession ); // D3D12DDI_TABLE_TYPE_0030_DEVICE_CONTENT_PROTECTION_RESOURCES typedef struct D3D12DDI_DEVICE_FUNCS_CONTENT_PROTECTION_RESOURCES_0030 { PFND3D12DDI_CALCPRIVATEPROTECTEDRESOURCESESSIONSIZE_0030 pfnCalcPrivateProtectedResourceSessionSize; PFND3D12DDI_CREATEPROTECTEDRESOURCESESSION_0030 pfnCreateProtectedResourceSession; PFND3D12DDI_CALCPRIVATEOPENEDPROTECTEDRESOURCESESSIONSIZE_0030 pfnCalcPrivateOpenedProtectedResourceSessionSize; PFND3D12DDI_OPENPROTECTEDRESOURCESESSION_0030 pfnOpenProtectedResourceSession; PFND3D12DDI_DESTROYPROTECTEDRESOURCESESSION_0030 pfnDestroyProtectedResourceSession; } D3D12DDI_DEVICE_FUNCS_CONTENT_PROTECTION_RESOURCES_0030; typedef struct D3D12DDICB_CREATE_PROTECTED_SESSION_0030 { CONST VOID* pPrivateDriverData; UINT PrivateDriverDataSize; } D3D12DDICB_CREATE_PROTECTED_SESSION_0030; typedef HRESULT(APIENTRY CALLBACK* PFND3D12DDI_CREATE_PROTECTED_SESSION_CB_0030)( D3D12DDI_HRTDEVICE hRTDevice, D3D12DDI_HRTPROTECTEDSESSION_0030 hRTProtectedSession, _In_ D3D12DDICB_CREATE_PROTECTED_SESSION_0030* pArgs ); // D3D12DDI_TABLE_TYPE_0030_CONTENT_PROTECTION_CALLBACKS typedef struct D3D12DDI_CONTENT_PROTECTION_CALLBACKS_0030 { PFND3D12DDI_CREATE_PROTECTED_SESSION_CB_0030 pfnCreateProtectedSessionCB; } D3D12DDI_CONTENT_PROTECTION_CALLBACKS_0030; //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Extended Feature Content Protection Resources // Feature: D3D12DDI_FEATURE_0030_CONTENT_PROTECTION_RESOURCES // Version: D3D12DDI_FEATURE_VERSION_CONTENT_PROTECTION_RESOURCES_0040_0 // Usermode DDI Min Version: D3D12DDI_SUPPORTED_0040 #define D3D12DDI_FEATURE_VERSION_CONTENT_PROTECTION_RESOURCES_0040_0 2u //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Extended Feature Content Protection Resources // Feature: D3D12DDI_FEATURE_0030_CONTENT_PROTECTION_RESOURCES // Version: D3D12DDI_FEATURE_VERSION_CONTENT_PROTECTION_RESOURCES_0074_0 // Usermode DDI Min Version: D3D12DDI_SUPPORTED_0040 #define D3D12DDI_FEATURE_VERSION_CONTENT_PROTECTION_RESOURCES_0074_0 3u DEFINE_GUID(D3D12DDI_PROTECTED_RESOURCES_SESSION_HARDWARE_PROTECTED, 0x62B0084E, 0xC70E, 0x4DAA, 0xA1, 0x09, 0x30, 0xFF, 0x8D, 0x5A, 0x04, 0x82); // D3D12DDICAPS_TYPE_0074_PROTECTED_RESOURCE_SESSION_TYPE_COUNT typedef struct D3D12DDI_PROTECTED_RESOURCE_SESSION_TYPE_COUNT_DATA_0074 { UINT NodeIndex; // input UINT Count; // output } D3D12DDI_PROTECTED_RESOURCE_SESSION_TYPE_COUNT_DATA_0074; // D3D12DDICAPS_TYPE_0074_PROTECTED_RESOURCE_SESSION_TYPES typedef struct D3D12DDI_PROTECTED_RESOURCE_SESSION_TYPES_DATA_0074 { UINT NodeIndex; // input UINT Count; // input GUID* pTypes; // output } D3D12DDI_PROTECTED_RESOURCE_SESSION_TYPES_DATA_0074; typedef struct D3D12DDIARG_CREATE_PROTECTED_RESOURCE_SESSION_0074 { UINT NodeMask; GUID ProtectionType; } D3D12DDIARG_CREATE_PROTECTED_RESOURCE_SESSION_0074; typedef SIZE_T ( APIENTRY* PFND3D12DDI_CALCPRIVATEPROTECTEDRESOURCESESSIONSIZE_0074 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_PROTECTED_RESOURCE_SESSION_0074* pArgs ); typedef HRESULT ( APIENTRY* PFND3D12DDI_CREATEPROTECTEDRESOURCESESSION_0074 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_PROTECTED_RESOURCE_SESSION_0074* pArgs, D3D12DDI_HPROTECTEDRESOURCESESSION_0030 hDrvProtectedResourceSession, D3D12DDI_HRTPROTECTEDSESSION_0030 hRtProtectedSession ); // D3D12DDI_TABLE_TYPE_0030_DEVICE_CONTENT_PROTECTION_RESOURCES typedef struct D3D12DDI_DEVICE_FUNCS_CONTENT_PROTECTION_RESOURCES_0074 { PFND3D12DDI_CALCPRIVATEPROTECTEDRESOURCESESSIONSIZE_0074 pfnCalcPrivateProtectedResourceSessionSize; PFND3D12DDI_CREATEPROTECTEDRESOURCESESSION_0074 pfnCreateProtectedResourceSession; PFND3D12DDI_CALCPRIVATEOPENEDPROTECTEDRESOURCESESSIONSIZE_0030 pfnCalcPrivateOpenedProtectedResourceSessionSize; PFND3D12DDI_OPENPROTECTEDRESOURCESESSION_0030 pfnOpenProtectedResourceSession; PFND3D12DDI_DESTROYPROTECTEDRESOURCESESSION_0030 pfnDestroyProtectedResourceSession; } D3D12DDI_DEVICE_FUNCS_CONTENT_PROTECTION_RESOURCES_0074; //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Extended Feature Content Protection Streaming // Feature: D3D12DDI_FEATURE_0030_CONTENT_PROTECTION_STREAMING // Version: D3D12DDI_FEATURE_VERSION_CONTENT_PROTECTION_STREAMING_0030_0 // Usermode DDI Min Version: D3D12DDI_SUPPORTED_0030 #define D3D12DDI_FEATURE_VERSION_CONTENT_PROTECTION_STREAMING_0030_0 1u typedef struct D3D12DDIARG_CREATE_CRYPTO_SESSION_0030 { UINT NodeMask; GUID DecodeProfile; GUID ContentProtectionSystem; D3D12DDI_BITSTREAM_ENCRYPTION_TYPE_0030 BitstreamEncryption; D3D12DDI_CRYPTO_SESSION_FLAGS_0030 Flags; } D3D12DDIARG_CREATE_CRYPTO_SESSION_0030; typedef SIZE_T ( APIENTRY* PFND3D12DDI_CALCPRIVATECRYPTOSESSIONSIZE_0030 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_CRYPTO_SESSION_0030* pArgs ); typedef HRESULT ( APIENTRY* PFND3D12DDI_CREATECRYPTOSESSION_0030 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_CRYPTO_SESSION_0030* pArgs, D3D12DDI_HCRYPTOSESSION_0030 hDrvCryptoSession, D3D12DDI_HRTPROTECTEDSESSION_0030 hRtProtectedSession ); typedef struct D3D12DDIARG_OPEN_CRYPTO_SESSION_0030 { CONST VOID* pPrivateDriverData; UINT PrivateDriverDataSize; } D3D12DDIARG_OPEN_CRYPTO_SESSION_0030; typedef SIZE_T ( APIENTRY* PFND3D12DDI_CALCPRIVATEOPENEDCRYPTOSESSIONSIZE_0030 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_OPEN_CRYPTO_SESSION_0030* pArgs ); typedef HRESULT ( APIENTRY* PFND3D12DDI_OPENCRYPTOSESSION_0030 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_OPEN_CRYPTO_SESSION_0030* pArgs, D3D12DDI_HCRYPTOSESSION_0030 hDrvCryptoSession ); typedef VOID ( APIENTRY* PFND3D12DDI_DESTROYCRYPTOSESSION_0030 )( D3D12DDI_HDEVICE hDrvDevice, D3D12DDI_HCRYPTOSESSION_0030 hDrvCryptoSession ); typedef HRESULT ( APIENTRY* PFND3D12DDI_GETKEYBASEDATA_0030 ) ( D3D12DDI_HDEVICE hDrvDevice, D3D12DDI_HCRYPTOSESSION_0030 hDrvCryptoSession, _In_reads_bytes_(KeyInputDataSize) CONST VOID* pKeyInputData, UINT KeyInputDataSize, _Out_writes_bytes_(KeyBaseDataSize) VOID* pKeyBaseData, UINT KeyBaseDataSize ); typedef struct D3D12DDIARG_CREATE_CRYPTO_SESSION_POLICY_0030 { const void* pKeyInfo; UINT KeyInfoSize; } D3D12DDIARG_CREATE_CRYPTO_SESSION_POLICY_0030; typedef SIZE_T ( APIENTRY* PFND3D12DDI_CALCPRIVATECRYPTOSESSIONPOLICYSIZE_0030 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_CRYPTO_SESSION_POLICY_0030* pArgs, D3D12DDI_HCRYPTOSESSION_0030 hDrvCryptoSession ); typedef HRESULT ( APIENTRY* PFND3D12DDI_CREATECRYPTOSESSIONPOLICY_0030 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_CRYPTO_SESSION_POLICY_0030* pArgs, D3D12DDI_HCRYPTOSESSION_0030 hDrvCryptoSession, D3D12DDI_HCRYPTOSESSIONPOLICY_0030 hDrvCryptoSessionPolicy, D3D12DDI_HRTPROTECTEDSESSION_0030 hRtProtectedSession ); typedef struct D3D12DDIARG_OPEN_CRYPTO_SESSION_POLICY_0030 { const void* pPrivateDriverData; UINT PrivateDriverDataSize; } D3D12DDIARG_OPEN_CRYPTO_SESSION_POLICY_0030; typedef SIZE_T ( APIENTRY* PFND3D12DDI_CALCPRIVATEOPENEDCRYPTOSESSIONPOLICYSIZE_0030 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_OPEN_CRYPTO_SESSION_POLICY_0030* pArgs ); typedef HRESULT ( APIENTRY* PFND3D12DDI_OPENCRYPTOSESSIONPOLICY_0030 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_OPEN_CRYPTO_SESSION_POLICY_0030* pArgs, D3D12DDI_HCRYPTOSESSIONPOLICY_0030 hDrvCryptoSessionPolicy ); typedef VOID ( APIENTRY* PFND3D12DDI_DESTROYCRYPTOSESSIONPOLICY_0030 )( D3D12DDI_HDEVICE hDrvDevice, D3D12DDI_HCRYPTOSESSIONPOLICY_0030 hDrvCryptoSessionPolicy ); typedef struct D3D12DDI_CRYPTO_SESSION_TRANSFORM_DECRYPT_HEADER_INPUT_ARGUMENTS_0030 { BOOL Enable; _Field_size_bytes_full_(SliceHeadersSize) const void* pSliceHeaders; UINT64 SliceHeadersSize; _Field_size_full_(SliceHeaderCount) const DWORD* pSliceHeadersOffsets; UINT64 SliceHeaderCount; _Field_size_bytes_full_(ContextSize) const void* pContext; UINT64 ContextSize; } D3D12DDI_CRYPTO_SESSION_TRANSFORM_DECRYPT_HEADER_INPUT_ARGUMENTS_0030; typedef struct D3D12DDI_CRYPTO_SESSION_TRANSFORM_INPUT_ARGUMENTS_0030 { D3D12DDI_HCRYPTOSESSIONPOLICY_0030 hDrvCryptoSessionPolicy; D3D12DDI_HRESOURCE hDrvBuffer; UINT64 Size; UINT64 Offset; _Field_size_bytes_full_(IVSize) const void* pIV; UINT IVSize; _Field_size_bytes_full_(SubSampleMappingCount) const void* pSubSampleMappingBlock; UINT SubSampleMappingCount; _Field_size_bytes_full_(ContextSize) const void* pContext; UINT64 ContextSize; D3D12DDI_CRYPTO_SESSION_TRANSFORM_DECRYPT_HEADER_INPUT_ARGUMENTS_0030 EncryptedHeader; } D3D12DDI_CRYPTO_SESSION_TRANSFORM_INPUT_ARGUMENTS_0030; typedef struct D3D12DDI_CRYPTO_SESSION_TRANSFORM_DECRYPT_HEADER_OUTPUT_ARGUMENTS_0030 { BOOL Enable; _Field_size_bytes_full_(SliceHeadersSize) const void *pSliceHeaders; UINT64 SliceHeadersSize; _Field_size_bytes_full_(ContextSize) const void* pContext; UINT64 ContextSize; } D3D12DDI_CRYPTO_SESSION_TRANSFORM_DECRYPT_HEADER_OUTPUT_ARGUMENTS_0030; typedef struct D3D12DDI_CRYPTO_SESSION_TRANSFORM_DECRYPT_OUTPUT_ARGUMENTS_0030 { BOOL Enable; D3D12DDI_HRESOURCE hDrvBuffer; UINT64 Size; UINT64 Offset; } D3D12DDI_CRYPTO_SESSION_TRANSFORM_DECRYPT_OUTPUT_ARGUMENTS_0030; typedef struct D3D12DDI_CRYPTO_SESSION_TRANSFORM_TRANSCRYPT_OUTPUT_ARGUMENTS_0030 { BOOL Enable; _Field_size_bytes_full_(IVSize) void* pIV; UINT IVSize; } D3D12DDI_CRYPTO_SESSION_TRANSFORM_TRANSCRYPT_OUTPUT_ARGUMENTS_0030; typedef struct D3D12DDI_CRYPTO_SESSION_TRANSFORM_OUTPUT_ARGUMENTS_0030 { D3D12DDI_CRYPTO_SESSION_TRANSFORM_DECRYPT_OUTPUT_ARGUMENTS_0030 Decrypt; D3D12DDI_CRYPTO_SESSION_TRANSFORM_TRANSCRYPT_OUTPUT_ARGUMENTS_0030 Transcrypt; D3D12DDI_CRYPTO_SESSION_TRANSFORM_DECRYPT_HEADER_OUTPUT_ARGUMENTS_0030 ClearHeader; } D3D12DDI_CRYPTO_SESSION_TRANSFORM_OUTPUT_ARGUMENTS_0030; typedef HRESULT ( APIENTRY* PFND3D12DDI_TRANSFORMENCRYPTEDDATA_0030 )( D3D12DDI_HDEVICE hDrvDevice, D3D12DDI_CRYPTO_SESSION_TRANSFORM_OPERATION_0030 Operation, _In_ const D3D12DDI_CRYPTO_SESSION_TRANSFORM_OUTPUT_ARGUMENTS_0030* pOutputArguments, _In_ const D3D12DDI_CRYPTO_SESSION_TRANSFORM_INPUT_ARGUMENTS_0030* pInputArguments ); // D3D12DDI_TABLE_TYPE_0030_DEVICE_CONTENT_PROTECTION_STREAMING typedef struct D3D12DDI_DEVICE_FUNCS_CONTENT_PROTECTION_STREAMING_0030 { PFND3D12DDI_CALCPRIVATECRYPTOSESSIONSIZE_0030 pfnCalcPrivateCryptoSessionSize; PFND3D12DDI_CREATECRYPTOSESSION_0030 pfnCreateCryptoSession; PFND3D12DDI_CALCPRIVATEOPENEDCRYPTOSESSIONSIZE_0030 pfnCalcPrivateOpenedCryptoSessionSize; PFND3D12DDI_OPENCRYPTOSESSION_0030 pfnOpenCryptoSession; PFND3D12DDI_DESTROYCRYPTOSESSION_0030 pfnDestroyCryptoSession; PFND3D12DDI_GETKEYBASEDATA_0030 pfnGetKeyBaseData; PFND3D12DDI_CALCPRIVATECRYPTOSESSIONPOLICYSIZE_0030 pfnCalcPrivateCryptoSessionPolicySize; PFND3D12DDI_CREATECRYPTOSESSIONPOLICY_0030 pfnCreateCryptoSessionPolicy; PFND3D12DDI_CALCPRIVATEOPENEDCRYPTOSESSIONPOLICYSIZE_0030 pfnCalcPrivateOpenedCryptoSessionPolicySize; PFND3D12DDI_OPENCRYPTOSESSIONPOLICY_0030 pfnOpenCryptoSessionPolicy; PFND3D12DDI_DESTROYCRYPTOSESSIONPOLICY_0030 pfnDestroyCryptoSessionPolicy; PFND3D12DDI_TRANSFORMENCRYPTEDDATA_0030 pfnTransformEncryptedData; } D3D12DDI_DEVICE_FUNCS_CONTENT_PROTECTION_STREAMING_0030; //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Extended Feature Video // Version: D3D12DDI_FEATURE_VERSION_VIDEO_0030_0 // Usermode DDI Min Version: D3D12DDI_SUPPORTED_0021 typedef struct D3D12DDI_VIDEO_DECODE_DECRYPTION_ARGUMENTS_0030 { D3D12DDI_HCRYPTOSESSIONPOLICY_0030 hDrvCryptoSessionPolicy; CONST VOID* pIV; UINT IVSize; CONST VOID* pSubSampleMappingBlock; UINT SubSampleMappingCount; } D3D12DDI_VIDEO_DECODE_DECRYPTION_ARGUMENTS_0030; //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Extended Feature Video // Version: D3D12DDI_FEATURE_VERSION_VIDEO_0032_0 // Usermode DDI Min Version: D3D12DDI_SUPPORTED_0021 // UMD handle types */ IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HVIDEODECODER_0020 MAKE_D3D12DDI_HVIDEODECODER_0020(/* optional(void) */ IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HVIDEOENCODERHEAP_0080 MAKE_D3D12DDI_HVIDEOENCODERHEAP_0080(/* } D3D12DDI_VIDEO_PROTECTED_RESOURCE_SUPPORT_FLAGS_0072; DEFINE_ENUM_FLAG_OPERATORS( D3D12DDI_VIDEO_PROTECTED_RESOURCE_SUPPORT_FLAGS_0072 ); // D3D12DDICAPS_TYPE_VIDEO_0072_DECODE_PROTECTED_RESOURCES // *pInfo = nullptr // pData = D3D12DDI_VIDEO_DECODE_PROTECTED_RESOURCES_DATA_0072 // DataSize = sizeof(D3D12DDI_VIDEO_DECODE_PROTECTED_RESOURCES_DATA_0072) typedef struct D3D12DDI_VIDEO_DECODE_PROTECTED_RESOURCES_DATA_0072 { UINT NodeIndex; // input D3D12DDI_VIDEO_DECODE_CONFIGURATION_0020 Configuration; // input D3D12DDI_VIDEO_PROTECTED_RESOURCE_SUPPORT_FLAGS_0072 SupportFlags; // output } D3D12DDI_VIDEO_DECODE_PROTECTED_RESOURCES_DATA_0072; // D3D12DDICAPS_TYPE_VIDEO_0072_PROCESS_PROTECTED_RESOURCES // *pInfo = nullptr // pData = D3D12DDI_VIDEO_PROCESS_PROTECTED_RESOURCES_DATA_0072 // DataSize = sizeof(D3D12DDI_VIDEO_PROCESS_PROTECTED_RESOURCES_DATA_0072) typedef struct D3D12DDI_VIDEO_PROCESS_PROTECTED_RESOURCES_DATA_0072 { UINT NodeIndex; // input D3D12DDI_VIDEO_PROTECTED_RESOURCE_SUPPORT_FLAGS_0072 SupportFlags; // output } D3D12DDI_VIDEO_PROCESS_PROTECTED_RESOURCES_DATA_0072; // D3D12DDICAPS_TYPE_VIDEO_0072_MOTION_ESTIMATOR_PROTECTED_RESOURCES // *pInfo = nullptr // pData = D3D12DDI_VIDEO_MOTION_ESTIMATOR_PROTECTED_RESOURCES_DATA_0072 // DataSize = sizeof(D3D12DDI_VIDEO_MOTION_ESTIMATOR_PROTECTED_RESOURCES_DATA_0072) typedef struct D3D12DDI_VIDEO_MOTION_ESTIMATOR_PROTECTED_RESOURCES_DATA_0072 { UINT NodeIndex; // input D3D12DDI_VIDEO_PROTECTED_RESOURCE_SUPPORT_FLAGS_0072 SupportFlags; // output } D3D12DDI_VIDEO_MOTION_ESTIMATOR_PROTECTED_RESOURCES_DATA_0072; // D3D12DDICAPS_TYPE_VIDEO_0032_DECODER_HEAP_SIZE // *pInfo = nullptr // pData = D3D12DDI_VIDEO_DECODER_HEAP_SIZE_DATA_0072 // DataSize = sizeof(D3D12DDI_VIDEO_DECODER_HEAP_SIZE_DATA_0072) typedef struct D3D12DDI_VIDEO_DECODER_HEAP_SIZE_DATA_0072 { UINT NodeMask; D3D12DDI_VIDEO_DECODE_CONFIGURATION_0020 Configuration; // input UINT DecodeWidth; // input UINT DecodeHeight; // input DXGI_FORMAT Format; // input DXGI_RATIONAL FrameRate; // input UINT BitRate; // input UINT MaxDecodePictureBufferCount; // input BOOL Protected; // input UINT64 MemoryPoolL0Size; // output UINT64 MemoryPoolL1Size; // output } D3D12DDI_VIDEO_DECODER_HEAP_SIZE_DATA_0072; // D3D12DDICAPS_TYPE_VIDEO_0032_PROCESSOR_SIZE // *pInfo = nullptr // pData = D3D12DDI_VIDEO_PROCESSOR_SIZE_DATA_0072 // DataSize = sizeof(D3D12DDI_VIDEO_PROCESSOR_SIZE_DATA_0072) typedef struct D3D12DDI_VIDEO_PROCESSOR_SIZE_DATA_0072 { UINT NodeMask; // input D3D12DDI_VIDEO_PROCESS_OUTPUT_STREAM_DESC_0032 OutputStream; // input D3D12DDI_VIDEO_PROCESSOR_INPUT_STREAM_DESC_0043* pInputStreams; // input UINT NumInputStreams; // input BOOL Protected; // input UINT64 MemoryPoolL0Size; // output UINT64 MemoryPoolL1Size; // output } D3D12DDI_VIDEO_PROCESSOR_SIZE_DATA_0072; typedef struct D3D12DDIARG_CREATE_VIDEO_DECODER_0072 { UINT NodeMask; D3D12DDI_VIDEO_DECODE_CONFIGURATION_0020 Configuration; D3D12DDI_HPROTECTEDRESOURCESESSION_0030 hDrvProtectedResourceSession; } D3D12DDIARG_CREATE_VIDEO_DECODER_0072; typedef struct D3D12DDIARG_CREATE_VIDEO_DECODER_HEAP_0072 { UINT NodeMask; D3D12DDI_VIDEO_DECODE_CONFIGURATION_0020 Configuration; UINT DecodeWidth; UINT DecodeHeight; DXGI_FORMAT Format; DXGI_RATIONAL FrameRate; UINT BitRate; UINT MaxDecodePictureBufferCount; D3D12DDI_HPROTECTEDRESOURCESESSION_0030 hDrvProtectedResourceSession; } D3D12DDIARG_CREATE_VIDEO_DECODER_HEAP_0072; typedef struct D3D12DDIARG_CREATE_VIDEO_PROCESSOR_0072 { UINT NodeMask; D3D12DDI_VIDEO_PROCESS_OUTPUT_STREAM_DESC_0032 OutputStream; D3D12DDI_VIDEO_PROCESSOR_INPUT_STREAM_DESC_0043* pInputStreams; UINT NumInputStreams; D3D12DDI_HPROTECTEDRESOURCESESSION_0030 hDrvProtectedResourceSession; } D3D12DDIARG_CREATE_VIDEO_PROCESSOR_0072; typedef SIZE_T ( APIENTRY* PFND3D12DDI_CALCPRIVATEVIDEODECODERSIZE_0072 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_VIDEO_DECODER_0072* pArgs); typedef HRESULT ( APIENTRY* PFND3D12DDI_CREATEVIDEODECODER_0072 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_VIDEO_DECODER_0072* pArgs, D3D12DDI_HVIDEODECODER_0020 hDrvVideoDecoder ); typedef SIZE_T ( APIENTRY* PFND3D12DDI_CALCPRIVATEVIDEODECODERHEAPSIZE_0072 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_VIDEO_DECODER_HEAP_0072* pArgs); typedef HRESULT ( APIENTRY* PFND3D12DDI_CREATEVIDEODECODERHEAP_0072 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_VIDEO_DECODER_HEAP_0072*, D3D12DDI_HVIDEODECODERHEAP_0032 hDrvVideoDecoderHeap ); typedef SIZE_T ( APIENTRY* PFND3D12DDI_CALCPRIVATEVIDEOPROCESSORSIZE_0072 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_VIDEO_PROCESSOR_0072* pArgs); typedef HRESULT ( APIENTRY* PFND3D12DDI_CREATEVIDEOPROCESSOR_0072 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_VIDEO_PROCESSOR_0072* pArgs, D3D12DDI_HVIDEOPROCESSOR_0020 hDrvVideoProcessor); // D3D12DDI_TABLE_TYPE_0020_DEVICE_VIDEO typedef struct D3D12DDI_DEVICE_FUNCS_VIDEO_0072 { PFND3D12DDI_VIDEO_GETCAPS pfnGetCaps; PFND3D12DDI_CALCPRIVATEVIDEODECODERSIZE_0072 pfnCalcPrivateVideoDecoderSize; PFND3D12DDI_CREATEVIDEODECODER_0072 pfnCreateVideoDecoder; PFND3D12DDI_DESTROYVIDEODECODER_0021 pfnDestroyVideoDecoder; PFND3D12DDI_CALCPRIVATEVIDEODECODERHEAPSIZE_0072 pfnCalcPrivateVideoDecoderHeapSize; PFND3D12DDI_CREATEVIDEODECODERHEAP_0072 pfnCreateVideoDecoderHeap; PFND3D12DDI_DESTROYVIDEODECODERHEAP_0032 pfnDestroyVideoDecoderHeap; PFND3D12DDI_CALCPRIVATEVIDEOPROCESSORSIZE_0072 pfnCalcPrivateVideoProcessorSize; PFND3D12DDI_CREATEVIDEOPROCESSOR_0072 pfnCreateVideoProcessor; PFND3D12DDI_DESTROYVIDEOPROCESSOR_0021 pfnDestroyVideoProcessor; PFND3D12DDI_CALCPRIVATEVIDEOMOTIONESTIMATORSIZE_0060 pfnCalcPrivateVideoMotionEstimatorSize; PFND3D12DDI_CREATEVIDEOMOTIONESTIMATOR_0060 pfnCreateVideoMotionEstimator; PFND3D12DDI_DESTROYVIDEOMOTIONESTIMATOR_0053 pfnDestroyVideoMotionEstimator; PFND3D12DDI_CALCPRIVATEVIDEOMOTIONVECTORHEAPSIZE_0060 pfnCalcPrivateVideoMotionVectorHeapSize; PFND3D12DDI_CREATEVIDEOMOTIONVECTORHEAP_0060 pfnCreateVideoMotionVectorHeap; PFND3D12DDI_DESTROYVIDEOMOTIONVECTORHEAP_0053 pfnDestroyVideoMotionVectorHeap; PFND3D12DDI_CALCPRIVATEVIDEOEXTENSIONCOMMANDSIZE_0061 pfnCalcPrivateVideoExtensionCommandSize; PFND3D12DDI_CREATEVIDEOEXTENSIONCOMMAND_0063 pfnCreateVideoExtensionCommand; PFND3D12DDI_DESTROYVIDEOEXTENSIONCOMMAND_0063 pfnDestroyVideoExtensionCommand; } D3D12DDI_DEVICE_FUNCS_VIDEO_0072; //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Extended Feature Video // Version: D3D12DDI_FEATURE_VERSION_VIDEO_0076_0 // Usermode DDI Min Version: D3D12DDI_SUPPORTED_0043 #define D3D12DDI_FEATURE_VERSION_VIDEO_0076_0 17u typedef HRESULT(APIENTRY* PFND3D12DDI_EXECUTEDEVICEVIDEOEXTENSIONCOMMAND_0076)( D3D12DDI_HDEVICE hDrvDevice, D3D12DDI_HVIDEOEXTENSIONCOMMAND_0063 hDrvVideoExtensionCommand, _In_reads_bytes_ (ExecutionParametersSizeInBytes) CONST void *pExecutionParameters, _In_ SIZE_T ExecutionParametersSizeInBytes, _Out_writes_bytes_(OutputDataSizeInBytes) void *pOutputData, SIZE_T OutputDataSizeInBytes); // D3D12DDI_TABLE_TYPE_0020_DEVICE_VIDEO typedef struct D3D12DDI_DEVICE_FUNCS_VIDEO_0076 { PFND3D12DDI_VIDEO_GETCAPS pfnGetCaps; PFND3D12DDI_CALCPRIVATEVIDEODECODERSIZE_0072 pfnCalcPrivateVideoDecoderSize; PFND3D12DDI_CREATEVIDEODECODER_0072 pfnCreateVideoDecoder; PFND3D12DDI_DESTROYVIDEODECODER_0021 pfnDestroyVideoDecoder; PFND3D12DDI_CALCPRIVATEVIDEODECODERHEAPSIZE_0072 pfnCalcPrivateVideoDecoderHeapSize; PFND3D12DDI_CREATEVIDEODECODERHEAP_0072 pfnCreateVideoDecoderHeap; PFND3D12DDI_DESTROYVIDEODECODERHEAP_0032 pfnDestroyVideoDecoderHeap; PFND3D12DDI_CALCPRIVATEVIDEOPROCESSORSIZE_0072 pfnCalcPrivateVideoProcessorSize; PFND3D12DDI_CREATEVIDEOPROCESSOR_0072 pfnCreateVideoProcessor; PFND3D12DDI_DESTROYVIDEOPROCESSOR_0021 pfnDestroyVideoProcessor; PFND3D12DDI_CALCPRIVATEVIDEOMOTIONESTIMATORSIZE_0060 pfnCalcPrivateVideoMotionEstimatorSize; PFND3D12DDI_CREATEVIDEOMOTIONESTIMATOR_0060 pfnCreateVideoMotionEstimator; PFND3D12DDI_DESTROYVIDEOMOTIONESTIMATOR_0053 pfnDestroyVideoMotionEstimator; PFND3D12DDI_CALCPRIVATEVIDEOMOTIONVECTORHEAPSIZE_0060 pfnCalcPrivateVideoMotionVectorHeapSize; PFND3D12DDI_CREATEVIDEOMOTIONVECTORHEAP_0060 pfnCreateVideoMotionVectorHeap; PFND3D12DDI_DESTROYVIDEOMOTIONVECTORHEAP_0053 pfnDestroyVideoMotionVectorHeap; PFND3D12DDI_CALCPRIVATEVIDEOEXTENSIONCOMMANDSIZE_0061 pfnCalcPrivateVideoExtensionCommandSize; PFND3D12DDI_CREATEVIDEOEXTENSIONCOMMAND_0063 pfnCreateVideoExtensionCommand; PFND3D12DDI_DESTROYVIDEOEXTENSIONCOMMAND_0063 pfnDestroyVideoExtensionCommand; PFND3D12DDI_EXECUTEDEVICEVIDEOEXTENSIONCOMMAND_0076 pfnExecuteDeviceVideoExtensionCommand; } D3D12DDI_DEVICE_FUNCS_VIDEO_0076; //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Extended Feature Video // Version: D3D12DDI_FEATURE_VERSION_VIDEO_0080_0 // Usermode DDI Min Version: D3D12DDI_SUPPORTED_0043 #define D3D12DDI_FEATURE_VERSION_VIDEO_0080_0 18u // UMD handle types D3D10DDI_H( D3D12DDI_HVIDEOENCODER_0080 ) */ IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HVIDEOENCODER_0080 MAKE_D3D12DDI_HVIDEOENCODER_0080(/* } D3D12DDI_VIDEO_PROTECTED_RESOURCE_SUPPORT_FLAGS_0072; DEFINE_ENUM_FLAG_OPERATORS( D3D12DDI_VIDEO_PROTECTED_RESOURCE_SUPPORT_FLAGS_0072 ); // D3D12DDICAPS_TYPE_VIDEO_0072_DECODE_PROTECTED_RESOURCES // *pInfo = nullptr // pData = D3D12DDI_VIDEO_DECODE_PROTECTED_RESOURCES_DATA_0072 // DataSize = sizeof(D3D12DDI_VIDEO_DECODE_PROTECTED_RESOURCES_DATA_0072) typedef struct D3D12DDI_VIDEO_DECODE_PROTECTED_RESOURCES_DATA_0072 { UINT NodeIndex; // input D3D12DDI_VIDEO_DECODE_CONFIGURATION_0020 Configuration; // input D3D12DDI_VIDEO_PROTECTED_RESOURCE_SUPPORT_FLAGS_0072 SupportFlags; // output } D3D12DDI_VIDEO_DECODE_PROTECTED_RESOURCES_DATA_0072; // D3D12DDICAPS_TYPE_VIDEO_0072_PROCESS_PROTECTED_RESOURCES // *pInfo = nullptr // pData = D3D12DDI_VIDEO_PROCESS_PROTECTED_RESOURCES_DATA_0072 // DataSize = sizeof(D3D12DDI_VIDEO_PROCESS_PROTECTED_RESOURCES_DATA_0072) typedef struct D3D12DDI_VIDEO_PROCESS_PROTECTED_RESOURCES_DATA_0072 { UINT NodeIndex; // input D3D12DDI_VIDEO_PROTECTED_RESOURCE_SUPPORT_FLAGS_0072 SupportFlags; // output } D3D12DDI_VIDEO_PROCESS_PROTECTED_RESOURCES_DATA_0072; // D3D12DDICAPS_TYPE_VIDEO_0072_MOTION_ESTIMATOR_PROTECTED_RESOURCES // *pInfo = nullptr // pData = D3D12DDI_VIDEO_MOTION_ESTIMATOR_PROTECTED_RESOURCES_DATA_0072 // DataSize = sizeof(D3D12DDI_VIDEO_MOTION_ESTIMATOR_PROTECTED_RESOURCES_DATA_0072) typedef struct D3D12DDI_VIDEO_MOTION_ESTIMATOR_PROTECTED_RESOURCES_DATA_0072 { UINT NodeIndex; // input D3D12DDI_VIDEO_PROTECTED_RESOURCE_SUPPORT_FLAGS_0072 SupportFlags; // output } D3D12DDI_VIDEO_MOTION_ESTIMATOR_PROTECTED_RESOURCES_DATA_0072; // D3D12DDICAPS_TYPE_VIDEO_0032_DECODER_HEAP_SIZE // *pInfo = nullptr // pData = D3D12DDI_VIDEO_DECODER_HEAP_SIZE_DATA_0072 // DataSize = sizeof(D3D12DDI_VIDEO_DECODER_HEAP_SIZE_DATA_0072) typedef struct D3D12DDI_VIDEO_DECODER_HEAP_SIZE_DATA_0072 { UINT NodeMask; D3D12DDI_VIDEO_DECODE_CONFIGURATION_0020 Configuration; // input UINT DecodeWidth; // input UINT DecodeHeight; // input DXGI_FORMAT Format; // input DXGI_RATIONAL FrameRate; // input UINT BitRate; // input UINT MaxDecodePictureBufferCount; // input BOOL Protected; // input UINT64 MemoryPoolL0Size; // output UINT64 MemoryPoolL1Size; // output } D3D12DDI_VIDEO_DECODER_HEAP_SIZE_DATA_0072; // D3D12DDICAPS_TYPE_VIDEO_0032_PROCESSOR_SIZE // *pInfo = nullptr // pData = D3D12DDI_VIDEO_PROCESSOR_SIZE_DATA_0072 // DataSize = sizeof(D3D12DDI_VIDEO_PROCESSOR_SIZE_DATA_0072) typedef struct D3D12DDI_VIDEO_PROCESSOR_SIZE_DATA_0072 { UINT NodeMask; // input D3D12DDI_VIDEO_PROCESS_OUTPUT_STREAM_DESC_0032 OutputStream; // input D3D12DDI_VIDEO_PROCESSOR_INPUT_STREAM_DESC_0043* pInputStreams; // input UINT NumInputStreams; // input BOOL Protected; // input UINT64 MemoryPoolL0Size; // output UINT64 MemoryPoolL1Size; // output } D3D12DDI_VIDEO_PROCESSOR_SIZE_DATA_0072; typedef struct D3D12DDIARG_CREATE_VIDEO_DECODER_0072 { UINT NodeMask; D3D12DDI_VIDEO_DECODE_CONFIGURATION_0020 Configuration; D3D12DDI_HPROTECTEDRESOURCESESSION_0030 hDrvProtectedResourceSession; } D3D12DDIARG_CREATE_VIDEO_DECODER_0072; typedef struct D3D12DDIARG_CREATE_VIDEO_DECODER_HEAP_0072 { UINT NodeMask; D3D12DDI_VIDEO_DECODE_CONFIGURATION_0020 Configuration; UINT DecodeWidth; UINT DecodeHeight; DXGI_FORMAT Format; DXGI_RATIONAL FrameRate; UINT BitRate; UINT MaxDecodePictureBufferCount; D3D12DDI_HPROTECTEDRESOURCESESSION_0030 hDrvProtectedResourceSession; } D3D12DDIARG_CREATE_VIDEO_DECODER_HEAP_0072; typedef struct D3D12DDIARG_CREATE_VIDEO_PROCESSOR_0072 { UINT NodeMask; D3D12DDI_VIDEO_PROCESS_OUTPUT_STREAM_DESC_0032 OutputStream; D3D12DDI_VIDEO_PROCESSOR_INPUT_STREAM_DESC_0043* pInputStreams; UINT NumInputStreams; D3D12DDI_HPROTECTEDRESOURCESESSION_0030 hDrvProtectedResourceSession; } D3D12DDIARG_CREATE_VIDEO_PROCESSOR_0072; typedef SIZE_T ( APIENTRY* PFND3D12DDI_CALCPRIVATEVIDEODECODERSIZE_0072 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_VIDEO_DECODER_0072* pArgs); typedef HRESULT ( APIENTRY* PFND3D12DDI_CREATEVIDEODECODER_0072 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_VIDEO_DECODER_0072* pArgs, D3D12DDI_HVIDEODECODER_0020 hDrvVideoDecoder ); typedef SIZE_T ( APIENTRY* PFND3D12DDI_CALCPRIVATEVIDEODECODERHEAPSIZE_0072 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_VIDEO_DECODER_HEAP_0072* pArgs); typedef HRESULT ( APIENTRY* PFND3D12DDI_CREATEVIDEODECODERHEAP_0072 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_VIDEO_DECODER_HEAP_0072*, D3D12DDI_HVIDEODECODERHEAP_0032 hDrvVideoDecoderHeap ); typedef SIZE_T ( APIENTRY* PFND3D12DDI_CALCPRIVATEVIDEOPROCESSORSIZE_0072 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_VIDEO_PROCESSOR_0072* pArgs); typedef HRESULT ( APIENTRY* PFND3D12DDI_CREATEVIDEOPROCESSOR_0072 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_VIDEO_PROCESSOR_0072* pArgs, D3D12DDI_HVIDEOPROCESSOR_0020 hDrvVideoProcessor); // D3D12DDI_TABLE_TYPE_0020_DEVICE_VIDEO typedef struct D3D12DDI_DEVICE_FUNCS_VIDEO_0072 { PFND3D12DDI_VIDEO_GETCAPS pfnGetCaps; PFND3D12DDI_CALCPRIVATEVIDEODECODERSIZE_0072 pfnCalcPrivateVideoDecoderSize; PFND3D12DDI_CREATEVIDEODECODER_0072 pfnCreateVideoDecoder; PFND3D12DDI_DESTROYVIDEODECODER_0021 pfnDestroyVideoDecoder; PFND3D12DDI_CALCPRIVATEVIDEODECODERHEAPSIZE_0072 pfnCalcPrivateVideoDecoderHeapSize; PFND3D12DDI_CREATEVIDEODECODERHEAP_0072 pfnCreateVideoDecoderHeap; PFND3D12DDI_DESTROYVIDEODECODERHEAP_0032 pfnDestroyVideoDecoderHeap; PFND3D12DDI_CALCPRIVATEVIDEOPROCESSORSIZE_0072 pfnCalcPrivateVideoProcessorSize; PFND3D12DDI_CREATEVIDEOPROCESSOR_0072 pfnCreateVideoProcessor; PFND3D12DDI_DESTROYVIDEOPROCESSOR_0021 pfnDestroyVideoProcessor; PFND3D12DDI_CALCPRIVATEVIDEOMOTIONESTIMATORSIZE_0060 pfnCalcPrivateVideoMotionEstimatorSize; PFND3D12DDI_CREATEVIDEOMOTIONESTIMATOR_0060 pfnCreateVideoMotionEstimator; PFND3D12DDI_DESTROYVIDEOMOTIONESTIMATOR_0053 pfnDestroyVideoMotionEstimator; PFND3D12DDI_CALCPRIVATEVIDEOMOTIONVECTORHEAPSIZE_0060 pfnCalcPrivateVideoMotionVectorHeapSize; PFND3D12DDI_CREATEVIDEOMOTIONVECTORHEAP_0060 pfnCreateVideoMotionVectorHeap; PFND3D12DDI_DESTROYVIDEOMOTIONVECTORHEAP_0053 pfnDestroyVideoMotionVectorHeap; PFND3D12DDI_CALCPRIVATEVIDEOEXTENSIONCOMMANDSIZE_0061 pfnCalcPrivateVideoExtensionCommandSize; PFND3D12DDI_CREATEVIDEOEXTENSIONCOMMAND_0063 pfnCreateVideoExtensionCommand; PFND3D12DDI_DESTROYVIDEOEXTENSIONCOMMAND_0063 pfnDestroyVideoExtensionCommand; } D3D12DDI_DEVICE_FUNCS_VIDEO_0072; //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Extended Feature Video // Version: D3D12DDI_FEATURE_VERSION_VIDEO_0076_0 // Usermode DDI Min Version: D3D12DDI_SUPPORTED_0043 #define D3D12DDI_FEATURE_VERSION_VIDEO_0076_0 17u typedef HRESULT(APIENTRY* PFND3D12DDI_EXECUTEDEVICEVIDEOEXTENSIONCOMMAND_0076)( D3D12DDI_HDEVICE hDrvDevice, D3D12DDI_HVIDEOEXTENSIONCOMMAND_0063 hDrvVideoExtensionCommand, _In_reads_bytes_ (ExecutionParametersSizeInBytes) CONST void *pExecutionParameters, _In_ SIZE_T ExecutionParametersSizeInBytes, _Out_writes_bytes_(OutputDataSizeInBytes) void *pOutputData, SIZE_T OutputDataSizeInBytes); // D3D12DDI_TABLE_TYPE_0020_DEVICE_VIDEO typedef struct D3D12DDI_DEVICE_FUNCS_VIDEO_0076 { PFND3D12DDI_VIDEO_GETCAPS pfnGetCaps; PFND3D12DDI_CALCPRIVATEVIDEODECODERSIZE_0072 pfnCalcPrivateVideoDecoderSize; PFND3D12DDI_CREATEVIDEODECODER_0072 pfnCreateVideoDecoder; PFND3D12DDI_DESTROYVIDEODECODER_0021 pfnDestroyVideoDecoder; PFND3D12DDI_CALCPRIVATEVIDEODECODERHEAPSIZE_0072 pfnCalcPrivateVideoDecoderHeapSize; PFND3D12DDI_CREATEVIDEODECODERHEAP_0072 pfnCreateVideoDecoderHeap; PFND3D12DDI_DESTROYVIDEODECODERHEAP_0032 pfnDestroyVideoDecoderHeap; PFND3D12DDI_CALCPRIVATEVIDEOPROCESSORSIZE_0072 pfnCalcPrivateVideoProcessorSize; PFND3D12DDI_CREATEVIDEOPROCESSOR_0072 pfnCreateVideoProcessor; PFND3D12DDI_DESTROYVIDEOPROCESSOR_0021 pfnDestroyVideoProcessor; PFND3D12DDI_CALCPRIVATEVIDEOMOTIONESTIMATORSIZE_0060 pfnCalcPrivateVideoMotionEstimatorSize; PFND3D12DDI_CREATEVIDEOMOTIONESTIMATOR_0060 pfnCreateVideoMotionEstimator; PFND3D12DDI_DESTROYVIDEOMOTIONESTIMATOR_0053 pfnDestroyVideoMotionEstimator; PFND3D12DDI_CALCPRIVATEVIDEOMOTIONVECTORHEAPSIZE_0060 pfnCalcPrivateVideoMotionVectorHeapSize; PFND3D12DDI_CREATEVIDEOMOTIONVECTORHEAP_0060 pfnCreateVideoMotionVectorHeap; PFND3D12DDI_DESTROYVIDEOMOTIONVECTORHEAP_0053 pfnDestroyVideoMotionVectorHeap; PFND3D12DDI_CALCPRIVATEVIDEOEXTENSIONCOMMANDSIZE_0061 pfnCalcPrivateVideoExtensionCommandSize; PFND3D12DDI_CREATEVIDEOEXTENSIONCOMMAND_0063 pfnCreateVideoExtensionCommand; PFND3D12DDI_DESTROYVIDEOEXTENSIONCOMMAND_0063 pfnDestroyVideoExtensionCommand; PFND3D12DDI_EXECUTEDEVICEVIDEOEXTENSIONCOMMAND_0076 pfnExecuteDeviceVideoExtensionCommand; } D3D12DDI_DEVICE_FUNCS_VIDEO_0076; //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Extended Feature Video // Version: D3D12DDI_FEATURE_VERSION_VIDEO_0080_0 // Usermode DDI Min Version: D3D12DDI_SUPPORTED_0043 #define D3D12DDI_FEATURE_VERSION_VIDEO_0080_0 18u // UMD handle types */ IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HVIDEOEXTENSIONCOMMAND_0063 MAKE_D3D12DDI_HVIDEOEXTENSIONCOMMAND_0063(/* 3D } D3D12DDI_RESOURCE_COORDINATE_0053; typedef struct D3D12DDI_VIDEO_MOTION_ESTIMATOR_OUTPUT_0053 { D3D12DDI_HVIDEOMOTIONVECTORHEAP_0053 hDrvMotionVectorHeap; } D3D12DDI_VIDEO_MOTION_ESTIMATOR_OUTPUT_0053; typedef struct D3D12DDI_VIDEO_MOTION_ESTIMATOR_INPUT_0053 { D3D12DDI_HRESOURCE hDrvInputTexture2D; UINT InputSubresourceIndex; D3D12DDI_HRESOURCE hDrvReferenceTexture2D; UINT ReferenceSubresourceIndex; D3D12DDI_HVIDEOMOTIONVECTORHEAP_0053 hDrvPreviousMotionVectorHeap; } D3D12DDI_VIDEO_MOTION_ESTIMATOR_INPUT_0053; typedef VOID ( APIENTRY* PFND3D12DDI_ESTIMATE_MOTION_0053 )( D3D12DDI_HCOMMANDLIST hDrvCommandList, D3D12DDI_HVIDEOMOTIONESTIMATOR_0053 hDrvMotionEstimator, CONST D3D12DDI_VIDEO_MOTION_ESTIMATOR_OUTPUT_0053* pOutputArguments, CONST D3D12DDI_VIDEO_MOTION_ESTIMATOR_INPUT_0053* pInputArguments ); typedef struct D3D12DDI_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT_0053 { D3D12DDI_HRESOURCE hDrvMotionVectorTexture2D; D3D12DDI_RESOURCE_COORDINATE_0053 MotionVectorCoordinate; D3D12DDI_HRESOURCE hDrvDifferencesMetricTexture2D; D3D12DDI_RESOURCE_COORDINATE_0053 DifferencesMetricCoordinate; } D3D12DDI_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT_0053; typedef struct D3D12DDI_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_INPUT_0053 { D3D12DDI_HVIDEOMOTIONVECTORHEAP_0053 hDrvMotionVectorHeap; UINT PixelWidth; UINT PixelHeight; } D3D12DDI_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_INPUT_0053; typedef VOID ( APIENTRY* PFND3D12DDI_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_0053 )( D3D12DDI_HCOMMANDLIST hDrvCommandList, CONST D3D12DDI_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT_0053* pOutputArguments, CONST D3D12DDI_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_INPUT_0053* pInputArguments ); // D3D12DDI_TABLE_TYPE_0053_COMMAND_LIST_VIDEO_ENCODE typedef struct D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_ENCODE_0053 { PFND3D12DDI_CLOSECOMMANDLIST pfnCloseCommandList; PFND3D12DDI_RESETCOMMANDLIST_0040 pfnResetCommandList; PFND3D12DDI_DISCARD_RESOURCE_0003 pfnDiscardResource; PFND3D12DDI_SET_MARKER pfnSetMarker; PFND3D12DDI_SET_PREDICATION pfnSetPredication; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnBeginQuery; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnEndQuery; PFND3D12DDI_RESOLVE_QUERY_DATA pfnResolveQueryData; PFND3D12DDI_RESOURCEBARRIER_0022 pfnResourceBarrier; PFND3D12DDI_ESTIMATE_MOTION_0053 pfnEstimateMotion; PFND3D12DDI_SETPROTECTEDRESOURCESESSION_0030 pfnSetProtectedResourceSession; PFND3D12DDI_WRITEBUFFERIMMEDIATE_0032 pfnWriteBufferImmediate; PFND3D12DDI_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_0053 pfnResolveVideoMotionVectorHeap; } D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_ENCODE_0053; //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Extended Feature Video // Version: D3D12DDI_FEATURE_VERSION_VIDEO_0060 // Usermode DDI Min Version: D3D12DDI_SUPPORTED_0043 #define D3D12DDI_FEATURE_VERSION_VIDEO_0060_0 14u // D3D12DDICAPS_TYPE_VIDEO_0053_MOTION_ESTIMATOR // *pInfo = nullptr // pData = D3D12DDI_VIDEO_MOTION_ESTIMATOR_DATA_0060 // DataSize = sizeof(D3D12DDI_VIDEO_MOTION_ESTIMATOR_DATA_0060) typedef struct D3D12DDI_VIDEO_MOTION_ESTIMATOR_DATA_0060 { UINT NodeIndex; // input DXGI_FORMAT InputFormat; // input D3D12DDI_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE_FLAGS_0053 BlockSizeFlags; // output D3D12DDI_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAGS_0053 PrecisionFlags; // output D3D12DDI_VIDEO_SIZE_RANGE_0032 SizeRange; // output } D3D12DDI_VIDEO_MOTION_ESTIMATOR_DATA_0060; // D3D12DDICAPS_TYPE_VIDEO_0053_MOTION_ESTIMATOR_SIZE // *pInfo = nullptr // pData = D3D12DDI_VIDEO_MOTION_ESTIMATOR_SIZE_DATA_0060 // DataSize = sizeof(D3D12DDI_VIDEO_MOTION_ESTIMATOR_SIZE_DATA_0060) typedef struct D3D12DDI_VIDEO_MOTION_ESTIMATOR_SIZE_DATA_0060 { UINT NodeMask; // input DXGI_FORMAT InputFormat; // input D3D12DDI_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE_0053 BlockSize; // input D3D12DDI_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_0053 Precision; // input D3D12DDI_VIDEO_SIZE_RANGE_0032 SizeRange; // input BOOL Protected; // input UINT64 MotionEstimatorMemoryPoolL0Size; // output UINT64 MotionEstimatorMemoryPoolL1Size; // output UINT64 MotionVectorHeapMemoryPoolL0Size; // output UINT64 MotionVectorHeapMemoryPoolL1Size; // output } D3D12DDI_VIDEO_MOTION_ESTIMATOR_SIZE_DATA_0060; typedef struct D3D12DDIARG_CREATE_VIDEO_MOTION_ESTIMATOR_0060 { UINT NodeMask; DXGI_FORMAT InputFormat; D3D12DDI_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE_0053 BlockSize; D3D12DDI_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_0053 Precision; D3D12DDI_VIDEO_SIZE_RANGE_0032 SizeRange; D3D12DDI_HPROTECTEDRESOURCESESSION_0030 hDrvProtectedResourceSession; } D3D12DDIARG_CREATE_VIDEO_MOTION_ESTIMATOR_0060; typedef SIZE_T ( APIENTRY* PFND3D12DDI_CALCPRIVATEVIDEOMOTIONESTIMATORSIZE_0060 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_VIDEO_MOTION_ESTIMATOR_0060* pArgs); typedef HRESULT ( APIENTRY* PFND3D12DDI_CREATEVIDEOMOTIONESTIMATOR_0060 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_VIDEO_MOTION_ESTIMATOR_0060* pArgs, D3D12DDI_HVIDEOMOTIONESTIMATOR_0053 hDrvMotionEstimator); typedef struct D3D12DDIARG_CREATE_VIDEO_MOTION_VECTOR_HEAP_0060 { UINT NodeMask; DXGI_FORMAT InputFormat; D3D12DDI_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE_0053 BlockSize; D3D12DDI_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_0053 Precision; D3D12DDI_VIDEO_SIZE_RANGE_0032 SizeRange; D3D12DDI_HPROTECTEDRESOURCESESSION_0030 hDrvProtectedResourceSession; } D3D12DDIARG_CREATE_VIDEO_MOTION_VECTOR_HEAP_0060; typedef SIZE_T ( APIENTRY* PFND3D12DDI_CALCPRIVATEVIDEOMOTIONVECTORHEAPSIZE_0060 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_VIDEO_MOTION_VECTOR_HEAP_0060* pArgs); typedef HRESULT ( APIENTRY* PFND3D12DDI_CREATEVIDEOMOTIONVECTORHEAP_0060 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_VIDEO_MOTION_VECTOR_HEAP_0060* pArgs, D3D12DDI_HVIDEOMOTIONVECTORHEAP_0053 hDrvMotionEstimator); typedef struct D3D12DDI_DEVICE_FUNCS_VIDEO_0060 { PFND3D12DDI_VIDEO_GETCAPS pfnGetCaps; PFND3D12DDI_CALCPRIVATEVIDEODECODERSIZE_0032 pfnCalcPrivateVideoDecoderSize; PFND3D12DDI_CREATEVIDEODECODER_0032 pfnCreateVideoDecoder; PFND3D12DDI_DESTROYVIDEODECODER_0021 pfnDestroyVideoDecoder; PFND3D12DDI_CALCPRIVATEVIDEODECODERHEAPSIZE_0033 pfnCalcPrivateVideoDecoderHeapSize; PFND3D12DDI_CREATEVIDEODECODERHEAP_0033 pfnCreateVideoDecoderHeap; PFND3D12DDI_DESTROYVIDEODECODERHEAP_0032 pfnDestroyVideoDecoderHeap; PFND3D12DDI_CALCPRIVATEVIDEOPROCESSORSIZE_0043 pfnCalcPrivateVideoProcessorSize; PFND3D12DDI_CREATEVIDEOPROCESSOR_0043 pfnCreateVideoProcessor; PFND3D12DDI_DESTROYVIDEOPROCESSOR_0021 pfnDestroyVideoProcessor; PFND3D12DDI_CALCPRIVATEVIDEOMOTIONESTIMATORSIZE_0060 pfnCalcPrivateVideoMotionEstimatorSize; PFND3D12DDI_CREATEVIDEOMOTIONESTIMATOR_0060 pfnCreateVideoMotionEstimator; PFND3D12DDI_DESTROYVIDEOMOTIONESTIMATOR_0053 pfnDestroyVideoMotionEstimator; PFND3D12DDI_CALCPRIVATEVIDEOMOTIONVECTORHEAPSIZE_0060 pfnCalcPrivateVideoMotionVectorHeapSize; PFND3D12DDI_CREATEVIDEOMOTIONVECTORHEAP_0060 pfnCreateVideoMotionVectorHeap; PFND3D12DDI_DESTROYVIDEOMOTIONVECTORHEAP_0053 pfnDestroyVideoMotionVectorHeap; } D3D12DDI_DEVICE_FUNCS_VIDEO_0060; typedef struct D3D12DDI_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT_0060 { D3D12DDI_HRESOURCE hDrvMotionVectorTexture2D; D3D12DDI_RESOURCE_COORDINATE_0053 MotionVectorCoordinate; } D3D12DDI_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT_0060; typedef VOID ( APIENTRY* PFND3D12DDI_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_0060 )( D3D12DDI_HCOMMANDLIST hDrvCommandList, CONST D3D12DDI_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT_0060* pOutputArguments, CONST D3D12DDI_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_INPUT_0053* pInputArguments ); // D3D12DDI_TABLE_TYPE_0053_COMMAND_LIST_VIDEO_ENCODE typedef struct D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_ENCODE_0060 { PFND3D12DDI_CLOSECOMMANDLIST pfnCloseCommandList; PFND3D12DDI_RESETCOMMANDLIST_0040 pfnResetCommandList; PFND3D12DDI_DISCARD_RESOURCE_0003 pfnDiscardResource; PFND3D12DDI_SET_MARKER pfnSetMarker; PFND3D12DDI_SET_PREDICATION pfnSetPredication; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnBeginQuery; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnEndQuery; PFND3D12DDI_RESOLVE_QUERY_DATA pfnResolveQueryData; PFND3D12DDI_RESOURCEBARRIER_0022 pfnResourceBarrier; PFND3D12DDI_ESTIMATE_MOTION_0053 pfnEstimateMotion; PFND3D12DDI_SETPROTECTEDRESOURCESESSION_0030 pfnSetProtectedResourceSession; PFND3D12DDI_WRITEBUFFERIMMEDIATE_0032 pfnWriteBufferImmediate; PFND3D12DDI_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_0060 pfnResolveVideoMotionVectorHeap; } D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_ENCODE_0060; //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Extended Feature Video // Version: D3D12DDI_FEATURE_VERSION_VIDEO_0063 // Usermode DDI Min Version: D3D12DDI_SUPPORTED_0043 #define D3D12DDI_FEATURE_VERSION_VIDEO_0063_0 15u // UMD handle types */ out IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HVIDEOMOTIONESTIMATOR_0053 MAKE_D3D12DDI_HVIDEOMOTIONESTIMATOR_0053(/* } D3D12DDI_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS_0041; DEFINE_ENUM_FLAG_OPERATORS(D3D12DDI_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS_0041); typedef struct D3D12DDI_VIDEO_DECODE_HISTOGRAM_DATA_0041 { UINT NodeIndex; // in GUID DecodeProfile; // in UINT Width; // in UINT Height; // in DXGI_FORMAT DecodeFormat; // in D3D12DDI_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS_0041 Components; // out UINT BinCount; // out UINT CounterBitDepth; // out } D3D12DDI_VIDEO_DECODE_HISTOGRAM_DATA_0041; typedef struct D3D12DDI_VIDEO_DECODE_COMPONENT_HISTOGRAM_0041 { UINT64 Offset; D3D12DDI_HRESOURCE hDrvBuffer; } D3D12DDI_VIDEO_DECODE_COMPONENT_HISTOGRAM_0041; #define D3D12DDI_VIDEO_DECODE_MAX_HISTOGRAM_COMPONENTS 4 typedef struct D3D12DDI_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS_0041 { D3D12DDI_HRESOURCE hDrvOutputTexture2D; UINT OutputSubresource; D3D12DDI_VIDEO_DECODE_CONVERSION_ARGUMENTS_0021 ConversionArguments; D3D12DDI_VIDEO_DECODE_COMPONENT_HISTOGRAM_0041 Histograms[D3D12DDI_VIDEO_DECODE_MAX_HISTOGRAM_COMPONENTS]; } D3D12DDI_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS_0041; typedef VOID ( APIENTRY* PFND3D12DDI_VIDEO_DECODE_FRAME_0041 )( D3D12DDI_HCOMMANDLIST hDrvCommandList, D3D12DDI_HVIDEODECODER_0020 hDrvDecoder, const D3D12DDI_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS_0041* pOutputStreamParameters, const D3D12DDI_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS_0032* pInputStreamParameters ); // D3D12DDI_TABLE_TYPE_0022_COMMAND_LIST_VIDEO_DECODE typedef struct D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_DECODE_0041 { PFND3D12DDI_CLOSECOMMANDLIST pfnCloseCommandList; PFND3D12DDI_RESETCOMMANDLIST_0040 pfnResetCommandList; PFND3D12DDI_DISCARD_RESOURCE_0003 pfnDiscardResource; PFND3D12DDI_SET_MARKER pfnSetMarker; PFND3D12DDI_SET_PREDICATION pfnSetPredication; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnBeginQuery; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnEndQuery; PFND3D12DDI_RESOLVE_QUERY_DATA pfnResolveQueryData; PFND3D12DDI_RESOURCEBARRIER_0022 pfnResourceBarrier; PFND3D12DDI_VIDEO_DECODE_FRAME_0041 pfnDecodeFrame; PFND3D12DDI_SETPROTECTEDRESOURCESESSION_0030 pfnSetProtectedResourceSession; PFND3D12DDI_WRITEBUFFERIMMEDIATE_0032 pfnWriteBufferImmediate; } D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_DECODE_0041; //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Extended Feature Video // Version: D3D12DDI_FEATURE_VERSION_VIDEO_0041_1 // Usermode DDI Min Version: D3D12DDI_SUPPORTED_0040 #define D3D12DDI_FEATURE_VERSION_VIDEO_0041_1 11u typedef struct D3D12DDI_VIDEO_DECODE_CONVERSION_ARGUMENTS_0041 { BOOL Enable; D3D12DDI_HRESOURCE hDrvReferenceTexture2D; UINT ReferenceSubresource; DXGI_COLOR_SPACE_TYPE OutputColorSpace; DXGI_COLOR_SPACE_TYPE DecodeColorSpace; UINT OutputWidth; UINT OutputHeight; } D3D12DDI_VIDEO_DECODE_CONVERSION_ARGUMENTS_0041; typedef struct D3D12DDI_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS_0041_1 { D3D12DDI_HRESOURCE hDrvOutputTexture2D; UINT OutputSubresource; D3D12DDI_VIDEO_DECODE_CONVERSION_ARGUMENTS_0041 ConversionArguments; D3D12DDI_VIDEO_DECODE_COMPONENT_HISTOGRAM_0041 Histograms[D3D12DDI_VIDEO_DECODE_MAX_HISTOGRAM_COMPONENTS]; } D3D12DDI_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS_0041_1; typedef VOID ( APIENTRY* PFND3D12DDI_VIDEO_DECODE_FRAME_0041_1 )( D3D12DDI_HCOMMANDLIST hDrvCommandList, D3D12DDI_HVIDEODECODER_0020 hDrvDecoder, const D3D12DDI_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS_0041_1* pOutputStreamParameters, const D3D12DDI_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS_0032* pInputStreamParameters ); // D3D12DDI_TABLE_TYPE_0022_COMMAND_LIST_VIDEO_DECODE typedef struct D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_DECODE_0041_1 { PFND3D12DDI_CLOSECOMMANDLIST pfnCloseCommandList; PFND3D12DDI_RESETCOMMANDLIST_0040 pfnResetCommandList; PFND3D12DDI_DISCARD_RESOURCE_0003 pfnDiscardResource; PFND3D12DDI_SET_MARKER pfnSetMarker; PFND3D12DDI_SET_PREDICATION pfnSetPredication; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnBeginQuery; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnEndQuery; PFND3D12DDI_RESOLVE_QUERY_DATA pfnResolveQueryData; PFND3D12DDI_RESOURCEBARRIER_0022 pfnResourceBarrier; PFND3D12DDI_VIDEO_DECODE_FRAME_0041_1 pfnDecodeFrame; PFND3D12DDI_SETPROTECTEDRESOURCESESSION_0030 pfnSetProtectedResourceSession; PFND3D12DDI_WRITEBUFFERIMMEDIATE_0032 pfnWriteBufferImmediate; } D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_DECODE_0041_1; //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Extended Feature Video // Version: D3D12DDI_FEATURE_VERSION_VIDEO_0043 // Usermode DDI Min Version: D3D12DDI_SUPPORTED_0040 #define D3D12DDI_FEATURE_VERSION_VIDEO_0043_0 12u typedef struct D3D12DDI_VIDEO_PROCESSOR_INPUT_STREAM_DESC_0043 { DXGI_FORMAT Format; DXGI_COLOR_SPACE_TYPE ColorSpace; DXGI_RATIONAL SourceAspectRatio; DXGI_RATIONAL DestinationAspectRatio; DXGI_RATIONAL FrameRate; D3D12DDI_VIDEO_SIZE_RANGE_0032 SourceSizeRange; D3D12DDI_VIDEO_SIZE_RANGE_0032 DestinationSizeRange; BOOL EnableOrientation; D3D12DDI_VIDEO_PROCESS_FILTER_FLAGS_0020 FilterFlags; D3D12DDI_VIDEO_FRAME_STEREO_FORMAT_0020 StereoFormat; D3D12DDI_VIDEO_PROCESS_DEINTERLACE_FLAGS_0020 DeinterlaceMode; BOOL EnableAlphaBlending; D3D12DDI_VIDEO_PROCESS_LUMA_KEY_0020 LumaKey; UINT NumPastFrames; UINT NumFutureFrames; BOOL EnableAutoProcessing; } D3D12DDI_VIDEO_PROCESSOR_INPUT_STREAM_DESC_0043; typedef struct D3D12DDIARG_CREATE_VIDEO_PROCESSOR_0043 { UINT NodeMask; D3D12DDI_VIDEO_PROCESS_OUTPUT_STREAM_DESC_0032 OutputStream; D3D12DDI_VIDEO_PROCESSOR_INPUT_STREAM_DESC_0043* pInputStreams; UINT NumInputStreams; } D3D12DDIARG_CREATE_VIDEO_PROCESSOR_0043; // D3D12DDICAPS_TYPE_VIDEO_0032_PROCESSOR_SIZE // *pInfo = nullptr // pData = D3D12DDI_VIDEO_PROCESSOR_SIZE_DATA_0043 // DataSize = sizeof(D3D12DDI_VIDEO_PROCESSOR_SIZE_DATA_0043) typedef struct D3D12DDI_VIDEO_PROCESSOR_SIZE_DATA_0043 { D3D12DDIARG_CREATE_VIDEO_PROCESSOR_0043 VideoProcessorDesc; // input UINT64 MemoryPoolL0Size; // output UINT64 MemoryPoolL1Size; // output } D3D12DDI_VIDEO_PROCESSOR_SIZE_DATA_0043; typedef SIZE_T ( APIENTRY* PFND3D12DDI_CALCPRIVATEVIDEOPROCESSORSIZE_0043 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_VIDEO_PROCESSOR_0043* pArgs); typedef HRESULT ( APIENTRY* PFND3D12DDI_CREATEVIDEOPROCESSOR_0043 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_VIDEO_PROCESSOR_0043* pArgs, D3D12DDI_HVIDEOPROCESSOR_0020 hDrvVideoProcessor); typedef struct D3D12DDI_DEVICE_FUNCS_VIDEO_0043 { PFND3D12DDI_VIDEO_GETCAPS pfnGetCaps; PFND3D12DDI_CALCPRIVATEVIDEODECODERSIZE_0032 pfnCalcPrivateVideoDecoderSize; PFND3D12DDI_CREATEVIDEODECODER_0032 pfnCreateVideoDecoder; PFND3D12DDI_DESTROYVIDEODECODER_0021 pfnDestroyVideoDecoder; PFND3D12DDI_CALCPRIVATEVIDEODECODERHEAPSIZE_0033 pfnCalcPrivateVideoDecoderHeapSize; PFND3D12DDI_CREATEVIDEODECODERHEAP_0033 pfnCreateVideoDecoderHeap; PFND3D12DDI_DESTROYVIDEODECODERHEAP_0032 pfnDestroyVideoDecoderHeap; PFND3D12DDI_CALCPRIVATEVIDEOPROCESSORSIZE_0043 pfnCalcPrivateVideoProcessorSize; PFND3D12DDI_CREATEVIDEOPROCESSOR_0043 pfnCreateVideoProcessor; PFND3D12DDI_DESTROYVIDEOPROCESSOR_0021 pfnDestroyVideoProcessor; } D3D12DDI_DEVICE_FUNCS_VIDEO_0043; typedef struct D3D12DDIARG_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS_0043 { D3D12DDI_VIDEO_PROCESS_INPUT_STREAM_0020 InputStream[2]; D3D12DDI_VIDEO_PROCESS_TRANSFORM_0032 Transform; D3D12DDI_VIDEO_PROCESS_INPUT_STREAM_FLAGS_0020 Flags; D3D12DDI_VIDEO_PROCESS_INPUT_STREAM_RATE_INFO_0032 RateInfo; INT FilterLevels[D3D12DDI_VIDEO_PROCESS_MAX_FILTERS_0020]; D3D12DDI_VIDEO_PROCESS_ALPHA_BLENDING_0020 AlphaBlending; D3D12DDI_VIDEO_FIELD_TYPE_0020 FieldType; } D3D12DDIARG_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS_0043; typedef VOID ( APIENTRY* PFND3D12DDI_VIDEO_PROCESS_FRAME_0043) ( D3D12DDI_HCOMMANDLIST hDrvCommandList, D3D12DDI_HVIDEOPROCESSOR_0020 hDrvVideoProcessor, const D3D12DDIARG_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS_0032* pOutputParameters, const D3D12DDIARG_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS_0043* pInputStreamParameters, UINT NumInputStreams ); // D3D12DDI_TABLE_TYPE_0022_COMMAND_LIST_VIDEO_DECODE typedef struct D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_PROCESS_0043 { PFND3D12DDI_CLOSECOMMANDLIST pfnCloseCommandList; PFND3D12DDI_RESETCOMMANDLIST_0040 pfnResetCommandList; PFND3D12DDI_DISCARD_RESOURCE_0003 pfnDiscardResource; PFND3D12DDI_SET_MARKER pfnSetMarker; PFND3D12DDI_SET_PREDICATION pfnSetPredication; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnBeginQuery; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnEndQuery; PFND3D12DDI_RESOLVE_QUERY_DATA pfnResolveQueryData; PFND3D12DDI_RESOURCEBARRIER_0022 pfnResourceBarrier; PFND3D12DDI_VIDEO_PROCESS_FRAME_0043 pfnProcessFrame; PFND3D12DDI_SETPROTECTEDRESOURCESESSION_0030 pfnSetProtectedResourceSession; PFND3D12DDI_WRITEBUFFERIMMEDIATE_0032 pfnWriteBufferImmediate; } D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_PROCESS_0043; //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Extended Feature Video // Version: D3D12DDI_FEATURE_VERSION_VIDEO_0053 // Usermode DDI Min Version: D3D12DDI_SUPPORTED_0043 #define D3D12DDI_FEATURE_VERSION_VIDEO_0053_0 13u // UMD handle types */ out IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HVIDEOMOTIONVECTORHEAP_0053 MAKE_D3D12DDI_HVIDEOMOTIONVECTORHEAP_0053(/* } D3D12DDI_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS_0041; DEFINE_ENUM_FLAG_OPERATORS(D3D12DDI_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS_0041); typedef struct D3D12DDI_VIDEO_DECODE_HISTOGRAM_DATA_0041 { UINT NodeIndex; // in GUID DecodeProfile; // in UINT Width; // in UINT Height; // in DXGI_FORMAT DecodeFormat; // in D3D12DDI_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS_0041 Components; // out UINT BinCount; // out UINT CounterBitDepth; // out } D3D12DDI_VIDEO_DECODE_HISTOGRAM_DATA_0041; typedef struct D3D12DDI_VIDEO_DECODE_COMPONENT_HISTOGRAM_0041 { UINT64 Offset; D3D12DDI_HRESOURCE hDrvBuffer; } D3D12DDI_VIDEO_DECODE_COMPONENT_HISTOGRAM_0041; #define D3D12DDI_VIDEO_DECODE_MAX_HISTOGRAM_COMPONENTS 4 typedef struct D3D12DDI_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS_0041 { D3D12DDI_HRESOURCE hDrvOutputTexture2D; UINT OutputSubresource; D3D12DDI_VIDEO_DECODE_CONVERSION_ARGUMENTS_0021 ConversionArguments; D3D12DDI_VIDEO_DECODE_COMPONENT_HISTOGRAM_0041 Histograms[D3D12DDI_VIDEO_DECODE_MAX_HISTOGRAM_COMPONENTS]; } D3D12DDI_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS_0041; typedef VOID ( APIENTRY* PFND3D12DDI_VIDEO_DECODE_FRAME_0041 )( D3D12DDI_HCOMMANDLIST hDrvCommandList, D3D12DDI_HVIDEODECODER_0020 hDrvDecoder, const D3D12DDI_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS_0041* pOutputStreamParameters, const D3D12DDI_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS_0032* pInputStreamParameters ); // D3D12DDI_TABLE_TYPE_0022_COMMAND_LIST_VIDEO_DECODE typedef struct D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_DECODE_0041 { PFND3D12DDI_CLOSECOMMANDLIST pfnCloseCommandList; PFND3D12DDI_RESETCOMMANDLIST_0040 pfnResetCommandList; PFND3D12DDI_DISCARD_RESOURCE_0003 pfnDiscardResource; PFND3D12DDI_SET_MARKER pfnSetMarker; PFND3D12DDI_SET_PREDICATION pfnSetPredication; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnBeginQuery; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnEndQuery; PFND3D12DDI_RESOLVE_QUERY_DATA pfnResolveQueryData; PFND3D12DDI_RESOURCEBARRIER_0022 pfnResourceBarrier; PFND3D12DDI_VIDEO_DECODE_FRAME_0041 pfnDecodeFrame; PFND3D12DDI_SETPROTECTEDRESOURCESESSION_0030 pfnSetProtectedResourceSession; PFND3D12DDI_WRITEBUFFERIMMEDIATE_0032 pfnWriteBufferImmediate; } D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_DECODE_0041; //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Extended Feature Video // Version: D3D12DDI_FEATURE_VERSION_VIDEO_0041_1 // Usermode DDI Min Version: D3D12DDI_SUPPORTED_0040 #define D3D12DDI_FEATURE_VERSION_VIDEO_0041_1 11u typedef struct D3D12DDI_VIDEO_DECODE_CONVERSION_ARGUMENTS_0041 { BOOL Enable; D3D12DDI_HRESOURCE hDrvReferenceTexture2D; UINT ReferenceSubresource; DXGI_COLOR_SPACE_TYPE OutputColorSpace; DXGI_COLOR_SPACE_TYPE DecodeColorSpace; UINT OutputWidth; UINT OutputHeight; } D3D12DDI_VIDEO_DECODE_CONVERSION_ARGUMENTS_0041; typedef struct D3D12DDI_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS_0041_1 { D3D12DDI_HRESOURCE hDrvOutputTexture2D; UINT OutputSubresource; D3D12DDI_VIDEO_DECODE_CONVERSION_ARGUMENTS_0041 ConversionArguments; D3D12DDI_VIDEO_DECODE_COMPONENT_HISTOGRAM_0041 Histograms[D3D12DDI_VIDEO_DECODE_MAX_HISTOGRAM_COMPONENTS]; } D3D12DDI_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS_0041_1; typedef VOID ( APIENTRY* PFND3D12DDI_VIDEO_DECODE_FRAME_0041_1 )( D3D12DDI_HCOMMANDLIST hDrvCommandList, D3D12DDI_HVIDEODECODER_0020 hDrvDecoder, const D3D12DDI_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS_0041_1* pOutputStreamParameters, const D3D12DDI_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS_0032* pInputStreamParameters ); // D3D12DDI_TABLE_TYPE_0022_COMMAND_LIST_VIDEO_DECODE typedef struct D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_DECODE_0041_1 { PFND3D12DDI_CLOSECOMMANDLIST pfnCloseCommandList; PFND3D12DDI_RESETCOMMANDLIST_0040 pfnResetCommandList; PFND3D12DDI_DISCARD_RESOURCE_0003 pfnDiscardResource; PFND3D12DDI_SET_MARKER pfnSetMarker; PFND3D12DDI_SET_PREDICATION pfnSetPredication; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnBeginQuery; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnEndQuery; PFND3D12DDI_RESOLVE_QUERY_DATA pfnResolveQueryData; PFND3D12DDI_RESOURCEBARRIER_0022 pfnResourceBarrier; PFND3D12DDI_VIDEO_DECODE_FRAME_0041_1 pfnDecodeFrame; PFND3D12DDI_SETPROTECTEDRESOURCESESSION_0030 pfnSetProtectedResourceSession; PFND3D12DDI_WRITEBUFFERIMMEDIATE_0032 pfnWriteBufferImmediate; } D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_DECODE_0041_1; //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Extended Feature Video // Version: D3D12DDI_FEATURE_VERSION_VIDEO_0043 // Usermode DDI Min Version: D3D12DDI_SUPPORTED_0040 #define D3D12DDI_FEATURE_VERSION_VIDEO_0043_0 12u typedef struct D3D12DDI_VIDEO_PROCESSOR_INPUT_STREAM_DESC_0043 { DXGI_FORMAT Format; DXGI_COLOR_SPACE_TYPE ColorSpace; DXGI_RATIONAL SourceAspectRatio; DXGI_RATIONAL DestinationAspectRatio; DXGI_RATIONAL FrameRate; D3D12DDI_VIDEO_SIZE_RANGE_0032 SourceSizeRange; D3D12DDI_VIDEO_SIZE_RANGE_0032 DestinationSizeRange; BOOL EnableOrientation; D3D12DDI_VIDEO_PROCESS_FILTER_FLAGS_0020 FilterFlags; D3D12DDI_VIDEO_FRAME_STEREO_FORMAT_0020 StereoFormat; D3D12DDI_VIDEO_PROCESS_DEINTERLACE_FLAGS_0020 DeinterlaceMode; BOOL EnableAlphaBlending; D3D12DDI_VIDEO_PROCESS_LUMA_KEY_0020 LumaKey; UINT NumPastFrames; UINT NumFutureFrames; BOOL EnableAutoProcessing; } D3D12DDI_VIDEO_PROCESSOR_INPUT_STREAM_DESC_0043; typedef struct D3D12DDIARG_CREATE_VIDEO_PROCESSOR_0043 { UINT NodeMask; D3D12DDI_VIDEO_PROCESS_OUTPUT_STREAM_DESC_0032 OutputStream; D3D12DDI_VIDEO_PROCESSOR_INPUT_STREAM_DESC_0043* pInputStreams; UINT NumInputStreams; } D3D12DDIARG_CREATE_VIDEO_PROCESSOR_0043; // D3D12DDICAPS_TYPE_VIDEO_0032_PROCESSOR_SIZE // *pInfo = nullptr // pData = D3D12DDI_VIDEO_PROCESSOR_SIZE_DATA_0043 // DataSize = sizeof(D3D12DDI_VIDEO_PROCESSOR_SIZE_DATA_0043) typedef struct D3D12DDI_VIDEO_PROCESSOR_SIZE_DATA_0043 { D3D12DDIARG_CREATE_VIDEO_PROCESSOR_0043 VideoProcessorDesc; // input UINT64 MemoryPoolL0Size; // output UINT64 MemoryPoolL1Size; // output } D3D12DDI_VIDEO_PROCESSOR_SIZE_DATA_0043; typedef SIZE_T ( APIENTRY* PFND3D12DDI_CALCPRIVATEVIDEOPROCESSORSIZE_0043 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_VIDEO_PROCESSOR_0043* pArgs); typedef HRESULT ( APIENTRY* PFND3D12DDI_CREATEVIDEOPROCESSOR_0043 )( D3D12DDI_HDEVICE hDrvDevice, _In_ CONST D3D12DDIARG_CREATE_VIDEO_PROCESSOR_0043* pArgs, D3D12DDI_HVIDEOPROCESSOR_0020 hDrvVideoProcessor); typedef struct D3D12DDI_DEVICE_FUNCS_VIDEO_0043 { PFND3D12DDI_VIDEO_GETCAPS pfnGetCaps; PFND3D12DDI_CALCPRIVATEVIDEODECODERSIZE_0032 pfnCalcPrivateVideoDecoderSize; PFND3D12DDI_CREATEVIDEODECODER_0032 pfnCreateVideoDecoder; PFND3D12DDI_DESTROYVIDEODECODER_0021 pfnDestroyVideoDecoder; PFND3D12DDI_CALCPRIVATEVIDEODECODERHEAPSIZE_0033 pfnCalcPrivateVideoDecoderHeapSize; PFND3D12DDI_CREATEVIDEODECODERHEAP_0033 pfnCreateVideoDecoderHeap; PFND3D12DDI_DESTROYVIDEODECODERHEAP_0032 pfnDestroyVideoDecoderHeap; PFND3D12DDI_CALCPRIVATEVIDEOPROCESSORSIZE_0043 pfnCalcPrivateVideoProcessorSize; PFND3D12DDI_CREATEVIDEOPROCESSOR_0043 pfnCreateVideoProcessor; PFND3D12DDI_DESTROYVIDEOPROCESSOR_0021 pfnDestroyVideoProcessor; } D3D12DDI_DEVICE_FUNCS_VIDEO_0043; typedef struct D3D12DDIARG_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS_0043 { D3D12DDI_VIDEO_PROCESS_INPUT_STREAM_0020 InputStream[2]; D3D12DDI_VIDEO_PROCESS_TRANSFORM_0032 Transform; D3D12DDI_VIDEO_PROCESS_INPUT_STREAM_FLAGS_0020 Flags; D3D12DDI_VIDEO_PROCESS_INPUT_STREAM_RATE_INFO_0032 RateInfo; INT FilterLevels[D3D12DDI_VIDEO_PROCESS_MAX_FILTERS_0020]; D3D12DDI_VIDEO_PROCESS_ALPHA_BLENDING_0020 AlphaBlending; D3D12DDI_VIDEO_FIELD_TYPE_0020 FieldType; } D3D12DDIARG_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS_0043; typedef VOID ( APIENTRY* PFND3D12DDI_VIDEO_PROCESS_FRAME_0043) ( D3D12DDI_HCOMMANDLIST hDrvCommandList, D3D12DDI_HVIDEOPROCESSOR_0020 hDrvVideoProcessor, const D3D12DDIARG_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS_0032* pOutputParameters, const D3D12DDIARG_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS_0043* pInputStreamParameters, UINT NumInputStreams ); // D3D12DDI_TABLE_TYPE_0022_COMMAND_LIST_VIDEO_DECODE typedef struct D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_PROCESS_0043 { PFND3D12DDI_CLOSECOMMANDLIST pfnCloseCommandList; PFND3D12DDI_RESETCOMMANDLIST_0040 pfnResetCommandList; PFND3D12DDI_DISCARD_RESOURCE_0003 pfnDiscardResource; PFND3D12DDI_SET_MARKER pfnSetMarker; PFND3D12DDI_SET_PREDICATION pfnSetPredication; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnBeginQuery; PFND3D12DDI_BEGIN_END_QUERY_0003 pfnEndQuery; PFND3D12DDI_RESOLVE_QUERY_DATA pfnResolveQueryData; PFND3D12DDI_RESOURCEBARRIER_0022 pfnResourceBarrier; PFND3D12DDI_VIDEO_PROCESS_FRAME_0043 pfnProcessFrame; PFND3D12DDI_SETPROTECTEDRESOURCESESSION_0030 pfnSetProtectedResourceSession; PFND3D12DDI_WRITEBUFFERIMMEDIATE_0032 pfnWriteBufferImmediate; } D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_PROCESS_0043; //---------------------------------------------------------------------------------------------------------------------------------- // D3D12 Extended Feature Video // Version: D3D12DDI_FEATURE_VERSION_VIDEO_0053 // Usermode DDI Min Version: D3D12DDI_SUPPORTED_0043 #define D3D12DDI_FEATURE_VERSION_VIDEO_0053_0 13u // UMD handle types D3D10DDI_H( D3D12DDI_HVIDEOMOTIONESTIMATOR_0053 ) */ out IntPtr h);
        
        [DllImport("d3d12umddi", ExactSpelling = true)]
        public static extern D3D12DDI_HVIDEOPROCESSOR_0020 MAKE_D3D12DDI_HVIDEOPROCESSOR_0020(/* optional(void) */ IntPtr h);
        
        [DllImport("d3d9on12", ExactSpelling = true)]
        public static extern IDirect3D9 Direct3DCreate9On12(uint SDKVersion, ref _D3D9ON12_ARGS pOverrideList, uint NumOverrideEntries);
        
        [DllImport("d3d9on12", ExactSpelling = true)]
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
        
        [DllImport("d3dcsx", ExactSpelling = true)]
        public static extern HRESULT D3DX11CreateFFT(ID3D11DeviceContext pDeviceContext, /* _In_ */ ref D3DX11_FFT_DESC pDesc, uint Flags, /* _Out_ */ out D3DX11_FFT_BUFFER_INFO pBufferInfo, /* _Out_ */ out ID3DX11FFT ppFFT);
        
        [DllImport("d3dcsx", ExactSpelling = true)]
        public static extern HRESULT D3DX11CreateFFT1DComplex(ID3D11DeviceContext pDeviceContext, uint X, uint Flags, /* _Out_ */ out D3DX11_FFT_BUFFER_INFO pBufferInfo, /* _Out_ */ out ID3DX11FFT ppFFT);
        
        [DllImport("d3dcsx", ExactSpelling = true)]
        public static extern HRESULT D3DX11CreateFFT1DReal(ID3D11DeviceContext pDeviceContext, uint X, uint Flags, /* _Out_ */ out D3DX11_FFT_BUFFER_INFO pBufferInfo, /* _Out_ */ out ID3DX11FFT ppFFT);
        
        [DllImport("d3dcsx", ExactSpelling = true)]
        public static extern HRESULT D3DX11CreateFFT2DComplex(ID3D11DeviceContext pDeviceContext, uint X, uint Y, uint Flags, /* _Out_ */ out D3DX11_FFT_BUFFER_INFO pBufferInfo, /* _Out_ */ out ID3DX11FFT ppFFT);
        
        [DllImport("d3dcsx", ExactSpelling = true)]
        public static extern HRESULT D3DX11CreateFFT2DReal(ID3D11DeviceContext pDeviceContext, uint X, uint Y, uint Flags, /* _Out_ */ out D3DX11_FFT_BUFFER_INFO pBufferInfo, /* _Out_ */ out ID3DX11FFT ppFFT);
        
        [DllImport("d3dcsx", ExactSpelling = true)]
        public static extern HRESULT D3DX11CreateFFT3DComplex(ID3D11DeviceContext pDeviceContext, uint X, uint Y, uint Z, uint Flags, /* _Out_ */ out D3DX11_FFT_BUFFER_INFO pBufferInfo, /* _Out_ */ out ID3DX11FFT ppFFT);
        
        [DllImport("d3dcsx", ExactSpelling = true)]
        public static extern HRESULT D3DX11CreateFFT3DReal(ID3D11DeviceContext pDeviceContext, uint X, uint Y, uint Z, uint Flags, /* _Out_ */ out D3DX11_FFT_BUFFER_INFO pBufferInfo, /* _Out_ */ out ID3DX11FFT ppFFT);
        
        [DllImport("d3dcsx", ExactSpelling = true)]
        public static extern HRESULT D3DX11CreateScan(/* _In_ */ ID3D11DeviceContext pDeviceContext, uint MaxElementScanSize, uint MaxScanCount, /* _Out_ */ out ID3DX11Scan ppScan);
        
        [DllImport("d3dcsx", ExactSpelling = true)]
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
        
        [DllImport("ddkmapi", ExactSpelling = true)]
        public static extern uint DxApi(uint dwFunctionNum, IntPtr lpvInBuffer, uint cbInBuffer, IntPtr lpvOutBuffer, uint cbOutBuffer);
        
        [DllImport("ddrawgdi", ExactSpelling = true)]
        public static extern bool GdiEntry1(int pDirectDrawGlobal, IntPtr hdc);
        
        [DllImport("ddrawgdi", ExactSpelling = true)]
        public static extern bool GdiEntry10(int pDirectDrawGlobal, ref bool pbNewMode);
        
        [DllImport("ddrawgdi", ExactSpelling = true)]
        public static extern bool GdiEntry11(int pSurfaceFrom, int pSurfaceTo);
        
        [DllImport("ddrawgdi", ExactSpelling = true)]
        public static extern void GdiEntry12(int pSurface, int pSurfaceAttached);
        
        [DllImport("ddrawgdi", ExactSpelling = true)]
        public static extern uint GdiEntry13();
        
        [DllImport("ddrawgdi", ExactSpelling = true)]
        public static extern IntPtr GdiEntry14(int pDDraw, int pSurface, bool bRelease);
        
        [DllImport("ddrawgdi", ExactSpelling = true)]
        public static extern bool GdiEntry15(int pDDraw, IntPtr hdc, IntPtr lpGammaRamp);
        
        [DllImport("ddrawgdi", ExactSpelling = true)]
        public static extern uint GdiEntry16(int pDDraw, int pDDSLcl1, int pDDSLcl2);
        
        [DllImport("ddrawgdi", ExactSpelling = true)]
        public static extern bool GdiEntry2(int pDirectDrawGlobal, int pHalInfo, int pDDCallbacks, int pDDSurfaceCallbacks, int pDDPaletteCallbacks, ref LPD3DHAL_CALLBACKS pD3dCallbacks, ref LPD3DHAL_GLOBALDRIVERDATA pD3dDriverData, int pD3dBufferCallbacks, int pD3dTextureFormats, ref uint pdwFourCC, /* // Can be NULL */ int pvmList);
        
        [DllImport("ddrawgdi", ExactSpelling = true)]
        public static extern bool GdiEntry3(int pDirectDrawGlobal);
        
        [DllImport("ddrawgdi", ExactSpelling = true)]
        public static extern bool GdiEntry4(int pSurfaceLocal, bool bPrimarySurface);
        
        [DllImport("ddrawgdi", ExactSpelling = true)]
        public static extern bool GdiEntry5(int pSurfaceLocal);
        
        [DllImport("ddrawgdi", ExactSpelling = true)]
        public static extern bool GdiEntry6(int pSurfaceLocal, IntPtr hWnd);
        
        [DllImport("ddrawgdi", ExactSpelling = true)]
        public static extern IntPtr GdiEntry7(int pSurfaceLocal, ref tagPALETTEENTRY pColorTable);
        
        [DllImport("ddrawgdi", ExactSpelling = true)]
        public static extern bool GdiEntry8(int pSurfaceLocal);
        
        [DllImport("ddrawgdi", ExactSpelling = true)]
        public static extern IntPtr GdiEntry9(IntPtr hdc, ref tagBITMAPINFO pbmi, uint iUsage, IntPtr ppvBits, IntPtr hSectionApp, uint dwOffset);
        
        /// <summary>
        /// Creates a single uninitialized object of the class associated with a specified CLSID.  <param name="rclsid"> The CLSID associated with the data and code that will be used to create the object. </param> <param name="riid"> A reference to the identifier of the interface to be used to communicate with the object. </param> <param name="ppv"> Address of pointer variable that receives the interface pointer requested in riid. Upon successful return, *ppv contains the requested interface pointer. Upon failure, *ppv contains NULL.</param> <remarks> While this function is similar to CoCreateInstance, there is no COM involvement. </remarks>
        /// </summary>
        [DllImport("dxcapi", ExactSpelling = true)]
        public static extern HRESULT DxcCreateInstance(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid rclsid, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Out_ */ out IntPtr ppv);
        
        [DllImport("dxcapi", ExactSpelling = true)]
        public static extern HRESULT DxcCreateInstance2(/* _In_ */ IMalloc pMalloc, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid rclsid, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Out_ */ out IntPtr ppv);
        
        [DllImport("dxcore", ExactSpelling = true)]
        public static extern HRESULT DXCoreCreateAdapterFactory([MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvFactory);
        
        [DllImport("dxgidebug", ExactSpelling = true)]
        public static extern HRESULT DXGIGetDebugInterface([MarshalAs(UnmanagedType.LPStruct)] Guid riid, IntPtr ppDebug);
        
        [DllImport("dxva2", ExactSpelling = true)]
        public static extern HRESULT DXVAHD_CreateDevice(/* _In_ */ ref int pD3DDevice, /* _In_ */ ref _DXVAHD_CONTENT_DESC pContentDesc, /* _In_ */ _DXVAHD_DEVICE_USAGE Usage, /* optional(PDXVAHDSW_Plugin) */ IntPtr pPlugin, /* _Outptr_ */ out IDXVAHD_Device ppDevice);
        
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern uint HI32(ulong unPacked);
        
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern uint LO32(ulong unPacked);
        
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
        public static extern HRESULT MFGetAttribute2UINT32asUINT64(IMFAttributes pAttributes, [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* _Out_ */ out uint punHigh32, /* _Out_ */ out uint punLow32);
        
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern void MFGetAttributeDouble(IMFAttributes pAttributes, [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, double fDefault);
        
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFGetAttributeRatio(IMFAttributes pAttributes, [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* _Out_ */ out uint punNumerator, /* _Out_ */ out uint punDenominator);
        
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFGetAttributesAsBlob(/* _In_ */ IMFAttributes pAttributes, /* _Out_writes_bytes_(cbBufSize) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] pBuf, /* _In_ */ int cbBufSize);
        
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFGetAttributesAsBlobSize(/* _In_ */ IMFAttributes pAttributes, /* _Out_ */ out uint pcbBufSize);
        
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFGetAttributeSize(IMFAttributes pAttributes, [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* _Out_ */ out uint punWidth, /* _Out_ */ out uint punHeight);
        
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern uint MFGetAttributeUINT32(IMFAttributes pAttributes, [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, uint unDefault);
        
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern ulong MFGetAttributeUINT64(IMFAttributes pAttributes, [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, ulong unDefault);
        
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
        
        [DllImport("mfplat", ExactSpelling = true)]
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
        public static extern HRESULT MFSetAttribute2UINT32asUINT64(IMFAttributes pAttributes, [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, uint unHigh32, uint unLow32);
        
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFSetAttributeRatio(IMFAttributes pAttributes, [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, uint unNumerator, uint unDenominator);
        
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFSetAttributeSize(IMFAttributes pAttributes, [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, uint unWidth, uint unHeight);
        
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
        
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern ulong Pack2UINT32AsUINT64(uint unHigh, uint unLow);
        
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern ulong PackRatio(int nNumerator, uint unDenominator);
        
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern ulong PackSize(uint unWidth, uint unHeight);
        
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern void Unpack2UINT32AsUINT64(ulong unPacked, /* _Out_ */ out uint punHigh, /* _Out_ */ out uint punLow);
        
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern void UnpackRatio(ulong unPacked, /* _Out_ */ out int pnNumerator, /* _Out_ */ out uint punDenominator);
        
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern void UnpackSize(ulong unPacked, /* _Out_ */ out uint punWidth, /* _Out_ */ out uint punHeight);

        [DllImport("mfplat", ExactSpelling = true)]
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

        [DllImport("mfplat", ExactSpelling = true)]
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

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateExtendedCameraIntrinsicModel(int distortionModelType, /* _COM_Outptr_ */ out IMFExtendedCameraIntrinsicModel ppExtendedCameraIntrinsicModel);

        [DllImport("mfplat", ExactSpelling = true)]
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

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateRelativePanelWatcher(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string videoDeviceId, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string displayMonitorDeviceId, /* _COM_Outptr_ */ out IMFRelativePanelWatcher ppRelativePanelWatcher);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateRemoteDesktopPlugin(/* _Outptr_ */ out IMFRemoteDesktopPlugin ppPlugin);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateSampleCopierMFT(/* _Outptr_ */ out IntPtr ppCopierMFT);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateSampleGrabberSinkActivate(IMFMediaType pIMFMediaType, IMFSampleGrabberSinkCallback pIMFSampleGrabberSinkCallback, /* _Outptr_ */ out IntPtr ppIActivate);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateSensorActivityMonitor(/* _In_ */ IMFSensorActivitiesReportCallback pCallback, /* _COM_Outptr_ */ out IMFSensorActivityMonitor ppActivityMonitor);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateSensorGroup(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string SensorGroupSymbolicLink, /* _COM_Outptr_ */ out IMFSensorGroup ppSensorGroup);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateSensorProfile(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid ProfileType, /* _In_ */ uint ProfileIndex, /* _In_opt_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string Constraints, /* _COM_Outptr_ */ out IMFSensorProfile ppProfile);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateSensorProfileCollection(/* _COM_Outptr_ */ out IMFSensorProfileCollection ppSensorProfile);

        [DllImport("mfplat", ExactSpelling = true)]
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

        [DllImport("mfplat", ExactSpelling = true)]
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
        
        [DllImport("mfd3d12", ExactSpelling = true)]
        public static extern HRESULT MFCreateD3D12SynchronizationObject(/* [annotation][in] _In_ */ ID3D12Device pDevice, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][out] _Outptr_ */ out IntPtr ppvSyncObject);
        
        [DllImport("mfplay", ExactSpelling = true)]
        public static extern HRESULT MFPCreateMediaPlayer(/* _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string pwszURL, /* _In_ */ bool fStartPlayback, /* _In_opt_ */ uint creationOptions, /* _In_opt_ */ IMFPMediaPlayerCallback pCallback, /* optional(HWND__) */ IntPtr hWnd, /* _Out_opt_ */ out IMFPMediaPlayer ppMediaPlayer);
        
        [DllImport("mfreadwrite", ExactSpelling = true)]
        public static extern HRESULT MFCreateSinkWriterFromMediaSink(/* _In_ */ ref int pMediaSink, /* _In_opt_ */ IMFAttributes pAttributes, /* _Out_ */ out IMFSinkWriter ppSinkWriter);
        
        [DllImport("mfreadwrite", ExactSpelling = true)]
        public static extern HRESULT MFCreateSinkWriterFromURL(/* _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string pwszOutputURL, /* _In_opt_ */ IMFByteStream pByteStream, /* _In_opt_ */ IMFAttributes pAttributes, /* _Out_ */ out IMFSinkWriter ppSinkWriter);
        
        [DllImport("mfreadwrite", ExactSpelling = true)]
        public static extern HRESULT MFCreateSourceReaderFromByteStream(/* _In_ */ IMFByteStream pByteStream, /* _In_opt_ */ IMFAttributes pAttributes, /* _Out_ */ out IMFSourceReader ppSourceReader);
        
        [DllImport("mfreadwrite", ExactSpelling = true)]
        public static extern HRESULT MFCreateSourceReaderFromMediaSource(/* _In_ */ ref int pMediaSource, /* _In_opt_ */ IMFAttributes pAttributes, /* _Out_ */ out IMFSourceReader ppSourceReader);
        
        [DllImport("mfreadwrite", ExactSpelling = true)]
        public static extern HRESULT MFCreateSourceReaderFromURL(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pwszURL, /* _In_opt_ */ IMFAttributes pAttributes, /* _Out_ */ out IMFSourceReader ppSourceReader);
        
        [DllImport("mfvirtualcamera", ExactSpelling = true)]
        public static extern HRESULT MFCreateVirtualCamera(/* _In_ */ __MIDL___MIDL_itf_mfvirtualcamera_0000_0000_0001 type, /* _In_ */ __MIDL___MIDL_itf_mfvirtualcamera_0000_0000_0002 lifetime, /* _In_ */ __MIDL___MIDL_itf_mfvirtualcamera_0000_0000_0003 access, /* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string friendlyName, /* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string sourceId, /* _In_reads_opt_(categoryCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] Guid[] categories, /* _In_ */ int categoryCount, /* _COM_Outptr_ */ out IMFVirtualCamera virtualCamera);
        
        [DllImport("mfvirtualcamera", ExactSpelling = true)]
        public static extern HRESULT MFIsVirtualCameraTypeSupported(/* _In_ */ __MIDL___MIDL_itf_mfvirtualcamera_0000_0000_0001 type, /* _Out_ */ out bool supported);
        
        [DllImport("mmdeviceapi", ExactSpelling = true)]
        public static extern HRESULT ActivateAudioInterfaceAsync(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string deviceInterfacePath, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _In_opt_ */ [In, Out] PropVariant activationParams, /* _In_ */ IActivateAudioInterfaceCompletionHandler completionHandler, /* _COM_Outptr_ */ out IActivateAudioInterfaceAsyncOperation activationOperation);
        
        [DllImport("opmapi", ExactSpelling = true)]
        public static extern HRESULT OPMGetVideoOutputForTarget(/* _In_ */ ref LUID pAdapterLuid, /* _In_ */ uint VidPnTarget, /* _In_ */ _OPM_VIDEO_OUTPUT_SEMANTICS vos, /* _COM_Outptr_ */ out IOPMVideoOutput ppOPMVideoOutput);
        
        [DllImport("opmapi", ExactSpelling = true)]
        public static extern HRESULT OPMGetVideoOutputsFromHMONITOR(/* _In_ */ IntPtr hMonitor, /* _In_ */ _OPM_VIDEO_OUTPUT_SEMANTICS vos, /* _Out_ */ out uint pulNumVideoOutputs, /* _Outptr_result_buffer_(*pulNumVideoOutputs) */ out IOPMVideoOutput pppOPMVideoOutputArray);
        
        [DllImport("opmapi", ExactSpelling = true)]
        public static extern HRESULT OPMGetVideoOutputsFromIDirect3DDevice9Object(/* _In_ */ ref int pDirect3DDevice9, /* _In_ */ _OPM_VIDEO_OUTPUT_SEMANTICS vos, /* _Out_ */ out uint pulNumVideoOutputs, /* _Outptr_result_buffer_(*pulNumVideoOutputs) */ out IOPMVideoOutput pppOPMVideoOutputArray);
        
        [DllImport("wincodecsdk", ExactSpelling = true)]
        public static extern HRESULT WICGetMetadataContentSize(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidContainerFormat, /* _In_ */ IWICMetadataWriter pIWriter, /* _Out_ */ out ulong pcbSize);
        
        [DllImport("wincodecsdk", ExactSpelling = true)]
        public static extern HRESULT WICMatchMetadataContent(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidContainerFormat, /* optional(GUID) */ IntPtr pguidVendor, /* _In_ */ IStream pIStream, /* _Out_ */ out Guid pguidMetadataFormat);
        
        [DllImport("wincodecsdk", ExactSpelling = true)]
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
