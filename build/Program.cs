using Cake.Frosting;

namespace Build
{
    public class Program : IFrostingStartup
    {
        public static int Main(string[] args)
        {
            var host = new CakeHostBuilder()
                .WithArguments(args)
                .UseStartup<Program>()
                .Build();

            return host.Run();
        }

        public void Configure(ICakeServices services)
        {
            services.UseContext<BuildContext>();
            services.UseLifetime<Lifetime>();
            services.UseWorkingDirectory("..");
        }
    }
}