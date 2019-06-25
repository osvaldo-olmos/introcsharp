using System;
using System.Collections;
using System.Collections.Generic;

namespace OOP_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessMan businessMan = new BusinessMan();
            Console.WriteLine(businessMan.Drive());
            Console.WriteLine(businessMan.Stop());

            //playing squash
            ISquashPlayer squashPlayer =(ISquashPlayer)businessMan;
            Console.WriteLine(squashPlayer.Drive());
            Console.WriteLine(businessMan.Backhand());
            Console.WriteLine(businessMan.Serve());
            Console.WriteLine(businessMan.Drop());
        }
    }
}
