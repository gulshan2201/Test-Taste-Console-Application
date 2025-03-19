using System;
using Test_Taste_Console_Application.Domain.DataTransferObjects;

namespace Test_Taste_Console_Application.Domain.Objects
{
    public class Moon
    {
        public string Id { get; set; }
        public float MassValue { get; set; }
        public float MassExponent { get; set; }

        // NEW addition by Gulshan
        public float TemperatureValue { get; set; }
        public float TemperatureExponent { get; set; }

        public Moon(MoonDto moonDto)
        {
            Id = moonDto.Id;
            MassValue = moonDto.MassValue;
            MassExponent = moonDto.MassExponent;

            //NEW addition by Gulshan
            TemperatureValue = moonDto.TemperatureValue; 
            TemperatureExponent = moonDto.TemperatureExponent;
        }


        //NEW addition by Gulshan
        public double GetTemperature()
        {
            return TemperatureValue * Math.Pow(10, TemperatureExponent);
        }
    }
}
