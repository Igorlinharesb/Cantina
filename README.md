***
<h1 align="right" > Cantina do Tio Bill

<br>
<br>

<h2 align="right" >Documento de Sistema<br> V.0.1
<br>
<br>
<br>
<br>
<br>
<br>

Histórico de Revisões
---------------------

  |**Data**    | **Versão** |  **Descrição**                                                                        |    **Autor**   |
  |------------|------------| --------------------------------------------------------------------------------------|----------------|
  | 06/09/2020 | 0.1        | Cadastro, e exclusão de pedidos e geração de relatório de vendas                      | @Igorlinharesb |
  | Em breve   | 0.2        | Armazenar datas dos pedidos                                                           | @IgorLinharesb |
  | Em breve   | 0.3        | Cadastro de clientes                                                                  | @Igorlinharesb |
  | Em breve   | 0.4        | Gerar relatórios elaborados, com filtros e gráficos                                   | @Igorlinharesb |


Sumário
=======
 1. Introdução<br>
    1.1 Visão Geral<br>
    1.2 Descriçao Geral do Sistema<br>

 2. Ferramentas Utilizadas no Desenvolvimento<br>
 3. Funcionalidades<br>
 4. Uso do Sistema<br>
    4.1 Cadastro de Pedidos<br>
    4.2 Listagem de Pedidos<br>
    4.3 Alteração e Exclusão de Pedidos<br>
    4.4 Geração de Relatório de Vendas<br>
    
    
### 1. Introdução
-----------

##### 1.1 Visão Geral

<p> Este projeto está focado no usuário que necessita de uma interface amigável. Promovendo por meio da simplicidade de layout a descomplexidade no uso, facilidade até mesmo ao mais inexperiente usuário. Este projeto traz o
desenvolvimento de um sistema de gerenciamento de pós-graduação, de forma a
facilitar os processos em um sistema computacional simples e fácil de usar. Este sistema deve fazer com que o processo de registro e acompanhamento de vendas seja o mais automatizado possível. </p>

##### 1.2 Descrição Geral do sistema

<p></p>
<p>O sistema a ser desenvolvido é voltado para
o gerenciamento de vendas de quentinhas da Cantina do Tio Bill. O mesmo deve trazer funcionalidades como cadastro, alteração e exclusão de pedidos e geração de relatórios automatizados.</p>

### 2. Ferramentas
------------

* **Conexão com o banco de dados:** Para o desenvolvimento desse sistema foi utilizado o banco de dados relacional SQL Server.

* **Extensões Visual Studio:** Para o desenvolvimento desse sistema foi utilizada a extensão *Microsoft RDLC Report Designer para Visual Studio* para geração de relatórios.

* **Pacotes Nuget:** *Microsoft Report Viewer Control* para .Net Windows Forms e *Entity Framework* como ferramenta ORM.

### 3. Funcionalidades
------------

* **Cadastro de Pedidos:** Cadastro de novos pedidos.
* **Listagem de Pedidos:** Listagem de todos os pedidos cadastrados.
* **Alteração de Pedidos:** Alteração de valores de um pedido cadastrado.
* **Exclusão de Pedidos:** Exclusão de um pedido cadastrado.
* **Geração de Relatório de Vendas:** Geração de um relatório com todos os pedidos cadastrados.

### 4. Uso do Sistema:
------------


