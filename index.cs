using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication5
{
    class Program
{
    static Clock clock = new Clock(09, 99, 69);
    static void Main(string[] args)
    {
        TIME();
        Console.ReadLine();
    }
    static void TIME()
    {
        while(true)
        {
            clock.Tick();
            Console.WriteLine(clock.displayTime());
            Thread.Sleep(867);
            Console.Clear();
        }
    }
}
class Clock
{
    private int hour;
    private int minute;
    private int second;
    public Clock(int hh, int mm, int ss)
    {
        this.hour = hh;
        this.minute = mm;
        this.second = ss;
    }
    public void Tick()
    {
        this.second++;
        if(this.second == 100)
        {
            this.minute++;
            this.second = 00;
        }
        if(this.minute == 100)
        {
            this.hour++;
            this.minute = 00;
        }
        if(this.hour == 10)
        {
            this.hour = 0;
        }
        
    }
    public string displayTime()
        {
            string time = this.hour.ToString("D2") + ":" + this.minute.ToString("D2") + ":" + this.second.ToString("D2");
            return time;
        }
}
}
