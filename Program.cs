﻿using System;
using System.Threading;

namespace Module_9_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new ArgumentOutOfRangeException("Сообщение об ошибке");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.Read();
            }
        }
    }
}