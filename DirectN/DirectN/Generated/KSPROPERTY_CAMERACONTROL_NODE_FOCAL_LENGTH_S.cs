// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(5764,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_CAMERACONTROL_NODE_FOCAL_LENGTH_S
    {
        public KSNODEPROPERTY NodeProperty;
        public int lOcularFocalLength;
        public int lObjectiveFocalLengthMin;
        public int lObjectiveFocalLengthMax;
    }
}
