using inHealthTechnicalExam.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inHealthTechnicalExam.Utilities
{
    public class Utility
    {
        public bool IsUserHasAdminRole(string roleCode)
        {
            bool returnValue;
            if (string.Compare(roleCode, Constant.ADMIN) == 0)
                returnValue = true;
            else
                returnValue = false;
            return returnValue;
        }
    }
}
