CREATE PROCEDURE SP_VTop4_PRODUTO
		(
		@nmPlataforma 	VARCHAR (20),
		@cdCategoria 		INT
		)
		AS 
			BEGIN
				SELECT TOP 4 PRODUTO.cdProduto, PRODUTO.cdPlataforma, PRODUTO.cdCategoria, PRODUTO.cdSubCategoria, PRODUTO.cdPUBLICADOR, PRODUTO.cdDESENVOLVEDOR, 
				PRODUTO.cdGenero, PRODUTO.cdESRB, PRODUTO.cdMidia, PRODUTO.NomeCompto, PRODUTO.NomeRzdo, PRODUTO.Resumo, PRODUTO.Detalhe, 
				PRODUTO.Foto, PRODUTO.noMinEst, PRODUTO.noMaxEst, PRODUTO.EstAlvo, PRODUTO.vlVenda, PRODUTO.DtCad, PRODUTO.Ativo, PRODUTO.DtLanc, 
				PLATAFORMA.nmPLataforma, PLATAFORMA.iconePlataforma, 
				CATEGORIA.nmCategoria, SUBCATEGORIA.nmSubCategoria, PUBLICADOR.nmPUBLICADOR, 
				DESENVOLVEDOR.nmDESENVOLVEDOR, GENERO.nmGenero, ESRB.nmESRB, ESRB.iconeESRB, MIDIA.nmMidia
				
				FROM ((PRODUTO INNER JOIN Plataforma ON PRODUTO.cdPlataforma = Plataforma.cdPlataforma)	INNER JOIN  CATEGORIA ON PRODUTO.cdCategoria = CATEGORIA.cdCategoria)
							   INNER JOIN  SubCategoria ON PRODUTO.cdSubCategoria = SubCategoria.cdSubCategoria
							   INNER JOIN  PUBLICADOR ON PRODUTO.cdPUBLICADOR = PUBLICADOR.cdPUBLICADOR
							   INNER JOIN  DESENVOLVEDOR ON PRODUTO.cdDESENVOLVEDOR = DESENVOLVEDOR.cdDESENVOLVEDOR	
							   INNER JOIN  Genero ON PRODUTO.cdGenero = Genero.cdGenero
							   INNER JOIN  ESRB ON PRODUTO.cdESRB = ESRB.cdESRB
							   INNER JOIN  Midia ON PRODUTO.cdMidia = Midia.cdMidia			
							   INNER JOIN  EAN ON PRODUTO.cdProduto = EAN.cdProduto
	
				WHERE PLATAFORMA.nmPLataforma=@nmPlataforma and PRODUTO.cdCategoria=@cdCategoria
				ORDER BY PRODUTO.DtLanc DESC
			END
			
CREATE PROCEDURE SP_VPRODUTO
		(
		@cdProduto 	INT
		
		)
		AS 
			BEGIN
				SELECT TOP 4 PRODUTO.cdProduto, PRODUTO.cdPlataforma, PRODUTO.cdCategoria, PRODUTO.cdSubCategoria, PRODUTO.cdPUBLICADOR, PRODUTO.cdDESENVOLVEDOR, 
				PRODUTO.cdGenero, PRODUTO.cdESRB, PRODUTO.cdMidia, PRODUTO.NomeCompto, PRODUTO.NomeRzdo, PRODUTO.Resumo, PRODUTO.Detalhe, 
				PRODUTO.Foto, PRODUTO.noMinEst, PRODUTO.noMaxEst, PRODUTO.EstAlvo, PRODUTO.vlVenda, PRODUTO.DtCad, PRODUTO.Ativo, PRODUTO.DtLanc, 
				PLATAFORMA.nmPLataforma, PLATAFORMA.iconePlataforma, 
				CATEGORIA.nmCategoria, SUBCATEGORIA.nmSubCategoria, PUBLICADOR.nmPUBLICADOR, 
				DESENVOLVEDOR.nmDESENVOLVEDOR, GENERO.nmGenero, ESRB.nmESRB, ESRB.iconeESRB, MIDIA.nmMidia
				
				FROM ((PRODUTO INNER JOIN Plataforma ON PRODUTO.cdPlataforma = Plataforma.cdPlataforma)	INNER JOIN  CATEGORIA ON PRODUTO.cdCategoria = CATEGORIA.cdCategoria)
							   INNER JOIN  SubCategoria ON PRODUTO.cdSubCategoria = SubCategoria.cdSubCategoria
							   INNER JOIN  PUBLICADOR ON PRODUTO.cdPUBLICADOR = PUBLICADOR.cdPUBLICADOR
							   INNER JOIN  DESENVOLVEDOR ON PRODUTO.cdDESENVOLVEDOR = DESENVOLVEDOR.cdDESENVOLVEDOR	
							   INNER JOIN  Genero ON PRODUTO.cdGenero = Genero.cdGenero
							   INNER JOIN  ESRB ON PRODUTO.cdESRB = ESRB.cdESRB
							   INNER JOIN  Midia ON PRODUTO.cdMidia = Midia.cdMidia			
							   INNER JOIN  EAN ON PRODUTO.cdProduto = EAN.cdProduto
	
				WHERE PRODUTO.cdProduto=@cdProduto
				
			END


