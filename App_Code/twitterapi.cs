using System.Collections.Generic;
using TweetSharp;

/// <summary>
/// Summary description for Class1
/// </summary>
public class twitterapi
{
    public twitterapi()
    {

    }
    public IEnumerable<TwitterStatus> getTwit(string input)
    {
        var service = new TwitterService("HsE9x7KSWhqyb7CQhxhFWN2oF", "GlUtr9Hy7Rq0UwcKmA8MCbSD1AORoTN83LvA8oYGool1yUFG1S");

        //AuthenticateWith("Access Token", "AccessTokenSecret");
        service.AuthenticateWith("2489399222-AR5SyQDsDZ7bqc23eT8QNBDauVFDX8PWdnrWZcu", "FMAJel0Q3ivViyvGRLDWljeDKbANrRj0D8XS3shlmVGCt");

        TwitterSearchResult result = service.Search(new SearchOptions { Q = input, Count = 500 });

        if (result == null)
        {
            return null;
        }

        //ScreenName="screeen name not username", Count=Number of Tweets / www.Twitter.com/mcansozeri. 
        IEnumerable<TwitterStatus> tweets = result.Statuses;

        return tweets;
    }
}