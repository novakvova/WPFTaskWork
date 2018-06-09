using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleExample
{
    class Program
    {
        static void Work(int time)
        {
            Console.WriteLine("Work time {0} threadId {1}", time, 
                Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(time);
            Console.WriteLine("End Work {0} threadId {1}",time, 
                Thread.CurrentThread.ManagedThreadId);
        }
        
        static void Main(string[] args)
        {
            Action action = new Action(()=>Work(2000));
            Task task = new Task(action);
            task.Start();
            Work(3000);
            Console.WriteLine("End main Work");
            task.Wait();
            Console.WriteLine("End main");
        }
    }
}
