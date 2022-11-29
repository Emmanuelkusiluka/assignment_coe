// Condition: Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …

using System.Numerics;

namespace FibonacciSequence
{
    class Program
    {
        static void Main()
        {
            BigInteger newElement;
            BigInteger[] sequenceMembers = { 0, 1 };
            Console.Write("{0},\n{1},\n", sequenceMembers[0], sequenceMembers[1]);
            for (int i = 0; i < 98; i++)
            {
                newElement = sequenceMembers[0] + sequenceMembers[1];
                Console.WriteLine("{0},",newElement);
                sequenceMembers[0] = sequenceMembers[1];
                sequenceMembers[1] = newElement;
            }
        }
    }
}