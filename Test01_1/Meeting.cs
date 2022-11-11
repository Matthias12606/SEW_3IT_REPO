using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01_1
{
    internal class Meeting
    {
        public string Description { get; set; }
        public int? EstimatedDurationInMinutes { get; set; }
        public MeetingType Type;

        public Meeting(string Description, int? EstimatedDurationInMinutes, MeetingType Type)
        {
            this.Description = Description;
            this.EstimatedDurationInMinutes = EstimatedDurationInMinutes;
            this.Type = Type;
            
        }

        public override string ToString()
        {
            return "Description: " + this.Description + "Estimated Duration: " + this.EstimatedDurationInMinutes + " hours , Type: " + this.Type;
        }
    }
}
