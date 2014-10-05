using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Conventions.Helpers;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using T4FluentNH.Conventions;

namespace T4FluentNH.Tests
{
    public class AutomappingConfiguration : DefaultAutomappingConfiguration
    {
        public override bool ShouldMap(Type type)
        {
            return base.ShouldMap(type) && typeof(Entity).IsAssignableFrom(type);
        }
    }

    public static class NHConfig
    {
        private static readonly ISessionFactory SessionFactory;

        static NHConfig()
        {
            var modelAssembly = typeof(NHConfig).Assembly;
            var configuration = new Configuration();
            configuration.Configure();  //configure from the web.config
            var fluentConfig = Fluently.Configure(configuration);
            var autoPestModel = AutoMap
                .Assemblies(new AutomappingConfiguration(), new[] { modelAssembly })
                .UseOverridesFromAssembly(modelAssembly)
                .IgnoreBase<Entity>()
                .Conventions.AddFromAssemblyOf<ReadOnlyAttributeConvention>()
                .Conventions.Add(PrimaryKey.Name.Is(o => "Id"))
                .Conventions.Add(ForeignKey.EndsWith("Id"));
            fluentConfig
                .Mappings(m =>
                {
                    m.HbmMappings.AddFromAssembly(modelAssembly);
                    m.AutoMappings.Add(autoPestModel);
                    var mappingsDirecotry = Path.Combine(Directory.GetCurrentDirectory(), "Mappings");
                    if (!Directory.Exists(mappingsDirecotry))
                        Directory.CreateDirectory(mappingsDirecotry);
                    m.AutoMappings.ExportTo(mappingsDirecotry);
                    m.FluentMappings.ExportTo(mappingsDirecotry);
                });
            
            SessionFactory = fluentConfig.BuildSessionFactory();
            var schema = new SchemaExport(configuration);
            schema.Drop(false, true);
            schema.Create(false, true);
        }

        public static ISession OpenSession()
        {
            ISession session = SessionFactory.OpenSession();
            return session;
        }
    }
}
