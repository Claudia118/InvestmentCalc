using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Total
    {
        //Fields and Properties

        private int compounds;
        public int Compounds
        {
            get { return compounds; }
            set { compounds = value; Calc(); }
        }

        private double interest;
        public double Interest
        {
            get { return interest; }
            set { interest = value; Calc(); }
        }

        private double principal;
        public double Principal
        {
            get { return principal; }
            set { principal = value; Calc(); }
        }

        private int years;
        public int Years
        {
            get { return years; }
            set { years = value; Calc();}
        }

        public double Full { get; private set; }

        //Calc Method
        private void Calc()
        {
            Full = principal * (double)Math.Pow((1 + Interest /(100 * Compounds)), Compounds * Years);

        }
        
    }
}
