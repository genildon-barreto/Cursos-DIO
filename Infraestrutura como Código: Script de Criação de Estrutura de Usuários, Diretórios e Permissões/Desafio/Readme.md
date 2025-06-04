# Script de Criação de Usuários, Diretórios e Permissões
Este projeto é um desafio prático do curso "Infraestrutura como Código" da Digital Innovation One (DIO). Ele demonstra a automação da criação de uma estrutura de usuários, grupos, diretórios e suas respectivas permissões em um sistema Linux, utilizando um script Bash.

## 🚀 Visão Geral do Projeto
O objetivo principal deste projeto é simular a configuração inicial de um servidor, onde diferentes equipes (Administração, Vendas e Segurança) precisam ter acesso a diretórios específicos com permissões controladas. O script Bash automatiza todo esse processo, tornando a implantação mais rápida e menos propensa a erros.

## ✨ Funcionalidades
O script Bash (script_provisionamento.sh) realiza as seguintes ações:

* Criação de Diretórios:
  * /publico: Diretório de acesso geral.
  * /adm: Diretório exclusivo para o grupo GRP_ADM.
  * /ven: Diretório exclusivo para o grupo GRP_VEN.
  * /sec: Diretório exclusivo para o grupo GRP_SEC.
* Criação de Grupos de Usuários:
  * GRP_ADM: Grupo para usuários administradores.
  * GRP_VEN: Grupo para usuários de vendas.
  * GRP_SEC: Grupo para usuários de segurança.
* Criação de Usuários:
  * Administradores: Carlos, Maria, João.
  * Vendas: Débora, Sebastiana, Roberto.
  * Segurança: Josefa, Amanda, Rogério.
  * Todos os usuários são criados com a senha inicial Abc123 (e são forçados a trocá-la no primeiro login, através do comando passwd -e).
* Associação de Usuários a Grupos: Cada usuário é adicionado ao seu grupo correspondente.
* Definição de Permissões:
  * /adm, /ven, /sec: Proprietário root e grupo correspondente. Permissões 770 (leitura, escrita e execução para proprietário e grupo, sem acesso para outros).
  * /publico: Permissões 777 (acesso total para todos).
## 💻 Como Executar
Para executar este script, siga os passos abaixo:

1.  Clone o repositório:  
        Bash  

        git clone https://github.com/genildon-barreto/Cursos-DIO.git  
        cd Cursos-DIO/Infraestrutura%20como%20C%C3%B3digo%3A%20Script%20de%20Cria%C3%A7%C3%A3o%20de%20Estrutura%20de%20Usu%C3%A1rios%2C%20Diret%C3%B3rios%20e%20Permiss%C3%B5es/Desafio  
2.  Dê permissão de execução ao script:  
        Bash  
        chmod +x script_provisionamento.sh
    
3.  Execute o script como superusuário (sudo):  
        Bash  

        sudo ./script_provisionamento.sh
    
Observação: O script utiliza sudo para todas as operações, garantindo as permissões necessárias para criar e modificar usuários, grupos e diretórios no sistema.

## 💡 Aprendizados do Projeto
Este projeto foi fundamental para solidificar diversos conceitos importantes sobre Infraestrutura como Código e administração de sistemas Linux:

* Automação com Shell Script: A prática de escrever scripts Bash para automatizar tarefas repetitivas é essencial para a eficiência e consistência na administração de sistemas.
* Gerenciamento de Usuários e Grupos: Aprofundamento no uso de comandos como useradd, groupadd, gpasswd e passwd para a criação e manipulação de usuários e grupos, incluindo a definição de senhas e atribuição a grupos.
* Controle de Permissões (chmod e chown): Compreensão prática da importância e do funcionamento do chmod para definir permissões de acesso (leitura, escrita, execução) e do chown para alterar o proprietário e o grupo de arquivos e diretórios.
* Princípio do Menor Privilégio: Implementação da prática de conceder apenas as permissões necessárias, garantindo que cada grupo de usuários tenha acesso somente aos recursos que lhes são pertinentes, aumentando a segurança do sistema.
* Idempotência (implícita): Embora não explicitamente focada na idempotência perfeita, a estrutura do script permite que ele seja executado múltiplas vezes sem causar efeitos colaterais indesejados graves (como duplicar usuários, pois os comandos verificarão a existência antes de criar, embora algumas mensagens de erro possam aparecer).
* Organização de Código: A estruturação do script em etapas lógicas, com mensagens de progresso, facilita a leitura e o entendimento do fluxo de execução.
## 🎓 Digital Innovation One (DIO)
Este projeto é um resultado do curso Infraestrutura como Código oferecido pela Digital Innovation One.
## 🤝 Contribuições
Este projeto é um desafio de curso, mas se você tiver sugestões de melhorias ou encontrou algum problema, sinta-se à vontade para abrir uma issue ou enviar um pull request.
