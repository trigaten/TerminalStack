using System;

namespace TerminalStack
{
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public TimeSpan TimeExpected { get; set; }
        public float Priority { get; set; }

        public Item(string name, string description, TimeSpan timeExpected, float priority)
        {
            this.Name = name;
            this.Description = description;
            this.TimeExpected = timeExpected;
            this.Priority = priority;
        }
    }
}