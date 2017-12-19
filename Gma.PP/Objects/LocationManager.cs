using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Gma.PP.Objects
{

    public class LocationManager
    {
        private static string ConfDirectory = "config";

        private static string FilePath = ConfDirectory + "\\weizhi.json";

        public static ItemLocationList LocationInf { get; set; }

        public static void Init()
        {

            var jsonPath = AppDomain.CurrentDomain.BaseDirectory + FilePath;
            if (System.IO.File.Exists(jsonPath))
            {
                using (StreamReader sr = new StreamReader(jsonPath))
                {
                    try
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Converters.Add(new JavaScriptDateTimeConverter());
                        serializer.NullValueHandling = NullValueHandling.Ignore;

                        //构建Json.net的读取流  
                        JsonReader reader = new JsonTextReader(sr);
                        //对读取出的Json.net的reader流进行反序列化，并装载到模型中  
                        LocationInf = serializer.Deserialize<ItemLocationList>(reader);

                    }
                    catch (Exception ex)
                    {
                        ex.Message.ToString();
                    }
                }

                MergerLocationItems();
            }
            else
            {
                LoadLocationItemDefault();
            }
        }

        public static void LoadLocationItemDefault()
        {
            LocationInf = new ItemLocationList();
            var items = GetDefinedItemLocations();
            foreach (var item in items)
            {
                LocationInf.AddItem(item);
            }

        }

        public static List<ItemLocation> GetDefinedItemLocations()
        {
            var items = new List<ItemLocation>();
            items.Add(new ItemLocation { Id = LocationItemConsts.DingDanLeiXing });
            items.Add(new ItemLocation { Id = LocationItemConsts.WuLiaoListDefaultRow });
            items.Add(new ItemLocation { Id = LocationItemConsts.WuLiaoFormHangHao });
            items.Add(new ItemLocation { Id = LocationItemConsts.CloseWuLiaoForm });
            items.Add(new ItemLocation { Id = LocationItemConsts.CancelCaiGouDan });
            return items;
        }

        public static void MergerLocationItems()
        {
            if (LocationInf == null)
            {
                LoadLocationItemDefault();
            }
            else
            {
                var items = GetDefinedItemLocations();
                foreach (var item in items)
                {
                    if (LocationInf.Items.ContainsKey(item.Id))
                    {
                        continue;
                    }

                    LocationInf.AddItem(item);
                }

            }

        }

        public static void SaveConfig()
        {
            var xmlDirectoryPath = AppDomain.CurrentDomain.BaseDirectory + ConfDirectory;

            if (!System.IO.Directory.Exists(xmlDirectoryPath))
                System.IO.Directory.CreateDirectory(xmlDirectoryPath);

            var jsonPath = AppDomain.CurrentDomain.BaseDirectory + FilePath;

            using (StreamWriter sw = new StreamWriter(jsonPath))
            {
                try
                {

                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Converters.Add(new JavaScriptDateTimeConverter());
                    serializer.NullValueHandling = NullValueHandling.Ignore;

                    //构建Json.net的写入流  
                    JsonWriter writer = new JsonTextWriter(sw);
                    //把模型数据序列化并写入Json.net的JsonWriter流中  
                    serializer.Serialize(writer, LocationInf);
                    //ser.Serialize(writer, ht);  
                    writer.Close();
                    sw.Close();

                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                }
            }
        }

    }

}
