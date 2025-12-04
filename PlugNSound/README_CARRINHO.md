# ?? Sistema de Carrinho de Compras - PlugNSound

## ?? Visão Geral

Sistema completo de **e-commerce** com carrinho de compras para a loja PlugNSound. Os clientes podem navegar pelos produtos, adicionar itens ao carrinho e finalizar suas compras.

## ? Novidades do Sistema de Carrinho

### ??? Funcionalidades de Loja
- ? **Vitrine de Produtos** - Dashboard mostra produtos disponíveis (sem informações de estoque)
- ? **Carrinho de Compras** - Adicione produtos e gerencie quantidades
- ? **Botão de Carrinho** - Sempre visível na barra de título com contador de itens
- ? **Gerenciamento de Itens** - Adicione, remova ou ajuste quantidades
- ? **Cálculo Automático** - Subtotais e total geral atualizados em tempo real
- ? **Finalização de Compra** - Processo de checkout (versão demo)

## ?? Interface da Loja

### Dashboard (Vitrine)
**O que os clientes veem:**
- ?? Total de produtos disponíveis
- ?? Categorias disponíveis  
- ?? Cards de produtos com:
  - Badge de categoria
  - Nome do produto
  - **Preço em Euros (€)**
  - Botão "?? Adicionar ao Carrinho"

**O que NÃO é mostrado:**
- ? Quantidade em estoque
- ? Valor total do estoque
- ? Informações administrativas

### Botão de Carrinho
Localizado no **canto superior direito** da barra de título:
- ?? Ícone de carrinho de compras
- **(N)** Contador de itens em tempo real
- Cor azul vibrante
- Sempre acessível de qualquer tela

## ?? Como Usar o Carrinho

### 1. Adicionar Produtos ao Carrinho

**Na Dashboard:**
1. Navegue pelos produtos em cards
2. Clique no botão **"?? Adicionar ao Carrinho"** no card do produto
3. Confirmação aparece: "Produto foi adicionado ao carrinho!"
4. **Contador do carrinho atualiza automaticamente**

### 2. Visualizar o Carrinho

1. Clique no botão **"Carrinho (N)"** no canto superior direito
2. Ver todos os itens adicionados com:
   - Nome do produto
   - Preço unitário
   - Quantidade
   - Subtotal por item
   
### 3. Gerenciar Itens no Carrinho

**Aumentar Quantidade:**
- Selecione um item na lista
- Clique em **"? Adicionar +1"**
- Quantidade aumenta em 1 unidade

**Diminuir Quantidade:**
- Selecione um item na lista
- Clique em **"? Diminuir"**
- Quantidade diminui em 1 unidade
- (Mínimo: 1 unidade)

**Remover Item:**
- Selecione um item na lista
- Clique em **"? Remover"**
- Confirme a remoção
- Item é excluído do carrinho

**Limpar Carrinho:**
- Clique em **"??? Limpar Carrinho"**
- Confirme a ação
- Todos os itens são removidos

### 4. Finalizar Compra

1. Com itens no carrinho, clique em **"? Finalizar Compra"**
2. Veja o resumo:
   - Total de itens
   - Valor total em €
3. Confirme a compra
4. **Sucesso!** Pedido confirmado (versão demo)
5. Carrinho é limpo automaticamente

## ?? Informações do Carrinho

### Painel de Totais (Rodapé Roxo)
- **Total de Produtos:** Quantidade total de itens
- **Valor Total:** Soma de todos os subtotais em €
- **Botão Finalizar:** Habilitado apenas com itens no carrinho

## ?? Design do Sistema

### Cards de Produtos
```
???????????????????????????
? [Áudio]                 ?  ? Badge categoria
?                         ?
? Fone de Ouvido         ?  ? Nome
? Bluetooth               ?
?                         ?
? € 49,90                ?  ? Preço
?                         ?
? [?? Adicionar]         ?  ? Botão azul
???????????????????????????
```

