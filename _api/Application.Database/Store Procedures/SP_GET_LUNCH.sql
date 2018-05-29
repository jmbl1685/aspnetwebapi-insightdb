CREATE PROCEDURE SP_GET_LUNCH
  @PageNumber INT = 1,
  @PageSize   INT = 5
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
	ORDER BY Name
    OFFSET @PageSize * (@PageNumber - 1) ROWS
    FETCH NEXT @PageSize ROWS ONLY OPTION (RECOMPILE);

END