using System.Text.RegularExpressions;

namespace EasyTalent.NucleoCompartilhado
{
    public static class ValidarDocumentos
    {
        public static bool ValidarEmail(string email)
        {
            const string emailRegex = @"^(([^<>()[\]\\.,;áàãâäéèêëíìîïóòõôöúùûüç:\s@\""]+"
                                      + @"(\.[^<>()[\]\\.,;áàãâäéèêëíìîïóòõôöúùûüç:\s@\""]+)*)|(\"".+\""))@"
                                      + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|"
                                      + @"(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$";
            Regex rx = new Regex(emailRegex);
            return rx.IsMatch(email);
        }
    }
}