# 2022-303-NomeIndefinido
<h1 align="center">⚠️Projeto em andamento⚠️</h1>

### Integrantes do projeto:
<p>Gabriel Rodrigues Pereira, Bernardo Tavares e Almeida, Wesley Alexandre Figueiredo e Enzo Braga e Franco.</p>

# Menu Inicial
<p align="center"><img src="https://user-images.githubusercontent.com/102994014/172288971-e0ebed71-26bb-41c1-a2e0-732d9ba1f103.png" alt="Imagem do Menu Principal"/>
<p>No menu de início temos o título, por enquanto improvisado e mais quatro principais botões com as seguintes funções:</p>
<ul>
  <li>"Jogar": Carrega a scene que possuir um de valor de índice maior que a scene usada para o menu principal, nesse caso só pode ser a Scene1;
<p align="center"><img src="https://user-images.githubusercontent.com/102994014/172288974-1cd4ad51-b9a2-45e3-a86a-60e32f9bad99.png" alt="Imagem mostrando o botão Jogar"/></br>Aqui podemos observar a ainda bem simples Scene1, criada apenas para mostrar a funcionalidade do botão em questão e das já implementadas movimentaçãoes e animações do jogador.</p></li>
  <li>"Configurações": Abre um novo painel com três botões clicáveis e dois Dropdowns, que serão explicados em breve;</li>
  <li>"Créditos": Abre um novo painel simples, que possui apenas o nome dos quatro integrantes, a opção existe somente para facilitar a consulta dos responsáveis pelo projeto;
<p align="center"><img src="https://user-images.githubusercontent.com/102994014/172288976-ae9bbe32-7274-4341-b1d8-2962c0ac4fbd.png" alt="Imagem mostrando o botão Créditos"></br>Aqui podemos observar a funcionalidade do botão, que simplesmente abre um novo painel.</p></li>
  <li>"Sair": Encerra a instância atual do jogo, funciona apenas em um projeto buildado;</li>
</ul>

## Menu de Configurações
<p align="center"><img src="https://user-images.githubusercontent.com/102994014/172288980-6125c28d-9a62-47ef-a5c9-937a7fd37e87.png" alt="Imagem mostrando o botão Configurações"/></p>
Ao clicar na segunda opção do Menu Inicial, o painel do Menu de Configurações se abrirá. Ele possui até então cinco opções, estas são:
<ul>
  <li>"Configurações de Acessibilidade": Ao clicar, leva o jogador a um novo painel de configurações, é onde haverá a maior parte das opções de habilitar as funcionalidades de acessibilidade e inclusão;</li>
  <li>"Configurações de Audio": Ao clicar, leva o jogador a um novo painel de configurações, é onde haverá opções de costumizar as funcionalidades de áudio;</li>
  <li>"Configurações Gráficas": Ao clicar, leva o jogador ao painel de configurações gráficas, é onde haverá opções de costumizar qualidade e resolução gráfica;</li>
  <li>"Idioma": Nesta opção, será possível trocar entre os idiomas "Português - BR" e "English - USA", podendo talvez haver outras no futuro (Por enquanto é apenas um ```Dropdown``` com estas duas opções de linguagem);</li>
  <li>"Dificuldade": Este Dropdown permitirá ao jogador alternar a dificuldade, mesmo sendo recomendado que se jogue no normal, ás vezes uma dificuldade motora ou de raciocínio pode levar ao jogador por optar à uma configuração que requeira menos reflexos (Por enquanto é apenas um ```Dropdown``` com os níveis de dificuldade "Super Fácil", "Fácil", "Normal" e "Difícil");</li>
</ul>

