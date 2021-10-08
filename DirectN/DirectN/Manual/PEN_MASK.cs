using System;

namespace DirectN
{
    [Flags]
    public enum PEN_MASK
    {
        PEN_MASK_NONE = 0x00000000, // Default - none of the optional fields are valid
        PEN_MASK_PRESSURE = 0x00000001, // The pressure field is valid
        PEN_MASK_ROTATION = 0x00000002, // The rotation field is valid
        PEN_MASK_TILT_X = 0x00000004, // The tiltX field is valid
        PEN_MASK_TILT_Y = 0x00000008, // The tiltY field is valid
    }
}
