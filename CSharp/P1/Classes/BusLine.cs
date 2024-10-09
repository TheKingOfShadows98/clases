using System.Linq;

namespace WhereBus
{
    public class BusLine : IRouteItem{
        public string Name { get; set;} 
        public BusStop[] BusStops {get; set;}

        public BusLine(string name, BusStop[] busStops){
            Name = name;
            BusStops = busStops;
        }
        public string GetName() => $"[L]{Name}";
        
        public bool ContainsBusStop(BusStop stop){
            return BusStops.Contains(stop);
        }

    }
}