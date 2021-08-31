using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTH2.Models
{
    public class GPTB1
    {
        public double GPT(double soA, double soB)
        {
            double Nghiem = -soB / soA;
            return Nghiem;
        }
    }
}