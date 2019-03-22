using SmartShop.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SmartShop.Domain.ValueObjects
{
    public class Email
    {
        public Email(string endereco)
        {
            if (isValid(endereco))
            {
                Endereco = endereco;
            }
            else
            {
                endereco = null;
            }


        }
        public string Endereco { get; private set; }

        private bool isValid(string email)
        {
            string texto = email;

            Regex rg = new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
            if (rg.IsMatch(texto))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
