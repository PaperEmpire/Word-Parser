// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.InteropServices;
using System.Windows.Markup;
using System.Linq;

do
{

    Console.WriteLine("Insert a paragraph of text:"); // user inputs text

    string paraText = Console.ReadLine(); // store user input in a variable

    string[] paraTextWords = paraText.ToLower().Split(new char[] { ' ', ',', '.', '!', '?', '(', ')' }, StringSplitOptions.RemoveEmptyEntries); // split the paragraph's words into an array and make them lowercase
    var groups = paraTextWords.GroupBy(v => v).OrderByDescending(g => g.Count()); // count all instances of a word in the paragraph for every word that appears then order the results from most to least
    foreach (var group in groups)
    {
        Console.WriteLine("--");
        Console.WriteLine("Value {0} has {1} items", group.Key, group.Count());
    }

    Console.WriteLine("----");
} while (true);
