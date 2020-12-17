DECLARE @indication [varchar](5)
DECLARE @num INT

DECLARE Test CURSOR FOR
 SELECT indication, num
 FROM stop_start
 
OPEN Test
 
FETCH NEXT FROM Test INTO @indication, @num
 
WHILE @@FETCH_STATUS = 0
BEGIN
 PRINT @indication + ' ' + CAST(@num AS VARCHAR(20))
 FETCH NEXT FROM Test INTO @indication, @num
END
 
CLOSE test
DEALLOCATE test