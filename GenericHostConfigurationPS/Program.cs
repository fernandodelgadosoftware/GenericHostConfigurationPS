using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace GenericHostConfigurationPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            configurationBuilder
                //.SetBasePath(FileDirectory)
                .AddJsonFile("config.json");

            IConfigurationRoot configuration = configurationBuilder.Build();

            Console.WriteLine($"Processing: {args[0]}");
            Console.WriteLine($"Thumbnail Width: {configuration["thumbnailWidth"]}");

        }
    }
}
