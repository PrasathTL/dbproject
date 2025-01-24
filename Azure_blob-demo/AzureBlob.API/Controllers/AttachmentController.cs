using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureBlob.API.Models;
using AzureBlob.API.Service;
using Microsoft.AspNetCore.Mvc;

namespace AzureBlob.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AttachmentController : ControllerBase
	{
		AzureBlobService _service;
		public AttachmentController(AzureBlobService service)
		{
			_service = service;
		}

        ///DocumentLibrary/{TenantID}/{ModuleName}/{EntityID}/{FileNameGUID}


        [HttpPost("UploadMultipleFiles/{tenantId}/{moduleName}/{entityId}")]
        public async Task<IActionResult> UploadFiles(string tenantId, string moduleName, string entityId, string fileNameGuid, List<IFormFile> files)
        {
            var response = await _service.UploadFiles(files, tenantId, moduleName, entityId, fileNameGuid);
            return Ok(response);
        }

        [HttpGet("GetAllFilesProperties")]

        public async Task<IActionResult> GetAllFiles()
		{
			var response = await _service.GetUploadedBlobs();
			return Ok(response);
		}


        [HttpGet("DownloadFile/{tenantId}/{moduleName}/{entityId}/{fileNameGuid}")]
        public async Task<IActionResult> DownloadFile(string tenantId, string moduleName, string entityId, string fileNameGuid)
        {
            var stream = await _service.DownloadFile(tenantId, moduleName, entityId, fileNameGuid);
            return File(stream, "application/octet-stream", fileNameGuid);
        }

        [HttpGet("getFileDetailsbyID/{tenantId}/{moduleName}/{entityId}/{fileNameGuid}")]
        public async Task<IActionResult> GetFileDetailsByID(string tenantId, string moduleName, string entityId, string fileNameGuid)
        {
            var properties = await _service.GetFileDetails(tenantId, moduleName, entityId, fileNameGuid);
            return Ok(properties);
        }

        [HttpPost("downloadallfiles")]
        public async Task<IActionResult> DownloadFiles([FromBody] List<string> filePaths)
        {
            if (filePaths == null || !filePaths.Any())
            {
                return BadRequest("No file paths provided.");
            }

            var streams = await _service.DownloadFiles(filePaths);
            byte[] zipBuffer;
            using (MemoryStream zipStream = new MemoryStream())
            {
                using (var archive = new System.IO.Compression.ZipArchive(zipStream, System.IO.Compression.ZipArchiveMode.Create, true))
                {
                    for (int i = 0; i < filePaths.Count; i++)
                    {
                        var entry = archive.CreateEntry(filePaths[i]);
                        using (var entryStream = entry.Open())
                        {
                            await streams[i].CopyToAsync(entryStream);
                        }
                    }
                    archive.Dispose();
                }
                zipStream.Position = 0;
                zipBuffer = zipStream.ToArray();
            }
            return File(zipBuffer, "application/zip", "files.zip");
        }

    }
}