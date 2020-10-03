using System.Text;
using TERG.Core.Interfaces;

namespace TERG.Core.Models.References
{
    public class RandomIntegerReference : IReference
    {
        public string Type
        {
            get
            {
                return "RINT";
            }
        }

        // Reference Settings
        public int Min;

        public int Max;
        public int MinLength;

        public RandomIntegerReference()
        {
            Min = 0;
            Max = 0;
            MinLength = 0;
        }

        public string Pull(Engine e)
        {
            int num = Engine.RNG.Next(Min, Max);
            StringBuilder r = new StringBuilder(num.ToString());
            if (MinLength > 0)
            {
                int offset = 0;
                if (num < 0) offset = 1;
                r.Insert(offset, "0", MinLength - r.Length);
            }
            return r.ToString();
        }

        public string ToString(Engine e)
        {
            return "RINT: m" + Min + " M" + Max + " Z" + MinLength;
        }
    }
}