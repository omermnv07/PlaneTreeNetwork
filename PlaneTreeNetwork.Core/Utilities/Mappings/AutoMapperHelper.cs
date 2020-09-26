using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace PlaneTreeNetwork.Core.Utilities.Mappings
{
    public class AutoMapperHelper
    {
        public static List<T> MapToSameTypeList<T>(List<T> list)
        {
            Mapper.Initialize(x =>
            {
                x.CreateMap<T, T>();
            });

            List<T> result = Mapper.Map<List<T>, List<T>>(list);
            return result;
        }
        public static T MapToSameType<T>(T obj)
        {
            Mapper.Initialize(x =>
            {
                x.CreateMap<T, T>();
            });

            T result = Mapper.Map<T, T>(obj);
            return result;
        }
    }
}
