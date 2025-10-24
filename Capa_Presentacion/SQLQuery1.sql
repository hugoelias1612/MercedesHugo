USE [ArimaERP];
GO

SET NOCOUNT ON;
SET XACT_ABORT ON;

BEGIN TRY
    BEGIN TRAN;

    ------------------------------------------------------------
    -- 1) Vaciar dependencias que referencian PRESENTACION
    ------------------------------------------------------------
    IF OBJECT_ID('[dbo].[producto_presentacion]', 'U') IS NOT NULL
    BEGIN
        DELETE FROM [dbo].[producto_presentacion];
    END

    ------------------------------------------------------------
    -- 2) Borrar PRESENTACION y resetear IDENTITY a 0
    ------------------------------------------------------------
    IF OBJECT_ID('[dbo].[PRESENTACION]', 'U') IS NULL
        THROW 51000, 'La tabla [dbo].[PRESENTACION] no existe.', 1;

    DELETE FROM [dbo].[PRESENTACION];
    DBCC CHECKIDENT ('[dbo].[PRESENTACION]', RESEED, 0);

    ------------------------------------------------------------
    -- 3) Insertar NUEVAS presentaciones (solo [descripcion])
    --    Orden alfabetico DENTRO de cada familia
    --    >>> IDs quedan por rangos fijos (1–10, 11–20, etc.)
    ------------------------------------------------------------

    -- 1–10: LACTEOS (alfabetico)
    INSERT INTO [dbo].[PRESENTACION] ([descripcion]) VALUES
    ('Botella 1L'),
    ('Botella 500ml'),
    ('Pote 200g'),
    ('Pote 500g'),
    ('Sachet 1L'),
    ('Sachet 500ml'),
    ('Tetra 1L'),
    ('Tetra 500ml'),
    ('Vaso 180g'),
    ('Vaso 360g');

    -- 11–20: BEBIDAS (SIN ALCOHOL) (alfabetico)
    INSERT INTO [dbo].[PRESENTACION] ([descripcion]) VALUES
    ('Bidon 5L'),
    ('Botella 1L'),
    ('Botella 2L'),
    ('Botella 3L'),
    ('Botella 500ml'),
    ('Botella Vidrio 1L'),
    ('Botella Vidrio 500ml'),
    ('Lata 354ml'),
    ('Lata 473ml'),
    ('Tetra 1L');

    -- 21–30: BEBIDAS ALCOHOLICAS (alfabetico, petaca fija 250ml)
    INSERT INTO [dbo].[PRESENTACION] ([descripcion]) VALUES
    ('Botella Plastico 1L'),
    ('Botella Plastico 500ml'),
    ('Botella Vidrio 330ml'),
    ('Botella Vidrio 500ml'),
    ('Botella Vidrio 750ml'),
    ('Lata 354ml'),
    ('Lata 473ml'),
    ('Petaca 250ml'),
    ('Tetra 1L'),
    ('Tetra 500ml');

    -- 31–40: ALIMENTOS (alfabetico; sin "paquete" ni "caja")
    INSERT INTO [dbo].[PRESENTACION] ([descripcion]) VALUES
    ('Bolsa 1kg'),
    ('Bolsa 500g'),
    ('Frasco 1kg'),
    ('Frasco 250g'),
    ('Frasco 500g'),
    ('Frasco 800g'),
    ('Lata 300g'),
    ('Lata 400g'),
    ('Lata 800g'),
    ('Sobre 100g');

    -- 41–50: PILAS / VELAS / ENCENDEDORES (alfabetico; con duracion y tipos)
    INSERT INTO [dbo].[PRESENTACION] ([descripcion]) VALUES
    ('Encendedor Tipo Candela'),
    ('Encendedor Tipo Cocina'),
    ('Encendedor Tipo Zippo'),
    ('Pila 9V Duracion Estandar'),
    ('Pila AA Duracion Estandar'),
    ('Pila AA Larga Duracion'),
    ('Pila AAA Duracion Estandar'),
    ('Pila AAA Larga Duracion'),
    ('Vela Cera 10cm'),
    ('Vela Cera 20cm');

    -- 51–60: HIGIENE PERSONAL (alfabetico; sin sachet/caja/pack)
    INSERT INTO [dbo].[PRESENTACION] ([descripcion]) VALUES
    ('Aerosol 150ml'),
    ('Aerosol 250ml'),
    ('Barra 90g'),
    ('Botella 1L'),
    ('Botella 250ml'),
    ('Botella 500ml'),
    ('Frasco 300ml'),
    ('Frasco 500ml'),
    ('Tubo 100g'),
    ('Tubo 200g');

    -- 61–70: CUIDADO DOMESTICO (alfabetico; trapo/detergente/lavandina/etc.)
    INSERT INTO [dbo].[PRESENTACION] ([descripcion]) VALUES
    ('Atomizador 1L'),
    ('Atomizador 500ml'),
    ('Bidon 2L'),
    ('Bidon 5L'),
    ('Botella 1L'),
    ('Botella 2L'),
    ('Frasco 500ml'),
    ('Pulverizador 500ml'),
    ('Sachet 500ml'),
    ('Trapo Unidad');

    ------------------------------------------------------------
    -- 4) Confirmación visual rápida
    ------------------------------------------------------------
    DECLARE @c int = (SELECT COUNT(*) FROM [dbo].[PRESENTACION]);
    IF @c <> 70
        THROW 51001, 'Cantidad final distinta de 70 en [PRESENTACION].', 1;

    COMMIT TRAN;
    PRINT 'OK: Se insertaron 70 presentaciones en [dbo].[PRESENTACION].';

END TRY
BEGIN CATCH
    IF XACT_STATE() <> 0 ROLLBACK TRAN;
    DECLARE @Msg nvarchar(4000) = ERROR_MESSAGE();
    RAISERROR(@Msg, 16, 1);
END CATCH;