using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern
{
    public class StreamingContent
    {
        public string ContentID { get; set; }
        public float Rating { get; set; }
        public string Genre { get; set; }
        public float Length { get; set; }
        public bool IsMature { get; set; }

        public StreamingContent(string title, float rating, string genre, float length, bool isMature)
        {
            ContentID = title;
            Rating = rating;
            Genre = genre;
            Length = length;
            IsMature = isMature;
        }

        public StreamingContent()
        {

        }
    }
}
