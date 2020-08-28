CREATE TABLE produtos(
	id INTEGER,
	id_tipo_produto INTEGER,
	nm_produto VARCHAR2(30) NOT NULL,
	ds_produto VARCHAR2(50),
	preco NUMBER(5,2),
	fg_ativo INTEGER,
	CONSTRAINT pk_produto PRIMARY KEY(id),
	CONSTRAINT fk_tipo_produto FOREIGN KEY(id_tipo_produto) REFERENCES tipos_produtos(id)
 );