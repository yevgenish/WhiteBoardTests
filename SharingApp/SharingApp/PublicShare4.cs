using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharingApp
{
    public class PublicShare4
    {
        public void Share(int platformId, string text)
        {
            //1 facebook
            //2 twitter
            //3 vk
            //4 linkedin

            string dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName
                + @"\SharingLibraries\";

            string resData = SharingLibraries.ResourceManager.GetString($"n_{ platformId }");
            SharingLibraryInfo libraryInfo
                = (SharingLibraryInfo)JsonConvert.DeserializeObject(resData, typeof(SharingLibraryInfo));

            Assembly assembly = Assembly.LoadFrom(dir + libraryInfo.Dll);//"MyDll.dll"
            Type type = assembly.GetType(libraryInfo.Type); //"MyType"

            object instance = Activator.CreateInstance(type);

            MethodInfo method = (instance.GetType()).GetMethod(libraryInfo.Method);
            method.Invoke(instance, new object[] { text });
        }
    }
}
