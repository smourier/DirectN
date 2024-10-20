// generated from <Windows SDK Path>\um\gameinput.h
using System;

namespace DirectN
{
    [Flags]
    public enum GameInputFocusPolicy
    {
        GameInputDefaultFocusPolicy = 0x00000000,
        GameInputDisableBackgroundInput = 0x00000001,
        GameInputExclusiveForegroundInput = 0x00000002,
        GameInputDisableBackgroundGuideButton = 0x00000004,
        GameInputExclusiveForegroundGuideButton = 0x00000008,
        GameInputDisableBackgroundShareButton = 0x00000010,
        GameInputExclusiveForegroundShareButton = 0x00000020,
    }
}
