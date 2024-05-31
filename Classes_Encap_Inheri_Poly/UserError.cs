using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Encap_Inheri_Poly
{
    internal abstract class UserError
    {
        public abstract string UEMessage();
    }
    internal class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }
    internal class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error!";
        }
    }
    internal class AlphaNumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a special character in an alphanumeric only field. This fired an error!";
        }
    }
    internal class SpecialInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a alphanumeric character in an special only field. This fired an error!";
        }
    }
    internal class PasswordInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to log in with a password that didn't match the username. This fired an error!";
        }
    }

}
