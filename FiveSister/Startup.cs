using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using IBLL;
using BLL;

namespace FiveSister
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
            services.AddControllers();
            services.AddTransient<IBLLClothesBrand,ClothesBrandBLL>();
            services.AddTransient<IBLLClothesType, ClothesTypeBLL>();
            services.AddTransient<IBLLGoodsInfo, GoodsInfoBLL>();
            services.AddTransient<IBLLGoodsCarInfo, GoodsCarInfoBLL>();
            services.AddTransient<IBLLUserInfo, GoodsUserInfoBLL>();
            
            //配置跨域处理，允许所有来源：
            services.AddCors(options =>
            options.AddPolicy("kkk",
            p => p.AllowAnyOrigin())
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors("kkk");//必须位于UserMvc之前 
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
