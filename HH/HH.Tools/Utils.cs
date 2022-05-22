namespace HH.Tools
{
    public static class Utils
    {
        public static bool InRange(this int num, int from, int to) => num >= from && num <= to;
        public static bool InRangeOrNull(this int? num, int from, int to) => num == null || num.Value.InRange(from, to);

        public static bool InRangeOrNull(this int? num, int? from, int? to)
            => num == null || num.Value.InRange(from ?? int.MinValue, to ?? int.MaxValue);
    }
}