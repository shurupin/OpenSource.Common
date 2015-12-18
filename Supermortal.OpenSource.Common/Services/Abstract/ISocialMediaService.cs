using System;
using Supermortal.OpenSource.Common.Models;

namespace Supermortal.OpenSource.Common.Services.Abstract
{
    public interface ISocialMediaService
    {
        Uri CreateRequestUri();
        string GetRedirectUrl();
        string ExtractAuthToken(string returnString);
        OauthTokenModel GetRequestTokens(string authToken);
        void SaveOauthResponse(OauthTokenModel otm);
        bool? HasCredentials();
        void MakePost(OauthTokenModel otm, AudioUoW audio);
    }
}
