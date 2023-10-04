﻿using System.IO;
using System.Windows;
using DesktopApp.View;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using University.Dal.UnitOfWork;
using University.DAL;
using University.DAL.Extensions;
using University.DAL.Models;
using University.DAL.Repositories;
using University.DAL.UnitOfWork;

namespace DesktopApp
{
    public partial class App : Application
    {
        IHost host = Host.CreateDefaultBuilder()
        .ConfigureAppConfiguration(app =>
        {
            app.SetBasePath(Directory.GetCurrentDirectory());
            app.AddJsonFile("appsettings.json");
        })
        .ConfigureServices((context, services) =>
        {
            IConfiguration configuration = context.Configuration;
            services.AddDbContext<UniversityContext>(o => o.UseSqlServer(configuration.GetConnectionString("UniversityDatabase")));
            services.AddDataDependencies();
            services.AddSingleton<MainWindow>();
        })
        .Build();
    }
}
