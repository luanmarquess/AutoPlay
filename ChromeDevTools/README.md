# Chrome DevTools
- Exibe erros de lógica;
- Navegador monta uma representação visual do DOM, represenatação de objetos armazenados em memória;

## Elements
- Representação de todos os elementos que temonos na página HTML inspecionada;
 
## Adicionar uma classe no no elemento selecinado
- Selecionar elemento dom a se incrementado;
- Em Styles, no canto superior direito, clickar .cls e descrever a classe;
-.cls pode-se ativar e desativar uma classe já existente;

## Styles -> Properties
- Visualizar as propriedades de cada elemento;
- Hierarquia; 

## Significado cores ao passar mouse por cima do elemento
- Azul == tamanho do conteúdo do elemento 
- Verde == paddins 
- Laranja == margin

## Computed
- Representação dos valores convertidos para o nevegador de margin, border e paddin de do elemento selecionado;
- O valor não é o mesmo que está declarado no css, pois existem unidades de medida diferentes (em, px, %...). Desta forma, o valor contido na representação da aba Computed é igual a conversão do valor declarado.
![computed](img/computed.png)

- Computed também possibilita a visualização de propriedades que nosso elemento aceita alteração. Diferenciando das propriedades aplicadas pela diferença de opacity;
![computed](img/propriedades.png)

## Estilhos riscados no Style do navegador
- O risco por cima de algum comando de estilo no devtools, indica que tal estilo está sendo sobrescrito. Ou seja, o mesmo não está sendo utilizado ao renderizar a página;
![sobrescrito](img/sobrescrito.png)

## MediaQuery 
- Defermina algum estilo de acordo de acordo com algum critério. Pode ser usado para manipular elementos de acordo com a resolução do usuário/navegador;
![mediaQuery](img/mediaQuery.png)

## Erros de sitnaxe no CSS (visualizados no DevTools)
- Erros de sintaxe em alguma linha são indicados pelo simbolo :warning:

## Identificação da folha de estilo
- Devtools nos mostra qual arquivo contém o estilo aplicado em cada elemento;
- nome arquivo --> extensão --> linha;
![localizarArquivo](img/identificacao.png)

# Console

## Erros
- Erros são exibidos no console como um simbolo :x: antes da descrição.

## console.log()
- Exibe o que foi passado por parâmetro direto na aba console do DevTools;

## console.warn()
- Avisos para algo de errado acontece, porém não compromete a aplicação;

## console.assert(condição, "mensagem")
- Tipo mensagem exibida no console, para casos expecíficos;
- Ex: console.assert(x>10, "número maior que 10");

## console.group() console.groupEnd()
- Agrupa a exibição das mensagem, para facilitar a visulização/diferenciação de outras mensagens de erro;
- Ex: console.group("texto qualquer de identificação")
-     console.groupEnd();

- Todos os console.log's que estiventem entre o console.group e console,groupEnd, serão agrupados na aba console do DevTools.
- A exibição do group ao carregar a página é "aberta". 

## console.groupCollapsed()
- Mesma função do console.group(), porém a exibição default é grupo fechado. Ou seja, para exibi-lo é necessário clickar na seta antecedente a ele.

## console.table()
- Agurpa valores dentro de uma tabela;
- Sintaxe: console.table ([
    [dado1,dado2,dado3],
    [dado4,dado5,dado6]
])

- Passar alterar o nome da coluna, usa-se obejtos;
- Ex: console.table([
    {nome_coluna1:"dado_túpula1", nome_coluna2:"dado_túpula1"},
    {nome_coluna1:"dado_túpula2", nome_coluna2:"dado_túpula2"}
])

## DevTool Console Filter
- É possível filtrar as mensagens no console. Para acessar essa funcionalidade, basta clicka no icone de filtro;

## Filtro por Regex (Expressão regular);
- [0-9] == todas mensagens que possuem número de 0 a 9;
- {3} == todas mensagens que possuem no mínimo 3 números;

## Manter o histórico de Logs no console
- Para manter os logs no console do navegador, mesmo que a página seja recarregada, precisamos selecionar o check "Preserve log";
![preserve-log](img/preserve-log.png)

## $_
 - Recupera o resultado do último comando executado no console;

## $0 (Copiar elementos da aba Elements para o Console)
- Selecionar o elemento desejado na aba Elements;
- Digitar $0 na aba Console e precionar Enter;

## $ Histórico
- $ guarda um histórico dos cinco últimos elementos acessados atráves do $0;
- Para acessar, basta alterar o número subsequente ao cifrão:
    - $1 == penúltimo; 
    - $2 == antepenúltimo;
    - ...
    - $4 == primeiro.

## $()
- Busca de dom no console, com uma sintaxe mais simplificada;
![cifrao-busca](img/cifrao-busca.png)

## $$
- Busca todos os elementos passados como parâmetro;
- document.querySelectorAll() == $$()

## Histórico de comandos
- UpArrow acessa toda o histórico dos comandos anteriores;

## getEventListeners()
- Exibe todos os listeners contidos no elemetno passado como parâmetro;
![getEventListener](img/getEventListener.png)

## Elements --> Event Listeners
- Aba Event Listeners exibe todos os listeners vinculados ao elemento selecionado;
- Caso o check "Ancestors" esteja selecionado, o listeners presentes na aba, estam vinculados ao elemento selecionado e/ou ao elemento pai do elemtento selecionado;
- Exibe o arquivo que contém o listener e a linha dele;

# Sources
- Vizualizar o código fonte de tudo que foi carregado no navegador;

## Visualizar no código fonte a linha que apresenta erro
- click sobre a descrição da arquivo/linha na apresentação do erro;  

## Debug 
- Executa o código passo a passo, faciltando a visualização de possível erros;

### BreakPoint
- Click sobre a linha que deseja incluir o BreakPoint;
- Stop na execução do código ao momento em que encontrar o breakpoint;

### Executar uma linha e pular para próxima
![next-step](img/next-step.png)

## Editar o código fonte direto do Devtools
### WorkSpace
- Area de trabalho criada onde o DevTools permite alteração de arquivos;
![addFolderToWorkSpace](img/addFolderToWorkSpace.png)

- Adicionar pasta fonte;
![createFolderToDevTools ](img/createFolderToDevTools.png)

- Aceitar o pedido de permição do navegador para realizar mudanças no arquivo fonte;

## Scope
- Exibe o escopo de todas  as variáveis 
- js ao ser executado, sua primeira realização é a criação das variáveis, já alocando espaço em momória, recebendo undefined para as que ainda não receberam valor;



