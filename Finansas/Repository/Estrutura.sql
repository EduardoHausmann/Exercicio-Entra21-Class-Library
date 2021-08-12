DROP TABLE IF EXISTS contas_pagar;
CREATE TABLE contas_pagar(
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(50),
	valor DECIMAL(5,2),
	tipo VARCHAR(50)
);

DROP TABLE IF EXISTS contas_receber;
CREATE TABLE contas_receber(
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(50),
	valor DECIMAL(5,2),
	valor_recebido DECIMAL(5,2)
);

DROP TABLE IF EXISTS clientes;
CREATE TABLE clientes(
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(50),
	cpf VARCHAR(14),
	rg VARCHAR(9)
);