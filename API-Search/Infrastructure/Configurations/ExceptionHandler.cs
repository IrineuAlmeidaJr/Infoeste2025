using System.Net;
using System.Text.Json;
using Domain.Exception;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Configurations;

public class ExceptionHandler
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ExceptionHandler> _logger;

    public ExceptionHandler(RequestDelegate next, ILogger<ExceptionHandler> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (DomainException ex)
        {
            await HandleExceptionAsync(context, ex);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(context, ex);
        }
    }

    private Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        _logger.LogError(exception, "Unhandled exception caught by ExceptionHandler");

        var statusCode = HttpStatusCode.InternalServerError;
        var problemDetails = new ProblemDetails
        {
            Status = (int)statusCode,
            Title = "Ocorreu um erro inesperado!",
            Detail = "Não foi possível processar sua requisição no momento. Por favor, tente novamente ou contate o suporte.",
            Instance = context.Request.Path
        };

        context.Response.ContentType = "application/problem+json";
        context.Response.StatusCode = (int)statusCode;
        var result = JsonSerializer.Serialize(problemDetails);
        return context.Response.WriteAsync(result);
    }

    private Task HandleExceptionAsync(HttpContext context, DomainException exception)
    {
        _logger.LogError(exception, "Domain exception caught by ExceptionHandler");

        var statusCode = exception.StatusCode;
        var problemDetails = new ProblemDetails
        {
            Status = (int)statusCode,
            Title = exception.Title,
            Detail = exception.Description,
            Instance = context.Request.Path
        };

        context.Response.ContentType = "application/problem+json";
        context.Response.StatusCode = (int)statusCode;
        var result = JsonSerializer.Serialize(problemDetails);
        return context.Response.WriteAsync(result);
    }
}
