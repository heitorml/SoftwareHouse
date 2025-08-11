var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.SoftwareHouse_Customers>("softwarehouse-customers");

builder.AddProject<Projects.SoftwareHouse_Notification>("softwarehouse-notification");

builder.AddProject<Projects.SoftwareHouse_Budget>("softwarehouse-budget");

builder.AddProject<Projects.SoftwareHouse_Projects>("softwarehouse-projects");

builder.Build().Run();
