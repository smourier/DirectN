using System;

namespace DirectN
{
    [Flags]
    public enum POINTER_MESSAGE_FLAGS
    {
        POINTER_MESSAGE_FLAG_NONE = 0x00000000,
        POINTER_MESSAGE_FLAG_NEW = 0x00000001,// New pointer
        POINTER_MESSAGE_FLAG_INRANGE = 0x00000002,// Pointer has not departed
        POINTER_MESSAGE_FLAG_INCONTACT = 0x00000004,// Pointer is in contact
        POINTER_MESSAGE_FLAG_FIRSTBUTTON = 0x00000010,// Primary action
        POINTER_MESSAGE_FLAG_SECONDBUTTON = 0x00000020,// Secondary action
        POINTER_MESSAGE_FLAG_THIRDBUTTON = 0x00000040,// Third button
        POINTER_MESSAGE_FLAG_FOURTHBUTTON = 0x00000080,// Fourth button
        POINTER_MESSAGE_FLAG_FIFTHBUTTON = 0x00000100,// Fifth button
        POINTER_MESSAGE_FLAG_PRIMARY = 0x00002000,// Pointer is primary
        POINTER_MESSAGE_FLAG_CONFIDENCE = 0x00004000,// Pointer is considered unlikely to be accidental
        POINTER_MESSAGE_FLAG_CANCELED = 0x00008000,// Pointer is departing in an abnormal manner
    }
}
