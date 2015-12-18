using Supermortal.OpenSource.Common.Models;

namespace Supermortal.OpenSource.Common.Services.Abstract
{
    public interface IAPIKeyService
    {
        APIKeysModel GetAPIKeys();
        void BootstrapAPIKeys(APIKeysModel akm);
    }
}
