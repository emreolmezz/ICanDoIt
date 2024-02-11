using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICanDoIt.Client.Extensions
{
    public static class EndPointsExtensions
    {
        public static IApplicationBuilder AddEndPoints(this IApplicationBuilder app)
        {
            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllerRoute(
                    name: "checkout",
                    pattern: "checkout",
                    defaults: new { controller = "Cart", action = "Checkout" }
                );
                endpoints.MapControllerRoute(
                    name: "cart",
                    pattern: "cart",
                    defaults: new { controller = "Cart", action = "Index" }
                );
                endpoints.MapControllerRoute(
                    name: "search",
                    pattern: "search",
                    defaults: new { controller = "Shop", action = "Search" }
                );
                endpoints.MapControllerRoute(
                    name: "products",
                    pattern: "products/{category?}",
                    defaults: new { controller = "Shop", action = "list" }
                );
                endpoints.MapControllerRoute(
                    name: "productsdetails",
                    pattern: "{url}",
                    defaults: new { controller = "Shop", action = "Details" }
                );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            });
            return app;
        }
    }
}
