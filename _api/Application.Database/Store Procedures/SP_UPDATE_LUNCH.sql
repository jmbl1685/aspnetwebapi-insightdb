CREATE PROCEDURE SP_UPDATE_LUNCH
	@LunchID UNIQUEIDENTIFIER,
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
		WHERE LunchID = @LunchID
END