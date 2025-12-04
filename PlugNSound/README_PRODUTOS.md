# Sistema de Gerenciamento - PlugNSound ??

## ?? Visão Geral

Sistema completo de gerenciamento para a loja PlugNSound com navegação por abas, dashboard interativo com cards de produtos e múltiplos módulos.

## ? Novidades

- ? **Inicia automaticamente na Dashboard**
- ? **Cards de produtos bonitos e arredondados**
- ? **Estatísticas em tempo real**
- ? **Efeito hover nos cards**
- ? **Sistema centralizado de gerenciamento de produtos**

## ?? Módulos Disponíveis

### 1. Dashboard ??
**Página inicial (abre automaticamente ao iniciar)**

Apresenta:
- **3 Cards de Estatísticas** com cores vibrantes:
  - Total de Produtos (roxo)
  - Total de Itens em Estoque (rosa)
  - Valor Total em Estoque (coral)
  
- **Grid de Cards de Produtos** com:
  - Design moderno com bordas arredondadas
  - Badge de categoria colorido
  - Preço em destaque (Euros)
  - Quantidade em estoque
  - Efeito hover interativo

### 2. Products (Produtos) ??
Sistema completo de gerenciamento de produtos com:
- Adicionar, editar e remover produtos
- Controle de estoque
- Organização por categorias
- Preços em **Euros (€)**
- Sincronização automática com a Dashboard

### 3. Customers (Clientes) ??
Módulo de gerenciamento de clientes.

### 4. Marketing ??
Ferramentas de marketing e campanhas.

### 5. Settings ??
Configurações do sistema.

### 6. About ??
Informações sobre o sistema - Versão 1.0.0

## ?? Como Usar

### Iniciando o Sistema

1. Execute o aplicativo PlugNSound
2. O sistema **abre automaticamente na Dashboard**
3. Você verá imediatamente os produtos disponíveis em cards bonitos

### Navegação entre Módulos

1. No menu lateral esquerdo, clique em qualquer botão para acessar o módulo correspondente
2. O sistema **automaticamente fecha o módulo anterior** e abre o novo
3. Clique no logo no topo para voltar à tela inicial (fecha todos os módulos)

### Dashboard - Visualização de Produtos

Na Dashboard você verá:

#### Estatísticas no Topo
- **Total Produtos**: Quantidade total de produtos cadastrados
- **Total Itens Estoque**: Soma de todos os itens em estoque
- **Valor Total em Estoque**: Valor monetário total (produto × quantidade)

#### Cards de Produtos
Cada produto é exibido em um card com:
- **Badge de Categoria** (topo esquerdo, fundo roxo)
- **Nome do Produto** (título em negrito)
- **Preço em Euros** (destaque grande)
- **Quantidade em Estoque** (rodapé)

**Interatividade:**
- Passe o mouse sobre o card para ver efeito hover
- Fundo muda para cinza claro
- Borda roxa sutil aparece
- Cursor vira "mãozinha"

### Gerenciar Produtos

1. Clique no botão **"Products"** (ícone de carrinho de compras)
2. A tela de gerenciamento de produtos será aberta

#### Adicionar um Novo Produto

1. Preencha os campos obrigatórios:
   - **Nome**: Nome do produto
   - **Descrição**: Descrição detalhada do produto (opcional)
   - **Preço**: Valor do produto em **Euros (€)**
   - **Quantidade**: Quantidade em estoque
   - **Categoria**: Categoria do produto

2. Clique no botão **"Adicionar"** (azul)
3. O produto será adicionado à lista
4. **Automaticamente sincronizado com a Dashboard!**

#### Editar um Produto

1. Na lista de produtos, clique no produto que deseja editar
2. Os dados do produto serão carregados nos campos
3. Modifique as informações desejadas
4. Clique no botão **"Editar"** (rosa)
5. O produto será atualizado na lista e na Dashboard

#### Remover um Produto

1. Na lista de produtos, clique no produto que deseja remover
2. Clique no botão **"Remover"** (vermelho)
3. Confirme a ação na janela de confirmação
4. O produto será removido da lista e da Dashboard

## ?? Produtos de Exemplo

O sistema já vem com 6 produtos de exemplo (preços em Euros):

1. **Fone de Ouvido Bluetooth** - € 49,90 | 15 un. | Áudio
2. **Caixa de Som Portátil** - € 34,90 | 20 un. | Áudio
3. **Microfone USB** - € 59,90 | 10 un. | Áudio
4. **Placa de Som USB** - € 149,90 | 5 un. | Áudio
5. **Cabo XLR Premium** - € 24,90 | 30 un. | Acessórios
6. **Suporte de Mesa para Microfone** - € 39,90 | 12 un. | Acessórios

## ?? Funcionalidades

