using EPiServer.Cms.Shell;
using EPiServer.Cms.Shell.UI.Configurations;
using EPiServer.Cms.UI.AspNetIdentity;
using EPiServer.Scheduler;
using EPiServer.ServiceLocation;
using EPiServer.Web.Routing;
using nackademin24_optimizely.Business.Services;
using nackademin24_optimizely.Business.Services.Intefaces;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace nackademin24_optimizely
{
    public class Startup
    {
        private readonly IWebHostEnvironment _webHostingEnvironment;

        public Startup(IWebHostEnvironment webHostingEnvironment)
        {
            _webHostingEnvironment = webHostingEnvironment;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            if (_webHostingEnvironment.IsDevelopment())
            {
                AppDomain.CurrentDomain.SetData("DataDirectory", Path.Combine(_webHostingEnvironment.ContentRootPath, "App_Data"));

                services.Configure<SchedulerOptions>(options => options.Enabled = false);
            }

            services
                .AddCmsAspNetIdentity<ApplicationUser>()
                .AddCms()
                .AddAdminUserRegistration()
                .AddEmbeddedLocalization<Startup>();

            services.Configure<UploadOptions>(x => { x.FileSizeLimit = 5248800; });
            services.AddScoped<IDescendantService, DescendantService>();
            services.AddScoped<IXmlSitemapService, XmlSitemapService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapContent();
            });

            app.UseStatusCodePages(async context =>
            {
                if (context.HttpContext.Response.StatusCode == 404)
                {
                    context.HttpContext.Response.Redirect("/error");

                    await Task.Yield();
                }
            });
        }
    }
}
