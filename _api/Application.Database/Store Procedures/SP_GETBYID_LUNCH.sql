CREATE PROCEDURE SP_GETBYID_LUNCH
  @LunchID UNIQUEIDENTIFIER
AS
BEGIN
	SET NOCOUNT ON;
 
  	SELECT 
		Id,
		LunchID,
		Name,
		Description,
		Ingredients,
		Image
	FROM Application.Lunch
	WHERE LunchID = @LunchID
END