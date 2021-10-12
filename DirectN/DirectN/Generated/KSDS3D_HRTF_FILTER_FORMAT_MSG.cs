// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(1281,9)
using System;
using System.Runtime.InteropServices;
using KSDS3D_HRTF_COEFF_FORMAT = DirectN.__enum_43219;
using KSDS3D_HRTF_FILTER_METHOD = DirectN.__enum_42017;
using KSDS3D_HRTF_FILTER_VERSION = DirectN.DS3D_HRTF_VERSION_1;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSDS3D_HRTF_FILTER_FORMAT_MSG
    {
        public KSDS3D_HRTF_FILTER_METHOD FilterMethod;
        public KSDS3D_HRTF_COEFF_FORMAT CoeffFormat;
        public KSDS3D_HRTF_FILTER_VERSION Version;
        public uint Reserved;
    }
}
