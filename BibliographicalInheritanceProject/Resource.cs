using System;

namespace BiblioInheritance
{
    class Resource
    {
        public string Title { get; private set; }
        public string Category { get; private set; }
        public string Status { get; protected set; }
        public Resource(string title, string category)
        {
            Title = title;
            Category = category;
            Status = "Available";
        }
        public virtual void UpdateStatus()
        {
            if (Status == "Out")
            {
                Status = "Available";
            }
            else
            {
                Status = "Out";
            }
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Title:{Title}\nCategory:{Category}\nStatus:{Status}");
        }
  }

}