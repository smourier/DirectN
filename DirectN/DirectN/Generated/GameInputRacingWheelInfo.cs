// generated from <Windows SDK Path>\um\gameinput.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct GameInputRacingWheelInfo
    {
        public GameInputLabel menuButtonLabel;
        public GameInputLabel viewButtonLabel;
        public GameInputLabel previousGearButtonLabel;
        public GameInputLabel nextGearButtonLabel;
        public GameInputLabel dpadUpLabel;
        public GameInputLabel dpadDownLabel;
        public GameInputLabel dpadLeftLabel;
        public GameInputLabel dpadRightLabel;
        public bool hasClutch;
        public bool hasHandbrake;
        public bool hasPatternShifter;
        public int minPatternShifterGear;
        public int maxPatternShifterGear;
        public float maxWheelAngle;
    }
}
