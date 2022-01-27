using System;
using System.Collections.Generic;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.Fundamentos;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.API;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolacao - Fundamentos", Interpolacao.Executar},
                {"Notacao Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operadore Ternário - Fundamentos", OperadorTernario.Executar},

                //Estruturas de Controle
                {"Estrutura If - Estruturas De Controle", EstruturaIf.Executar},
                {"Estrutura If Else - Estruturas De Controle", EstruturaIfElse.Executar},
                {"Estrutura If Else If - Estruturas De Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas De Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas De Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas De Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas De Controle", EstruturaFor.Executar},
                {"Estrutura Foreach - Estruturas De Controle", EstruturaForEach.Executar},
                {"Usando Break - Estruturas De Controle", UsandoOBreak.Executar},
                {"Usando Continue - Estruturas De Controle", UsandoContinue.Executar},

                // Classes & Métodos
                {"Membros - Classes & Métodos", Membros.Executar},
                {"Construtores - Classes & Métodos", Construtores.Executar},
                {"Metodos com retorno - Classes & Métodos", MetodosComRetorno.Executar},
                {"Metodos Estáticos - Classes & Métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes & Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes & Métodos", DesafioAtributo.Executar},
                {"Params - Classes & Métodos", Params.Executar},
                {"Parametros Nomeados - Classes & Métodos", ParametrosNomeados.Executar},
                {"Getters and Setters - Classes & Métodos", GetSet.Executar},
                {"Propriedades - Classes & Métodos", Propriedades.Executar},
                {"Readonly - Classes & Métodos", Readonly.Executar},
                {"Enum - Classes & Métodos", ExemploEnum.Executar},
                {"Struct - Classes & Métodos", ExemploStruct.Executar},
                {"Struct vs Classe - Classes & Métodos", StructVsClasse.Executar},
                {"Valor vs Referência - Classes & Métodos", ValorVsReferencia.Executar},
                {"Parametros por Referência - Classes & Métodos", ParametrosPorReferencia.Executar},
                {"Parâmetro com valor padrão- Classes & Métodos", ParametroPadrao.Executar},

                // Coleções
                {"Arrays - Coleções", Arrays.Executar},
                {"Lists - Coleções", ColecoesList.Executar},
                {"Array List - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack- Coleções", ColecaoStack.Executar},
                {"Dictionary - Coleções", ColecoesDictionary.Executar},


                //Orientação a Objeto
                {"Heranca - Orientação a Objetos", Heranca.Executar},
                {"Usando o This - Orientação a Objetos", ConstrutorThis.Executar},
                {"Encapsulamento - Orientação a Objetos", OO.Encapsulamento.Executar},
                {"Polimorfismo - Orientação a Objetos", Polimorfismo.Executar},
                {"Abstract - Orientação a Objetos", Abstract.Executar},
                {"Interface - Orientação a Objetos", Interface.Executar},
                {"Sealed - Orientação a Objetos", Sealed.Executar},

                // Métodos e Funções
                {"Exemplo Lambda - Métodos e Funções", ExemploLambda.Executar},
                {"Lambda com Delegate- Métodos e Funções", LambdasDelegate.Executar},
                {"Usando Delegate- Métodos e Funções", UsandoDelegate.Executar},
                {"Delegates com Função anônima- Métodos e Funções", DelegateFuncAnonima.Executar},
                {"Delegates com Parâmetros - Métodos e Funções", DelegatesComParametros.Executar},
                {"Métodos de Extensão - Métodos e Funções", MetodosDeExtensao.Executar},

                // Exceções
                {"Primeira Exceção - Exceções", PrimeiraExcecao.Executar},
                {"Exceções Personalizadas - Exceções", ExcecoesPersonalizadas.Executar},

                // API
                {"Primeiro Arquivo - API", PrimeiroArquivo.Executar},
                {"Lendo arquivos - API", LendoArquivos.Executar},

                // Tópicos Avançados
                {"LINQ #01 - Tópicos Avançados", LINQ1.Executar},
                {"LINQ #02 - Tópicos Avançados", LINQ2.Executar},
                {"Nullables - Tópicos Avançados", Nullables.Executar},
                {"Dynamics - Tópicos Avançados", Dynamics.Executar},
                {"Generics - Tópicos Avançados", Genericos.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}