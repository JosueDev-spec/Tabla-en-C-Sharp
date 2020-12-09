using System;

namespace QuickSharp
{
    public class Tabla{
        private int n;
        public Tabla(int n){
            this.n = n;
       }
       public void mostarTb(){
           
        for(int i= 0 ;i<11;i++){
            int r = n*i;
            Console.WriteLine(i+"*"+n+" = "+r);
    }
       }
    }
    public class Program
    {
        private static void Main()
        {
           
            Tabla tb = new Tabla(3);
            tb.mostarTb();
            
            Console.ReadKey();
        }
    }
}