### Botão de Carrinho (Barra de Título)
```
?? Carrinho (3)
```
- Fundo azul (#18A1FB)
- Ícone de carrinho branco
- Contador entre parênteses
- Hover: Cursor vira mãozinha

## ?? Fluxo de Compra

1. **Cliente acessa a loja** ? Dashboard abre automaticamente
2. **Navega pelos produtos** ? Visualiza cards bonitos
3. **Adiciona ao carrinho** ? Clica no botão do card
4. **Contador atualiza** ? Vê quantidade no botão superior
5. **Visualiza carrinho** ? Clica no botão "Carrinho (N)"
6. **Ajusta itens** ? Adiciona/Remove/Modifica quantidades
7. **Finaliza compra** ? Clica em "? Finalizar Compra"
8. **Confirmação** ? Pedido registrado!

## ?? Funcionalidades Técnicas

### CarrinhoManager (Classe Estática)
Gerencia o carrinho globalmente:

```csharp
// Adicionar produto
CarrinhoManager.AdicionarProduto(produto, quantidade);

// Obter itens
var itens = CarrinhoManager.ObterItens();

// Atualizar quantidade
CarrinhoManager.AtualizarQuantidade(produtoId, novaQuantidade);

// Remover produto
CarrinhoManager.RemoverProduto(produtoId);

// Limpar carrinho
CarrinhoManager.LimparCarrinho();

// Obter totais
int quantidadeTotal = CarrinhoManager.ObterQuantidadeTotal();
decimal valorTotal = CarrinhoManager.ObterValorTotal();
```

### ItemCarrinho (Classe)
Representa um item no carrinho:
- **Produto**: Referência ao produto
- **Quantidade**: Unidades selecionadas
- **Subtotal**: Preço × Quantidade (calculado automaticamente)

## ?? Produtos de Exemplo

A loja vem com 6 produtos pré-cadastrados:

1. **Fone de Ouvido Bluetooth** - € 49,90 | Áudio
2. **Caixa de Som Portátil** - € 34,90 | Áudio
3. **Microfone USB** - € 59,90 | Áudio
4. **Placa de Som USB** - € 149,90 | Áudio
5. **Cabo XLR Premium** - € 24,90 | Acessórios
6. **Suporte de Mesa para Microfone** - € 39,90 | Acessórios

## ?? Arquivos do Sistema de Carrinho

### Novos Arquivos
- **`CarrinhoManager.cs`** - Gerenciador centralizado do carrinho
- **`FormCarrinho.cs`** - Interface do carrinho de compras
- **`FormCarrinho.Designer.cs`** - Design visual do carrinho

### Arquivos Modificados
- **`Form2.cs`** - Botão de carrinho e contador
- **`Form2.Designer.cs`** - Botão na barra de título
- **`FormDashboard.cs`** - Vitrine pública (sem estoque)
- **`FormDashboard.Designer.cs`** - Interface de loja
- **`ProdutoCard.cs`** - Botão adicionar ao carrinho
- **`ProdutoCard.Designer.cs`** - Design com botão

## ?? Separação Cliente vs Admin

### ?? Visão do Cliente (Dashboard)
- ? Produtos disponíveis
- ? Preços
- ? Categorias
- ? Adicionar ao carrinho
- ? Quantidade em estoque
- ? Informações administrativas

### ?? Visão Admin (Products)
- ? Todos os produtos
- ? Quantidade em estoque
- ? Adicionar/Editar/Remover
- ? Controle total
- ? Informações detalhadas

## ?? Próximas Funcionalidades

### Curto Prazo
- [ ] Sistema de login (Cliente / Admin)
- [ ] Salvar carrinho por sessão
- [ ] Histórico de compras
- [ ] Integração com pagamento (Stripe/PayPal)
- [ ] Cálculo de frete

### Médio Prazo
- [ ] Sistema de cupons/descontos
- [ ] Favoritos
- [ ] Avaliações de produtos
- [ ] Busca e filtros avançados
- [ ] Categorias dinâmicas

### Longo Prazo
- [ ] Sistema de pedidos completo
- [ ] Rastreamento de entrega
- [ ] Notificações por email
- [ ] Sistema de pontos/fidelidade
- [ ] App mobile

## ?? Notas Importantes

- ?? **Sistema em Memória**: Dados do carrinho são perdidos ao fechar o app
- ?? **Checkout Demo**: Finalização de compra é simulada
- ?? **Sincronização**: Carrinho compartilhado entre todas as telas
- ??? **Validações**: Quantidade mínima é 1, não é possível adicionar 0
- ?? **Contador**: Atualizado automaticamente em todas as ações

## ?? Experiência do Usuário

### Dashboard (Vitrine)
```
1. Usuário abre app
2. Vê produtos em cards bonitos
3. Clica "Adicionar ao Carrinho"
4. Vê confirmação
5. Contador no topo atualiza: (0) ? (1)
```

### Carrinho de Compras
```
1. Clica "Carrinho (1)" no topo
2. Vê lista de itens
3. Pode ajustar quantidades
4. Vê totais atualizarem
5. Clica "Finalizar Compra"
6. Confirmação de sucesso!
```

## ?? Sistema de Preços

- **Moeda**: Euros (€)
- **Formato**: € 00,00
- **Cálculos**: Precisão decimal
- **Subtotais**: Preço × Quantidade
- **Total**: Soma de todos subtotais

---

**PlugNSound - Sua Loja de Áudio Premium** ??  
**E-commerce Completo | Carrinho Inteligente | Preços em Euros** ??  
**Versão 2.0.0 - Shopping Cart Edition** ??
