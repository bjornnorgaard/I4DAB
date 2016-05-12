using System;

namespace Handin
{
    public class SensorAccess : ISensorAccess
    {
        public bool AddData(int sensorId, int apartmentId, double value, string timestamp)
        {
            if (SensorExists(sensorId))
            {
                if (CreateSensorInDb(sensorId) == false) return false;
            }

            if (ApartmentExists(apartmentId))
            {
                if (CreateApartmentInDb(apartmentId) == false) return false;
            }

            if (CreateMesurement(sensorId, apartmentId, value, timestamp) == false) return false;

            return true;
        }

        private bool CreateMesurement(int sensorId, int apartmentId, double value, string timestamp)
        {
            throw new NotImplementedException();
        }

        private bool CreateApartmentInDb(int apartmentId)
        {
            throw new NotImplementedException();
        }

        private bool ApartmentExists(int apartmentId)
        {
            throw new NotImplementedException();
        }

        private bool CreateSensorInDb(int sensorId)
        {
            throw new NotImplementedException();
        }

        private bool SensorExists(int sensorId)
        {
            throw new NotImplementedException();
        }
    }
}