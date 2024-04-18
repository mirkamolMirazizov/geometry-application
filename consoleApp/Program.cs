using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;

var featureManagement = new Dictionary<string, string>
{
    { "FeatureManagement:Square", "true" },
    { "FeatureManagement:Rectangle", "false" },
    { "FeatureManagement:Triangle", "true" }
};

IConfigurationRoot configuration = new ConfigurationBuilder()
    .AddInMemoryCollection(featureManagement)
    .Build();

IServiceCollection services = new ServiceCollection();
services.AddFeatureManagement(configuration);
IServiceProvider serviceProvider = services.BuildServiceProvider();

var featureManager = serviceProvider.GetRequiredService<IFeatureManager>();
if (await featureManager.IsEnabledAsync("Square"))
{
}


