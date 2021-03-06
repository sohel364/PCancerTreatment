USE [cancer]
GO
/****** Object:  StoredProcedure [dbo].[insert_doctors]    Script Date: 27-May-15 11:30:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JISAN MAHMUD
-- Create date:
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[insert_stage_m] 
(
		@stage_m_id NVARCHAR(250) OUTPUT,
		@stage_m_name NVARCHAR(250),
		@stage_m_desc NVARCHAR(250),
		@stage_m_disease_id NVARCHAR(250)
 )     
AS

EXEC primary_key_gen 'stage_m', @stage_m_id OUTPUT

	INSERT INTO stage_m	
	(
	  	stage_m_id,
		stage_m_name,
		stage_m_desc,
		stage_m_disease_id
	)           
    VALUES
    (
	    @stage_m_id,
		@stage_m_name,
		@stage_m_desc,
		@stage_m_disease_id
	)


