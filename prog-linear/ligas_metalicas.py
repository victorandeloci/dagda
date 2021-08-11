from pymprog import*

# Dados de Entrada

R = [3, 2] # receita de cada liga
D = [3, 1, 3] # disponibilidade (estoques)
P = [[0.5, 0.3],
     [0.1, 0.2],
     [0.4, 0.4]] # proporções de cada materia prima

n = len(R) # número de ligas
m = len(D) # número de materias-primas

begin("ligas") # iniciando modelo

# variaveis de decisão
x = var("x", n)

# função objetivo
maximize(sum(R[i]*x[i] for i in range(n)))

# restrições

for j in range(m):
  sum(P[j][i] * x[i] for i in range(n)) <= D[j]

# resolvendo
solve()

print('Valor ótimo: {}'.format(vobj()))

for i in range(n):
  print('x{} = {}'.format(i+1, x[i].primal))

end()
