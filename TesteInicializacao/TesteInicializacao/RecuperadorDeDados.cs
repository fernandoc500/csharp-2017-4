using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteInicializacao
{
    class RecuperadorDeDados
    {
        /// <summary>
        /// Função que digitada o nome de um aluno irá retornar a matrícula do usuário
        /// </summary>
        /// <param name="nome">O Nome do Aluno</param>
        /// <returns>A matrícula</returns>
        public String ObterMatricula(String nome)
        {
            if (nome == "Fernando")
                return "1322728";
            else
                return "1231231";
        }
    }
}
