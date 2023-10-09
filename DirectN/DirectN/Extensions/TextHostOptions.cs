using System;

namespace DirectN
{
    [Flags]
    public enum TextHostOptions
    {
        None = 0x0,
        WordWrap = TXTBIT.TXTBIT_WORDWRAP,
        Vertical = TXTBIT.TXTBIT_VERTICAL,
        Multiline = TXTBIT.TXTBIT_MULTILINE,
        ReadOnly = TXTBIT.TXTBIT_READONLY,
    }
}
