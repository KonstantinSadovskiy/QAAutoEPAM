namespace InterfacesAndAbstractClasses
{
    public interface IFlyable
    {
        /// <summary>
        /// Flies object to new coordinates
        /// </summary>
        /// <param name="newCoordinates">New coordinates</param>
        void FlyTo(Coordinates newCoordinates);
        /// <summary>
        /// Gets fly time to the new coordinates
        /// </summary>
        /// <param name="newCoordinates">New coordinates</param>
        /// <returns>Fly time</returns>
        double GetFlyTime(Coordinates newCoordinates);
    }
}
