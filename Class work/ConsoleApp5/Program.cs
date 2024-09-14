namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mymath m;
            Mymath ad = Cal.add;
            Mymath su = Cal.subtract;
           m=ad;
            m += su;
            m(10, 20);

            

        }
    }
}
