﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exercise 1: Design a StopwatchDesign a class called Stopwatch.The job of this class is to simulate a stopwatch.It should provide two methods: Start and Stop.
//We call the start method first, and the stop method next.Then we ask the stopwatch about the duration between start and stop. Duration should be a value 
//in TimeSpan.Display the duration on the console. We should also be able to use a stopwatch multiple times.So we may start and stop it and then start and 
//stop it again. Make sure the duration value each time is calculated properly. We should not be able to start a stopwatch twice in a row (because that may 
//overwrite the initial start time). So the class should throw an InvalidOperationException if its started twice.

//Educational tip: The aim of this exercise is to make you understand that a class should be always in a valid state.We use encapsulation and information 
//hiding to achieve that.The class should not reveal its implementation detail.It only reveals a little bit, like a blackbox.From the outside, you should 
//not be able to misuse a class because you shouldn’t be able to see the implementation detail.

    namespace CSharpIntermediate
{
    class Stopwatch
    {
        DateTime _startTime;
        DateTime _endTime;
        TimeSpan _timeElapsed;

        public Stopwatch()
        {
            _startTime = DateTime.MinValue;
            _endTime = DateTime.MinValue;
            _timeElapsed = TimeSpan.MinValue;
        }

        public void Start()
        {
            Console.WriteLine("Press Enter to start the stopwatch...");
            Console.ReadLine();
            _startTime = DateTime.Now;
            Console.WriteLine("Stopwatch started.");
            Console.WriteLine();   
        }

        public void Stop()
        {
            Console.WriteLine("Press Enter to stop the stopwatch...");
            Console.ReadLine();
            _endTime = DateTime.Now;
            Console.WriteLine("Stopwatch stopped.");
            Console.WriteLine();

            _timeElapsed = _endTime - _startTime;

            Console.WriteLine("Time Elapsed: " + _timeElapsed);
        }
    }
}