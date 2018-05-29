CREATE PROCEDURE SP_UPDATE_LUNCH
	@ID UNIQUEIDENTIFIER,
	@Name VARCHAR(150),
	@Description VARCHAR(MAX),
	@Ingredients VARCHAR(MAX),
	@Image VARCHAR(MAX)
AS
BEGIN
	UPDATE Application.Lunch
		SET 
			Name = @Name,
			Description = @Description,
			Ingredients = @Ingredients,
			Image = @Image
	WHERE LunchID = @ID

	SELECT 
		Id,
		LunchID,
		Name,
		Description,
		Ingredients,
		Image
	FROM Application.Lunch WHERE LunchID = @ID

END