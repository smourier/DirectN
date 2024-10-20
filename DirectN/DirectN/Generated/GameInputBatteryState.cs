// generated from <Windows SDK Path>\um\gameinput.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct GameInputBatteryState
    {
        public float chargeRate;
        public float maxChargeRate;
        public float remainingCapacity;
        public float fullChargeCapacity;
        public GameInputBatteryStatus status;
    }
}
