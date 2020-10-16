using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Microsoft.WindowsAzure.Storage.Blob;

namespace Siliconvalve.Demo
{
    public static class VideoFileRouter
    {
        [FunctionName("VideoFileRouter")]
        [return: Queue("movies", Connection = "customserverless01_QUEUE")]
        public static string Run([BlobTrigger("sampleuploads/{name}.mp4", Connection = "customserverless01_STORAGE")]ICloudBlob movieBlob, ILogger log)
        {
            log.LogInformation($"Routing movie file with URI: {movieBlob.Uri}");
            return movieBlob.Uri.ToString();
        }
    }
}
