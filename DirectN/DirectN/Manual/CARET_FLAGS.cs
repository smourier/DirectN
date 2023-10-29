using System;

namespace DirectN
{
    [Flags]
    public enum CARET_FLAGS
    {
        CARET_NONE = 0, // Normal Western caret (blinking vertical bar)
        CARET_CUSTOM = 1, // Adorned caret, only set currently for RTL
        CARET_RTL = 2,
        CARET_ITALIC = 32,
        CARET_NULL = 64, // Nondegenerate selection: use empty bitmap
        CARET_ROTATE90 = 128, // Rotate 90 degrees clockwise
    }
}
