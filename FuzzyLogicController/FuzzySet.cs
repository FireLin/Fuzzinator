using System;
using System.Collections.Generic;
using System.Text;

namespace FuzzyLogicController
{
    public class FuzzySet
    {
        private List<FuzzyNumber> _nums;
        private String _lingvar;

        #region Constructor
        public FuzzySet(List<FuzzyNumber> Num, String LingusticVariable)
        {
            _nums = Num;
            _lingvar = LingusticVariable;
        }

        public FuzzySet(String LingusticVariable)
        {
            _lingvar = LingusticVariable;
            _nums = new List<FuzzyNumber>();
        }

        #endregion

        #region Setters & Getters
        public List<FuzzyNumber> Set
        {
            get { return _nums; }
            set { _nums = value; }
        }

        public String Variable
        {
            get { return _lingvar; }
            set { _lingvar = value; }
        }
        #endregion

        #region Methods
        public FuzzyNumber searchByMemShipValue(String Value)
        {
            return _nums.Find(delegate(FuzzyNumber e) { return e.MemberShipName == Value; });
        }
        #endregion
    }
}
