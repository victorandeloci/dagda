# PCV modificado
from pymprog import*
from math import*

# bibliotecas para desenhar
from matplotlib import pyplot as plt
import matplotlib.patches as patches

def distancia(i, j):
  return sqrt((j[0] - i[0])**2 + (j[1] - i[1])**2)

coordenadas  = [[14, 43],
                [82, 84],
                [43, 17],
                [15, 32],
                [87, 84],
                [28, 80],
                [12, 46],
                [26, 4],
                [57, 24],
                [24, 50],
                [32, 26],
                [65, 23],
                [92, 100],
                [24, 88],
                [65, 15],
                [14, 43]]

n = len(coordenadas) - 1 # número de cidades (nós)

begin('PCV')

x = var('x',iprod(range(n + 1),range(n + 1)), bool)
u = var('u', n + 1)
# função objetivo
minimize(sum(distancia(coordenadas[i],coordenadas[j]) * x[i,j] for i in range(n) for j in range(1,n+1) if i!=j))

# primeira restrição
for i in range(n):
  sum(x[i,j] for j in range(1,n+1) if i!=j) == 1

# segunda restrição
for j in range(1,n+1):
  sum(x[i,j] for i in range(n) if i!=j) == 1

# eliminação de sub-rotas
for i in range(n):
  for j in range(1,n+1):
    if i!=j:
      u[j] >= u[i] + n * x[i,j] - n + 1

# restriçõe de precedência
P = [ [7, 12],
      [9, 1],
      [8, 9],
      [10, 3],
      [12, 2]]

m = len(P) # número de precedências

for i in range(n):
  for j in range(1,n+1):
    if i!=j:
      for k in range(m):
        u[P[k][1]] >= u[P[k][0]] + n * x[i,j] - n + 1

# alguns parâmetros de resolução
#solver(int,gmi_cuts=1)
solve()

print("Valor ótimo PCV = {:.3f}".format(vobj()))
print()
for i in range(n):
  for j in range(n):
    if x[i,j].primal > 0.1:
      print("{:2d}   -->  {:2d}".format(i,j))


# PLotar rota
m = 100 # máximo das coordenadas
fig1 = plt.figure()
ax1 = fig1.add_subplot(111, aspect='equal')
ax1.tick_params(labelbottom=False, labelleft=False, bottom=False, left=False)
ax1.grid(False)

for i in range(n):
  for j in range(1,n+1):
    if i!=j:
      if x[i,j].primal>=0.9:
          ax1.add_patch(patches.ConnectionPatch(xyA=(coordenadas[i][0],coordenadas[i][1]), xyB=(coordenadas[j][0],coordenadas[j][1]), coordsA="data", coordsB="data",color='black'))



for i in range(n):
    ax1.add_patch(patches.Circle((coordenadas[i][0],coordenadas[i][1]), radius= 0.03*m, color = '#F4A460'))
    plt.text(coordenadas[i][0]-0.03*len(str(i))*m/2,coordenadas[i][1]-0.02*m/2, str(i), {'color': 'black', 'fontsize': 10})


plt.ylim(-1,m+1)
plt.xlim(-1,m+1)

fig1.show()

plt.show(block=True)
plt.interactive(False)


end()
