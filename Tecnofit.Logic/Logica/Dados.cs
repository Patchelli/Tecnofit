using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecnofit.Logic.Logica
{
    public class Dados
    {
        public string lerLinkRepositorio()
        {
            const string Git = "https://github.com/Patchelli?tab=repositories";
            return Git;
        }

        public string lerLinkSite()
        {
            const string Site = "https://terraminerais.com";
            return Site;
        }


        public string lerPlanos()
        {
            string planos = "Concluir a faculdade e fazer uma especialização," +
                " médio prazo;Montar meu próprio negócio, longo prazo;";
            return planos;
        }

    }
}
