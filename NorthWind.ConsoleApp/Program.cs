using NorthWind.ConsoleApp.Services;
using NorthWind2.Entities.Interfaces;

IUserActionWriter Writer = default;

AppLogger Logger = new AppLogger(Writer);
Logger.WriteLog("Application started");
