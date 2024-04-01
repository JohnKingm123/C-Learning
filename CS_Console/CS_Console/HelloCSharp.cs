using System;
using RectAPP;
using BookSturcts;


namespace Helloworld_Application {


    struct MyStruct {
        public int X; 
        public int Y;

        public MyStruct(int x , int  y){
            X = x;
            Y = y;
        }    
    }


    class HelloWorld {
        static void Main(string[] args) {
            Console.WriteLine("HelloWorld");
            Book Book1 = new Book();
            Book Book2 = new Book();

            Book1.setValue("C Programming","Nuhua Ali", "C Programming Tutorial", 0);
            Book2.setValue("CS Programming", "Nuhua Ali", "CS Programming Tutorial", 1);

            Book1.display();
            Book2.display();

            Console.ReadLine();
            //////////        A.AcceptDetails();
            //////////        A.OutPut();
            //////////        Console.ReadLine();


        }

    }

}