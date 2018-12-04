using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace SharingApp
{
    public class PublicShare3
    {
        Dictionary<int, SharingClass> _dic;
        public void Share(int platformId, string text)
        {
            //1 facebook
            //2 twitter
            //3 vk
            //4 linkedin

            if (_dic == null)
            {
                _dic = new Dictionary<int, SharingClass>();
            }

            SharingClass share = null;
            if (!_dic.ContainsKey(platformId))
            {
                SharingClass current = GetInstance(platformId);
                _dic.Add(platformId, current);
            }
            share = _dic[platformId];

            if (share != null)
            {
                MethodInfo method = (share.Instance.GetType()).GetMethod(share.MethodName);
                method.Invoke(share.Instance, new object[] { text });
            }
        }

        public SharingClass GetInstance(int platformId)
        {
            string assemblyFile = null;
            string typeName = null;
            string methodName = null;

            string dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\SharingLibraries\";

            string resData = SharingLibraries.ResourceManager.GetString("n_" + platformId);
            SharingLibraryInfo myDeserializedObj
                = (SharingLibraryInfo)Newtonsoft.Json.JsonConvert.DeserializeObject(resData, typeof(SharingLibraryInfo));

            assemblyFile = dir + myDeserializedObj.Dll;
            typeName = myDeserializedObj.Type;
            methodName = myDeserializedObj.Method;

            Assembly assembly = Assembly.LoadFrom(assemblyFile);//"MyDll.dll"
            Type type = assembly.GetType(typeName); //"MyType"

            object instance = Activator.CreateInstance(type);
            SharingClass sharingClass = new SharingClass()
            {
                Instance = instance,
                MethodName = methodName
            };
            return sharingClass;
        }
    }
}
