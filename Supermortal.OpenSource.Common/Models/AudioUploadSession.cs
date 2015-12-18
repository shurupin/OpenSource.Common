using Supermortal.OpenSource.Common.Services.Abstract;

namespace Supermortal.OpenSource.Common.Models
{
    public class AudioUploadSession
    {
        public int Count { get; set; }
        public AllAudiosUploadedEventHandler AllAudiosUploaded { get; set; }
    }
}
