﻿using System;
using System.Threading;

namespace CalculateMaxThread
{
    class Program
    {
        static void Main(string[] args)
        {
            int threadCount = 0;
            try
            {
                for (int i = 0; i < int.MaxValue; i ++)
                {
                    new Thread(() => Thread.Sleep(Timeout.Infinite)).Start();
                    threadCount ++;
                    if ( i % 10 == 0)
                    {
                        Console.WriteLine(threadCount);        
                    }
                    
                }
            }
            catch
            {
                
                Console.ReadKey(true);
            }
        }
    }
}
