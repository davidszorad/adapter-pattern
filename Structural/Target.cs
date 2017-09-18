using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Structural
{
    /// <summary>
    /// The 'Target' class
    /// </summary>
    class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request()");
        }
    }
}
