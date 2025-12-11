select * from TbLibro; -- where Id_Libro = 1;

select * from TbEditorial; -- where Id_Editorial = 1;

update TbLibro set Id_Editorial = 1 where Id_Libro = 1;

update TbLibro set Id_Editorial = null where Id_Libro = 7;

-- delete from TbEditorial;

-- DBCC CHECKIDENT ('TbEditorial', RESEED, 0); -- Reinicia el IDENTITY