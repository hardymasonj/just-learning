// See https://aka.ms/new-console-template for more information
using HS.Learning.DIConsole.Configuration;
using HS.Learning.DILibrary.Models;
using HS.Learning.DILibrary.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

Console.WriteLine("Hello, World!");

IHost host = Host.CreateDefaultBuilder().ConfigureServices(
    (_, services) => services.AddScoped<IUrlStore, UrlStoreModel>()
                                            .AddScoped<IAPIWrapper, APIWrapper>()
    ).Build();
var apiWrapper = host.Services.GetService<IAPIWrapper>();
Console.WriteLine(apiWrapper.CalendarAPI);