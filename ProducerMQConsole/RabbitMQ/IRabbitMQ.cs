using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerMQConsole.RabbitMQ
{
    public interface IRabbitMQ
    {
        public void SendMessage(string message);
        public void SendMessage(object obj);
    }
}
