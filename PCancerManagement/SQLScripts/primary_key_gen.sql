USE [cancer]
GO
/****** Object:  StoredProcedure [dbo].[primary_key_gen]    Script Date: 5/9/2015 10:29:46 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
ALTER PROCEDURE [dbo].[primary_key_gen]
@entity_name VARCHAR(50),
@primary_key VARCHAR(15) OUTPUT
 AS

DECLARE
	@code INT,
	@prefix VARCHAR(5)
	
	-- Get Latest Code and Prefix from Database (sys_code)
	SELECT @code=entity_code,@prefix=entity_prefix FROM SYSTEM_CODE WHERE entity_name=@entity_name

	--Increace Code by 1
	SET @code=@code+1

	--Generate Primary Key
	IF(@code<10)
		SET @primary_key = @prefix + '00000000000' + CONVERT(VARCHAR(2), @code)
	ELSE IF(@code<100)
		SET @primary_key = @prefix + '0000000000' + CONVERT(VARCHAR(2), @code)
	ELSE IF(@code<1000)
		SET @primary_key = @prefix + '000000000' + CONVERT(VARCHAR(3), @code)
	ELSE IF(@code<10000)
		SET @primary_key = @prefix + '00000000' + CONVERT(VARCHAR(4), @code)
	ELSE IF(@code<100000)
		SET @primary_key = @prefix + '0000000' + CONVERT(VARCHAR(5), @code)
	ELSE IF(@code<1000000)
		SET @primary_key = @prefix + '000000' + CONVERT(VARCHAR(6), @code)
	ELSE IF(@code<10000000)
		SET @primary_key = @prefix + '00000' + CONVERT(VARCHAR(7), @code)
	ELSE IF(@code<100000000)
		SET @primary_key = @prefix + '0000' + CONVERT(VARCHAR(8), @code)
	ELSE IF(@code<1000000000)
		SET @primary_key = @prefix + '000' + CONVERT(VARCHAR(9), @code)
	ELSE IF(@code<10000000000)
		SET @primary_key = @prefix + '00' + CONVERT(VARCHAR(10), @code)
	ELSE IF(@code<100000000000)
		SET @primary_key = @prefix + '0' + CONVERT(VARCHAR(11), @code)
	ELSE
		SET @primary_key = @prefix + '' + CONVERT(VARCHAR(12), @code)

	--Upfate Code in Database (sys_code)
	UPDATE SYSTEM_CODE SET entity_code=@code WHERE entity_name=@entity_name