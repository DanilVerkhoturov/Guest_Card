using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Admin_Panel_Hotel
{
    class RegexUtilities
    {
        /// <summary>
        /// Проверка корректности электронной почты.
        /// </summary>
        /// <param name="email">Электронаня почта.</param>
        /// <returns>Если электронная почта введена корректно - true, в противном случае вернёт false.</returns>
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Нормализация домена.
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Изучает домен электронной почты и нормализует её.
                string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();

                    // Вытащить и обработать доменное имя (создает недопустимое ArgumentException)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
}
