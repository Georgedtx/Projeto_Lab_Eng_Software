using System.Text.RegularExpressions;

namespace Domain.Entities.Validations
{
    public class SenhaValidation
    {
        public static bool Validate(string senha)
        {
            if (senha.Length < 8)
            {
                return false;
            }

            if (senha.Length > 10)
            {
                return false;
            }

            var let = (Regex.IsMatch(senha, @"^(?=.*[a-z])(?=.*[A-Z]).+$", RegexOptions.ECMAScript));
            var num = (Regex.IsMatch(senha, @"[0-9]+(\.[0-9][0-9]?)?", RegexOptions.ECMAScript));

            if (let && num)
            {
                return true;
            }

            return false;
        }
    }
}
