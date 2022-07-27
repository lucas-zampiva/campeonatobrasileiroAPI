using CampeonatoBrasileiro.Domain.Core.Interfaces.Repositorys;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace CampeonatoBrasileiro.Infrastructure.Data.Repositorys
{
    public class RepositoryEventoBase<TEntity> : IRepositoryEventoBase<TEntity> where TEntity : class
    {
        private readonly MySqlContext mySqlContext;
        private readonly ConnectionFactory _factory;
        private const string QUEUE_NAME = "eventos";

        public RepositoryEventoBase(MySqlContext mySqlContext)
        {
            this.mySqlContext = mySqlContext;
            _factory = new ConnectionFactory
            {
                HostName = "localhost"
            };
        }

        public void Add(TEntity obj)
        {
            try
            {
                mySqlContext.Set<TEntity>().Add(obj);
                mySqlContext.SaveChanges();

                using (var connection = _factory.CreateConnection())
                {
                    using (var channel = connection.CreateModel())
                    {
                        channel.QueueDeclare(
                            queue: QUEUE_NAME,
                            durable: false,
                            exclusive: false,
                            autoDelete: false,
                            arguments: null
                            );

                        var stringfiedMessage = JsonConvert.SerializeObject(obj);
                        var bytesMessage = Encoding.UTF8.GetBytes(stringfiedMessage);

                        channel.BasicPublish(
                            exchange: "",
                            routingKey: QUEUE_NAME,
                            basicProperties: null,
                            body: bytesMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}