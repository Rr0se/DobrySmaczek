using AutoMapper.Configuration;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Services.AppSettingsService
{
    public class AppSettingsService
    {
        private readonly AutoMapper.Configuration.IConfiguration _config;
        public static IConfigurationRoot Configuration { get; set; }

        public AppSettingsService(AutoMapper.Configuration.IConfiguration config)
        {
            _config = config;
        }

        public static string Secret => Configuration["AppSettings:Authentication:Secret"];
        public static string IssuserName => Configuration["AppSettings:Authentication:IssuserName"];
        public static string AudienceName => Configuration["AppSettings:Authentication:AudienceName"];
        public static string ExpiredSecondTime => Configuration["AppSettings:Authentication:ExpiredSecondTime"];

        public static string CipherKey => Configuration["AppSettings:CipherKey"];

        public static string Email => Configuration["AppSettings:EmailSettings:Email"];
        public static string Password => Configuration["AppSettings:EmailSettings:Password"];
        public static string Smtp => Configuration["AppSettings:EmailSettings:Smtp"];
        public static string Port => Configuration["AppSettings:EmailSettings:Port"];
        public static string UrlSendEmail => Configuration["AppSettings:EmailSettings:UrlSendEmail"];

        public static string FilePath => Configuration["AppSettings:FilePath"];
        public static string FilePathTemplolary => Configuration["AppSettings:FilePathTemplolary"];

        public static string FileNameTempolary => Configuration["AppSettings:FileNameTempolary"];
        public static string FileType => Configuration["AppSettings:FileType"];
        public static string FileExtension => Configuration["AppSettings:FileExtension"];
        public static string ScannerRunPath => Configuration["AppSettings:ScannerRunPath"];
        public static string MaxCorrespondenceGroup => Configuration["AppSettings:MaxCorrespondenceGroup"];


        public static int MapLocationLifetime => int.Parse(Configuration["AppSettings:MapLocationLifetime"]);
        public static int PokeLifetime => int.Parse(Configuration["AppSettings:PokeLifetime"]);
        public static int NewsLifetime => int.Parse(Configuration["AppSettings:NewsLifetime"]);
        public static double NewsNearbyRadius => double.Parse(Configuration["AppSettings:NewsNearbyRadius"]);
        public static int UserActivityLifetime => int.Parse(Configuration["AppSettings:UserActivityLifetime"]);




    
}
}
