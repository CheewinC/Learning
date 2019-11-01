using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;

namespace Learning.Pages
{
    public partial class ClassToXml : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ICRM01801 a = new ICRM01801();
            a.IDOC = new ICRM01801IDOCICRM018[1][];
            string[] lines = File.ReadAllLines("D:\\ICRM018_Data_0021000005_20190801000536_0000000001.txt");
            ICRM01801IDOCICRM018 iCRM01801IDOCICRM018 = new ICRM01801IDOCICRM018();
            List<ICRM01801IDOCICRM018DETAILS> dETAILS = new List<ICRM01801IDOCICRM018DETAILS>();
            for (int i = 0; i < lines.Length; i++)
            {
                string[] data = lines[i].Split('|');
                if (data[1] == "p")
                {
                    iCRM01801IDOCICRM018 = new ICRM01801IDOCICRM018
                    {
                        BRANCH_CODE = data[3],
                        RONO = data[4],
                        COMPLETION_DATE = data[5],
                    };
                }
                else if (data[1] == "c")
                {
                    dETAILS.Add(new ICRM01801IDOCICRM018DETAILS
                    {
                        SOURCESYSTEM = data[4],
                        BRANCH_CODE = data[5],
                        RONO = data[6],
                        ANSWER_CODE = data[7],
                        RESULTS = data[8]
                    });
                }
                if ( (i+1) <= lines.Length || lines[i+1].Split('|')[1] == "P")
                {

                }
            }

            var serializer = new XmlSerializer(typeof(ICRM01801));
            using (var stream = new StreamWriter("D:\\test.xml"))
                serializer.Serialize(stream, a);
            string result = Serialize(a);
        }

        public static string Serialize<T>(T dataToSerialize)
        {
            var stringwriter = new StringWriter();
            var serializer = new XmlSerializer(typeof(T));
            serializer.Serialize(stringwriter, dataToSerialize);
            return stringwriter.ToString();
        }
    }
    public static class ArrayExtensions
    {
        public static T[] Add<T>(this T[] target, params T[] items)
        {
            // Validate the parameters
            if (target == null)
            {
                target = new T[] { };
            }
            if (items == null)
            {
                items = new T[] { };
            }

            // Join the arrays
            T[] result = new T[target.Length + items.Length];
            target.CopyTo(result, 0);
            items.CopyTo(result, target.Length);
            return result;
        }
    }
}