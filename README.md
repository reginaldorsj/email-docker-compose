# Atividade do curso *"Docker: Ferramenta essencial para Desenvolvedores"*

![](https://img-c.udemycdn.com/course/480x270/1137616_870b.jpg?Expires=1622842042&Signature=aKL2q8M6vnuXaxCp5tYRvbrqj7Fc0WDgaOgno~VodaIpH8gRMtU9YxX5UxmX6Jd2ME7atSZKgcmGL3PkN2B3Zl8yvjtPGXmD7Bb9d4aEtJ684-~g16f9BvtK-dhMBqcqJwMh0idCo3AeFWLCmac44pfdE7izbbQiaSwNt9h0OSwmtcAsuyFiOpe7ExyXcumA~yv1Zr7zhwd1qmr0V-6MDadOC5CjcXKGF03orbo55oNqZ11SVmsrYMNdQcVqFvnBu4pgITIKQsQiUTbBgEDFo-CSpNa1D~T7XQ2jYg2O1C-RhbTOkPT7vst7338VSq5XVxqdsz9UNSMwWYQoj3Hflw__&Key-Pair-Id=APKAITJV77WS5ZT7262A)

Curso disponibilizado pela Udemy e ministrado por Leonardo Leitão e Juracy Filho. Mais detalhes acesse: (https://www.udemy.com/course/curso-docker/). Durante o curso, uma atividade demonstrativa chamada "Projeto para Envio de Emails com Workers" é proposta: um exemplo completo de uma aplicação com múltiplos serviços em Docker. Essa atividade tem os seguintes componentes:
- Servidor web (nginx)
- Banco de dados (Postgres)
- Gerenciamento de filas (Redis)
- Worker para envio de email - escalável (Python)
- Aplicação principal (Python)

Com objetivo de aprendizado e exercício de conhecimento adquirido, adaptamos esta aplicação utilizando outras tecnologias similares:
- O banco de dados agora em Firebird 2.5
- Worker para envio de email - escalável em .NET Core 5.0/C#
- Aplicação principal em ASP.NET Core 5.0/C# (WebAPI)

Procuramos seguir o roteiro proposto pelo curso/apostila, mas modificamos a forma de executar certas atividades por conta das mudanças de plataforma. O resultado final continuou exatamente o mesmo.
