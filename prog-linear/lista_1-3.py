from pymprog import*

# Dados de entrada
D = [960, 510, 895] # demandas
E = [1100, 1800] # estoque
C = [[3.7, 4.3, 6.1],
     [9.8, 6.9, 2.1]]

n = len(E) # n de fábricas
m = len(D) # n de clientes

begin('transporte')

# variaveis
indices = iprod(range(n), range(m))
x = var('x', indices, int)

# funçaõ objetivo
minimize(sum(C[i][j] * x[i, j] for i, j in indices))

# restrições
for j in range(m):
  sum(x[i, j] for i in range(n)) == D[j] # demanda

for i in range(n):
  sum(x[i, j] for j in range(m)) <= E[i] # disponibilidade

# resolução
solve()

print('Valor ótimo = {}'.format(vobj()))

for i, j in indices:
  print('x[{}, {}] = {}'.format(i + 1, j + 1, x[i, j].primal))
