using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharingApp.Porting
{
    public class FacebookPorting : IShare
    {
        Facebook.Facebook _facebook;

        public FacebookPorting(Facebook.Facebook facebook)
        {
            _facebook = facebook;
        }

        void IShare.Share(string text)
        {
            _facebook.Share(text);
        }
    }
}
