using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Winui3Beispiele
{
  public static class RssFeedStatic
  {
    public static SyndicationFeed GetFeed()
    {
      var reader = XmlReader.Create("https://www.n-tv.de/rss");
      var feed = SyndicationFeed.Load(reader);
      return feed;
    }
  }

  public class RssFeed
  {
    public SyndicationFeed Feed { get; set; }

    public RssFeed()
    {
      var reader = XmlReader.Create("https://www.n-tv.de/rss");
      var feed = SyndicationFeed.Load(reader);
      Feed = feed;

    }
  }
}
