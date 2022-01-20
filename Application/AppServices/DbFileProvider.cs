using DevExtreme.AspNet.Mvc.FileManagement;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Application.AppServices
{
    public class DbFileProvider : IFileSystemItemEditor, IFileUploader, IFileContentProvider, IFileSystemItemLoader
    {
        PhysicalFileSystemProvider internalProvider;
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
        }
    }
}
