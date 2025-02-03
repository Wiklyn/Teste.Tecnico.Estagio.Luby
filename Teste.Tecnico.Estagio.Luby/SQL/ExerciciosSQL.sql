-- 2.1 Crie uma query para selecionar todas as pessoas 'tabela_pessoa' e os respectivos eventos 'tabela_evento' o qual elas participam.
SELECT
    p.id AS pessoa_id,
    p.nome AS pessoa_nome,
    e.id AS evento_od,
    e.evento AS evento_nome
FROM
    tabela_pessoa AS p
    LEFT JOIN tabela_evento AS e ON p.id = e.pessoa_id;


-- 2.2 Crie uma query para selecionar todas as pessoas 'tabela_pessoa' com sobrenome 'Doe'.
SELECT
    p.id,
    p.nome
FROM
    tabela_pessoa AS p
WHERE
    p.nome LIKE '%Doe';


-- 2.3 Crie uma query para adicionar um novo evento 'tabela_evento' e relacionar à pessoa 'Lisa Romero'.
INSERT INTO tabela_evento VALUES ('Evento E', 5);


-- 2.4 Crie uma query para atualizar 'Evento D' na 'tabela_evento' e relacionar à pessoa 'John Doe'.
UPDATE
    tabela_evento
SET
    pessoa_id = 1
WHERE
    evento = 'Evento D';


-- 2.5 Crie uma query para remover o 'Evento B' na 'tabela_evento'.
DELETE FROM
    tabela_evento
WHERE
    evento = 'Evento B';


-- 2.6 Crie uma query para remover todas as pessoas 'tabela_pessoa' que não possuem eventos 'tabela_evento' relacionados.,
DELETE FROM
    tabela_pessoa
WHERE
    id NOT IN (
        SELECT DISTINCT
            pessoa_id
        FROM
            tabela_evento
        WHERE
            pessoa_id IS NOT NULL
    );


-- 2.7 Crie uma query para alterar a tabela 'tabela_pessoa' e adicionar a coluna 'idade' (int)
ALTER TABLE
    tabela_pessoa
ADD
    idade INT;


-- 2.8 Crie uma query para criar uma tabela chamada 'tabela_telefone' que pertence a uma pessoa com seguintes campos:
-- id: int (PK)
-- telefone: varchar(200)
-- pessoa_id: int(FK)
CREATE TABLE tabela_telefone (
    id INT IDENTITY(1,1) PRIMARY KEY,
    telefone VARCHAR(200),
    pessoa_id INT,
    FOREIGN KEY (pessoa_id) REFERENCES tabela_pessoa(id) ON DELETE CASCADE
);


-- 2.9 Crie uma query para criar uma índice do tipo único na coluna telefone da 'tabela_telefone'.
CREATE UNIQUE INDEX IX_tabela_telefone_telefone
ON tabela_telefone (telefone);


-- 2.10 Crie uma query para remover a 'tabela_telefone'.
DROP TABLE IF EXISTS tabela_telefone;
