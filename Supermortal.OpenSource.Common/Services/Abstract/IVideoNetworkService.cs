﻿using System;
using System.Collections.Generic;
using Supermortal.OpenSource.Common.Models;

namespace Supermortal.OpenSource.Common.Services.Abstract
{
   
    public delegate void VideoUploadedEventHandler(object sender, VideoUploadedEventArgs e);

    public interface IVideoNetworkService
    {
        string ExtractAuthToken(string returnString);
        Uri CreateRequestUri();
        OauthTokenModel GetRequestTokens(string authToken);
        void SaveOauthResponse(OauthTokenModel otm);
        void UploadVideo(AudioUoW audio, OauthTokenModel otm, List<VideoUploadedEventHandler> videoUploaded = null);
        bool? HasCredentials();
        OauthTokenModel RefreshRequestTokens(OauthTokenModel ytm);
    }
}
