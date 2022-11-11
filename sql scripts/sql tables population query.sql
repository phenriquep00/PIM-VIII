insert into Endereco (id_, logradouro, numero, cep, bairro, cidade, estado)
values 
(1, 'Rua santos dumont', 471, 65980000, 'Centro', 'Carolina', 'Maranhão'),
(2, 'Rua Albert Einstein', 000, 12345678, 'Centro', 'São Paulo', 'São Paulo'),
(3, 'Rua Nikola Tesla', 010, 12345678, 'Centro', 'Brasilia', 'DF'),
(4, 'Rua Marrie Currie', 112, 0000000, 'Centro', 'Rio de Janeiro', 'Rio de Janeiro')
;

insert into Telefone_Tipo (id_, tipo)
values
(1, 'fixo'),
(2, 'celular'),
(3, 'celular'),
(4, 'celular')
;

insert into Telefone (id_, numero, ddd, tipo)
values
(1, 12345678, 99, 1),
(2, 12345679, 11, 2),
(3, 12345098, 61, 3),
(4, 12345234, 21, 4)
;

insert into Pessoa (id_, nome, cpf, Endereco)
values
(1, 'Pedro Henrique Fonseca Lima', 87654312, 1),
(2, 'John Doe', 00000001, 2),
(3, 'Maria Santos Silva Souza', 11111111, 3),
(4, 'Amanda Silva Santos ', 87654312, 4)
;

insert into Pessoa_Telefone (id_pessoa, id_telefone)
values
(1, 1),
(2, 2),
(3, 3),
(4, 4)
;