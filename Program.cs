using FileHelpers;
using System;
using System.Collections.Generic;

namespace ArquivosPosicionados
{
    class Program
    {
        static void Main(string[] args)
        {
           List<NovosCotistasDTO> lista = new List<NovosCotistasDTO>
           {
               new NovosCotistasDTO
               {
                   agencia = "0168",
                   conta = "504122",
                   dataInclusao = DateTime.Now,                  
                   tipo = "5",
                   idUsuario = "1",
                   cnpj = "23.160.569/0001-10",
               }
               
           };

            EscrevaArquivo(@"C:\Projetos\Publicacao\teste20210909.txt", lista);

        }

        public static void EscrevaArquivo(string nomeDoArquivo, List<NovosCotistasDTO> registros)
        {
            FileHelperEngine engine = new FileHelperEngine(typeof(NovosCotistasDTO));

            engine.WriteFile(nomeDoArquivo, registros);
        }
    }
}
