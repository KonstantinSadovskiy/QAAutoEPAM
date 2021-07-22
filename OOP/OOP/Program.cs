﻿using System;
using System.Linq;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Engine toyotaEngine = new Engine(300, 4.6, "Gasoline", "H5G658");
                Transmission toyotaTransmission = new Transmission("Auto", 6, "Aisin Corporation");
                Chassis toyotaChassis = new Chassis(4, "514473", 8000);
                Car toyotaTacoma = new Car(toyotaEngine, toyotaChassis, toyotaTransmission, "Toyota Tacoma", 50000);

                Engine icarusEngine = new Engine(1000, 7.8, "Diesel", "J54L66");
                Transmission icarusTransmission = new Transmission("Manual", 6, "Csepel");
                Chassis icarusChassis = new Chassis(6, "554348", 25000);
                Bus icarus = new Bus(icarusEngine, icarusChassis, icarusTransmission, "Icarus", 32);

                Engine garbageTruckEngine = new Engine(1800, 10.5, "Diesel", "NM54IJ");
                Transmission garbageTruckTransmission = new Transmission("Manual", 5, "McNeilus Refuse");
                Chassis garbageTruckChassis = new Chassis(6, "744199", 40000);
                Truck garbageTruck = new Truck(garbageTruckEngine, garbageTruckChassis, garbageTruckTransmission, "Garbage Truck", "Collecting garbage");

                Engine fireTruckEngine = new Engine(1500, 8.2, "Diesel", "JHO11K");
                Transmission fireTruckTransmission = new Transmission("Manual", 5, "Csepel");
                Chassis fireTruckChassis = new Chassis(8, "223587", 27250);
                Truck firetruck = new Truck(fireTruckEngine, fireTruckChassis, fireTruckTransmission, "Firetruck", "Extinguishing fire");

                Engine scooterEngine = new Engine(2, 0.5, "Biofuel", "INGJ3R");
                Transmission scooterTransmission = new Transmission("Auto", 3, "Scooter Corporation");
                Chassis scooterChassis = new Chassis(2, "664119", 300);
                Car scooterBike = new Car(scooterEngine, scooterChassis, scooterTransmission, "Scooter Bike", 50000);

                Transport[] transports = new Transport[5];
                transports[0] = toyotaTacoma;
                transports[1] = icarus;
                transports[2] = garbageTruck;
                transports[3] = firetruck;
                transports[4] = scooterBike;

                AutoPark autoPark = new AutoPark(transports);
                //autoPark.DisplayInfo();

                ListSerialization.SerializeList(Helper.ApplyAboveVolumeValueFilter(autoPark, 1.5), "PowerFiltered.xml");
                ListSerialization.SerializeList(Helper.ApplyBusOrTruckFilter(autoPark).Select(transportItem => transportItem.Engine).ToList(), "BusOrTruckEngineFiltered.xml");
                ListSerialization.SerializeList(Helper.ApplyGroupByTransmissionFilter(autoPark), "GroupByTransmissionFiltered.xml");
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
