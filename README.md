# Docker: Ferramenta essencial para Desenvolvedores

Curso disponibilizado pela Udemy e ministrado por ministrado por Leonardo Leitão e Juracy Filho. Mais detalhes acesse: (https://www.udemy.com/course/curso-docker/). Durante o curso, uma atividade demonstrativa chamada "Projeto para Envio de Emails com Workes" é proposta: um exemplo completo de uma aplicação com múltiplos serviços em Docker. Essa atividade tem os seguintes componentes:
- Servidor web (nginx)
- Banco de dados (Postgres)
- Gerenciamento de filas (Redis)
- Worker para envio de email - escalável (Python)
- Aplicação principal (Python)

Com objetivo de aprendizado e exercício de conhecimento adquirido, adaptamos esta aplicação utilizando outras tecnologias similares:
- O banco de dados agora em Firebird 2.5
- Worker para envio de email - escalável em .NET Core 5.0/C#
- Aplicação princial em ASP.NET Core 5.0/C# (WebAPI)

Procuramos seguir o roteiro proposto pelo curso/apostila, mas modificamos a forma de executar certas atividades por conta das mudanças de plataforma. O resultado final continuou exatamente o mesmo.
