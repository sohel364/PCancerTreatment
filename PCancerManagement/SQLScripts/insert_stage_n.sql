USE [cancer]
GO
/****** Object:  StoredProcedure [dbo].[insert_stage_m]    Script Date: 27-May-15 11:33:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JISAN MAHMUD
-- Create date:
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[insert_stage_n] 
(
		@stage_n_id NVARCHAR(250) OUTPUT,
		@stage_n_name NVARCHAR(250),
		@stage_n_desc NVARCHAR(250),
		@stage_n_disease_id NVARCHAR(250)
 )     
AS

EXEC primary_key_gen 'stage_n', @stage_n_id OUTPUT

	INSERT INTO stage_n	
	(
	  	stage_n_id,
		stage_n_name,
		stage_n_desc,
		stage_n_disease_id
	)           
    VALUES
    (
	    @stage_n_id,
		@stage_n_name,
		@stage_n_desc,
		@stage_n_disease_id
	)


