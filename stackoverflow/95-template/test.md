# Azure Manual

## Patterns

[Enterprise integration using queues and events](https://docs.microsoft.com/en-us/azure/architecture/reference-architectures/enterprise-integration/queues-events)

## Datbases

1. Cosmos DB

    1.1 SQL API

    [Getting started with SQL queries](https://docs.microsoft.com/en-us/azure/cosmos-db/sql-query-getting-started)

    In Azure Cosmos DB SQL API accounts, there are two ways to read data:

    **Point reads** - You can do a key/value lookup on a single item ID and partition key. The item ID and partition key combination is the key and the item itself is the  value. For a 1 KB document, point reads typically cost 1 request unit with a latency under 10 ms. Point reads return a single item.

    **SQL queries** - You can query data by writing queries using the Structured Query Language (SQL) as a JSON query language. Queries always cost at least 2.3 request units and, in general, will have a higher and more variable latency than point reads. Queries can return many items.

    [Understanding the difference between point reads and queries in Azure Cosmos DB](https://devblogs.microsoft.com/cosmosdb/point-reads-versus-queries/)
    [Understanding the difference between null and undefined in Azure Cosmos DB](https://devblogs.microsoft.com/cosmosdb/difference-between-null-and-undefined/)
    [Understanding how to query arrays in Azure Cosmos DB](https://devblogs.microsoft.com/cosmosdb/understanding-how-to-query-arrays-in-azure-cosmos-db/)

        

## Messaging

[Choose between Azure messaging services - Event Grid, Event Hubs, and Service Bus](https://docs.microsoft.com/en-us/azure/event-grid/compare-messaging-services)


1. Azure Service Bus

   [FIFO](https://github.com/MicrosoftDocs/azure-docs/issues/60531)

   > You need to use sessions if you want FIFO guarantee. Once you have enabled the session in the queue, then all the messages that are sent using the same session are stored at the same backend store for the FIFO guarantee. Let's take an example where your single consumer is consuming the message using peek lock and your consumer application crashes. Your single consumer application was not able to call the complete, abandoned on that message before it crashes. The message will not be visible for the single client to consume it again till the lock expires. If your application recovered and start consuming the messages again but the last messages was not visible again as the lock didn't expire (min 30 sec and max 5 minutes). Then in that case your single consumer will consume the next available message in the entity and your FIFO will not be guaranteed if you are not using the same session for all the messages. There can be multiple other scenarios when you are using the partitioned entities i.e. 16 partitions (16 backend store for storing the messages). The message will be store in the round-robin fashion and if you do not specify the session then the message can be stored at any of the partition. Session guarantees you that all the messages are stored in the same partition. Hope the above clarifies why you need to use a session for FIFO guarantee. Please let me know if you have any queries or concerns.
