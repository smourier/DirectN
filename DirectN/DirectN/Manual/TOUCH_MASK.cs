using System;

namespace DirectN
{
    [Flags]
    public enum TOUCH_MASK
    {
        TOUCH_MASK_NONE = 0x00000000, // Default - none of the optional fields are valid
        TOUCH_MASK_CONTACTAREA = 0x00000001, // The rcContact field is valid
        TOUCH_MASK_ORIENTATION = 0x00000002, // The orientation field is valid
        TOUCH_MASK_PRESSURE = 0x00000004, // The pressure field is valid
    }
}
