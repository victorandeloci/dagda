CREATE TABLE clientes(
  rg VARCHAR(11),
  CONSTRAINT pk_clientes_rg PRIMARY KEY(rg)
);

CREATE TABLE contas(
  numero INTEGER,
  CONSTRAINT pk_contas_numero PRIMARY KEY(numero)
);

CREATE TABLE correntistas(
  rg_cliente VARCHAR(11),
  numero_conta INTEGER,
  CONSTRAINT pk_correntistas_rg_numero PRIMARY KEY(rg_cliente, numero_conta),
  CONSTRAINT fk_correntistas_rg_cliente FOREIGN KEY(rg_cliente)
    REFERENCES clientes(rg),
  CONSTRAINT fk_correntistas_numero_conta FOREIGN KEY(numero_conta)
    REFERENCES contas(numero)
);

CREATE TABLE cartoesMagneticos(
  numero INTEGER,
  data_exp DATE,
  rg_cliente VARCHAR(11) CONSTRAINT nn_cartoesMagneticos_rg_cliente NOT NULL,
  numero_conta INTEGER CONSTRAINT nn_cartoesMagneticos_numero_conta NOT NULL,
  CONSTRAINT pk_cartoesMagneticos_numero PRIMARY KEY(numero),
  CONSTRAINT fk_cartoesMagneticos_rg_cliente FOREIGN KEY(rg_cliente)
    REFERENCES clientes(rg),
  CONSTRAINT fk_cartoesMagneticos_numero_conta FOREIGN KEY(numero_conta)
    REFERENCES contas(numero)
);
