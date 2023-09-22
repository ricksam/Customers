using Azure;
using Azure.Storage;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Sas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RckSoftwareMVC.Helpers
{
    public class AzureHelper
    {
        public AzureHelper()
        {
            this.blobServiceClient = new BlobServiceClient(connectionString);
        }

        const string connectionString = "DefaultEndpointsProtocol=https;AccountName=rcksoftware;AccountKey=ETfZ8bwN8TL83E2rpPCJ5ZI1YO5516lEPcnk4NW3E6hxpByUk9nU2vAZNmRdpS8/afQzFSgh7Qw28RAQWg9HHw==;EndpointSuffix=core.windows.net";

        const string AccountName = "rcksoftware";
        const string AccountKey = "ETfZ8bwN8TL83E2rpPCJ5ZI1YO5516lEPcnk4NW3E6hxpByUk9nU2vAZNmRdpS8/afQzFSgh7Qw28RAQWg9HHw==";

        private BlobServiceClient blobServiceClient { get; set; }

        public async Task<BlobContainerClient> GetContainer(string containerName = "")
        {
            BlobContainerClient blobContainerClient = blobServiceClient.GetBlobContainerClient(containerName);

            if (!blobContainerClient.Exists())
            {
                blobContainerClient = await blobServiceClient.CreateBlobContainerAsync(containerName);
            }

            return blobContainerClient;
        }

        public string GetSharePermission(string BlobContainerName, string BlobName)
        {
            TimeSpan clockSkew = TimeSpan.FromMinutes(15d);
            TimeSpan accessDuration = TimeSpan.FromMinutes(15d);

            var blobSasBuilder = new BlobSasBuilder
            {
                StartsOn = DateTime.UtcNow.Subtract(clockSkew),
                ExpiresOn = DateTime.UtcNow.Add(accessDuration) + clockSkew,
                BlobContainerName = BlobContainerName,
                BlobName = BlobName,
            };
            blobSasBuilder.SetPermissions(BlobSasPermissions.Read);
            var storageSharedKeyCredential = new StorageSharedKeyCredential(AccountName, AccountKey);
            BlobSasQueryParameters sasQueryParameters = blobSasBuilder.ToSasQueryParameters(storageSharedKeyCredential);
            return "?" + sasQueryParameters.ToString();
        }

        public string UrlBlobFile(string BlobContainerName, string BlobName)
        {
            string sasQueryParameters = GetSharePermission(BlobContainerName, BlobName);
            return string.Format("https://{0}.blob.core.windows.net/{1}/{2}", AccountName, BlobContainerName, BlobName) + sasQueryParameters;
        }

        public async Task<string> Upload(string containerName, string fileName, bool isStatic, Stream stream)
        {
            BlobContainerClient blobContainerClient = await GetContainer(containerName);
            string definitiveFileName = isStatic ? fileName : "f" + Guid.NewGuid().ToString() + Path.GetExtension(fileName);
            BlobClient blobClient = blobContainerClient.GetBlobClient(definitiveFileName);
            Response<BlobContentInfo> res = await blobClient.UploadAsync(stream, true);
            stream.Close();
            return definitiveFileName;
        }

        public async Task<bool> Exists(string containerName, string fileName)
        {
            BlobContainerClient blobContainerClient = await GetContainer(containerName);
            BlobClient blobClient = blobContainerClient.GetBlobClient(fileName);
            return blobClient.Exists();
        }

        public async Task<bool> Delete(string containerName, string fileName)
        {
            BlobContainerClient blobContainerClient = await GetContainer(containerName);
            BlobClient blobClient = blobContainerClient.GetBlobClient(fileName);
            return await blobClient.DeleteIfExistsAsync();
        }

        public async Task<Stream> Download(string containerName, string fileName)
        {
            try
            {
                if (await Exists(containerName, fileName))
                {
                    BlobContainerClient blobContainerClient = await GetContainer(containerName);
                    BlobClient blobClient = blobContainerClient.GetBlobClient(fileName);
                    BlobDownloadInfo download = await blobClient.DownloadAsync();
                    return download.Content;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        /*public async Task<List<string>> List(string containerName)
        {
            List<string> list = new List<string>();
            BlobContainerClient blobContainerClient = await GetContainer(containerName);
            AsyncPageable<BlobItem> blobItems = await blobContainerClient.GetBlobsAsync();
            foreach (var blobItem in blobItems)
            {
                list.Add(blobItem.Name);
            }
            return list;
        }*/
    }
}
