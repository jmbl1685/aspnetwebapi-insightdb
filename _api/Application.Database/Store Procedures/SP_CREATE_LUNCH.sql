CREATE PROCEDURE SP_CREATE_LUNCH
	@Name VARCHAR(150),
	@Description VARCHAR(MAX),
	@Ingredients VARCHAR(MAX),
	@Image VARCHAR(MAX)
AS
BEGIN
	
	INSERT INTO Application.Lunch
		(Name,
		 Description,
		 Ingredients,
		 Image)
	VALUES 
		(@Name,
		 @Description,
		 @Ingredients,
		 @Image)


	SELECT 
		Id,
		LunchID,
		Name,
		Description,
		Ingredients,
		Image
	FROM Application.Lunch WHERE Id = SCOPE_IDENTITY()

END