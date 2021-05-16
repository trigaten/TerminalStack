using System;
using System.Collections.Generic;


namespace TerminalStack
{
    /// <summary>
    /// Stores elements ordered by a float priority.
    /// Multiple elements with the same priority can be stored.
    /// </summary>
    public class PriorityStack
    {
        public PriorityStack()
        {

        }
    }

    /// <summary>
    /// A node for the PriorityStack
    /// </summary>
    /// <remarks>
    /// stores an element and points to next element
    /// </remarks>
    class PriorityNode
    {
        public Item ThisItem { get; set; }
        public Item NextItem { get; set; }

        public PriorityNode(Item item)
        {
            this.ThisItem = item;
            this.NextItem = null;
        }
    }

}
