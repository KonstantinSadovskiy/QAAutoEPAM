using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace OOP
{
    /// <summary>
    /// Class that defines Autopark, which contains list of transport
    /// </summary>
    [Serializable]
    public class AutoPark
    {
        private int _maxAmountOfTransport;
        private List<Transport> _transportPark = new List<Transport>();

        public int MaxAmountOfTransport
        {
            get
            {
                return _maxAmountOfTransport;
            }

            set
            {
                if (value < 1)
                {
                    throw new InitializationException("Max amount of transport can't be less than 1");
                }
                _maxAmountOfTransport = value;
            }
        }

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

        public AutoPark(int maxAmountOfTransport, Transport[] transports)
        {
            this.MaxAmountOfTransport = maxAmountOfTransport;
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

        /// <summary>
        /// Adds transport to the transport list
        /// </summary>
        /// <param name="transport">Added transport</param>
        public void AddTransport(Transport transport)
        {
            if (TransportPark.Count() == MaxAmountOfTransport)
            {
                throw new AddException("Can't exceed max amount of transport.");
            }

            if (TransportPark.Select(x => x.Id).Contains(transport.Id))
            {
                throw new AddException("Can't add transport with existing ID");
            }


            TransportPark.Add(transport);
        }

        /// <summary>
        /// Updates existing transport in transport list
        /// </summary>
        /// <param name="transport">New transport configuration</param>
        /// <param name="id">Transport id in list</param>
        public void UpdateAuto(Transport transport, int id)
        {
            if (!TransportPark.Select(x => x.Id).Contains(id))
            {
                throw new UpdateAutoException("Can't update not existing transport.");
            }

            if (id != transport.Id)
            {
                throw new UpdateAutoException("Can't update transport from template with different ID.");
            }

            int indexOfUpdatedTransport = TransportPark.IndexOf(TransportPark.Where(x => x.Id == id).ToList()[0]);
            TransportPark[indexOfUpdatedTransport] = transport;
        }

        /// <summary>
        /// Removes existing transport from transport list
        /// </summary>
        /// <param name="id">Transport id</param>
        public void RemoveAuto(int id)
        {
            if (!TransportPark.Select(x => x.Id).Contains(id))
            {
                throw new UpdateAutoException("Can't remove not existing transport.");
            }

            TransportPark.Remove(TransportPark.Where(x => x.Id == id).ToList()[0]);
        }

        /// <summary>
        /// Returns string list of all existing parameters of class
        /// </summary>
        /// <returns>String list of all existing parameters of class</returns>
        public List<string> GetAllAutoParameters()
        {
            return TransportPark.SelectMany(x => x.GetType().GetProperties()).Select(x => x.Name).Distinct().ToList();
        }

        /// <summary>
        /// Returns list of transport corresponding to the chosen parameters and their value
        /// </summary>
        /// <param name="parameter">String parameter name</param>
        /// <param name="value">String parameter value</param>
        /// <returns>list of transport corresponding to the chosen parameters and theitr value</returns>
        public List<Transport> getAutoByParameter(string parameter, string value)
        {
            if(!GetAllAutoParameters().Contains(parameter))
            {
                throw new GetAutoByParameterException();
            }

            return TransportPark.Where(x => GetAutoPerameterValue(x, parameter) == value).ToList();
        }

        /// <summary>
        /// Getting a parameter of a transport object by its name
        /// </summary>
        /// <param name="transport">Object with searched parameter</param>
        /// <param name="parameter">Parameter name</param>
        /// <returns>PropertyInfo resulted from searched parameters</returns>
        public PropertyInfo GetAutoParameter(Transport transport, string parameter)
        {
            return transport.GetType().GetProperty(parameter);
        }

        /// <summary>
        /// Getting the value of the specified parameter in an object
        /// </summary>
        /// <param name="transport">Specified object</param>
        /// <param name="parameter">Parameter name</param>
        /// <returns>Value of searched parameter</returns>
        public string GetAutoPerameterValue(Transport transport, string parameter)
        {
            return GetAutoParameter(transport, parameter).GetValue(transport).ToString();
        }
    }
}
