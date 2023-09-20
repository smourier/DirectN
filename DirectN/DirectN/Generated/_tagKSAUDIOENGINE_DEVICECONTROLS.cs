// generated from <Windows SDK Path>\shared\ksmedia.h
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
