using System;

namespace BookSturcts

{
    struct Book {
        private string title;
        private string author;
        private string subject;
        private int book_id;

        public void setValue(string t, string a, string s, int  id) { 
            title = t; author = a; subject = s; book_id = id;   
        }

        public void display() { 
            Console.WriteLine(title);
            Console.WriteLine(author);
            Console.WriteLine(subject);
            Console.WriteLine(book_id);
            Console.WriteLine("");
        }

    }





}
