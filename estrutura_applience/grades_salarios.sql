CREATE TABLE grades_salarios(
	id INTEGER CONSTRAINT pk_salario PRIMARY KEY,
	base NUMBER(8,2),
	teto NUMBER(8,2),
	fg_ativo INTEGER
);