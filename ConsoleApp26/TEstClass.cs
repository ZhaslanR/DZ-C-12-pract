using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    public delegate void PropertyEventHandler(object sender, PropertyEventArgs e);
    public class TestClass : IPropertychanged
    {
        public event PropertyEventHandler PropertyChanged;
        PropertyEventArgs args = new PropertyEventArgs();

        private int number;

        public int Number
        {
            get { return number; }
            set
            {
                number = value;
                args.Message = String.Format("Значение измениловь на {0}.", value);
                PropertyChanged?.Invoke(this, args);
            }
        }
    }
}
