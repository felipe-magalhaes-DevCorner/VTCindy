using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBasicoCindy
{
    public static class HelperClass
    {

        public static System.Windows.Forms.Control FindTag(System.Windows.Forms.Control.ControlCollection controls, string tag)
        {

            for (int i = 0; i < controls.Count; i++)
            {
                var c = controls[i];
                if (c.Tag != null)
                {
                    //logic
                    if (c.Tag.ToString() == tag)
                    {
                        return c;
                    }
                }

                if (c.HasChildren)
                {
                    var Chiildren = FindTag(c.Controls, tag); //Recursively check all children controls as well; ie groupboxes or 
                    if (Chiildren == null)
                    {
                        continue;
                    }
                    return Chiildren;

                }

            }
            return null;

        }
    }
}
