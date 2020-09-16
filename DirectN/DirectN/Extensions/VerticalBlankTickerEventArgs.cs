using System;

namespace DirectN
{
    public sealed class VerticalBlankTickerEventArgs : EventArgs
    {
        internal VerticalBlankTickerEventArgs(long ticks)
        {
            Ticks = ticks;
        }

        public long Ticks { get; }
    }
}
