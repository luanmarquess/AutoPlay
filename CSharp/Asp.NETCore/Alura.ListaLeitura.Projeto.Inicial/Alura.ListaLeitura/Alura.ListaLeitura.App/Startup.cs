
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;


namespace Alura.ListaLeitura.App
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddRouting();
            services.AddMvc();

        }

        public void Configure(IApplicationBuilder app) 
        {
            // Install-Package Microsoft.AspNetCore.Mvc -Version 2.0.2
            app.UseDeveloperExceptionPage();
            app.UseMvcWithDefaultRoute();



            //var builder = new RouteBuilder(app);
            //builder.MapRoute("{classe}/{metodo}", RoteamentoPadrao.TratamentoPadrao);

            //builder.MapRoute("Livros/ParaLer", LivrosLogica.ParaLer);
            //builder.MapRoute("Livros/Lendo", LivrosLogica.Lendo);
            //builder.MapRoute("Livros/Lidos", LivrosLogica.Lidos);
            //builder.MapRoute("Livros/Detalhes/{id:int}", LivrosLogica.Detalhes);
            //builder.MapRoute("Cadastro/NovoLivro/{nome}/{autor}", CadastroLogica.NovoLivro);
            //builder.MapRoute("Cadastro/NovoLivro", CadastroLogica.ExibeFormulario);
            //builder.MapRoute("Cadastro/Incluir", CadastroLogica.Incluir);

            //var rotas = builder.Build();

            //app.UseRouter(rotas);

            //app.Run(Roteamento);
        }
       
    }
}