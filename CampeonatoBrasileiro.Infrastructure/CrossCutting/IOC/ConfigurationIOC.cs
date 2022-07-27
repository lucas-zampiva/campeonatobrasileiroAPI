using Autofac;
using CampeonatoBrasileiro.Application;
using CampeonatoBrasileiro.Application.Interfaces;
using CampeonatoBrasileiro.Application.Interfaces.Mappers;
using CampeonatoBrasileiro.Application.Mappers;
using CampeonatoBrasileiro.Domain.Core.Interfaces.Repositorys;
using CampeonatoBrasileiro.Domain.Core.Interfaces.Services;
using CampeonatoBrasileiro.Domain.Entitys;
using CampeonatoBrasileiro.Domain.Services;
using CampeonatoBrasileiro.Infrastructure.Data.Repositorys;

namespace CampeonatoBrasileiro.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceJogador>().As<IApplicationServiceJogador>();
            builder.RegisterType<ApplicationServiceTime>().As<IApplicationServiceTime>();
            builder.RegisterType<ApplicationServiceTransferencia>().As<IApplicationServiceTransferencia>();
            builder.RegisterType<ApplicationServiceTorneio>().As<IApplicationServiceTorneio>();
            builder.RegisterType<ApplicationServicePartida>().As<IApplicationServicePartida>();
            builder.RegisterType<ApplicationServiceEvento>().As<IApplicationServiceEvento>();

            builder.RegisterType<ServiceJogador>().As<IServiceJogador>();
            builder.RegisterType<ServiceTime>().As<IServiceTime>();
            builder.RegisterType<ServiceTransferencia>().As<IServiceTransferencia>();
            builder.RegisterType<ServiceTorneio>().As<IServiceTorneio>();
            builder.RegisterType<ServicePartida>().As<IServicePartida>();
            builder.RegisterType<ServiceEvento>().As<IServiceEvento>();

            builder.RegisterType<RepositoryJogador>().As<IRepositoryJogador>();
            builder.RegisterType<RepositoryTime>().As<IRepositoryTime>();
            builder.RegisterType<RepositoryTransferencia>().As<IRepositoryTransferencia>();
            builder.RegisterType<RepositoryTorneio>().As<IRepositoryTorneio>();
            builder.RegisterType<RepositoryPartida>().As<IRepositoryPartida>();
            builder.RegisterType<RepositoryEvento>().As<IRepositoryEvento>();

            builder.RegisterType<MapperJogador>().As<IMapperJogador>();
            builder.RegisterType<MapperTime>().As<IMapperTime>();
            builder.RegisterType<MapperTransferencia>().As<IMapperTransferencia>();
            builder.RegisterType<MapperTorneio>().As<IMapperTorneio>();
            builder.RegisterType<MapperPartida>().As<IMapperPartida>();
            builder.RegisterType<MapperEvento>().As<IMapperEvento>();

            #endregion IOC
        }
    }
}