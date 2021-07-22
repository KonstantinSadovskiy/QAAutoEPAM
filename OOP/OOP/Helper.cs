using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP
{
    public static class Helper
    {
        public static List<Transport> ApplyAboveVolumeValueFilter(AutoPark autoPark, double volumeValue)
        {
            return autoPark.TransportPark.Where(transportItem => transportItem.Engine.Volume > volumeValue)
                                         .OrderBy(transportItem => transportItem.Engine.Power)
                                         .ToList();
        }

        public static List<Transport> ApplyBusOrTruckFilter(AutoPark autoPark)
        {
            return autoPark.TransportPark.Where(transportItem => (transportItem is Bus || 
                                                                  transportItem is Truck))
                                         .ToList();
        }

        public static List<Transport> ApplyGroupByTransmissionFilter(AutoPark autoPark)
        {
            return autoPark.TransportPark.GroupBy(transportItem => transportItem.Transmission.Type).SelectMany(transportItem => transportItem).ToList();
        }
    }
}
