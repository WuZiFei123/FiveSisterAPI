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
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<IBLLClothesBrand,ClothesBrandBLL>();
            services.AddTransient<IBLLClothesType, ClothesTypeBLL>();
            services.AddTransient<IBLLGoodsInfo, GoodsInfoBLL>();
            services.AddTransient<IBLLGoodsCarInfo, GoodsCarInfoBLL>();
            services.AddTransient<IBLLActibityInfo, ActibityInfoBLL>();
            services.AddTransient<IBLLKillInfo, KillInfoBLL>();
            services.AddTransient<IBLLShopInfo, ShopInfoBLL>();
            services.AddTransient<IBLLPosstionInfo, PosstionInfoBLL>();
            services.AddTransient<IBLLGoodsAddInfo, GoodsAddInfoBLL>();
            //跨域配置
            services.AddTransient<IBLLSizeInfo, SizeInfoBLL>();
            services.AddTransient<IBLLAddressInfo,AddressInfoBLL>();
            //���ÿ����������������Դ��
            services.AddCors(options =>
            options.AddPolicy("kkk",
            p => p.AllowAnyOrigin())
            );
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors("kkk");
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
