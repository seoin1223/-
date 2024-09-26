using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace socket
{
    public class Dto
    {
        public string INTERFACE_ID { get; set; } // set 
        public string MEASURE_DATE { get; set; } // (yyyMMdd) set
        public string MEASURE_TIME { get; set; } // (HHmmss) set
        public string CAR_NUMBER { get; set; } // set
        public string A_CODE { get; } = "032630"; 
        public string ITEM_CODE { get; } = "12010003"; 
        public string TOTAL_WEIGHT { get; set; } // set
        public string EMPTY_WEIGHT { get; set; } = "0"; 
        public string MEASURE_FLAG { get; } = "0"; 
        public string WEIGHT_FLAG { get; set; } = "1"; 
        public string INTERFACE_FLAG { get; } = "1"; 
        public string LOAD_TYPE { get; } = "0"; 
        public string BALE_SIZE { get; } = ""; 
        public string BALE_COUNT { get; } = "20"; 

       


       public Dto(String EMPTY_WEIGHT, string MEASURE_DATE, string INTERFACE_ID)
        {
            this.EMPTY_WEIGHT = EMPTY_WEIGHT;
            this.WEIGHT_FLAG = "2";
            this.MEASURE_DATE = MEASURE_DATE;
            this.INTERFACE_ID = INTERFACE_ID;
        }

        public Dto(string INTERFACE_ID, string MEASURE_DATE, string MEASURE_TIME, string CAR_NUMBER, string TOTAL_WEIGHT)
        {
            this.INTERFACE_ID = INTERFACE_ID;
            this.MEASURE_DATE = MEASURE_DATE;
            this.MEASURE_TIME = MEASURE_TIME;
            this.CAR_NUMBER = CAR_NUMBER;
            this.TOTAL_WEIGHT = TOTAL_WEIGHT;
        }

        public bool ValueCheck()
        {
            var properties = new[] { INTERFACE_ID, MEASURE_DATE, MEASURE_TIME, CAR_NUMBER, TOTAL_WEIGHT };
            return properties.All(p => !string.IsNullOrEmpty(p));
        }

        public override string ToString()
        {
            return $"{INTERFACE_ID}, {MEASURE_DATE}, {MEASURE_TIME}, {CAR_NUMBER}, {A_CODE}, {ITEM_CODE}, {TOTAL_WEIGHT}, {EMPTY_WEIGHT}, {MEASURE_FLAG}, {WEIGHT_FLAG}, {INTERFACE_FLAG}, {LOAD_TYPE}, {BALE_SIZE}, {BALE_COUNT}";
        }
    

    }
}
