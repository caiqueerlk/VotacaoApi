
using VotacaoApi.Repository;

namespace VotacaoApi 
{
    public class Program
    {
        public static void Main(string[] args)
        {


            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            builder.Services.AddSingleton<ICandidatoRepository, CandidatoRepository>();
            builder.Services.AddSingleton<IVotoRepository, VotoRepository>();

            var app = builder.Build();

            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}