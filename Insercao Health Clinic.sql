INSERT INTO Clinica(Endereco, HoraFuncionamento, HorarioFechamento, CNPJ, NomeFantasia, RazaoSocial)
VALUES ('Rua parma 982','8:00:00','18:00:00','13813941084278','GP Clinics', 'Gustavo industrias EI')

INSERT INTO TipoDeUsuario(TituloTipoUsuario)
VALUES ('administrador'),('comum')

INSERT INTO Usuario(IdTipoUsuario,Email,Senha)
VALUES (2,'Henrique@gmail.com','rique'),(2,'eduardo@gmail.com','Edu')

INSERT INTO Especialidade(NomeEspecialidade)
VALUES ('Ortopedista'),('fisioterapeuta'),('Neurologista')

INSERT INTO Medico(IdClinica, IdEspecialidade, IdUsuario, Nome, CRM)
VALUES (1,2,2,'Henrique','837104')

INSERT INTO Paciente(IdUsuario, Nome, CPF)
VALUES(5,'Eduardo','49173019475')

INSERT INTO Consulta(IdMedico, IdPaciente, DataConsulta, HorarioConsulta, Descricao)
VALUES (2,2,'2023/08/17','12:00:00','lesao no joelho')	

INSERT INTO Prontuario(IdConsulta, DescricaoProntuario)
VALUES(2,'paciente com lesao no joelho, feito uns exercios de movimentos da perna')

INSERT INTO Comentario(IdConsulta, Comentario)
VALUES(2,'Doutor muito bem informado e sabe oque esta fazendo!')


