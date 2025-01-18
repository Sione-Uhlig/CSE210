using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class Journal
{
    public void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
        Console.Write("What would you like to do? ");
    }
    
}