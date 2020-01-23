USE "ProjetoContaBancaria1.1";

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[InsContas]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[InsContas]
GO 

CREATE PROCEDURE [dbo].[InsContas]
					  @Dat_Criacao			datetime,
					  @Ind_Tipo				char(1),
					  @Num_Cpf				int

	AS

	/*
	Documentação
	Arquivo Fonte.....: SPCBContas.sql
	Objetivo..........: Insere Contas
	Autor.............: Alexandre Higino
 	Data..............: 23/01/2020
	*/

	BEGIN

		INSERT INTO [dbo].[Contas]
				(Dat_Criacao, Ind_Tipo, Num_Cpf) 
			VALUES (@Dat_Criacao, @Ind_Tipo, @Num_Cpf) 

		RETURN 0
	END
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[SelDadosConta]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[SelDadosConta]
GO

CREATE PROCEDURE [dbo].[SelDadosConta]
					  @Num_Conta	int
	AS

	/*
	Documentação
	Arquivo Fonte.....: SPCBContas.sql
	Objetivo..........: Seleciona dados da conta
	Autor.............: Alexandre Higino
 	Data..............: 23/01/2020
	*/

	BEGIN

		SELECT *
			FROM [dbo].[Contas] WITH(NOLOCK)
			WHERE Num_Conta = @Num_Conta

	END
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[DelConta]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[DelConta]
GO

CREATE PROCEDURE [dbo].[DelConta]
					  @Num_Conta	int
	AS

	/*
	Documentação
	Arquivo Fonte.....: SPCBContas.sql
	Objetivo..........: Deleta conta
	Autor.............: Alexandre Higino
 	Data..............: 23/01/2020
	*/

	BEGIN

		DELETE [dbo].[Contas]
			WHERE Num_Conta = @Num_Conta

	END
GO