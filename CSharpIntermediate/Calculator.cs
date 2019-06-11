using System.Linq;

namespace CSharpIntermediate
{
    public class Calculator
    {
        public int Add(params int[] numbers) // params keyword allows method to accept a varying number of arguments
        {
            int sum = 0;
            sum = numbers.Aggregate((a, b) => a + b); 

            return sum;
        }
    }
}
