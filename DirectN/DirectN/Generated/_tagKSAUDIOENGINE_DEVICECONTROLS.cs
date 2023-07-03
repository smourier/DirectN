// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\ksmedia.h(8238,9)
using System.Runtime.InteropServices;
using EDeviceControlUseType = DirectN.eDeviceControlUse;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _tagKSAUDIOENGINE_DEVICECONTROLS
    {
        public EDeviceControlUseType Volume;
        public EDeviceControlUseType Mute;
        public EDeviceControlUseType PeakMeter;
    }
}
