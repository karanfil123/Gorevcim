using Gorevcim.Core.Dtos;
using Gorevcim.Services.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using System.Text.Json;

namespace Gorevcim.Api.MiddleWare
{
    public static class UseCustomExceptionHandler
    {
        public static void UsecustomException(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(config =>
            {
                config.Run(async context =>
                {
                    context.Response.ContentType = "application/json";
                    var exceptionFuture = context.Features.Get<IExceptionHandlerFeature>();
                    var statusCode = exceptionFuture.Error switch
                    {
                        ClientSideExeption => 400,
                        NotFoundException => 404,
                        _ => 500
                    };
                    context.Response.StatusCode = statusCode;
                    var response = CustomResponseDto<NoContentDto>.Fail(statusCode, exceptionFuture.Error.Message);
                    await context.Response.WriteAsync(JsonSerializer.Serialize(response));
                });
            });
        }
    }
}