### Sistema Geral
- ? Navegação fluida entre módulos
- ? **Inicia automaticamente na Dashboard**
- ? Fechamento automático do módulo anterior ao abrir um novo
- ? Interface moderna e intuitiva
- ? Menu lateral com ícones coloridos
- ? Barra de título personalizável por módulo

### Dashboard
- ? **Cards de produtos com design arredondado**
- ? **Efeito hover interativo**
- ? **Estatísticas em tempo real**
- ? Layout responsivo com FlowLayoutPanel
- ? Scroll automático para muitos produtos
- ? Cores vibrantes e modernas
- ? **Sincronização automática com módulo de produtos**

### Módulo de Produtos
- ? Adicionar produtos
- ? Editar produtos existentes
- ? Remover produtos
- ? Visualizar lista completa de produtos
- ? Validação de campos obrigatórios
- ? Controle de estoque
- ? Organização por categorias
- ? **Preços em Euros (€)**
- ? Interface intuitiva e colorida
- ? **Gerenciamento centralizado com ProdutoManager**

## ?? Arquitetura

### Arquivos do Sistema

#### Formulários Principais
- **`Form2.cs`**: Formulário principal com menu de navegação
- **`Form2.Designer.cs`**: Design da interface principal

#### Módulos
- **`FormDashboard.cs`**: Dashboard interativo com cards de produtos
- **`FormProdutos.cs`**: Gerenciamento de produtos
- **`FormCustomers.cs`**: Gerenciamento de clientes
- **`FormMarketing.cs`**: Ferramentas de marketing
- **`FormSettings.cs`**: Configurações do sistema
- **`FormAbout.cs`**: Informações sobre o sistema

#### Componentes
- **`ProdutoCard.cs`**: Componente visual de card de produto
- **`ProdutoCard.Designer.cs`**: Design do card

#### Modelos e Gerenciamento
- **`Produto.cs`**: Classe modelo que representa um produto
- **`ProdutoManager.cs`**: Gerenciador centralizado de produtos

### Como Funciona a Navegação

Quando você clica em um botão do menu:
1. O botão é ativado visualmente (cor e ícone mudam)
2. O formulário anterior é **fechado automaticamente**
3. O novo formulário é aberto no `panelDesktop`
4. A barra de título atualiza com o ícone e nome do módulo

### ProdutoManager - Sistema Centralizado

O `ProdutoManager` é uma classe estática que:
- Mantém a lista de produtos em memória
- Garante que todos os módulos vejam os mesmos dados
- Fornece métodos para: ObterTodosProdutos(), AdicionarProduto(), AtualizarProduto(), RemoverProduto()
- Carrega produtos de exemplo automaticamente

## ?? Design dos Cards

### Características Visuais
- **Bordas arredondadas** (radius de 15px)
- **Background branco** com sombra sutil
- **Badge de categoria** com fundo roxo
- **Tipografia hierárquica**: Nome (11pt bold), Preço (16pt bold), Estoque (9pt)
- **Cores do tema** PlugNSound

### Efeito Hover
- Background muda para cinza clarinho
- Borda roxa sutil aparece
- Cursor vira mãozinha
- Transição suave

## ?? Moeda do Sistema

O sistema utiliza **Euros (€)** como moeda padrão para todos os preços de produtos.

## ?? Próximas Melhorias (Sugestões)

- [ ] Click nos cards para ver detalhes do produto
- [ ] Filtrar produtos por categoria na Dashboard
- [ ] Busca de produtos
- [ ] Implementar funcionalidades completas nos módulos Customers, Marketing, Settings
- [ ] Persistência de dados em banco de dados
- [ ] Imagens nos cards de produtos
- [ ] Animações de transição
- [ ] Gráficos e charts na Dashboard
- [ ] Histórico de alterações
- [ ] Relatórios de estoque e vendas
- [ ] Códigos de barras
- [ ] Integração com sistema de vendas
- [ ] Multi-idioma
- [ ] Conversão de moedas
- [ ] Modo escuro

## ?? Observações

- O sistema **inicia automaticamente na Dashboard**
- Os dados são gerenciados pelo `ProdutoManager` centralizado
- Alterações em Products atualizam automaticamente a Dashboard (ao retornar)
- Todos os produtos compartilham a mesma fonte de dados
- Os cards são criados dinamicamente com base nos produtos disponíveis
- O layout é responsivo e ajusta os cards automaticamente
- **Ao mudar de aba, o formulário anterior é fechado automaticamente**

## ?? Início Rápido

1. Execute o aplicativo
2. **Dashboard abre automaticamente** com produtos em cards bonitos
3. Explore os produtos visualmente
4. Clique em "Products" para gerenciar
5. Adicione, edite ou remova produtos
6. Volte à Dashboard para ver as mudanças!

---

**Desenvolvido para PlugNSound** ??  
**Versão 1.0.0**  
**Design Moderno | Interface Intuitiva | Preços em Euros** ??
