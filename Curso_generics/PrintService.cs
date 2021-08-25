
using System.IO;
using System;

namespace Curso_generics
{
    // public class PrintService
    // {

    //     private int[] _value = new int[10];
    //     private int _count = 0;


    //     public void AddValue(int value)
    //     {
    //         if (_count == 10)
    //         {

    //             throw new InvalidOperationException("PrintServive is full");

    //         }
    //         _value[_count] = value;
    //         _count++;
    //     }
    //     public int Firt()
    //     {

    //         if (_count == 0)
    //         {

    //             throw new InvalidOperationException("PrintServe is Empity");
    //         }
    //         return _value[0];

    //     }

    //     public void Print()
    //     {

    //         System.Console.Write("[");
    //         for (int i = 0; i < _count - 1; i++)
    //         {
    //             System.Console.Write(_value[i] + " ,");
    //         }
    //         if (_count > 0)
    //         {

    //             System.Console.Write(_value[_count - 1]);
    //         }
    //         System.Console.WriteLine("]");
    //     }




    // }

    public class PrintService<T>
    {

        private T[] _value = new T[10];
        private int _count = 0;


        public void AddValue(T value)
        {
            if (_count == 10)
            {

                throw new InvalidOperationException("PrintServive is full");

            }
            _value[_count] = value;
            _count++;
        }
        public T Firt()
        {

            if (_count == 0)
            {

                throw new InvalidOperationException("PrintServe is Empity");
            }
            return _value[0];

        }

        public void Print()
        {

            System.Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                System.Console.Write(_value[i] + " ,");
            }
            if (_count > 0)
            {

                System.Console.Write(_value[_count - 1]);
            }
            System.Console.WriteLine("]");
        }




    }
}