-- =====================================================================
--  Horizonte Imóveis · Cadastro de Clientes
--  Rode este script no MySQL Workbench ou no phpMyAdmin ANTES de abrir o programa.
-- =====================================================================

CREATE DATABASE IF NOT EXISTS imobiliaria
    CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE imobiliaria;

CREATE TABLE IF NOT EXISTS clientes (
    id             INT AUTO_INCREMENT PRIMARY KEY,
    nome           VARCHAR(120)  NOT NULL,
    cpf            VARCHAR(14)   NOT NULL,
    telefone       VARCHAR(20)   NOT NULL,
    email          VARCHAR(120)  DEFAULT '',
    interesse      VARCHAR(20)   NOT NULL,
    tipo_imovel    VARCHAR(40)   NOT NULL,
    valor          DECIMAL(12,2) DEFAULT 0,
    cidade         VARCHAR(80)   NOT NULL,
    bairro         VARCHAR(80)   DEFAULT '',
    observacoes    TEXT,
    foto           VARCHAR(255)  DEFAULT '',
    data_cadastro  DATETIME      NOT NULL
);

-- Clientes de exemplo
INSERT INTO clientes (nome, cpf, telefone, email, interesse, tipo_imovel, valor, cidade, bairro, observacoes, foto, data_cadastro) VALUES
('Mariana Albuquerque', '787.789.328-07', '(11) 98765-4321', 'mariana@email.com', 'Compra',  'Apartamento',    650000, 'São Paulo',      'Vila Mariana', '', '', NOW()),
('Ricardo Fontes',      '792.174.218-12', '(11) 99123-4567', 'ricardo@email.com', 'Aluguel', 'Sala comercial',   4500, 'São Paulo',      'Pinheiros',    '', '', NOW()),
('Helena Duarte',       '096.792.908-32', '(19) 98222-1100', 'helena@email.com',  'Venda',   'Casa',           980000, 'Campinas',       'Cambuí',       '', '', NOW()),
('Camila Rocha',        '793.834.701-94', '(21) 99654-8899', 'camila@email.com',  'Aluguel', 'Apartamento',      3200, 'Rio de Janeiro', 'Botafogo',     '', '', NOW());

-- Para conferir:
-- SELECT * FROM clientes;
