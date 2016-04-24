using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tweetinvi;
using Tweetinvi.Core.Parameters;

/// <summary>
/// Summary description for Class1
/// </summary>
public class TweetAPI
{
    public TweetAPI()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public IEnumerable<Tweetinvi.Core.Interfaces.ITweet> getTwit(string input)
    {
        Auth.SetUserCredentials("HsE9x7KSWhqyb7CQhxhFWN2oF", "GlUtr9Hy7Rq0UwcKmA8MCbSD1AORoTN83LvA8oYGool1yUFG1S", "2489399222-AR5SyQDsDZ7bqc23eT8QNBDauVFDX8PWdnrWZcu", "FMAJel0Q3ivViyvGRLDWljeDKbANrRj0D8XS3shlmVGCt");

        var searchParam = new TweetSearchParameters(input)
        {
            MaximumNumberOfResults = 200
        };
        
        //ScreenName="screeen name not username", Count=Number of Tweets / www.Twitter.com/mcansozeri. 
        
        var tweets = Search.SearchTweets(searchParam);
        
        return tweets;
    }
}