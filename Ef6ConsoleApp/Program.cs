// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using Ef6ConsoleApp;
using Ef6ConsoleApp.DbContexts;
using Microsoft.EntityFrameworkCore;




Console.WriteLine(Environment.GetEnvironmentVariable("DATABASE_CONNECTION_STRING"));
var dbCtx = new CityInfoContext();

var cities = dbCtx.Cities.Find(1);
Console.WriteLine(cities.Name);