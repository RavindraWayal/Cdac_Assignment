namespace del{
    public delegate int add(int a,int b);
    class Myclass{
        public int cal(int a,int b){
            return a+b;
        }

        public static void Main(){
            del obj=new del();
            add x=new x(obj.cal);
            Console.WriteLine(x(10,2));
        }
    }
}