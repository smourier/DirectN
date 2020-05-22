// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksmedia.h(6790,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagTRANSPORTBASICPARMS
    {
        public int TimeFormat;
        public int TimeReference;
        public int Superimpose;
        public int EndStopAction;
        public int RecordFormat;
        public int StepFrames;
        public int SetpField;
        public int Preroll;
        public int RecPreroll;
        public int Postroll;
        public int EditDelay;
        public int PlayTCDelay;
        public int RecTCDelay;
        public int EditField;
        public int FrameServo;
        public int ColorFrameServo;
        public int ServoRef;
        public int WarnGenlock;
        public int SetTracking;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)] 
        public char[] VolumeName;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)] 
        public int[] Ballistic;
        public int Speed;
        public int CounterFormat;
        public int TunerChannel;
        public int TunerNumber;
        public int TimerEvent;
        public int TimerStartDay;
        public int TimerStartTime;
        public int TimerStopDay;
        public int TimerStopTime;
    }
}
