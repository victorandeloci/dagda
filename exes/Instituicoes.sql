CREATE TABLE instituicoes(
  sigla CHAR(3),
  CONSTRAINT pk_instituicoes_sigla PRIMARY KEY(sigla)
);

CREATE TABLE projetos(
  numero INTEGER,
  CONSTRAINT pk_projetos_numero PRIMARY KEY(numero)
);

CREATE TABLE pesquisadores(
  rg VARCHAR(11),
  CONSTRAINT pk_pesquisadores_rg PRIMARY KEY(rg)
);

CREATE TABLE pesquisas(
  sigla_instituicao CHAR(3),
  numero_projeto INTEGER,
  rg_pesquisador VARCHAR(11),
  data_inicio DATE,
  CONSTRAINT pk_pesquisas_sigla_numero_rg PRIMARY KEY(sigla_instituicao, numero_projeto, rg_pesquisador),
  CONSTRAINT fk_pesuisas_sigla_instituicao FOREIGN KEY(sigla_instituicao)
    REFERENCES instituicoes(sigla),
  CONSTRAINT fk_pesuisas_numero_projeto FOREIGN KEY(numero_projeto)
    REFERENCES projetos(numero),
  CONSTRAINT fk_pesuisas_rg_pesquisador FOREIGN KEY(rg_pesquisador)
    REFERENCES pesquisadores(rg)
);
