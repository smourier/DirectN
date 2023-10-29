using System;

namespace DirectN
{
    [Flags]
    public enum TASKDIALOG_COMMON_BUTTON_FLAGS
    {
        TDCBF_OK_BUTTON = 0x0001,
        TDCBF_YES_BUTTON = 0x0002,
        TDCBF_NO_BUTTON = 0x0004,
        TDCBF_CANCEL_BUTTON = 0x0008,
        TDCBF_RETRY_BUTTON = 0x0010,
        TDCBF_CLOSE_BUTTON = 0x0020,
    }
}
