using System;
using System.Collections.Generic;
using System.Text;

namespace CodeKatas
{
    public class InvalidSchemeException : Exception { };
    public class ArgsClass
    {   
        

        public Dictionary<string, bool> Args(string[] scheme, string args)
        {
            var dict = new Dictionary<string, bool>();

            if (scheme.Length == 0)
                throw new Exception("No scheme");     

            foreach (string command in scheme)
            {
                if (command.Length != 2 && command[0] != '-')
                    throw new InvalidSchemeException();
                else
                {
                    dict.Add(command, false);

                }
            }
            return dict;
        }
    }
}