### Menu de Acessibilidade
<p align="center"><img src="https://user-images.githubusercontent.com/102994014/172288983-aa7fc0a0-51c7-499d-8acb-c74ba4e5b981.png" alt="Imagem mostrando o botão Acessibilidade" /></br><h6 align="center">O dropdown do daltonismo acabou por esconder o slider da fonte na print, porém assim é melhor observado os tipos de daltonismo</h6><p>
Ao clicar na primeira opção do Menu de Configurações, o painel de opções de Configuração de Acessibilidade se abrirá. Ele possui até então cinco opções, estas são:
<ul>
  <li>"Alto Contraste": Como muitas das opções a seguir, ainda será pensado como implementar esta funcionalidade numa futura versão do projeto, é possível que se coloque uma cor sólida de background ao invés do ambiente, atenue ainda mais as cores do jogador, inimigo, personagens e etc. e que se mude todo e qualquer painel que possua texto para contrastar ainda mais do que o normal os textos de seus fundos (Por enquanto é apenas uma ```ToggleBox```);</li>
  <li>"Modo Daltonismo": Implementaremos um "Modo Daltonismo" que procurará corrigir a paleta de cores do jogo para que se adeque a um dentre os três tipos que o jogador selecionar, as três opções, como mostradas na imagem, serão Protanopia, Deuteranopia e Tritanopia, que costumam ser os casos mais comuns. É possível que coloquemos um plugin da Unity enquanto desenvolvemos o projeto, para simular e checar se tudo esta correndo como planejado, além disso, temos um daltônico na equipe 😁; (Por enquanto é apenas um ```Dropdown``` com os tipos de Daltonismo como opção);</li>
  <li>"Tamanho da Fonte": Para facilitar a quem possua dificuldade de leitura ou de visão ou até mesmo apenas a quem queira possuir uma melhor customização do jogo, haverá a opção de mudança do tamanho da fonte; (Por enquanto é apenas um ```Slider```);</li>
  <li>"Tipo da Fonte": Adicionando uma opção de mudança de fonte nas configurações, incluímos a opção de fontes neutras não serifadas quaisqueres e também a opção de fontes para disléxicos, tudo isso sem precisar largar uma fonte principal estilizada para o ambiente do jogo; (Por enquanto é apenas um ```Dropdown``` com as opções "Padrão", "Não serifada" e "Disléxica");</li>
  <li>"Narração": Por fim, a opção de narração ajudará a aqueles que não enxergam ou possuem visão reduzida, pretendemos configurá-la para todos os menus juntamente com uma opção de navegação por teclado. (Por enquanto é apenas uma ```ToggleBox```);</li>
</ul>

### Menu de Audio
<p align="center"><img src="https://user-images.githubusercontent.com/102994014/172288988-e258d5da-0a71-4a65-9a76-e6e639e8ad66.png" alt="Imagem mostrando o botão Audio" /><p>
Ao se clicar na segunda opção do Menu de Configurações, o painel de opções de Configuração de Audio se abrirá. Ele possui até então quatro sliders, estes são:
<ul>
  <li>"Volume Geral": Definirá o volume de todo o jogo, sendo a opção mais importante;</li>
  <li>"Volume da Música" e "Volume dos Efeitos Sonoros": definirão os outros volumes, sendo menos importantes que a primeira opção, podem ser reduzidas caso o jogador possua audição reduzida e queira prestar atenção em um som específico;</li>
  <li>"Outros Sons": Creio que será difícil ou que até mesmo não caiba muita inclusão via áudio para quem possua visão reduzida, devido ao gênero de jogo que almejamos, porém caso venha a ser possível, o slider para isso já existe e deve abrigar funções como ```bipes``` de áudio que alertam o jogador de inimigos ou colisões com paredes.</li>
</ul>

### Menu de Gráficos
<p align="center"><img src="https://user-images.githubusercontent.com/102994014/172288992-311c6f89-3782-425b-ad43-4ec9d41df844.png" alt="Imagem mostrando o botão Gráficos" /><p>
Ao se clicar na terceira opção do Menu de Configurações, o painel de opções de Configurações Gráficas se abrirá. Ele possui até então três opções, sendo estas:
<ul>
  <li>"Tamanho da Resolução": Permitirá ao jogador definir o melhor tipo de resolução para se jogar o jogo, os exemplos de definição colocados por enquanto são os mais comuns de proporção 16:9 e 4:3;
  <li>"Fullscreen": Como é possível visualizar pela imagem, este dropdown permitirá ao jogador definir se prefere jogar em modo janela, janela sem borda ou em tela cheia;
  <li>"Brilho": Permitirá ao jogador definir, por meio de um slider, a melhor quantidade de brilho para se jogar o jogo;
 </ul>

# Planos futuros
<ul>
  <li>As várias das muitas opções ainda não são funcionais, visto que mal se tem um corpo de projeto bem formado, precisamos então começar a trabalhar na implementação e interpretação por parte do jogo das configurações e customizações propostas;</li>
  <li>Quanto mais autoral um jogo for, melhor, planejamos então que casa haja tempo, utilizemos assets inteiramente nossos. Atualmente o personagem, a skybox e o cenário utilizado para o menu são da <a href="https://assetstore.unity.com/">Unity Asset Store</a>, seus criadores são <a href="https://alexkim0415.wixsite.com/dungeonmason">Alex Kim</a>, <a href="https://assetstore.unity.com/publishers/4162">Render Knight</a> e <a href="https://www.artstation.com/justcreate">JustCreate</a> respectivamente e todos os direitos e créditos de suas criações vão inteiramente aos mesmos;</li>
  <li>Após termos uma melhor ideia do que gostaríamos de desenvolver, é bem capaz de que a estilização e algumas das funcionaldades deste menu mudem, talvez até mesmo de forma bastante brusca e notável.</li>
