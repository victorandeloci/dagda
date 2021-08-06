CREATE TABLE tipos_produtos(
	id INTEGER,
	nm_tipo_produto VARCHAR2(10) NOT NULL,
	fg_ativo INTEGER,
	CONSTRAINT pk_tipo_produto PRIMARY KEY(id)
 );