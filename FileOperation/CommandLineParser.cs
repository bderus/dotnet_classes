using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperation
{
    public class CommandLineParser
    {
        public List<string> ArgumentParser(string[] args)
        {
            var parsedArgs = new List<string>();
            foreach(string arg in args)
            {
                if (arg.Contains("="))
                {
                    var parsedString = arg.Substring(arg.IndexOf('=') + 1);
                    parsedArgs.Add(parsedString);
                }
                else
                {
                    Console.WriteLine("Niewłaściwie podany argument");
                }             

            }
            return parsedArgs;
            
        }
    }
}
