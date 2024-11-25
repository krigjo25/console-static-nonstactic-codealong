using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showplaces
{
    public class Place
    {
        //  object members
        public string PlaceName { get; private set; }
        public string Municipality { get; private set; }
        public string Region { get; private set; }

        //  Most common way to initialize an object
        public Place(string pm, string municipality, string region)
        {
            PlaceName = pm;
            Region = region;
            Municipality = municipality;

            
        }
        // Object method
        public void ShowPlace()
        {
            int inline_size = 10;
            SeperateRow();
            PrintMessage("Name", inline_size, PlaceName);
            PrintMessage("Kommune", inline_size, Municipality);
            PrintMessage("Fylke", inline_size, Region);
            SeperateRow();
        }

        private void PrintMessage(string label, int inline_size, string field)
        {
            inline_size -= label.Length;
            Console.WriteLine($"{label} :" + " ".PadLeft(inline_size, ' ') + $"{field}");
        }

        private void SeperateRow(int inline_size = 20)
        {
            Console.WriteLine(string.Empty.PadLeft(inline_size, '*'));
        }

    }

}
