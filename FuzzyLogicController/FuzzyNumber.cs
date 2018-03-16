using System;
using System.Collections.Generic;
using System.Text;

namespace FuzzyLogicController
{
    public class FuzzyNumber
    {
        String _membername;
        double _fuzzyout;

        public FuzzyNumber(String MemName, double value)
        {
            _membername = MemName;
            _fuzzyout = value;
        }

        public String MemberShipName
        {
            get { return _membername; }
        }

        public double FuzzyValue
        {
            get { return _fuzzyout; }
            set { _fuzzyout = value; }
        }

        public override string ToString()
        {
            return MemberShipName + " ---> " + FuzzyValue.ToString();
        }
      

    }
}
