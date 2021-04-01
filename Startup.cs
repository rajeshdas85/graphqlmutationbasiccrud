using graphqlmutationbasiccrud.GraphQL;
using graphqlmutationbasiccrud.IService;
using graphqlmutationbasiccrud.Service;
using HotChocolate;
using HotChocolate.AspNetCore;
using HotChocolate.AspNetCore.Playground;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace graphqlmutationbasiccrud
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IGroupService, GroupService>();
            services.AddSingleton<IStudentService, StudentService>();
            services.AddGraphQL(x => SchemaBuilder.New()
            .AddServices(x)
            .AddType<GroupType>()
            .AddType<StudentType>()
            .AddQueryType<Query>()
            .AddMutationType<Mutation>()
            .Create()
            );
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UsePlayground(new PlaygroundOptions { QueryPath = "/api", Path = "/Playground" });
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseGraphQL("/api");

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
