Documentação - Teste de Lógica :rocket:

:mag_right: Visão Geral

Este código implementa um programa com um menu de acesso e quatro funcionalidades diferentes. O usuário pode escolher uma opção do menu digitando o número correspondente. Cada opção do menu executa uma funcionalidade específica. As funcionalidades incluem cálculo de desconto em veículos, cálculo de média ponderada de notas de alunos, verificação de tipos de triângulo e recálculo de boletos de pagamento.

:file_folder: Estrutura do Código

O código é escrito em C# e possui uma classe principal chamada Program. A função Main é o ponto de entrada do programa, onde o menu de acesso e a seleção das funcionalidades são controlados por meio de um loop do-while.

O código é dividido em quatro métodos principais, cada um responsável por uma funcionalidade específica:

ExecutarExercicio1: Realiza o cálculo de desconto em veículos com base no ano e valor informados pelo usuário.
ExecutarExercicio2: Calcula a média ponderada de notas de alunos com base em notas informadas pelo usuário e verifica se o aluno foi aprovado ou reprovado.
ExecutarExercicio3: Verifica o tipo de triângulo com base em três valores informados pelo usuário.
ExecutarExercicio4: Recalcula o valor de um boleto de pagamento com base na data de vencimento, data de pagamento e valor do boleto informados pelo usuário.

Além dos métodos principais, o código também possui funções auxiliares para obter notas de alunos, calcular média ponderada, verificar se uma data é um dia útil, verificar se uma data é um final de semana, verificar se uma data é um feriado e obter o próximo dia útil.

:arrow_forward: Fluxo de Execução

Ao iniciar o programa, o menu de acesso é exibido com as opções numéricas de 1 a 4, representando as quatro funcionalidades disponíveis. O usuário deve digitar o número correspondente à opção desejada. Em seguida, a funcionalidade correspondente é executada.

Após a execução de uma funcionalidade, o programa retorna ao menu de acesso e aguarda a próxima escolha do usuário. O loop do-while continua até que o usuário digite a opção "0" para sair do programa.

:gear: Funcionalidades

Funcionalidade 1 - Cálculo de Desconto em Veículos
Esta funcionalidade permite calcular o desconto em veículos com base no ano e valor informados pelo usuário. O programa solicita ao usuário que digite o ano do veículo e o valor do veículo. Em seguida, é aplicado um desconto de 12% se o ano for até 2000 ou 7% se for posterior a 2000. O valor do desconto e o valor a ser pago são exibidos na tela. O programa também mantém um contador de carros até 2000 e o total geral de carros.

Funcionalidade 2 - Cálculo de Média Ponderada de Notas de Alunos
Nesta funcionalidade, o usuário pode calcular a média ponderada de notas de alunos. O programa solicita ao usuário que digite o código do aluno e as três notas do aluno. Em seguida, é calculada a média ponderada considerando os pesos de cada nota (40%, 30% e 30%). Se a média for maior ou igual a 6, o aluno é considerado aprovado; caso contrário, é considerado reprovado. A média e a situação do aluno são exibidas na tela.

Funcionalidade 3 - Verificação de Tipo de Triângulo
Nesta funcionalidade, o programa verifica o tipo de triângulo com base em três valores informados pelo usuário. O usuário deve digitar os três valores representando os lados do triângulo. O programa verifica se os valores formam um triângulo válido e, em caso afirmativo, determina se o triângulo é equilátero, isósceles ou escaleno. O resultado é exibido na tela.

Funcionalidade 4 - Recálculo de Boleto de Pagamento
Nesta funcionalidade, o programa permite recalcular o valor de um boleto de pagamento com base na data de vencimento, data de pagamento e valor original do boleto informados pelo usuário. O programa verifica se a data de pagamento é posterior à data de vencimento e, em caso afirmativo, aplica uma multa de R$ 2,00 e R$ 0,03 por dia (valores fixos). O programa também verifica se a data de pagamento é um dia útil e, se não for, ajusta a data para o próximo dia útil. O valor recalculado e a nova data de pagamento são exibidos na tela.

:memo: Considerações Finais

Este código implementa um programa com um menu de acesso e quatro funcionalidades diferentes. As funcionalidades abrangem cálculos de desconto em veículos, média ponderada de notas de alunos, verificação de tipos de triângulo e recálculo de boletos de pagamento. O código pode ser estendido e aprimorado para adicionar mais funcionalidades ou para atender a requisitos específicos.
