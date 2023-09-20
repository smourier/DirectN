// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_AV1__struct_4
    {
        public _DXVA_PicParams_AV1__struct_4__union_0 __union_0;
        public byte base_qindex;
        public sbyte y_dc_delta_q;
        public sbyte u_dc_delta_q;
        public sbyte v_dc_delta_q;
        public sbyte u_ac_delta_q;
        public sbyte v_ac_delta_q;
        public byte qm_y;
        public byte qm_u;
        public byte qm_v;
        public ushort Reserved16Bits;
    }
}
