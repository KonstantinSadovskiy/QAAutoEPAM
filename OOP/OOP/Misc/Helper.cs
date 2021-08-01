using System.Collections.Generic;
using System.Linq;

namespace OOP
{
    /// <summary>
    /// Class that contains methods for serialization filtering
    /// </summary>
    public static class Helper
    {
        /// <summary>
        /// Returns sorted list of transport with engine volume value more than indicated
        /// </summary>
        /// <param name="autoPark">AutoPark object with list of transport</param>
        /// <param name="volumeValue">Volume value</param>
        public static List<Transport> GetTransportAboveVolumeValue(AutoPark autoPark, double volumeValue)
        {
            return autoPark.TransportPark.Where(transportItem => transportItem.Engine.Volume > volumeValue)
                                         .OrderBy(transportItem => transportItem.Engine.Power)
                                         .ToList();
        }

        /// <summary>
        /// Returns list of transport with with only buses and trucks
        /// </summary>
        /// <param name="autoPark">AutoPark object with list of transport</param>
        public static List<Transport> GetTransportBusAndTruck(AutoPark autoPark)
        {
            return autoPark.TransportPark.Where(transportItem => (transportItem is Bus || 
                                                                  transportItem is Truck))
                                         .ToList();
        }

        /// <summary>
        /// Returns list of transport grouped by transmission type
        /// </summary>
        /// <param name="autoPark">AutoPark object with list of transport</param>
        public static List<Transport> GetTransportGroupByTransmission(AutoPark autoPark)
        {
            return autoPark.TransportPark.GroupBy(transportItem => transportItem.Transmission.Type).SelectMany(transportItem => transportItem).ToList();
        }
    }
}
