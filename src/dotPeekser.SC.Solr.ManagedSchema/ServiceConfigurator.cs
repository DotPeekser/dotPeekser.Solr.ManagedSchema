﻿namespace dotPeekser.SC.Solr.ManagedSchema
{
    using dotPeekser.SC.Solr.ManagedSchema.Factories;
    using dotPeekser.SC.Solr.ManagedSchema.Interfaces;
    using dotPeekser.SC.Solr.ManagedSchema.Logging;
    using Microsoft.Extensions.DependencyInjection;
    using Sitecore.DependencyInjection;

    public class ServiceConfigurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IXmlReaderFactory, ScXmlReaderFactory>();
            serviceCollection.AddSingleton<IManagedSchemaLogger, ScLogger>();
        }
    }
}
