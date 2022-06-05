# 2022-303-NomeIndefinido
<h1 align="center">⚠️Esta versão não é final, portanto está sujeita a mudança⚠️</h1>

### Integrantes do projeto:
<p>Gabriel Rodrigues Pereira, Bernardo Tavares e Almeida, Wesley Alexandre Figueiredo e Enzo Braga e Franco.</p>

# Menu Inicial
No menu de início temos o título, por enquanto improvisado e mais quatro botões com as seguintes funções:
- "Jogar": Carrega a scene que possuir um de valor index maior que a scene usada para o menu principal, nesse caso só pode ser a Scene1;
- "Configurações": Abre um novo painel com cinco opções de botão clicável: as três primeiras abrem novos painéis com ainda mais opções, a quarta terá função de trocar o idioma e a quinta de alterar a dificuldade para que pessoas com dificuldade motora ou de raciocínio possam reduzir a quantidade de reflexo necessário para jogar;
- "Créditos": Abre um novo painel simples, que possui apenas o nome dos quatro integrantes, a opção existe somente para facilitar a consulta;
- "Sair": Encerra a instância atual do jogo, funciona apenas em um projeto buildado;

## Menu de Configurações
Ao clicar na segunda opção do Menu Inicial, o painel do Menu de Configurações se abrirá. Ele possui até então cinco opções, estas são:
- "Configurações de Acessibilidade": Ao clicar, leva o jogador a um novo painel de configurações, é onde haverá opções de habilitar maior parte das funcionalidades de acessibilidade e inclusão;
- "Configurações de Audio": Ao clicar, leva o jogador a um novo painel de configurações, é onde haverá opções de costumizar as funcionalidades de áudio;
- "Configurações Gráficas": Ao clicar, leva o jogador ao painel de configurações gráficas, será possível alterar a resolução, o brilho, fullscrean ou não e etc.;
- "Idioma": Nesta opção será possível trocar entre os idiomas "Português - BR" e "English - USA", podendo talvez haver outras no futuro (Por enquanto é apenas um ```Dropdown``` com estas duas opções de linguagem);
- "Dificuldade": Este Dropdown permitirá ao jogador alternar a dificuldade, mesmo sendo recomendado que se jogue no normal, ás vezes uma dificuldade motora ou de raciocínio pode levar ao jogador por optar à uma configuração que requeira menos reflexos (Por enquanto é apenas um ```Dropdown``` com os níveis de dificuldade "Super Fácil", "Fácil", "Normal" e "Difícil");

### Menu de Acessibilidade
Ao clicar na primeira opção do Menu de Configurações, o painel de opções de Configuração de Acessibilidade se abrirá. Ele possui até então cinco opções, estas são:
- "Alto Contraste": Como muitas das opções a seguir, ainda será pensado como implementar esta funcionalidade numa futura versão do projeto, é possível que se coloque uma cor sólida de background ao invés do ambiente, atenue ainda mais as cores do jogador, inimigo, personagens e etc. e que se mude todo e qualquer painel que possua texto para contrastar ainda mais do que o normal os textos de seus fundos (Por enquanto é apenas uma ```ToggleBox```);
- "Modo Daltonismo": Implementaremos um "Modo Daltonismo" que procurará corrigir a paleta de cores do jogo para que se adeque a um dentre os três tipos que o jogador selecionar, as três opções serão Protanopia, Deuteranopia e Tritanopia, que costumam ser os casos mais comuns. É possível que coloquemos um plugin da Unity enquanto desenvolvemos o projeto, para simular e checar se tudo esta correndo como planejado, além disso, temos um daltônico na equipe 😁; (Por enquanto é apenas um ```Dropdown``` com os tipos de Daltonismo como opção);
- "Tamanho da Fonte": Para facilitar a quem possua dificuldade de leitura ou de visão ou até mesmo apenas a quem queira possuir uma melhor customização do jogo, haverá a opção de mudança do tamanho da fonte; (Por enquanto é apenas um ```Slider```);
- "Tipo da Fonte": Adcionando uma opção de mudança de fonte nas configurações, incluímos a opção de fontes neutras não serifadas quaisqueres e também a opção de fontes para disléxicos, tudo isso sem precisar largar uma fonte principal estilizada para o ambiente do jogo; (Por enquanto é apenas um ```Dropdown``` com as opções "Padrão", "Não serifada" e "Disléxica");
- "Narração": Por fim, a opção de narração ajudará a aqueles que não enxergam ou possuem visão reduzida, pretendemos configurá-la para todos os menus juntamente com uma opção de navegação por teclado. (Por enquanto é apenas uma ```ToggleBox```);

## Menu de Audio
Ao se clicar na segunda opção do Menu de Configurações, o painel de opções de Configuração de Audio se abrirá. Ele possui até então quatro sliders, estes são:
- "Volume Geral": Definirá o volume de todo o jogo, sendo a opção mais importante;
- "Volume da Música" e "Volume dos Efeitos Sonoros": definirão os outros volumes, sendo menos importantes que a primeira opção, podem ser reduzidas caso o jogador possua audição reduzida e queira prestar atenção em um som específico;
- "Outros Sons": Creio que será difícil ou que até mesmo não caiba muita inclusão via áudio para quem possua visão reduzida, devido ao gênero de jogo que almejamos, porém caso venha a ser possível, o slider para isso já existe e deve abrigar funções como ```bipes``` de áudio que alertam o jogador de inimigos ou colisões com paredes.

## Menu de Gráficos
Ao se clicar na terceira opção do Menu de Configurações, o painel de opções de Configurações Gráficas se abrirá. Ele possui até então apenas duas opções, sendo estas:
- "Tamanho da Resolução": Permitirá ao jogador definir o melhor tipo de resolução para se jogar o jogo;
- "Brilho": Permitirá ao jogador definir, por meio de um slider, a melhor quantidade de brilho para se jogar o jogo;
