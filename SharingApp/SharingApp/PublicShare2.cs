using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SharingApp
{
    public class PublicShare2
    {
        Dictionary<int, IShare> _dic;
        public void Share(int platformId, string text)
        {
            //1 facebook
            //2 twitter
            //3 vk
            if(_dic == null)
            {
                _dic = new Dictionary<int, IShare>();
            }

            IShare share = null;

            if(platformId == 1)
            {               
                if (!_dic.ContainsKey(platformId))
                {
                    _dic.Add(platformId, new Porting.FacebookPorting(new Facebook.Facebook()));
                }
                share = _dic[platformId];
            }
            else if(platformId == 2)
            {
                if (!_dic.ContainsKey(platformId))
                {
                    _dic.Add(platformId, new Porting.TwitterPorting(new Twitter.Twitter()));
                }
                share = _dic[platformId];
            }
            else if(platformId == 3)
            {
                if (!_dic.ContainsKey(platformId))
                {
                    _dic.Add(platformId, new Porting.VKPorting(new VK.VK()));
                }
                share = _dic[platformId];
            }

            if(share != null)
            {
                share.Share(text);
            }
        }
    }
}
