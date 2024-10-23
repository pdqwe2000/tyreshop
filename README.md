# Tyre Shop
Sistema para Gestão de Stocks e vendas de uma oficina de pneus

Programação Orientada a Objectos

Licenciatura em Engenharia de Sistemas Informáticos (*regime pós-laboral*) 2023-24

| Número | Nome |
| -----   | ---- |
| 27990     | Pedro Duarte  |


## Organização

[doc/](./doc/)  documentação com o relatório e documentação

[src/](./src/)  Código da solução desenvolvida 

## Introdução
Este projeto foi desenvolvido como parte do programa das disciplinas de Laboratórios de Informática e Programação Imperativa.
A aplicação resultante tem como objetivo a gestão e monitorização de pacientes, visando promover hábitos alimentares saudáveis.
## Objetivo
Este projeto visa desenvolver uma solução para manipular os dados dos pacientes de um gabinete de nutrição, utilizando o paradigma de programação imperativa. A aplicação será responsável por várias funcionalidades, incluindo:
- Registo e controlo de informações alimentares dos pacientes.
- Monitoração da adesão a uma dieta saudável.
- Análise e acompanhamento do progresso nutricional.

## Estrutura do Projeto
-   [doc/](./doc)

    -   Contém a documentação do projeto.
        -   [html/](./doc/html/)
            -   Local onde a documentação gerada pelo Doxygen é armazenada.
        -   [Doxyfile](./doc/Doxyfile)
            -   Ficheiro de configuração do Doxygen para a geração da documentação.
        -   [n-04-doc.pdf](./doc/n-04-doc.pdf)
            -   Relatório do projeto da aplicação informática.
        -   [n-04-refman.pdf](./doc/n-04-refman.pdf)
            -   Documentação do projeto da aplicação informática.
-   [data/](./data)

    -   Armazena os arquivos de dados utilizados pelo programa.
        -  [dietas.txt](./data/dietas.txt)
            -   Registo das dietas dos pacientes.
        -   [pacientes.txt](./data/pacientes.txt)
            -   Informações dos pacientes.
        -   [planotnutricional.txt](./data/planonutricional.txt)
            -   Planos nutricionais aplicados.
-   [include/](./include)
    -   Contém os arquivos de cabeçalho (headers) do projeto.
        -   [main.h](./include/main.h)
            -   Arquivo header principal que conecta e declara as funções do programa em linguagem C.
-   [src/](./src)
    -   Contém os ficheiros fonte do programa em linguagem C.
        -   [main.c](./src/main.c)
            -   Ficheiro principal contendo a função `main` e a lógica principal do programa.
        -   [operacoes_menu.c](./src/operacoes_menu.c)
            -   Ficheiro com as operações relacionadas ao menu de escolhas do programa.
        -   [operacoes_opcoes.c](./src/operacoes_opcoes.c)
            -   Ficheiro com as operações relacionadas às opções / funções do programa.
-   [Makefile](Makefile)
    -   Arquivo utilizado pelo comando `make` para compilar o projeto de forma automatizada.
-   [README.md](README.md)
    -   Arquivo que contém informações básicas sobre o projeto, a sua descrição, uso e outras instruções.
-   [TrabPratico.exe](TrabPratico.exe)
    -   Executável do projeto, gerado após a compilação.

### Descrição da Estrutura

Este projeto está organizado de forma a separar claramente os componentes do código-fonte, dados e documentação.

Os diretórios *doc/* e *data/* mantêm a [documentação gerada em *Doxygen*](doc/html/index.html)  e os ficheiros de dados usados pelo programa, respetivamente.

O diretório *include/* mantém o ficheiro principal de cabeçalho que interliga todas as funções e algoritmos do projeto.

Já o diretório *src/* contém os ficheiros-fonte da aplicação, organizados de acordo com suas funcionalidades específicas.

O ficheiro *Makefile* automatiza o processo de compilação do projeto, enquanto *README.md* fornece informações básicas sobre o projeto.

Por fim, *TrabPratico.exe* é o executável gerado após a compilação do projeto.
  
## Compilação
Para a compilação e execução do programa, é apenas necessário utilizar o comando *make* a partir do diretório raíz do projeto
(por norma, n-04/).

Após a compilação do projeto, é gerado um novo executável *TrabPratico.exe*, na raíz do repositório.
## Execução / Utilização
Para executar esta aplicação, é possível de duas formas:
- Ambiente gráfico:
  - Duplo-clique no ficheiro '*TrabPratico.exe*'
- CLI / Consola:
  - Navegar para o diretório raíz do projeto, e executar '*./TrabPratico.exe*'

### Argumentos
**Nota.:** Para utilizar os argumentos, é necessário ser executado através do CLI / Consola.
- *-ajuda* para navegar diretamente para uma página de ajuda.
- *-a.txt -b.txt -c.txt* para introduzir manualmente caminhos para utilizar ficheiros diferente de dados, respetivamente aos pacientes, dietas e planos nutricionais.
Caso não inserido, utiliza os ficheiros pré-definidos pelo programa.
- *-tab* para utilizar um ficheiro separado por *tabs* e não por ponto e vírgula.

## Distribuição de Tarefas
- **Pedro Duarte:**
    - Participação na organização de dados do projeto e sua verificação.
    - Contribuição para a documentação do projeto em Doxygen.
    - Melhoramentos relacionados com funções e leitura de ficheiros.
    - Troubleshooting.
    - Adição de dados para testes de funcionamento.
    - Adição de detalhes aos printfs.
- **Tiago Vale:**
    - Planeamento da estrutura do relatório.
    - Implementação de dados para a elaboração do relatório.
    - Contribuição na elaboração do relatório.
    - Coloboração na compilação final e revisão geral do relatório.
    - Participação na organização de dados do projeto e sua verificação.
- **Miguel Areal:**
    - Planeamento da arquitetura e organização aplicacional.
    - Planeamento e execução da base inicial do projeto.
    - Resolução da solução de compilação do projeto (Makefile).
    - Contribuição na elaboração do ficheiro informativo README.md.
    - Contribuição para a documentação do projeto em Doxygen.

## Bibliografia
Durante o desenvolvimento do projeto, foram utilizadas várias referências:
- [Documentação livrarias em C](https://www.tutorialspoint.com/c_standard_library/index.htm)
- [Documentação em Doxygen](https://www.doxygen.nl/manual/docblocks.html)(https://axom.readthedocs.io/en/develop/docs/sphinx/coding_guide/sec04_header_org.html)(https://docs.rtems.org/branches/master/eng/coding-doxygen.html)
- [Fórum StackOverflow](https://stackoverflow.com)
- [Ambiente de desenvolvimento Visual Studio Code](https://code.visualstudio.com)
- Exercícios da disciplina de Programação Imperativa - Moodle IPCA LESIPL
- [Ferramenta MAKE em Windows](https://gnuwin32.sourceforge.net/packages/make.htm)
- [Compilador GCC em Windows](https://sourceforge.net/projects/mingw/files/)
- [Texmaker](https://www.xm1math.net/texmaker/).
- [Overleaf](https://www.overleaf.com/).
- [CTAN](https://ctan.org/).
- [LatexProject](https://www.latex-project.org/)
