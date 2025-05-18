using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverride4_16
{
    internal class Animal
    {
        public virtual void Move()
        {
            Console.WriteLine("Animal speaks");
            System.Windows.Forms.MessageBox.Show("所有动物都有的走动行为");
        }

    }
}
