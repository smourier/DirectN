// generated from <Windows SDK Path>\um\gameinput.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct GameInputForceFeedbackRampParams
    {
        public GameInputForceFeedbackEnvelope envelope;
        public GameInputForceFeedbackMagnitude startMagnitude;
        public GameInputForceFeedbackMagnitude endMagnitude;
    }
}
