

using Edka.Sa04;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Edka.Sa05
{
    internal class ProgrAM
    {
        public static List<Disciplinals> disciplinas = new List<Disciplinals>
        {
            new Disciplinals{Disciplina = "Neurociência e Aprendizagem",Inicio = new DateTime(08-08-2022), Termino = new DateTime(12-09-2022)},
            new Disciplinals{Disciplina = "Habilidades socio emocionais",Inicio = new DateTime(10-08-2022), Termino = new DateTime(24-08-2022)},
            new Disciplinals{Disciplina = "Felicidade",Inicio = new DateTime(31-08-2022), Termino = new DateTime(14-09-2022)},
            new Disciplinals{Disciplina = "Teoria do Desenvolvimento Humano e da Aprendizagem",Inicio = new DateTime(19-09-2022), Termino = new DateTime(24-10-2022)},
            new Disciplinals{Disciplina = "Planejamento Pedagógico",Inicio = new DateTime(27-08-2022), Termino = new DateTime(23-10-2022)},
            new Disciplinals{Disciplina = "Educação Inclusiva e Cidadania",Inicio = new DateTime(21-09-2022), Termino = new DateTime(09-11-2022)},
            new Disciplinals{Disciplina = "Gestão da Sala de Aula",Inicio = new DateTime(16-11-2022), Termino = new DateTime(30-12-2022)},
            new Disciplinals{Disciplina = "Met.Dinâmicas e Inovativas",Inicio = new DateTime(31-10-2022), Termino = new DateTime(14-11-2022)},
            new Disciplinals{Disciplina = "Projeto Integrador",Inicio = new DateTime(21-11-2022), Termino = new DateTime(05-12-2022)},
            new Disciplinals{Disciplina = "Avaliação por Competências",Inicio = new DateTime(01-01-2023), Termino = new DateTime(02-01-2023)},
            new Disciplinals{Disciplina = "Aprendizagem por Competências",Inicio = new DateTime(02-01-2023), Termino = new DateTime(03-01-2023)},
            new Disciplinals{Disciplina = "Prática Docente á Distância",Inicio = new DateTime(03-01-2023), Termino = new DateTime(04-01-2023)},
            new Disciplinals{Disciplina = "Legislação e diretrizes da Educação Profissional e tecnologia",Inicio = new DateTime(04-01-2023), Termino = new DateTime(05-01-2023)},
            new Disciplinals{Disciplina = "Ambientes de Aprendizagem Inoativos",Inicio = new DateTime(05-01-2023), Termino = new DateTime(06-01-2023)}
        };
        static void Main(string[] args)
        {
            var listaCrescente = from d in disciplinas
                                 orderby d.Termino ascending
                                 select d;

            foreach (var lista in listaCrescente)
            {
                Console.WriteLine(lista);
            }

            Console.ReadKey();
        }
    }
}

