// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace HelloWorldProgram {
    
    class Program {
        /// <summary>
        /// This is the sample main function
        /// </summary>
        /// <param name="args">Array of string elements for command line</param>
        /// <returns>No Value</returns>
        static void Main (string[] args){
            Console.WriteLine("Whats Your name ?");
            string? str  = Console.ReadLine();
            Console.WriteLine("Why, Hello there " + str);
        }
    }
}