using System;

namespace DirectN
{
    [Flags]
    public enum POINTER_MOD
    {
        POINTER_MOD_NONE = 0x0000,
        POINTER_MOD_SHIFT = 0x0004,    // Shift key is held down.
        POINTER_MOD_CTRL = 0x0008,    // Ctrl key is held down.
    }
}
