﻿namespace Sensor.API.DTO
{
    /// <summary>
    /// Sensor data trasfer object.
    /// </summary>
    public class SensorDTO
    {
        /// <summary>
        /// Sensor Identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Sensor serial number.
        /// </summary>
        public string Serial { get; set; }

        /// <summary>
        /// Sensor type identifier.
        /// </summary>
        public int SensorTypeId { get; set; }

        /// <summary>
        /// Sensor type.
        /// </summary>
        public string SensorType { get; set; }
    }
}