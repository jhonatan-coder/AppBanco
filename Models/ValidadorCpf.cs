using System;
using System.Linq;
namespace AppBanco.Models
{
    public static class ValidadorCpf
    {
        public static bool Validar(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
            {
                return false;
            }
            //Remove qualquer ponto, traço ou espaço que o usuario tenha digitado
            string apenasNumeros = new string(cpf.Where(char.IsDigit).ToArray());
            //CPF precisa de exatamente 11 números
            if (apenasNumeros.Length != 11)
            {
                return false;
            }
            //ignora CPFs com todos os números iguais (111.111.111-11)
            if (apenasNumeros.All(c => c == apenasNumeros[0]))
            {
                return false;
            }
            //Cálculo do Primeiro Dígito verificador
            int[] multiplicador1 = {10, 9, 8, 7, 6, 5, 4, 3, 2};
            string sCpf = apenasNumeros.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(sCpf[i].ToString()) * multiplicador1[i];
            }

            int resto = soma % 11;
            int digito1 = resto < 2 ? 0 : 11 - resto;
            //Cálculo do Segundo Dígito Verificador
            int[] multiplicador2 = {11, 10, 9, 8, 7, 6, 5, 4, 3, 2};
            sCpf += digito1;
            soma = 0;

            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(sCpf[i].ToString()) * multiplicador2[i];
            }
            resto = soma % 11;
            int digito2 = resto <2 ? 0 : 11 - resto;
            
            //Confere se os dígitos calculados batem com os que o usuário digitou.
            return apenasNumeros.EndsWith(digito1.ToString() + digito2.ToString());
        }
    }
}