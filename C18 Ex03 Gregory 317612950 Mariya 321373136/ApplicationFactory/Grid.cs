using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C18_Ex03_Gregory_317612950_Mariya_321373136
{
    public class Grid : IEnumerable<Control>
    {
        private Dictionary<string, Control> Parts { get; set; }

        public Grid()
        {
            Parts = new Dictionary<string, Control>();
        }

        public Grid Add(String i_PartTitle, Control i_PartControl)
        {
            Parts.Add(i_PartTitle, i_PartControl);
            return this;
        }

        public Control GetPart(String i_PartName)
        {
            return Parts[i_PartName];
        }

        public IEnumerator<Control> GetEnumerator()
        {
            foreach (KeyValuePair<string, Control> gridPart in Parts)
            {
                yield return gridPart.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Parts.GetEnumerator();
        }
    }

}
