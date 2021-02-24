﻿CREATE PROC FI_SP_ConsBeneficiario
	@ID BIGINT
AS
BEGIN
	IF(ISNULL(@ID,0) = 0)
		SELECT NOME, CPF, ID FROM BENEFICIARIOS WITH(NOLOCK)
	ELSE
		SELECT NOME, CPF, ID FROM BENEFICIARIOS WITH(NOLOCK) WHERE IDCLIENTE = @ID
END