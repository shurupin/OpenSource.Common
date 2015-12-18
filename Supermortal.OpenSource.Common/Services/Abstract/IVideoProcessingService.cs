using System.Collections.Generic;
using Supermortal.OpenSource.Common.Models;
using Supermortal.OpenSource.Common.Models.Enums;

namespace Supermortal.OpenSource.Common.Services.Abstract
{

    public delegate void VideoRenderedEventHandler(object sender, VideoRenderedEventArgs e);

    public interface IVideoProcessingService
    {
        void CreateVideoFromImages(List<string> imagePaths, string audioPath, string outputPath, VideoQuality vq, List<VideoRenderedEventHandler> renderCompleted = null);
        string GetCorrectFilename(string outputFilename);

        void CreateVideoFromImages(List<string> imagePaths, AudioUoW audio, string outputPath, VideoQuality vq,
            List<VideoRenderedEventHandler> renderCompleted = null);
    }
}
