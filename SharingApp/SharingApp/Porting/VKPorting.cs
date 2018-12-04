using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharingApp.Porting
{
    public class VKPorting: IShare
    {
        VK.VK _vk;
        public VKPorting(VK.VK vk)
        {
            _vk = vk;
        }

        void IShare.Share(string text)
        {
            _vk.Post(text);
        }
    }
}
