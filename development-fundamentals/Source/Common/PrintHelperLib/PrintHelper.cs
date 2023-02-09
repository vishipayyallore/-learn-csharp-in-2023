using PrintHelperLib.Interfaces;
using System.Collections;

namespace PrintHelperLib
{

    public class PrintHelper : IPrintHelper
    {
        public void Print(string[] names)
        {
            int index = 1;

            Array.ForEach(names, (name) =>
            {
                WriteLine($"{index++}. {name} ({name.Length})");
            });
        }

        public void Print(ArrayList names)
        {
            foreach (string name in names)
            {
                WriteLine(name);
            }
        }
    }

}