##### 4.1 Página Inicial
  ![Tela Inicial](https://github.com/Igorlinharesb/Cantina/blob/master/Imagens/01-Tela%20Inicial.png)

  ##### 4.2 Cadastro de Pedidos
  <p> Para cadastro de novos pedidos basta o usuário preencher os locais mostrados abaixo na imagem corretamente, e clicar no botão "Salvar Pedido". </p>
  
  ![Cadastro de Pedidos](https://github.com/Igorlinharesb/Cantina/blob/master/Imagens/02-Pedido-Preenchido.png)
  
  <p> Caso o usuário peencha os locais corretamente, após clicar no botão de "Salvar Pedido" deve ser mostrada uma caixa de mensagem, solicitando a confirmação do cadastro, conforme é mostrado na imagem abaixo. </p>
  
  ![Confirmação de Pedido](https://github.com/Igorlinharesb/Cantina/blob/master/Imagens/03-Confirma%C3%A7%C3%A3oPedido.png)
  
  <p> E por fim é mostrado uma mensagem confirmando que o pedido de fato foi cadastrado no banco de dados.</p>
  
  ![Pedido Salvo](https://github.com/Igorlinharesb/Cantina/blob/master/Imagens/04-Pedido-Salvo.png)
  
  <p>Não é possível realizar o cadastro de pedidos cujo o nome do cliente se encontra nulo. Caso o usuário tente fazer isso, será mostrada uma mensagem conforme a imagem abaixo:</p>
  
  ![Cliente Vazio](https://github.com/Igorlinharesb/Cantina/blob/master/Imagens/5%20-%20Usuario%20Vazio.png)
  
  <p> Também não é possível que o cliente cadastre um pedido com 0 quentinhas. Caso o usuário tente fazer isso será mostrada uma mensagem conforme a imagem abaixo: </p>
  ![Pedido Vazio](https://github.com/Igorlinharesb/Cantina/blob/master/Imagens/6%20-%20Quentinhas%20Vazias.png)
  
  
  ##### 4.3 Listagem de Pedidos
  <p>Na página inicial do sistema também é mostrada a lista de pedidos cadastrados, conforme a imagem abaixo:</p>
  
  ![Pedido Salvo](https://github.com/Igorlinharesb/Cantina/blob/master/Imagens/04-Pedido-Salvo.png)

  ##### 4.3 Alteração e Exclusão de Pedidos
  <p> Caso seja cadastrado algum pedido com erros do banco de dados, o usuário tem a opção de editar ou excluir o pedido. Para isso, basta o usuário dar um duplo clique na linha do pedido o qual ele deseja editar, e logo em seguida os dados do pedido serão preenchidos no local do cadastro, o botão de "Salvar Pedido" muda para "Atualizar Pedido", e o botão "Excluir Pedido" é habilitado. A imagem abaixo ilustra o processo:</p>
  
  ![Editar Pedido](https://github.com/Igorlinharesb/Cantina/blob/master/Imagens/8%20-%20Editar%20Pedido.png)
  
  <p>Caso o usuário queira editar o pedido, basta atualizar os campos preenchidos, e clicar no botão "Atualizar Pedido". Após isso, assim como no cadastro de pedidos, é mostrada uma caixa de confirmação da alteração:</p>
  
  ![Confirma Edição](https://github.com/Igorlinharesb/Cantina/blob/master/Imagens/8.2%20%20-%20Confirma%20Edi%C3%A7%C3%A3o.png)
  
  <p> Caso o usuário opte por excluir o registro, basta clicar no botão "Excluir Pedido". Apóis isso, é mostrada uma caixa de confirmação da exclusão, conforme mostrado abaixo: </p>
  
  ![Confirma Exclusão](https://github.com/Igorlinharesb/Cantina/blob/master/Imagens/8.3%20-%20Confirma%20Exclus%C3%A3o.png)
  
  ![Exclusão Confirmada](https://github.com/Igorlinharesb/Cantina/blob/master/Imagens/8.4%20-%20Excluido.png)
   

  ##### 4.4 Geração de Relatório de Vendas
  <p> O usuário também tem a opção de gerar um relatório de vendas. Para isso, basta clicar no botão "Relatório de Vendas". </p>

![Gerar relatorio](https://github.com/Igorlinharesb/Cantina/blob/master/Imagens/11%20-%20Gera%C3%A7%C3%A3o%20de%20Relat%C3%B3rio.png)

<p> Após isso, é mostrada uma nova tela ao usuário com um relatório contendo todos os pedidos, em que o usuário tem a opção de visualizar para impressão, exportar para arquivos .pdf, .xlsx e .docx, conforme mostrado abaixo: </p>
 
![Gerar relatorio](https://github.com/Igorlinharesb/Cantina/blob/master/Imagens/12%20-%20Relat%C3%B3rio.png)
 








