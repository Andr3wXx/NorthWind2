using Microsoft.Extensions.Hosting;
using NorthWind.ConsoleApp.Services;
using NorthWind.Writers;
using NorthWind2.Entities.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;
using System.Windows.Markup;

//Contruccion del Host

HostApplicationBuilder  Builder = Host.CreateApplicationBuilder();

Builder.Services.AddNorthWindService();

using IHost AppHost = Builder.Build(); //El host de la aplicacion



//IUserActionWriter Writer = new FileWriter();
//IUserActionWriter Writer = new ConsoleWriter();
//IUserActionWriter Writer = new DebugWriter();

IAppLogger Logger = AppHost.Services.GetRequiredService<IAppLogger>();
Logger.WriteLog("Application started.");

IProductService Service = AppHost.Services.GetRequiredService<IProductService>();
Service.Add("Demo", "Azucar refinada");

/*
 * AppLoger y los Writers: Responsabilidad unica
 * AppLoger: Abierto pero cerrado
 * AppLogger: Inversion de dependencias. los modulos de al alto nivel son independientes de los detalles de implementacion
 */