﻿/// <summary>
/// Problem 7. Timer
/// Using delegates write a class Timer that can execute certain method at each t seconds.
/// </summary>
/// 

namespace Timer
{
    using System;
    using System.Threading;

    public delegate void RepeatDelegate(int t);

    class Timer
    {
        static void Main()
        {
            RepeatDelegate t = delegate(int time)
            {
                while (true)
                {
                    Thread.Sleep(time);
                    Console.WriteLine("{0}", DateTime.Now);
                }
            };

            t(1000);
        }
    }
}