CREATE PROCEDURE SP_V_CATEGORIA
		(
		@nmPlataforma 	VARCHAR (20)
		)
		AS 
		BEGIN
		SELECT DISTINCT CATEGORIA.nmCategoria
		FROM ((PRODUTO INNER JOIN Plataforma ON PRODUTO.cdPlataforma = Plataforma.cdPlataforma)	INNER JOIN  CATEGORIA ON PRODUTO.cdCategoria = CATEGORIA.cdCategoria)
					   INNER JOIN  SubCategoria ON PRODUTO.cdSubCategoria = SubCategoria.cdSubCategoria
					   INNER JOIN  PUBLICADOR ON PRODUTO.cdPUBLICADOR = PUBLICADOR.cdPUBLICADOR
					   INNER JOIN  DESENVOLVEDOR ON PRODUTO.cdDESENVOLVEDOR = DESENVOLVEDOR.cdDESENVOLVEDOR	
					   INNER JOIN  Genero ON PRODUTO.cdGenero = Genero.cdGenero
					   INNER JOIN  ESRB ON PRODUTO.cdESRB = ESRB.cdESRB
					   INNER JOIN  Midia ON PRODUTO.cdMidia = Midia.cdMidia			
					   INNER JOIN  EAN ON PRODUTO.cdProduto = EAN.cdProduto
		WHERE PLATAFORMA.nmPLataforma=@nmPlataforma 
		END
			
				
CREATE PROCEDURE SP_V_GENERO
		(
		@nmPlataforma 	VARCHAR (20)
		)
		AS 
		BEGIN
		SELECT DISTINCT GENERO.nmGenero
		FROM ((PRODUTO INNER JOIN Plataforma ON PRODUTO.cdPlataforma = Plataforma.cdPlataforma)	INNER JOIN  CATEGORIA ON PRODUTO.cdCategoria = CATEGORIA.cdCategoria)
					   INNER JOIN  SubCategoria ON PRODUTO.cdSubCategoria = SubCategoria.cdSubCategoria
					   INNER JOIN  PUBLICADOR ON PRODUTO.cdPUBLICADOR = PUBLICADOR.cdPUBLICADOR
					   INNER JOIN  DESENVOLVEDOR ON PRODUTO.cdDESENVOLVEDOR = DESENVOLVEDOR.cdDESENVOLVEDOR	
					   INNER JOIN  Genero ON PRODUTO.cdGenero = Genero.cdGenero
					   INNER JOIN  ESRB ON PRODUTO.cdESRB = ESRB.cdESRB
					   INNER JOIN  Midia ON PRODUTO.cdMidia = Midia.cdMidia			
					   INNER JOIN  EAN ON PRODUTO.cdProduto = EAN.cdProduto
		WHERE PLATAFORMA.nmPLataforma=@nmPlataforma 
		END		
			
