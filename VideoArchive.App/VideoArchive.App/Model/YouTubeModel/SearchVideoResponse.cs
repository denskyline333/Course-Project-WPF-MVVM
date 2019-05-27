using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoArchive.App.Model.YouTubeModel
{
    public partial class SearchVideoResponse
    {
        public Item[] Items { get; set; }  
    }

    public partial class Item
    {
        public string Id { get; set; }
        public Snippet Snippet { get; set; }       
    }

    public partial class Snippet
    {
        public string ChannelTitle { get; set; }
        public string Description { get; set; }
        public DateTime PublishedAt { get; set; }
    }
}
