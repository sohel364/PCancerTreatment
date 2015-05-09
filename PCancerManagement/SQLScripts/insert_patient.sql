USE [cancer]
GO
/****** Object:  StoredProcedure [dbo].[insert_patient]    Script Date: 5/9/2015 10:29:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		MAHMUDUL HASAN
-- Create date:
-- Description:	
-- =============================================
ALTER PROCEDURE [dbo].[insert_patient] 
(
		@patient_id NVARCHAR(250) OUTPUT,
		@name NVARCHAR(250),
		@fathers_name NVARCHAR(250),
		@religion NVARCHAR(250),
		@sex NVARCHAR(250),
		@age  NVARCHAR(250),
		@height NVARCHAR(250),
		@weight NVARCHAR(250),
		@address NVARCHAR(250),
		@contact_no NVARCHAR(250),
		@reffered_id NVARCHAR(250),
		@dtype NVARCHAR(250),
		@disese_id NVARCHAR(250)


 )     
AS

EXEC primary_key_gen 'patient', @patient_id OUTPUT

	INSERT INTO patient	
	(
		
	  	patient_id,
		name ,
		fathers_name,
		religion,
		sex,
		age,
		height,
		weight,
		address,
		contact_no,
		reffered_id,
		dtype,
		disese_id
	)           
    VALUES
    (
	    @patient_id,
		@name ,
		@fathers_name,
		@religion,
		@sex,
		@age,
		@height,
		@weight,
		@address,
		@contact_no,
		@reffered_id,
		@dtype,
		@disese_id	
	)

