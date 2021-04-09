CREATE DATABASE IF NOT EXISTS
    produtodb;
USE produtodb;

CREATE TABLE IF NOT EXISTS produtos (
    IdProduto INT(11) AUTO_INCREMENT,
    Nome VARCHAR(100),
    Descricao VARCHAR(255),
    Valor FLOAT,
    PRIMARY KEY (IdProduto)
);

INSERT INTO produtos VALUE(0, 'Caneta', 'Objeto para escrever em documentos', 2.50);
INSERT INTO produtos VALUE(0, 'Televisão', 'Tv Smart - Entretenimento', 1340.90);
INSERT INTO produtos VALUE(0, 'Geladeira', 'Melhor custo-benefício para a refrigeração', 2599.90);
INSERT INTO produtos VALUE(0, 'Video-Game', 'Se divirta com os melhores jogos da atualidade', 6000.00);
INSERT INTO produtos VALUE(0, 'Notebook', 'Ultima geração de tecnologia', 3500.00);
INSERT INTO produtos VALUE(0, 'Celular', 'Tecnlogia de ponta com a melhor camera', 5000.99);
