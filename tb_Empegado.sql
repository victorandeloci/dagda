CREATE TABLE tb_empregado(
  id_empregado INTEGER,
  id_gerente INTEGER,
  id_departamento INTEGER,
  id_funcao INTEGER,
  nome VARCHAR(20),
  sobrenome VARCHAR(25),
  email VARCHAR(25),
  telefone VARCHAR(20),
  data_admissao DATE,
  percentual_comissao NUMERIC,
  salario NUMERIC,
  CONSTRAINT pk_empregado_id PRIMARY KEY(id_empregado),
  CONSTRAINT fk_empregado_id_gerente FOREIGN KEY(id_gerente)
    REFERENCES (tb_empregado.id_empregado),
  CONSTRAINT fk_empregado_id_departamento FOREIGN KEY(id_departamento)
    REFERENCES (tb_departamento.id_departamento),
  CONSTRAINT fk_empregado_id_funcao FOREIGN KEY(id_funcao)
    REFERENCES (tb_funcao.id_funcao),
);
