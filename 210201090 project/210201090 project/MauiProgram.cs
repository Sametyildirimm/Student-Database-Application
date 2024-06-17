using Microsoft.Extensions.Logging;

namespace _210201090_project
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });


            string _dbPath = Path.Combine(FileSystem.AppDataDirectory, "Student.db");
            builder.Services.AddSingleton(s => ActivatorUtilities.CreateInstance<DBTrans>(s, _dbPath));

            string dbpath = Path.Combine(FileSystem.AppDataDirectory, "Course.db");
            builder.Services.AddSingleton(s => ActivatorUtilities.CreateInstance<DBTrans2>(s, dbpath));



#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
