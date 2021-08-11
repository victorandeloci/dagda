from pymprog import*

# Dados
P = [80, 90] # capacidade produtiva
D = [50, 40, 65] # demanda
CF = [[10, 12, 20],
      [15, 8, 11]] #custo de fazenda para cliente
CP = [[7, 7, 20],
      [8, 9, 10],
      [24, 8, 6]] # custos de processamentos para clientes

n = len(P) # num de fazendas
m = len(CP) # um de processamentos
l = len(D) # num de clientes

begin('carnes')

# variáveis de decisão
A = iprod(range(n), range(m)) # índices variável X
x = var('X', A) # cria n*m variáveis (de fazenda para processamento)

B = iprod(range(m), range(l)) # índices variável Y
y = var('Y', B) # cria m*l variáveis (de processamento para clientes)

# função objetivo
minimize(sum(CF[i][j] * x[i, j] for i, j in A) + sum(CP[j][k] * y[j, k] for j, k in B))

# restrições
for k in range(l):
  sum(y[j,k] for j in range(m)) == D[k] # atendimento da demanda

for i in range(n):
  sum(x[i, j] for j in range(m)) <= P[i] # capacidade produtiva

for j in range(m):
  sum(x[i, j] for i in range(n)) == sum(y[j, k] for k in range(l))

# resolvendo
solve()

print('Valor ótimo = {}'.format(vobj()))

for i, j in A:
  print('x[{}, {}] = {}'.format(i+1, j+1, x[i, j].primal))

for j, k in B:
  print('y[{}, {}] = {}'.format(j+1, k+1, y[i, j].primal))
