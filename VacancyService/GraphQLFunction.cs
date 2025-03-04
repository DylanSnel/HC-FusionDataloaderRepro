using HotChocolate.AzureFunctions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using System.Threading.Tasks;

namespace VacancyService;

public static class GraphQLFunction
{
    public const string GraphQLFunctionName = "GraphQLHttpFunction";

    [AllowAnonymous]
    [FunctionName(GraphQLFunctionName)]
    public static Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "graphql/{**slug}")]
        HttpRequest request,
        [GraphQL] IGraphQLRequestExecutor executor)
        => executor.ExecuteAsync(request);
}
