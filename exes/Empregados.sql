CREATE TABLE Empregado(
  cpf INTEGER,
  nome VARCHAR(50),
  cod_departamento INTEGER NOT NULL,
  data_lotacao DATE,
  CONSTRAINT pk_empregado_cpf PRIMARY KEY(cpf),
  CONSTRAINT fk_departamento_cod FOREIGN KEY(cod_departamento) REFERENCES Departamentos(cod)
);

CREATE TABLE Departamentos(
  cod INTEGER,
  nome VARCHAR(50),
  CONSTRAINT pk_departamento_cod PRIMARY KEY(cod)
);
