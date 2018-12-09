// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawi.h(1754,9)
using System;
using System.Runtime.InteropServices;
using LPDDKERNELCAPS = DirectN._DDKERNELCAPS;
using LPDDRAWI_DDMOTIONCOMP_INT = DirectN._DDRAWI_DDMOTIONCOMP_INT;
using LPDDRAWI_DDRAWCLIPPER_INT = DirectN._DDRAWI_DDRAWCLIPPER_INT;
using LPDDRAWI_DDRAWPALETTE_INT = DirectN._DDRAWI_DDRAWPALETTE_INT;
using LPDDRAWI_DDRAWSURFACE_INT = DirectN._DDRAWI_DDRAWSURFACE_INT;
using LPDDRAWI_DDVIDEOPORT_INT = DirectN._DDRAWI_DDVIDEOPORT_INT;
using LPDDRAWI_DIRECTDRAW_GBL = DirectN._DDRAWI_DIRECTDRAW_GBL;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;
using LPDDVIDEOPORTCAPS = DirectN._DDVIDEOPORTCAPS;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public partial struct _DDRAWI_DIRECTDRAW_GBL
    {
        public uint dwRefCnt;
        public uint dwFlags;
        public ulong fpPrimaryOrig;
        public _DDCORECAPS ddCaps;
        public uint dwInternal1;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)] 
        public uint[] dwUnused1;
        public IntPtr lpDDCBtmp;
        public IntPtr dsList;
        public IntPtr palList;
        public IntPtr clipperList;
        public IntPtr lp16DD;
        public uint dwMaxOverlays;
        public uint dwCurrOverlays;
        public uint dwMonitorFrequency;
        public _DDCORECAPS ddHELCaps;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)] 
        public uint[] dwUnused2;
        public _DDCOLORKEY ddckCKDestOverlay;
        public _DDCOLORKEY ddckCKSrcOverlay;
        public _VIDMEMINFO vmiData;
        public IntPtr lpDriverHandle;
        public IntPtr lpExclusiveOwner;
        public uint dwModeIndex;
        public uint dwModeIndexOrig;
        public uint dwNumFourCC;
        public IntPtr lpdwFourCC;
        public uint dwNumModes;
        public IntPtr lpModeInfo;
        public _PROCESS_LIST plProcessList;
        public uint dwSurfaceLockCount;
        public uint dwAliasedLockCnt;
        public IntPtr dwReserved3;
        public IntPtr hDD;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)] 
        public string cObsolete;
        public uint dwReserved1;
        public uint dwReserved2;
        public _DBLNODE dbnOverlayRoot;
        public IntPtr lpwPDeviceFlags;
        public uint dwPDevice;
        public uint dwWin16LockCnt;
        public uint dwUnused3;
        public uint hInstance;
        public uint dwEvent16;
        public uint dwSaveNumModes;
        public IntPtr lpD3DGlobalDriverData;
        public IntPtr lpD3DHALCallbacks;
        public _DDCORECAPS ddBothCaps;
        public IntPtr lpDDVideoPortCaps;
        public IntPtr dvpList;
        public IntPtr lpD3DHALCallbacks2;
        public tagRECT rectDevice;
        public uint cMonitors;
        public IntPtr gpbmiSrc;
        public IntPtr gpbmiDest;
        public IntPtr phaiHeapAliases;
        public IntPtr hKernelHandle;
        public IntPtr pfnNotifyProc;
        public IntPtr lpDDKernelCaps;
        public IntPtr lpddNLVCaps;
        public IntPtr lpddNLVHELCaps;
        public IntPtr lpddNLVBothCaps;
        public IntPtr lpD3DExtendedCaps;
        public uint dwDOSBoxEvent;
        public tagRECT rectDesktop;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] 
        public string cDriverName;
        public IntPtr lpD3DHALCallbacks3;
        public uint dwNumZPixelFormats;
        public IntPtr lpZPixelFormats;
        public IntPtr mcList;
        public uint hDDVxd;
        public _DDSCAPSEX ddsCapsMore;
    }
}
