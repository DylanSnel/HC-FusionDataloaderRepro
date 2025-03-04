[assembly: FunctionsStartup(typeof(Startup))]
namespace PublicationService;

public class Startup : FunctionsStartup
{

    public override void Configure(IFunctionsHostBuilder builder)
    {
        var context = builder.GetContext();
        builder.AddGraphQLFunction(b => b.AddQueryType<Query>());


    }
}
