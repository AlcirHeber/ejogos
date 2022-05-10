using EJOGOS1.Models;
using System.Collections.Generic;

namespace EJOGOS1.Interface
{
    public interface IEquipe
    {
        //Contrato
        //Representa os métodos que são obrigatórios em uma classe

        void Criar(Equipe novaequipe);

        List<Equipe> LerEquipes();




    }
}
