DROP TABLE IF EXISTS contas_pagar;
CREATE TABLE contas_pagar(
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(50),
	valor DECIMAL(5,2),
	tipo VARCHAR(50),
	data_vencimento DATE
);

DROP TABLE IF EXISTS contas_receber;
CREATE TABLE contas_receber(
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(50),
	valor DECIMAL(5,2),
	valor_recebido DECIMAL(5,2),
	data_recebimento DATE,
	recebido BIT
);

DROP TABLE IF EXISTS clientes;
CREATE TABLE clientes(
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(50),
	cpf VARCHAR(20),
	data_nascimneto DATE,
	rg VARCHAR(20)
);