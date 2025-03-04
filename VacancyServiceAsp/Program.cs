var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

builder.AddGraphQL().AddTypes();

var app = builder.Build();

app.MapDefaultEndpoints();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);
