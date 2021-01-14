﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Serilog;
using Serilog.Events;
using System;
using System.IO;

namespace LojaVirtual
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var dataLog = DateTime.Now.ToShortDateString().Replace("/", "-");

           Log.Logger = new LoggerConfiguration()
           .MinimumLevel.Debug()
           .MinimumLevel.Override("Microsoft", LogEventLevel.Fatal)
           .Enrich.WithProperty("Usuario", 0)
           //.WriteTo.File(Directory.GetCurrentDirectory() + $"/Logs/{dataLog}-log.txt")
           .WriteTo.MySQL("Server=127.0.0.1; Port=3306; Database=loja; Username=HCTS; Password=HCTS+102030;")
           .CreateLogger();

            try
            {
                CreateWebHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Servidor encerrado inesperadamente");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>().UseSerilog();
    }
}