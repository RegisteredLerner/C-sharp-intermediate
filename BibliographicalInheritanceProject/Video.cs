using System;

namespace BiblioInheritance
{
    class Video : Resource
    {
        public string Director { get; set; }
        public int Runtime { get; set; }
        public string MediaType { get; set; }
        public Video(string title, string category, string director, int runtime, string mediatype) : base(title, category)
        {
            Director = director;
            Runtime = runtime;
            MediaType = mediatype;
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Title:{Title}\nCategory:{Category}\nStatus:{Status}\nDirector:{Director}\nRuntime:{Runtime}\nMediaType:{MediaType}");

        }
        public override void UpdateStatus()
        {
            if (Status == "Streaming")
            {
                Status = "Trailer time";
            }
            else
            {
                Status = "Streaming";
            }
        }
    
    }

}
