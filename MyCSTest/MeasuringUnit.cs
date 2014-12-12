using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSTest
{
    public class MeasuringUnit
    {
        public MeasuringUnitType Type { get; private set; }

        public MeasuringUnit(MeasuringUnitType type)
        {
            Type = type;
        }


        public override string ToString() {
            switch (this.Type) {
                case MeasuringUnitType.Kilogram:   return "kg";
                case MeasuringUnitType.Gram:       return "g";
                case MeasuringUnitType.Milligram:  return "mg";
                case MeasuringUnitType.Liter:      return "l";
                case MeasuringUnitType.Milliliter: return "ml";
                case MeasuringUnitType.Deciliter:  return "dl";
                case MeasuringUnitType.Ton:        return "t";
                default:                            return "";
            }
        }
    }
}