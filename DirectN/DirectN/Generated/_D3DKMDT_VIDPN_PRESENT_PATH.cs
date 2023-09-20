// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMDT_VIDPN_PRESENT_PATH
    {
        public uint VidPnSourceId;
        public uint VidPnTargetId;
        public _D3DKMDT_VIDPN_PRESENT_PATH_IMPORTANCE ImportanceOrdinal;
        public _D3DKMDT_VIDPN_PRESENT_PATH_TRANSFORMATION ContentTransformation;
        public _D3DKMDT_2DREGION VisibleFromActiveTLOffset;
        public _D3DKMDT_2DREGION VisibleFromActiveBROffset;
        public _D3DKMDT_COLOR_BASIS VidPnTargetColorBasis;
        public _D3DKMDT_COLOR_COEFF_DYNAMIC_RANGES VidPnTargetColorCoeffDynamicRanges;
        public _D3DKMDT_VIDPN_PRESENT_PATH_CONTENT Content;
        public _D3DKMDT_VIDPN_PRESENT_PATH_COPYPROTECTION CopyProtection;
        public _D3DKMDT_GAMMA_RAMP GammaRamp;
    }
}
