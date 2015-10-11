-- REMPLISSAGE TABLE CATEGORIES

--RAZ table DIM_CATEGORIES

DELETE FROM [ODE_DATAWAREHOUSE].[DIM_CATEGORIES];

GO

--CREATION VUES TEMPORAIRES POUR éviter l'erreur "Bulk load data conversion error (type mismatch or invalid character for the specified codepage) for row 1, column 1 (ID)."


CREATE VIEW [ODE_DATAWAREHOUSE].Univers_V
AS SELECT LIBEL_UNIVERS,ID_UNIVERS
FROM DIM_CATEGORIES
;

CREATE VIEW [ODE_DATAWAREHOUSE].Rayons_V
AS SELECT LIBEL_RAYON,ID_RAYON
FROM DIM_CATEGORIES
;

CREATE VIEW [ODE_DATAWAREHOUSE].Familles_V
AS SELECT LIBEL_FAMILLE,ID_FAMILLE
FROM DIM_CATEGORIES
;

CREATE VIEW [ODE_DATAWAREHOUSE].sous_Familles_V
AS SELECT LIBEL_SSFAMILLE,ID_SSFAMILLE
FROM DIM_CATEGORIES
;

GO

BULK INSERT [ODE_DATAWAREHOUSE].[Univers_V] FROM N'$(OdeCsvPath)Univers.csv' 
WITH (
    --CHECK_CONSTRAINTS,
    --CODEPAGE='ACP',
    --DATAFILETYPE='char',
    FIELDTERMINATOR=';',
    ROWTERMINATOR='\n'
    --KEEPIDENTITY,
    --TABLOCK
);

GO

BULK INSERT [ODE_DATAWAREHOUSE].[Rayons_V] FROM N'$(OdeCsvPath)Rayons.csv'
WITH (
    --CHECK_CONSTRAINTS,
    --CODEPAGE='ACP',
    --DATAFILETYPE='char',
    FIELDTERMINATOR=';',
    ROWTERMINATOR='\n'
    --KEEPIDENTITY,
    --TABLOCK
);

GO

BULK INSERT [ODE_DATAWAREHOUSE].[Familles_V] FROM N'$(OdeCsvPath)Familles.csv'
WITH (
    --CHECK_CONSTRAINTS,
    --CODEPAGE='ACP',
    --DATAFILETYPE='char',
    FIELDTERMINATOR=';',
    ROWTERMINATOR='\n'
    --KEEPIDENTITY,
    --TABLOCK
);

GO

BULK INSERT [ODE_DATAWAREHOUSE].[sous_Familles_V] FROM N'$(OdeCsvPath)Sous_familles.csv'
WITH (
    --CHECK_CONSTRAINTS,
    --CODEPAGE='ACP',
    --DATAFILETYPE='char',
    FIELDTERMINATOR=';',
    ROWTERMINATOR='\n'
    --KEEPIDENTITY,
    --TABLOCK
);

GO