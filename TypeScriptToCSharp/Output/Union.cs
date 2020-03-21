using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSCS
{
    public abstract class Union
    {
        public virtual object Value { get; set; }
    }

    public class Union<T1, T2>:Union
    {
        public static implicit operator Union<T1, T2>(T1 value)
        {
            return new Union<T1, T2>() { Value = value };
        }
        public static implicit operator Union<T1, T2>(T2 value)
        {
            return new Union<T1, T2>() { Value = value };
        }
    }

    public class Union<T1, T2, T3> : Union
    {
        public static implicit operator Union<T1, T2, T3>(T1 value)
        {
            return new Union<T1, T2, T3>() { Value = value };
        }
        public static implicit operator Union<T1, T2, T3>(T2 value)
        {
            return new Union<T1, T2, T3>() { Value = value };
        }
        public static implicit operator Union<T1, T2, T3>(T3 value)
        {
            return new Union<T1, T2, T3>() { Value = value };
        }
    }

    public class Union<T1, T2, T3, T4> : Union
    {
        public static implicit operator Union<T1, T2, T3, T4>(T1 value)
        {
            return new Union<T1, T2, T3, T4>() { Value = value };
        }
        public static implicit operator Union<T1, T2, T3, T4>(T2 value)
        {
            return new Union<T1, T2, T3, T4>() { Value = value };
        }
        public static implicit operator Union<T1, T2, T3, T4>(T3 value)
        {
            return new Union<T1, T2, T3, T4>() { Value = value };
        }
        public static implicit operator Union<T1, T2, T3, T4>(T4 value)
        {
            return new Union<T1, T2, T3, T4>() { Value = value };
        }
    }

    public class Union<T1, T2, T3, T4, T5> : Union
    {
        public static implicit operator Union<T1, T2, T3, T4, T5>(T1 value)
        {
            return new Union<T1, T2, T3, T4, T5>() { Value = value };
        }
        public static implicit operator Union<T1, T2, T3, T4, T5>(T2 value)
        {
            return new Union<T1, T2, T3, T4, T5>() { Value = value };
        }
        public static implicit operator Union<T1, T2, T3, T4, T5>(T3 value)
        {
            return new Union<T1, T2, T3, T4, T5>() { Value = value };
        }
        public static implicit operator Union<T1, T2, T3, T4, T5>(T4 value)
        {
            return new Union<T1, T2, T3, T4, T5>() { Value = value };
        }
        public static implicit operator Union<T1, T2, T3, T4, T5>(T5 value)
        {
            return new Union<T1, T2, T3, T4, T5>() { Value = value };
        }
    }

    public class Union<T1, T2, T3, T4, T5, T6> : Union
    {
        public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T1 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6>() { Value = value };
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T2 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6>() { Value = value };
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T3 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6>() { Value = value };
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T4 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6>() { Value = value };
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T5 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6>() { Value = value };
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T6 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6>() { Value = value };
        }
    }

    public class Union<T1, T2, T3, T4, T5, T6, T7> : Union
    {
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T1 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7>() { Value = value };
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T2 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7>() { Value = value };
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T3 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7>() { Value = value };
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T4 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7>() { Value = value };
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T5 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7>() { Value = value };
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T6 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7>() { Value = value };
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T7 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7>() { Value = value };
        }
    }

    public class Union<T1, T2, T3, T4, T5, T6, T7, T8> : Union
    {
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T1 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8>() { Value = value };
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T2 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8>() { Value = value };
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T3 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8>() { Value = value };
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T4 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8>() { Value = value };
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T5 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8>() { Value = value };
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T6 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8>() { Value = value };
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T7 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8>() { Value = value };
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T8 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8>() { Value = value };
        }
    }
}
