using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using productos.Models;
using Microsoft.Extensions.Configuration; //extension que se utiliza con IConfigurationRoot
using Microsoft.EntityFrameworkCore;

namespace productos
{
        public class Startup
        {
            //propiedad para administrar la conexion con el DBMS
            private IConfigurationRoot _configurationRoot;
            //agregacion del metodo constructor de la clase StartUp para instacia de la conexion
            public Startup(IHostingEnvironment hostingEnvironment)
            {
                _configurationRoot = new ConfigurationBuilder()
                    .SetBasePath(hostingEnvironment.ContentRootPath)
                    .AddJsonFile("appsettings.json")
                    .Build();

            }
            public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection")));
            //Registrando las clases mock
            //services.AddTransient<ICategoriasRepositorio, MockCategoriasRepositorio>();
            //services.AddTransient<IProductosRepositorio, MockProductosRepositorio>();
            //Registrando las clase repositorio
            services.AddTransient<ICategoriasRepositorio, CategoriaRepositorio>();
            services.AddTransient<IProductosRepositorio, ProductosRepositorio>();
           

            //Agrega soporte MVC al proyecto
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
            app.UseDeveloperExceptionPage();
            DataInicio.AgregarData(app);
        }
    }
}
