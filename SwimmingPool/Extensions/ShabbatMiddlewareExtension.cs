using Swim.API.Middlewares;

namespace Swim.API.Extensions
{
    public static class ShabbatMiddlewareExtension
    {
        public static IApplicationBuilder UseShabbat(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ShabbatMiddleware>();
        }
    }
}
