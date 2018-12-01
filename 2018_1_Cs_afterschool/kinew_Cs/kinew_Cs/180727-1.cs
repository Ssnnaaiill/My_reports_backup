using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kinew_Cs
{
    class _180727_1
    {
        class Book
        {
            string name, date, author, owner, publisher, seniorEditor, producer, editor, designer;
            public Book(string name, string date, string author, string owner, string publisher, string seniorEditor, string producer, string editor, string designer)
            {
                this.name = name;
                this.date = date;
                this.author = author;
                this.owner = owner;
                this.publisher = publisher;
                this.seniorEditor = seniorEditor;
                this.producer = producer;
                this.editor = editor;
                this.designer = designer;
            }
            public void BookInfo()
            {
                Console.WriteLine("이름\t\t" + name);
                Console.WriteLine("초판발행\t" + date);
                Console.WriteLine("지은이\t\t" + author);
                Console.WriteLine("펴낸이\t\t" + owner);
                Console.WriteLine("펴낸곳\t\t" + publisher);
                Console.WriteLine("책임편집\t" + seniorEditor);
                Console.WriteLine("기획\t\t" + producer);
                Console.WriteLine("편집\t\t" + editor);
                Console.WriteLine("디자인\t\t" + designer);
            }
        }
        static void BookStoreClassExample(string[] args)
        {
            Book example = new Book("PHP프로그래밍 입문", "2013-05-20", "황재호", "김태헌", "한빛아카데미(주)", "김현용", "김이화", "김이화", "여동일");
            example.BookInfo();
        }
    }
}