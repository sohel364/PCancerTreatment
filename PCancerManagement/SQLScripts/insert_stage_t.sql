USE [cancer]
GO
/****** Object:  StoredProcedure [dbo].[insert_stage_t]    Script Date: 27-May-15 11:36:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JISAN MAHMUD
-- Create date:
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[insert_stage_t] 
(
		@stage_t_id NVARCHAR(250) OUTPUT,
		@stage_t_name NVARCHAR(250),
		@stage_t_desc NVARCHAR(250),
		@stage_t_disease_id NVARCHAR(250)
 )     
AS

EXEC primary_key_gen 'stage_t', @stage_t_id OUTPUT

	INSERT INTO stage_t	
	(
	  	stage_t_id,
		stage_t_name,
		stage_t_desc,
		stage_t_disease_id
	)           
    VALUES
    (
	    @stage_t_id,
		@stage_t_name,
		@stage_t_desc,
		@stage_t_disease_id
	)


