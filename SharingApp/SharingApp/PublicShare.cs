using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SharingApp
{
    public class PublicShare
    {
        public void Share(int platformId, string text)
        {
            //1 facebook
            //2 twitter
            //3 vk

            if(platformId == 1)
            {
                Facebook.Facebook fb = new Facebook.Facebook();
                fb.Share(text);
            }
            else if(platformId == 2)
            {
                Twitter.Twitter tw = new Twitter.Twitter();
                tw.Tweet(text);
            }
            else if(platformId == 3)
            {
                VK.VK vk = new VK.VK();
                vk.Post(text);
            }
        }
    }
}
