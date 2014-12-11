using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSTest
{
    class MeasuringUnit
    {
        public MeasuringUnitTypes Type { get; private set; }

        public MeasuringUnit(MeasuringUnitTypes type)
        {
            this.Type = type;
        }


        public override string ToString() {
            switch (this.Type) {
                case MeasuringUnitTypes.Kilogram:   return "kg";
                case MeasuringUnitTypes.Gram:       return "g";
                case MeasuringUnitTypes.Milligram:  return "mg";
                case MeasuringUnitTypes.Liter:      return "l";
                case MeasuringUnitTypes.Milliliter: return "ml";
                case MeasuringUnitTypes.Deciliter:  return "dl";
                case MeasuringUnitTypes.Ton:        return "t";
                default:                            return "";
            }
        }
    }
}