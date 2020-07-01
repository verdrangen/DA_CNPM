use DOAN_CNPM
GO
CREATE PROC USP_SearchBook
@title nchar(300)
AS
BEGIN
 select * from BOOK where TITLE LIKE  @title
END
-- drop PROC USP_SearchBook