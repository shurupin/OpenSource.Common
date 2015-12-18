using System.Collections.Generic;
using Supermortal.OpenSource.Common.Models;

namespace Supermortal.OpenSource.Common.Services.Abstract
{
    public interface IMasterService
    {
        List<AudioUoW> CreateAudioUnitsOfWork(string audioDirectory);
        string GetAudioUnitOfWorkName(string audioPath);
        string GenerateTagsString(List<string> tags, char delimiter = ',');
        List<string> GetTagsFromTagString(string tagsString);
    }
}
