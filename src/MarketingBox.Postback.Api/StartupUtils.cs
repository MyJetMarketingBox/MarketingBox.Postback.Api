using Microsoft.Extensions.DependencyInjection;

namespace MarketingBox.Postback.Api
{
    public static class StartupUtils
    {
        public static void SetupSwaggerDocumentation(this IServiceCollection services)
        {
            services.AddSwaggerDocument(o =>
            {
                o.Title = "Postback API";
                o.GenerateEnumMappingDescription = true;

                // o.AddSecurity("Bearer", Enumerable.Empty<string>(),
                //     new OpenApiSecurityScheme
                //     {
                //         Type = OpenApiSecuritySchemeType.ApiKey,
                //         Description = "Bearer Token",
                //         In = OpenApiSecurityApiKeyLocation.Header,
                //         Name = "Authorization"
                //     });
            });
        }
    }
}
