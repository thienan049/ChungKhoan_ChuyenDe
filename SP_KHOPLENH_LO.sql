USE [CHUNGKHOAN]
GO

/****** Object:  StoredProcedure [dbo].[SP_KHOPLENH_LO]    Script Date: 5/13/2021 10:05:11 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER PROC [dbo].[SP_KHOPLENH_LO]
 @macp NVARCHAR( 10), @Ngay NVARCHAR( 10),  @LoaiGD CHAR, 
 @soluongMB INT, @giadatMB FLOAT 
AS
SET DATEFORMAT DMY
DECLARE @CrsrVar CURSOR, @id INT, @ngaydat NVARCHAR(10), @soluong INT, @giadat FLOAT, @soluongkhop INT, @giakhop FLOAT
 IF (@LoaiGD='B')
   EXEC CursorLoaiGD  @CrsrVar OUTPUT, @macp,@Ngay, 'M'
 ELSE 
  EXEC CursorLoaiGD  @CrsrVar OUTPUT, @macp,@Ngay, 'B'
  
FETCH NEXT FROM @CrsrVar  INTO @id, @ngaydat, @soluong, @giadat 
--SELECT @ngaydat , @soluong , @giadat
WHILE (@@FETCH_STATUS <> -1 AND @soluongMB > 0)
BEGIN
 IF (@LoaiGD='B' )
   IF  (@giadatMB <= @giadat)
   BEGIN
     IF @soluongMB > @soluong 
     BEGIN
       SET @soluongkhop = @soluong
       SET @giakhop = @giadat
       SET @soluongMB = @soluongMB - @soluong
       UPDATE dbo.LENHDAT  
         SET SOLUONG = 0, TRANGTHAILENH='Khop'
         WHERE CURRENT OF @CrsrVar
     END
     ELSE --@soluongMB <= @soluong 
     BEGIN
       SET @soluongkhop = @soluongMB
       SET @giakhop = @giadat
       
       UPDATE dbo.LENHDAT  
         SET SOLUONG = SOLUONG - @soluongMB
         WHERE CURRENT OF @CrsrVar
       SET @soluongMB = 0
     END
     --SELECT  @soluongkhop, @giakhop
     INSERT INTO LENHKHOP VALUES(@Ngay, @soluongkhop, @giakhop, @id)
   END
   ELSE --(@giadatMB > @giadat)
   BEGIN
	 INSERT INTO LENHDAT VALUES(@macp, @Ngay, @LoaiGD, 'LO', @soluongMB, @giadatMB, 'Chokhop')
     GOTO THOAT
   END
 ELSE --(@LoaiGD='M')
     -- Còn Trường hợp lệnh gởi vào là lệnh mua
   IF  (@giadatMB >= @giadat)
   BEGIN
     IF @soluongMB >= @soluong 
     BEGIN
       SET @soluongkhop = @soluong
       SET @giakhop = @giadatMB
       SET @soluongMB = @soluongMB - @soluong
       UPDATE dbo.LENHDAT  
         SET SOLUONG = 0, TRANGTHAILENH='Khop'
         WHERE CURRENT OF @CrsrVar
     END
     ELSE --@soluongMB < @soluong 
     BEGIN
       SET @soluongkhop = @soluongMB
       SET @giakhop = @giadatMB
       
       UPDATE dbo.LENHDAT  
         SET SOLUONG = SOLUONG - @soluongMB
         WHERE CURRENT OF @CrsrVar
       SET @soluongMB = 0
     END
     --SELECT  @soluongkhop, @giakhop
     INSERT INTO LENHKHOP VALUES(@Ngay, @soluongkhop, @giakhop, @id)
   END
   ELSE --(@giadatMB < @giadat)
   BEGIN
	 INSERT INTO LENHDAT VALUES(@macp, @Ngay, @LoaiGD, 'LO', @soluongMB, @giadatMB, 'Chokhop')
     GOTO THOAT
   END
 FETCH NEXT FROM @CrsrVar INTO  @id, @ngaydat , @soluong , @giadat
END
IF (@@FETCH_STATUS = -1 AND @soluongMB > 0)
	INSERT INTO LENHDAT VALUES(@macp, @Ngay, @LoaiGD, 'LO', @soluongMB, @giadatMB, 'Khop 1 phan')
THOAT:
    CLOSE @CrsrVar
    DEALLOCATE @CrsrVar
GO

