using System;
using System.Security.Cryptography.X509Certificates;

namespace RectAPP
{
    class Rect {
    double lenth;
    double width;
        
    public void AcceptDetails() { 
        lenth = 4.5;
        width = 3.5;
    }

        public double GetS() {
            return lenth * width;
        }
        public void OutPut() {
            Console.WriteLine("Length:{0}",lenth);
            Console.WriteLine("Width:{0}", width);
            Console.WriteLine("Area:{0}", GetS());
        }
    }

    //class RxecuteRectangle {
    //    static void Main(string[] args) {
    //        Rect A = new Rect();
    //        A.AcceptDetails();
    //        A.OutPut();
    //        Console.ReadLine();
        
    //    }
    
    
    
    //}



}