CREATE PROCEDURE SP_V_SubCat
		(
		@nmPlataforma 	VARCHAR (20)
		)
		AS 
		BEGIN
		SELECT DISTINCT SUBCATEGORIA.nmSubCategoria
		FROM ((PRODUTO INNER JOIN Plataforma ON PRODUTO.cdPlataforma = Plataforma.cdPlataforma)	INNER JOIN  CATEGORIA ON PRODUTO.cdCategoria = CATEGORIA.cdCategoria)
					   INNER JOIN  SubCategoria ON PRODUTO.cdSubCategoria = SubCategoria.cdSubCategoria
					   INNER JOIN  PUBLICADOR ON PRODUTO.cdPUBLICADOR = PUBLICADOR.cdPUBLICADOR
					   INNER JOIN  DESENVOLVEDOR ON PRODUTO.cdDESENVOLVEDOR = DESENVOLVEDOR.cdDESENVOLVEDOR	
					   INNER JOIN  Genero ON PRODUTO.cdGenero = Genero.cdGenero
					   INNER JOIN  ESRB ON PRODUTO.cdESRB = ESRB.cdESRB
					   INNER JOIN  Midia ON PRODUTO.cdMidia = Midia.cdMidia			
					   INNER JOIN  EAN ON PRODUTO.cdProduto = EAN.cdProduto
		WHERE PLATAFORMA.nmPLataforma=@nmPlataforma 
		END			
				
				




	
	
	
CREATE PROCEDURE SP_ADD_NENDERECO
	
		
		@cdCli 			INT,
		@PNomeDest		VARCHAR (30),
		@UNomeDest		VARCHAR (40),
		@Telefone		VARCHAR (9) ,
		@noCEP 			CHAR (8) ,
		@noLog 			VARCHAR (8) ,
		@Complemento	VARCHAR (70),
		@cdTpEndereco	INT,
		@PCobranca		BIT,
		@PEntrega		BIT,
		@DtCad			DATE,
		@Ativo			BIT 
	
AS
BEGIN	
	
INSERT INTO CLIENTE_ENDERECO (cdCli, PNomeDest, UNomeDest, Telefone, noCEP, noLog, Complemento, cdTpEndereco, PCobranca, PEntrega, DtCad, Ativo) 	
		VALUES				 (@cdCli, @PNomeDest, @UNomeDest, @Telefone, @noCEP, @noLog, @Complemento, @cdTpEndereco, @PCobranca, @PEntrega, @DtCad, @Ativo)
	
END	
	
	
	
	
	
	
	
		SELECT * FROM CLIENTE_ENDERECO
	
	CREATE PROCEDURE SP_ADD_PDV
	
	
	@cdCli 			INT ,
	@dtPedido 		SMALLDATETIME 
		
	AS
	BEGIN
	
	INSERT INTO PDV (cdFunc, cdCli, dtPedido, cdTransp, cdSit, cdTPvenda, cdFormaPgto, Ativo) 
	VALUES (1, @cdCli, @dtPedido, 1, 1, 3, 1, 1)
	
	END 
	
	CREATE PROCEDURE sp_RetornaCodPedido
	@cdCli 			INT ,
	@dtPedido 		SMALLDATETIME 

	AS
	BEGIN
	
		SELECT cdPDV, cdCli, dtPedido
		FROM PDV
		WHERE cdCli=@cdCli And dtPedido=@dtPedido

	END 
	
	
	
	CREATE PROCEDURE SP_ADD_DET_PDV
	
	
	@cdPDV 			INT,
	@EAN	    	VARCHAR (14),
	@QTDE 			INT,
	@SubTotal 		DECIMAL (8,2)
		
	AS
	BEGIN
	
	INSERT INTO DET_PDV (cdPDV, EAN, QTDE, SubTotal) 
	VALUES (@cdPDV, @EAN, @QTDE, @SubTotal)
	
	END  
	
	SELECT * FROM CLIENTE