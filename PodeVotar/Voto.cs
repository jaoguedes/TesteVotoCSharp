﻿namespace PodeVotar
{
    public static class Voto
    {
        public static string podeVotar(int idade)
        {
            if (idade <= 15)
                return "Não pode votar!";

            if ((idade >= 16 && idade <= 17))
                return "Voto opcional!";

            if ((idade >= 18 && idade <= 70))
                return "Voto obrigatório!";

            return "Voto opcional!";
        }
    }
}
