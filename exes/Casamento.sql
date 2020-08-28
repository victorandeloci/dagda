CREATE TABLE Marido(
  rg INTEGER,
  rg_esposa INTEGER,
  nome VARCHAR(50),
  CONSTRAINT pk_marido_rg PRIMARY KEY(rg),
  CONSTRAINT fk_esposa_rg FOREIGN KEY(rg_esposa) REFERENCES Esposa(rg)
);

CREATE TABLE Esposa(
  rg INTEGER,
  rg_marido INTEGER,
  nome VARCHAR(50),
  data_casamento DATE,
  CONSTRAINT pk_esposa_rg PRIMARY KEY(rg),
  CONSTRAINT fk_marido_rg FOREIGN KEY(rg_marido) REFERENCES Marido(rg),
  CONSTRAINT fk_casamento_data FOREIGN KEY(data_casamento) REFERENCES Casamento(data)
);

CREATE TABLE Casamento(
  data DATE
);
