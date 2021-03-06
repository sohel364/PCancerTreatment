USE [cancer]
GO
/****** Object:  StoredProcedure [dbo].[insert_doctors]    Script Date: 02-Jul-15 10:22:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JISAN MAHMUD
-- Create date:
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[insert_disease] 
(
		@disease_id NVARCHAR(250) OUTPUT,
		@icd_code NVARCHAR(250),
		@disease_name NVARCHAR(250),
		@clinical_description NVARCHAR(250),
		@historical_description NVARCHAR(250),
		@disease_type_id NVARCHAR(250)
 )     
AS

EXEC primary_key_gen 'disease', @disease_id OUTPUT

	INSERT INTO disease	
	(
	  	disease_id,
		icd_code,
		disease_name,
		clinical_description,
		historical_description,
		disease_type_id
	)           
    VALUES
    (
	    @disease_id,
		@icd_code,
		@disease_name,
		@clinical_description,
		@historical_description,
		@disease_type_id
	)

