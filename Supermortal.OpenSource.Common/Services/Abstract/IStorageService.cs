using Supermortal.OpenSource.Common.Models;

namespace Supermortal.OpenSource.Common.Services.Abstract
{
    public interface IStorageService
    {
        void Save(StorageModel obj);
        StorageModel Load();
        string GetBaseDirectory();
    }
}
