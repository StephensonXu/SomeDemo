using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ReadJson
{
    class Program
    {
        static void Main(string[] args)
        {
            //序列化
            Customer p = new Customer() { Unid = 1, CustomerName = "John" };
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var json = serializer.Serialize(p);
            Console.WriteLine(json);
            //反序列化
            var p1 = serializer.Deserialize<Customer>(json);
            Console.WriteLine(p1.Unid + " " + p1.CustomerName);
            Console.WriteLine(ReferenceEquals(p, p1));

            //test
            StreamReader sr = File.OpenText("./test.json");// \\或者@"\"或者/或者./
            string json1 = sr.ReadToEnd();
            Console.WriteLine(json1);
            var p2 = serializer.Deserialize<Customer>(json1);
            Console.WriteLine(p2.Unid + " " + p2.CustomerName);


            Console.ReadKey();
        }
    }
}
