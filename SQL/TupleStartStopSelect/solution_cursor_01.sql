DECLARE @indication [varchar](5)
DECLARE @num INT

DECLARE @current_indication [varchar](5)
DECLARE @current_num_sum INT
SET @current_indication = ''
SET @current_num_sum = 0

DECLARE @tmp_table TABLE
(indication [varchar](5), 
 num INT
)

DECLARE cursor1 CURSOR FOR
 SELECT indication, num
 FROM [dbo].[stop_start]
 
OPEN cursor1
 
FETCH NEXT FROM cursor1 INTO @indication, @num
 
WHILE @@FETCH_STATUS = 0
BEGIN

PRINT @indication + ' ' + CAST(@num AS VARCHAR(20))

IF(LEN(ISNULL(@current_indication, '')) = 0)
	BEGIN
			SET @current_indication = @indication
			SET @current_num_sum = @num
	END
ELSE
	BEGIN
		IF(@current_indication = @indication)
			BEGIN
				SET @current_num_sum += @num				
			END
		ELSE
			BEGIN
				INSERT INTO @tmp_table(indication, num) VALUES(@current_indication, @current_num_sum)
				SET @current_indication = @indication
				SET @current_num_sum = @num
			END
	END	

FETCH NEXT FROM cursor1 INTO @indication, @num

END
CLOSE cursor1
DEALLOCATE cursor1

INSERT INTO @tmp_table(indication, num) VALUES(@current_indication, @current_num_sum)

SELECT * FROM @tmp_table
