using System;

class Program
{
    static void Main()
    {
        int opcao;

        do
        {
            Console.WriteLine("Menu de Acesso");
            Console.WriteLine("1 - Exercício 1");
            Console.WriteLine("2 - Exercício 2");
            Console.WriteLine("3 - Exercício 3");
            Console.WriteLine("4 - Exercício 4");
            Console.WriteLine("0 - Sair");
            Console.WriteLine();
            Console.Write("Digite a opção desejada: ");

            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                Console.WriteLine();
                opcao = -1;
            }
            else
            {
                Console.WriteLine();

                switch (opcao)
                {
                    case 1:
                        ExecutarExercicio1();
                        break;
                    case 2:
                        ExecutarExercicio2();
                        break;
                    case 3:
                        ExecutarExercicio3();
                        break;
                    case 4:
                        ExecutarExercicio4();
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        Console.WriteLine();
                        opcao = -1;
                        break;
                }

                Console.WriteLine();
            }

        } while (opcao != 0);
    }

    static void ExecutarExercicio1()
    {
        do
        {
            int ano;
            bool anoValido;

            do
            {
                Console.Write("Digite o ano do veículo: ");
                anoValido = int.TryParse(Console.ReadLine(), out ano);

                if (!anoValido)
                {
                    Console.WriteLine("Ano inválido. Por favor, digite um valor numérico válido.");
                }
            } while (!anoValido);

            double desconto = (ano <= 2000) ? 0.12 : 0.07;

            double valor;
            bool valorValido;

            do
            {
                Console.Write("Digite o valor do veículo: R$");
                valorValido = double.TryParse(Console.ReadLine(), out valor);

                if (!valorValido)
                {
                    Console.WriteLine("Valor inválido. Por favor, digite um valor numérico válido.");
                }
            } while (!valorValido);

            double valorDesconto = valor * desconto;
            double valorFinal = valor - valorDesconto;

            Console.WriteLine("Desconto: R$" + valorDesconto.ToString("F2"));
            Console.WriteLine("Valor a ser pago: R$" + valorFinal.ToString("F2"));
            Console.WriteLine();

            Console.Write("Deseja continuar calculando desconto? (S/N): ");
            char continuar = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (continuar != 'S' && continuar != 'N')
            {
                Console.WriteLine("Opção inválida! Por favor, insira 'S' para continuar ou 'N' para sair.");
                Console.WriteLine();
            }

            if (continuar != 'S')
            {
                break;
            }

        } while (true);
        return;
    }

    static void ExecutarExercicio2()
    {
        do
        {
            int codigoAluno;
            bool codigoValido;

            do
            {
                Console.Write("Digite o código do aluno: ");
                codigoValido = int.TryParse(Console.ReadLine(), out codigoAluno);

                if (!codigoValido)
                {
                    Console.WriteLine("Código inválido. Por favor, digite um valor numérico válido.");
                }
            } while (!codigoValido);

            double[] notas = ObterNotasAluno();

            double media = CalcularMediaPonderada(notas);

            Console.WriteLine();
            Console.WriteLine("Aluno: " + codigoAluno);
            Console.WriteLine("Notas: " + string.Join(", ", notas));
            Console.WriteLine("Média: " + media.ToString("F2"));
            Console.WriteLine(media >= 6 ? "APROVADO" : "REPROVADO");
            Console.WriteLine();

            Console.Write("Deseja continuar calculando desconto? (S/N): ");
            char continuar = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (continuar != 'S' && continuar != 'N')
            {
                Console.WriteLine("Opção inválida! Por favor, insira 'S' para continuar ou 'N' para sair.");
                Console.WriteLine();
            }

            if (continuar != 'S')
            {
                break;
            }

        } while (true);
        return;
    }

    static double[] ObterNotasAluno()
    {
        double[] notas = new double[3];

        for (int i = 0; i < 3; i++)
        {
            bool notaValida;
            do
            {
                Console.Write("Digite a nota {0} do aluno: ", i + 1);
                notaValida = double.TryParse(Console.ReadLine(), out notas[i]);

                if (!notaValida)
                {
                    Console.WriteLine("Nota inválida. Por favor, digite um valor numérico válido.");
                }
            } while (!notaValida);
        }
        return notas;
    }

    static double CalcularMediaPonderada(double[] notas)
    {
        double maiorNota = Math.Max(notas[0], Math.Max(notas[1], notas[2]));
        double media = (maiorNota * 4 + (notas[0] + notas[1] + notas[2] - maiorNota) * 3) / 10;
        return media;
    }

    //A) a = 1, b = 2, c = 3 - Triângulo Escaleno
    //B) a = 3, b = 4, c = 5 - Triângulo Escaleno
    //C) a = 2, b = 2, c = 4 - Triângulo Isósceles
    //D) a = 4, b = 4, c = 4 - Triângulo Equilátero
    //E) a = 5, b = 3, c = 3 - Triângulo Isósceles
    static void ExecutarExercicio3()
    {
        int a, b, c;
        string mens = string.Empty;

        do
        {
            Console.WriteLine("Informe o valor de a:");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Valor inválido. Informe novamente o valor de a:");
            }

            Console.WriteLine("Informe o valor de b:");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Valor inválido. Informe novamente o valor de b:");
            }

            Console.WriteLine("Informe o valor de c:");
            while (!int.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Valor inválido. Informe novamente o valor de c:");
            }

            if (a < b + c && b < a + c && c < a + b && a == b && b == c)
            {
                mens = "Triângulo Equilátero";
            }
            else if (a == b || b == c || a == c)
            {
                mens = "Triângulo Isósceles";
            }
            else
            {
                mens = "Triângulo Escaleno";
            }

            Console.WriteLine(mens);
            Console.WriteLine();
            
            Console.Write("Deseja continuar verificando os triângulo? (S/N): ");
            char continuar = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (continuar != 'S' && continuar != 'N')
            {
                Console.WriteLine("Opção inválida! Por favor, insira 'S' para continuar ou 'N' para sair.");
                Console.WriteLine();
            }

            if (continuar != 'S')
            {
                break;
            }

        } while (true);
        return;    
    }

    static void ExecutarExercicio4()
    {
        DateTime dataVencimento, dataPagamento;
        decimal valorBoleto, valorRecalculado, valorJuros;
        const decimal valorJurosPorDia = 0.03m;
        const decimal valorMulta = 2.00m;

        do
        {

        Console.WriteLine("Recálculo de Boletos");
        Console.WriteLine("--------------------");

        Console.Write("Informe a data de vencimento (dd/mm/aaaa): ");
        if (!DateTime.TryParse(Console.ReadLine(), out dataVencimento))
        {
            Console.WriteLine("Data de vencimento inválida. Encerrando programa.");
            return;
        }

        Console.Write("Informe a data de pagamento (dd/mm/aaaa): ");
        if (!DateTime.TryParse(Console.ReadLine(), out dataPagamento))
        {
            Console.WriteLine("Data de pagamento inválida. Encerrando programa.");
            return;
        }

        Console.Write("Informe o valor do boleto: R$");
        if (!decimal.TryParse(Console.ReadLine(), out valorBoleto))
        {
            Console.WriteLine("Valor do boleto inválido. Encerrando programa.");
            return;
        }

        valorRecalculado = valorBoleto;

        if (dataPagamento < dataVencimento)
        {
            Console.WriteLine("Pagamento anterior ao vencimento. Não serão cobrados juros nem multa.");
            Console.WriteLine("Valor do boleto recalculado: R$" + valorRecalculado.ToString("F2"));
            return;
        }

        bool vencimentoDiaUtil = VerificarDiaUtil(dataVencimento);

        bool mesmoDia = dataPagamento.Date == dataVencimento.Date;

        bool finalDeSemanaOuFeriado = VerificarFinalDeSemana(dataVencimento) || VerificarFeriado(dataVencimento);

        if ((finalDeSemanaOuFeriado && dataPagamento.Date == ObterProximoDiaUtil(dataVencimento).Date) ||
            (finalDeSemanaOuFeriado && mesmoDia) ||
            (!finalDeSemanaOuFeriado && vencimentoDiaUtil && dataPagamento.Date == ObterProximoDiaUtil(dataVencimento).Date))
        {
            Console.WriteLine("Pagamento no próximo dia útil. Não serão cobrados juros nem multa.");
            Console.WriteLine("Valor do boleto recalculado: R$" + valorRecalculado.ToString("F2"));
            return;
        }
        else if (finalDeSemanaOuFeriado && dataPagamento.Date > ObterProximoDiaUtil(dataVencimento).Date)
        {
            TimeSpan diasAtraso = dataPagamento.Date - ObterProximoDiaUtil(dataVencimento).Date;
            int totalDiasAtraso = diasAtraso.Days;
            valorJuros = (totalDiasAtraso * valorJurosPorDia) + valorMulta;
        }
        else if (!finalDeSemanaOuFeriado && vencimentoDiaUtil && dataPagamento.Date > ObterProximoDiaUtil(dataVencimento).Date)
        {
            TimeSpan diasAtraso = dataPagamento.Date - ObterProximoDiaUtil(dataVencimento).Date;
            int totalDiasAtraso = diasAtraso.Days;
            valorJuros = (totalDiasAtraso * valorJurosPorDia) + valorMulta;
        }
        else
        {
            TimeSpan diasAtraso = dataPagamento.Date - dataVencimento.Date;
            int totalDiasAtraso = diasAtraso.Days;
            valorJuros = (totalDiasAtraso * valorJurosPorDia) + valorMulta;
        }

        valorRecalculado += valorJuros;

        Console.WriteLine("Valor do boleto recalculado: R$" + valorRecalculado.ToString("F2"));
        Console.WriteLine("Valor total dos juros: R$" + valorJuros.ToString("F2"));
        Console.WriteLine();

        Console.Write("Deseja continuar recalculando boletos? (S/N): ");
        char continuar = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (continuar != 'S' && continuar != 'N')
            {
                Console.WriteLine("Opção inválida! Por favor, insira 'S' para continuar ou 'N' para sair.");
                Console.WriteLine();
            }

            if (continuar != 'S')
            {
                break;
            }

        } while (true);
        return;
    }

    static bool VerificarFinalDeSemana(DateTime data)
    {
        return data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday;
    }

    static bool VerificarFeriado(DateTime data)
    {
        if (data.Month == 12 && data.Day == 25)
        {
            return true;
        }

        return false;
    }

    static bool VerificarDiaUtil(DateTime data)
    {
        return !VerificarFinalDeSemana(data) && !VerificarFeriado(data);
    }

    static DateTime ObterProximoDiaUtil(DateTime data)
    {
        do
        {
            data = data.AddDays(1);
        } while (!VerificarDiaUtil(data));

        return data;
    }

    //----- Portugol -----
    // algoritmo "<RecalculoBoleto>"
    // data vencimentoOriginal, vencimentoNovo, dataAtual
    // real valorBoleto, valorRecalculado, valorJuros
    // inteiro numDias, diasUteis

    // mostrar("Informe a data de vencimento original: ")
    // ler(vencimentoOriginal)
    // mostrar("Informe a data de vencimento nova (data de pagamento): ")
    // ler(vencimentoNovo)
    // mostrar("Informe o valor do boleto: ")
    // ler(valorBoleto)

    // numDias <- vencimentoNovo - vencimentoOriginal
    // dataAtual <- vencimentoOriginal
    // diasUteis <- 0
    // valorJuros <- 0

    // enquanto (numDias > 0) faça
    //     se (VerificaFeriado(dataAtual) OU VerificaFinalDeSemana(dataAtual)) então
    //         dataAtual <- dataAtual + 1
    //     senao
    //         diasUteis <- diasUteis + 1
    //         valorJuros <- valorJuros + 0.03
    //         dataAtual <- dataAtual + 1
    //     fim-se
    //     numDias <- numDias - 1
    // fim-enquanto

    // valorRecalculado <- valorBoleto + valorJuros + 2
    // mostrar("Valor do boleto recalculado: R$ ", valorRecalculado)
    // mostrar("Valor total dos juros do período: R$ ", valorJuros)

    // finalgoritmo
}