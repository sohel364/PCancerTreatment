USE [cancer]
GO
/****** Object:  StoredProcedure [dbo].[insert_disease]    Script Date: 02-Jul-15 10:31:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JISAN MAHMUD
-- Create date:
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[insert_disease_type] 
(
		@disease_type_id NVARCHAR(250) OUTPUT,
		@disease_type_name NVARCHAR(250),
		@disease_type_description NVARCHAR(250)
 )     
AS

EXEC primary_key_gen 'disease_type', @disease_type_id OUTPUT

	INSERT INTO disease_type	
	(
	  	disease_type_id,
		disease_type_name,
		disease_type_description
	)           
    VALUES
    (
	    @disease_type_id,
		@disease_type_name,
		@disease_type_description
	)

