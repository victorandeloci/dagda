from pymprog import*

# Dados
D = [[900, 1500, 1300],
     [700, 900, 800]] # demanda
C = [[1.5, 1.5, 2.0],
     [0.5, 0.5, 0.8]] # custo de produção por litro
CE = [[0.5, 0.25, 0.0],
      [0.25, 0.25, 0.0]] # custo de estoque
CP = [[200, 400, 400],
      [400, 500, 500]] # custo de preparação do tanque
T = [100/1000, 80/1000] # tempo dem produção das bebs 1 e 2
TP = [12, 8] # tempo de preparação
TD = [250, 320, 200] # disponibilidade do tanque

n = len(T) # num de bebidas
m = len(TD) # num de periodos
M = sum(D[i][j] for i in range(n) for j in range(m)) # M suficientemente grande

begin('bebidas')

#variáveis de decisão
A = iprod(range(n), range(m)) # indices para as variáveis
x = var('x', A) # variáveis de produção
s = var('s', A, bool) # variável setup

B = iprod(range(n), range(-1, m))# cria indices das vars de estoque
y = var('y', B) # cria vars de estoque

# função objetivo
minimize(sum(C[i][j] * x[i,j] + CE[i][j] * y[i, j] + CP[i][j] * s[i, j] for i, j in A))

# restrições
for i, j in A:
  x[i, j] + y[i, j - 1] - y[i, j] == D[i][j] # demanda

for i in range(n):
  y[i, -1] == 0 # estoque inicial

for j in range(m):
  sum(T[i] * x[i, j] + TP[i] * s[i, j] for i in range(n)) <= TD[j] # disponibilidade do tanque

for i, j in A:
  x[i, j] <= M * s[i, j] # acoplamento

# resolvendo
solve()

print('Valor ótimo = {}'.format(vobj()))

for i, j in A:
  print('X[{0}, {1}] = {2}            Y[{0}, {1}] = {3}'.format(i + 1, j + 1, x[i, j].primal, y[i, j].primal))
