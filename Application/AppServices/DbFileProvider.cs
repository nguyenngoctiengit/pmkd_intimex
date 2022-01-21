using DevExtreme.AspNet.Mvc.FileManagement;
using Microsoft.AspNetCore.Http;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace Application.AppServices
{
    public class DbFileProvider : IFileSystemItemEditor, IFileUploader, IFileContentProvider, IFileSystemItemLoader
    {
        PhysicalFileSystemProvider internalProvider;
        private IHostEnvironment _env;
        public DbFileProvider(string path)
        {
            internalProvider = new PhysicalFileSystemProvider(path);
        }
        public IEnumerable<FileSystemItem> GetItems(FileSystemLoadItemOptions options)
        {
            return internalProvider.GetItems(options);
        }
        public void CopyItem(FileSystemCopyItemOptions options)
        {
            throw new NotImplementedException();
        }

        public void CreateDirectory(FileSystemCreateDirectoryOptions options)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(FileSystemDeleteItemOptions options)
        {
            throw new NotImplementedException();
        }

        public Stream GetFileContent(FileSystemLoadFileContentOptions options)
        {
            throw new NotImplementedException();
        }

        public void MoveItem(FileSystemMoveItemOptions options)
        {
            throw new NotImplementedException();
        }

        public void RenameItem(FileSystemRenameItemOptions options)
        {
            throw new NotImplementedException();
        }

        public void UploadFile(FileSystemUploadFileOptions options)
        {
            
            var dir = options.DestinationDirectory;
            string destinationKey = $"{_env.ContentRootPath}/{options.DestinationDirectory.Path}/{options.FileName}";
            /*using (FileStream fileStream = System.IO.File.Create(destinationKey))
            {
                
                file.CopyTo(fileStream);
                fileStream.Flush();
            }*/
        }
    }
}
