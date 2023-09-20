// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_CAMERACONTROL_FOCAL_LENGTH_S
    {
        public KSIDENTIFIER Property;
        public int lOcularFocalLength;
        public int lObjectiveFocalLengthMin;
        public int lObjectiveFocalLengthMax;
    }
}
