CREATE TABLE tabela_pessoa (
    id INT IDENTITY(1,1) PRIMARY KEY,
    nome VARCHAR(50) NOT NULL
);

CREATE TABLE tabela_evento (
    id INT IDENTITY(1,1) PRIMARY KEY,
    evento VARCHAR(50) NOT NULL,
    pessoa_id INT NULL,
    FOREIGN KEY (pessoa_id) REFERENCES tabela_pessoa(id) ON DELETE CASCADE
);

INSERT INTO tabela_pessoa (nome) VALUES 
('John Doe '),
('Jane Doe'),
('Alice Jones '),
('Bobby Louis'),
('Lisa Romero');

INSERT INTO tabela_evento (evento, pessoa_id) VALUES 
('Evento A', 2),
('Evento B', 3),
('Evento C', 2),
('Evento D', NULL);
