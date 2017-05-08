using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshPods
{
   public class Subscription
    {
        /// <summary>
        /// Podcast Title
        /// Mapped to channel.title node of feed XML
        /// </summary>
        public string feedName { get; set; }

        /// <summary>
        /// Podcast feed url
        /// Returns atom feed XML
        /// </summary>
        public string FeedUrl { get; set; }

        /// <summary>
        /// Podcast website
        /// Mapped to channel.link node of feed XML
        /// </summary>
        public string FeedInfoUrl { get; set; }

        /// <summary>
        /// Podcast description
        /// Mapped to channel.description. Contained in CDATA
        /// </summary>
        public string FeedDescription { get; set; }
        
        /// <summary>
        /// uniqueID for podcast feed. Title of feed xml file.
        /// </summary>
        public Guid FeedID { get; set; }// = new Guid();

        /// <summary>
        /// 
        /// </summary>
        public List<Episode> Episodes { get; set; }

        /// <summary>
        /// List of strings that are used to filter episodes in a feed.
        /// Some Podcasts have excerpts from a longer episode or short aside.
        /// </summary>
        public List<String> FeedFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<PodcastCategories> FeedCategories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Image FeedCoverImage { get; set; }

        public enum FeedType
        {
            Streaming,
            Download
        }

        /// <summary>
        /// Create new subscription
        /// </summary>
        /// <param name="_feedURL">RSS feed XML</param>
        /// <param name="_feedType"></param>
        /// <param name="_feedFilter"></param>
        /// <param name="_newFeedID"></param>
        public Subscription(string _feedURL, FeedType _feedType, List<String> _feedFilter, Guid _newFeedID = new Guid())
        {
            //Pull feed XML
            //List five most recent episodes using applied filters
            //Add feed info to subscription repository (XML file)
            //Create podcast episiode repository (XML file)
        }

        public Subscription(Guid _feedID)
        {
            //Get existing feed from subscription repository using GUID
            //
        }

    }
}
