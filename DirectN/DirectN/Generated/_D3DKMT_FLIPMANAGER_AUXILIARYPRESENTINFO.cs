// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(500,9)
using System;
using System.Runtime.InteropServices;
using LUID = DirectN._LUID;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_FLIPMANAGER_AUXILIARYPRESENTINFO
    {
        public _D3DKMT_AUXILIARYPRESENTINFO auxiliaryPresentInfo;
        public uint flipManagerTracingId;
        public bool customDurationChanged;
        public LUID FlipAdapterLuid;
        public uint VidPnSourceId;
        public _D3DKMT_FLIPMODEL_INDEPENDENT_FLIP_STAGE independentFlipStage;
        public ulong FlipCompletedQpc;
        public uint HwPresentDurationQpc;
        public bool WasCanceled;
        public bool ConvertedToNonIFlip;
    }
}
