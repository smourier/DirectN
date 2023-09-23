// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;
using LUID = DirectN._LUID;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_FLIPMODEL_PRESENTHISTORYTOKEN
    {
        public ulong FenceValue;
        public ulong hLogicalSurface;
        public IntPtr dxgContext;
        public uint VidPnSourceId;
        public uint SwapChainIndex;
        public ulong PresentLimitSemaphoreId;
        public D3DDDI_FLIPINTERVAL_TYPE FlipInterval;
        public _D3DKMT_FLIPMODEL_PRESENTHISTORYTOKENFLAGS Flags;
        public long hCompSurf;
        public LUID compSurfLuid;
        public ulong confirmationCookie;
        public ulong CompositionSyncKey;
        public uint RemainingTokens;
        public tagRECT ScrollRect;
        public tagPOINT ScrollOffset;
        public uint PresentCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public float[] RevealColor;
        public _D3DDDI_ROTATION Rotation;
        public _D3DKMT_FLIPMODEL_PRESENTHISTORYTOKEN__union_0 __union_18;
        public uint InkCookie;
        public tagRECT SourceRect;
        public uint DestWidth;
        public uint DestHeight;
        public tagRECT TargetRect;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)] 
        public float[] Transform;
        public uint CustomDuration;
        public D3DDDI_FLIPINTERVAL_TYPE CustomDurationFlipInterval;
        public uint PlaneIndex;
        public D3DDDI_COLOR_SPACE_TYPE ColorSpace;
        public _D3DKMT_DIRTYREGIONS DirtyRegions;
    }
}
