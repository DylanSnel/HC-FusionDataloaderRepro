var builder = DistributedApplication.CreateBuilder(args);

var publication = builder.AddAzureFunctionsProject<Projects.PublicationService>("publicationservice");
var vacancy = builder.AddAzureFunctionsProject<Projects.VacancyService>("vacancyservice");

var aspVacancy = builder.AddProject<Projects.VacancyServiceAsp>("vacancyserviceasp");
var gateway = builder.AddFusionGateway<Projects.Gateway>("apiservice")
                       // .WithSubgraph(publication)
                       .WithSubgraph(aspVacancy);





builder.Build().Run();
