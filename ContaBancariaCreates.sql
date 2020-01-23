CREATE DATABASE "ProjetoContaBancaria1.1";

USE "ProjetoContaBancaria1.1";

	/*
	Documentação
	Arquivo Fonte.......: ContaBancariaCreates.sql
	Objetivo............: Criar Banco de Dados e Tabelas
	Autor...............: Alexandre Higino
 	Data................: 22/01/2020
	Comentários.........: Criação do banco de dados e das tabelas
	Tipos de Contas.....: 0 - Conta Corrente
						  1 - Conta Poupança
	Tipos de Operações..: 0 - Deposito
						  1 - Saque
						  2 - Transferência
	*/

CREATE TABLE Clientes
(					 
		    Num_Cpf				INT,
			Nom_Cliente			VARCHAR(50)	NOT NULL,
			Nom_Email			VARCHAR(30)	NOT NULL UNIQUE,
			Dat_Nasc			DATETIME	NOT NULL,
			Ind_Sexo			CHAR(1),
			Nom_Login			VARCHAR(20) NOT NULL UNIQUE,
			Nom_Senha			VARCHAR(20)	NOT NULL

			CONSTRAINT PK_Cliente PRIMARY KEY (Num_Cpf)
);

CREATE TABLE Contas
(
			Num_ContConta		INT IDENTITY,
			Num_Conta			INT			NOT NULL,
			Vlr_Saldo			DECIMAL(9,2) DEFAULT 0,
			Dat_Criacao			DATETIME	NOT NULL,
			Ind_Tipo			CHAR(1)		NOT NULL,
			Num_Cpf				INT			NOT NULL

			CONSTRAINT PK_Conta PRIMARY KEY (Num_ContConta),
			CONSTRAINT FK_Conta_Cliente	FOREIGN KEY (Num_Cpf) REFERENCES Clientes (Num_Cpf) ON DELETE CASCADE
);

CREATE TABLE Operacoes
(
			Num_Operacao		INT IDENTITY,
			Ind_Tipo			CHAR(1)		 NOT NULL,
			Dat_Realizacao		DATETIME	 NOT NULL,
			Vlr_Operacao		DECIMAL(9,2) NOT NULL,
			Num_Conta			INT

			CONSTRAINT PK_Operacao PRIMARY KEY (Num_Operacao),
			CONSTRAINT FK_Operacao_Conta FOREIGN KEY (Num_Conta) REFERENCES Contas (Num_ContConta) ON DELETE CASCADE
);