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
        public enum TxtType
        {
            ID,
            PASSWORD
        }
        /// <summary>
        /// check if the password is valid
        /// </summary>
        /// <param name="passTxt">string password</param>
        /// <param name="msgBlock">text block</param>
        /// <param name="txt">text box</param>
        /// <returns>false - the validatioSn message is not visible, true - validation message is visible</returns>
        public static bool validPass(string passTxt, TxtType txtType)//
        {
            string reExValidation = "";
            if (txtType == TxtType.PASSWORD)
            {
                reExValidation = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,8}$"; //matches length of 8 include digit, Lower and Upper-Case letters
                return Regex.IsMatch(passTxt, reExValidation);
            }
            reExValidation = @"\d{9}";//matches 9 digits
            return Regex.IsMatch(passTxt, reExValidation);
        }
    }
}