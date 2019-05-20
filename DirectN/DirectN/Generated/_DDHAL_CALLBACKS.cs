// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ddrawi.h(1664,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_CALLBACKS
    {
        public _DDHAL_DDCALLBACKS cbDDCallbacks;
        public _DDHAL_DDSURFACECALLBACKS cbDDSurfaceCallbacks;
        public _DDHAL_DDPALETTECALLBACKS cbDDPaletteCallbacks;
        public _DDHAL_DDCALLBACKS HALDD;
        public _DDHAL_DDSURFACECALLBACKS HALDDSurface;
        public _DDHAL_DDPALETTECALLBACKS HALDDPalette;
        public _DDHAL_DDCALLBACKS HELDD;
        public _DDHAL_DDSURFACECALLBACKS HELDDSurface;
        public _DDHAL_DDPALETTECALLBACKS HELDDPalette;
        public _DDHAL_DDEXEBUFCALLBACKS cbDDExeBufCallbacks;
        public _DDHAL_DDEXEBUFCALLBACKS HALDDExeBuf;
        public _DDHAL_DDEXEBUFCALLBACKS HELDDExeBuf;
        public _DDHAL_DDVIDEOPORTCALLBACKS cbDDVideoPortCallbacks;
        public _DDHAL_DDVIDEOPORTCALLBACKS HALDDVideoPort;
        public _DDHAL_DDCOLORCONTROLCALLBACKS cbDDColorControlCallbacks;
        public _DDHAL_DDCOLORCONTROLCALLBACKS HALDDColorControl;
        public _DDHAL_DDMISCELLANEOUSCALLBACKS cbDDMiscellaneousCallbacks;
        public _DDHAL_DDMISCELLANEOUSCALLBACKS HALDDMiscellaneous;
        public _DDHAL_DDKERNELCALLBACKS cbDDKernelCallbacks;
        public _DDHAL_DDKERNELCALLBACKS HALDDKernel;
        public _DDHAL_DDMOTIONCOMPCALLBACKS cbDDMotionCompCallbacks;
        public _DDHAL_DDMOTIONCOMPCALLBACKS HALDDMotionComp;
    }
}
