using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoIII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            Loop.MainLoop();
        }
    }

    internal static class Loop
    {
        static bool initial = true;

        internal static void MainLoop()
        {
            if (initial)
                initial = false;
            else
                Console.WriteLine("\n\n\n\n\n");

            Console.WriteLine("Digite:\n\tq-reconhecimento: Reconhecimento de funções orgânicas\n" +
                "\tq-nomenclatura: Nomenclatura de Funções Orgânicas\n" +
                "\tq-reações: Reações Orgânicas\n" +
                "\tq-isomeria: Isomeria (pois é)");

            var ex = Console.ReadLine();

            switch (ex)
            {
                case "q-reconhecimento":
                    new ChemistryUnderstandment();
                    break;
                case "q-nomenclatura":
                    new ChemistryNames();
                    break;
                case "q-reações":
                    new ChemistryReactions();
                    break;
                case "q-isomeria":
                    new ChemistryIsomery();
                    break;
                default:
                    break;
            }
        }
    }

    internal class ChemistryUnderstandment
    {
        internal ChemistryUnderstandment()
        {
            Init();
        }

        /**
            Retorna a resposta certa.

            @param rand	Número aleatório que para a definição da resposta.
            @return Resposta certa.
        */
        string SetAnswer(int rand)
        {
            string answer = "";

            switch (rand)
            {
                case 1:
                    answer = "hidrocarboneto";
                    break;
                case 2:
                    answer = "alcool";
                    break;
                case 3:
                    answer = "enol";
                    break;
                case 4:
                    answer = "aldeido";
                    break;
                case 5:
                    answer = "cetona";
                    break;
                case 6:
                    answer = "acidocarboxilico";
                    break;
                case 7:
                    answer = "eter";
                    break;
                case 8:
                    answer = "ester";
                    break;
                case 9:
                    answer = "fenol";
                    break;
                case 10:
                    answer = "haletoorganico";
                    break;
                case 11:
                    answer = "amina";
                    break;
                case 12:
                    answer = "amida";
                    break;
                case 13:
                    answer = "nitrila";
                    break;
                case 14:
                    answer = "nitrocomposto";
                    break;
                default:
                    Console.WriteLine("Oops... bug");
                    break;
            }

            return answer;
        }

        /**
            Define a pergunta.

            @param rand				Número aleatório que para a definição da pergunta.
            @param typeOfQuestion	Número definido pelo usuário para definição do tipo de pergunta.
        */
        void SetQuestion(int rand, int typeOfQuestion)
        {
            string question = "";
            int randType = 1;

            switch (typeOfQuestion)
            {
                case 1:
                    randType = 1;
                    break;
                case 2:
                    randType = 2;
                    break;
                case 3:
                    Random rd = new Random();
                    randType = rd.Next(1, 3);
                    break;
            }

            switch (rand)
            {
                case 1:
                    switch (randType)
                    {
                        case 1:
                            question = "C - C - C";
                            break;
                        case 2:
                            question = "somente carbonos na cadeia principal";
                            break;
                    }
                    break;
                case 2:
                    switch (randType)
                    {
                        case 1:
                            question = "C - C - O";
                            break;
                        case 2:
                            question = "hidroxila(OH) ligada a um carbono saturado";
                            break;
                    }
                    break;
                case 3:
                    switch (randType)
                    {
                        case 1:
                            question = "O\n|\nC = C - C";
                            break;
                        case 2:
                            question = "hidroxila(OH) ligada a carbono insaturado(ligacao dupla)";
                            break;
                    }
                    break;
                case 4:
                    switch (randType)
                    {
                        case 1:
                            question = "C - C - C = O";
                            break;
                        case 2:
                            question = "carbonila (C=O) na extremidade da cadeia";
                            break;
                    }
                    break;
                case 5:
                    switch (randType)
                    {
                        case 1:
                            question = "C - CO - C";
                            break;
                        case 2:
                            question = "carbonila(C=O) no interior da cadeia";
                            break;
                    }
                    break;
                case 6:
                    switch (randType)
                    {
                        case 1:
                            question = "HOOC - C - C - C - C";
                            break;
                        case 2:
                            question = "presenca do grupo funcional carboxila (COOH)";
                            break;
                    }
                    break;
                case 7:
                    switch (randType)
                    {
                        case 1:
                            question = "C - C - O - C - C - C";
                            break;
                        case 2:
                            question = "oxigenio como heteroatomo (entre radicais)";
                            break;
                    }
                    break;
                case 8:
                    switch (randType)
                    {
                        case 1:
                            question = "C - COO - C - C";
                            break;
                        case 2:
                            question = "caracterizada pelo grupo funcional carboxilato (- COO -)";
                            break;
                    }
                    break;
                case 9:
                    switch (randType)
                    {
                        case 1:
                            question = "C6H5 - OH";
                            break;
                        case 2:
                            question = "hidroxila ligada diretamente a um carbono que faz parte do anel aromatico";
                            break;
                    }
                    break;
                case 10:
                    switch (randType)
                    {
                        case 1:
                            question = "Cl - C - C";
                            break;
                        case 2:
                            question = "compostos resultantes da substituicao de um ou mais hidrogenios dos hidrocarbonetos por um ou mais halogenios";
                            break;
                    }
                    break;
                case 11:
                    switch (randType)
                    {
                        case 1:
                            question = "C - C - N\n    |\n    C";
                            break;
                        case 2:
                            question = "resultantes da substituicao dos hidrogenios do NH3 por radicais organicos";
                            break;
                    }
                    break;
                case 12:
                    switch (randType)
                    {
                        case 1:
                            question = "C - C - CO - N";
                            break;
                        case 2:
                            question = "compostos resultantes da substituicao de hidrogenios do NH3, por radicais acila (R - CO -)";
                            break;
                    }
                    break;
                case 13:
                    switch (randType)
                    {
                        case 1:
                            question = "C - C - C -= N";
                            break;
                        case 2:
                            question = "nitrogenio com ligacao tripla no final da cadeia";
                            break;
                    }
                    break;
                case 14:
                    switch (randType)
                    {
                        case 1:
                            question = "C - C - C - NO";
                            break;
                        case 2:
                            question = "NO2 no final da cadeia";
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Oops... bug");
                    break;
            }

            Console.WriteLine(question + "\n");
        }

        /**
	        Loop principal do reconhecimento de funções.

	        @param typeOfQuestion Número definido pelo usuário para definição do tipo de questão.
        */
        void Workflow(int typeOfQuestion)
        {
            Random rd = new Random();

            int rand = rd.Next(1, 15);
            string answer;
            string input;

            answer = SetAnswer(rand);
            SetQuestion(rand, typeOfQuestion);

            input = Console.ReadLine();

            if (input == "voltar") Loop.MainLoop();

            if (input == answer)
                Console.WriteLine("Acertou!\n\n");
            else
                Console.WriteLine("Errou... A resposta certa e \"" + answer + "\"\n\n");

            Workflow(typeOfQuestion);
        }

        /**
	        Setup inicial para o reconhecimento de funções.
        */
        void Init()
        {
            Console.WriteLine("Reconhecimento de funcoes organicas, escreva o nome da funcao sem acentos e em minusculo. \nDigite \"voltar\" para recomecar o programa.\n");
            Console.WriteLine("Escreva 1 para somente questoes estruturais, 2 para questoes teoricas ou 3 para os dois: ");
            int typeOfQuestion;
            typeOfQuestion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            Workflow(typeOfQuestion);
        }
    }

    internal class ChemistryNames
    {
        internal ChemistryNames()
        {
            Init();
        }

        /**
	        Retorna a resposta do exercício.

	        @param randFunction Função orgânica aleatória.
	        @param randExercise Seletor de três exercícios diferentes para cada função orgânica.
	        @param randType		Seletor do tipo do exercício (Usual ou IUPAC).
        */
        string SetAnswer(int randFunction, int randExercise, int randType)
        {
            string answer = "";

            if (randType == 1)
                Console.WriteLine("Nome Oficial\n");
            else
                Console.WriteLine("Nome Usual\n");

            switch (randFunction)
            {
                case 1:
                    if (randType == 1)
                        switch (randExercise)
                        {
                            case 1:
                                answer = "propano";
                                break;
                            case 2:
                                answer = "etano";
                                break;
                            case 3:
                                answer = "1-buteno";
                                break;
                        }
                    else
                        switch (randExercise)
                        {
                            case 1:
                                answer = "etino";
                                break;
                            case 2:
                                answer = "iso-propano";
                                break;
                            case 3:
                                answer = "metano";
                                break;
                        }
                    break;
                case 2:
                    if (randType == 1)
                        switch (randExercise)
                        {
                            case 1:
                                answer = "butanol";
                                break;
                            case 2:
                                answer = "1-propanol";
                                break;
                            case 3:
                                answer = "ciclobutanol";
                                break;
                        }
                    else
                        switch (randExercise)
                        {
                            case 1:
                                answer = "alcool-butilico";
                                break;
                            case 2:
                                answer = "alcool-propilico";
                                break;
                            case 3:
                                answer = "alcool-ciclobutilico";
                                break;
                        }
                    break;
                case 3:
                    if (randType == 1)
                        switch (randExercise)
                        {
                            case 1:
                                answer = "etenol";
                                break;
                            case 2:
                                answer = "prop-1-en-1-ol";
                                break;
                            case 3:
                                answer = "but-2-en-2-ol";
                                break;
                        }
                    else
                        switch (randExercise)
                        {
                            case 1:
                                answer = "pent-2-en-3-ol";
                                break;
                            case 2:
                                answer = "prop-1-en-2-ol";
                                break;
                            case 3:
                                answer = "but-1-en-2-ol";
                                break;
                        }
                    break;
                case 4:
                    if (randType == 1)
                        switch (randExercise)
                        {
                            case 1:
                                answer = "propanal";
                                break;
                            case 2:
                                answer = "etanal";
                                break;
                            case 3:
                                answer = "butanal";
                                break;
                        }
                    else
                        switch (randExercise)
                        {
                            case 1:
                                answer = "aldeido-propionico";
                                break;
                            case 2:
                                answer = "aldeido-acetico";
                                break;
                            case 3:
                                answer = "aldeido-butirico";
                                break;
                        }
                    break;
                case 5:
                    if (randType == 1)
                        switch (randExercise)
                        {
                            case 1:
                                answer = "3-pentanona";
                                break;
                            case 2:
                                answer = "butanona";
                                break;
                            case 3:
                                answer = "propanona";
                                break;
                        }
                    else
                        switch (randExercise)
                        {
                            case 1:
                                answer = "dietil-cetona";
                                break;
                            case 2:
                                answer = "etil-metil-cetona";
                                break;
                            case 3:
                                answer = "dimetil-cetona";
                                break;
                        }
                    break;
                case 6:
                    if (randType == 1)
                        switch (randExercise)
                        {
                            case 1:
                                answer = "acido-butanoico";
                                break;
                            case 2:
                                answer = "acido-pentanoico";
                                break;
                            case 3:
                                answer = "acido-propanoico";
                                break;
                        }
                    else
                        switch (randExercise)
                        {
                            case 1:
                                answer = "acido-butirico";
                                break;
                            case 2:
                                answer = "acido-valerico";
                                break;
                            case 3:
                                answer = "acido-propionico";
                                break;
                        }
                    break;
                case 7:
                    if (randType == 1)
                        switch (randExercise)
                        {
                            case 1:
                                answer = "etoxi-propano";
                                break;
                            case 2:
                                answer = "metoxi-etano";
                                break;
                            case 3:
                                answer = "etoxi-butano";
                                break;
                        }
                    else
                        switch (randExercise)
                        {
                            case 1:
                                answer = "eter-etil-propilico";
                                break;
                            case 2:
                                answer = "eter-metil-etilico";
                                break;
                            case 3:
                                answer = "eter-etil-butirico";
                                break;
                        }
                    break;
                case 8:
                    if (randType == 1)
                        switch (randExercise)
                        {
                            case 1:
                                answer = "propanoato-de-etila";
                                break;
                            case 2:
                                answer = "butanoato-de-metila";
                                break;
                            case 3:
                                answer = "metanoato-de-propila";
                                break;
                        }
                    else
                        switch (randExercise)
                        {
                            case 1:
                                answer = "propionato-de-etila";
                                break;
                            case 2:
                                answer = "butirato-de-metila";
                                break;
                            case 3:
                                answer = "formiato-de-propila";
                                break;
                        }
                    break;
                case 9:
                    if (randType == 1)
                        switch (randExercise)
                        {
                            case 1:
                                answer = "1,2-hidroxi-propil-benzeno";
                                break;
                            case 2:
                                answer = "1,3-hidroxi-butil-benzeno";
                                break;
                            case 3:
                                answer = "b-hidroxi-naftaleno";
                                break;
                        }
                    else
                        switch (randExercise)
                        {
                            case 1:
                                answer = "o-propil-fenol";
                                break;
                            case 2:
                                answer = "m-butil-fenol";
                                break;
                            case 3:
                                answer = "b-naftol";
                                break;
                        }
                    break;
                case 10:
                    if (randType == 1)
                        switch (randExercise)
                        {
                            case 1:
                                answer = "1-cloro-butano";
                                break;
                            case 2:
                                answer = "2-iodo-butano";
                                break;
                            case 3:
                                answer = "1-bromo-pentano";
                                break;
                        }
                    else
                        switch (randExercise)
                        {
                            case 1:
                                answer = "cloreto-de-butila";
                                break;
                            case 2:
                                answer = "iodeto-de-s-butila";
                                break;
                            case 3:
                                answer = "brometo-de-pentila";
                                break;
                        }
                    break;
                case 11:
                    if (randType == 1)
                        switch (randExercise)
                        {
                            case 1:
                                answer = "metilamina";
                                break;
                            case 2:
                                answer = "propilamina";
                                break;
                            case 3:
                                answer = "butilamina";
                                break;
                        }
                    else
                        switch (randExercise)
                        {
                            case 1:
                                answer = "amino-metano";
                                break;
                            case 2:
                                answer = "1-amino-propano";
                                break;
                            case 3:
                                answer = "1-amino-butano";
                                break;
                        }
                    break;
                case 12:
                    if (randType == 1)
                        switch (randExercise)
                        {
                            case 1:
                                answer = "etanamida";
                                break;
                            case 2:
                                answer = "n-metil-propanamida";
                                break;
                            case 3:
                                answer = "n-butil-propanamida";
                                break;
                        }
                    else
                        switch (randExercise)
                        {
                            case 1:
                                answer = "acetamida";
                                break;
                            case 2:
                                answer = "n-metil-propionamida";
                                break;
                            case 3:
                                answer = "n-butil-propanamida";
                                break;
                        }
                    break;
                case 13:
                    if (randType == 1)
                        switch (randExercise)
                        {
                            case 1:
                                answer = "propano-nitrila";
                                break;
                            case 2:
                                answer = "butano-nitrila";
                                break;
                            case 3:
                                answer = "etano-nitrila";
                                break;
                        }
                    else
                        switch (randExercise)
                        {
                            case 1:
                                answer = "cianeto-de-propila";
                                break;
                            case 2:
                                answer = "cianeto-de-butila";
                                break;
                            case 3:
                                answer = "cianeto-de-etila";
                                break;
                        }
                    break;
                case 14:
                    if (randType == 1)
                        switch (randExercise)
                        {
                            case 1:
                                answer = "1-nitro-propano";
                                break;
                            case 2:
                                answer = "2-nitro-butano";
                                break;
                            case 3:
                                answer = "nitro-etano";
                                break;
                        }
                    else
                        switch (randExercise)
                        {
                            case 1:
                                answer = "2-nitro-pentano";
                                break;
                            case 2:
                                answer = "2-nitro-propano";
                                break;
                            case 3:
                                answer = "1-nitro-butano";
                                break;
                        }
                    break;
                default:
                    Console.WriteLine("Oops... bug");
                    break;
            }

            return answer;
        }

        /**
            Setup para a nomenclatura de funções.

            @param randFunction Função orgânica aleatória.
            @param randExercise Seletor de três exercícios diferentes para cada função orgânica.
            @param randType		Seletor do tipo do exercício (Usual ou IUPAC).
        */
        void SetQuestion(int randFunction, int randExercise, int randType)
        {
            string question = "";

            switch (randFunction)
            {
                case 1:
                    if (randType == 1)
                        switch (randExercise)
                        {
                            case 1:
                                question = "C - C - C";
                                break;
                            case 2:
                                question = "C - C";
                                break;
                            case 3:
                                question = "C = C - C - C";
                                break;
                        }
                    else
                        switch (randExercise)
                        {
                            case 1:
                                question = "C -= C";
                                break;
                            case 2:
                                question = "C - C\n|\nC";
                                break;
                            case 3:
                                question = "C";
                                break;
                        }
                    break;
                case 2:
                    switch (randExercise)
                    {
                        case 1:
                            question = "C - C - C - C - OH";
                            break;
                        case 2:
                            question = "C - C - C - OH";
                            break;
                        case 3:
                            question = "C - C\n|   |\nC - C - OH";
                            break;
                    }
                    break;
                case 3:
                    if (randType == 1)
                        switch (randExercise)
                        {
                            case 1:
                                question = "OH - C = C";
                                break;
                            case 2:
                                question = "OH - C = C - C";
                                break;
                            case 3:
                                question = "    OH\n    |\nC - C = C - C";
                                break;
                        }
                    else
                        switch (randExercise)
                        {
                            case 1:
                                question = "C - C = C - C - C\n        |\n        OH";
                                break;
                            case 2:
                                question = "C = C - C\n    |\n    OH";
                                break;
                            case 3:
                                question = "C = C - C - C\n    |\n    OH";
                                break;
                        }
                    break;
                case 4:
                    switch (randExercise)
                    {
                        case 1:
                            question = "C - C - CO";
                            break;
                        case 2:
                            question = "C - CO";
                            break;
                        case 3:
                            question = "C - C - C - CO";
                            break;
                    }
                    break;
                case 5:
                    switch (randExercise)
                    {
                        case 1:
                            question = "C - C - CO - C - C";
                            break;
                        case 2:
                            question = "C - CO - C - C";
                            break;
                        case 3:
                            question = "C - CO - C";
                            break;
                    }
                    break;
                case 6:
                    switch (randExercise)
                    {
                        case 1:
                            question = "C - C - C - COOH";
                            break;
                        case 2:
                            question = "C - C - C - C - COOH";
                            break;
                        case 3:
                            question = "C - C - COOH";
                            break;
                    }
                    break;
                case 7:
                    switch (randExercise)
                    {
                        case 1:
                            question = "C - C - O - C - C - C";
                            break;
                        case 2:
                            question = "C - C - O - C";
                            break;
                        case 3:
                            question = "C - C - O - C - C - C - C";
                            break;
                    }
                    break;
                case 8:
                    switch (randExercise)
                    {
                        case 1:
                            question = "C - C - COO - C - C";
                            break;
                        case 2:
                            question = "C - C - C - COO - C";
                            break;
                        case 3:
                            question = "COO - C - C - C";
                            break;
                    }
                    break;
                case 9:
                    switch (randExercise)
                    {
                        case 1:
                            question = " ___\n/   \\_ OH\n\\   /\n ---\n    |\n    C - C - C";
                            break;
                        case 2:
                            question = " ___ _ OH\n/   \\\n\\   /\n ---\n    |\n    C - C - C - C";
                            break;
                        case 3:
                            question = "HO\n |\n ___\n/   \\\n\\   /\n ---\n/   \\\n\\   /\n ---";
                            break;
                    }
                    break;
                case 10:
                    switch (randExercise)
                    {
                        case 1:
                            question = "Cl - C - C - C - C";
                            break;
                        case 2:
                            question = "C - C (I) C - C";
                            break;
                        case 3:
                            question = "Br - C - C - C - C - C";
                            break;
                    }
                    break;
                case 11:
                    switch (randExercise)
                    {
                        case 1:
                            question = "C - N";
                            break;
                        case 2:
                            question = "C - C - C - N";
                            break;
                        case 3:
                            question = "C - C - C - C - N";
                            break;
                    }
                    break;
                case 12:
                    switch (randExercise)
                    {
                        case 1:
                            question = "C - CON";
                            break;
                        case 2:
                            question = "C - C - CON - C";
                            break;
                        case 3:
                            question = "C - C - CON - C - C - C - C";
                            break;
                    }
                    break;
                case 13:
                    switch (randExercise)
                    {
                        case 1:
                            question = "C - C - C -= N";
                            break;
                        case 2:
                            question = "C - C - C - C -= N";
                            break;
                        case 3:
                            question = "C - C -= N";
                            break;
                    }
                    break;
                case 14:
                    if (randType == 1)
                        switch (randExercise)
                        {
                            case 1:
                                question = "C - C - C - NO2";
                                break;
                            case 2:
                                question = "C - C - C - C\n    |\n    NO2";
                                break;
                            case 3:
                                question = "C - C - NO2";
                                break;
                        }
                    else
                        switch (randExercise)
                        {
                            case 1:
                                question = "C - C - C - C - C\n    |\n    NO2";
                                break;
                            case 2:
                                question = "C - C - C\n    |\n    NO2";
                                break;
                            case 3:
                                question = "C - C - C - C - NO2";
                                break;
                        }
                    break;
                default:
                    Console.WriteLine("Oops... bug");
                    break;
            }

            Console.WriteLine(question + "\n");
        }

        /**
            Loop principal da nomenclatura de funções.
        */
        void Workflow()
        {
            Random rd = new Random();

            int randFunction = rd.Next(1, 15);
            int randExercise = rd.Next(1, 4);
            int randType = rd.Next(1, 3);
            string answer = "";
            string input = "";

            answer = SetAnswer(randFunction, randExercise, randType);
            SetQuestion(randFunction, randExercise, randType);
            input = Console.ReadLine();

            if (input == "voltar") Loop.MainLoop();

            if (input == answer)
                Console.WriteLine("Acertou!\n\n");
            else
                Console.WriteLine("Errou... A resposta certa e \"" + answer + "\"\n\n");

            Workflow();
        }

        /**
            Setup inicial para nomenclatura de funções.
        */
        void Init()
        {
            Console.WriteLine("Troque todos os espacos por \"-\"\n");

            Workflow();
        }
    }

    internal class ChemistryReactions
    {
        internal ChemistryReactions()
        {
            Init();
        }

        void SetQuestion(int questionNumber)
        {
            string question = "";

            switch (questionNumber)
            {
                case 0:
                    question = "Tipo de reação em que ocorre quebra de ligações pi entre carbonos e resulta em um único produto.";
                    break;
                case 1:
                    question = "Reação que ocorre com a adição de um hidrogênio a uma molécula.";
                    break;
                case 2:
                    question = "Reação que ocorre com a adição de halogênios (F2, Cl2, Br2, I2) em um alceno ou alcadieno.";
                    break;
                case 3:
                    question = "Reação que ocorre com a adição de haletos de hidrogênio (HCl, HBr, HI) à alcenos.";
                    break;
                case 4:
                    question = "Regra de Markovnikov: Nas reações de ______, o hidrogênio é adicionado ao carbono ______ hidrogenado da ligação dupla. (separe as palavras com um hífen)";
                    break;
                case 5:
                    question = "Reação que ocorre com a adição de água à molécula orgânica";
                    break;
                case 6:
                    question = "Tipo de reação em que átomos de hidrogênio são substituídos por outros elementos e resulta em mais de um produto.";
                    break;
                case 7:
                    question = "Reação que ocorre com a substituição de hidrogênios por halogênios (F2, Cl2, Br2, I2).";
                    break;
                case 8:
                    question = "Na Halogenação, a ordem com que os hidrogênios \"saem\" do hidrocarboneto é: Carbono ______, Carbono ______, Carbono ______. (separe as palavras com um hífen)";
                    break;
                case 9:
                    question = "Reação que ocorre com a substituição de hidrogênios pelo grupo Nitro (-NO2)";
                    break;
                case 10:
                    question = "Reação que ocorre com a substituição de hidrogênios pelo grupo Sulfônico (-SO3H)";
                    break;
                case 11:
                    question = "Reação que ocorre com a substituição de um hidrogênio por um grupo alquila (metil, etil, propil, ...)";
                    break;
                case 12:
                    question = "Reação que ocorre com a substituição de um hidrogênio por um grupo acila.";
                    break;
                case 13:
                    question = "Tipo de reação que é catalisado por um agente oxidante (como permanganato de potássio - KMnO4)";
                    break;
                case 14:
                    question = "Reação que ocorre em alcenos com um agente oxidante em solução aquosa, concentrada e ácida. Podemos obter vários produtos.";
                    break;
                case 15:
                    question = "Se reagirmos um carbono primário em uma Oxidação Energética dos Alcenos, produziremos ______ e ______. (separe as palavras com um hífen)";
                    break;
                case 16:
                    question = "Se reagirmos um carbono secundário em uma Oxidação Energética dos Alcenos, produziremos ______.";
                    break;
                case 17:
                    question = "Se reagirmos um carbono terciário em uma Oxidação Energética dos Alcenos, produziremos ______";
                    break;
                case 18:
                    question = "Reação que ocorre em álcoois com um agente oxidante e o produto é um aldeído, podendo se transformar em um ácido carboxílico.";
                    break;
                case 19:
                    question = "Reação que ocorre em álcoois com um agente oxidante e o produto é uma cetona.";
                    break;
                case 20:
                    question = "Tipo de reação em que se originam dois produtos, um orgânico e outro inorgânico.";
                    break;
                case 21:
                    question = "Desidratação ______ é quando uma molécula elimina água, já desidratação ______ é quando duas moléculas interagem e se unem, eliminando água simultaneamente. (separe as palavras com um hífen)";
                    break;
                case 22:
                    question = "Reação onde obtemos um alceno a partir de um alcano - catalisado por calor - e eliminamos hidrogênio.";
                    break;
                case 23:
                    question = "Reação onde di-haletos vicinais (\"vizinhos\") mais zinco (catalisado por calor) formam alcenos e eliminam haletos.";
                    break;
                case 24:
                    question = "Reação onde um haleto de alquila, catalisado por uma base (álcool/KOH), produz um alceno e elimina um Halogenidreto (Hidrohalogênio)";
                    break;
                case 25:
                    question = "Reação intramolecular onde um álcool catalisado por calor (170º) e ácido sulfúrico produzem um alceno e eliminam água.";
                    break;
                case 26:
                    question = "Reação intermolecular onde dois álcoois catalisados por calor (140º) e ácido sulfúrico produzem um éter e eliminam água.";
                    break;
                case 27:
                    question = "Tipo de reação caracterizada pelos reagentes \"matéria orgânica + O2\" e pelo produto \"CO2 + H2O\".";
                    break;
                case 28:
                    question = "Tipo de reação contrária à oxidação (que ocorre com o hidrogênio).";
                    break;
                case 29:
                    question = "Tipo de reação onde um Álcool e um Ácido Carboxílico produzem Éster";
                    break;
                case 30:
                    question = "Tipo de reação que se caracteriza por ser contrária à esterificação.";
                    break;
                default:
                    Console.WriteLine("Oops... Bug");
                    Workflow();
                    break;
            }

            Console.WriteLine(question);
        }

        string SetAnswer(int questionNumber)
        {
            string answer = "";

            switch (questionNumber)
            {
                case 0:
                    answer = "Reação de Adição/Adição";
                    break;
                case 1:
                    answer = "Hidrogênação";
                    break;
                case 2:
                    answer = "Halogenação";
                    break;
                case 3:
                    answer = "Hidrohalogenação/Halogenidreto";
                    break;
                case 4:
                    answer = "adição-mais";
                    break;
                case 5:
                    answer = "Hidratação";
                    break;
                case 6:
                    answer = "Reação de Substituição/Substituição";
                    break;
                case 7:
                    answer = "Halogenação";
                    break;
                case 8:
                    answer = "terciário-secundário-primário";
                    break;
                case 9:
                    answer = "Nitração";
                    break;
                case 10:
                    answer = "Sulfonação";
                    break;
                case 11:
                    answer = "Alquilação";
                    break;
                case 12:
                    answer = "Acilação";
                    break;
                case 13:
                    answer = "Reação de Oxidação/Oxidação";
                    break;
                case 14:
                    answer = "Oxidação Energética do Alceno";
                    break;
                case 15:
                    answer = "gás carbônico-água";
                    break;
                case 16:
                    answer = "ácido carboxílico";
                    break;
                case 17:
                    answer = "cetona";
                    break;
                case 18:
                    answer = "Oxidação do Álcool Primário";
                    break;
                case 19:
                    answer = "Oxidação do Álcool Secundário";
                    break;
                case 20:
                    answer = "Reação de Eliminação/Eliminação";
                    break;
                case 21:
                    answer = "intramolecular-intermolecular";
                    break;
                case 22:
                    answer = "Eliminação de Hidrogênio/Desidrogenação";
                    break;
                case 23:
                    answer = "Eliminação de Halogênio/De-Halogenação";
                    break;
                case 24:
                    answer = "Eliminação de Halogenidreto";
                    break;
                case 25:
                    answer = "Eliminação de Água";
                    break;
                case 26:
                    answer = "Eliminação de Água";
                    break;
                case 27:
                    answer = "Reação de Combustão/Combustão";
                    break;
                case 28:
                    answer = "Redução";
                    break;
                case 29:
                    answer = "Esterificação";
                    break;
                case 30:
                    answer = "Hidrólise";
                    break;
            }

            return answer;
        }

        void Workflow()
        {
            Random rd = new Random();

            int questionNumber = rd.Next(1, 32);

            string answer = "";
            List<string> possibleAnswers = null;

            string input = "";

            answer = SetAnswer(questionNumber);
            SetQuestion(questionNumber);
            input = Console.ReadLine();

            if (input == "voltar") Loop.MainLoop();

            if (answer.Contains('/'))
            {
                possibleAnswers = new List<string>(answer.Split('/'));
            }

            if (possibleAnswers != null)
            {
                foreach (string s in possibleAnswers)
                {
                    if (input.ToLower() == s.ToLower())
                    {
                        Console.WriteLine("Acertou!\n\n");
                        goto WorkflowLabel;
                    }
                }

                Console.WriteLine("Errou... A resposta certa é \"" + answer + "\"\n\n");
            }
            else
            {
                if (input.ToLower() == answer.ToLower())
                    Console.WriteLine("Acertou!\n\n");
                else
                    Console.WriteLine("Errou... A resposta certa é \"" + answer + "\"\n\n");
            }

        WorkflowLabel:
            Workflow();
        }

        void Init()
        {
            Console.WriteLine("Acentos e espaços são válidos, todas as respostas estão no singular e correspondem ao polígrafo de reações.\n\n");

            /*
            @"                                          ";
            @"                               NO2        ";
            @"      __                        \__       ";
            @"CH3__/  \   +   3X   --->   CH3_/  \_NO2  ";
            @"     \__/                       \__/      ";
            @"                                /         ";
            @"                               NO2        ";
            */

            Workflow();
        }
    }

    internal class ChemistryIsomery
    {
        internal ChemistryIsomery()
        {
            Init();
        }

        void Init()
        {
            Console.WriteLine("Escreva:\n\t1 - Questões Teóricas\n\t2 - Questões Práticas\n\t3 - Ambas");
            QuestionType questionType = (QuestionType)(Convert.ToInt32(Console.ReadLine()) - 1);

            Workflow(questionType);
        }

        void Workflow(QuestionType questionType)
        {
            Random rd = new Random();

            int questionNumber = rd.Next(1, 8);

            QuestionType? unambiguousType = null;
            if (questionType == QuestionType.Both)
                unambiguousType = (QuestionType)rd.Next(1, 3);

            SetQuestion(questionNumber, (unambiguousType.HasValue) ? unambiguousType.Value : questionType);
            var answer = SetAnswer(questionNumber, (unambiguousType.HasValue) ? unambiguousType.Value : questionType);

        InputLabel:
            var input = Console.ReadLine();

            if (input.ToLower().Contains("ótica"))
            {
                Console.WriteLine("Você quis dizer óptica? ;)");
                goto InputLabel;
            }

            if (input == "voltar")
                Loop.MainLoop();

            bool rightAnswer = false;

            List<string> possibleAnswers = null;
            if(answer.Contains('/'))
            {
                possibleAnswers = new List<string>(answer.Split('/'));
                foreach (string s in possibleAnswers)
                {
                    if (input.ToLower() == s.ToLower())
                    {
                        rightAnswer = true;
                        break;
                    }
                }
            }
            else
            {
                if (input.ToLower() == answer.ToLower())
                    rightAnswer = true;
            }

            if (rightAnswer)
                Console.WriteLine("Acertou!");
            else
                Console.WriteLine("Errou... A resposta certa é " + answer);

            Console.WriteLine("\n");

            Workflow(questionType);
        }

        void SetQuestion(int questionNumber, QuestionType questionType)
        {
            string question = "";

            if (questionType == QuestionType.Both)
            {
                Console.WriteLine("Oops... Bug");
                Loop.MainLoop();
            }

            if (questionType == QuestionType.Theory)
                switch (questionNumber)
                {
                    case 0:
                        question = "Os compostos pertencem a mesma função nas apresetam cadeias diferentes";
                        break;
                    case 1:
                        question = "Os compostos pertencem a mesma função e a mesma cadeia mas se diferenciam pela posição de um radical";
                        break;
                    case 2:
                        question = "Os compostos apresentam a mesma função e a mesma cadeia mas há deslocamento de um heteroátomo";
                        break;
                    case 3:
                        question = "Os compostos diferem pela função orgânica";
                        break;
                    case 4:
                        question = "Caso particular de isomeria de função onde os compostos coexistem. Pode ocorrer entre aldeído e enol ou entre cetona e enol";
                        break;
                    case 5:
                        question = "Ocorre em compostos de cadeia insaturada (somente dupla) e que apresente ligantes diferentes nos carbonos da dupla ligação";
                        break;
                    case 6:
                        question = "Ocorre quando o composto apresenta carbono assimétrico";
                        break;
                }
            else
                switch (questionNumber)
                {
                    case 0:
                        question = "";
                        break;
                    case 1:
                        question = "";
                        break;
                    case 2:
                        question = "";
                        break;
                    case 3:
                        question = "";
                        break;
                    case 4:
                        question = "";
                        break;
                    case 5:
                        question = "";
                        break;
                    case 6:
                        question = "";
                        break;
                    case 7:
                        question = "";
                        break;
                    case 8:
                        question = "";
                        break;
                    case 9:
                        question = "";
                        break;
                    case 10:
                        question = "";
                        break;
                    case 11:
                        question = "";
                        break;
                    case 12:
                        question = "";
                        break;
                    case 13:
                        question = "";
                        break;
                    case 14:
                        question = "";
                        break;
                    case 15:
                        question = "";
                        break;
                    case 16:
                        question = "";
                        break;
                    case 17:
                        question = "";
                        break;
                    case 18:
                        question = "";
                        break;
                    case 19:
                        question = "";
                        break;
                }

            Console.WriteLine(question);
        }

        string SetAnswer(int questionNumber, QuestionType questionType)
        {
            var answer = "";

            if (questionType == QuestionType.Theory)
                switch (questionNumber)
                {
                    case 0:
                        answer = "Isomeria de Cadeia/Cadeia";
                        break;
                    case 1:
                        answer = "Isomeria de Posição/Posição";
                        break;
                    case 2:
                        answer = "Isomeria de Compensação/Compensação/Metameria";
                        break;
                    case 3:
                        answer = "Isomeria de Função/Função";
                        break;
                    case 4:
                        answer = "Tautomeria";
                        break;
                    case 5:
                        answer = "Isomeria Geométrica/Geométrica";
                        break;
                    case 6:
                        answer = "Isomeria Óptica/Óptica";
                        break;
                }

            return answer;
        }

        internal enum QuestionType
        {
            Theory,
            Exercise,
            Both
        }
    }
}
