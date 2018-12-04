using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharingApp.Porting
{
    public class TwitterPorting: IShare
    {
        Twitter.Twitter _twitter;
        public TwitterPorting(Twitter.Twitter twitter)
        {
            _twitter = twitter;
        }

        void IShare.Share(string text)
        {
            _twitter.Tweet(text);
        }
    }
}
