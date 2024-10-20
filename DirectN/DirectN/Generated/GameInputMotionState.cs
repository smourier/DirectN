// generated from <Windows SDK Path>\um\gameinput.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct GameInputMotionState
    {
        public float accelerationX;
        public float accelerationY;
        public float accelerationZ;
        public float angularVelocityX;
        public float angularVelocityY;
        public float angularVelocityZ;
        public float magneticFieldX;
        public float magneticFieldY;
        public float magneticFieldZ;
        public float orientationW;
        public float orientationX;
        public float orientationY;
        public float orientationZ;
        public GameInputMotionAccuracy accelerometerAccuracy;
        public GameInputMotionAccuracy gyroscopeAccuracy;
        public GameInputMotionAccuracy magnetometerAccuracy;
        public GameInputMotionAccuracy orientationAccuracy;
    }
}
