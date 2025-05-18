using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverride4_16
{
    internal class Fish : Animal
    {
        public override void Move()
        {
            base.Move();
            Console.WriteLine("Fish swims");
            System.Windows.Forms.MessageBox.Show("Swim   鱼在水中游动");
        }
    }
    
    
}
