using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    /// <summary>
    /// Class that defines Autopark, which contains list of transport
    /// </summary>
    [Serializable]
    public class AutoPark
    {
        public List<Transport> _transportPark = new List<Transport>();

        public List<Transport> TransportPark
        {
            get
            {
                return _transportPark;
            }

            set
            {
                _transportPark = value;
            }
        }
            

        public AutoPark() 
        { }

        public AutoPark(Transport[] transports)
        {
            this.TransportPark = transports.ToList();
        }

        /// <summary>
        /// Returns info about all transport in autopark
        /// </summary>
        public string GetInfo()
        {
            StringBuilder result = new StringBuilder("");

            foreach(Transport transport in TransportPark)
            {
                result.Append(transport.Getinfo());
            }

            return result.ToString();
        }
    }
}
