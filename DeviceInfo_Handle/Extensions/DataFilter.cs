using DeviceInfo_Handle.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceInfo_Handle.Extensions
{
    public static class DataFilter
    {
        public static List<DeviceInfo> FindData(this List<DeviceInfo> list)
        {
            List<DeviceInfo> result = new List<DeviceInfo>();
            for (int i = 0; i < list.Count(); i++)
            {
                List<DeviceInfo> temp = new List<DeviceInfo>();
                int number = int.Parse(list[i].Brigade.Code);
                for (int y = i+1; y < list.Count()-1; y++)
                {
                    if(int.Parse(list[y].Brigade.Code) == number)
                    {
                        if(!temp.Contains(list[i]))
                            temp.Add(list[i]);

                        temp.Add(list[y]);
                    }                        
                }
                for (int j = 0; j < temp.Count()-1; j++)
                {
                    if (temp[j].Device.IsOnline)
                    {
                        result.AddRange(temp);
                        break;
                    }
                    continue;
                }
            }
           return result;
        }
    }    
}
