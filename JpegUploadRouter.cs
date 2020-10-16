using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Microsoft.WindowsAzure.Storage.Blob;

namespace Siliconvalve.Demo
{

    public static class JpegUploadRouter
    {
        [FunctionName("JpegUploadRouter")]
        [return: Queue("images", Connection = "customserverless01_QUEUE")]
        public static string Run([BlobTrigger("sampleuploads/{name}.jpg", Connection = "customserverless01_STORAGE")]ICloudBlob imageBlob, ILogger log)
        {
            log.LogInformation($"Routing image file with URI: {imageBlob.Uri}");
            return imageBlob.Uri.ToString();
        }
    }
}