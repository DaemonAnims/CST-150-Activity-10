//Code Corrected by Chance Anderson

//Use for IC08
//Lydia's Code

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_10
{
    class Set
    {
        private List<int> elements;

        public Set()
        {
            elements = new List<int>();
        }

        public bool addElement(int val)
        {
            if (containsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }
        }

        private bool containsElement(int val)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (val == elements[i])
                    return true;
                //removed unnecessary else statement; prevented loop from going past first iteration
                //else
                  //  return false;
            }
            return false;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        public void clearSet()
        {
            elements.Clear();
        }

        public Set union(Set rhs)
        {
            //Added temporary Set to prevent alteration of original sets
            Set set = new Set();
            foreach (int val in elements)
                set.addElement(val);
            for (int i = 0; i < rhs.elements.Count; i++)
            {
                set.addElement(rhs.elements[i]);
            }
            //Changed return statement to return temp set; previous return statement
            //only returned the input without any alterations
            //return rhs;
            return set;
        }
    }
}
