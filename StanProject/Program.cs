using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using NLog.Web;
using System;
using System.Text;

namespace StanProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureLogging(loggingBuilder =>
                    {
                        loggingBuilder.AddNLog("NLog.config");//需要配置文件
                    })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    //webBuilder.UseNLog();
                    webBuilder.UseStartup<Startup>();
                });
    }
}
