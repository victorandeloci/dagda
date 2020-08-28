CREATE TABLE funcionarios(
	id INTEGER,
	id_gerente INTEGER,
	nome VARCHAR2(10) NOT NULL,
	sobrenome VARCHAR2(10) NOT NULL,
	cargo VARCHAR2(20) NOT NULL,
	salario NUMBER (8,2),
	fg_ativo INTEGER,
	CONSTRAINT pk_funcionario PRIMARY KEY(id),
	CONSTRAINT fk_gerente FOREIGN KEY(id_gerente),
		REFERENCES funcionarios(id)
);