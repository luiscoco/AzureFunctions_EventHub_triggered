using System;
using System.Text;
using Azure.Messaging.EventHubs;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public class EventHubTrigger1
    {
        private readonly ILogger<EventHubTrigger1> _logger;

        public EventHubTrigger1(ILogger<EventHubTrigger1> logger)
        {
            _logger = logger;
        }

        [Function(nameof(EventHubTrigger1))]
        public void Run([EventHubTrigger("myluiscoconamespace-96d407f675", Connection = "myluiscoconamespace_RootManageSharedAccessKey_EVENTHUB")] EventData[] events)
        {
            foreach (EventData eventname in events)
            {
                // Convert ReadOnlyMemory<byte> to byte[]
                byte[] eventDataBytes = eventname.Body.ToArray();

                // Assuming UTF-8 encoding, you can change it based on your actual encoding
                Encoding utf8Encoding = Encoding.UTF8;

                // Convert byte[] to string
                string eventDataString = utf8Encoding.GetString(eventDataBytes);

                _logger.LogInformation("Event Body: {body}", eventDataString);
                _logger.LogInformation("Event Content-Type: {contentType}", eventname.ContentType);
            }
        }
    }
}
