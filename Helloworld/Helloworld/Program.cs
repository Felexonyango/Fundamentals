using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {


            Person myObj = new Person();
            myObj.name = "Liam";
            Console.WriteLine(myObj.name);

            /*            int index = 1;
                        while (index <= 5)
                        {
                            Console.WriteLine(index);
                            index++;

                        }
                        int[] luckyNums = { 10, 20, 40, 60, 70 };
                        for (int i = 0; i < luckyNums.Length; i++)
                        {
                            Console.WriteLine(luckyNums[i]);
                        }*/
            Book book = new Book("Mike","test",50);
         Console.WriteLine(book.title);
         Console.WriteLine(book.author);
         Console.WriteLine(book.pages);
  



        }
        static int cube(int num)
        {
            int result = num * num * num;

            return result;
        }
        static int GetMax(int num1, int num2, int num3)
        {
            int result;

            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }

            return result;
        }
    }
    class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(string aTitle,string aUthour,int aPage)
        {
           

            title= aTitle;
            author= aUthour;
            pages= aPage;
           

        }
    }

   
   class Person
    {
        private string name;
        public string name;
        {
            get { return name}
            set
            {
                name = "Test";
            }
        }
    }

}