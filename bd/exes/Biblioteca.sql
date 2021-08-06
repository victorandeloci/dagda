CREATE TABLE clientes(
  rg VARCHAR(11),
  nome VARCHAR(64),
  CONSTRAINT k_clientes_rg PRIMARY KEY(rg)
);

CREATE TABLE bibliotecarias(
  rg VARCHAR(11),
  nome VARCHAR(64),
  CONSTRAINT pk_bibliotecarias_rg PRIMARY KEY(rg)
);

CREATE TABLE livros(
  codigo INTEGER,
  nome_cliente VARCHAR(64),
  rg_cliente VARCHAR(11),
  data_devolucao DATE,
  rg_bibliotecaria VARCHAR(11),
  CONSTRAINT pk_livros_codigo PRIMARY KEY(codigo),
  CONSTRAINT fk_livros_nome_nome_cliente FOREIGN KEY(nome_cliente)
    REFERENCES clientes(nome),
  CONSTRAINT fk_livros_rg_cliente FOREIGN KEY(rg_cliente)
    REFERENCES clientes(rg),
  CONSTRAINT fk_livros_rg_bibliotecaria FOREIGN KEY(rg_bibliotecaria)
    REFERENCES bibliotecarias(rg)
);
