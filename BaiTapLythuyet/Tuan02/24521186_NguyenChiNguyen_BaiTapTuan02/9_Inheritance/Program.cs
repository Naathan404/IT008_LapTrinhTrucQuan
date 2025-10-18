using System;

namespace Inheritance
{ 
    public class Program
    {
        public static void Main(string[] args)
        {
            Window w = new Window(5, 10);
            w.DrawWindow();

            ListBox lb = new ListBox(20, 10, "Hello World!");
            lb.DrawWindow();
        }
    }

    public class Window
    { 
        public Window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }
        public void DrawWindow()
        { 
            Console.WriteLine("Drawing Window at {0}, {1}", top, left);
        }    
        private int top;
        private int left;
    }

    public class ListBox : Window
    {
        public ListBox(int top, int left, string theContents) : base(top, left)
        {
            mListBoxContents = theContents; 
        }
        public new void DrawWindow()
        {
            base.DrawWindow();
            Console.WriteLine("ListBox write: {0}", mListBoxContents);
        }
        private string mListBoxContents; 

    }
}

