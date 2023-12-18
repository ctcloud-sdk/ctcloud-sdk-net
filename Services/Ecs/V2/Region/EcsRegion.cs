using System;
using System.Collections.Generic;
using CtCloud.SDK.Core;

namespace CtCloud.SDK.Ecs.V2
{
    public class EcsRegion
    {
        public static readonly Region RU_MOSCOW_1 = new Region("ru-moscow-1",
            "https://ecs.ru-moscow-1.hc.sbercloud.ru");
        
        private static readonly IRegionProvider Provider = RegionProviderChain.GetDefault("ECS");

        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>()
        {
                { "ru-moscow-1", RU_MOSCOW_1 },
        };

        public static Region ValueOf(string regionId)
        {
            if (string.IsNullOrEmpty(regionId))
            {
                throw new ArgumentNullException(regionId);
            }

            var region = Provider.GetRegion(regionId);
            if (region != null)
            {
                return region;
            }

            if (StaticFields.ContainsKey(regionId))
            {
                return StaticFields[regionId];
            }

            throw new ArgumentException("Unexpected regionId: ", regionId);
        }
    }
}