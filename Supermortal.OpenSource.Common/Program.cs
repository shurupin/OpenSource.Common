using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Splicer.Renderer;
using Splicer.Timeline;
using Splicer.WindowsMedia;

namespace Supermortal.OpenSource.Common
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Pics");
            using (ITimeline timeline = new DefaultTimeline(30))
            {
                double halfDuration = 1;
                IGroup group = timeline.AddVideoGroup("video", 30, 32, 1920, 1080);

                ITrack videoTrack = group.AddTrack();
                List<string> filePaths = Directory.EnumerateFiles(folderPath, "*.jpg").ToList();
                for (int i = 0; i < filePaths.Count; i++)
                {
                    IClip clip = videoTrack.AddImage(filePaths[i], 0, 10);
                    if (i > 0)
                    {
                        group.AddTransition(clip.Offset - halfDuration, halfDuration, StandardTransitions.CreateFade(), true);
                        group.AddTransition(clip.Offset, halfDuration, StandardTransitions.CreateFade(), false);
                    }
                }

                string folderPath2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Audio");
                string audioPath = Directory.EnumerateFiles(folderPath2, "*.wav").FirstOrDefault(x => x != null);

                ITrack audioTrack = timeline.AddAudioGroup().AddTrack();

                IClip audio = audioTrack.AddAudio(audioPath, 0, videoTrack.Duration);

                audioTrack.AddEffect(0, audio.Duration, StandardEffects.CreateAudioEnvelope(1.0, 1.0, 1.0, audio.Duration));

                using (var renderer = new WindowsMediaRenderer(timeline, "output.wmv", WindowsMediaProfiles.FullHD))
                {
                    renderer.Render();
                }
            }

            Console.WriteLine("Hello World!");
        }
    }
}
