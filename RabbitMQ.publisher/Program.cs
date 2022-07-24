using RabbitMQ.Client;
using System;

namespace RabbitMQ.publisher
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory();
            factory.Uri = new Uri("amqps://gbcsgwch:bA7BS6rPwZZBhem5qzkWwBL-MWmGem6c@chimpanzee.rmq.cloudamqp.com/gbcsgwch");

            using var connection = factory.CreateConnection();
            var channel = connection.CreateModel();

            //kuyruğu publisher'a oluşturmak istemiyoruz. 'Fanout Exchange'
           // channel.QueueDeclare("hello", true, false, false);
        }
    }
}
