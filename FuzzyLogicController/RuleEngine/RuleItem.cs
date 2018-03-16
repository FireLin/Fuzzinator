using System;
using System.Collections.Generic;
using System.Text;

namespace FuzzyLogicController.RuleEngine
{
    public class RuleItem
    {
        private String _variable;
        private String _membership;

        #region Constructor
        public RuleItem(String Variable, String Membership)
        {
            this._variable = Variable;
            this._membership = Membership;
        }
        #endregion

        #region Getter & Setters
        public String Variable
        {
            get { return _variable; }
        }

        public String MemberShipValue
        {
            get { return _membership; }
        }
        #endregion
    }
}
