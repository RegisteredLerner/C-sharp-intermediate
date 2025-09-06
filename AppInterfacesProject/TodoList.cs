using System;

namespace SavingInterface
{
    class TodoList : IDisplayable, IResetable
    {
        public string HeaderSymbol{ get; }
        public string[] Todos
        { get; private set; }

        private int nextOpenIndex;

        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
            HeaderSymbol = "-";
        }

        public void Add(string todo)
        {
            if (nextOpenIndex > 4)
            {
                Console.WriteLine("End of the line");


            }
            else
            {
                Todos[nextOpenIndex] = todo;
                nextOpenIndex++;
            }
            
            
        }
        public void Display()
        {
            Console.WriteLine("Todos");
            Console.WriteLine(String.Concat(Enumerable.Repeat(HeaderSymbol,12)));
            foreach (string todeo in Todos)
            {
                
                if (todeo == null)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.WriteLine(todeo);
                }
            }
        }
        public void Reset()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }
  }
}