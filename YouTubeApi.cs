using System;
using System.Collections.Generic;
using CustomException.Models;

namespace CustomException
{
    public class YouTubeApi
    {
        public List<Video> GetVideos()
        {
            try
            {
                // do some logic

                throw new Exception("Some low level error");
            }
            catch (Exception ex)
            {
                throw new YouTubeException("Could not fetch the videos from YouTube", ex);  // in the inner exception we will see the actual problem that happened
            }

            return new List<Video>();
        }
    }
}
