using System;

namespace BiblioInheritance
{
    class Periodical : Resource
    {
        public string Period { get; set; }
        public Periodical(string title, string category, string period) : base(title, category)
        {
            Period = period;

        }
        public override void UpdateStatus()
        {
            if (Status == "In-use")
            {
                Status = "Available";
            }
            else
            {
                Status = "In-use";
            }
        }
    }
 
}