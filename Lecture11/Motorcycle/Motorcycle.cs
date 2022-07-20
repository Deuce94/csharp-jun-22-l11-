using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcycle
{
    internal class Motorcycle
    {
        public Guid id { get; } = Guid.NewGuid();
        public string? Model { get; set; }
        public string? Creator { get; set; }
        public DateOnly DateOfIssue { get; set; }
        public Int32 Mileage{ get; set; }

        public Engine? EngineOfMotorcycle { get; set; }

        public Motorcycle( string? model, string? creator, DateOnly dateOfIssue, int mileage, Engine? engineOfMotorcycle)
        {
            
            Model = model;
            Creator = creator;
            DateOfIssue = dateOfIssue;
            
            Mileage = mileage;
            EngineOfMotorcycle = engineOfMotorcycle;
        }

       

        public override string ToString()
        {
            return String.Format($"1. Motorcycle: \"{Creator}\", model: {Model}, id: \"{id}\", year: {DateOfIssue.Year} \n" +
                $"1.1 Engine: {EngineOfMotorcycle?.GetType()}, volume: { EngineOfMotorcycle.volume}, power {EngineOfMotorcycle.power}");
        }


    }


}
