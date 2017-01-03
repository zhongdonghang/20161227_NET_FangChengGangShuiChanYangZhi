using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Domain._02_ViewModel.RptFishpond
{
    public class RptWaterQualityAnalyzer
    {
        public string Title { get; set; }


        public List<string> F_PHValues { get; set; }

        public List<string> TemperatureValues { get; set; }

        public List<string> DOValues { get; set; }
    }
}
