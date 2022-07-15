# greyLog_NET5
Configurando o greylog
1° Acesse o windows powershell
entre na pasta que esta no projeto: greyLogConfig, essa pasta contem um arquivo docker-compose.
2° ao acessar a pasta acima no windows powershell, execute o comando docker-compose up, aguarde a construção da imagem.

Ao concluir a construção da imagem, para acessa o painel do Greylog acesse: http://127.0.0.1:9000/
Usuario: admin
Senha: admin

Execute a aplicaçao .NET5, pelo swag chame o metodo, /WeatherForecast, isso ja vai fazer com que o log de teste seja enviado.
