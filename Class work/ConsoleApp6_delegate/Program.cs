namespace ConsoleApp6_delegate
{
    internal class Program
    {
        // delegate int Myfac(int x);
        delegate void print(int s);
        static void Main(string[] args)
        {
           /* Myfac fac = delegate (int x)
            {
                int fact = 1;
                for (int i = 1; i <= x; i++)
                {
                    fact = fact * i;
                    
                }
                
                return fact;
            };
            
            Console.WriteLine(fac(1));
           */
           print p=s=>Console .WriteLine(s);
            p(2);

            
            
            
        }
    }
}
