namespace _16._The_loop_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The while loop for reference");
            int i = 0;
            while (i <= 5) {
                Console.WriteLine(i);
                i++;

                Console.WriteLine("The for loop");
                for(i = 0; i <= 5; i++) {
                  Console.WriteLine(i);
                
                }
            
            }
        }
    }
}