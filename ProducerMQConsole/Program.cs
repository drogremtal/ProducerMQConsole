// See https://aka.ms/new-console-template for more information


using ProducerMQConsole.RabbitMQ;

IRabbitMQ rabbitMQ = new RabbitMQService();

for (int i = 0; i < 100; i++)
{
    rabbitMQ.SendMessage($"sdasda {i}");
}



Console.WriteLine("Hello, World!");
Console.ReadLine();

                                         