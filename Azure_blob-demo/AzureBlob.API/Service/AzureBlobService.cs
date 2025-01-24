using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs.Specialized;
using AzureBlob.API.Models;
using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace AzureBlob.API.Service
{
	public class AzureBlobService
	{
        private const string BasePath = "";
        BlobServiceClient _blobClient;
		BlobContainerClient _containerClient;
        public AzureBlobService(IConfiguration configuration)
        {
            var azureConnectionString = configuration["AzureBlobStorage:ConnectionString"];
            var containerName = configuration["AzureBlobStorage:ContainerName"];
            _blobClient = new BlobServiceClient(azureConnectionString);
            _containerClient = _blobClient.GetBlobContainerClient(containerName);
        }

        //public async Task<List<Azure.Response<BlobContentInfo>>> UploadFiles(List<IFormFile> files)
        //{

        //	var azureResponse = new List<Azure.Response<BlobContentInfo>>();
        //	foreach(var file in files)
        //	{
        //		string fileName = file.FileName;
        //		using (var memoryStream = new MemoryStream())
        //		{
        //			file.CopyTo(memoryStream);
        //			memoryStream.Position = 0;
        //			var client = await _containerClient.UploadBlobAsync(fileName, memoryStream, default);
        //			azureResponse.Add(client);
        //		}
        //	};

        //	return azureResponse;
        //}

        private string GenerateFilePath(string tenantId, string moduleName, string entityId, string fileNameGuid)
        {
            return $"{BasePath}/{tenantId}/{moduleName}/{entityId}/{fileNameGuid}";
        }

        public async Task<List<Azure.Response<BlobContentInfo>>> UploadFiles(List<IFormFile> files, string tenantId, string moduleName, string entityId, string fileNameGuid)
        {
            var responses = new List<Azure.Response<BlobContentInfo>>();

            foreach (var file in files)
            {
               
                var filePath = GenerateFilePath(tenantId, moduleName, entityId, fileNameGuid);
                var blobClient = _containerClient.GetBlobClient(filePath);
                using (var stream = file.OpenReadStream())
                {
                    var response = await blobClient.UploadAsync(stream, true);
                    responses.Add(response);
                }
            }

            return responses;
        }

        public async Task<List<BlobItem>> GetUploadedBlobs()
		{
			var items = new List<BlobItem>();
			var uploadedFiles = _containerClient.GetBlobsAsync();
			await foreach (BlobItem file in uploadedFiles)
			{
				items.Add(file);
			}

			return items;
		}

        public async Task<Stream> DownloadFile(string tenantId, string moduleName, string entityId, string fileNameGuid)
        {
            var filePath = GenerateFilePath(tenantId, moduleName, entityId, fileNameGuid);
            var blobClient = _containerClient.GetBlobClient(filePath);
            var response = await blobClient.DownloadAsync();
            return response.Value.Content;
        }

        public async Task<BlobProperties> GetFileDetails(string tenantId, string moduleName, string entityId, string fileNameGuid)
        {
            var filePath = GenerateFilePath(tenantId, moduleName, entityId, fileNameGuid);
            var blobClient = _containerClient.GetBlobClient(filePath);
            var properties = await blobClient.GetPropertiesAsync();
            return properties.Value;
        }


        public async Task<List<Stream>> DownloadFiles(List<string> filePaths)
        {
            var streams = new List<Stream>();

            foreach (var filePath in filePaths)
            {
                var blobClient = _containerClient.GetBlobClient(filePath);
                var response = await blobClient.DownloadAsync();
                streams.Add(response.Value.Content);
            }

            return streams;
        }
    }
}
