using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperation
{
    internal class CommandLineParser
    {
        public List<string> ArgumentParser(string[] args)
        {
            var parsedArgs = new List<string>();
            foreach(string arg in args)
            {
                if (arg.Contains("="))
                {
                    arg.Substring(arg.IndexOf('='));
                    parsedArgs.Add(arg);
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
