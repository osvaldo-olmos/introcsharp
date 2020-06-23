using System;
using System.Collections;
using System.Collections.Generic;

namespace OOP_Interfaces
{
    public interface IDriver
    {
        string Drive();
        string Stop();
    }

    public interface ISquashPlayer
    {
        string Serve();
        string Drive();
        string Backhand();
        string Drop();
    }

    public class BusinessMan : ISquashPlayer, IDriver
    {

        public string Drive()
        {
            return "Driving business";
        }


        //Explicit implementation cannot have public/protected or private
        string IDriver.Drive()
        {
            return "Driving a vehicle...";
        }

        //Explicit implementation cannot have public/protected or private
        string ISquashPlayer.Drive()
        {
            return "Hitting a drive";
        }

        public string Backhand()
        {
            return "Hitting a backhand";
        }
        public string Drop()
        {
            return "Hitting a drop";
        }

        public string Serve()
        {
            return "Serving the ball";
        }

        public string Stop()
        {
            return "Stopping...";
        }
    }
}