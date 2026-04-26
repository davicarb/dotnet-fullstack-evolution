# validador_RH

* Este foi meu primeiro projeto full-stack utilizando o winforms para obter uma interface em que o usuário possa interagir (além de um console onde só se aceita inputs via teclado.).
* Neste sistema, apesar de simples, foi treinado:
  
  1. POO no C#, treinando classes, objetos, propriedades e argumentos;
  2. Permanência de dados utilizando JSON (note que ainda as senhas não são criptografadas no .json, mas sim escritas diretamente. Futuramente os projetos contarão com criptografia);
  3. Desserialização de arquivos .json para listas, e serialização de objetos dotnet para arquivos .json;
  4. Implementação de filtros de entrada para garantir a integridade dos dados (ex: impedir nomes curtos ou idades inválidas) e uso de MessageBox para feedback imediato ao usuário;
  5. Tratamentos de erros e tipagem: Uso de métodos como int.TryParse para evitar que o sistema quebre caso o usuário digite letras onde deveriam ser números.

Imagens do projeto:

# Tela de login:
<img width="801" height="477" alt="image" src="https://github.com/user-attachments/assets/4f57c6fa-0d5c-463a-ad6a-83df56abc0b0" />

# Tela de cadastro:
<img width="801" height="477" alt="image" src="https://github.com/user-attachments/assets/735a922c-ebdc-4b23-a405-c5257543f326" />

# Tela do sistema (abre somente após o login)
<img width="782" height="571" alt="image" src="https://github.com/user-attachments/assets/6f620533-c1a7-45f9-a9e5-9f7c9df0710a" />
