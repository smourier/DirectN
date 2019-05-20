// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\ksmedia.h(6677,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagDEVCAPS
    {
        public int CanRecord;
        public int CanRecordStrobe;
        public int HasAudio;
        public int HasVideo;
        public int UsesFiles;
        public int CanSave;
        public int DeviceType;
        public int TCRead;
        public int TCWrite;
        public int CTLRead;
        public int IndexRead;
        public int Preroll;
        public int Postroll;
        public int SyncAcc;
        public int NormRate;
        public int CanPreview;
        public int CanMonitorSrc;
        public int CanTest;
        public int VideoIn;
        public int AudioIn;
        public int Calibrate;
        public int SeekType;
        public int SimulatedHardware;
    }
}
