using System;
using System.Collections.Generic;

namespace DirectN
{
    public partial struct DWRITE_TEXT_RANGE : IEquatable<DWRITE_TEXT_RANGE>, IComparable<DWRITE_TEXT_RANGE>, IComparable
    {
        public static DWRITE_TEXT_RANGE All => new DWRITE_TEXT_RANGE(0);

        public uint EndPosition => startPosition + length;

        public DWRITE_TEXT_RANGE(uint startPosition, uint length)
        {
            this.startPosition = startPosition;
            this.length = length;
        }

        public DWRITE_TEXT_RANGE(uint startPosition)
        {
            this.startPosition = startPosition;
            length = uint.MaxValue - startPosition;
        }

        public bool Contains(uint position) => position >= startPosition && position < EndPosition;
        public bool IntersectsWith(DWRITE_TEXT_RANGE range) => Intersect(range).length > 0;
        public DWRITE_TEXT_RANGE Intersect(DWRITE_TEXT_RANGE range)
        {
            var start = Math.Max(startPosition, range.startPosition);
            var end = Math.Min(EndPosition, range.EndPosition);
            if (end < start)
                return new DWRITE_TEXT_RANGE();

            return new DWRITE_TEXT_RANGE(start, end - start);
        }

        public override string ToString() => "S:" + startPosition + " E:" + EndPosition + " L:" + length;

        public static IEnumerable<DWRITE_TEXT_RANGE> Search(string input, string search, StringComparison comparison = StringComparison.CurrentCulture, int maxCount = int.MaxValue, int startPosition = 0, int endPosition = int.MaxValue)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (search == null)
                throw new ArgumentNullException(nameof(search));

            if (startPosition < 0)
                throw new ArgumentOutOfRangeException(nameof(startPosition));

            if (endPosition < startPosition)
                throw new ArgumentOutOfRangeException(nameof(endPosition));

            if (endPosition == startPosition || maxCount == 0 || search.Length == 0 || input.Length == 0 || search.Length > input.Length)
                yield break;

            var count = 0;
            var len = input.Length - search.Length;
            for (var i = Math.Min(startPosition, input.Length); i <= Math.Min(endPosition, len); i++)
            {
                if (count == maxCount)
                    yield break;

                var text = input.Substring(i, search.Length);
                if (string.Compare(text, search, comparison) == 0)
                {
                    yield return new DWRITE_TEXT_RANGE((uint)i, (uint)search.Length);
                    // we don't support overlaps
                    i += search.Length - 1;
                }
            }
        }

        public static DWRITE_TEXT_RANGE FromTo(uint startPosition, uint endPosition, bool allowReverse = true)
        {
            if (startPosition > endPosition)
            {
                if (allowReverse)
                    return new DWRITE_TEXT_RANGE(endPosition, startPosition - endPosition);

                throw new ArgumentException(null, nameof(endPosition));
            }
            return new DWRITE_TEXT_RANGE(startPosition, endPosition - startPosition);
        }

        int IComparable.CompareTo(object obj) => CompareTo((DWRITE_TEXT_RANGE)obj);
        public int CompareTo(DWRITE_TEXT_RANGE other)
        {
            var cmp = startPosition.CompareTo(other.startPosition);
            if (cmp != 0)
                return cmp;

            return length.CompareTo(other.length);
        }

        public bool Equals(DWRITE_TEXT_RANGE other) => startPosition == other.startPosition && length == other.length;
        public override bool Equals(object obj) => obj is DWRITE_TEXT_RANGE rg && Equals(rg);
        public override int GetHashCode() => startPosition.GetHashCode() ^ length.GetHashCode();
        public static bool operator ==(DWRITE_TEXT_RANGE left, DWRITE_TEXT_RANGE right) => left.Equals(right);
        public static bool operator !=(DWRITE_TEXT_RANGE left, DWRITE_TEXT_RANGE right) => !left.Equals(right);
    }
}
