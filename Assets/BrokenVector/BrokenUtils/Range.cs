using UnityEngine;
using Rand = UnityEngine.Random;

namespace BrokenVector.BrokenUtils
{
    /// <summary>
    /// Represents a range between two integer values.
    /// </summary>
    /// <remarks>
    /// Contains usefull methods, like Random()
    /// </remarks>
    public class Range
    {
        public int Min { get; set; }
        public int Max { get; set; }

        public Range(int min, int max)
        {
            Min = min;
            Max = max;
        }

        /// <returns>
        /// a random integer between Min[inclusiv] and Max[exclusiv]
        /// </returns>
        public int Random()
        {
            return Rand.Range(Min, Max);
        }

        public override string ToString()
        {
            return "Range(" + Min + "," + Max + ")";
        }

        protected bool Equals(Range other)
        {
            return Min == other.Min && Max == other.Max;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Range) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Min*397) ^ Max;
            }
        }
    }
}