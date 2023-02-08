using NamesArrayListLib.Interfaces;
using System.Collections;

namespace NamesArrayListLib
{

    public class PrintHelper : IPrintHelper
    {

        public void Print(ArrayList names)
        {
            foreach (string name in names)
            {
                WriteLine(name);
            }
        }

    }

}
