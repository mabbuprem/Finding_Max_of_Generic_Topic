using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finding_Max_Of_Generic_Topic
{
    public class IntMax<T>
    {
        public T[] valueofArray;

        public IntMax(T[] valueofArray)
        {
            this.valueofArray = valueofArray;
        }
        public T[] Sort(T[] valuesofArray)
        {
            Array.Sort(valuesofArray);
            return valuesofArray;
        }
        public T MaxOfArray(T[] valuesofArray)
        {
            var sorted_Values = Sort(valuesofArray);
            return sorted_Values[^1];
        }
        public T MaxMethod()
        {
            var max = MaxOfArray(valueofArray);
            return max;
        }



    }
}