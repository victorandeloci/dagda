CREATE TABLE Pessoas(
  cod INTEGER NOT NULL,
  name VARCHAR(50),
  CONSTRAINT pk_pessoas_cod PRIMARY KEY(cod)
);

CREATE TABLE CNH(
  numero INTEGER,
  expedicao DATE,
  validade DATE,
  categoria VARCHAR(5),
  codigo INTEGER CONSTRAINT uq_cnh_codigo UNIQUE,
  retirada DATE,
  CONSTRAINT pk_cnh_numero PRIMARY KEY(numero),
  CONSTRAINT fk_cnh_codigo FOREIGN KEY(codigo) REFERENCES Pessoas(cod)
);
