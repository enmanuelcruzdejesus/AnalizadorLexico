using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnalizadorLex1
{
    public class LexicalAnalyzer
    {
        public static bool IsValidEmail(string email)
        {
            bool s1 = false;
            bool s2 = false;
            bool s3 = false;
            bool s4 = false;
            if (email.Length > 7)
            {
                for (int i = 0; i < email.Length; i++)
                {
                    //1.validando que la cadena no puede empezar con el simbolo @
                    if (email[0] != '@' && s1 == false)
                    {
                        s1 = true;
                        continue;

                    }

                    //validando que la cadena tenga el simbolo @ 
                    if (email[i] == '@' && s1 == true && s2 == false)
                    {
                        s2 = true;
                        continue;

                    }

                    //validando que la cadena tenga el simbolo . pero no puede ser despues del simbolo @
                    if (email[i] == '.' && email[i - 1] != '@' && s1 == true && s2 == true && s3 == false)
                    {
                        s3 = true;
                        continue;

                    }



                    if (email[i - 1] == '.' && email[i] != '.' && s1 == true && s2 == true && s3 == true && s4 == false)
                    {
                        s4 = true;

                    }

                }
            }
            else
            {
                return false;
            }

            return s1 && s2 && s2 && s3 && s4;




        }

        public static bool IsValidId(string Id)
        {
            string c1 = Id.Substring(0, 4);
            string c2 = string.Empty;
            int n1 = 0;
            bool result = false;
            if (Id.Length == 9)
            {

                if (Int32.TryParse(c1, out n1))
                {
                    if (Id.Substring(4, 1)[0] == '-')
                    {
                        c2 = Id.Substring(5, 4);
                        if (Int32.TryParse(c2, out n1))
                        {
                            result = true;
                        }
                    }
                }
            }
            else
            {
                result = false;
            }



            return result;
        }

        public static bool IsValidURL(string url)
        {
            var schemes = new string[] { "http", "https", "ftp", "mailto", "file", "data", "irc" };

            if (url.Length >= 7)
            {
                var i = url.IndexOf(':');
                if (i > 0)
                {
                    //getting the scheme
                    var scheme = url.Substring(0, i);
                    if (schemes.Contains(scheme))
                    {
                        var s2 = url.Substring(i + 1, 2);
                        if (s2 == "//")
                        {
                            //obteniendo el dominio
                            var bindex = url.IndexOf("//") + 2;
                            var eindex = url.LastIndexOf('/');
                            var sub = url.Substring(bindex, eindex);
                            var isub = sub.IndexOf('/');
                            var domain = sub.Substring(0, isub).Trim();

                            //validando domain
                            var www = domain.Substring(0, 3);
                            if (www == "www")
                            {

                                var fistdot = domain.Substring(3, 1);
                                var indexfirstdot = domain.IndexOf('.');
                                if (fistdot == ".")
                                {
                                    var indexseconddot = domain.LastIndexOf(".");
                                    if (indexseconddot - indexfirstdot > 3)
                                    {
                                        //validando extension
                                        var ext = domain.Substring(indexseconddot + 1, 3);
                                        var listofdomainextensions = new string[] { "com", "do", "org", "gov", "es", "arg", "mx", "net", "edu", "mil", "uk", "ch", "de", "eg", "fr", "it", "ur", "us" };
                                        if (listofdomainextensions.Contains(ext))
                                        {
                                            return true;
                                        }
                                        else
                                        {
                                            return false;
                                        }


                                    }
                                    else
                                    {
                                        return false;
                                    }


                                }
                                else
                                {
                                    return false;
                                }
                            }
                            else
                            {
                                return false;
                            }




                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }

                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }


        }

        public static bool IsValidPhone(string phone)
        {

            string c1 = phone.Substring(0, 3);
            string c2 = string.Empty;
            string c3 = string.Empty;
            int n1 = 0;
            bool result = false;
            if (phone.Length == 12)
            {

                if (Int32.TryParse(c1, out n1))
                {
                    if (phone.Substring(3, 1)[0] == '-')
                    {
                        c2 = phone.Substring(4, 3);
                        if (Int32.TryParse(c2, out n1))
                        {
                            if (phone.Substring(7, 1)[0] == '-')
                            {
                                c3 = phone.Substring(8, 4);
                                if (Int32.TryParse(c3, out n1))
                                {
                                    result = true;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                result = false;
            }



            return result;
        }

        public static bool IsValidsig(string sig)
        {
            //CSD-1730-4988-ISC-314
            string c1 = sig.Substring(0, 3);
            string c2 = string.Empty;
            string c3 = string.Empty;
            string c4 = string.Empty;
            string c5 = string.Empty;
            int n1 = 0;
            bool result = false;

            if (sig.Length == 21)
            {
                c1 = sig.Substring(0, 3);
                if (c1 == "CSD")
                {
                    if (sig.Substring(3, 1)[0] == '-')
                    {
                        c2 = sig.Substring(4, 4);
                        if (Int32.TryParse(c2, out n1))
                        {
                            if (sig.Substring(8, 1)[0] == '-')
                            {
                                c3 = sig.Substring(9, 4);
                                if (Int32.TryParse(c3, out n1))
                                {
                                    if (sig.Substring(13, 1)[0] == '-')
                                    {
                                        c4 = sig.Substring(14, 3);
                                        if (!Int32.TryParse(c4, out n1))
                                        {
                                            if (sig.Substring(17, 1)[0] == '-')
                                            {
                                                c5 = sig.Substring(18, 3);
                                                if (Int32.TryParse(c5, out n1))
                                                {
                                                    result = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                result = false;
            }

            return result;
        }
        public LexicalAnalyzer()
        {
        }
    }
}
