﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace DBOPerator.Schedule
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            var build = new HostBuilder()
                 .ConfigureServices((hostContext, services) =>
                 {
                     services.AddHostedService(p => new MinuteTimerHostExecutor(ConfigHelper.MinuteTimerSleepMinute));
                     ////services.AddHostedService(p => new DayTimerHostExecutor(ConfigHelper.DayTimerSleepMinute));
                 });

            await build.RunConsoleAsync();
            Console.WriteLine("Hello World!");
        }
    }
}
