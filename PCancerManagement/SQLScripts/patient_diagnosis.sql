USE [cancer]
GO
/****** Object:  StoredProcedure [dbo].[insert_patient]    Script Date: 09-May-15 11:12:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JISAN MAHMUD
-- Create date:
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[insert_patient_diagnosis] 
(
		@patient_diagnosis_id NVARCHAR(250) OUTPUT,
		@patient_diagnosis_criteria NVARCHAR(250),
		@patient_diagnosis_stage NVARCHAR(250),
		@patient_diagnosis_histopathology NVARCHAR(250),
		@patient_diagnosis_cytology NVARCHAR(250),
		@patient_id  NVARCHAR(250)

 )     
AS

EXEC primary_key_gen 'patient_diagnosis', @patient_diagnosis_id OUTPUT

	INSERT INTO patient_diagnosis	
	(
		
	  	patient_diagnosis_id,
		patient_diagnosis_criteria ,
		patient_diagnosis_stage,
		patient_diagnosis_cytology,
		patient_id
	)           
    VALUES
    (
	    @patient_diagnosis_id,
		@patient_diagnosis_criteria ,
		@patient_diagnosis_stage,
		@patient_diagnosis_cytology,
		@patient_id	
	)

