using DeviceInfo_Handle.Models.DTOs;
using Newtonsoft.Json;
using DeviceInfo_Handle.Extensions;
class Program
{
    public static void Main(string[] args)
    {
        var path = "C:\\Users\\markell\\Desktop\\Тестовое B-1336\\Задание2\\Devices.json";
        using (StreamReader sr = new StreamReader(path))
        {
            var text = sr.ReadToEnd();
            var result = JsonConvert.DeserializeObject<List<DeviceInfo>>(text).FindData();

            var newData = JsonConvert.SerializeObject<Conflict>(result);
        }
    }
}