using System;

namespace DirectN
{
    [Flags]
    public enum POINTER_FLAGS
    {
        POINTER_FLAG_NONE = 0x00000000, // Default
        POINTER_FLAG_NEW = 0x00000001, // New pointer
        POINTER_FLAG_INRANGE = 0x00000002, // Pointer has not departed
        POINTER_FLAG_INCONTACT = 0x00000004, // Pointer is in contact
        POINTER_FLAG_FIRSTBUTTON = 0x00000010, // Primary action
        POINTER_FLAG_SECONDBUTTON = 0x00000020, // Secondary action
        POINTER_FLAG_THIRDBUTTON = 0x00000040, // Third button
        POINTER_FLAG_FOURTHBUTTON = 0x00000080, // Fourth button
        POINTER_FLAG_FIFTHBUTTON = 0x00000100, // Fifth button
        POINTER_FLAG_PRIMARY = 0x00002000, // Pointer is primary for system
        POINTER_FLAG_CONFIDENCE = 0x00004000, // Pointer is considered unlikely to be accidental
        POINTER_FLAG_CANCELED = 0x00008000, // Pointer is departing in an abnormal manner
        POINTER_FLAG_DOWN = 0x00010000, // Pointer transitioned to down state (made contact)
        POINTER_FLAG_UPDATE = 0x00020000, // Pointer update
        POINTER_FLAG_UP = 0x00040000, // Pointer transitioned from down state (broke contact)
        POINTER_FLAG_WHEEL = 0x00080000, // Vertical wheel
        POINTER_FLAG_HWHEEL = 0x00100000, // Horizontal wheel
        POINTER_FLAG_CAPTURECHANGED = 0x00200000, // Lost capture
        POINTER_FLAG_HASTRANSFORM = 0x00400000, // Input has a transform associated with it
    }
}
