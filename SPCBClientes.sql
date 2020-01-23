USE "ProjetoContaBancaria1.1";

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[ConsLogin]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[ConsLogin]
GO

CREATE PROCEDURE [dbo].[ConsLogin]
					  @Nom_Consulta		varchar(30),
					  @Nom_Senha		varchar(20)
	AS

	/*
	Documentação
	Arquivo Fonte.....: SPCBClientes.sql
	Objetivo..........: Consulta Login
	Autor.............: Alexandre Higino
 	Data..............: 22/01/2020
	Comentários.......: 0 - Login e Senha Corretos
						1 - Login não encontrado
						2 - Senha incorreta
	*/

	BEGIN

		IF EXISTS(SELECT * 
			FROM [dbo].[Clientes] WITH(NOLOCK)
			WHERE	Nom_Email = @Nom_Consulta
					OR Nom_Login = @Nom_Consulta)
		BEGIN
			IF EXISTS(SELECT *
				FROM [dbo].[Clientes] WITH(NOLOCK)
				WHERE (Nom_Email = @Nom_Consulta
					   OR Nom_Login = @Nom_Consulta)
				AND Nom_Senha = @Nom_Senha)
			RETURN 0

			RETURN 2

		END

			RETURN 1

	END
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[ConsDados]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[ConsDados]
GO 

CREATE PROCEDURE [dbo].[ConsDados]
					 @Num_Cpf		int,
					 @Nom_Email		varchar(30),
					 @Nom_Login		varchar(20)
	AS

	/*
	Documentação
	Arquivo Fonte.....: SPCBClientes.sql
	Objetivo..........: Consulta disponibilidade de cadastro de dados
	Autor.............: Alexandre Higino
 	Data..............: 22/01/2020
	Comentários.......: 0 - Dados disponíveis
						1 - Cpf já cadastrado
						2 - Email já cadastrado
						3 - Login já cadastrado
	*/

	BEGIN
		
		IF EXISTS(SELECT * 
			FROM [dbo].[Clientes] WITH(NOLOCK)
			WHERE	Num_Cpf = @Num_Cpf)
		RETURN 1

		IF EXISTS(SELECT * 
			FROM [dbo].[Clientes] WITH(NOLOCK)
			WHERE	Nom_Email = @Nom_Email)
		RETURN 2

		IF EXISTS(SELECT * 
			FROM [dbo].[Clientes] WITH(NOLOCK)
			WHERE	Nom_Login = @Nom_Login)
		RETURN 3

		RETURN 0

	END
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[InsClientes]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[InsClientes]
GO 

CREATE PROCEDURE [dbo].[InsClientes]
					  @Num_Cpf		int,
					  @Nom_Cliente	varchar(50),
					  @Nom_Email	varchar(30),
					  @Dat_Nasc		datetime,
					  @Ind_Sexo		varchar(14),
					  @Nom_Login	varchar(20),
					  @Nom_Senha	varchar(20)

	AS

	/*
	Documentação
	Arquivo Fonte.....: SPCBClientes.sql
	Objetivo..........: Insere Clientes
	Autor.............: Alexandre Higino
 	Data..............: 22/01/2020
	*/

	BEGIN

		INSERT INTO [dbo].[Clientes]
				(Num_Cpf, Nom_Cliente, Nom_Email, Dat_Nasc, Ind_Sexo, Nom_Login, Nom_Senha) 
			VALUES (@Num_Cpf, @Nom_Cliente, @Nom_Email, @Dat_Nasc, @Ind_Sexo, @Nom_Login, @Nom_Senha) 

		RETURN 0
	END
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[UpdClientes]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[UpdClientes]
GO 

CREATE PROCEDURE [dbo].[UpdClientes]
					  @Num_Cpf		int,
					  @Nom_Cliente	varchar(50),
					  @Dat_Nasc		datetime,
					  @Ind_Sexo		char(1),
					  @Nom_Email	varchar(30)

	AS

	/*
	Documentação
	Arquivo Fonte.....: SPCBClientes.sql
	Objetivo..........: Atualiza dados do cliente
	Autor.............: Alexandre Higino
 	Data..............: 22/01/2020
	*/

	BEGIN

		UPDATE [dbo].[Clientes]
			SET	Num_Cpf = @Num_Cpf,
			    Nom_Cliente = @Nom_Cliente,
				Dat_Nasc = @Dat_Nasc,
				Ind_Sexo = @Ind_Sexo
			WHERE Nom_Email = @Nom_Email

		RETURN 0

	END

GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[SelDados]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[SelDados]
GO

CREATE PROCEDURE [dbo].[SelDados]
					  @Nom_Email	varchar(30)
	AS

	/*
	Documentação
	Arquivo Fonte.....: SPCBClientes.sql
	Objetivo..........: Seleciona dados do cliente
	Autor.............: Alexandre Higino
 	Data..............: 22/01/2020
	*/

	BEGIN

		SELECT *
			FROM [dbo].[Clientes] WITH(NOLOCK)
			WHERE Nom_Email = @Nom_Email

	END
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[DelCliente]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[DelCliente]
GO

CREATE PROCEDURE [dbo].[DelCliente]
					  @Num_Cpf	int
	AS

	/*
	Documentação
	Arquivo Fonte.....: SPCBClientes.sql
	Objetivo..........: Deleta cliente
	Autor.............: Alexandre Higino
 	Data..............: 22/01/2020
	*/

	BEGIN

		DELETE [dbo].[Clientes]
			WHERE Num_Cpf = @Num_Cpf

	END
GO