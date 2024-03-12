using System.Numerics;
using System.Runtime.CompilerServices;

namespace Array
{
    internal class Program
    {
        static void Main()
        {
            Array<int> array = new Array<int>();

            array.Add(1);
            array.Add(2);
            array.Add(3);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            array.Remove(2);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public class Array<T>
        {
            private T[] arr;
            public Array(T[] arr)
            {
                this.arr = arr;
            }
            public Array()
            {
                this.arr = new T[0];
            }
            public int Length { get => arr.Length; }
            public T this[int index]
            {
                get => arr[index];
            }
            public void Add(T value)
            {
                T[] tempArray = new T[arr.Length + 1];

                for (int i = 0; i < arr.Length; i++)
                {
                    tempArray[i] = arr[i];
                }
                tempArray[tempArray.Length - 1] = value;
                arr = tempArray;
            }
            public void Remove(int index)
            {
                T[] tempArray = new T[arr.Length - 1];

                for (int i = 0, j = 0; i < arr.Length; i++)
                {
                    if (i == index) continue;
                    tempArray[j++] = arr[i];
                }
                arr = tempArray;
            }
            public int GetLength()
            {
                return arr.Length;
            }
        }
    }
}