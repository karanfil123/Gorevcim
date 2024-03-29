﻿using Autofac;
using Gorevcim.Core.Repositories;
using Gorevcim.Core.Services;
using Gorevcim.Core.UnitOfWork;
using Gorevcim.Repository.Repositories;
using Gorevcim.Repository.Repositories.UnitOfWorks;
using Gorevcim.Services.Mapping;
using Gorevcim.Services.Services;
using System.Reflection;

namespace Gorevcim.Web.Modules
{
    public class RepositoryServiceModules : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(GenericService<>)).As(typeof(IGenericService<>)).InstancePerLifetimeScope();
            builder.RegisterType<UnitOfWork>().As<IGenericUnitOfWork>();

            builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();

            builder.RegisterType<CategoryService>().As<ICategoryService>();
            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>();

            builder.RegisterType<ProductBrandRepository>().As<IProductBrandRepository>();
            builder.RegisterType<ProductBrandService>().As<IProductBrandService>();

            builder.RegisterType<ProductColorService>().As<IProductColorService>();
            builder.RegisterType<ProductColorRepository>().As<IProductColorRepository>();

            builder.RegisterType<ProductFeaturesService>().As<IProductFeaturesService>();
            builder.RegisterType<ProductFeaturesRepository>().As<IProductFeaturesRepository>();

            builder.RegisterType<ProductCurrencyService>().As<IProductCurrencyService>();
            builder.RegisterType<ProductCurrencyRepository>().As<IProductCurrencyUnitRepository>();

            builder.RegisterType<ProductMeasurementRepository>().As<IProductMeasurementUnitRepository>();
            builder.RegisterType<ProductMeasurementService>().As<IProductMeasurementUnitService>();

            builder.RegisterType<ProductVatUnitRepository>().As<IProductVatUnitRepository>();
            builder.RegisterType<ProductVatUnitService>().As<IProductVatUnitService>();

            builder.RegisterType<ProductProjectRepository>().As<IProductProjectRepository>();
            builder.RegisterType<ProductVatUnitService>().As<IProductVatUnitService>();

            builder.RegisterType<ProductWeightUnitRepository>().As<IProductWeightUnitRepository>();
            builder.RegisterType<ProductWeightUnitService>().As<IProductWeightUnitService>();

            var repository = Assembly.GetAssembly(typeof(AppContext));
            var service = Assembly.GetAssembly(typeof(MapProfiles));
            var api = Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(repository, service, api).Where(x => x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(repository, service, api).Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();
        }
    }
}
