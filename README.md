# Azure Function - Simple Media Router Demo

This Function App contains two Functions which are used to detect new Blobs in a Blob Storage Account and then place the new Blob's URI onto a Storage Account Queue for upstream processing.

Note: using Azure Event Grid would likely make more sense, but is not the intent of this demo code!

There are two settings you can set for this Function App:

- customserverless01_STORAGE: the storage account connection which is used to monitor for new blobs.
- customserverless01_QUEUE: the storage account connection which is used to publish new queue messages.