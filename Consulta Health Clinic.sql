USE HealthClinicManha



select 
 Consulta.IdConsulta as Consulta,
 Consulta.DataConsulta ,
 Consulta.HorarioConsulta,
 Clinica.NomeFantasia as Clinica,
 Paciente.Nome as Paciente,
 Medico.Nome as Medico,
 Especialidade.NomeEspecialidade as Especialidade,
 Medico.CRM,
 Prontuario.DescricaoProntuario as Prontuario,
 Comentario.Comentario
 from 
 Consulta, Clinica, Paciente, Especialidade, Medico, Prontuario, Comentario
 WHERE
 Paciente.IdPaciente = Consulta.IdPaciente and
 Medico.IdMedico = Consulta.IdMedico and
 Especialidade.IdEspecialidade = Medico.IdEspecialidade and
 Prontuario.IdConsulta = Consulta.IdConsulta and
 Comentario.IdConsulta = Consulta.IdConsulta




select 
 Consulta.IdConsulta as Consulta,
 Consulta.DataConsulta ,
 Consulta.HorarioConsulta,
 Clinica.NomeFantasia as Clinica,
 Paciente.Nome as Paciente,
 Medico.Nome as Medico,
 Especialidade.NomeEspecialidade as Especialidade,
 Medico.CRM,
 Prontuario.DescricaoProntuario as Prontuario,
 Comentario.Comentario
 from
 Clinica, Consulta
 LEFT JOIN Medico ON Consulta.IdMedico = Medico.IdMedico
 LEFT JOIN Paciente ON Consulta.IdPaciente = Paciente.IdPaciente
 LEFT JOIN Especialidade ON Medico.IdEspecialidade = Especialidade.IdEspecialidade
 LEFT JOIN Prontuario ON Consulta.IdConsulta = Prontuario.IdConsulta
 LEFT JOIN Comentario ON Consulta.IdConsulta = Comentario.IdConsulta