using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace TEST.Validation
{
    public class ValidServe
    {
        /// <summary>
        /// check if the password is valid
        /// </summary>
        /// <param name="passTxt">string password</param>
        /// <param name="msgBlock">text block</param>
        /// <param name="txt">text box</param>
        /// <returns>false - the validation message is not visible, true - validation message is visible</returns>
        public static bool validPass(string passTxt)
        {
            string reExValidation = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,8}$";
            return Regex.IsMatch(passTxt, reExValidation);
        }
    }
}