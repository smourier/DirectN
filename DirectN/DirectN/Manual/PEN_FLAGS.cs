using System;

namespace DirectN
{
    [Flags]
    public enum PEN_FLAGS
    {
        PEN_FLAG_NONE = 0x00000000, // Default
        PEN_FLAG_BARREL = 0x00000001, // The barrel button is pressed
        PEN_FLAG_INVERTED = 0x00000002, // The pen is inverted
        PEN_FLAG_ERASER = 0x00000004, // The eraser button is pressed
    }
}
