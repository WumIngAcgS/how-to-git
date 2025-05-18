using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverride4_16
{
    internal class Bird: Animal
    {
        public override void Move()
        {
            System.Windows.Forms.MessageBox.Show("Fly    鸟在空中飞");
        }
        //public void Fly()
        //{
        //    Console.WriteLine("Bird flies");
        //    System.Windows.Forms.MessageBox.Show("Fly    鸟在空中飞");
        //}
    }
}
