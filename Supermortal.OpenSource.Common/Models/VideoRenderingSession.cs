using Supermortal.OpenSource.Common.Services.Abstract;

namespace Supermortal.OpenSource.Common.Models
{
    public class VideoRenderingSession
    {
        public int Count { get; set; }
        public AllVideosRenderedEventHandler AllVideosRendered { get; set; }
        public AllVideosUploadedEventHandler AllVideosUploaded { get; set; }
    }
}
