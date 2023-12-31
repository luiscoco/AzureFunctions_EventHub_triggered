# Azure Function EventHub triggered

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/ef08dae3-a6b5-49e1-90db-e1a41ca755be)

https://github.com/luiscoco/AzureFunctions_EventHub_triggered

## 1. Create in VSCode an Azure Function EventHub triggered 

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/22c8bdae-11f3-46ca-ad24-acbec65e5c14)

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/b8ba9fd5-19c7-414a-8fc7-76ef6e7cd9b9)

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/e550fa88-d935-4586-b63b-b76e224fa2f9)

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/87c7cdd9-b944-40cb-9afe-5e3f8e53edf2)

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/e70c9bbd-ff6a-4c02-a649-ffb69fbb7827)

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/80cefb3d-0b7e-4caa-814c-c14a80ba9f40)

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/bfda8299-cd0b-4432-9c5b-a3c7590a0322)

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/4840545d-84ed-4d03-9a74-64e9b2cb953e)

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/2f57d36d-df47-44cc-87ad-194197ece7f0)

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/34ce96b5-60ee-4d74-b793-71fae2cb6537)

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/abd20d4e-9d5c-4ae8-8f59-a87804e25249)

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/be2a55a9-0a27-49fa-b525-755e531eda4d)

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/3c23424c-c80d-40af-9142-7d669d2687cb)

## 2. Create an Azure Function in Azure Portal

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/e7abd342-7241-420d-a3ab-19967fa57111)

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/72621691-e4ba-462f-8add-f65ef9b8f0da)

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/c7013d34-f6c2-4b81-bb20-eb88bc830c12)

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/b2fdaf38-eb4c-480e-9f11-da2d45706f6e)

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/0b6c7d5e-093f-4a9d-951f-c0e659bdb89c)

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/0d6a2f0a-31fb-43f9-8b79-9961c06d713b)

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/d0c38c22-3908-48c8-b723-ee3d57d2ee45)

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/5c13ee4e-adbb-428d-aad8-73a0042a59eb)

## 3. Create a configuration variable in Azure Function (Azure Portal)

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/70f873e0-8bb7-4c2e-81bc-a91c66520d15)

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/de8d1227-30e5-49e6-bf67-af387ff42932)

## 4. Stop the Azure Function in Azure Portal

We stop the Azure Function before deploying from VSCode

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/1a7b0a1f-4514-461a-927c-466d2a44834a)

## 5. Deploy the Azure Function with VSCode

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/0c14d245-b939-4e18-9a4b-a7bf175bae90)

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/8b411407-d835-4b51-9c71-0d582a08c87b)

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/200bad2a-07c6-4f68-9823-343c178ecf91)

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/05133241-5cd0-435e-a282-41dff864c961)

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/e303acac-c3e7-4803-805e-169f9ae60cf3)

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/9daca13e-2b30-4236-a3ff-085b7ccdc112)

## 6. Create the C# console application in Visual Studio 2022 for sending messages to Azure EventHub

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/1bc3ceac-73ed-474f-861f-9f453d801f7b)

```csharp
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Azure.Messaging.EventHubs;
using Azure.Messaging.EventHubs.Consumer;
using Azure.Messaging.EventHubs.Producer;

string EventHubConnectionString = "Endpoint=sb://myluiscoconamespace.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=cTO7Ut5V31JYTerHsBAtnrKkJRDkmPUz1+AEhKC1qjM=";
string EventHubName = "myluiscoconamespace-96d407f675";

await SendEventsAsync(5); // Specify the number of events you want to send

async Task SendEventsAsync(int numberOfEvents)
{
    await using (var producerClient = new EventHubProducerClient(EventHubConnectionString, EventHubName))
    {
        List<EventData> eventBatch = new List<EventData>();

        for (int i = 0; i < numberOfEvents; i++)
        {
            try
            {
                string messageBody = $"Message {i}";
                var eventData = new EventData(Encoding.UTF8.GetBytes(messageBody));
                eventBatch.Add(eventData);
                Console.WriteLine($"Event added to batch: {messageBody}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating event: {ex.Message}");
            }
        }

        try
        {
            await producerClient.SendAsync(eventBatch);
            Console.WriteLine($"Batch of events sent successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error sending batch of events: {ex.Message}");
        }
    }
}
```

## 7. Run the sending message application and monitor the output

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/7d96ebd3-1e86-405a-9298-c804bb92f983)

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/3b810226-4cfd-44f1-9aa7-8db1679042cb)

![image](https://github.com/luiscoco/AzureFunctions_EventHub_triggered/assets/32194879/eee5031a-d59e-4ed5-b976-473f5a2aae1f)
