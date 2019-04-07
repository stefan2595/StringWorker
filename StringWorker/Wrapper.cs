using System;

namespace StringWorker
{
    public class Wrapper
    {
        public Wrapper(string input)
        {
            if (input.Length != 0)
            {
                internalString = input;
            }
            else
            {
                internalString = "-1";
            }
        }

        public string getValue()
        {
            return internalString;
        }

        public int append(string input)
        {
            internalString += input;
            return internalString.Length;
        }

        public int prepend(string input)
        {
            internalString = internalString.Insert(0, input);
            return internalString.Length;
        }


        public int removeCharAt(int position)
        {
            internalString = internalString.Remove(position, 1);
            return internalString.Length;
        }

        public int emptyString()
        {
            internalString = "";
            return internalString.Length;
        }

        private string internalString;
    }
}
