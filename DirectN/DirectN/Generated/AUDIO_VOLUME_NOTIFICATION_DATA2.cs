// generated from <Windows SDK Path>\um\audioengineextensionapo.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct AUDIO_VOLUME_NOTIFICATION_DATA2
    {
        public IntPtr notificationData;
        public float masterVolumeInDb;
        public float volumeMinInDb;
        public float volumeMaxInDb;
        public float volumeIncrementInDb;
        public uint step;
        public uint stepCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public float[] channelVolumesInDb;
    }
}
